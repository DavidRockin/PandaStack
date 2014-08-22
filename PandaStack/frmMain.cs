using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using System.IO;
using System.Diagnostics;

namespace PandaStack
{

    public partial class frmMain : Form
    {

        private PandaStack PandaStack;
        private frmAbout FormAbout = new frmAbout();
        private frmSettings FormSettings = new frmSettings();

        private int SortColumn = -1;

        public frmMain()
        {
            InitializeComponent();
            
            // Setup PandaStack
            this.PandaStack = Program.PandaStack;
            this.PandaStack.LoadModules();

            Information.Form = this;
            Information.AddMessage("Setting up PandaStack");

            // Check to see if PandaStack is running as administrator
            if (Program.IsAdministrator())
            {
                this.Text += " [Administrator]";
                Information.AddMessage("PandaStack is running as administrator");
            }

            this.tmrSync.Interval = this.PandaStack.GetJsonHandler().GetSettings().timerInterval;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Setup lvModule's columns
            this.lvModules.Columns.Add("Module Name", 150, HorizontalAlignment.Left);
            this.lvModules.Columns.Add("Module Status", 130, HorizontalAlignment.Left);
            this.lvModules.Columns.Add("Module Type", 130, HorizontalAlignment.Left);

            // Put the loaded modules into the lvModules list view
            this.FetchModules();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.PandaStack.GetJsonHandler().GetSettings().minimizeToTray != true)
                return;

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.niMinimize.Visible = true;

                if (this.PandaStack.GetJsonHandler().GetSettings().minimizeToolTip == true)
                    this.niMinimize.ShowBalloonTip(3000);

                this.tmrSync.Enabled = false;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Information.AddMessage("Exiting PandaStack");

            try
            {
                if (this.PandaStack.GetModules().Count > 0)
                {
                    foreach (Module module in this.PandaStack.GetModules())
                    {
                        if (module.GetModuleType() == ModuleType.Software)
                        {
                            module.GetModuleProcess().Kill();
                        }
                    }
                }
            }
            catch { }

            e.Cancel = false;
        }

        private void lvModules_SelectIndexChange(object sender, EventArgs e)
        {
            if (this.lvModules.Items.Count > 0 && this.lvModules.SelectedItems.Count > 0)
            {
                Module module = (Module)this.lvModules.FocusedItem.Tag;
                Information.AddMessage("Selected the module " + module.GetModuleName(), InfoType.Debug);
                grpModuleControl.Text = "Module Control: " + module.GetModuleName();

                // If the module is a service, we need to check it's status
                if (module.GetModuleType() == ModuleType.Service)
                {
                    try
                    {
                        ServiceController serviceController = module.GetServiceController();
                        if (serviceController != null)
                        {
                            this.btnToggle.Text = (serviceController.Status == ServiceControllerStatus.Stopped
                                                    ? "Start Module" : "Stop Module");
                            this.btnToggle.Image = (serviceController.Status == ServiceControllerStatus.Stopped
                                                    ? Properties.Resources.control_play : Properties.Resources.control_stop);
                            this.btnToggle.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Information.HandleException(ex);
                    }
                }
                else if (module.GetModuleType() == ModuleType.Software)
                {
                    try
                    {
                        Process process = module.GetModuleProcess();
                        if (process != null)
                        {
                            process.Refresh();
                            this.btnToggle.Text = (process.HasExited ? "Start Module" : "Stop Module");
                            this.btnToggle.Image = (process.HasExited ? Properties.Resources.control_play : Properties.Resources.control_stop);
                            this.btnToggle.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Information.HandleException(ex);
                    }
                }

                // If there are any controls, enable the control button
                if (module.GetControls().Count > 0)
                {
                    this.btnControl.Enabled = true;
                }

                // If there are any configs, enable the config button
                if (module.GetConfigs().Count > 0)
                {
                    this.btnConfig.Enabled = true;
                }
            }
            else
            {
                this.ResetModuleControl();
            }
        }

        private void lvModules_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != this.SortColumn)
            {
                this.SortColumn = e.Column;
                this.lvModules.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (this.lvModules.Sorting == SortOrder.Ascending)
                {
                    this.lvModules.Sorting = SortOrder.Descending;
                }
                else
                {
                    this.lvModules.Sorting = SortOrder.Ascending;
                }
            }

            this.lvModules.Sort();
            this.lvModules.ListViewItemSorter = new ListViewItemComparer(e.Column, this.lvModules.Sorting);
        }

        private void tmrSync_Tick(object sender, EventArgs e)
        {
            if (this.lvModules.Items.Count == 0)
                return;

            // Is there a selected module?
            if (this.lvModules.SelectedItems.Count > 0)
            {
                Module module = (Module)this.lvModules.FocusedItem.Tag;

                // If the module is a service, we need to check it's status
                if (module.GetModuleType() == ModuleType.Service)
                {
                    try
                    {
                        ServiceController serviceController = module.GetServiceController();
                        if (serviceController != null)
                        {
                            this.btnToggle.Text = (serviceController.Status == ServiceControllerStatus.Stopped
                                                    ? "Start Module" : "Stop Module");
                            this.btnToggle.Image = (serviceController.Status == ServiceControllerStatus.Stopped
                                                     ? Properties.Resources.control_play : Properties.Resources.control_stop);
                            this.btnToggle.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        //Information.HandleException(ex);
                    }
                }
                else if (module.GetModuleType() == ModuleType.Software)
                {
                    try
                    {
                        Process process = module.GetModuleProcess();
                        if (process != null)
                        {
                            process.Refresh();
                            this.btnToggle.Text = (process.HasExited ? "Start Module" : "Stop Module");
                            this.btnToggle.Image = (process.HasExited ? Properties.Resources.control_play : Properties.Resources.control_stop);
                            this.btnToggle.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Information.HandleException(ex);
                    }
                }
            }

            // Loop through all of the modules in the list, and update its status
            foreach (ListViewItem lvi in this.lvModules.Items) 
            {
                Module module = (Module)lvi.Tag;
                lvi.SubItems[1].Text = module.GetModuleStatus();
            }
        }

        /** Module Control **/

        private void btnToggle_Click(object sender, EventArgs e)
        {
            // This button should only be clickable if there are items in lvModules
            // and one of them has been selected
            if (this.lvModules.Items.Count == 0 || this.lvModules.SelectedItems.Count == 0)
                return;

            Module module = (Module)this.lvModules.FocusedItem.Tag;

            if (module.GetModuleType() == ModuleType.Service)
            {
                try
                {
                    ServiceController serviceController = module.GetServiceController();
                    if (serviceController == null)
                        return;

                    Information.AddMessage("Toggling module " + module.GetModuleName(), InfoType.Debug);

                    // Toggle the service
                    if (serviceController.Status == ServiceControllerStatus.Stopped)
                    {
                        serviceController.Start();
                    }
                    else
                    {
                        serviceController.Stop();
                    }

                    // Update the module's status
                    serviceController.Refresh();
                    this.btnToggle.Text = (serviceController.Status == ServiceControllerStatus.Stopped
                                            ? "Start Module" : "Stop Module");
                    this.btnToggle.Image = (serviceController.Status == ServiceControllerStatus.Stopped
                                                     ? Properties.Resources.control_play : Properties.Resources.control_stop);
                    this.lvModules.FocusedItem.SubItems[1].Text = module.GetModuleStatus();
                }
                catch (Exception ex)
                {
                    Information.HandleException(ex);
                }
            }
            else if (module.GetModuleType() == ModuleType.Software)
            {
                try
                {
                    Process process = module.GetModuleProcess();
                    if (process != null)
                    {
                        if (process.HasExited)
                        {
                            process.Start();
                        }
                        else
                        {
                            process.Kill();
                        }

                        process.Refresh();
                        this.btnToggle.Text = (process.HasExited ? "Start Module" : "Stop Module");
                        this.btnToggle.Image = (process.HasExited ? Properties.Resources.control_play : Properties.Resources.control_stop);
                        this.btnToggle.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    Information.HandleException(ex);
                }
            }
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            // This button should only be clickable if there are items in lvModules
            // and one of them has been selected
            if (this.lvModules.Items.Count == 0 || this.lvModules.SelectedItems.Count == 0)
                return;

            Module module = (Module)this.lvModules.FocusedItem.Tag;
            this.ctmControl.Items.Clear();

            if (module.GetControls().Count > 0)
            {
                foreach (ModuleControl control in module.GetControls())
                {
                    // If the control is a seperator, create a new seperator and
                    // add it to the context menu
                    if (control.GetControlType() == ControlType.Separator)
                    {
                        this.ctmControl.Items.Add(new ToolStripSeparator());
                        continue;
                    }

                    ToolStripMenuItem menuItem = new ToolStripMenuItem(control.GetControlName());
                    menuItem.Tag = control;
                    menuItem.Click += new EventHandler(this.ctmControl_ItemClicked);

                    switch (control.GetControlType())
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

                    this.ctmControl.Items.Add(menuItem);
                }

                this.ctmControl.Show(btnControl, new Point(0, btnControl.Height));
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            // This button should only be clickable if there are items in lvModules
            // and one of them has been selected
            if (this.lvModules.Items.Count == 0 || this.lvModules.SelectedItems.Count == 0)
                return;

            Module module = (Module)this.lvModules.FocusedItem.Tag;
            this.ctmConfig.Items.Clear();

            if (module.GetConfigs().Count > 0)
            {
                foreach (ModuleConfig config in module.GetConfigs())
                {
                    // If the config is a seperator, create a new seperator and
                    // add it to the context menu
                    if (config.GetConfigType() == ConfigType.Separator)
                    {
                        this.ctmConfig.Items.Add(new ToolStripSeparator());
                        continue;
                    }

                    ToolStripMenuItem menuItem = new ToolStripMenuItem(config.GetConfigName());
                    menuItem.Tag = config;
                    menuItem.Click += new EventHandler(this.ctmConfig_itemClicked);

                    switch (config.GetConfigType())
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

                    this.ctmConfig.Items.Add(menuItem);
                }

                this.ctmConfig.Show(btnConfig, new Point(0, btnConfig.Height));
            }
        }

        private void ctmControl_ItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ModuleControl control = (ModuleControl)menuItem.Tag;
            Module module = (Module)this.lvModules.FocusedItem.Tag;

            Information.AddMessage("Handling control '" + control.GetControlName() + "' for module '" + module.GetModuleName() + "'", InfoType.Debug);

            try
            {
                Process.Start(control.GetControlPath(), control.GetControlArgs());
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        private void ctmConfig_itemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ModuleConfig config = (ModuleConfig)menuItem.Tag;
            Module module = (Module)this.lvModules.FocusedItem.Tag;

            Information.AddMessage("Handling config '" + config.GetConfigName() + "' for module '" + module.GetModuleName() + "'", InfoType.Debug);

            try
            {
                Process.Start(config.GetConfigPath(), config.GetConfigArgs());
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }
        }

        /** Console **/

        private void ctmConsole_Copy_Click(object sender, EventArgs e)
        {
            this.rtbConsole.Copy();
        }

        private void ctmConsole_Clear_Click(object sender, EventArgs e)
        {
            this.rtbConsole.Clear();
        }

        private void ctmConsole_SelectAll_Click(object sender, EventArgs e)
        {
            this.rtbConsole.SelectAll();
            this.rtbConsole.Focus();
        }

        private void ctmConsole_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog svdConsoleOutput = new SaveFileDialog();
            svdConsoleOutput.Filter = "Rich Text Format (.rtf)|*.rtf|Log Files (*.log)|*.log|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            svdConsoleOutput.Title = "Save Console Output";

            if (svdConsoleOutput.ShowDialog() != DialogResult.Cancel && svdConsoleOutput.FileName != "")
            {
                rtbConsole.SaveFile(svdConsoleOutput.FileName);
            }
        }

        /** PandaStack Actions **/

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.ResetModuleControl();

            // Stop sync timer, and clear the list view
            this.tmrSync.Enabled = false;
            this.lvModules.Items.Clear();

            // Reload the modules from file, and then add to the list view
            this.PandaStack.ReloadModules();
            this.FetchModules();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.FormAbout.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.FormSettings.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /** Minimize Form **/

        private void niMinimize_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.RestoreApplication();
        }

        private void ctmMinimize_Restore_Click(object sender, EventArgs e)
        {
            this.RestoreApplication();
        }

        private void ctmMinimize_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * <summary>
         * Fetch the loaded modules into the list view
         * </summary>
         */
        private void FetchModules()
        {
            List<Module> loadedModules = this.PandaStack.GetModules();

            this.tmrSync.Enabled = false;

            if (loadedModules.Count > 0)
            {
                ListViewItem lvi;
                Information.AddMessage("Loading " + loadedModules.Count + " modules");

                foreach (Module module in loadedModules)
                {
                    Information.AddMessage("Found module '" + module.GetModuleName() + "' with " + module.GetControls().Count + " controls, " + module.GetConfigs().Count + " configs");
                    lvi = new ListViewItem(module.GetModuleName());
                    lvi.SubItems.Add(module.GetModuleStatus());
                    lvi.SubItems.Add(module.GetModuleType().ToString());
                    lvi.Tag = module;

                    this.lvModules.Items.Add(lvi);
                    lvi = null;
                }

                // Enable the timer again only because there are modules loaded
                this.tmrSync.Enabled = true;
            }
            else
            {
                Information.AddMessage("There are no modules loaded");
            }
        }

        /**
         * <sumamry>
         * Reset the module control
         * </summary>
         * <remarks>
         * Unselects the focues module, and then clears the
         * module control group and it's components
         * </remarks>
         */
        private void ResetModuleControl()
        {
            if (this.lvModules.Items.Count > 0 && this.lvModules.SelectedItems.Count > 0)
                this.lvModules.FocusedItem.Focused = false;

            this.grpModuleControl.Text = "Module Control";
            this.btnToggle.Text = "Start Module";
            this.btnToggle.Image = Properties.Resources.control_play;

            this.btnToggle.Enabled = false;
            this.btnControl.Enabled = false;
            this.btnConfig.Enabled = false;
            this.ctmControl.Items.Clear();
            this.ctmConfig.Items.Clear();
        }

        /**
         * <sumamry>
         * Restores the PandaStack Application
         * </summary>
         */
        private void RestoreApplication()
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.niMinimize.Visible = false;
            this.tmrSync.Enabled = true;
        }

    }

}
