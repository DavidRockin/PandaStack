using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using DavidRockin.PandaStack.PandaClass;
using DavidRockin.PandaStack.PandaClass.Json;

namespace DavidRockin.PandaStack.ModuleGenerator
{
    public class PandaStack
    {
        public JsonHandler JsonHandler = new JsonHandler();
        public List<Module> Modules = new List<Module>();

        public List<Module> LoadConfiguration(string configFile)
        {
            try
            {
                if (!File.Exists(configFile))
                {
                    Information.AddMessage("Failed to load configuration file '" + configFile  + "'", InfoType.Error);
                    return null;
                }
                this.JsonHandler.ConfigPath = configFile;
                this.JsonHandler.LoadConfig();
            }
            catch (Exception ex)
            {
                Information.AddMessage("Failed to load configuration: " + ex.Message, InfoType.Exception);
                return null;
            }

            // Iterate through the JSON modules
            foreach (JsonModule jsonModule in this.JsonHandler.GetModules())
            {
                // A module must contain a name and a type
                if (String.IsNullOrEmpty(jsonModule.name) || String.IsNullOrEmpty(jsonModule.type))
                    continue;

                // Create the module
                ModuleType moduleType = (ModuleType)Enum.Parse(typeof(ModuleType), jsonModule.type, true);
                Module module = new Module(jsonModule.name, moduleType);

                if (moduleType == ModuleType.Service && !String.IsNullOrEmpty(jsonModule.service))
                {
                    module.SetServiceName(jsonModule.service);
                }
                else if (moduleType == ModuleType.Software && !String.IsNullOrEmpty(jsonModule.path))
                {
                    module.SetProcessPath(jsonModule.path);
                }

                // Setup the module's configurations
                if (jsonModule.config != null)
                {
                    foreach (JsonConfig jsonConfig in jsonModule.config)
                    {
                        // Configuration must have a name, a type, and a file/path
                        if ((String.IsNullOrEmpty(jsonConfig.name) || String.IsNullOrEmpty(jsonConfig.type) || String.IsNullOrEmpty(jsonConfig.path))
                            && jsonConfig.type.ToLower() != "separator")
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
                        // Configuration must have a name, a type, and a file/path
                        if ((String.IsNullOrEmpty(jsonControl.name) || String.IsNullOrEmpty(jsonControl.type) || String.IsNullOrEmpty(jsonControl.path))
                            && jsonControl.type.ToLower() != "separator")
                            continue;
                        ControlType controlType = (ControlType)Enum.Parse(typeof(ControlType), jsonControl.type, true);
                        module.AddControl(new ModuleControl(jsonControl.name, jsonControl.path, jsonControl.args, controlType));
                    }
                }

                this.Modules.Add(module);
            }

            return this.Modules;
        }

        public List<JsonModule> ModulesToJson(List<Module> Modules)
        {
            if (this.JsonHandler != null && this.JsonHandler.Root.modules != null)
                this.JsonHandler.Root.modules.Clear();

            foreach (Module module in Modules)
            {
                JsonModule jsonModule = new JsonModule();
                jsonModule.name = module.Name;
                jsonModule.path = module.SoftwarePath;
                jsonModule.service = module.ServiceName;
                jsonModule.type = module.Type.ToString();

                jsonModule.config = new List<JsonConfig>();
                jsonModule.control = new List<JsonControl>();

                foreach (ModuleConfig config in module.Configs)
                {
                    JsonConfig jsonConfig = new JsonConfig();
                    jsonConfig.name = config.Name;
                    jsonConfig.type = config.Type.ToString();
                    jsonConfig.path = config.Path;
                    jsonConfig.args = config.Arguments;
                    jsonModule.config.Add(jsonConfig);
                }

                foreach (ModuleControl control in module.Controls)
                {
                    JsonControl jsonControl = new JsonControl();
                    jsonControl.name = control.Name;
                    jsonControl.type = control.Type.ToString();
                    jsonControl.path = control.Path;
                    jsonControl.args = control.Arguments;
                    jsonModule.control.Add(jsonControl);
                }

                this.JsonHandler.Root.modules.Add(jsonModule);
            }

            return this.JsonHandler.Root.modules;
        }
    }
}
