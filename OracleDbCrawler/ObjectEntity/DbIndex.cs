using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OracleDbCrawler.Attributes;

namespace OracleDbCrawler.ObjectEntity
{
  
    [TableNameAttribute("ALL_INDEXES")]
    public class DbIndex
    {
        [Column("OWNER")]
        public String Owner { get; set; }
        [Column("INDEX_NAME")]
        public String IndexName { get; set; }
        [Column("INDEX_TYPE")]
        public String IndexType { get; set; }
        [Column("TABLE_OWNER")]
        public String TableOwner { get; set; }
        [Column("TABLE_NAME")]
        public String TableName { get; set; }
        [Column("TABLE_TYPE")]
        public String TableType { get; set; }
        [Column("UNIQUENESS")]
        public String Uniqueness { get; set; }
        [Column("COMPRESSION")]
        public String Compression { get; set; }
        [Column("PREFIX_LENGTH")]
        public decimal PrefixLength { get; set; }
        [Column("TABLESPACE_NAME")]
        public String TablespaceName { get; set; }
        [Column("INI_TRANS")]
        public decimal IniTrans { get; set; }
        [Column("MAX_TRANS")]
        public decimal MaxTrans { get; set; }
        [Column("INITIAL_EXTENT")]
        public decimal InitialExtent { get; set; }
        [Column("NEXT_EXTENT")]
        public decimal NextExtent { get; set; }
        [Column("MIN_EXTENTS")]
        public decimal MinExtents { get; set; }
        [Column("MAX_EXTENTS")]
        public decimal MaxExtents { get; set; }
        [Column("PCT_INCREASE")]
        public decimal PctIncrease { get; set; }
        [Column("PCT_THRESHOLD")]
        public decimal PctThreshold { get; set; }
        [Column("INCLUDE_COLUMN")]
        public decimal IncludeColumn { get; set; }
        [Column("FREELISTS")]
        public decimal Freelists { get; set; }
        [Column("FREELIST_GROUPS")]
        public decimal FreelistGroups { get; set; }
        [Column("PCT_FREE")]
        public decimal PctFree { get; set; }
        [Column("LOGGING")]
        public String Logging { get; set; }
        [Column("BLEVEL")]
        public decimal Blevel { get; set; }
        [Column("LEAF_BLOCKS")]
        public decimal LeafBlocks { get; set; }
        [Column("DISTINCT_KEYS")]
        public decimal DistinctKeys { get; set; }
        [Column("AVG_LEAF_BLOCKS_PER_KEY")]
        public decimal AvgLeafBlocksPerKey { get; set; }
        [Column("AVG_DATA_BLOCKS_PER_KEY")]
        public decimal AvgDataBlocksPerKey { get; set; }
        [Column("CLUSTERING_FACTOR")]
        public decimal ClusteringFactor { get; set; }
        [Column("STATUS")]
        public String Status { get; set; }
        [Column("NUM_ROWS")]
        public decimal NumRows { get; set; }
        [Column("SAMPLE_SIZE")]
        public decimal SampleSize { get; set; }
        [Column("LAST_ANALYZED")]
        public DateTime LastAnalyzed { get; set; }
        [Column("DEGREE")]
        public String Degree { get; set; }
        [Column("INSTANCES")]
        public String Instances { get; set; }
        [Column("PARTITIONED")]
        public String Partitioned { get; set; }
        [Column("TEMPORARY")]
        public String Temporary { get; set; }
        [Column("GENERATED")]
        public String Generated { get; set; }
        [Column("SECONDARY")]
        public String Secondary { get; set; }
        [Column("BUFFER_POOL")]
        public String BufferPool { get; set; }
        [Column("FLASH_CACHE")]
        public String FlashCache { get; set; }
        [Column("CELL_FLASH_CACHE")]
        public String CellFlashCache { get; set; }
        [Column("USER_STATS")]
        public String UserStats { get; set; }
        [Column("DURATION")]
        public String Duration { get; set; }
        [Column("PCT_DIRECT_ACCESS")]
        public decimal PctDirectAccess { get; set; }
        [Column("ITYP_OWNER")]
        public String ItypOwner { get; set; }
        [Column("ITYP_NAME")]
        public String ItypName { get; set; }
        [Column("PARAMETERS")]
        public String Parameters { get; set; }
        [Column("GLOBAL_STATS")]
        public String GlobalStats { get; set; }
        [Column("DOMIDX_STATUS")]
        public String DomidxStatus { get; set; }
        [Column("DOMIDX_OPSTATUS")]
        public String DomidxOpstatus { get; set; }
        [Column("FUNCIDX_STATUS")]
        public String FuncidxStatus { get; set; }
        [Column("JOIN_INDEX")]
        public String JoinIndex { get; set; }
        [Column("IOT_REDUNDANT_PKEY_ELIM")]
        public String IotRedundantPkeyElim { get; set; }
        [Column("DROPPED")]
        public String Dropped { get; set; }
        [Column("VISIBILITY")]
        public String Visibility { get; set; }
        [Column("DOMIDX_MANAGEMENT")]
        public String DomidxManagement { get; set; }
        [Column("SEGMENT_CREATED")]
        public String SegmentCreated { get; set; }
        [Column("ORPHANED_ENTRIES")]
        public String OrphanedEntries { get; set; }
        [Column("INDEXING")]
        public String Indexing { get; set; }
    }


}
