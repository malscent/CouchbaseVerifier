// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AddNode
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class AutoCompactionSettings
    {
        [JsonProperty("parallelDBAndViewCompaction")]
        public bool ParallelDBAndViewCompaction { get; set; }

        [JsonProperty("databaseFragmentationThreshold")]
        public DatabaseFragmentationThreshold DatabaseFragmentationThreshold { get; set; }

        [JsonProperty("viewFragmentationThreshold")]
        public ViewFragmentationThreshold ViewFragmentationThreshold { get; set; }

        [JsonProperty("indexCompactionMode")]
        public string IndexCompactionMode { get; set; }

        [JsonProperty("indexCircularCompaction")]
        public IndexCircularCompaction IndexCircularCompaction { get; set; }

        [JsonProperty("indexFragmentationThreshold")]
        public IndexFragmentationThreshold IndexFragmentationThreshold { get; set; }
    }

    public class BucketName
    {
        [JsonProperty("bucketName")]
        public string BucketName { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class Buckets
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("terseBucketsBase")]
        public string TerseBucketsBase { get; set; }

        [JsonProperty("terseStreamingBucketsBase")]
        public string TerseStreamingBucketsBase { get; set; }
    }

    public class ClusterLogsCollection
    {
        [JsonProperty("startURI")]
        public string StartURI { get; set; }

        [JsonProperty("cancelURI")]
        public string CancelURI { get; set; }
    }

    public class Controllers
    {
        [JsonProperty("addNode")]
        public AddNode AddNode { get; set; }

        [JsonProperty("rebalance")]
        public Rebalance Rebalance { get; set; }

        [JsonProperty("failOver")]
        public FailOver FailOver { get; set; }

        [JsonProperty("startGracefulFailover")]
        public StartGracefulFailover StartGracefulFailover { get; set; }

        [JsonProperty("reAddNode")]
        public ReAddNode ReAddNode { get; set; }

        [JsonProperty("reFailOver")]
        public ReFailOver ReFailOver { get; set; }

        [JsonProperty("ejectNode")]
        public EjectNode EjectNode { get; set; }

        [JsonProperty("setRecoveryType")]
        public SetRecoveryType SetRecoveryType { get; set; }

        [JsonProperty("setAutoCompaction")]
        public SetAutoCompaction SetAutoCompaction { get; set; }

        [JsonProperty("clusterLogsCollection")]
        public ClusterLogsCollection ClusterLogsCollection { get; set; }

        [JsonProperty("replication")]
        public Replication Replication { get; set; }
    }

    public class Counters
    {
        [JsonProperty("rebalance_success")]
        public int RebalanceSuccess { get; set; }

        [JsonProperty("rebalance_start")]
        public int RebalanceStart { get; set; }
    }

    public class DatabaseFragmentationThreshold
    {
        [JsonProperty("percentage")]
        public int Percentage { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }
    }

    public class EjectNode
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ExternalListener
    {
        [JsonProperty("afamily")]
        public string Afamily { get; set; }

        [JsonProperty("nodeEncryption")]
        public bool NodeEncryption { get; set; }
    }

    public class FailOver
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class Hdd
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("quotaTotal")]
        public long QuotaTotal { get; set; }

        [JsonProperty("used")]
        public long Used { get; set; }

        [JsonProperty("usedByData")]
        public int UsedByData { get; set; }

        [JsonProperty("free")]
        public long Free { get; set; }
    }

    public class IndexCircularCompaction
    {
        [JsonProperty("daysOfWeek")]
        public string DaysOfWeek { get; set; }

        [JsonProperty("interval")]
        public Interval Interval { get; set; }
    }

    public class IndexFragmentationThreshold
    {
        [JsonProperty("percentage")]
        public int Percentage { get; set; }
    }

    public class InterestingStats
    {
        [JsonProperty("couch_docs_actual_disk_size")]
        public int CouchDocsActualDiskSize { get; set; }

        [JsonProperty("couch_views_actual_disk_size")]
        public int CouchViewsActualDiskSize { get; set; }

        [JsonProperty("curr_items")]
        public int CurrItems { get; set; }

        [JsonProperty("curr_items_tot")]
        public int CurrItemsTot { get; set; }

        [JsonProperty("ep_bg_fetched")]
        public int EpBgFetched { get; set; }

        [JsonProperty("couch_docs_data_size")]
        public int CouchDocsDataSize { get; set; }

        [JsonProperty("mem_used")]
        public int MemUsed { get; set; }

        [JsonProperty("vb_replica_curr_items")]
        public int VbReplicaCurrItems { get; set; }

        [JsonProperty("vb_active_num_non_resident")]
        public int VbActiveNumNonResident { get; set; }

        [JsonProperty("cmd_get")]
        public int CmdGet { get; set; }

        [JsonProperty("get_hits")]
        public int GetHits { get; set; }

        [JsonProperty("ops")]
        public int Ops { get; set; }

        [JsonProperty("index_data_size")]
        public int IndexDataSize { get; set; }

        [JsonProperty("index_disk_size")]
        public int IndexDiskSize { get; set; }

        [JsonProperty("couch_spatial_disk_size")]
        public int CouchSpatialDiskSize { get; set; }

        [JsonProperty("couch_views_data_size")]
        public int CouchViewsDataSize { get; set; }

        [JsonProperty("couch_spatial_data_size")]
        public int CouchSpatialDataSize { get; set; }
    }

    public class Interval
    {
        [JsonProperty("fromHour")]
        public int FromHour { get; set; }

        [JsonProperty("toHour")]
        public int ToHour { get; set; }

        [JsonProperty("fromMinute")]
        public int FromMinute { get; set; }

        [JsonProperty("toMinute")]
        public int ToMinute { get; set; }

        [JsonProperty("abortOutside")]
        public bool AbortOutside { get; set; }
    }

    public class Node
    {
        [JsonProperty("clusterMembership")]
        public string ClusterMembership { get; set; }

        [JsonProperty("recoveryType")]
        public string RecoveryType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("otpNode")]
        public string OtpNode { get; set; }

        [JsonProperty("thisNode")]
        public bool ThisNode { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("nodeUUID")]
        public string NodeUUID { get; set; }

        [JsonProperty("clusterCompatibility")]
        public int ClusterCompatibility { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("os")]
        public string Os { get; set; }

        [JsonProperty("cpuCount")]
        public int CpuCount { get; set; }

        [JsonProperty("ports")]
        public Ports Ports { get; set; }

        [JsonProperty("services")]
        public List<string> Services { get; set; }

        [JsonProperty("nodeEncryption")]
        public bool NodeEncryption { get; set; }

        [JsonProperty("addressFamilyOnly")]
        public bool AddressFamilyOnly { get; set; }

        [JsonProperty("configuredHostname")]
        public string ConfiguredHostname { get; set; }

        [JsonProperty("addressFamily")]
        public string AddressFamily { get; set; }

        [JsonProperty("externalListeners")]
        public List<ExternalListener> ExternalListeners { get; set; }

        [JsonProperty("couchApiBase")]
        public string CouchApiBase { get; set; }

        [JsonProperty("couchApiBaseHTTPS")]
        public string CouchApiBaseHTTPS { get; set; }

        [JsonProperty("systemStats")]
        public SystemStats SystemStats { get; set; }

        [JsonProperty("interestingStats")]
        public InterestingStats InterestingStats { get; set; }

        [JsonProperty("uptime")]
        public string Uptime { get; set; }

        [JsonProperty("memoryTotal")]
        public int MemoryTotal { get; set; }

        [JsonProperty("memoryFree")]
        public int MemoryFree { get; set; }

        [JsonProperty("mcdMemoryReserved")]
        public int McdMemoryReserved { get; set; }

        [JsonProperty("mcdMemoryAllocated")]
        public int McdMemoryAllocated { get; set; }
    }

    public class Ports
    {
        [JsonProperty("direct")]
        public int Direct { get; set; }

        [JsonProperty("httpsCAPI")]
        public int HttpsCAPI { get; set; }

        [JsonProperty("httpsMgmt")]
        public int HttpsMgmt { get; set; }

        [JsonProperty("distTCP")]
        public int DistTCP { get; set; }

        [JsonProperty("distTLS")]
        public int DistTLS { get; set; }
    }

    public class Ram
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("quotaTotal")]
        public int QuotaTotal { get; set; }

        [JsonProperty("quotaUsed")]
        public int QuotaUsed { get; set; }

        [JsonProperty("used")]
        public int Used { get; set; }

        [JsonProperty("usedByData")]
        public int UsedByData { get; set; }

        [JsonProperty("quotaUsedPerNode")]
        public int QuotaUsedPerNode { get; set; }

        [JsonProperty("quotaTotalPerNode")]
        public int QuotaTotalPerNode { get; set; }
    }

    public class ReAddNode
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class Rebalance
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ReFailOver
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class RemoteClusters
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("validateURI")]
        public string ValidateURI { get; set; }
    }

    public class Replication
    {
        [JsonProperty("createURI")]
        public string CreateURI { get; set; }

        [JsonProperty("validateURI")]
        public string ValidateURI { get; set; }
    }

    public class Root
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nodes")]
        public List<Node> Nodes { get; set; }

        [JsonProperty("buckets")]
        public Buckets Buckets { get; set; }

        [JsonProperty("bucketNames")]
        public List<BucketName> BucketNames { get; set; }

        [JsonProperty("remoteClusters")]
        public RemoteClusters RemoteClusters { get; set; }

        [JsonProperty("alerts")]
        public List<object> Alerts { get; set; }

        [JsonProperty("alertsSilenceURL")]
        public string AlertsSilenceURL { get; set; }

        [JsonProperty("controllers")]
        public Controllers Controllers { get; set; }

        [JsonProperty("rebalanceStatus")]
        public string RebalanceStatus { get; set; }

        [JsonProperty("rebalanceProgressUri")]
        public string RebalanceProgressUri { get; set; }

        [JsonProperty("stopRebalanceUri")]
        public string StopRebalanceUri { get; set; }

        [JsonProperty("nodeStatusesUri")]
        public string NodeStatusesUri { get; set; }

        [JsonProperty("maxBucketCount")]
        public int MaxBucketCount { get; set; }

        [JsonProperty("maxCollectionCount")]
        public int MaxCollectionCount { get; set; }

        [JsonProperty("maxScopeCount")]
        public int MaxScopeCount { get; set; }

        [JsonProperty("autoCompactionSettings")]
        public AutoCompactionSettings AutoCompactionSettings { get; set; }

        [JsonProperty("tasks")]
        public Tasks Tasks { get; set; }

        [JsonProperty("counters")]
        public Counters Counters { get; set; }

        [JsonProperty("indexStatusURI")]
        public string IndexStatusURI { get; set; }

        [JsonProperty("serverGroupsUri")]
        public string ServerGroupsUri { get; set; }

        [JsonProperty("clusterName")]
        public string ClusterName { get; set; }

        [JsonProperty("balanced")]
        public bool Balanced { get; set; }

        [JsonProperty("checkPermissionsURI")]
        public string CheckPermissionsURI { get; set; }

        [JsonProperty("memoryQuota")]
        public int MemoryQuota { get; set; }

        [JsonProperty("indexMemoryQuota")]
        public int IndexMemoryQuota { get; set; }

        [JsonProperty("ftsMemoryQuota")]
        public int FtsMemoryQuota { get; set; }

        [JsonProperty("cbasMemoryQuota")]
        public int CbasMemoryQuota { get; set; }

        [JsonProperty("eventingMemoryQuota")]
        public int EventingMemoryQuota { get; set; }

        [JsonProperty("storageTotals")]
        public StorageTotals StorageTotals { get; set; }
    }

    public class SetAutoCompaction
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("validateURI")]
        public string ValidateURI { get; set; }
    }

    public class SetRecoveryType
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class StartGracefulFailover
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class StorageTotals
    {
        [JsonProperty("ram")]
        public Ram Ram { get; set; }

        [JsonProperty("hdd")]
        public Hdd Hdd { get; set; }
    }

    public class SystemStats
    {
        [JsonProperty("cpu_utilization_rate")]
        public double CpuUtilizationRate { get; set; }

        [JsonProperty("cpu_stolen_rate")]
        public int CpuStolenRate { get; set; }

        [JsonProperty("swap_total")]
        public int SwapTotal { get; set; }

        [JsonProperty("swap_used")]
        public int SwapUsed { get; set; }

        [JsonProperty("mem_total")]
        public int MemTotal { get; set; }

        [JsonProperty("mem_free")]
        public int MemFree { get; set; }

        [JsonProperty("mem_limit")]
        public int MemLimit { get; set; }

        [JsonProperty("cpu_cores_available")]
        public int CpuCoresAvailable { get; set; }

        [JsonProperty("allocstall")]
        public int Allocstall { get; set; }
    }

    public class Tasks
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ViewFragmentationThreshold
    {
        [JsonProperty("percentage")]
        public int Percentage { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }
    }

