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

        private void lvModules_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (this.lvModules.Items.Count > 0 && this.lvModules.SelectedItems.Count > 0)
                {
                    Module module = (Module)this.lvModules.FocusedItem.Tag;
                    this.updateCurrentModule(module);
                    this.grpModuleOptions.Enabled = true;
                    this.btnRemove.Enabled = true;

                    return;
                }
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }

            this.ClearCurrentModule();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Module module = new Module();
            ListViewItem lvi = new ListViewItem();
            lvi.Text = module.GetModuleName();
            lvi.Tag = module;

            this.Modules.Add(module);
            this.lvModules.Items.Add(lvi);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvModules.SelectedItems.Count > 0)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.lvModules.Items.Count > 0 && this.lvModules.SelectedItems.Count > 0)
            {
                ListViewItem lvi = this.lvModules.FocusedItem;
                Module module = (Module)lvi.Tag;

                module.SetModuleName(txtName.Text);
                module.SetModuleType((ModuleType)Enum.Parse(typeof(ModuleType), cmbType.Text));

                if (cmbType.Text == "Service")
                {
                    module.SetServiceName(txtServiceName.Text);
                }

                lvi.Text = txtName.Text;
                module.ClearConfigs();
                module.ClearControls();

                if (this.lvControls.Items.Count > 0)
                {
                    foreach (ListViewItem alvi in this.lvControls.Items)
                    {
                        ModuleControl control = (ModuleControl)alvi.Tag;
                        control.SetControlName(alvi.Text);
                        control.SetControlType((ControlType)Enum.Parse(typeof(ControlType), alvi.SubItems[1].Text));
                        control.SetControlPath(alvi.SubItems[2].Text);
                        module.AddControl(control);
                    }
                }

                if (this.lvConfigs.Items.Count > 0)
                {
                    foreach (ListViewItem clvi in this.lvConfigs.Items)
                    {
                        ModuleConfig config = (ModuleConfig)clvi.Tag;
                        config.SetConfigName(clvi.Text);
                        config.SetConfigType((ConfigType)Enum.Parse(typeof(ConfigType), clvi.SubItems[1].Text));
                        config.SetConfigPath(clvi.SubItems[2].Text);
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

                txtName.Text = module.GetModuleName();
                cmbType.Text = module.GetModuleType().ToString();
                lvi.Text = module.GetModuleName();

                this.lvControls.Items.Clear();
                this.lvConfigs.Items.Clear();

                foreach (ModuleControl control in module.GetControls())
                {
                    ListViewItem controlLvi = new ListViewItem();
                    controlLvi.Text = control.GetControlName();
                    controlLvi.SubItems.Add(control.GetControlType().ToString());
                    controlLvi.SubItems.Add(control.GetControlPath());
                    controlLvi.Tag = control;
                    this.lvControls.Items.Add(controlLvi);
                }

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

        private void lvAdmins_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lvControls.Items.Count > 0 && this.lvControls.SelectedItems.Count > 0)
                {
                    this.btnControl_Remove.Enabled = true;
                    this.btnControl_Edit.Enabled = true;
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

        private void lvConfigs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lvConfigs.Items.Count > 0 && this.lvConfigs.SelectedItems.Count > 0)
                {
                    this.btnConfig_Edit.Enabled = true;
                    this.btnConfig_Remove.Enabled = true;
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

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            DialogResult warning = MessageBox.Show("You are loading a new PandaStack configuration file, doing so will remove all unsaved changes. Are you sure you wish to remove all unsaved changes?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (warning == DialogResult.Yes)
            {
                // Remove modules
                this.ClearCurrentModule();
                this.lvModules.Items.Clear();
                this.Modules.Clear();

                // Display a file dialog asking which configuration file to load
                OpenFileDialog ofdConfig = new OpenFileDialog();
                ofdConfig.Title = "Load New Configuration File";
                ofdConfig.Filter = "Configuration File (*.conf;*.json)|*.conf;*.json|All Files (*.*)|*.*";

                if (ofdConfig.ShowDialog() != DialogResult.Cancel)
                {
                    this.LoadJsonFile(ofdConfig.FileName);
                }
            }
            else
            {
                // Do nothing
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

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbType.Text == "Service")
            {
                this.txtServiceName.Enabled = true;
            }
            else
            {
                this.txtServiceName.Enabled = false;
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
                module.SetModuleType((ModuleType)Enum.Parse(typeof(ModuleType), this.Ucfirst(jsonModule.type)));
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
                        control.SetControlType((ControlType)Enum.Parse(typeof(ControlType), this.Ucfirst(jsonControl.type)));
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
                        config.SetConfigType((ConfigType)Enum.Parse(typeof(ConfigType), this.Ucfirst(jsonConfig.type)));
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
         * Turns the first character of a string to uppercase
         * </summary>
         * <returns>
         * String
         * </returns>
         */
        private string Ucfirst(string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1);
        }

    }

}