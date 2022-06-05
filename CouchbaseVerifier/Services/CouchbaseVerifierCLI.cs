using System;
using CommandDotNet;
using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;
using Newtonsoft.Json;

namespace CouchbaseVerifierCLI.Services
{
    public class VerifierCLI
    {
        private readonly IEnumerable<ITestValidator> _validators;
        private readonly ICouchbaseCacheManager _cacheManager;

        public VerifierCLI(IEnumerable<ITestValidator> validators, ICouchbaseCacheManager manager)
        {
            _validators = validators;
            _cacheManager = manager;
        }

        [Command("verify", Description = "Performs test verifications against a couchbase server node")]
        public async Task<int> Verify(
            [Option("host", Description = "Couchbase Host to attempt connections to")]
            string host,
            [Option('u', "username", Description = "Username to use to connect to Couchbase Server Node")]
            string username,
            [Option('p', "password", Description = "Password to use to connect to Couchbase Server Node")]
            string password,
            [Option('d', "definitions", Description = "Path to a json file containing Test Definitions")]
            string testDefinitions,
            [Option('t', "timeout", Description = "How long to wait for a response from Couchbase Server")]
            int timeoutInSeconds = 60,
            [Option('r', "retries", Description = "The amount of times data will be attempted to be retrieved and validated against test definitions")]
            int retries = 5
        )
        {
            try {
                Console.WriteLine("Using Settings:");
                Console.WriteLine($"Host: {host}");
                Console.WriteLine($"Username: {username}");
                Console.WriteLine($"Password: {string.Empty.PadLeft(password.Length, '*')}");
                Console.WriteLine($"TestDefinitionsPath: {testDefinitions}");
                Console.WriteLine($"Timeout is: {timeoutInSeconds}");
                Console.WriteLine($"Retries is: {retries}");
                Console.WriteLine(SPLITTER);
                Console.WriteLine($"Begin Time: {DateTime.UtcNow}");
                Console.Write("Establishing Couchbase Cache...");

                var complete = await _cacheManager.SetCache(host, username, password, retries, timeoutInSeconds);
                if (!complete) {
                    Console.Write("Failed!\n");
                    Console.WriteLine("Unable to establish connection to Couchbase node.");
                    return 1;
                }
                Console.Write("Success!\n");
                Console.WriteLine(SPLITTER);
                Console.WriteLine("Beginning tests...");
                var config = TestConfiguration.ReadDefinitions(testDefinitions);
                var fails = config.TestDefinitions.Count;
                foreach (var def in config.TestDefinitions) {
                    var test = _validators.Where(t => string.Equals(def.Name, t.Name, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
                    if (test == null) {
                        throw new InvalidConfigurationException($"No test by the name of {def.Name} exists. See CouchbaseVerifier list for a full list of test names.");
                    }
                    var result = test.PerformValidation(_cacheManager.GetCache(), def);
                    printResult(result, test, def);
                    fails -= Convert.ToInt32(result.Success);       
                }
                Console.WriteLine($"{config.TestDefinitions.Count - fails}/{config.TestDefinitions.Count} successful tests.");
                Console.WriteLine(SPLITTER);
                Console.WriteLine($"EndTime:  {DateTime.UtcNow}");
                return fails;
            } catch (Exception e) {
                Console.WriteLine($"EndTime: {DateTime.UtcNow}");
                Console.WriteLine($"Error: {e.Message}");
                return 1;
            }

        }

        private void printResult(TestResult result, ITestValidator test, TestDefinition def)
        {
            if (result.Success) {
                var existing = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CHECKMARK);
                Console.ForegroundColor = existing;
                Console.Write($" {test.Name} - Expected: {def.ExpectedResult} - Actual: {result.Actual}\n");
            } else {
                var existing = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("x");
                Console.ForegroundColor = existing;
                Console.Write($" {test.Name} - Expected: {def.ExpectedResult} - Actual: {result.Actual}\n");
            }
        }

        private const string CHECKMARK = "\u2713";
        private const string SPLITTER = "---------------------------------------------------------------";
        [Command("list", Description = "Lists all tests that will be executed")]
        public void ListTests()
        {
            Console.WriteLine(SPLITTER);
            Console.WriteLine(String.Format("|{0,-30}|{1,-30}|", "Name", "Expected Value Type"));
            Console.WriteLine(SPLITTER);
            foreach (var t in _validators) {
                Console.WriteLine(String.Format("|{0,-30}|{1,-30}|", t.Name, t.ExpectedValueType));
                Console.WriteLine(SPLITTER);
            }
        }

        [Command("describe", Description = "Provides description of an individual test")]
        public void Describe(
            [Operand("test name", Description = "The name of the test to describe")]
            string test)
        {
            foreach (var t in _validators) {
                if (string.Equals(t.Name, test, StringComparison.InvariantCultureIgnoreCase)) {
                    Console.WriteLine(t.Description);
                    return;
                }
            }
            Console.WriteLine("Test not found.");
        }

        [Command("generate", Description = "Generates an example test definitions file for editing")]
        public void GenerateDefinitionsFile(
            [Option('o', "output", Description = "Path to where to output an example test definitions file")]
            string output = "")
        {
            try {
                var tc = new TestConfiguration();
                foreach (var t in _validators) {
                    tc.TestDefinitions.Add(t.GetDefaultTestDefinition());
                }
                var fileName = Path.GetFileName(output);
                if (string.IsNullOrEmpty(fileName)) {
                    fileName = "testDefinitions.json";
                }
                var path = Path.GetDirectoryName(output);
                if (string.IsNullOrEmpty(path)) {
                    path = "./";
                }
                Directory.CreateDirectory(path);
                
                var json = JsonConvert.SerializeObject(tc, Formatting.Indented);
                File.WriteAllText($"{path}{Path.DirectorySeparatorChar}{fileName}", json);
            }
            catch (Exception e) {
                Console.WriteLine($"Error occurred generating file: {e.Message}");
            }
        }
    }
}