using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack_Module_Generator
{

    class ModuleConfig
    {

        private string ConfigName = "Untitled Config";
        private string ConfigPath;
        private ConfigType ConfigType = ConfigType.File;

        public void SetConfigName(string name)
        {
            this.ConfigName = name;
        }

        public string GetConfigName()
        {
            return this.ConfigName;
        }

        public void SetConfigPath(string path)
        {
            this.ConfigPath = path;
        }

        public string GetConfigPath()
        {
            return this.ConfigPath;
        }

        public void SetConfigType(ConfigType type)
        {
            this.ConfigType = type;
        }

        public ConfigType GetConfigType()
        {
            return this.ConfigType;
        }

    }

}
