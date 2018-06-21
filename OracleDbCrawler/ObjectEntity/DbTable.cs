using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OracleDbCrawler.Attributes;

namespace OracleDbCrawler.ObjectEntity
{
   
 
    [TableNameAttribute("ALL_TABLES")]
    public class DbTable
    {
        [Column("OWNER")]
        public String Owner { get; set; }
        [Column("TABLE_NAME")]
        public String TableName { get; set; }
        [Column("TABLESPACE_NAME")]
        public String TablespaceName { get; set; }
        [Column("CLUSTER_NAME")]
        public String ClusterName { get; set; }
        [Column("IOT_NAME")]
        public String IotName { get; set; }
        [Column("STATUS")]
        public String Status { get; set; }
        [Column("PCT_FREE")]
        public decimal PctFree { get; set; }
        [Column("PCT_USED")]
        public decimal PctUsed { get; set; }
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
        [Column("FREELISTS")]
        public decimal Freelists { get; set; }
        [Column("FREELIST_GROUPS")]
        public decimal FreelistGroups { get; set; }
        [Column("LOGGING")]
        public String Logging { get; set; }
        [Column("BACKED_UP")]
        public String BackedUp { get; set; }
        [Column("NUM_ROWS")]
        public decimal NumRows { get; set; }
        [Column("BLOCKS")]
        public decimal Blocks { get; set; }
        [Column("EMPTY_BLOCKS")]
        public decimal EmptyBlocks { get; set; }
        [Column("AVG_SPACE")]
        public decimal AvgSpace { get; set; }
        [Column("CHAIN_CNT")]
        public decimal ChainCnt { get; set; }
        [Column("AVG_ROW_LEN")]
        public decimal AvgRowLen { get; set; }
        [Column("AVG_SPACE_FREELIST_BLOCKS")]
        public decimal AvgSpaceFreelistBlocks { get; set; }
        [Column("NUM_FREELIST_BLOCKS")]
        public decimal NumFreelistBlocks { get; set; }
        [Column("DEGREE")]
        public String Degree { get; set; }
        [Column("INSTANCES")]
        public String Instances { get; set; }
        [Column("CACHE")]
        public String Cache { get; set; }
        [Column("TABLE_LOCK")]
        public String TableLock { get; set; }
        [Column("SAMPLE_SIZE")]
        public decimal SampleSize { get; set; }
        [Column("LAST_ANALYZED")]
        public DateTime LastAnalyzed { get; set; }
        [Column("PARTITIONED")]
        public String Partitioned { get; set; }
        [Column("IOT_TYPE")]
        public String IotType { get; set; }
        [Column("TEMPORARY")]
        public String Temporary { get; set; }
        [Column("SECONDARY")]
        public String Secondary { get; set; }
        [Column("NESTED")]
        public String Nested { get; set; }
        [Column("BUFFER_POOL")]
        public String BufferPool { get; set; }
        [Column("FLASH_CACHE")]
        public String FlashCache { get; set; }
        [Column("CELL_FLASH_CACHE")]
        public String CellFlashCache { get; set; }
        [Column("ROW_MOVEMENT")]
        public String RowMovement { get; set; }
        [Column("GLOBAL_STATS")]
        public String GlobalStats { get; set; }
        [Column("USER_STATS")]
        public String UserStats { get; set; }
        [Column("DURATION")]
        public String Duration { get; set; }
        [Column("SKIP_CORRUPT")]
        public String SkipCorrupt { get; set; }
        [Column("MONITORING")]
        public String Monitoring { get; set; }
        [Column("CLUSTER_OWNER")]
        public String ClusterOwner { get; set; }
        [Column("DEPENDENCIES")]
        public String Dependencies { get; set; }
        [Column("COMPRESSION")]
        public String Compression { get; set; }
        [Column("COMPRESS_FOR")]
        public String CompressFor { get; set; }
        [Column("DROPPED")]
        public String Dropped { get; set; }
        [Column("READ_ONLY")]
        public String ReadOnly { get; set; }
        [Column("SEGMENT_CREATED")]
        public String SegmentCreated { get; set; }
        [Column("RESULT_CACHE")]
        public String ResultCache { get; set; }
        [Column("CLUSTERING")]
        public String Clustering { get; set; }
        [Column("ACTIVITY_TRACKING")]
        public String ActivityTracking { get; set; }
        [Column("DML_TIMESTAMP")]
        public String DmlTimestamp { get; set; }
        [Column("HAS_IDENTITY")]
        public String HasIdentity { get; set; }
        [Column("CONTAINER_DATA")]
        public String ContainerData { get; set; }
        [Column("INMEMORY")]
        public String Inmemory { get; set; }
        [Column("INMEMORY_PRIORITY")]
        public String InmemoryPriority { get; set; }
        [Column("INMEMORY_DISTRIBUTE")]
        public String InmemoryDistribute { get; set; }
        [Column("INMEMORY_COMPRESSION")]
        public String InmemoryCompression { get; set; }
        [Column("INMEMORY_DUPLICATE")]
        public String InmemoryDuplicate { get; set; }
    }


}
