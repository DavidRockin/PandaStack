using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Windows.Forms;

namespace PandaStack
{

    public class Module
    {

        private string Name;
        private ModuleType Type;

        private string ServiceName;
        private ServiceController ServiceController;

        private List<ModuleConfig> Configs = new List<ModuleConfig>();
        private List<ModuleControl> Controls = new List<ModuleControl>();

        public Module(string name, ModuleType type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string GetModuleName()
        {
            return this.Name;
        }

        public ModuleType GetModuleType()
        {
            return this.Type;
        }

        public string GetServiceName()
        {
            if (this.Type != ModuleType.Service) return null;
            return this.ServiceName;
        }

        public void AddConfig(ModuleConfig config)
        {
            this.Configs.Add(config);
        }

        public List<ModuleConfig> GetConfigs()
        {
            return this.Configs;
        }

        public void AddControl(ModuleControl control)
        {
            this.Controls.Add(control);
        }

        public List<ModuleControl> GetControls()
        {
            return this.Controls;
        }

        public ServiceController GetServiceController()
        {
            return this.ServiceController;
        }

        public void SetServiceName(string serviceName)
        {
            if (!(serviceName != null && serviceName != string.Empty))
                   return;

            try
            {
                this.ServiceController = new ServiceController(serviceName);
                this.ServiceName = serviceName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public string GetModuleStatus()
        {
            string status = "n/a";

            if (this.Type == ModuleType.Service)
            {
                try
                {
                    this.ServiceController.Refresh();
                    status = this.ServiceController.Status.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            return status;
        }

    }

}
