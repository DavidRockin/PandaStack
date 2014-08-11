using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace PandaStack_Module_Generator
{

    public partial class frmMain : Form
    {

        private frmEditItem FormEditItem;
        private List<Module> Modules = new List<Module>();

        public frmMain()
        {
            InitializeComponent();
            this.SetupToolTip();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Setup the controls columns
            lvControls.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvControls.Columns.Add("Type", 75, HorizontalAlignment.Left);
            lvControls.Columns.Add("Path", 250, HorizontalAlignment.Left);

            // Setup the configurations columns
            lvConfigs.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvConfigs.Columns.Add("Type", 75, HorizontalAlignment.Left);
            lvConfigs.Columns.Add("Path", 250, HorizontalAlignment.Left);

            lvModules.Columns.Add("Module Name", lvModules.Width - 25, HorizontalAlignment.Left);

            // Set the module types
            var values = Enum.GetValues(typeof(ModuleType));
            foreach (ModuleType type in values)
            {
                this.cmbType.Items.Add(type.ToString());
            }
        }

        private void lvModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lvModules.Items.Count > 0 && this.lvModules.SelectedItems.Count > 0)
                {
                    Module module = (Module)this.lvModules.FocusedItem.Tag;
                    this.updateCurrentModule(module);
                    this.grpModuleOptions.Enabled = true;
                    this.btnRemove.Enabled = true;

                    if (this.lvModules.FocusedItem.Index > 0 && this.lvModules.Items.Count > 1)
                    {
                        this.btnMvUp.Enabled = true;
                    }

                    if (this.lvModules.FocusedItem.Index < (this.lvModules.Items.Count - 1))
                    {
                        this.btnMvDwn.Enabled = true;
                    }

                    return;
                }
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }

            this.ClearCurrentModule();
        }

        /** Module Actions **/

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            Module module = new Module();
            lvi.Text = module.GetModuleName();
            lvi.Tag = module;

            this.Modules.Add(module);
            this.lvModules.Items.Add(lvi);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvModules.Items.Count > 0 && this.lvModules.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = this.lvModules.FocusedItem;
                    Module module = (Module)lvi.Tag;
                    this.lvModules.Items.Remove(lvi);
                    this.Modules.Remove(module);

                    this.ClearCurrentModule();
                }
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }
        }

        private void btnMvUp_Click(object sender, EventArgs e)
        {
            try
            {
                this.MoveListViewItem(this.lvModules, this.lvModules.FocusedItem, -1, this.btnMvUp, this.btnMvDwn);
                this.lvModules_SelectedIndexChanged(this.lvModules, new EventArgs());
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }
        }

        private void btnMvDwn_Click(object sender, EventArgs e)
        {
            try
            {
                this.MoveListViewItem(this.lvModules, this.lvModules.FocusedItem, 1, this.btnMvUp, this.btnMvDwn);
                this.lvModules_SelectedIndexChanged(this.lvModules, new EventArgs());
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.lvModules.Items.Count > 0 && this.lvModules.SelectedItems.Count > 0)
            {
                ListViewItem lvi = this.lvModules.FocusedItem;
                Module module = (Module)lvi.Tag;

                // Set the module values
                module.SetModuleName(txtName.Text);
                module.SetModuleType((ModuleType)Enum.Parse(typeof(ModuleType), cmbType.Text, true));
                lvi.Text = txtName.Text;

                // Based on the module type, set its corresponding values
                if (cmbType.Text == "Service")
                {
                    module.SetServiceName(this.txtServiceName.Text);
                }
                else if (cmbType.Text == "Software")
                {
                    module.SetProgramPath(this.txtFilePath.Text);
                }

                module.ClearConfigs();
                module.ClearControls();

                // If there are any controls, create them and add to the module
                if (this.lvControls.Items.Count > 0)
                {
                    foreach (ListViewItem controlLvi in this.lvControls.Items)
                    {
                        ModuleControl control = (ModuleControl)controlLvi.Tag;
                        control.SetControlName(controlLvi.Text);
                        control.SetControlType((ControlType)Enum.Parse(typeof(ControlType), controlLvi.SubItems[1].Text, true));
                        control.SetControlPath(controlLvi.SubItems[2].Text);
                        module.AddControl(control);
                    }
                }

                // If there are any configs, create them and add to the module
                if (this.lvConfigs.Items.Count > 0)
                {
                    foreach (ListViewItem configLvi in this.lvConfigs.Items)
                    {
                        ModuleConfig config = (ModuleConfig)configLvi.Tag;
                        config.SetConfigName(configLvi.Text);
                        config.SetConfigType((ConfigType)Enum.Parse(typeof(ConfigType), configLvi.SubItems[1].Text, true));
                        config.SetConfigPath(configLvi.SubItems[2].Text);
                        module.AddConfig(config);
                    }
                }
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            if (this.lvModules.Items.Count > 0 && this.lvModules.SelectedItems.Count > 0)
            {
                ListViewItem lvi = this.lvModules.FocusedItem;
                Module module = (Module)lvi.Tag;

                this.updateCurrentModule(module);
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtServiceName.Enabled = false;
            this.txtFilePath.Enabled = false;
            this.btnOpenLoc.Enabled = false;
            this.btnLoadService.Enabled = false;

            if (this.cmbType.Text == "Service")
            {
                this.txtServiceName.Enabled = true;
                this.btnLoadService.Enabled = true;
            }
            else if (this.cmbType.Text == "Software")
            {
                this.txtFilePath.Enabled = true;
                this.btnOpenLoc.Enabled = true;
            }
        }

        private void btnOpenLoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFileLoc = new OpenFileDialog();
            ofdFileLoc.Title = "Load Application";
            ofdFileLoc.Filter = "Application Files (*.exe)|*.exe|Batch files (*.bat;*.com)|*.bat;*.com|All Files (*.*)|*.*";

            if (ofdFileLoc.ShowDialog() != DialogResult.Cancel)
            {
                this.txtFilePath.Text = ofdFileLoc.FileName;
            }
        }

        private void btnLoadService_Click(object sender, EventArgs e)
        {
            frmServiceSelector serviceSelector = new frmServiceSelector();
            if (serviceSelector.ShowDialog() == DialogResult.OK)
            {
                this.txtServiceName.Text = serviceSelector.ServiceName;
            }
        }

        /** Module Controls **/

        private void lvControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lvControls.Items.Count > 0 && this.lvControls.SelectedItems.Count > 0)
                {
                    this.btnControl_Remove.Enabled = true;
                    this.btnControl_Edit.Enabled = true;

                    if (this.lvControls.FocusedItem.Index > 0 && this.lvControls.Items.Count > 1)
                    {
                        this.btnControl_MvUp.Enabled = true;
                    }

                    if (this.lvControls.FocusedItem.Index < (this.lvControls.Items.Count - 1))
                    {
                        this.btnControl_MvDown.Enabled = true;
                    }

                    return;
                }
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }

            this.ClearCurrentControl();
        }

        private void btnControl_Add_Click(object sender, EventArgs e)
        {
            if (this.lvModules.Items.Count > 0 && this.lvModules.SelectedItems.Count > 0)
            {
                ModuleControl control = new ModuleControl();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = control.GetControlName();
                lvi.SubItems.Add(control.GetControlType().ToString());
                lvi.SubItems.Add(control.GetControlPath());
                lvi.Tag = control;
                this.lvControls.Items.Add(lvi);
            }
        }

        private void btnControl_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvControls.Items.Count > 0 && this.lvControls.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = this.lvControls.FocusedItem;
                    this.lvControls.Items.Remove(lvi);
                }
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }
        }

        private void btnControl_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvControls.Items.Count > 0 && this.lvControls.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = this.lvControls.FocusedItem;
                    ModuleControl admin = (ModuleControl)lvi.Tag;

                    this.FormEditItem = new frmEditItem(admin);
                    this.FormEditItem.Name = lvi.Text;
                    this.FormEditItem.Type = lvi.SubItems[1].Text;
                    this.FormEditItem.Path = lvi.SubItems[2].Text;

                    if (this.FormEditItem.ShowDialog() == DialogResult.OK)
                    {
                        lvi.Text = this.FormEditItem.Name;
                        lvi.SubItems[1].Text = this.FormEditItem.Type;
                        lvi.SubItems[2].Text = this.FormEditItem.Path;
                    }
                }
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }
        }


        private void btnControl_MvUp_Click(object sender, EventArgs e)
        {
            try
            {
                this.MoveListViewItem(this.lvControls, this.lvControls.FocusedItem, -1, this.btnControl_MvUp, this.btnControl_MvDown);
                this.lvControls_SelectedIndexChanged(this.lvControls, new EventArgs());
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }
        }

        private void btnControl_MvDown_Click(object sender, EventArgs e)
        {
            try
            {
                this.MoveListViewItem(this.lvControls, this.lvControls.FocusedItem, 1, this.btnControl_MvUp, this.btnControl_MvDown);
                this.lvControls_SelectedIndexChanged(this.lvControls, new EventArgs());
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }
        }

        /** Module Configs **/

        private void lvConfigs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lvConfigs.Items.Count > 0 && this.lvConfigs.SelectedItems.Count > 0)
                {
                    this.btnConfig_Edit.Enabled = true;
                    this.btnConfig_Remove.Enabled = true;

                    if (this.lvConfigs.FocusedItem.Index > 0 && this.lvConfigs.Items.Count > 1)
                    {
                        this.btnConfig_MvUp.Enabled = true;
                    }

                    if (this.lvConfigs.FocusedItem.Index < (this.lvConfigs.Items.Count - 1))
                    {
                        this.btnConfig_MvDown.Enabled = true;
                    }

                    return;
                }
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }

            this.ClearCurrentConfig();
        }

        private void btnConfig_Add_Click(object sender, EventArgs e)
        {
            if (this.lvModules.Items.Count > 0 && this.lvModules.SelectedItems.Count > 0)
            {
                ModuleConfig config = new ModuleConfig();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = config.GetConfigName();
                lvi.SubItems.Add(config.GetConfigType().ToString());
                lvi.SubItems.Add(config.GetConfigPath());
                lvi.Tag = config;
                this.lvConfigs.Items.Add(lvi);
            }
        }

        private void btnConfig_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvConfigs.Items.Count > 0 && this.lvConfigs.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = this.lvConfigs.FocusedItem;
                    this.lvConfigs.Items.Remove(lvi);
                }
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }
        }

        private void btnConfig_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvConfigs.Items.Count > 0 && this.lvConfigs.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = this.lvConfigs.FocusedItem;
                    ModuleConfig config = (ModuleConfig)lvi.Tag;

                    this.FormEditItem = new frmEditItem(config);
                    this.FormEditItem.Name = lvi.Text;
                    this.FormEditItem.Type = lvi.SubItems[1].Text;
                    this.FormEditItem.Path = lvi.SubItems[2].Text;

                    if (this.FormEditItem.ShowDialog() == DialogResult.OK)
                    {
                        lvi.Text = FormEditItem.Name;
                        lvi.SubItems[1].Text = FormEditItem.Type;
                        lvi.SubItems[2].Text = FormEditItem.Path;
                    }
                }
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }
        }



        private void btnConfig_MvUp_Click(object sender, EventArgs e)
        {
            try
            {
                this.MoveListViewItem(this.lvConfigs, this.lvConfigs.FocusedItem, -1, this.btnConfig_MvUp, this.btnConfig_MvDown);
                this.lvControls_SelectedIndexChanged(this.lvConfigs, new EventArgs());
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }
        }

        private void btnConfig_MvDown_Click(object sender, EventArgs e)
        {
            try
            {
                this.MoveListViewItem(this.lvConfigs, this.lvConfigs.FocusedItem, 1, this.btnConfig_MvUp, this.btnConfig_MvDown);
                this.lvControls_SelectedIndexChanged(this.lvConfigs, new EventArgs());
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }
        }

        /** Application Actions **/

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            if (this.Modules.Count > 0 || this.lvModules.Items.Count > 0)
            {
                DialogResult warning = MessageBox.Show("You are loading a new PandaStack configuration file, doing so will remove all unsaved changes. Are you sure you wish to remove all unsaved changes?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (warning != DialogResult.Yes)
                {
                    return;
                }
            }

            // Display a file dialog asking which configuration file to load
            OpenFileDialog ofdConfig = new OpenFileDialog();
            ofdConfig.Title = "Load New Configuration File";
            ofdConfig.Filter = "Configuration File (*.conf;*.json)|*.conf;*.json|All Files (*.*)|*.*";

            if (ofdConfig.ShowDialog() != DialogResult.Cancel)
            {
                // Remove modules
                this.ClearCurrentModule();
                this.lvModules.Items.Clear();
                this.Modules.Clear();

                this.LoadJsonFile(ofdConfig.FileName);
            }
        }

        private void btnImportConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdConfig = new OpenFileDialog();
            ofdConfig.Title = "Import Configuration File";
            ofdConfig.Filter = "Configuration File (*.conf;*.json)|*.conf;*.json|All Files (*.*)|*.*";

            if (ofdConfig.ShowDialog() != DialogResult.Cancel)
            {
                this.LoadJsonFile(ofdConfig.FileName);
            }
        }

        /**
         * <summary>
         * Set the selected module
         * </summary>
         */
        private void updateCurrentModule(Module module)
        {
            this.txtName.Text = module.GetModuleName();
            this.cmbType.Text = module.GetModuleType().ToString();
            this.lvControls.Items.Clear();
            this.lvConfigs.Items.Clear();

            if (module.GetModuleType() == ModuleType.Service)
            {
                this.txtServiceName.Text = module.GetServiceName();
            }
            else if (module.GetModuleType() == ModuleType.Software)
            {
                this.txtFilePath.Text = module.GetProgramPath();
            }

            if (module.GetControls().Count > 0)
            {
                foreach (ModuleControl control in module.GetControls())
                {
                    ListViewItem controlLvi = new ListViewItem();
                    controlLvi.Text = control.GetControlName();
                    controlLvi.SubItems.Add(control.GetControlType().ToString());
                    controlLvi.SubItems.Add(control.GetControlPath());
                    controlLvi.Tag = control;
                    this.lvControls.Items.Add(controlLvi);
                }
            }

            if (module.GetConfigs().Count > 0)
            {
                foreach (ModuleConfig config in module.GetConfigs())
                {
                    ListViewItem configLvi = new ListViewItem();
                    configLvi.Text = config.GetConfigName();
                    configLvi.SubItems.Add(config.GetConfigType().ToString());
                    configLvi.SubItems.Add(config.GetConfigPath());
                    configLvi.Tag = config;
                    this.lvConfigs.Items.Add(configLvi);
                }
            }
        }

        /**
         * <summary>
         * Clear the current module fields
         * </summary>
         */
        private void ClearCurrentModule()
        {
            if (this.lvModules.SelectedItems.Count > 0)
                this.lvModules.FocusedItem.Focused = false;

            this.btnRemove.Enabled = false;
            this.grpModuleOptions.Enabled = false;
            this.txtName.Text = "";
            this.cmbType.Text = "";
            this.txtServiceName.Text = "";
            this.lvControls.Items.Clear();
            this.lvConfigs.Items.Clear();
            this.txtFilePath.Text = "";
            this.btnMvUp.Enabled = false;
            this.btnMvDwn.Enabled = false;

            this.ClearCurrentControl();
            this.ClearCurrentConfig();
        }

        /**
         * <summary>
         * Disable administration management
         * </summary>
         */
        private void ClearCurrentControl()
        {
            this.btnControl_Edit.Enabled = false;
            this.btnControl_Remove.Enabled = false;
            this.btnControl_MvUp.Enabled = false;
            this.btnControl_MvDown.Enabled = false;
        }

        /**
         * <summary>
         * Disable configuration management
         * </summary>
         */
        private void ClearCurrentConfig()
        {
            this.btnConfig_Edit.Enabled = false;
            this.btnConfig_Remove.Enabled = false;
            this.btnConfig_MvUp.Enabled = false;
            this.btnConfig_MvDown.Enabled = false;
        }

        /**
         * <summary>
         * Handles an exception with debugging information
         * </summar>
         */
        private void HandleException(Exception ex)
        {
            StackTrace stackTrace = new StackTrace(ex, true);
            StackFrame stackFrame = stackTrace.GetFrame(0);
            string message = ex.Message + " " + ex.InnerException + "\r\n" + stackFrame.GetFileName() + ":" +
                                stackFrame.GetFileLineNumber() + " -> " + stackFrame.GetMethod();
            MessageBox.Show(message, ex.GetType().ToString());
        }

        /**
         * <summary>
         * Load a PandaStack configuration file
         * </summary>
         */
        private void LoadJsonFile(string filePath)
        {
            JsonHandler jsonHandler = new JsonHandler(filePath);
            jsonHandler.FetchJson();

            foreach (JsonModule jsonModule in jsonHandler.GetModules())
            {
                Module module = new Module();
                module.SetModuleName(jsonModule.name);
                module.SetModuleType((ModuleType)Enum.Parse(typeof(ModuleType), jsonModule.type, true));

                if (module.GetModuleType() == ModuleType.Service)
                {
                    module.SetServiceName(jsonModule.service);
                }

                if (jsonModule.control != null && jsonModule.control.Count > 0)
                {
                    foreach (JsonControl jsonControl in jsonModule.control)
                    {
                        ModuleControl control = new ModuleControl();
                        control.SetControlName(jsonControl.name);
                        control.SetControlType((ControlType)Enum.Parse(typeof(ControlType), jsonControl.type, true));
                        control.SetControlPath(jsonControl.path);

                        module.AddControl(control);
                    }
                }

                if (jsonModule.config != null && jsonModule.config.Count > 0)
                {
                    foreach (JsonConfig jsonConfig in jsonModule.config)
                    {
                        ModuleConfig config = new ModuleConfig();
                        config.SetConfigName(jsonConfig.name);
                        config.SetConfigType((ConfigType)Enum.Parse(typeof(ConfigType), jsonConfig.type, true));
                        config.SetConfigPath(jsonConfig.path);

                        module.AddConfig(config);
                    }
                }

                this.Modules.Add(module);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = module.GetModuleName();
                lvi.Tag = module;
                this.lvModules.Items.Add(lvi);
            }
        }

        /**
         * <summary>
         * Moves an item in a list view
         * </summary>
         */
        private void MoveListViewItem(ListView listView, ListViewItem listViewItem, int indexChange, Button btnMoveUp, Button btnMoveDown)
        {
            if (listViewItem.Index > 0 || listViewItem.Index < (listView.Items.Count-1))
            {
                int index = listViewItem.Index + indexChange;
                listView.Items.RemoveAt(listViewItem.Index);
                listView.Items.Insert(index, listViewItem);
                listView.Items[index].Focused = true;

                btnMoveUp.Enabled = (index > 0 ? true : false);
                btnMoveDown.Enabled = (index < listView.Items.Count-1 ? true : false);
            }
        }

    }

}