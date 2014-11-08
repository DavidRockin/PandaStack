using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DavidRockin.PandaStack.PandaClass.Json
{
    public class JsonModule
    {
        public string name { get; set; }
        public string type { get; set; }
        public string service { get; set; }
        public string path { get; set; }

        public List<JsonConfig> config { get; set; }
        public List<JsonControl> control { get; set; }
    }
}
