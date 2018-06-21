using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OracleDbCrawler.Attributes;

namespace OracleDbCrawler.ObjectEntity
{
   
    [TableNameAttribute("ALL_CONSTRAINTS")]
    public class DbConstraint
    {
        [Column("OWNER")]
        public String Owner { get; set; }
        [Column("CONSTRAINT_NAME")]
        public String ConstraintName { get; set; }
        [Column("CONSTRAINT_TYPE")]
        public String ConstraintType { get; set; }
        [Column("TABLE_NAME")]
        public String TableName { get; set; }
        [Column("SEARCH_CONDITION")]
        public long SearchCondition { get; set; }
        [Column("SEARCH_CONDITION_VC")]
        public String SearchConditionVc { get; set; }
        [Column("R_OWNER")]
        public String ROwner { get; set; }
        [Column("R_CONSTRAINT_NAME")]
        public String RConstraintName { get; set; }
        [Column("DELETE_RULE")]
        public String DeleteRule { get; set; }
        [Column("STATUS")]
        public String Status { get; set; }
        [Column("DEFERRABLE")]
        public String Deferrable { get; set; }
        [Column("DEFERRED")]
        public String Deferred { get; set; }
        [Column("VALIDATED")]
        public String Validated { get; set; }
        [Column("GENERATED")]
        public String Generated { get; set; }
        [Column("BAD")]
        public String Bad { get; set; }
        [Column("RELY")]
        public String Rely { get; set; }
        [Column("LAST_CHANGE")]
        public DateTime LastChange { get; set; }
        [Column("INDEX_OWNER")]
        public String IndexOwner { get; set; }
        [Column("INDEX_NAME")]
        public String IndexName { get; set; }
        [Column("INVALID")]
        public String Invalid { get; set; }
        [Column("VIEW_RELATED")]
        public String ViewRelated { get; set; }
        [Column("ORIGIN_CON_ID")]
        public decimal OriginConId { get; set; }
    }

}
