using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack
{

    public class ModuleControl
    {

        private string Name;
        private string Path;
        private string Args;
        private ControlType Type;

        public ModuleControl(string name, string filePath, ControlType type)
        {
            this.Name = name;
            this.Path = filePath;
            this.Type = type;
        }

        public ModuleControl(string name, string filePath, string args, ControlType type)
        {
            this.Name = name;
            this.Path = filePath;
            this.Args = args;
            this.Type = type;
        }

        public string GetControlName()
        {
            return this.Name;
        }

        public string GetControlPath()
        {
            return this.Path;
        }

        public string GetControlArgs()
        {
            return this.Args;
        }

        public ControlType GetControlType()
        {
            return this.Type;
        }

    }

}
