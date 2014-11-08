using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Diagnostics;

namespace DavidRockin.PandaStack.PandaClass
{
    public class Module
    {
        public string Name = "Untitled Module";
        public ModuleType Type = ModuleType.Helper;

        public List<ModuleConfig> Configs = new List<ModuleConfig>();
        public List<ModuleControl> Controls = new List<ModuleControl>();

        public string ServiceName;
        public string SoftwarePath;
        public ServiceController ServiceController;
        public Process ModuleProcess;

        public Module()
        {
        }

        public Module(string name, ModuleType type)
        {
            this.Name = name;
            this.Type = type;
        }

        public void AddConfig(ModuleConfig config)
        {
            this.Configs.Add(config);
        }

        public void AddControl(ModuleControl control)
        {
            this.Controls.Add(control);
        }

        public void SetServiceName(string serviceName)
        {
            if (String.IsNullOrEmpty(serviceName))
                return;

            try
            {
                this.ServiceController = new ServiceController(serviceName);
                this.ServiceName = serviceName;
            }
            catch (Exception ex)
            {
                Information.AddMessage(ex.Message);
            }
        }

        public void SetProcessPath(string processPath)
        {
            this.ModuleProcess = new Process();
            this.ModuleProcess.StartInfo.FileName = processPath;
            this.ModuleProcess.Start();
        }

        public string GetModuleStatus()
        {
            string status = "n/a";

            try
            {
                if (this.Type == ModuleType.Service)
                {
                    this.ServiceController.Refresh();
                    status = this.ServiceController.Status.ToString();
                }
                else if (this.Type == ModuleType.Software)
                {
                    this.ModuleProcess.Refresh();
                    status = (this.ModuleProcess.HasExited ? "Stopped" : "Running");
                }
            }
            catch { }

            return status;
        }
    }
}
