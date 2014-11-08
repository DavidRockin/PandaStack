using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text.RegularExpressions;

namespace DavidRockin.PandaStack.PandaClass.Json
{
    public class JsonHandler
    {
        public string ConfigPath;
        public JsonRoot Root;

        public void LoadConfig()
        {
            string json = File.ReadAllText(this.ConfigPath);

            // Strip comments from JSON file before parsing
            json = Regex.Replace(json, @"/\*(?>(?:(?>[^*]+)|\*(?!/))*)\*/", string.Empty, RegexOptions.Multiline);
            json = Regex.Replace(json, @"\s//(.+?)\r\n", string.Empty, RegexOptions.Multiline);

            // Parse the JSON file into objects
            DataContractJsonSerializer serialized = new DataContractJsonSerializer(typeof(JsonRoot));
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            this.Root = (JsonRoot)serialized.ReadObject(stream);
        }

        public string Serialize()
        {
            string str = "";

            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(JsonRoot));
            ser.WriteObject(stream, this.Root);

            stream.Position = 0;
            StreamReader sr = new StreamReader(stream);
            str = sr.ReadToEnd();

            return str;
        }

        public List<JsonModule> GetModules()
        {
            return this.Root.modules;
        }
        public JsonSettings GetSettings()
        {
            return this.Root.settings;
        }
    }
}
