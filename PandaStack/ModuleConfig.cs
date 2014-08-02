﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack
{

    public class ModuleConfig
    {

        private string Name;
        private string Path;
        private string Args;
        private ConfigType Type;

        public ModuleConfig(string name, string filePath, ConfigType type)
        {
            this.Name = name;
            this.Path = filePath;
            this.Type = type;
        }

        public ModuleConfig(string name, string filePath, string args, ConfigType type)
        {
            this.Name = name;
            this.Path = filePath;
            this.Args = args;
            this.Type = type;
        }

        public string GetConfigName()
        {
            return this.Name;
        }

        public string GetConfigPath()
        {
            return this.Path;
        }

        public ConfigType GetConfigType()
        {
            return this.Type;
        }

        public string GetConfigArgs()
        {
            return this.Args;
        }

    }

}
