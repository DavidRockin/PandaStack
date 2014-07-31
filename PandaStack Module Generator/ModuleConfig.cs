using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack_Module_Generator
{

    class ModuleConfig
    {

        private string name = "Untitled Config";
        private string path;
        private ModuleConfigType type = ModuleConfigType.File;

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

        public void setType(ModuleConfigType type)
        {
            this.type = type;
        }

        public ModuleConfigType getType()
        {
            return this.type;
        }

    }

}
