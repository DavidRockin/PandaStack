using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack_Module_Generator
{

    class Module
    {

        private string ModuleName = "Untitled Module";
        private ModuleType ModuleType = ModuleType.Helper;

        private string ServiceName;
        private string SoftwarePath;

        private List<ModuleControl> Controls = new List<ModuleControl>();
        private List<ModuleConfig> Configs = new List<ModuleConfig>();

        public void SetModuleName(string name)
        {
            this.ModuleName = name;
        }

        public string GetModuleName()
        {
            return this.ModuleName;
        }

        public void SetModuleType(ModuleType type)
        {
            this.ModuleType = type;
        }

        public ModuleType GetModuleType()
        {
            return this.ModuleType;
        }

        public void SetServiceName(string service)
        {
            this.ServiceName = service;
        }

        public string GetServiceName()
        {
            return this.ServiceName;
        }

        public void SetProgramPath(string filePath)
        {
            this.SoftwarePath = filePath;
        }

        public string GetProgramPath()
        {
            return this.SoftwarePath;
        }

        public void AddConfig(ModuleConfig config)
        {
            this.Configs.Add(config);
        }

        public List<ModuleConfig> GetConfigs()
        {
            return this.Configs;
        }

        public void ClearConfigs()
        {
            this.Configs.Clear();
        }

        public void AddControl(ModuleControl control)
        {
            this.Controls.Add(control);
        }

        public List<ModuleControl> GetControls()
        {
            return this.Controls;
        }

        public void ClearControls()
        {
            this.Controls.Clear();
        }

    }

}
