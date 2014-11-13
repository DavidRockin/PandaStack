using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DavidRockin.PandaStack.PandaClass;
using DavidRockin.PandaStack.PandaClass.Json;

namespace DavidRockin.PandaStack.ModuleGenerator
{
    public partial class frmMain : Form
    {
        private frmConsole FormConsole;
        private frmEditItem FormEditItem;
        private List<Module> Modules = new List<Module>();

        public frmMain()
        {
            InitializeComponent();
            this.FormConsole = new frmConsole();
            Information.Console = this.FormConsole.rtbConsole;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Information.AddMessage("Settings up PandaStack Module Generator");

            if (Utilities.RunningAsAdmin())
                this.Text += " [Administrator]";

            foreach (ModuleType type in Enum.GetValues(typeof(ModuleType)))
                this.cmbModuleType.Items.Add(type.ToString());
        }

        #region Loaded modules list

        private void lvwModulesLoaded_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lvwModulesLoaded.Items.Count > 0 && this.lvwModulesLoaded.SelectedItems.Count > 0)
                {
                    Module module = (Module)this.lvwModulesLoaded.FocusedItem.Tag;
                    this.SetActiveModule(module);
                    this.grpModuleOptions.Enabled = true;
                    this.btnModuleDelete.Enabled = true;

                    Information.AddMessage("Switching to module " + module.Name);

                    if (this.lvwModulesLoaded.FocusedItem.Index > 0 && this.lvwModulesLoaded.Items.Count > 1)
                        this.btnModuleMvUp.Enabled = true;
                    if (this.lvwModulesLoaded.FocusedItem.Index < (this.lvwModulesLoaded.Items.Count - 1))
                        this.btnModuleMvDown.Enabled = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }

            this.ClearActiveModule();
        }

        #endregion

        #region Module actions

        private void btnModuleCreate_Click(object sender, EventArgs e)
        {
            ListViewItem listItem = new ListViewItem();
            Module module = new Module();
            module.Name += " " + listItem.GetHashCode().ToString();
            listItem.Text = module.Name;
            listItem.Tag = module;
            this.Modules.Add(module);
            this.lvwModulesLoaded.Items.Add(listItem);
        }

        private void btnModuleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure we have modules loaded, and one of them are selected
                if (this.lvwModulesLoaded.Items.Count == 0 || this.lvwModulesLoaded.SelectedItems.Count == 0)
                    return;

                // Remove the selected module
                ListViewItem listItem = this.lvwModulesLoaded.FocusedItem;
                this.lvwModulesLoaded.Items.Remove(listItem);
                this.Modules.Remove((Module)listItem.Tag);
                this.ClearActiveModule();
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        private void btnModuleMvUp_Click(object sender, EventArgs e)
        {
            try
            {
                this.MoveListViewItem(this.lvwModulesLoaded, this.lvwModulesLoaded.FocusedItem, -1, this.btnModuleMvUp, this.btnModuleMvDown);
                this.lvwModulesLoaded_SelectedIndexChanged(this.lvwModulesLoaded, new EventArgs());
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        private void btnModuleMvDown_Click(object sender, EventArgs e)
        {
            try
            {
                this.MoveListViewItem(this.lvwModulesLoaded, this.lvwModulesLoaded.FocusedItem, 1, this.btnModuleMvUp, this.btnModuleMvDown);
                this.lvwModulesLoaded_SelectedIndexChanged(this.lvwModulesLoaded, new EventArgs());
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        #endregion

        #region Module editing

        private void cmbModuleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtModuleService.Enabled = false;
            this.txtModuleProgram.Enabled = false;
            this.btnModuleService.Enabled = false;
            this.btnModuleProgram.Enabled = false;

            if (this.cmbModuleType.Text == "Service")
            {
                this.txtModuleService.Enabled = true;
                this.btnModuleService.Enabled = true;
            }
            else if (this.cmbModuleType.Text == "Software")
            {
                this.txtModuleProgram.Enabled = true;
                this.btnModuleProgram.Enabled = true;
            }
        }

        private void btnModuleService_Click(object sender, EventArgs e)
        {
            frmServiceSelector serviceSelector = new frmServiceSelector();
            serviceSelector.ServiceName = this.txtModuleService.Text;
            if (serviceSelector.ShowDialog() == DialogResult.OK)
                this.txtModuleService.Text = serviceSelector.ServiceName;
        }

        private void btnModuleProgram_Click(object sender, EventArgs e)
        {
            OpenFileDialog mnuFileDialog = new OpenFileDialog();
            mnuFileDialog.Title = "Specify Application";
            mnuFileDialog.Filter = "Application Files (*.exe)|*.exe|Batch files (*.bat;*.com)|*.bat;*.com|All Files (*.*)|*.*";

            if (mnuFileDialog.ShowDialog() != DialogResult.Cancel)
                this.txtModuleProgram.Text = mnuFileDialog.FileName;
        }

        #region Configuration management

        private void lvwModuleConfigs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lvwModuleConfigs.Items.Count > 0 && this.lvwModuleConfigs.SelectedItems.Count > 0)
                {
                    this.btnConfigDelete.Enabled = true;
                    this.btnConfigEdit.Enabled = true;

                    if (this.lvwModuleConfigs.FocusedItem.Index > 0 && this.lvwModuleConfigs.Items.Count > 1)
                        this.btnConfigMvUp.Enabled = true;
                    if (this.lvwModuleConfigs.FocusedItem.Index < (this.lvwModuleConfigs.Items.Count - 1))
                        this.btnConfigMvDown.Enabled = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }

            this.ClearModuleConfigs();
        }

        private void btnConfigCreate_Click(object sender, EventArgs e)
        {
            if (this.lvwModulesLoaded.Items.Count > 0 && this.lvwModulesLoaded.SelectedItems.Count > 0)
            {
                ModuleConfig config = new ModuleConfig();
                ListViewItem listConfigItem = new ListViewItem();
                listConfigItem.Text = config.Name;
                listConfigItem.SubItems.Add(config.Type.ToString());
                listConfigItem.SubItems.Add(config.Path);
                listConfigItem.Tag = config;
                this.lvwModuleConfigs.Items.Add(listConfigItem);
            }
        }

        private void btnConfigDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvwModuleConfigs.Items.Count > 0 && this.lvwModuleConfigs.SelectedItems.Count > 0)
                {
                    ListViewItem listConfigItem = this.lvwModuleConfigs.FocusedItem;
                    this.lvwModuleConfigs.Items.Remove(listConfigItem);
                }
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        private void btnConfigEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvwModuleConfigs.Items.Count > 0 && this.lvwModuleConfigs.SelectedItems.Count > 0)
                {
                    ListViewItem listConfigItem = this.lvwModuleConfigs.FocusedItem;
                    ModuleConfig config = (ModuleConfig)listConfigItem.Tag;

                    this.FormEditItem = new frmEditItem(config);
                    this.FormEditItem.Name = listConfigItem.Text;
                    this.FormEditItem.Type = listConfigItem.SubItems[1].Text;
                    this.FormEditItem.Path = listConfigItem.SubItems[2].Text;

                    if (this.FormEditItem.ShowDialog() == DialogResult.OK)
                    {
                        listConfigItem.Text = this.FormEditItem.Name;
                        listConfigItem.SubItems[1].Text = this.FormEditItem.Type;
                        listConfigItem.SubItems[2].Text = this.FormEditItem.Path;
                    }
                }
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        private void btnConfigMvUp_Click(object sender, EventArgs e)
        {
            try
            {
                this.MoveListViewItem(this.lvwModuleConfigs, this.lvwModuleConfigs.FocusedItem, -1, this.btnConfigMvUp, this.btnConfigMvDown);
                this.lvwModuleConfigs_SelectedIndexChanged(this.lvwModuleConfigs, new EventArgs());
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        private void btnConfigMvDown_Click(object sender, EventArgs e)
        {
            try
            {
                this.MoveListViewItem(this.lvwModuleConfigs, this.lvwModuleConfigs.FocusedItem, 1, this.btnConfigMvUp, this.btnConfigMvDown);
                this.lvwModuleConfigs_SelectedIndexChanged(this.lvwModuleConfigs, new EventArgs());
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        #endregion

        #region Control management

        private void lvwModuleControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lvwModuleControls.Items.Count > 0 && this.lvwModuleControls.SelectedItems.Count > 0)
                {
                    this.btnControlDelete.Enabled = true;
                    this.btnControlEdit.Enabled = true;

                    if (this.lvwModuleControls.FocusedItem.Index > 0 && this.lvwModuleControls.Items.Count > 1)
                        this.btnControlMvUp.Enabled = true;
                    if (this.lvwModuleControls.FocusedItem.Index < (this.lvwModuleControls.Items.Count - 1))
                        this.btnControlMvDown.Enabled = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }

            this.ClearModuleControls();
        }

        private void btnControlCreate_Click(object sender, EventArgs e)
        {
            if (this.lvwModulesLoaded.Items.Count > 0 && this.lvwModulesLoaded.SelectedItems.Count > 0)
            {
                ModuleControl control = new ModuleControl();
                ListViewItem listControlItem = new ListViewItem();
                listControlItem.Text = control.Name;
                listControlItem.SubItems.Add(control.Type.ToString());
                listControlItem.SubItems.Add(control.Path);
                listControlItem.Tag = control;
                this.lvwModuleControls.Items.Add(listControlItem);
            }
        }

        private void btnControlDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvwModuleControls.Items.Count > 0 && this.lvwModuleControls.SelectedItems.Count > 0)
                {
                    ListViewItem listControlItem = this.lvwModuleControls.FocusedItem;
                    this.lvwModuleControls.Items.Remove(listControlItem);
                }
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        private void btnControlEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvwModuleControls.Items.Count > 0 && this.lvwModuleControls.SelectedItems.Count > 0)
                {
                    ListViewItem listControlItem = this.lvwModuleControls.FocusedItem;
                    ModuleControl control = (ModuleControl)listControlItem.Tag;

                    this.FormEditItem = new frmEditItem(control);
                    this.FormEditItem.Name = listControlItem.Text;
                    this.FormEditItem.Type = listControlItem.SubItems[1].Text;
                    this.FormEditItem.Path = listControlItem.SubItems[2].Text;

                    if (this.FormEditItem.ShowDialog() == DialogResult.OK)
                    {
                        listControlItem.Text = this.FormEditItem.Name;
                        listControlItem.SubItems[1].Text = this.FormEditItem.Type;
                        listControlItem.SubItems[2].Text = this.FormEditItem.Path;
                    }
                }
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        private void btnControlMvUp_Click(object sender, EventArgs e)
        {
            try
            {
                this.MoveListViewItem(this.lvwModuleControls, this.lvwModuleControls.FocusedItem, -1, this.btnControlMvUp, this.btnControlMvDown);
                this.lvwModuleControls_SelectedIndexChanged(this.lvwModuleControls, new EventArgs());
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        private void btnControlMvDown_Click(object sender, EventArgs e)
        {
            try
            {
                this.MoveListViewItem(this.lvwModuleControls, this.lvwModuleControls.FocusedItem, 1, this.btnControlMvUp, this.btnControlMvDown);
                this.lvwModuleControls_SelectedIndexChanged(this.lvwModuleControls, new EventArgs());
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        #endregion

        #region Module actions

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.lvwModulesLoaded.Items.Count == 0 || this.lvwModulesLoaded.SelectedItems.Count == 0)
                return;

            ListViewItem listModuleItem = this.lvwModulesLoaded.FocusedItem;
            Module module = (Module)listModuleItem.Tag;
            
            module.Name = this.txtModuleName.Text.Trim();
            module.Type = (ModuleType)Enum.Parse(typeof(ModuleType), this.cmbModuleType.Text.Trim(), true);
            listModuleItem.Text = module.Name;

            if (this.cmbModuleType.Text == "Service") module.ServiceName = this.txtModuleService.Text;
            else if (this.cmbModuleType.Text == "Software") module.SoftwarePath = this.txtModuleProgram.Text;

            module.Configs.Clear();
            module.Controls.Clear();

            if (this.lvwModuleConfigs.Items.Count > 0)
            {
                foreach (ListViewItem listConfigItem in this.lvwModuleConfigs.Items)
                {
                    ModuleConfig config = (ModuleConfig)listConfigItem.Tag;
                    config.Name = listConfigItem.Text.Trim();
                    config.Type = (ConfigType)Enum.Parse(typeof(ConfigType), listConfigItem.SubItems[1].Text.Trim(), true);
                    config.Path = listConfigItem.SubItems[2].Text.Trim();
                    module.AddConfig(config);
                }
            }

            if (this.lvwModuleControls.Items.Count > 0)
            {
                foreach (ListViewItem listControlItem in this.lvwModuleControls.Items)
                {
                    ModuleControl control = (ModuleControl)listControlItem.Tag;
                    control.Name = listControlItem.Text.Trim();
                    control.Type = (ControlType)Enum.Parse(typeof(ControlType), listControlItem.SubItems[1].Text.Trim(), true);
                    control.Path = listControlItem.SubItems[2].Text.Trim();
                    module.AddControl(control);
                }
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            if (this.lvwModulesLoaded.Items.Count > 0 && this.lvwModulesLoaded.SelectedItems.Count > 0)
            {
                // It's an interesting way of "discarding" changes, but it
                // atleast works, eh?
                ListViewItem listModuleItem  = this.lvwModulesLoaded.FocusedItem;
                this.SetActiveModule((Module)listModuleItem.Tag);
            }
        }

        #endregion

        #endregion

        #region Actions

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (this.Modules.Count > 0 || this.lvwModulesLoaded.Items.Count > 0)
            {
                DialogResult warning = MessageBox.Show("You are about to load a new PandaStack Configuration file, doing so will discard any unsaved changes. " +
                    "If you wish to save, you must click 'Save' then 'Export'. Are you sure you would like to remove all unsaved changes?",
                    "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (warning != DialogResult.Yes) return;
            }

            // Display a file dialog asking which configuration file to load
            OpenFileDialog mnuLoadConfig = new OpenFileDialog();
            mnuLoadConfig.Title = "Load New Configuration File";
            mnuLoadConfig.Filter = "Configuration File (*.conf;*.json)|*.conf;*.json|All Files (*.*)|*.*";

            if (mnuLoadConfig.ShowDialog() != DialogResult.Cancel)
            {
                // Remove modules
                this.ClearActiveModule();
                this.lvwModulesLoaded.Items.Clear();
                this.Modules.Clear();

                this.LoadConfigFile(mnuLoadConfig.FileName);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog mnuImportConfig = new OpenFileDialog();
            mnuImportConfig.Title = "Import Configuration File";
            mnuImportConfig.Filter = "Configuration File (*.conf;*.json)|*.conf;*.json|All Files (*.*)|*.*";

            if (mnuImportConfig.ShowDialog() != DialogResult.Cancel)
                this.LoadConfigFile(mnuImportConfig.FileName);
        }

        private void btnConsole_Click(object sender, EventArgs e)
        {
            this.FormConsole.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog mnuExportConfig = new SaveFileDialog();
            mnuExportConfig.Filter = "PandaStack Config (.conf)|PandaStack.conf|Configuration File (*.conf)|*.conf|All Files (*.*)|*.*";
            mnuExportConfig.Title = "Export Configuration";

            if (mnuExportConfig.ShowDialog() != DialogResult.Cancel && mnuExportConfig.FileName != "")
            {
                Program.PandaStack.ModulesToJson(this.Modules);
                StreamWriter file = new StreamWriter(mnuExportConfig.FileName);
                file.WriteLine(Program.PandaStack.JsonHandler.Serialize());
                file.Close();
            }
        }

        #endregion

        #region Functions

        private void SetActiveModule(Module module)
        {
            this.CleanActiveModule();

            this.txtModuleName.Text = module.Name;
            this.cmbModuleType.Text = module.Type.ToString();

            if (module.Type == ModuleType.Service)
                this.txtModuleService.Text = module.ServiceName;
            else if (module.Type == ModuleType.Software)
                this.txtModuleProgram.Text = module.SoftwarePath;

            if (module.Configs.Count > 0)
            {
                foreach (ModuleConfig config in module.Configs)
                {
                    ListViewItem configItem = new ListViewItem();
                    configItem.Text = config.Name;
                    configItem.SubItems.Add(config.Type.ToString());
                    configItem.SubItems.Add(config.Path);
                    configItem.Tag = config;

                    this.lvwModuleConfigs.Items.Add(configItem);
                }
            }

            if (module.Controls.Count > 0)
            {
                foreach (ModuleControl control in module.Controls)
                {
                    ListViewItem controlItem = new ListViewItem();
                    controlItem.Text = control.Name;
                    controlItem.SubItems.Add(control.Type.ToString());
                    controlItem.SubItems.Add(control.Path);
                    controlItem.Tag = control;

                    this.lvwModuleControls.Items.Add(controlItem);
                }
            }
        }

        private void LoadConfigFile(string filePath)
        {
            List<Module> modules = Program.PandaStack.LoadConfiguration(filePath);
            if (modules == null)
            {
                Information.AddMessage("Failed to load configuration file!", InfoType.Error);
                return;
            }

            if (modules.Count > 0)
            {
                foreach (Module module in modules)
                {
                    ListViewItem listModuleItem = new ListViewItem();
                    listModuleItem.Text = module.Name;
                    listModuleItem.Tag = module;
                    this.lvwModulesLoaded.Items.Add(listModuleItem);
                    this.Modules.Add(module);
                }
            }
        }

        private void MoveListViewItem(ListView listView, ListViewItem listViewItem, int indexChange, Button btnMoveUp, Button btnMoveDown)
        {
            if (listViewItem.Index > 0 || listViewItem.Index < (listView.Items.Count - 1))
            {
                int index = listViewItem.Index + indexChange;
                listView.Items.RemoveAt(listViewItem.Index);
                listView.Items.Insert(index, listViewItem);
                listView.Items[index].Focused = true;

                btnMoveUp.Enabled = (index > 0);
                btnMoveDown.Enabled = (index < listView.Items.Count - 1);
            }
        }

        /**
         * <summary>
         * Resets the active module
         * </summary>
         */
        private void ClearActiveModule()
        {
            Information.AddMessage("Clearing active module");
            this.grpModuleOptions.Enabled = false;
            this.btnModuleDelete.Enabled = false;
            this.btnModuleMvUp.Enabled = false;
            this.btnModuleMvDown.Enabled = false;

            this.CleanActiveModule();
        }

        /**
         * <summary>
         * Resets the active module edtior
         * </summary>
         */
        private void CleanActiveModule()
        {
            this.txtModuleName.Clear();
            this.cmbModuleType.Text = "";
            this.txtModuleService.Clear();
            this.txtModuleProgram.Clear();
            this.lvwModuleConfigs.Items.Clear();
            this.lvwModuleControls.Items.Clear();

            this.ClearModuleConfigs();
            this.ClearModuleControls();
        }

        /**
         * <summary>
         * Resets the module configs
         * </summary>
         */
        private void ClearModuleConfigs()
        {
            this.btnConfigDelete.Enabled = false;
            this.btnConfigEdit.Enabled = false;
            this.btnConfigMvUp.Enabled = false;
            this.btnConfigMvDown.Enabled = false;
        }

        /**
         * <summary>
         * Resets the module controls
         * </summary>
         */
        private void ClearModuleControls()
        {
            this.btnControlDelete.Enabled = false;
            this.btnControlEdit.Enabled = false;
            this.btnControlMvUp.Enabled = false;
            this.btnControlMvDown.Enabled = false;
        }

        #endregion
    }
}
