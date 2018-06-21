using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OracleDbCrawler.Attributes;

namespace OracleDbCrawler.ObjectEntity
{
  
    [TableNameAttribute("ALL_OBJECTS")]
    public class DbObject
    {
        [Column("OWNER")]
        public String Owner { get; set; }
        [Column("OBJECT_NAME")]
        public String ObjectName { get; set; }
        [Column("SUBOBJECT_NAME")]
        public String SubobjectName { get; set; }
        [Column("OBJECT_ID")]
        public decimal ObjectId { get; set; }
        [Column("DATA_OBJECT_ID")]
        public decimal DataObjectId { get; set; }
        [Column("OBJECT_TYPE")]
        public String ObjectType { get; set; }
        [Column("CREATED")]
        public DateTime Created { get; set; }
        [Column("LAST_DDL_TIME")]
        public DateTime LastDdlTime { get; set; }
        [Column("TIMESTAMP")]
        public String Timestamp { get; set; }
        [Column("STATUS")]
        public String Status { get; set; }
        [Column("TEMPORARY")]
        public String Temporary { get; set; }
        [Column("GENERATED")]
        public String Generated { get; set; }
        [Column("SECONDARY")]
        public String Secondary { get; set; }
        [Column("NAMESPACE")]
        public decimal Namespace { get; set; }
        [Column("EDITION_NAME")]
        public String EditionName { get; set; }
        [Column("SHARING")]
        public String Sharing { get; set; }
        [Column("EDITIONABLE")]
        public String Editionable { get; set; }
        [Column("ORACLE_MAINTAINED")]
        public String OracleMaintained { get; set; }
    }

}
