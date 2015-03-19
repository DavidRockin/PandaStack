using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DavidRockin.PandaStack.PandaClass.Json
{
    public class JsonRoot
    {
        public List<JsonModule> modules = new List<JsonModule>();
        public JsonSettings settings = new JsonSettings();
    }
}
