using System;

namespace AzureDevOpsMigration.Core
{
    public class Engine
    {
        public bool Run()
        {
            return true;
        }

        public ValidationResult Validate()
        {
            return new ValidationResult();
        }
    }
}
