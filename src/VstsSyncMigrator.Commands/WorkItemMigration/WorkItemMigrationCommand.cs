using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VstsSyncMigrator.Commands
{
    public class WorkItemMigrationCommand : CommandBase<WorkItemMigrationOptions>
    {
        public override int RunAndReturnExitCode(WorkItemMigrationOptions options)
        {
            return 0;
        }
    }
}
