# AndcultureCode.CSharp.Cli [![Build Status](https://travis-ci.org/AndcultureCode/AndcultureCode.CSharp.Cli.svg?branch=master)](https://travis-ci.org/AndcultureCode/AndcultureCode.CSharp.Cli) [![codecov](https://codecov.io/gh/AndcultureCode/AndcultureCode.CSharp.Cli/branch/master/graph/badge.svg)](https://codecov.io/gh/AndcultureCode/AndcultureCode.CSharp.Cli)
<!-- ALL-CONTRIBUTORS-BADGE:START - Do not remove or modify this section -->
[![All Contributors](https://img.shields.io/badge/all_contributors-1-orange.svg?style=flat-square)](#contributors-)
<!-- ALL-CONTRIBUTORS-BADGE:END -->
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

Contributing
======

Information on contributing to this repo is in the [Contributing Guide](CONTRIBUTING.md)

## Contributors ✨

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tr>
    <td align="center"><a href="http://www.winton.me/"><img src="https://avatars.githubusercontent.com/u/48424?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Winton DeShong</b></sub></a><br /><a href="https://github.com/AndcultureCode/AndcultureCode.CSharp.Cli/commits?author=wintondeshong" title="Code">💻</a> <a href="https://github.com/AndcultureCode/AndcultureCode.CSharp.Cli/commits?author=wintondeshong" title="Documentation">📖</a></td>
  </tr>
</table>

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!