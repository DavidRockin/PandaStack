using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack
{

    public class ModuleControl
    {

        private string ControlName;
        private string ControlPath;
        private string ControlArgs;
        private ControlType ControlType;

        public ModuleControl(string name, string filePath, ControlType type)
        {
            this.ControlName = name;
            this.ControlPath = filePath;
            this.ControlType = type;
        }

        public ModuleControl(string name, string filePath, string args, ControlType type)
        {
            this.ControlName = name;
            this.ControlPath = filePath;
            this.ControlArgs = args;
            this.ControlType = type;
        }

        public string GetControlName()
        {
            return this.ControlName;
        }

        public string GetControlPath()
        {
            return this.ControlPath;
        }

        public string GetControlArgs()
        {
            return this.ControlArgs;
        }

        public ControlType GetControlType()
        {
            return this.ControlType;
        }

    }

}
