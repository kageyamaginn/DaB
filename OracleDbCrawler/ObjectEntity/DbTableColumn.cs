using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OracleDbCrawler.Attributes;

namespace OracleDbCrawler.ObjectEntity
{

    [TableNameAttribute("ALL_TAB_COLUMNS")]
    public class DbTableColumn
    {
        [Column("OWNER")]
        public String Owner { get; set; }
        [Column("TABLE_NAME")]
        public String TableName { get; set; }
        [Column("COLUMN_NAME")]
        public String ColumnName { get; set; }
        [Column("DATA_TYPE")]
        public String DataType { get; set; }
        [Column("DATA_TYPE_MOD")]
        public String DataTypeMod { get; set; }
        [Column("DATA_TYPE_OWNER")]
        public String DataTypeOwner { get; set; }
        [Column("DATA_LENGTH")]
        public decimal DataLength { get; set; }
        [Column("DATA_PRECISION")]
        public decimal DataPrecision { get; set; }
        [Column("DATA_SCALE")]
        public decimal DataScale { get; set; }
        [Column("NULLABLE")]
        public String Nullable { get; set; }
        [Column("COLUMN_ID")]
        public decimal ColumnId { get; set; }
        [Column("DEFAULT_LENGTH")]
        public decimal DefaultLength { get; set; }
        [Column("DATA_DEFAULT")]
        public long DataDefault { get; set; }
        [Column("NUM_DISTINCT")]
        public decimal NumDistinct { get; set; }
        [Column("LOW_VALUE")]
        public byte[] LowValue { get; set; }
        [Column("HIGH_VALUE")]
        public byte[] HighValue { get; set; }
        [Column("DENSITY")]
        public decimal Density { get; set; }
        [Column("NUM_NULLS")]
        public decimal NumNulls { get; set; }
        [Column("NUM_BUCKETS")]
        public decimal NumBuckets { get; set; }
        [Column("LAST_ANALYZED")]
        public DateTime LastAnalyzed { get; set; }
        [Column("SAMPLE_SIZE")]
        public decimal SampleSize { get; set; }
        [Column("CHARACTER_SET_NAME")]
        public String CharacterSetName { get; set; }
        [Column("CHAR_COL_DECL_LENGTH")]
        public decimal CharColDeclLength { get; set; }
        [Column("GLOBAL_STATS")]
        public String GlobalStats { get; set; }
        [Column("USER_STATS")]
        public String UserStats { get; set; }
        [Column("AVG_COL_LEN")]
        public decimal AvgColLen { get; set; }
        [Column("CHAR_LENGTH")]
        public decimal CharLength { get; set; }
        [Column("CHAR_USED")]
        public String CharUsed { get; set; }
        [Column("V80_FMT_IMAGE")]
        public String V80FmtImage { get; set; }
        [Column("DATA_UPGRADED")]
        public String DataUpgraded { get; set; }
        [Column("HISTOGRAM")]
        public String Histogram { get; set; }
        [Column("DEFAULT_ON_NULL")]
        public String DefaultOnNull { get; set; }
        [Column("IDENTITY_COLUMN")]
        public String IdentityColumn { get; set; }
        [Column("EVALUATION_EDITION")]
        public String EvaluationEdition { get; set; }
        [Column("UNUSABLE_BEFORE")]
        public String UnusableBefore { get; set; }
        [Column("UNUSABLE_BEGINNING")]
        public String UnusableBeginning { get; set; }
    }

}
