using AndcultureCode.CSharp.Cli;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AndcultureCode.CSharp.CSharp.Tests.Unit.Stubs
{
    public class CommandStub : Command
    {
        #region Properties

        protected override string _commandDescription => "Test Description";

        #endregion Properties

        #region Constructors

        public CommandStub(
            CommandLineApplication command,
            IConfigurationRoot configurationRoot,
            IServiceCollection serviceCollection
        )
            : base(command, configurationRoot, serviceCollection)
        {
        }

        #endregion Constructors

        #region Public Methods

        public override int OnExecute() => base.OnExecute();

        #endregion Public Methods

        #region Protected Methods

        protected override void PreprocessArguments() => base.PreprocessArguments();
        protected override void RegisterSubCommands() => base.RegisterSubCommands();

        #endregion Protected Methods
    }
}
