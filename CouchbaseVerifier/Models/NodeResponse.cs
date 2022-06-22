// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using System.Numerics;
using Newtonsoft.Json;

namespace CouchbaseVerifier.Models
{
    public class AddNode
    {
        [JsonProperty("uri")]
        public string? Uri { get; set; }
    }

    public class AutoCompactionSettings
    {
        [JsonProperty("parallelDBAndViewCompaction")]
        public bool ParallelDBAndViewCompaction { get; set; }

        [JsonProperty("databaseFragmentationThreshold")]
        public DatabaseFragmentationThreshold? DatabaseFragmentationThreshold { get; set; }

        [JsonProperty("viewFragmentationThreshold")]
        public ViewFragmentationThreshold? ViewFragmentationThreshold { get; set; }

        [JsonProperty("indexCompactionMode")]
        public string? IndexCompactionMode { get; set; }

        [JsonProperty("indexCircularCompaction")]
        public IndexCircularCompaction? IndexCircularCompaction { get; set; }

        [JsonProperty("indexFragmentationThreshold")]
        public IndexFragmentationThreshold? IndexFragmentationThreshold { get; set; }
    }

    public class BucketName
    {
        [JsonProperty("bucketName")]
        public string? Name { get; set; }

        [JsonProperty("uuid")]
        public string? Uuid { get; set; }
    }

    public class Buckets
    {
        [JsonProperty("uri")]
        public string? Uri { get; set; }

        [JsonProperty("terseBucketsBase")]
        public string? TerseBucketsBase { get; set; }

        [JsonProperty("terseStreamingBucketsBase")]
        public string? TerseStreamingBucketsBase { get; set; }
    }

    public class ClusterLogsCollection
    {
        [JsonProperty("startURI")]
        public string? StartURI { get; set; }

        [JsonProperty("cancelURI")]
        public string? CancelURI { get; set; }
    }

    public class Counters
    {
        [JsonProperty("rebalance_success")]
        public Int64 RebalanceSuccess { get; set; }

        [JsonProperty("rebalance_start")]
        public Int64 RebalanceStart { get; set; }
    }

    public class DatabaseFragmentationThreshold
    {
        [JsonProperty("percentage")]
        public Int64 Percentage { get; set; }

        [JsonProperty("size")]
        public string? Size { get; set; }
    }

    public class EjectNode
    {
        [JsonProperty("uri")]
        public string? Uri { get; set; }
    }

    public class ExternalListener
    {
        [JsonProperty("afamily")]
        public string? Afamily { get; set; }

        [JsonProperty("nodeEncryption")]
        public bool NodeEncryption { get; set; }
    }

    public class FailOver
    {
        [JsonProperty("uri")]
        public string? Uri { get; set; }
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
        public Int64 UsedByData { get; set; }

        [JsonProperty("free")]
        public long Free { get; set; }
    }

    public class IndexCircularCompaction
    {
        [JsonProperty("daysOfWeek")]
        public string? DaysOfWeek { get; set; }

        [JsonProperty("interval")]
        public Interval? Interval { get; set; }
    }

    public class IndexFragmentationThreshold
    {
        [JsonProperty("percentage")]
        public Int64 Percentage { get; set; }
    }

    public class InterestingStats
    {
        [JsonProperty("couch_docs_actual_disk_size")]
        public Int64 CouchDocsActualDiskSize { get; set; }

        [JsonProperty("couch_views_actual_disk_size")]
        public Int64 CouchViewsActualDiskSize { get; set; }

        [JsonProperty("curr_items")]
        public Int64 CurrItems { get; set; }

        [JsonProperty("curr_items_tot")]
        public Int64 CurrItemsTot { get; set; }

        [JsonProperty("ep_bg_fetched")]
        public Int64 EpBgFetched { get; set; }

        [JsonProperty("couch_docs_data_size")]
        public Int64 CouchDocsDataSize { get; set; }

        [JsonProperty("mem_used")]
        public Int64 MemUsed { get; set; }

        [JsonProperty("vb_replica_curr_items")]
        public Int64 VbReplicaCurrItems { get; set; }

        [JsonProperty("vb_active_num_non_resident")]
        public Int64 VbActiveNumNonResident { get; set; }

        [JsonProperty("cmd_get")]
        public Int64 CmdGet { get; set; }

        [JsonProperty("get_hits")]
        public Int64 GetHits { get; set; }

        [JsonProperty("ops")]
        public Int64 Ops { get; set; }

        [JsonProperty("index_data_size")]
        public Int64 IndexDataSize { get; set; }

        [JsonProperty("index_disk_size")]
        public Int64 IndexDiskSize { get; set; }

        [JsonProperty("couch_spatial_disk_size")]
        public Int64 CouchSpatialDiskSize { get; set; }

        [JsonProperty("couch_views_data_size")]
        public Int64 CouchViewsDataSize { get; set; }

        [JsonProperty("couch_spatial_data_size")]
        public Int64 CouchSpatialDataSize { get; set; }
    }

    public class Interval
    {
        [JsonProperty("fromHour")]
        public Int64 FromHour { get; set; }

        [JsonProperty("toHour")]
        public Int64 ToHour { get; set; }

        [JsonProperty("fromMinute")]
        public Int64 FromMinute { get; set; }

        [JsonProperty("toMinute")]
        public Int64 ToMinute { get; set; }

        [JsonProperty("abortOutside")]
        public bool AbortOutside { get; set; }
    }

    public class Node
    {
        [JsonProperty("clusterMembership")]
        public string? ClusterMembership { get; set; }

        [JsonProperty("recoveryType")]
        public string? RecoveryType { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("otpNode")]
        public string? OtpNode { get; set; }

        [JsonProperty("thisNode")]
        public bool ThisNode { get; set; }

        [JsonProperty("hostname")]
        public string? Hostname { get; set; }

        [JsonProperty("nodeUUID")]
        public string? NodeUUID { get; set; }

        [JsonProperty("clusterCompatibility")]
        public Int64 ClusterCompatibility { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }

        [JsonProperty("os")]
        public string? Os { get; set; }

        [JsonProperty("cpuCount")]
        public Int64 CpuCount { get; set; }

        [JsonProperty("ports")]
        public Ports? Ports { get; set; }

        [JsonProperty("services")]
        public List<string>? Services { get; set; }

        [JsonProperty("nodeEncryption")]
        public bool NodeEncryption { get; set; }

        [JsonProperty("addressFamilyOnly")]
        public bool AddressFamilyOnly { get; set; }

        [JsonProperty("configuredHostname")]
        public string? ConfiguredHostname { get; set; }

        [JsonProperty("addressFamily")]
        public string? AddressFamily { get; set; }

        [JsonProperty("externalListeners")]
        public List<ExternalListener>? ExternalListeners { get; set; }

        [JsonProperty("couchApiBase")]
        public string? CouchApiBase { get; set; }

        [JsonProperty("couchApiBaseHTTPS")]
        public string? CouchApiBaseHTTPS { get; set; }

        [JsonProperty("systemStats")]
        public SystemStats? SystemStats { get; set; }

        [JsonProperty("interestingStats")]
        public InterestingStats? InterestingStats { get; set; }

        [JsonProperty("uptime")]
        public string? Uptime { get; set; }

        [JsonProperty("memoryTotal")]
        public Int64 MemoryTotal { get; set; }

        [JsonProperty("memoryFree")]
        public Int64 MemoryFree { get; set; }

        [JsonProperty("mcdMemoryReserved")]
        public Int64 McdMemoryReserved { get; set; }

        [JsonProperty("mcdMemoryAllocated")]
        public Int64 McdMemoryAllocated { get; set; }
    }

    public class Ram
    {
        [JsonProperty("total")]
        public Int64 Total { get; set; }

        [JsonProperty("quotaTotal")]
        public Int64 QuotaTotal { get; set; }

        [JsonProperty("quotaUsed")]
        public Int64 QuotaUsed { get; set; }

        [JsonProperty("used")]
        public Int64 Used { get; set; }

        [JsonProperty("usedByData")]
        public Int64 UsedByData { get; set; }

        [JsonProperty("quotaUsedPerNode")]
        public Int64 QuotaUsedPerNode { get; set; }

        [JsonProperty("quotaTotalPerNode")]
        public Int64 QuotaTotalPerNode { get; set; }
    }

    public class ReAddNode
    {
        [JsonProperty("uri")]
        public string? Uri { get; set; }
    }

    public class Rebalance
    {
        [JsonProperty("uri")]
        public string? Uri { get; set; }
    }

    public class ReFailOver
    {
        [JsonProperty("uri")]
        public string? Uri { get; set; }
    }

    public class RemoteClusters
    {
        [JsonProperty("uri")]
        public string? Uri { get; set; }

        [JsonProperty("validateURI")]
        public string? ValidateURI { get; set; }
    }

    public class Replication
    {
        [JsonProperty("createURI")]
        public string? CreateURI { get; set; }

        [JsonProperty("validateURI")]
        public string? ValidateURI { get; set; }
    }

    public class NodeResponse
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("nodes")]
        public List<Node>? Nodes { get; set; }

        [JsonProperty("buckets")]
        public Buckets? Buckets { get; set; }

        [JsonProperty("bucketNames")]
        public List<BucketName>? BucketNames { get; set; }

        [JsonProperty("remoteClusters")]
        public RemoteClusters? RemoteClusters { get; set; }

        [JsonProperty("alerts")]
        public List<object>? Alerts { get; set; }

        [JsonProperty("alertsSilenceURL")]
        public string? AlertsSilenceURL { get; set; }

        [JsonProperty("controllers")]
        public Controllers? Controllers { get; set; }

        [JsonProperty("rebalanceStatus")]
        public string? RebalanceStatus { get; set; }

        [JsonProperty("rebalanceProgressUri")]
        public string? RebalanceProgressUri { get; set; }

        [JsonProperty("stopRebalanceUri")]
        public string? StopRebalanceUri { get; set; }

        [JsonProperty("nodeStatusesUri")]
        public string? NodeStatusesUri { get; set; }

        [JsonProperty("maxBucketCount")]
        public Int64 MaxBucketCount { get; set; }

        [JsonProperty("maxCollectionCount")]
        public Int64 MaxCollectionCount { get; set; }

        [JsonProperty("maxScopeCount")]
        public Int64 MaxScopeCount { get; set; }

        [JsonProperty("autoCompactionSettings")]
        public AutoCompactionSettings? AutoCompactionSettings { get; set; }

        [JsonProperty("tasks")]
        public Tasks? Tasks { get; set; }

        [JsonProperty("counters")]
        public Counters? Counters { get; set; }

        [JsonProperty("indexStatusURI")]
        public string? IndexStatusURI { get; set; }

        [JsonProperty("serverGroupsUri")]
        public string? ServerGroupsUri { get; set; }

        [JsonProperty("clusterName")]
        public string? ClusterName { get; set; }

        [JsonProperty("balanced")]
        public bool? Balanced { get; set; }

        [JsonProperty("checkPermissionsURI")]
        public string? CheckPermissionsURI { get; set; }

        [JsonProperty("memoryQuota")]
        public Int64 MemoryQuota { get; set; }

        [JsonProperty("indexMemoryQuota")]
        public Int64 IndexMemoryQuota { get; set; }

        [JsonProperty("ftsMemoryQuota")]
        public Int64 FtsMemoryQuota { get; set; }

        [JsonProperty("cbasMemoryQuota")]
        public Int64 CbasMemoryQuota { get; set; }

        [JsonProperty("eventingMemoryQuota")]
        public Int64 EventingMemoryQuota { get; set; }

        [JsonProperty("storageTotals")]
        public StorageTotals? StorageTotals { get; set; }
    }

    public class SetAutoCompaction
    {
        [JsonProperty("uri")]
        public string? Uri { get; set; }

        [JsonProperty("validateURI")]
        public string? ValidateURI { get; set; }
    }

    public class SetRecoveryType
    {
        [JsonProperty("uri")]
        public string? Uri { get; set; }
    }

    public class StartGracefulFailover
    {
        [JsonProperty("uri")]
        public string? Uri { get; set; }
    }

    public class StorageTotals
    {
        [JsonProperty("ram")]
        public Ram? Ram { get; set; }

        [JsonProperty("hdd")]
        public Hdd? Hdd { get; set; }
    }

    public class SystemStats
    {
        [JsonProperty("cpu_utilization_rate")]
        public double CpuUtilizationRate { get; set; }

        [JsonProperty("cpu_stolen_rate")]
        public Int64 CpuStolenRate { get; set; }

        [JsonProperty("swap_total")]
        public Int64 SwapTotal { get; set; }

        [JsonProperty("swap_used")]
        public Int64 SwapUsed { get; set; }

        [JsonProperty("mem_total")]
        public Int64 MemTotal { get; set; }

        [JsonProperty("mem_free")]
        public Int64 MemFree { get; set; }

        [JsonProperty("mem_limit")]
        public Int64 MemLimit { get; set; }

        [JsonProperty("cpu_cores_available")]
        public Int64 CpuCoresAvailable { get; set; }

        [JsonProperty("allocstall")]
        public BigInteger Allocstall { get; set; }
    }

    public class Tasks
    {
        [JsonProperty("uri")]
        public string? Uri { get; set; }
    }

    public class ViewFragmentationThreshold
    {
        [JsonProperty("percentage")]
        public Int64 Percentage { get; set; }

        [JsonProperty("size")]
        public string? Size { get; set; }
    }
}
