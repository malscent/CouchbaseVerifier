// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

namespace CouchbaseVerifierCLI.Models
{
    public class Controllers
    {
        [JsonProperty("addNode")]
        public AddNode? AddNode { get; set; }

        [JsonProperty("clusterLogsCollection")]
        public ClusterLogsCollection? ClusterLogsCollection { get; set; }

        [JsonProperty("ejectNode")]
        public EjectNode? EjectNode { get; set; }

        [JsonProperty("failOver")]
        public FailOver? FailOver { get; set; }

        [JsonProperty("reAddNode")]
        public ReAddNode? ReAddNode { get; set; }

        [JsonProperty("reFailOver")]
        public ReFailOver? ReFailOver { get; set; }

        [JsonProperty("rebalance")]
        public Rebalance? Rebalance { get; set; }

        [JsonProperty("replication")]
        public Replication? Replication { get; set; }

        [JsonProperty("setAutoCompaction")]
        public SetAutoCompaction? SetAutoCompaction { get; set; }

        [JsonProperty("setFastWarmup")]
        public SetFastWarmup? SetFastWarmup { get; set; }

        [JsonProperty("setRecoveryType")]
        public SetRecoveryType? SetRecoveryType { get; set; }

        [JsonProperty("startGracefulFailover")]
        public StartGracefulFailover? StartGracefulFailover { get; set; }
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
        
        [JsonProperty("distTCP")]
        public int DistTCP { get; set; }

        [JsonProperty("distTLS")]
        public int DistTLS { get; set; }
    }

    public class PoolsResponse
    {
        [JsonProperty("alerts")]
        public List<object>? Alerts { get; set; }

        [JsonProperty("alertsSilenceURL")]
        public string? AlertsSilenceURL { get; set; }

        [JsonProperty("autoCompactionSettings")]
        public AutoCompactionSettings? AutoCompactionSettings { get; set; }

        [JsonProperty("buckets")]
        public Buckets? Buckets { get; set; }

        [JsonProperty("controllers")]
        public Controllers? Controllers { get; set; }

        [JsonProperty("counters")]
        public Counters? Counters { get; set; }

        [JsonProperty("fastWarmupSettings")]
        public FastWarmupSettings? FastWarmupSettings { get; set; }

        [JsonProperty("maxBucketCount")]
        public int MaxBucketCount { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("nodeStatusesUri")]
        public string? NodeStatusesUri { get; set; }

        [JsonProperty("nodes")]
        public List<Node>? Nodes { get; set; }

        [JsonProperty("rebalanceProgressUri")]
        public string? RebalanceProgressUri { get; set; }

        [JsonProperty("rebalanceStatus")]
        public string? RebalanceStatus { get; set; }

        [JsonProperty("remoteClusters")]
        public RemoteClusters? RemoteClusters { get; set; }

        [JsonProperty("serverGroupsUri")]
        public string? ServerGroupsUri { get; set; }

        [JsonProperty("stopRebalanceUri")]
        public string? StopRebalanceUri { get; set; }

        [JsonProperty("storageTotals")]
        public StorageTotals? StorageTotals { get; set; }

        [JsonProperty("tasks")]
        public Tasks? Tasks { get; set; }

        [JsonProperty("visualSettingsUri")]
        public string? VisualSettingsUri { get; set; }
    }

    public class SetFastWarmup
    {
        [JsonProperty("uri")]
        public string? Uri { get; set; }

        [JsonProperty("validateURI")]
        public string? ValidateURI { get; set; }
    }
}