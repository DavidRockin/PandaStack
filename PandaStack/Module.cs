using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Windows.Forms;
using System.Diagnostics;

namespace PandaStack
{

    public class Module
    {

        private string ModuleName;
        private ModuleType ModuleType;

        private Process ModuleProcess;
        private string ServiceName;
        private ServiceController ServiceController;

        private List<ModuleConfig> Configs = new List<ModuleConfig>();
        private List<ModuleControl> Controls = new List<ModuleControl>();

        public Module(string name, ModuleType type)
        {
            this.ModuleName = name;
            this.ModuleType = type;
        }

        public string GetModuleName()
        {
            return this.ModuleName;
        }

        public ModuleType GetModuleType()
        {
            return this.ModuleType;
        }

        public string GetServiceName()
        {
            return this.ServiceName;
        }

        public void AddControl(ModuleControl control)
        {
            this.Controls.Add(control);
        }

        public List<ModuleControl> GetControls()
        {
            return this.Controls;
        }

        public void AddConfig(ModuleConfig config)
        {
            this.Configs.Add(config);
        }

        public List<ModuleConfig> GetConfigs()
        {
            return this.Configs;
        }

        public ServiceController GetServiceController()
        {
            return this.ServiceController;
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
                Information.HandleException(ex);
            }
        }

        public string GetModuleStatus()
        {
            string status = "n/a";

            try
            {
                if (this.ModuleType == ModuleType.Service)
                {
                    this.ServiceController.Refresh();
                    status = this.ServiceController.Status.ToString();
                }
                else if (this.ModuleType == ModuleType.Software)
                {
                    this.ModuleProcess.Refresh();
                    status = (this.ModuleProcess.HasExited ? "Stopped" : "Running");
                }
            } catch {}

            return status;
        }

        public void SetProcessPath(string processPath)
        {
            this.ModuleProcess = new Process();
            this.ModuleProcess.StartInfo.FileName = processPath;
            this.ModuleProcess.Start();
        }

        public Process GetModuleProcess()
        {
            return this.ModuleProcess;
        }

    }

}
