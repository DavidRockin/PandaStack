using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack_Module_Generator
{

    class ModuleControl
    {

        private string ControlName = "Untitled Control";
        private string ControlPath;
        private ControlType ControlType = ControlType.Software;

        public void SetControlName(string name)
        {
            this.ControlName = name;
        }

        public string GetControlName()
        {
            return this.ControlName;
        }

        public void SetControlPath(string path)
        {
            this.ControlPath = path;
        }

        public string GetControlPath()
        {
            return this.ControlPath;
        }

        public void SetControlType(ControlType type)
        {
            this.ControlType = type;
        }

        public ControlType GetControlType()
        {
            return this.ControlType;
        }

    }

}
