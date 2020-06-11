using System;
using AndcultureCode.CSharp.Core.Extensions;
using AndcultureCode.CSharp.Core.Interfaces;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using AndcultureCode.CSharp.Core.Utilities.Configuration;
using AndcultureCode.CSharp.Cli.Constants;

namespace AndcultureCode.CSharp.Cli
{
    /// <summary>
    /// Base class for building CLI commands
    /// </summary>
    public abstract class Command
    {
        #region Private Properties

        private IServiceProvider _cachedServiceProvider;
        private CommandOption _verbose;

        #endregion Private Properties

        #region Protected Properties

        /// <summary>
        /// Instance of command available for sub-classes for extension (ie. sub commands)
        /// </summary>
        protected readonly CommandLineApplication _command;

        /// <summary>
        /// Description of the command output to the CLI when --help is requested
        /// </summary>
        protected abstract string _commandDescription { get; }

        /// <summary>
        /// Easy access to base appsettings configuration root
        /// </summary>
        protected readonly IConfigurationRoot _configurationRoot;

        /// <summary>
        /// Has the verbose flag been supplied with this command?
        /// </summary>
        /// <returns></returns>
        protected bool _isVerbose { get => Convert.ToBoolean(_verbose.Value()); }

        /// <summary>
        /// Subclass access to pre-built dependency registry
        /// </summary>
        protected readonly IServiceCollection _serviceCollection;

        /// <summary>
        /// Subclass access to built dependency registry
        /// </summary>
        protected IServiceProvider _serviceProvider
        {
            get => _cachedServiceProvider = _cachedServiceProvider ?? _serviceCollection.BuildServiceProvider();
        }

        #endregion Protected Properties

        #region Constructor

        /// <summary>
        /// Command constructor allowing forwarding of useful config, dependency registry, etc... actors
        /// </summary>
        /// <param name="command"></param>
        /// <param name="configurationRoot"></param>
        /// <param name="serviceCollection"></param>
        public Command(
            CommandLineApplication command,
            IConfigurationRoot configurationRoot,
            IServiceCollection serviceCollection
        )
        {
            _command = command;
            _configurationRoot = configurationRoot;
            _serviceCollection = serviceCollection;

            _command.Description = _commandDescription;
            _command.OnExecute(() => OnExecute());

            PreprocessArguments();
            RegisterSubCommands();
        }

        #endregion Constructor

        #region Public Methods

        /// <summary>
        /// Entry point for this command
        /// </summary>
        /// <returns></returns>
        public virtual int OnExecute()
        {
            Console.WriteLine($"No high-level command at this time. See --help for additional sub-commands.");
            return ExitCodes.SUCCESSFUL;
        }

        #endregion Public Methods

        #region Protected Methods

        /// <summary>
        /// Wraps the provided text in provided ANSI color codes for output to the console.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color">ANSI colors http://www.lihaoyi.com/post/BuildyourownCommandLinewithANSIescapecodes.html#colors</param>
        /// <returns></returns>
        protected string ColorText(string message, string color) => $"{color}{message}{ColorCodes.RESET}";

        /// <summary>
        /// Request dependency and all its sub-dependencies as they are registered in ServiceProvider dependency injection registry
        /// </summary>
        protected T GetDep<T>() where T : class => _serviceProvider.GetService(typeof(T)) as T;

        /// <summary>
        /// Cli-wide method for printing output to the console with prefixing
        /// to help distinguish output directly from the CLI versus application code.
        /// </summary>
        /// <param name="message"></param>
        protected void Output(string message) => Console.WriteLine(ColorText("[Dotnet.Cli] ", ColorCodes.LIGHT_GREEN) + message);

        /// <summary>
        /// Ouputs serialized version of supplied object to console.
        /// </summary>
        protected void Output(object obj) => Output(JsonConvert.SerializeObject(obj, Formatting.Indented));

        /// <summary>
        /// Cli-wide method for printing error output to the console with prefixing
        /// to help distinguish output directly from the CLI versus application code.
        /// </summary>
        /// <param name="message"></param>
        protected void OutputError(string message) => Console.WriteLine(ColorText("[Dotnet.Cli] ", ColorCodes.RED) + message);

        /// <summary>
        /// Cli-wide method for printing IResult error output to the console with prefixing
        /// to help distinguish output directly from the CLI versus application code.
        /// </summary>
        /// <param name="result"></param>
        protected void OutputError<T>(IResult<T> result) => Console.WriteLine(ColorText("[Dotnet.Cli] ", ColorCodes.RED) + result.ListErrors());

        /// <summary>
        /// Cli-wide method for printing string output in the form of a header
        /// </summary>
        /// <param name="message"></param>
        protected void OutputHeader(string message)
        {
            Output("--------------------------------------------------------------");
            Output(message);
            Output("--------------------------------------------------------------");
        }

        /// <summary>
        /// Outputs the message only if verbosity is enabled
        /// </summary>
        /// <param name="message"></param>
        protected void OutputIfVerbose(string message)
        {
            if (_isVerbose)
            {
                Output(message);
            }
        }

        /// <summary>
        /// Outputs the object only if verbosity is enabled
        /// </summary>
        protected void OutputIfVerbose(object obj)
        {
            if (_isVerbose)
            {
                Output(obj);
            }
        }

        /// <summary>
        /// Outputs a simple new line to the console
        /// </summary>
        protected void OutputNewLine() => Console.WriteLine("");

        /// <summary>
        /// Optional override to register your top-level command's related sub commands.
        ///
        /// Automatically called in the life-cycle of the base abstract command class.
        /// </summary>
        protected virtual void RegisterSubCommands() { }

        /// <summary>
        /// Optional override to pre-process incoming command-line arguments
        /// </summary>
        protected virtual void PreprocessArguments()
        {
            _verbose = _command.Option("-v|--verbose <verbose>", "Is Verbose Output", CommandOptionType.SingleValue);
        }

        #endregion Protected Methods
    }
}
