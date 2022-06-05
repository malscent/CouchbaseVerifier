#!/bin/bash

export TEST_PROJECT="./CouchbaseVerifier.Tests/CouchbaseVerifier.Tests.csproj"
export NUGET_SERVER="https://api.nuget.org/v3/index.json"
export BUILD_DIR="./build"
export TOOL_DIR="./CouchbaseVerifier/"
export TOOL_PROJECT_NAME="CouchbaseVerifier.csproj"

set -eu

project=$(basename -s .csproj "$TOOL_PROJECT_NAME")
version=$(sed -n 's:.*<Version>\(.*\>)</Version.*:\1:p' "$TOOL_DIR$TOOL_PROJECT_NAME")
tool_file="./build/$project.$version.nukpg"

echo "Project: $project"
echo "Testing $project version: $version"
dotnet test "$TEST_PROJECT"

dotnet pack "$TOOL_DIR$TOOL_PROJECT_NAME" -o "$BUILD_DIR" --configuration Release
dotnet nuget push "$tool_file" -s "$NUGET_SERVER" -k "$NUGET_KEY" -t 60 -n --force-english-output --skip-duplicate
