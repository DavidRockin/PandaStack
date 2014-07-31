using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack
{
    public class ModuleConfig
    {

        private string _configName;
        private string _configPath;
        private string _configArgs;

        private ModuleConfigType _configType;

        public ModuleConfig(string name, string filePath, ModuleConfigType type)
        {
            this._configName = name;
            this._configPath = filePath;
            this._configType = type;
        }

        public ModuleConfig(string name, string filePath, string args, ModuleConfigType type)
        {
            this._configName = name;
            this._configPath = filePath;
            this._configArgs = args;
            this._configType = type;
        }

        public string getConfigName()
        {
            return this._configName;
        }

        public string getConfigFile()
        {
            return this._configPath;
        }

        public ModuleConfigType getModuleConfigType()
        {
            return this._configType;
        }

        public string getArgs()
        {
            return this._configArgs;
        }

    }
}
