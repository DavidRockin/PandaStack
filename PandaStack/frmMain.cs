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

namespace PandaStack
{

    public partial class frmMain : Form
    {

        private PandaStack pandaStack;
        private frmAbout formAbout = new frmAbout();

        public frmMain()
        {
            // Setup PandaStack
            this.pandaStack = Program.pandaStack;
            this.pandaStack.loadModules();

            InitializeComponent();

            Information.form = this;
            Information.addMessage("Setting up PandaStack");

            // Check to see if PandaStack is running as administrator
            if (Program.isAdministrator())
            {
                this.Text += " [Administrator]";
                Information.addMessage("PandaStack is running as administrator");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Setup lvModule's Columns
            this.lvModules.Columns.Add("Module Name", 140, HorizontalAlignment.Left);
            this.lvModules.Columns.Add("Module Status", 130, HorizontalAlignment.Left);
            this.lvModules.Columns.Add("Module Type", 130, HorizontalAlignment.Left);

            // Put the loaded modules into the list view
            this.fetchModules();
        }

        private void frmMain_Closing(object sender, FormClosingEventArgs e)
        {
            Information.addMessage("Exiting PandaStack");
            // TODO: Handle closing programs (TBA)
        }

        private void lvModules_SelectIndexChange(object sender, EventArgs e)
        {
            try
            {
                // We only want to manage a selected module
                if (this.lvModules.SelectedItems.Count > 0)
                {
                    Module module = (Module)this.lvModules.FocusedItem.Tag;
                    Information.addMessage("Selected the module " + module.getModuleName(), InfoType.Debug);
                    grpModuleControl.Text = "Module Control: " + module.getModuleName();

                    // If the module is a service, check it's status
                    if (module.getModuleType() == ModuleType.Service)
                    {
                        try
                        {
                            ServiceController sc = module.getServiceController();

                            if (sc != null)
                            {
                                if (sc.Status == ServiceControllerStatus.Stopped)
                                {
                                    btnToggle.Text = "Start Module";
                                    btnToggle.Enabled = true;
                                }
                                else
                                {
                                    btnToggle.Text = "Stop Module";
                                    btnToggle.Enabled = true;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Information.handleException(ex);
                        }
                    }
                    else if (module.getModuleType() == ModuleType.Software)
                    {
                        // TODO: Allow the option to toggle module type software
                    }

                    // If there are admin options, enable the admin button
                    if (module.getAdmins().Count > 0)
                    {
                        btnAdmin.Enabled = true;
                    }

                    // If there are any configurations, enable the config button
                    if (module.getConfigs().Count > 0)
                    {
                        btnConfig.Enabled = true;
                    }
                }
                else
                {
                    // Reset the module control groupbox and it's component
                    grpModuleControl.Text = "Module Control";
                    btnToggle.Enabled = false;
                    btnAdmin.Enabled = false;
                    btnConfig.Enabled = false;
                    btnToggle.Text = "Start Module";
                }
            }
            catch
            {
                // meh
            }
        }

        private void tmrSync_Tick(object sender, EventArgs e)
        {
            if (this.lvModules.Items.Count == 0)
                return;

            // Is there a selected module?
            if (this.lvModules.SelectedItems.Count > 0)
            {
                Module module = (Module)this.lvModules.FocusedItem.Tag;

                // If the module is a service, update its button status
                if (module.getModuleType() == ModuleType.Service)
                {
                    try
                    {
                        ServiceController sc = module.getServiceController();

                        if (sc != null)
                        {
                            sc.Refresh();

                            if (sc.Status == ServiceControllerStatus.Stopped)
                            {
                                btnToggle.Text = "Start Module";
                                btnToggle.Enabled = true;
                            }
                            else
                            {
                                btnToggle.Text = "Stop Module";
                                btnToggle.Enabled = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Information.handleException(ex);
                    }
                }
                else if (module.getModuleType() == ModuleType.Software)
                {
                    // TODO: Update buttons for a selected software type module
                }
            }

            foreach (ListViewItem lvi in this.lvModules.Items) 
            {
                Module module = (Module)lvi.Tag;
                lvi.SubItems[1].Text = module.getStatus();
            }
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            // This button should only be clickable if there are items in lvModules
            // and one of them has been selected
            if (this.lvModules.Items.Count == 0 && this.lvModules.SelectedItems.Count == 0)
                return;

            Module module = (Module)this.lvModules.FocusedItem.Tag;

            if (module.getModuleType() == ModuleType.Service)
            {
                try
                {
                    ServiceController sc = module.getServiceController();
                    if (sc == null) return;

                    Information.addMessage("Toggling module " + module.getModuleName(), InfoType.Debug);

                    // Toggle the service
                    if (sc.Status == ServiceControllerStatus.Stopped)
                    {
                        sc.Start();
                        sc.Refresh();
                    }
                    else
                    {
                        sc.Stop();
                        sc.Refresh();
                    }

                    // Check the service status
                    if (sc.Status == ServiceControllerStatus.Stopped)
                    {
                        btnToggle.Text = "Start Module";
                        lvModules.FocusedItem.SubItems[1].Text = module.getStatus();
                    }
                    else
                    {
                        btnToggle.Text = "Stop Module";
                        lvModules.FocusedItem.SubItems[1].Text = module.getStatus();
                    }
                }
                catch (Exception ex)
                {
                    Information.handleException(ex);
                }
            }
            else if (module.getModuleType() == ModuleType.Software)
            {
                // TODO: Allow toggle of software type modules
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Stop sync timer, and clear the list view
            if (this.lvModules.FocusedItem != null)
                this.lvModules.FocusedItem.Selected = false; // Bug fix: refreshing while having an item selected throws an exception
            this.tmrSync.Enabled = false;
            this.lvModules.Items.Clear();

            // Reload the modules from file, and then add to the list view
            this.pandaStack.reloadModules();
            this.fetchModules();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.formAbout.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            // This button should only be clickable if there are items in lvModules
            // and one of them was selected
            if (this.lvModules.Items.Count == 0 && this.lvModules.SelectedItems.Count == 0)
                return;

            Module module = (Module)this.lvModules.FocusedItem.Tag;
            this.ctmConfig.Items.Clear();

            if (module.getConfigs().Count > 0)
            {
                foreach (ModuleConfig mc in module.getConfigs())
                {
                    ToolStripMenuItem mi = new ToolStripMenuItem(mc.getConfigName());
                    mi.Tag = mc;
                    mi.Click += new EventHandler(this.ctmConfig_itemClicked);

                    switch (mc.getModuleConfigType())
                    {
                        case ModuleConfigType.File:
                            mi.Image = Properties.Resources.page_white_edit;
                            break;

                        case ModuleConfigType.Directory:
                            mi.Image = Properties.Resources.folder;
                            break;

                        case ModuleConfigType.Software:
                            mi.Image = Properties.Resources.application;
                            break;

                        case ModuleConfigType.URL:
                            mi.Image = Properties.Resources.world;
                            break;
                    }

                    this.ctmConfig.Items.Add(mi);
                }

                this.ctmConfig.Show(btnConfig, new Point(0, btnConfig.Height));
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // This button should only be clickable if there are items in lvModules
            // and one of them was selected
            if (this.lvModules.Items.Count == 0 && this.lvModules.SelectedItems.Count == 0)
                return;

            Module module = (Module)this.lvModules.FocusedItem.Tag;
            this.ctmAdmin.Items.Clear();

            if (module.getAdmins().Count > 0)
            {
                foreach (ModuleAdmin ma in module.getAdmins())
                {
                    ToolStripMenuItem mi = new ToolStripMenuItem(ma.getAdminName());
                    mi.Tag = ma;
                    mi.Click += new EventHandler(this.ctmAdmin_itemClicked);

                    switch (ma.getModuleAdminType())
                    {
                        case ModuleAdminType.Command:
                            mi.Image = Properties.Resources.application_xp_terminal;
                            break;

                        case ModuleAdminType.Software:
                            mi.Image = Properties.Resources.application;
                            break;

                        case ModuleAdminType.URL:
                            mi.Image = Properties.Resources.world;
                            break;
                    }

                    this.ctmAdmin.Items.Add(mi);
                }

                this.ctmAdmin.Show(btnAdmin, new Point(0, btnAdmin.Height));
            }
        }

        /**
         * <summary>
         * Fetch the loaded modules into the list view
         * </summary>
         */
        private void fetchModules()
        {
            List<Module> loadedModules = this.pandaStack.getModules();

            this.tmrSync.Enabled = false;

            if (loadedModules.Count > 0)
            {
                ListViewItem lvi;
                Information.addMessage("Loading " + loadedModules.Count + " modules");

                foreach (Module module in loadedModules)
                {
                    Information.addMessage("Found module '" + module.getModuleName() + "' with " + module.getAdmins().Count + " admin options, " + module.getConfigs().Count + " config options");
                    lvi = new ListViewItem(module.getModuleName());
                    lvi.SubItems.Add(module.getStatus());
                    lvi.SubItems.Add(module.getModuleType().ToString());
                    lvi.Tag = module;

                    this.lvModules.Items.Add(lvi);
                    lvi = null;
                }

                // Enable the timer again only because there are modules loaded
                this.tmrSync.Enabled = true;
            }
            else
            {
                Information.addMessage("No modules loaded");
            }
        }

        private void ctmConfig_itemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;
            ModuleConfig mc = (ModuleConfig)mi.Tag;
            Module module = (Module)this.lvModules.FocusedItem.Tag;

            Information.addMessage("Handling configuration '" + mc.getConfigName() + "' for module '" + module.getModuleName() + "'", InfoType.Debug);
            System.Diagnostics.Process.Start(@mc.getConfigFile(), mc.getArgs());
        }
        
        private void ctmAdmin_itemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;
            ModuleAdmin ma = (ModuleAdmin)mi.Tag;
            Module module = (Module)this.lvModules.FocusedItem.Tag;

            Information.addMessage("Handling administration '" + ma.getAdminName() + "' for module '" + module.getModuleName() + "'", InfoType.Debug);
            System.Diagnostics.Process.Start(@ma.getAdminPath(), ma.getArgs());
        }

        private void ctmConsole_Copy_Click(object sender, EventArgs e)
        {
            this.rtbConsole.Copy();
        }

        private void ctmConsole_Clear_Click(object sender, EventArgs e)
        {
            this.rtbConsole.Text = "";
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
            svdConsoleOutput.ShowDialog();

            if (svdConsoleOutput.FileName != "")
            {
                rtbConsole.SaveFile(svdConsoleOutput.FileName);
            }
        }
	
        private int _sortColumn = -1;

        private void lvModules_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != this._sortColumn)
            {
                this._sortColumn = e.Column;
                lvModules.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (lvModules.Sorting == SortOrder.Ascending)
                {
                    lvModules.Sorting = SortOrder.Descending;
                }
                else
                {
                    lvModules.Sorting = SortOrder.Ascending;
                }
            }

            lvModules.Sort();
            this.lvModules.ListViewItemSorter = new ListViewItemComparer(e.Column, lvModules.Sorting);
        }

    }

}
