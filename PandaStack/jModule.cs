using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack
{

    public class jModule
    {

        public string name { get; set; }
        public string type { get; set; }
        public string service { get; set; }

        public List<jAdmin> admin { get; set; }
        public List<jConfig> config { get; set; }

    }

}
