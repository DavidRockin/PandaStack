using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace PandaStack
{

    class PandaStack
    {

        protected List<Module> _modules = new List<Module>();

        public void loadModules()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "/PandaStack.conf";
            string json = File.ReadAllText(path);

            DataContractJsonSerializer serialized = new DataContractJsonSerializer(typeof(List<jModule>));
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var obj = (List<jModule>)serialized.ReadObject(stream);

            foreach (jModule jModule in obj)
            {
                // Module has to have a name and type
                if (jModule.name == null || jModule.type == null)
                    continue;

                // Get and then check module type
                ModuleType moduleType = ModuleType.Helper;
                string jmType = jModule.type.ToLower();

                if (jmType == "service")
                {
                    moduleType = ModuleType.Service;
                }
                else if (jmType == "software")
                {
                    moduleType = ModuleType.Software;
                }
                else if (jmType == "language")
                {
                    moduleType = ModuleType.Language;
                }

                // Create the module
                Module module = new Module(jModule.name, moduleType);

                // Setup the module with its corresponding type
                if (moduleType == ModuleType.Service && jModule.service != null)
                {
                    module.setService(jModule.service);
                }
                else if (moduleType == ModuleType.Software)
                {
                    // TODO: Create software type modules
                }

                // Setup module's configurations
                if (jModule.config != null)
                {
                    foreach (jConfig jConfig in jModule.config)
                    {
                        // Configuration must have a name, a type and a file/path
                        if (jConfig.name == null || jConfig.type == null || jConfig.path == null)
                            continue;

                        // Get and then check the config's type
                        ModuleConfig mc;
                        ModuleConfigType configType = ModuleConfigType.File;
                        string jcType = jConfig.type.ToLower();

                        if (jcType == "dir" || jcType == "directory" || jcType == "folder")
                        {
                            configType = ModuleConfigType.Directory;
                        }
                        else if (jcType == "software")
                        {
                            configType = ModuleConfigType.Software;
                        }
                        else if (jcType == "url" || jcType == "website")
                        {
                            configType = ModuleConfigType.URL;
                        }

                        // Create the configuration, based on if it has args or not
                        if (jConfig.args == null)
                        {
                            mc = new ModuleConfig(jConfig.name, jConfig.path, configType);
                        }
                        else
                        {
                            mc = new ModuleConfig(jConfig.name, jConfig.path, jConfig.args, configType);
                        }

                        // Add the configuration to the module
                        module.addConfig(mc);
                    }
                }

                // Setup module's administrations
                if (jModule.admin != null)
                {
                    foreach (jAdmin jAdmin in jModule.admin)
                    {
                        // Admin has to have a name, a type and a file/path
                        if (jAdmin.name == null || jAdmin.type == null || jAdmin.path == null)
                            continue;

                        // Get and check the admin's type
                        ModuleAdmin ma;
                        ModuleAdminType adminType = ModuleAdminType.Software;
                        string jaType = jAdmin.type.ToLower();

                        if (jaType == "command")
                        {
                            adminType = ModuleAdminType.Command;
                        }
                        else if (jaType == "url" || jaType == "website")
                        {
                            adminType = ModuleAdminType.URL;
                        }

                        // Create the administration, based on if it has args or not
                        if (jAdmin.args == null)
                        {
                            ma = new ModuleAdmin(jAdmin.name, jAdmin.path, adminType);
                        }
                        else
                        {
                            ma = new ModuleAdmin(jAdmin.name, jAdmin.path, jAdmin.args, adminType);
                        }

                        // Add the administration to the module
                        module.addAdmin(ma);
                    }
                }

                // Add the module to the list
                this._modules.Add(module);
            }

        }

        public void reloadModules()
        {
            this._modules.Clear();
            this.loadModules();
        }

        public List<Module> getModules()
        {
            return this._modules;
        }

    }

}
