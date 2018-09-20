using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AzureDevOpsMigration.Core.Test
{
    [TestClass]
    public class TestConfiguration
    {
        [TestMethod]
        public void TestConfiguration_TestNew()
        {
            ConfigurationFile cf = ConfigurationFile.CreateDefault();
            Assert.IsNotNull(cf);
        }

        [TestMethod]
        public void TestConfiguration_Save()
        {
            string configFile = "configuration.json";
            ConfigurationFile cf = ConfigurationFile.CreateDefault();
            cf.Save(configFile, true);
            bool exists= System.IO.File.Exists(configFile);
            Assert.IsTrue(exists);

        }

        [TestMethod]
        public void TestConfiguration_Load()
        {
            TestConfiguration_Save();
            string configFile = "configuration.json";
            ConfigurationFile cf = ConfigurationFile.Load(configFile);
            Assert.IsNotNull(cf);
        }
    }
}
