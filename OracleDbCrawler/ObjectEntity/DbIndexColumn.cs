using OracleDbCrawler.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleDbCrawler.ObjectEntity
{
    [TableNameAttribute("ALL_IND_COLUMNS")]
    public class DbIndexColumn
    {
        [Column("INDEX_OWNER")]
        public String IndexOwner { get; set; }
        [Column("INDEX_NAME")]
        public String IndexName { get; set; }
        [Column("TABLE_OWNER")]
        public String TableOwner { get; set; }
        [Column("TABLE_NAME")]
        public String TableName { get; set; }
        [Column("COLUMN_NAME")]
        public String ColumnName { get; set; }
        [Column("COLUMN_POSITION")]
        public decimal ColumnPosition { get; set; }
        [Column("COLUMN_LENGTH")]
        public decimal ColumnLength { get; set; }
        [Column("CHAR_LENGTH")]
        public decimal CharLength { get; set; }
        [Column("DESCEND")]
        public String Descend { get; set; }
    }

}
