using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleDbCrawler.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ColumnAttribute : Attribute
    {
        public ColumnAttribute(String ColumnName, string DbTypeString = "")
        {
            this.DbTypeString = DbTypeString;
            this.ColumnName = ColumnName;
        }
        public string ColumnName { get; set; }
        public String DbTypeString { get; set; }
    }
}
