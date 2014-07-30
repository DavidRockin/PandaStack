using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack
{

    class ModuleAdmin
    {

        private string _adminName;
        private string _adminPath;
        private string _adminArgs;

        private ModuleAdminType _moduleAdminType;

        public ModuleAdmin(string name, string filePath, ModuleAdminType type)
        {
            this._adminName = name;
            this._adminPath = filePath;
            this._moduleAdminType = type;
        }

        public ModuleAdmin(string name, string filePath, string args, ModuleAdminType type)
        {
            this._adminName = name;
            this._adminPath = filePath;
            this._adminArgs = args;
            this._moduleAdminType = type;
        }

        public string getAdminName()
        {
            return this._adminName;
        }

        public string getAdminPath()
        {
            return this._adminPath;
        }

        public string getArgs()
        {
            return this._adminArgs;
        }

        public ModuleAdminType getModuleAdminType()
        {
            return this._moduleAdminType;
        }

    }

}
