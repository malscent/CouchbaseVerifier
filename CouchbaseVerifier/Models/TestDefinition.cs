namespace CouchbaseVerifier.Models
{
    public class TestDefinition
    {
        public string Name { get; set; } = "";
        public string ExpectedResult { get; set; } = "";

        public int ValidateAndReturnInt() {
            if (int.TryParse(ExpectedResult, out var t)) {
                return t;
            } else {
                throw new ArgumentException($"{ExpectedResult} cannot be parsed as Int.");
            }
        }

        public bool ValidateAndReturnBool() {
            if (bool.TryParse(ExpectedResult, out var t)) {
                return t;
            } else {
                throw new ArgumentException($"{ExpectedResult} cannot be parsed as Bool.");
            }
        }
    }
}