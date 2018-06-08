using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VstsSyncMigrator.Commands
{
    abstract public class CommandBase<TOptions> where TOptions:OptionsBase
    {

        abstract public int RunAndReturnExitCode(TOptions options);

        internal static string CreateExportPath(string logPath, string CommandName)
        {
            string exportPath = Path.Combine(logPath, CommandName);
            if (!Directory.Exists(exportPath))
            {
                Directory.CreateDirectory(exportPath);
            }

            return exportPath;
        }
    }
}
