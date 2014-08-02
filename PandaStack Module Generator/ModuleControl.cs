using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack_Module_Generator
{

    class ModuleControl
    {

        private string Name = "Untitled Control";
        private string Path;
        private ControlType Type = ControlType.Software;

        public void SetControlName(string name)
        {
            this.Name = name;
        }

        public string GetControlName()
        {
            return this.Name;
        }

        public void SetControlPath(string path)
        {
            this.Path = path;
        }

        public string GetControlPath()
        {
            return this.Path;
        }

        public void SetControlType(ControlType type)
        {
            this.Type = type;
        }

        public ControlType GetControlType()
        {
            return this.Type;
        }

    }

}
