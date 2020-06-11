# AndcultureCode.CSharp.Cli [![Build Status](https://travis-ci.org/AndcultureCode/AndcultureCode.CSharp.Cli.svg?branch=master)](https://travis-ci.org/AndcultureCode/AndcultureCode.CSharp.Cli) [![codecov](https://codecov.io/gh/AndcultureCode/AndcultureCode.CSharp.Cli/branch/master/graph/badge.svg)](https://codecov.io/gh/AndcultureCode/AndcultureCode.CSharp.Cli)
Port of Cli for .NET Core C#

## Getting Started
This package is installed via NuGet
```
dotnet add [<PROJECT>] package AndcultureCode.CSharp.Cli
```

After installation, simply import the extensions namespace to gain access
to all of the available extension methods
```csharp
using System;
using System.Collection.Generic;
using AndcultureCode.CSharp.Cli;

public class Program
{
    public static int Main(string[] args)
    {
        new List<string>().IsEmpty(); // returns true
    }
}
```

## Development Setup

* Install Dotnet Core 2.x
* Install the `and-cli` tooling found at [AndcultureCode.Cli](https://github.com/AndcultureCode/AndcultureCode.Cli)

Below are a few basics to get you started, but there are many more commands and options for managing this and other projects found in the `and-cli`.

### Building project
* Run the build command
    ```
    and-cli dotnet --build
    ```

### Running tests along with code coverage
* Run the test command
    ```
    and-cli dotnet-test
    ```
* Open the `coverage/index.htm` file in your browser

### Publishing a new version
* Run the publish command with the next version number ([See semver package versioning](https://docs.microsoft.com/en-us/nuget/concepts/package-versioning))
    ```
    and-cli nuget --publish <version>
    ```


Contributing
======

Information on contributing to this repo is in the [Contributing Guide](CONTRIBUTING.md)