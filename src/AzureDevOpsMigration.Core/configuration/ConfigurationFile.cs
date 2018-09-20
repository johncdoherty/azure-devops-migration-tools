using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;

namespace AzureDevOpsMigration.Core
{
    public class ConfigurationFile
    {
        public static ConfigurationFile CreateDefault()
        {
            return new ConfigurationFile();
        }

        public void Save(string filename,bool force)
        {
                string json = JsonConvert.SerializeObject(this);
                StreamWriter sw = new StreamWriter(filename);
                sw.WriteLine(json);
                sw.Close();
                Trace.WriteLine(string.Format("Configuration file has been saved as {0}", filename), "[Info]");
        }

        public static ConfigurationFile Load(string configFile)
        {
            StreamReader sr = new StreamReader(configFile);
            string configurationjson = sr.ReadToEnd();
            sr.Close();
            return JsonConvert.DeserializeObject<ConfigurationFile>(configurationjson);
        }
    }
}