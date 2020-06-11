<a name='assembly'></a>
# AndcultureCode.CSharp.Cli

## Contents

- [ColorCodes](#T-AndcultureCode-CSharp-Cli-Constants-ColorCodes 'AndcultureCode.CSharp.Cli.Constants.ColorCodes')
  - [LIGHT_GREEN](#F-AndcultureCode-CSharp-Cli-Constants-ColorCodes-LIGHT_GREEN 'AndcultureCode.CSharp.Cli.Constants.ColorCodes.LIGHT_GREEN')
  - [RED](#F-AndcultureCode-CSharp-Cli-Constants-ColorCodes-RED 'AndcultureCode.CSharp.Cli.Constants.ColorCodes.RED')
  - [RESET](#F-AndcultureCode-CSharp-Cli-Constants-ColorCodes-RESET 'AndcultureCode.CSharp.Cli.Constants.ColorCodes.RESET')
- [Command](#T-AndcultureCode-CSharp-Cli-Command 'AndcultureCode.CSharp.Cli.Command')
  - [#ctor(command,configurationRoot,serviceCollection)](#M-AndcultureCode-CSharp-Cli-Command-#ctor-McMaster-Extensions-CommandLineUtils-CommandLineApplication,Microsoft-Extensions-Configuration-IConfigurationRoot,Microsoft-Extensions-DependencyInjection-IServiceCollection- 'AndcultureCode.CSharp.Cli.Command.#ctor(McMaster.Extensions.CommandLineUtils.CommandLineApplication,Microsoft.Extensions.Configuration.IConfigurationRoot,Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [_command](#F-AndcultureCode-CSharp-Cli-Command-_command 'AndcultureCode.CSharp.Cli.Command._command')
  - [_configurationRoot](#F-AndcultureCode-CSharp-Cli-Command-_configurationRoot 'AndcultureCode.CSharp.Cli.Command._configurationRoot')
  - [_serviceCollection](#F-AndcultureCode-CSharp-Cli-Command-_serviceCollection 'AndcultureCode.CSharp.Cli.Command._serviceCollection')
  - [_commandDescription](#P-AndcultureCode-CSharp-Cli-Command-_commandDescription 'AndcultureCode.CSharp.Cli.Command._commandDescription')
  - [_isVerbose](#P-AndcultureCode-CSharp-Cli-Command-_isVerbose 'AndcultureCode.CSharp.Cli.Command._isVerbose')
  - [_serviceProvider](#P-AndcultureCode-CSharp-Cli-Command-_serviceProvider 'AndcultureCode.CSharp.Cli.Command._serviceProvider')
  - [ColorText(message,color)](#M-AndcultureCode-CSharp-Cli-Command-ColorText-System-String,System-String- 'AndcultureCode.CSharp.Cli.Command.ColorText(System.String,System.String)')
  - [GetDep\`\`1()](#M-AndcultureCode-CSharp-Cli-Command-GetDep``1 'AndcultureCode.CSharp.Cli.Command.GetDep``1')
  - [OnExecute()](#M-AndcultureCode-CSharp-Cli-Command-OnExecute 'AndcultureCode.CSharp.Cli.Command.OnExecute')
  - [Output(message)](#M-AndcultureCode-CSharp-Cli-Command-Output-System-String- 'AndcultureCode.CSharp.Cli.Command.Output(System.String)')
  - [Output()](#M-AndcultureCode-CSharp-Cli-Command-Output-System-Object- 'AndcultureCode.CSharp.Cli.Command.Output(System.Object)')
  - [OutputError(message)](#M-AndcultureCode-CSharp-Cli-Command-OutputError-System-String- 'AndcultureCode.CSharp.Cli.Command.OutputError(System.String)')
  - [OutputError\`\`1(result)](#M-AndcultureCode-CSharp-Cli-Command-OutputError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0}- 'AndcultureCode.CSharp.Cli.Command.OutputError``1(AndcultureCode.CSharp.Core.Interfaces.IResult{``0})')
  - [OutputHeader(message)](#M-AndcultureCode-CSharp-Cli-Command-OutputHeader-System-String- 'AndcultureCode.CSharp.Cli.Command.OutputHeader(System.String)')
  - [OutputIfVerbose(message)](#M-AndcultureCode-CSharp-Cli-Command-OutputIfVerbose-System-String- 'AndcultureCode.CSharp.Cli.Command.OutputIfVerbose(System.String)')
  - [OutputIfVerbose()](#M-AndcultureCode-CSharp-Cli-Command-OutputIfVerbose-System-Object- 'AndcultureCode.CSharp.Cli.Command.OutputIfVerbose(System.Object)')
  - [OutputNewLine()](#M-AndcultureCode-CSharp-Cli-Command-OutputNewLine 'AndcultureCode.CSharp.Cli.Command.OutputNewLine')
  - [PreprocessArguments()](#M-AndcultureCode-CSharp-Cli-Command-PreprocessArguments 'AndcultureCode.CSharp.Cli.Command.PreprocessArguments')
  - [RegisterSubCommands()](#M-AndcultureCode-CSharp-Cli-Command-RegisterSubCommands 'AndcultureCode.CSharp.Cli.Command.RegisterSubCommands')
- [ExitCodes](#T-AndcultureCode-CSharp-Cli-Constants-ExitCodes 'AndcultureCode.CSharp.Cli.Constants.ExitCodes')
  - [FAILED](#F-AndcultureCode-CSharp-Cli-Constants-ExitCodes-FAILED 'AndcultureCode.CSharp.Cli.Constants.ExitCodes.FAILED')
  - [SUCCESSFUL](#F-AndcultureCode-CSharp-Cli-Constants-ExitCodes-SUCCESSFUL 'AndcultureCode.CSharp.Cli.Constants.ExitCodes.SUCCESSFUL')

<a name='T-AndcultureCode-CSharp-Cli-Constants-ColorCodes'></a>
## ColorCodes `type`

##### Namespace

AndcultureCode.CSharp.Cli.Constants

##### Summary

Common CLI exit codes

<a name='F-AndcultureCode-CSharp-Cli-Constants-ColorCodes-LIGHT_GREEN'></a>
### LIGHT_GREEN `constants`

##### Summary

Light green

<a name='F-AndcultureCode-CSharp-Cli-Constants-ColorCodes-RED'></a>
### RED `constants`

##### Summary

Red

<a name='F-AndcultureCode-CSharp-Cli-Constants-ColorCodes-RESET'></a>
### RESET `constants`

##### Summary

Resets console output color to default

<a name='T-AndcultureCode-CSharp-Cli-Command'></a>
## Command `type`

##### Namespace

AndcultureCode.CSharp.Cli

##### Summary

Base class for building CLI commands

<a name='M-AndcultureCode-CSharp-Cli-Command-#ctor-McMaster-Extensions-CommandLineUtils-CommandLineApplication,Microsoft-Extensions-Configuration-IConfigurationRoot,Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### #ctor(command,configurationRoot,serviceCollection) `constructor`

##### Summary

Command constructor allowing forwarding of useful config, dependency registry, etc... actors

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [McMaster.Extensions.CommandLineUtils.CommandLineApplication](#T-McMaster-Extensions-CommandLineUtils-CommandLineApplication 'McMaster.Extensions.CommandLineUtils.CommandLineApplication') |  |
| configurationRoot | [Microsoft.Extensions.Configuration.IConfigurationRoot](#T-Microsoft-Extensions-Configuration-IConfigurationRoot 'Microsoft.Extensions.Configuration.IConfigurationRoot') |  |
| serviceCollection | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

<a name='F-AndcultureCode-CSharp-Cli-Command-_command'></a>
### _command `constants`

##### Summary

Instance of command available for sub-classes for extension (ie. sub commands)

<a name='F-AndcultureCode-CSharp-Cli-Command-_configurationRoot'></a>
### _configurationRoot `constants`

##### Summary

Easy access to base appsettings configuration root

<a name='F-AndcultureCode-CSharp-Cli-Command-_serviceCollection'></a>
### _serviceCollection `constants`

##### Summary

Subclass access to pre-built dependency registry

<a name='P-AndcultureCode-CSharp-Cli-Command-_commandDescription'></a>
### _commandDescription `property`

##### Summary

Description of the command output to the CLI when --help is requested

<a name='P-AndcultureCode-CSharp-Cli-Command-_isVerbose'></a>
### _isVerbose `property`

##### Summary

Has the verbose flag been supplied with this command?

##### Returns



<a name='P-AndcultureCode-CSharp-Cli-Command-_serviceProvider'></a>
### _serviceProvider `property`

##### Summary

Subclass access to built dependency registry

<a name='M-AndcultureCode-CSharp-Cli-Command-ColorText-System-String,System-String-'></a>
### ColorText(message,color) `method`

##### Summary

Wraps the provided text in provided ANSI color codes for output to the console.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| color | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | ANSI colors http://www.lihaoyi.com/post/BuildyourownCommandLinewithANSIescapecodes.html#colors |

<a name='M-AndcultureCode-CSharp-Cli-Command-GetDep``1'></a>
### GetDep\`\`1() `method`

##### Summary

Request dependency and all its sub-dependencies as they are registered in ServiceProvider dependency injection registry

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Cli-Command-OnExecute'></a>
### OnExecute() `method`

##### Summary

Entry point for this command

##### Returns



##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Cli-Command-Output-System-String-'></a>
### Output(message) `method`

##### Summary

Cli-wide method for printing output to the console with prefixing
to help distinguish output directly from the CLI versus application code.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-AndcultureCode-CSharp-Cli-Command-Output-System-Object-'></a>
### Output() `method`

##### Summary

Ouputs serialized version of supplied object to console.

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Cli-Command-OutputError-System-String-'></a>
### OutputError(message) `method`

##### Summary

Cli-wide method for printing error output to the console with prefixing
to help distinguish output directly from the CLI versus application code.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-AndcultureCode-CSharp-Cli-Command-OutputError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0}-'></a>
### OutputError\`\`1(result) `method`

##### Summary

Cli-wide method for printing IResult error output to the console with prefixing
to help distinguish output directly from the CLI versus application code.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [AndcultureCode.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} 'AndcultureCode.CSharp.Core.Interfaces.IResult{``0}') |  |

<a name='M-AndcultureCode-CSharp-Cli-Command-OutputHeader-System-String-'></a>
### OutputHeader(message) `method`

##### Summary

Cli-wide method for printing string output in the form of a header

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-AndcultureCode-CSharp-Cli-Command-OutputIfVerbose-System-String-'></a>
### OutputIfVerbose(message) `method`

##### Summary

Outputs the message only if verbosity is enabled

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-AndcultureCode-CSharp-Cli-Command-OutputIfVerbose-System-Object-'></a>
### OutputIfVerbose() `method`

##### Summary

Outputs the object only if verbosity is enabled

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Cli-Command-OutputNewLine'></a>
### OutputNewLine() `method`

##### Summary

Outputs a simple new line to the console

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Cli-Command-PreprocessArguments'></a>
### PreprocessArguments() `method`

##### Summary

Optional override to pre-process incoming command-line arguments

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Cli-Command-RegisterSubCommands'></a>
### RegisterSubCommands() `method`

##### Summary

Optional override to register your top-level command's related sub commands.

 Automatically called in the life-cycle of the base abstract command class.

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Cli-Constants-ExitCodes'></a>
## ExitCodes `type`

##### Namespace

AndcultureCode.CSharp.Cli.Constants

##### Summary

Common CLI exit codes

<a name='F-AndcultureCode-CSharp-Cli-Constants-ExitCodes-FAILED'></a>
### FAILED `constants`

##### Summary

General error

<a name='F-AndcultureCode-CSharp-Cli-Constants-ExitCodes-SUCCESSFUL'></a>
### SUCCESSFUL `constants`

##### Summary

Task behaved as expected without error
