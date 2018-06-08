using System;
using CommandLine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VstsSyncMigrator.Commands;

namespace VstsSyncMigrator.Commands.Tests
{
    [TestClass]
    public class WorkItemCommandTests
    {
        [TestMethod]
        public void TestWorkItemCommandRuns()
        {
            string[] args = {"--sourceTeamProject", "moo", "--sourceCollection", "http://moo.mo"};
            WorkItemMigrationCommand command = new WorkItemMigrationCommand();
            int result = Parser.Default.ParseArguments<WorkItemMigrationOptions>(args).MapResult(
                options => command.RunAndReturnExitCode(options),
               errs => 1);
            Assert.AreEqual(0, result);
        }


    }
}
