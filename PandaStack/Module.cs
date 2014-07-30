using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Windows.Forms;

namespace PandaStack
{

    class Module
    {

        private string _moduleName;
        private ModuleType _moduleType;

        private string _serviceName;
        private ServiceController _sc;

        private List<ModuleConfig> _configs = new List<ModuleConfig>();
        private List<ModuleAdmin> _admin = new List<ModuleAdmin>();

        public Module(string name, ModuleType type)
        {
            this._moduleName = name;
            this._moduleType = type;
        }

        public string getModuleName()
        {
            return this._moduleName;
        }

        public ModuleType getModuleType()
        {
            return this._moduleType;
        }

        public string getServiceName()
        {
            if (this._moduleType != ModuleType.Service) return null;
            return this._serviceName;
        }

        public void addConfig(ModuleConfig config)
        {
            this._configs.Add(config);
        }

        public List<ModuleConfig> getConfigs()
        {
            return this._configs;
        }

        public void addAdmin(ModuleAdmin admin)
        {
            this._admin.Add(admin);
        }

        public List<ModuleAdmin> getAdmins()
        {
            return this._admin;
        }

        public ServiceController getServiceController()
        {
            return this._sc;
        }

        public void setService(string service)
        {
            if (!(service != null && service != string.Empty))
                   return;

            try
            {
                this._sc = new ServiceController(service);
                this._serviceName = service;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public string getStatus()
        {
            string status = "n/a";

            if (this._moduleType == ModuleType.Service)
            {
                try
                {
                    this._sc.Refresh();
                    status = this._sc.Status.ToString();
                }
                catch // (Exception ex)
                {
                    // This spams the console a lot
                    // Information.addMessage(ex.Message + " " + ex.InnerException, InfoType.Important);
                }
            }

            return status;
        }

    }

}
