using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack
{

    public class ModuleConfig
    {

        private string ConfigName;
        private string ConfigPath;
        private string ConfigArgs;
        private ConfigType ConfigType;

        public ModuleConfig(string name, string filePath, ConfigType type)
        {
            this.ConfigName = name;
            this.ConfigPath = filePath;
            this.ConfigType = type;
        }

        public ModuleConfig(string name, string filePath, string args, ConfigType type)
        {
            this.ConfigName = name;
            this.ConfigPath = filePath;
            this.ConfigArgs = args;
            this.ConfigType = type;
        }

        public string GetConfigName()
        {
            return this.ConfigName;
        }

        public string GetConfigPath()
        {
            return this.ConfigPath;
        }

        public string GetConfigArgs()
        {
            return this.ConfigArgs;
        }
        
        public ConfigType GetConfigType()
        {
            return this.ConfigType;
        }

    }

}
