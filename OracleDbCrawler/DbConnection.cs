using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using OracleDbCrawler.Attributes;

namespace OracleDbCrawler
{
    public class DbConnection
    {
        public static List<DbConnection> FromTNS(String tnsFile)
        {
            return null;
        }
        public static DbConnection CreateConnectionString(String connectionString)
        {
            return new DbConnection(connectionString);
        }

        private DbConnection(String connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }
        public OracleConnection Conn { get
            {
                return new OracleConnection(ConnectionString);
            }
        }

        public  IEnumerable<object> GetTable(String owner, String entityName, String condition)
        {
            List<object> results = new List<object>();
            String whereClause = " WHERE ";
            if (String.IsNullOrEmpty(condition))
            {
                whereClause = "";
            }
            else
            {
                whereClause += condition;
            }
            Assembly datacontractAssembly = this.GetType().Assembly;

            Type entityType = datacontractAssembly.GetType("OracleDbCrawler.ObjectEntity." + entityName);
            if (entityType == null)
            {
                foreach (Type t in datacontractAssembly.GetTypes())
                {
                    //Logging.WriteLog(t.Name);
                }

            }

            object[] tableAttributes = entityType.GetCustomAttributes(typeof(TableNameAttribute), false);
            String tableName = "";
            if (tableAttributes == null || tableAttributes.Count() != 1)
            {
                return null;
            }

            tableName = (tableAttributes.First() as TableNameAttribute).TableName;
            OracleConnection conn = Conn;

            OracleCommand cmd = new OracleCommand(String.Format("SELECT * FROM {0}.{1}{2}", owner,tableName, whereClause), conn);
            cmd.InitialLONGFetchSize = 1;
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var item = Activator.CreateInstance(entityType);
                    for (int colIndex = 0; colIndex < reader.FieldCount; colIndex++)
                    {
                        string columnname = reader.GetName(colIndex);
                        PropertyInfo pi = entityType.GetProperties().ToList().Find(p =>
                        {
                            ColumnAttribute[] columns = p.GetCustomAttributes(typeof(ColumnAttribute), false) as ColumnAttribute[];
                            if (columns == null || columns.Count() == 0) return false;
                            if (columns[0].ColumnName == columnname)
                            {
                                return true;
                            }
                            return false;
                        });
                        if (!reader.IsDBNull(colIndex))
                        {
                            switch (reader.GetDataTypeName(colIndex))
                            {
                                case "Decimal": pi.SetValue(item, reader.GetDecimal(colIndex), null); break;
                                case "Date": pi.SetValue(item, reader.GetDateTime(colIndex), null); break;
                                case "Varchar2": pi.SetValue(item, reader.GetString(colIndex), null); break;
                                case "Raw":
                                    byte[] data = new byte[16];
                                    reader.GetBytes(colIndex, 0, data, 0, 16);
                                    pi.SetValue(item,data, null); break;
                                case "NVarchar2": pi.SetValue(item, reader.GetString(colIndex), null); break;
                                case "Clob": pi.SetValue(item, reader.GetOracleClob(colIndex).Value, null); break;
                                case "Char": pi.SetValue(item, reader.GetString(colIndex), null); break;
                                case "Int16": pi.SetValue(item, reader.GetDecimal(colIndex), null); break;
                                case "Int64": pi.SetValue(item, reader.GetInt64(colIndex), null); break;
                                default:break; 
                            }
                        }
                    }
                    results.Add(item);
                }
            }
            catch (Exception ex)
            {
               // ex.Log();
            }
            finally
            {
                conn.Close();
            }
            return results;
        }

        #region Get Table Properties



        #endregion
    }
}
