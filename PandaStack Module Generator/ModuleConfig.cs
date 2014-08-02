﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack_Module_Generator
{

    class ModuleConfig
    {

        private string Name = "Untitled Config";
        private string Path;
        private ConfigType Type = ConfigType.File;

        public void SetConfigName(string name)
        {
            this.Name = name;
        }

        public string GetConfigName()
        {
            return this.Name;
        }

        public void SetConfigPath(string path)
        {
            this.Path = path;
        }

        public string GetConfigPath()
        {
            return this.Path;
        }

        public void SetConfigType(ConfigType type)
        {
            this.Type = type;
        }

        public ConfigType GetConfigType()
        {
            return this.Type;
        }

    }

}
