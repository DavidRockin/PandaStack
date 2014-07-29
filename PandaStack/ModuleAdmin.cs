using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack
{

    class ModuleAdmin
    {

        private string _name;
        private string _path;

        private ModuleAdminType _moduleAdminType;

        public ModuleAdmin(string name, string filePath, ModuleAdminType type)
        {
            this._name = name;
            this._path = filePath;
            this._moduleAdminType = type;
        }

        public string getConfigName()
        {
            return this._name;
        }

        public string getConfigFile()
        {
            return this._path;
        }

        public ModuleAdminType getModuleConfigType()
        {
            return this._moduleAdminType;
        }
    }

}
