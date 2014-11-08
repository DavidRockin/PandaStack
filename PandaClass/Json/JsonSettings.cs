using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DavidRockin.PandaStack.PandaClass.Json
{
    public class JsonSettings
    {
        public bool minimizeToTray { get; set; }
        public bool minimizeToolTip { get; set; }
        public bool startMinimized { get; set; }

        public bool displayDebug { get; set; }
        
        public bool timerEnabled { get; set; }
        public int timerInterval { get; set; }
    }
}
