#!/bin/bash
set -eu

SCRIPT_SOURCE=${BASH_SOURCE[0]/%publish.sh/}

xmlStarlet=$(which xml)
if [[ -z "$xmlStarlet" ]]; then
    echo "XmlStarlet is required for this script.  Please install it before proceeding."
    exit 1
fi

export TEST_PROJECT="${SCRIPT_SOURCE}CouchbaseVerifier.Tests/CouchbaseVerifier.Tests.csproj"
export NUGET_SERVER="https://api.nuget.org/v3/index.json"
export BUILD_DIR="${SCRIPT_SOURCE}build"
export TOOL_DIR="${SCRIPT_SOURCE}CouchbaseVerifier/"
export TOOL_PROJECT_NAME="CouchbaseVerifier.csproj"


project=$(basename -s .csproj "$TOOL_PROJECT_NAME")
version=$(sed -n 's:.*<Version>\(.*\)</Version>.*:\1:p' "$TOOL_DIR$TOOL_PROJECT_NAME")
tool_file="${SCRIPT_SOURCE}build/$project.$version.nukpg"

echo "Project: $project"
echo "Testing $project version: $version"
dotnet test "$TEST_PROJECT"

dotnet pack "$TOOL_DIR$TOOL_PROJECT_NAME" -o "$BUILD_DIR" --configuration Release
dotnet nuget push "$tool_file" -s "$NUGET_SERVER" -k "$NUGET_KEY" -t 60 -n --force-english-output --skip-duplicate
