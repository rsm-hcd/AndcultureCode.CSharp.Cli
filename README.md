# AndcultureCode.CSharp.Cli [![Build Status](https://travis-ci.org/AndcultureCode/AndcultureCode.CSharp.Cli.svg?branch=master)](https://travis-ci.org/AndcultureCode/AndcultureCode.CSharp.Cli) [![codecov](https://codecov.io/gh/AndcultureCode/AndcultureCode.CSharp.Cli/branch/master/graph/badge.svg)](https://codecov.io/gh/AndcultureCode/AndcultureCode.CSharp.Cli)
Commonly used utilities when building CSharp CLIs for .NET Core C#

## Getting Started
This package is installed via NuGet
```
dotnet add [<PROJECT>] package AndcultureCode.CSharp.Cli
```

After installation, simply import the extensions namespace to gain access
to all of the available utilities.
```csharp
using System;
using System.Collection.Generic;
using AndcultureCode.CSharp.Cli;

public class MyCommand : Command
{
    #region Protected Properties

    protected override string _commandDescription => "Top level command for that does something helpful";

    #endregion Protected Properties


    #region Constructor

    public MyCommand(
        CommandLineApplication command,
        IConfigurationRoot configurationRoot,
        IServiceCollection serviceCollection
    ) : base(command, configurationRoot, serviceCollection)
    {
    }

    #endregion Constructor

    #region Protected Methods

    protected override void RegisterSubCommands()
    {
        _command.Command("mySubCommand", cmd => new MySubCommand(cmd, _configurationRoot, _serviceCollection));
    }

    #endregion Protected Methods
}
```

## Documentation

[Full API Documentation](src/AndcultureCode.CSharp.Cli/AndcultureCode.CSharp.Cli.md)

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

# Community

[![](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/images/0)](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/links/0)[![](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/images/1)](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/links/1)[![](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/images/2)](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/links/2)[![](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/images/3)](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/links/3)[![](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/images/4)](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/links/4)[![](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/images/5)](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/links/5)[![](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/images/6)](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/links/6)[![](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/images/7)](https://sourcerer.io/fame/andCulture/AndcultureCode/AndcultureCode.CSharp.Cli/links/7)

Contributing
======

Information on contributing to this repo is in the [Contributing Guide](CONTRIBUTING.md)
