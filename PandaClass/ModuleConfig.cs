using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DavidRockin.PandaStack.PandaClass
{
    public class ModuleConfig
    {
        public string Name = "Untitled Config";
        public string Path;
        public string Arguments;
        public ConfigType Type = ConfigType.File;

        public ModuleConfig()
        {

        }

        public ModuleConfig(string name, string filePath, ConfigType type)
        {
            this.Name = name;
            this.Path = filePath;
            this.Type = type;
        }

        public ModuleConfig(string name, string filePath, string arguments, ConfigType type)
        {
            this.Name = name;
            this.Path = filePath;
            this.Arguments = arguments;
            this.Type = type;
        }
    }
}
