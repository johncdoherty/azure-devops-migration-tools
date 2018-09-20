using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AzureDevOpsMigration.Core.Test
{
    [TestClass]
    public class TestEngine
    {

        Engine e;

        [TestInitialize]
        public void TestInit()
        {
            e = new Engine();
        }

        [TestMethod]
        public void TestEngine_New()
        {
            Assert.IsNotNull(e);
        }        

        [TestMethod]
        public void TestEngine_Run()
        {
            bool result = e.Run();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestEngine_ValidateNotNull()
        {
            ValidationResult result = e.Validate();
            Assert.IsNotNull(result);
        }

    }
}
