using System;
using CommandDotNet;

namespace CouchbaseVerifierCLI
{
    class Program
    {
        static int Main(string[] args)
        {
            return new AppRunner<VerifierCLI>().Run(args);
        }
    }
}
