# Couchbase Verifier
## Perform verifications on Couchbase Clusters to confirm deployment

## Introduction

CouchbaseVerifier is a simple tool written to do a quick check of a Couchbase server to verify some cluster details.  This tool was created to help with automating deployment pipelines.

## Usage
Couchbase verifier is packaged as a Dotnet tool.  You can install the tool and use in your terminal window. 

**Prerequisites**: CouchbaseVerifier is written using net6, you will need [.Net 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) installed to run.  

```
dotnet tool install CouchbaseVerifier --global
```

After installing the tool, you will be able to execute it via the `CouchbaseVerifier` command.

## Contributions

Submitions, issues and PRs are welcome.  Tests execute automatically when you create a PR.

Enjoy!