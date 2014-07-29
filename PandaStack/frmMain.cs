using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;

namespace PandaStack
{

    public partial class frmMain : Form
    {

        private PandaStack pandaStack;

        public frmMain()
        {
            // Setup PandaStack
            this.pandaStack = Program.pandaStack;
            this.pandaStack.loadModules();
            Information.form = this;

            InitializeComponent();
            Information.addMessage("Setting up PandaStack");

            this.lvModules.View = View.Details;
            this.lvModules.FullRowSelect = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Setup lvModules's columns
            this.lvModules.Columns.Add("Module Name", 130, HorizontalAlignment.Left);
            this.lvModules.Columns.Add("Module Status", 120, HorizontalAlignment.Left);
            this.lvModules.Columns.Add("Module Type", 100, HorizontalAlignment.Left);

            List<Module> loadedModules = this.pandaStack.getModules();
            if (loadedModules.Count > 0)
            {
                ListViewItem lvi;
                Information.addMessage("Loading " + loadedModules.Count + " modules");

                foreach (Module module in loadedModules)
                {
                    string status = "n/a";
                    if (module.getModuleType() == ModuleType.Service)
                    {
                        ServiceController sc = module.getServiceController();
                        status = sc.Status.ToString();
                    }

                    Information.addMessage("Found module '" + module.getModuleName() + "'");
                    lvi = new ListViewItem(module.getModuleName());
                    lvi.SubItems.Add(status);
                    lvi.SubItems.Add(module.getModuleType().ToString());
                    lvi.Tag = module;
                    this.lvModules.Items.Add(lvi);
                    lvi = null;
                }
            } else {
                Information.addMessage("There are no modules to load");
            }

            tmrSync.Enabled = true;
        }

        private void lvModules_SelectIndexChange(object sender, EventArgs e)
        {
            try
            {
                // We only want to manage a selected module
                if (this.lvModules.SelectedItems.Count > 0)
                {
                    Module module = (Module)lvModules.FocusedItem.Tag;
                    Information.addMessage("Selected module " + module.getModuleName(), InfoType.Debug);
                    grpModuleControl.Text = "Module Control: " + module.getModuleName();

                    if (module.getModuleType() == ModuleType.Service)
                    {
                        ServiceController sc = module.getServiceController();
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

                        if (module.getConfigs().Count > 0)
                        {
                            btnConfig.Enabled = true;
                        }

                        if (module.getAdmins().Count > 0)
                        {
                            btnAdmin.Enabled = true;
                        }

                        return;
                    }

                    grpModuleControl.Text = "Module Control";
                    btnToggle.Enabled = false;
                    btnConfig.Enabled = false;
                    btnAdmin.Enabled = false;
                    btnToggle.Text = "Start Module";
                }
                else
                {
                    grpModuleControl.Text = "Module Control";
                    btnToggle.Enabled = false;
                    btnConfig.Enabled = false;
                    btnAdmin.Enabled = false;
                    btnToggle.Text = "Start Module";
                }
            }
            catch (Exception ex)
            {
                // Gotta CATCH em all! ;)
            }
        }

        private void tmrSync_Tick(object sender, EventArgs e)
        {
            if (this.lvModules.Items.Count == 0) return;

            foreach (ListViewItem lvi in this.lvModules.Items)
            {
                Module module = (Module)lvi.Tag;
                if (module.getModuleType() == ModuleType.Service)
                {
                    ServiceController sc = module.getServiceController();
                    module.getServiceController().Refresh();
                    lvi.SubItems[1].Text = module.getServiceController().Status.ToString();
                }
            }
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (this.lvModules.Items.Count == 0) return;

            Module module = (Module)lvModules.FocusedItem.Tag;
            if (module.getModuleType() == ModuleType.Service)
            {
                ServiceController sc = module.getServiceController();
                Information.addMessage("Toggling module " + module.getModuleName(), InfoType.Debug);

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

                if (sc.Status == ServiceControllerStatus.Stopped)
                {
                    btnToggle.Text = "Start Module";
                    lvModules.FocusedItem.SubItems[1].Text = sc.Status.ToString();
                }
                else
                {
                    btnToggle.Text = "Stop Module";
                    lvModules.FocusedItem.SubItems[1].Text = sc.Status.ToString();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tmrSync.Enabled = false;
            this.lvModules.Items.Clear();

            List<Module> modules = this.pandaStack.getModules();
            if (modules.Count > 0)
            {
                ListViewItem lvi;
                Information.addMessage("Reloading " + modules.Count + " modules");

                foreach (Module module in modules)
                {
                    string status = "n/a";
                    if (module.getModuleType() == ModuleType.Service)
                    {
                        ServiceController sc = module.getServiceController();
                        status = sc.Status.ToString();
                    }

                    Information.addMessage("Found module '" + module.getModuleName() + "'");
                    lvi = new ListViewItem(module.getModuleName());
                    lvi.SubItems.Add(status);
                    lvi.SubItems.Add(module.getModuleType().ToString());
                    lvi.Tag = module;
                    this.lvModules.Items.Add(lvi);
                    lvi = null;
                }

                tmrSync.Enabled = true;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Closing(object sender, FormClosingEventArgs e)
        {
            Information.addMessage("Exiting PandaStack");
            // TODO: Handle closing programs (TBA)
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (this.lvModules.SelectedItems.Count > 0)
            {
                Module module = (Module)lvModules.FocusedItem.Tag;
                this.ctmConfig.Items.Clear();
                foreach (ModuleConfig mc in module.getConfigs())
                {
                    ToolStripMenuItem mi = new ToolStripMenuItem(mc.getConfigName());

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
                    }

                    this.ctmConfig.Items.Add(mi);
                }
                this.ctmConfig.Show(btnConfig, new Point(0, btnConfig.Height));
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (this.lvModules.SelectedItems.Count > 0)
            {
                Module module = (Module)lvModules.FocusedItem.Tag;
                this.ctmAdmin.Items.Clear();
                foreach (ModuleAdmin ma in module.getAdmins())
                {
                    ToolStripMenuItem mi = new ToolStripMenuItem(ma.getConfigName());

                    switch (ma.getModuleConfigType())
                    {
                        case ModuleAdminType.Command:
                            mi.Image = Properties.Resources.application_xp_terminal;
                            break;
                        case ModuleAdminType.Software:
                            mi.Image = Properties.Resources.application;
                            break;
                    }

                    this.ctmAdmin.Items.Add(mi);
                }
                this.ctmAdmin.Show(btnAdmin, new Point(0, btnAdmin.Height));
            }
        }

    }

}
