using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.ServiceProcess;
using DavidRockin.PandaStack.PandaClass;

namespace DavidRockin.PandaStack.PandaStack
{
    public partial class frmMain : Form
    {
        private int SortColumn = -1;
        private frmAbout FormAbout = new frmAbout();
        private frmSettings FormSettings = new frmSettings();

        public frmMain()
        {
            InitializeComponent();
            Information.Console = this.rtbConsole;
        }
        
        #region Form

        private void frmMain_Load(object sender, EventArgs e)
        {
            Information.AddMessage("Setting up PandaStack");
            Information.AddMessage("Loading modules");
            Program.PandaStack.LoadModules();

            Information.AddMessage("Fetching " + Program.PandaStack.JsonHandler.GetModules().Count + " modules");
            this.FetchModules();

            if (Utilities.RunningAsAdmin())
                this.Text += " [Administrator]";

            // Should we minimize PandaStack?
            if (Program.PandaStack.JsonHandler.GetSettings().startMinimized)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Minimize();
            }

            if (Program.PandaStack.JsonHandler.GetSettings().timerEnabled)
            {
                this.tmrServiceUpdate.Enabled = true;
                this.tmrServiceUpdate.Interval = Program.PandaStack.JsonHandler.GetSettings().timerInterval;
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            // If we are to minimize to tray, make sure we are allowed to
            if (Program.PandaStack.JsonHandler.GetSettings().minimizeToTray &&
                this.WindowState == FormWindowState.Minimized)
                this.Minimize();
        }
        
        private void tmrServiceUpdate_Tick(object sender, EventArgs e)
        {
            foreach (ListViewItem listModuleItem in this.lvwModulesLoaded.Items)
            {
                try
                {
                    Module module = (Module)listModuleItem.Tag;
                    if (module.Type == ModuleType.Service)
                    {
                        listModuleItem.SubItems[1].Text = module.GetModuleStatus();
                    }
                    else if (module.Type == ModuleType.Software)
                    {
                        // TODO: Update software
                    }
                }
                catch (Exception ex)
                {
                    Information.HandleException(ex);
                }
            }
        }

        #endregion

        #region Loaded modules list
        
        private void lvwModulesLoaded_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvwModulesLoaded.Items.Count > 0 && this.lvwModulesLoaded.SelectedItems.Count > 0)
            {
                ListViewItem listItem = this.lvwModulesLoaded.SelectedItems[0];
                this.UpdateModule((Module)listItem.Tag);
            }
            else
            {
                this.ResetModuleControl();
            }
        }

        private void lvwModulesLoaded_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != this.SortColumn)
            {
                this.SortColumn = e.Column;
                this.lvwModulesLoaded.Sorting = SortOrder.Ascending;
            }
            else
            {
                this.lvwModulesLoaded.Sorting = (this.lvwModulesLoaded.Sorting == SortOrder.Descending
                    ? SortOrder.Ascending : SortOrder.Descending);
            }
            this.lvwModulesLoaded.Sort();
            this.lvwModulesLoaded.ListViewItemSorter = new ListViewItemComparer(e.Column, this.lvwModulesLoaded.Sorting);
        }

        #endregion

        #region Module control

        private void btnModuleToggle_Click(object sender, EventArgs e)
        {
            // This button can only be clickable if there is a module selected
            if (this.lvwModulesLoaded.Items.Count == 0 || this.lvwModulesLoaded.SelectedItems.Count == 0 || !Utilities.RunningAsAdmin())
                return;

            Module module = (Module)this.lvwModulesLoaded.FocusedItem.Tag;

            try
            {
                if (module.Type == ModuleType.Service)
                {
                    // Module needs to have the service controller active
                    if (module.ServiceController == null) return;

                    // Attempt to toggle the service
                    if (module.ServiceController.Status == ServiceControllerStatus.Stopped) module.ServiceController.Start();
                    else module.ServiceController.Stop();

                    // Update module status
                    module.ServiceController.Refresh();
                    this.btnModuleToggle.Text = (module.ServiceController.Status == ServiceControllerStatus.Stopped
                        ? "Start Module" : "Stop Module");
                    this.btnModuleToggle.Image = (module.ServiceController.Status == ServiceControllerStatus.Stopped ?
                        Properties.Resources.control_play : Properties.Resources.control_stop);
                    this.lvwModulesLoaded.FocusedItem.SubItems[1].Text = module.GetModuleStatus();
                }
                else if (module.Type == ModuleType.Software)
                {
                    // TODO: Toggle software
                }
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        private void btnModuleConfigs_Click(object sender, EventArgs e)
        {
            // This button can only be clickable if there is a module selected
            if (this.lvwModulesLoaded.Items.Count == 0 || this.lvwModulesLoaded.SelectedItems.Count == 0)
                return;

            Module module = (Module)this.lvwModulesLoaded.FocusedItem.Tag;
            ToolStripMenuItem menuItem;
            this.cmsConfig.Items.Clear();

            if (module.Configs.Count > 0)
            {
                foreach (ModuleConfig config in module.Configs)
                {
                    if (config.Type == ConfigType.Separator)
                    {
                        this.cmsConfig.Items.Add(new ToolStripSeparator());
                        continue;
                    }

                    menuItem = new ToolStripMenuItem();
                    menuItem.Text = config.Name;
                    menuItem.Tag = config;
                    menuItem.Click += new EventHandler(this.cmsConfig_ItemClicked);

                    // Assign an icon based on type
                    switch (config.Type)
                    {
                        case ConfigType.File:
                            menuItem.Image = Properties.Resources.page_white_edit;
                            break;
                        case ConfigType.Directory:
                            menuItem.Image = Properties.Resources.folder;
                            break;
                        case ConfigType.Software:
                            menuItem.Image = Properties.Resources.application;
                            break;
                        case ConfigType.Url:
                            menuItem.Image = Properties.Resources.world;
                            break;
                    }

                    this.cmsConfig.Items.Add(menuItem);
                    menuItem = null;
                }
            }

            this.cmsConfig.Show(btnModuleConfigs, new Point(0, btnModuleConfigs.Height));
        }
        private void cmsConfig_ItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ModuleConfig config = (ModuleConfig)menuItem.Tag;
            Module module = (Module)this.lvwModulesLoaded.FocusedItem.Tag;

            Information.AddMessage("Handling config '" + config.Name + "' for module '" + module.Name + "'");
            try
            {
                Process.Start(config.Path, config.Arguments);
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        private void btnModuleControls_Click(object sender, EventArgs e)
        {
            // This button can only be clickable if there is a module selected
            if (this.lvwModulesLoaded.Items.Count == 0 || this.lvwModulesLoaded.SelectedItems.Count == 0)
                return;

            Module module = (Module)this.lvwModulesLoaded.FocusedItem.Tag;
            ToolStripMenuItem menuItem;
            this.cmsControl.Items.Clear();

            if (module.Controls.Count > 0)
            {
                foreach (ModuleControl control in module.Controls)
                {
                    if (control.Type == ControlType.Separator)
                    {
                        this.cmsControl.Items.Add(new ToolStripSeparator());
                        continue;
                    }

                    menuItem = new ToolStripMenuItem();
                    menuItem.Text = control.Name;
                    menuItem.Tag = control;
                    menuItem.Click += new EventHandler(this.cmsControl_ItemClicked);

                    // Assign an icon based on type
                    switch (control.Type)
                    {
                        case ControlType.Command:
                            menuItem.Image = Properties.Resources.application_xp_terminal;
                            break;
                        case ControlType.Software:
                            menuItem.Image = Properties.Resources.application;
                            break;
                        case ControlType.Url:
                            menuItem.Image = Properties.Resources.world;
                            break;
                    }

                    this.cmsControl.Items.Add(menuItem);
                    menuItem = null;
                }
            }

            this.cmsControl.Show(btnModuleControls, new Point(0, btnModuleControls.Height));
        }
        private void cmsControl_ItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ModuleControl control = (ModuleControl)menuItem.Tag;
            Module module = (Module)this.lvwModulesLoaded.FocusedItem.Tag;

            Information.AddMessage("Handling control '" + control.Name + "' for module '" + module.Name + "'");
            try
            {
                Process.Start(control.Path, control.Arguments);
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        #endregion

        #region PandaStack actions

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Information.AddMessage("Reloading modules", InfoType.Debug);
            this.RefreshConfig();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.FormAbout = new frmAbout();
            this.FormAbout.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.FormSettings = new frmSettings();
            if (this.FormSettings.ShowDialog() == DialogResult.OK)
            {
                Information.AddMessage("Settings saved, reloading PandaStack", InfoType.Info);
                this.RefreshConfig();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Console

        private void cmsConsole_Copy_Click(object sender, EventArgs e)
        {
            this.rtbConsole.Copy();
        }

        private void cmsConsole_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog mnuConsoleSave = new SaveFileDialog();
            mnuConsoleSave.Filter = "Rich Text Format (.rtf)|*.rtf|Log Files (*.log)|*.log|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            mnuConsoleSave.Title = "Save Console Output";

            if (mnuConsoleSave.ShowDialog() != DialogResult.Cancel && mnuConsoleSave.FileName != "")
                this.rtbConsole.SaveFile(mnuConsoleSave.FileName);
        }

        private void cmsConsole_SelectAll_Click(object sender, EventArgs e)
        {
            this.rtbConsole.SelectAll();
        }

        private void cmsConsole_Clear_Click(object sender, EventArgs e)
        {
            this.rtbConsole.Clear();
        }

        #endregion

        #region Minimization

        private void niMinimize_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.RestoreApplication();
        }

        private void cmsMinimize_Restore_Click(object sender, EventArgs e)
        {
            this.RestoreApplication();
        }

        private void cmsMinimize_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Functions

        private void UpdateModule(Module module)
        {
            this.grpModuleControl.Text = "Module Control: " + module.Name;
            this.btnModuleConfigs.Enabled = (module.Configs.Count > 0);
            this.btnModuleControls.Enabled = (module.Controls.Count > 0);

            try
            {
                if (module.Type == ModuleType.Service && Utilities.RunningAsAdmin())
                {
                    if (module.ServiceController == null) return;
                    module.ServiceController.Refresh();
                    this.btnModuleToggle.Text = (module.ServiceController.Status == ServiceControllerStatus.Stopped
                        ? "Start Module" : "Stop Module");
                    this.btnModuleToggle.Image = (module.ServiceController.Status == ServiceControllerStatus.Stopped ?
                        Properties.Resources.control_play : Properties.Resources.control_stop);
                    this.btnModuleToggle.Enabled = true;
                }
                else if (module.Type == ModuleType.Software)
                {
                    // TODO: Handle software
                }
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        private void Minimize()
        {
            this.ResetModuleControl();
            this.ShowInTaskbar = false;
            this.niMinimize.Visible = true;

            // Display the tooltip notification?
            if (Program.PandaStack.JsonHandler.GetSettings().minimizeToolTip)
                this.niMinimize.ShowBalloonTip(3000);
        }

        private void RefreshConfig()
        {
            this.ResetModuleControl();
            this.lvwModulesLoaded.Items.Clear();
            Program.PandaStack.ReloadModules();
            this.FetchModules();

            if (Program.PandaStack.JsonHandler.GetSettings().timerEnabled)
            {
                this.tmrServiceUpdate.Enabled = true;
                this.tmrServiceUpdate.Interval = Program.PandaStack.JsonHandler.GetSettings().timerInterval;
            }
            else
            {
                this.tmrServiceUpdate.Enabled = false;
            }
        }

        private void FetchModules()
        {
            List<Module> loadedModules = Program.PandaStack.Modules;
            ListViewItem listItem;

            foreach (Module module in loadedModules)
            {
                Information.AddMessage("Loading module '" + module.Name + "' with " + module.Configs.Count + " configs, and " + module.Controls.Count + " controls", InfoType.Debug);
                listItem = new ListViewItem();
                listItem.Text = module.Name;
                listItem.SubItems.Add(module.GetModuleStatus());
                listItem.SubItems.Add(module.Type.ToString());
                listItem.Tag = module;

                this.lvwModulesLoaded.Items.Add(listItem);
                listItem = null;
            }
        }

        private void ResetModuleControl()
        {
            // Loose focus from selected items
            if (this.lvwModulesLoaded.Items.Count > 0 && this.lvwModulesLoaded.SelectedItems.Count > 0)
                this.lvwModulesLoaded.SelectedItems.Clear();

            // Disable buttons
            this.btnModuleToggle.Enabled = false;
            this.btnModuleConfigs.Enabled = false;
            this.btnModuleControls.Enabled = false;

            // Reset buttons
            this.grpModuleControl.Text = "Module Control";
            this.btnModuleToggle.Text = "Start Module";
            this.btnModuleToggle.Image = Properties.Resources.control_play;

            // Clear context menus
            this.cmsConfig.Items.Clear();
            this.cmsControl.Items.Clear();
        }

        public void RestoreApplication()
        {
            this.ResetModuleControl();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.niMinimize.Visible = false;
        }

        #endregion
    }
}
