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

    public class PandaStack
    {

        private JsonHandler JsonHandler;
        protected List<Module> Modules = new List<Module>();

        public PandaStack()
        {
            string jsonFile = AppDomain.CurrentDomain.BaseDirectory + "/PandaStack.conf";
            this.JsonHandler = new JsonHandler(jsonFile);
        }

        public void LoadModules()
        {
            this.JsonHandler.FetchJson();

            foreach (JsonModule jsonModule in this.JsonHandler.GetModules())
            {
                // Module has to have a name and type
                if (String.IsNullOrEmpty(jsonModule.name) || String.IsNullOrEmpty(jsonModule.type))
                    continue;

                // Set module type then create the module
                ModuleType moduleType = (ModuleType)Enum.Parse(typeof(ModuleType), jsonModule.type, true);
                Module module = new Module(jsonModule.name, moduleType);

                // Setup the module with its corresponding type
                if (moduleType == ModuleType.Service && jsonModule.service != null)
                {
                    module.SetServiceName(jsonModule.service);
                }
                else if (moduleType == ModuleType.Software)
                {
                    // TODO: Create software type modules
                }

                // Setup module's configurations
                if (jsonModule.config != null)
                {
                    foreach (JsonConfig jsonConfig in jsonModule.config)
                    {
                        // Configuration must have a name, a type and a file/path
                        if (String.IsNullOrEmpty(jsonConfig.name) || String.IsNullOrEmpty(jsonConfig.type) || String.IsNullOrEmpty(jsonConfig.path))
                            continue;

                        ConfigType configType = (ConfigType)Enum.Parse(typeof(ConfigType), jsonConfig.type, true);
                        module.AddConfig(new ModuleConfig(jsonConfig.name, jsonConfig.path, jsonConfig.args, configType));
                    }
                }

                // Setup the module's controls
                if (jsonModule.control != null)
                {
                    foreach (JsonControl jsonControl in jsonModule.control)
                    {
                        // Controls must have a name, a type and a file/path
                        if (String.IsNullOrEmpty(jsonControl.name) || String.IsNullOrEmpty(jsonControl.type) || String.IsNullOrEmpty(jsonControl.path))
                            continue;

                        ControlType controlType = (ControlType)Enum.Parse(typeof(ControlType), jsonControl.type, true);
                        module.AddControl(new ModuleControl(jsonControl.name, jsonControl.path, jsonControl.args, controlType));
                    }
                }

                // Add the module to the list
                this.Modules.Add(module);
            }
        }

        public void ReloadModules()
        {
            this.Modules.Clear();
            this.LoadModules();
        }

        public List<Module> GetModules()
        {
            return this.Modules;
        }

        public JsonHandler GetJsonHandler()
        {
            return this.JsonHandler;
        }

    }

}
