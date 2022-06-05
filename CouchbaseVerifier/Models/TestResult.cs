namespace CouchbaseVerifier.Models
{
    public class TestResult
    {
        public bool Success { get; set; }
        public string Actual { get; set; } = "";
    }
}