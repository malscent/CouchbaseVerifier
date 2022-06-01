using System;
using CommandDotNet;

namespace CouchbaseVerifierCLI
{
    public class VerifierCLI
    {
        [DefaultMethod]
        [Command(Name = "verify", AttributeUsageAttribute = "verify <host> <username> <password> <path>", Description = "Performs verifications against a Couchbase Server")]
        public void Verify(
            [Option(Name = "Host", Description = "The Couchbase Server Host to connect to.")] string host,
            [Option(Name = "Username", Description = "The Couchbase Server Host to connect to.")] string username,
            [Option(Name = "Password", Description = "The Couchbase Server Host to connect to.")] string password,
            [Option(Name = "Path", Description = "The Couchbase Server Host to connect to.")] string path
        )
        {
            Console.WriteLine("Using Settings:");
            Console.WriteLine($"Host: {host}");
            Console.WriteLine($"Username: {username}");
            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"Path: {path}");
        }
    }
}