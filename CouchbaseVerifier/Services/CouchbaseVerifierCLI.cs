using System;
using CommandDotNet;
using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;
using Newtonsoft.Json;

namespace CouchbaseVerifierCLI.Services
{
    public class VerifierCLI
    {
        private IEnumerable<ITestValidator> _validators;

        public VerifierCLI(IEnumerable<ITestValidator> validators)
        {
            _validators = validators;
        }

        [Command("verify", Description = "Performs test verifications against a couchbase server node")]
        public void Verify(
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
            Console.WriteLine("Using Settings:");
            Console.WriteLine($"Host: {host}");
            Console.WriteLine($"Username: {username}");
            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"TestDefinitionsPath: {testDefinitions}");
            Console.WriteLine($"Timeout is: {timeoutInSeconds}");
            Console.WriteLine($"Retries is: {retries}");
        }

        [Command("list", Description = "Lists all tests that will be executed")]
        public void ListTests()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine(String.Format("|{0,-30}|{1,-30}|", "Name", "Expected Value Type"));
            Console.WriteLine("---------------------------------------------------------------");
            foreach (var t in _validators) {
                Console.WriteLine(String.Format("|{0,-30}|{1,-30}|", t.Name, t.ExpectedValueType));
                Console.WriteLine("---------------------------------------------------------------");
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