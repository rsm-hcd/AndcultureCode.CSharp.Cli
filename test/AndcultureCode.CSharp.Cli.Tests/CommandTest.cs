using Shouldly;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;
using AndcultureCode.CSharp.Testing;
using AndcultureCode.CSharp.Testing.Extensions;
using Moq;
using AndcultureCode.CSharp.Testing.Tests;
using AndcultureCode.CSharp.Cli;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AndcultureCode.CSharp.Cli.Constants;
using AndcultureCode.CSharp.CSharp.Tests.Unit.Stubs;

namespace AndcultureCode.CSharp.CSharp.Tests.Unit
{
    public class CommandTest : BaseUnitTest
    {
        #region Setup

        public CommandTest(ITestOutputHelper output) : base(output) { }

        #endregion Setup

        #region OnExecute

        [Fact]
        public void OnExecute_Returns_Successful_ExitCode()
        {
            // Arrange
            var commandLineApplication = new CommandLineApplication();
            var mockConfigurationRoot = Mock.Of<IConfigurationRoot>();
            var mockServiceCollection = Mock.Of<IServiceCollection>();
            var sut = new CommandStub(commandLineApplication, mockConfigurationRoot, mockServiceCollection);

            // Act
            var result = sut.OnExecute();

            // Assert
            result.ShouldBe(ExitCodes.SUCCESSFUL);
        }

        #endregion OnExecute
    }
}
