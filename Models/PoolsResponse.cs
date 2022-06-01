// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AddNode
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class AutoCompactionSettings
    {
        [JsonProperty("databaseFragmentationThreshold")]
        public DatabaseFragmentationThreshold DatabaseFragmentationThreshold { get; set; }

        [JsonProperty("parallelDBAndViewCompaction")]
        public bool ParallelDBAndViewCompaction { get; set; }

        [JsonProperty("viewFragmentationThreshold")]
        public ViewFragmentationThreshold ViewFragmentationThreshold { get; set; }
    }

    public class Buckets
    {
        [JsonProperty("terseBucketsBase")]
        public string TerseBucketsBase { get; set; }

        [JsonProperty("terseStreamingBucketsBase")]
        public string TerseStreamingBucketsBase { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ClusterLogsCollection
    {
        [JsonProperty("cancelURI")]
        public string CancelURI { get; set; }

        [JsonProperty("startURI")]
        public string StartURI { get; set; }
    }

    public class Controllers
    {
        [JsonProperty("addNode")]
        public AddNode AddNode { get; set; }

        [JsonProperty("clusterLogsCollection")]
        public ClusterLogsCollection ClusterLogsCollection { get; set; }

        [JsonProperty("ejectNode")]
        public EjectNode EjectNode { get; set; }

        [JsonProperty("failOver")]
        public FailOver FailOver { get; set; }

        [JsonProperty("reAddNode")]
        public ReAddNode ReAddNode { get; set; }

        [JsonProperty("reFailOver")]
        public ReFailOver ReFailOver { get; set; }

        [JsonProperty("rebalance")]
        public Rebalance Rebalance { get; set; }

        [JsonProperty("replication")]
        public Replication Replication { get; set; }

        [JsonProperty("setAutoCompaction")]
        public SetAutoCompaction SetAutoCompaction { get; set; }

        [JsonProperty("setFastWarmup")]
        public SetFastWarmup SetFastWarmup { get; set; }

        [JsonProperty("setRecoveryType")]
        public SetRecoveryType SetRecoveryType { get; set; }

        [JsonProperty("startGracefulFailover")]
        public StartGracefulFailover StartGracefulFailover { get; set; }
    }

    public class Counters
    {
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

    public class FailOver
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class FastWarmupSettings
    {
        [JsonProperty("fastWarmupEnabled")]
        public bool FastWarmupEnabled { get; set; }

        [JsonProperty("minItemsThreshold")]
        public int MinItemsThreshold { get; set; }

        [JsonProperty("minMemoryThreshold")]
        public int MinMemoryThreshold { get; set; }
    }

    public class Hdd
    {
        [JsonProperty("free")]
        public long Free { get; set; }

        [JsonProperty("quotaTotal")]
        public long QuotaTotal { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("used")]
        public long Used { get; set; }

        [JsonProperty("usedByData")]
        public int UsedByData { get; set; }
    }

    public class InterestingStats
    {
        [JsonProperty("cmd_get")]
        public int CmdGet { get; set; }

        [JsonProperty("couch_docs_actual_disk_size")]
        public int CouchDocsActualDiskSize { get; set; }

        [JsonProperty("couch_docs_data_size")]
        public int CouchDocsDataSize { get; set; }

        [JsonProperty("couch_views_actual_disk_size")]
        public int CouchViewsActualDiskSize { get; set; }

        [JsonProperty("couch_views_data_size")]
        public int CouchViewsDataSize { get; set; }

        [JsonProperty("curr_items")]
        public int CurrItems { get; set; }

        [JsonProperty("curr_items_tot")]
        public int CurrItemsTot { get; set; }

        [JsonProperty("ep_bg_fetched")]
        public int EpBgFetched { get; set; }

        [JsonProperty("get_hits")]
        public int GetHits { get; set; }

        [JsonProperty("mem_used")]
        public int MemUsed { get; set; }

        [JsonProperty("ops")]
        public int Ops { get; set; }

        [JsonProperty("vb_replica_curr_items")]
        public int VbReplicaCurrItems { get; set; }
    }

    public class Node
    {
        [JsonProperty("clusterCompatibility")]
        public int ClusterCompatibility { get; set; }

        [JsonProperty("clusterMembership")]
        public string ClusterMembership { get; set; }

        [JsonProperty("couchApiBase")]
        public string CouchApiBase { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("interestingStats")]
        public InterestingStats InterestingStats { get; set; }

        [JsonProperty("mcdMemoryAllocated")]
        public int McdMemoryAllocated { get; set; }

        [JsonProperty("mcdMemoryReserved")]
        public int McdMemoryReserved { get; set; }

        [JsonProperty("memoryFree")]
        public long MemoryFree { get; set; }

        [JsonProperty("memoryTotal")]
        public long MemoryTotal { get; set; }

        [JsonProperty("os")]
        public string Os { get; set; }

        [JsonProperty("otpCookie")]
        public string OtpCookie { get; set; }

        [JsonProperty("otpNode")]
        public string OtpNode { get; set; }

        [JsonProperty("ports")]
        public Ports Ports { get; set; }

        [JsonProperty("recoveryType")]
        public string RecoveryType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("systemStats")]
        public SystemStats SystemStats { get; set; }

        [JsonProperty("thisNode")]
        public bool ThisNode { get; set; }

        [JsonProperty("uptime")]
        public string Uptime { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class Ports
    {
        [JsonProperty("direct")]
        public int Direct { get; set; }

        [JsonProperty("httpsCAPI")]
        public int HttpsCAPI { get; set; }

        [JsonProperty("httpsMgmt")]
        public int HttpsMgmt { get; set; }

        [JsonProperty("proxy")]
        public int Proxy { get; set; }

        [JsonProperty("sslProxy")]
        public int SslProxy { get; set; }
    }

    public class Ram
    {
        [JsonProperty("quotaTotal")]
        public int QuotaTotal { get; set; }

        [JsonProperty("quotaTotalPerNode")]
        public int QuotaTotalPerNode { get; set; }

        [JsonProperty("quotaUsed")]
        public int QuotaUsed { get; set; }

        [JsonProperty("quotaUsedPerNode")]
        public int QuotaUsedPerNode { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("used")]
        public long Used { get; set; }

        [JsonProperty("usedByData")]
        public int UsedByData { get; set; }
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
        [JsonProperty("alerts")]
        public List<object> Alerts { get; set; }

        [JsonProperty("alertsSilenceURL")]
        public string AlertsSilenceURL { get; set; }

        [JsonProperty("autoCompactionSettings")]
        public AutoCompactionSettings AutoCompactionSettings { get; set; }

        [JsonProperty("buckets")]
        public Buckets Buckets { get; set; }

        [JsonProperty("controllers")]
        public Controllers Controllers { get; set; }

        [JsonProperty("counters")]
        public Counters Counters { get; set; }

        [JsonProperty("fastWarmupSettings")]
        public FastWarmupSettings FastWarmupSettings { get; set; }

        [JsonProperty("maxBucketCount")]
        public int MaxBucketCount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nodeStatusesUri")]
        public string NodeStatusesUri { get; set; }

        [JsonProperty("nodes")]
        public List<Node> Nodes { get; set; }

        [JsonProperty("rebalanceProgressUri")]
        public string RebalanceProgressUri { get; set; }

        [JsonProperty("rebalanceStatus")]
        public string RebalanceStatus { get; set; }

        [JsonProperty("remoteClusters")]
        public RemoteClusters RemoteClusters { get; set; }

        [JsonProperty("serverGroupsUri")]
        public string ServerGroupsUri { get; set; }

        [JsonProperty("stopRebalanceUri")]
        public string StopRebalanceUri { get; set; }

        [JsonProperty("storageTotals")]
        public StorageTotals StorageTotals { get; set; }

        [JsonProperty("tasks")]
        public Tasks Tasks { get; set; }

        [JsonProperty("visualSettingsUri")]
        public string VisualSettingsUri { get; set; }
    }

    public class SetAutoCompaction
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("validateURI")]
        public string ValidateURI { get; set; }
    }

    public class SetFastWarmup
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
        [JsonProperty("hdd")]
        public Hdd Hdd { get; set; }

        [JsonProperty("ram")]
        public Ram Ram { get; set; }
    }

    public class SystemStats
    {
        [JsonProperty("cpu_utilization_rate")]
        public double CpuUtilizationRate { get; set; }

        [JsonProperty("mem_free")]
        public long MemFree { get; set; }

        [JsonProperty("mem_total")]
        public long MemTotal { get; set; }

        [JsonProperty("swap_total")]
        public long SwapTotal { get; set; }

        [JsonProperty("swap_used")]
        public int SwapUsed { get; set; }
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

