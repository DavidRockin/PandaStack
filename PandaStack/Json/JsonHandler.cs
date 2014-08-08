using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text.RegularExpressions;

namespace PandaStack
{

    public class JsonHandler
    {

        private string FilePath;
        private JsonRoot Root;
        private JsonModule[] Modules;
        private JsonSettings Settings;

        public JsonHandler(string filePath)
        {
            this.FilePath = filePath;
        }

        public void FetchJson()
        {
            string json = File.ReadAllText(this.FilePath);
            json = Regex.Replace(json, @"/\*(?>(?:(?>[^*]+)|\*(?!/))*)\*/", string.Empty, RegexOptions.Multiline);
            json = Regex.Replace(json, @"\s//(.+?)\r\n", string.Empty, RegexOptions.Multiline);
            DataContractJsonSerializer serialized = new DataContractJsonSerializer(typeof(JsonRoot));
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var root = (JsonRoot)serialized.ReadObject(stream);

            this.Root = root;
            this.Modules = root.modules;
            this.Settings = root.settings;
        }

        public JsonRoot GetJsonRoot()
        {
            return this.Root;
        }

        public JsonModule[] GetModules()
        {
            return this.Modules;
        }

        public JsonSettings GetSettings()
        {
            return this.Settings;
        }

    }

}
