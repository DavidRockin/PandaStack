using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DavidRockin.PandaStack.PandaClass
{
    public class ModuleControl
    {
        public string Name = "Untitled Control";
        public string Path;
        public string Arguments;
        public ControlType Type = ControlType.Software;

        public ModuleControl()
        {

        }

        public ModuleControl(string name, string filePath, ControlType type)
        {
            this.Name = name;
            this.Path = filePath;
            this.Type = type;
        }

        public ModuleControl(string name, string filePath, string arguments, ControlType type)
        {
            this.Name = name;
            this.Path = filePath;
            this.Arguments = arguments;
            this.Type = type;
        }
    }
}
