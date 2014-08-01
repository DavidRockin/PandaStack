using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack_Module_Generator
{

    class ModuleAdmin
    {

        private string name = "Untitled Admin";
        private string path;
        private ModuleAdminType type = ModuleAdminType.Software;

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setPath(string path)
        {
            this.path = path;
        }

        public string getPath()
        {
            return this.path;
        }

        public void setType(ModuleAdminType type)
        {
            this.type = type;
        }

        public ModuleAdminType getType()
        {
            return this.type;
        }

    }

}
