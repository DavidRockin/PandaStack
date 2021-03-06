﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using DavidRockin.PandaStack.PandaClass;
using DavidRockin.PandaStack.PandaClass.Json;

namespace DavidRockin.PandaStack.PandaStack
{
    public class PandaStack
    {
        public JsonHandler JsonHandler = new JsonHandler();
        public List<Module> Modules = new List<Module>();

        public string AppDirectory;

        public PandaStack()
        {
            this.AppDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string jsonFile = this.AppDirectory + "/PandaStack.conf";
            if (File.Exists(jsonFile))
            {
                this.JsonHandler.ConfigPath = jsonFile;
            }
            else
            {
                Information.AddMessage("Failed to locate PandaStack.conf file", InfoType.Error);
            }
        }

        public void LoadModules()
        {
            try
            {
                this.JsonHandler.LoadConfig();
            }
            catch (Exception ex)
            {
                Information.AddMessage("Failed to load configuration: " + ex.Message, InfoType.Exception);
                return;
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
        }

        public void ReloadModules()
        {
            this.Modules.Clear();
            this.LoadModules();
        }
    }
}
