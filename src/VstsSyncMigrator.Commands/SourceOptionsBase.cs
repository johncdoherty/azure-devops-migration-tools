using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VstsSyncMigrator.Commands
{
    public class SourceOptionsBase : OptionsBase
    {
        [Option("sourceCollection", Required = true, HelpText = "Collection that you want to connect to.")]
        public Uri sourceCollection { get; set; }

        [Option("sourceTeamProject", Required = true, HelpText = "Collection that you want to connect to.")]
        public string sourceTeamProject { get; set; }

        [Option("sourceQueryBit", Required = false, Default = "", HelpText = "Collection that you want to connect to.")]
        public string sourceQueryBit { get; set; }
    }
}
