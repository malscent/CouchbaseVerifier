using CouchbaseVerifier.Models;
using Newtonsoft.Json;

namespace CouchbaseVerifier.Tests
{
    public class ParsingTests
    {
        [Fact]
        void ParsesAnArmNodeResponse()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/ArmNodeResponse.json"));
        }
    }
}