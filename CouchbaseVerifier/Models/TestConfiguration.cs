using Newtonsoft.Json;

namespace CouchbaseVerifier.Models
{
    public class TestConfiguration
    {
        public List<TestDefinition> TestDefinitions { get; set; } = new List<TestDefinition>();
        public static TestConfiguration ReadDefinitions(string path) {
            if (string.IsNullOrEmpty(path)) {
                throw new ArgumentException("Test Configuration is required.");
            }
            if (!File.Exists(path)) {
                throw new ArgumentException("Test Configuration must exist.");
            }
            var data = File.ReadAllText(path);
            if (string.IsNullOrEmpty(data)) {
                throw new ArgumentException($"Test configuration must be in the appropriate json format.  Use CouchbaseVerifier generate -o {path} to create.");
            }
            var config = JsonConvert.DeserializeObject<TestConfiguration>(data);
            if (config == null) {
                throw new ArgumentException($"Unable to parse ${path} into a test configuration file.  Use CouchbaseVerifier generate to generate a new one.");
            }
            return config;
        }
    }
}