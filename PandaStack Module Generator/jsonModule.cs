using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack_Module_Generator
{

    public class jsonModule
    {

        public string name { get; set; }
        public string type { get; set; }
        public string service { get; set; }

        public List<jsonAdmin> admin { get; set; }
        public List<jsonConfig> config { get; set; }

    }

}
