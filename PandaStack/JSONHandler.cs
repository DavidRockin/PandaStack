using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace PandaStack
{

    public class JSONHandler
    {

        private string _filePath;
        private jsonRoot root;
        private jsonModule[] modules;
        private jsonSettings settings;

        public JSONHandler(string filePath)
        {
            this._filePath = filePath;
        }

        public void fetchJSON()
        {
            string json = File.ReadAllText(this._filePath);
            DataContractJsonSerializer serialized = new DataContractJsonSerializer(typeof(jsonRoot));
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var obj = (jsonRoot)serialized.ReadObject(stream);

            this.root = obj;
            this.modules = obj.modules;
            this.settings = obj.settings;
        }

        public jsonRoot getJSONRoot()
        {
            return this.root;
        }

        public jsonModule[] getModules()
        {
            return this.modules;
        }

        public jsonSettings getSettings()
        {
            return this.settings;
        }

    }

}
