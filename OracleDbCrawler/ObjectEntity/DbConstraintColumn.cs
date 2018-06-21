using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OracleDbCrawler.Attributes;

namespace OracleDbCrawler.ObjectEntity
{

    [TableNameAttribute("ALL_CONS_COLUMNS")]
    public class DbConstraintColumn
    {
        [Column("OWNER")]
        public String Owner { get; set; }
        [Column("CONSTRAINT_NAME")]
        public String ConstraintName { get; set; }
        [Column("TABLE_NAME")]
        public String TableName { get; set; }
        [Column("COLUMN_NAME")]
        public String ColumnName { get; set; }
        [Column("POSITION")]
        public decimal Position { get; set; }
    }

}
