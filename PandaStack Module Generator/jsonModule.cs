using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack_Module_Generator
{

    public class JsonModule
    {

        public string name { get; set; }
        public string type { get; set; }
        public string service { get; set; }

        public List<JsonControl> control { get; set; }
        public List<JsonConfig> config { get; set; }

    }

}
