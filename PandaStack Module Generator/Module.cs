using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack_Module_Generator
{

    class Module
    {

        private string name = "Untitled Module";
        private ModuleType type = ModuleType.Helper;

        private string service;

        private List<ModuleAdmin> admins = new List<ModuleAdmin>();
        private List<ModuleConfig> configs = new List<ModuleConfig>();

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setType(ModuleType type)
        {
            this.type = type;
        }

        public ModuleType getType()
        {
            return this.type;
        }

        public void setService(string service)
        {
            this.service = service;
        }

        public string getService()
        {
            return this.service;
        }

        public void addConfig(ModuleConfig config)
        {
            this.configs.Add(config);
        }

        public List<ModuleConfig> getConfigs()
        {
            return this.configs;
        }

        public void clearConfigs()
        {
            this.configs.Clear();
        }

        public void addAdmin(ModuleAdmin admin)
        {
            this.admins.Add(admin);
        }

        public List<ModuleAdmin> getAdmins()
        {
            return this.admins;
        }

        public void clearAdmins()
        {
            this.admins.Clear();
        }

    }

}
