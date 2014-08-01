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

        private frmEditItem formEditItem;
        private List<Module> modules = new List<Module>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Setup the administrations columns
            lvAdmins.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvAdmins.Columns.Add("Type", 75, HorizontalAlignment.Left);
            lvAdmins.Columns.Add("Path", 250, HorizontalAlignment.Left);

            // Setup the configurations columns
            lvConfigs.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvConfigs.Columns.Add("Type", 75, HorizontalAlignment.Left);
            lvConfigs.Columns.Add("Path", 250, HorizontalAlignment.Left);

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
                this.handleException(ex);
            }

            this.clearCurrentModule();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Module module = new Module();
            ListViewItem lvi = new ListViewItem();
            lvi.Text = module.getName();
            lvi.Tag = module;

            this.modules.Add(module);
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
                    this.modules.Remove(module);

                    this.clearCurrentModule();
                }
            }
            catch (Exception ex)
            {
                this.handleException(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.lvModules.Items.Count > 0 && this.lvModules.SelectedItems.Count > 0)
            {
                ListViewItem lvi = this.lvModules.FocusedItem;
                Module module = (Module)lvi.Tag;

                module.setName(txtName.Text);
                module.setType((ModuleType)Enum.Parse(typeof(ModuleType), cmbType.Text));

                if (cmbType.Text == "Service")
                {
                    module.setService(txtServiceName.Text);
                }

                lvi.Text = txtName.Text;
                module.getAdmins().Clear();
                module.getConfigs().Clear();

                if (this.lvAdmins.Items.Count > 0)
                {
                    foreach (ListViewItem alvi in this.lvAdmins.Items)
                    {
                        ModuleAdmin admin = (ModuleAdmin)alvi.Tag;
                        admin.setName(alvi.Text);
                        admin.setType((ModuleAdminType)Enum.Parse(typeof(ModuleAdminType), alvi.SubItems[1].Text));
                        admin.setPath(alvi.SubItems[2].Text);
                        module.addAdmin(admin);
                    }
                }

                if (this.lvConfigs.Items.Count > 0)
                {
                    foreach (ListViewItem clvi in this.lvConfigs.Items)
                    {
                        ModuleConfig config = (ModuleConfig)clvi.Tag;
                        config.setName(clvi.Text);
                        config.setType((ModuleConfigType)Enum.Parse(typeof(ModuleConfigType), clvi.SubItems[1].Text));
                        config.setPath(clvi.SubItems[2].Text);
                        module.addConfig(config);
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

                txtName.Text = module.getName();
                cmbType.Text = module.getType().ToString();
                lvi.Text = module.getName();

                this.lvAdmins.Items.Clear();
                this.lvConfigs.Items.Clear();

                foreach (ModuleAdmin admin in module.getAdmins())
                {
                    ListViewItem alvi = new ListViewItem();
                    alvi.Text = admin.getName();
                    alvi.SubItems.Add(admin.getType().ToString());
                    alvi.SubItems.Add(admin.getPath());
                    alvi.Tag = admin;
                    this.lvAdmins.Items.Add(alvi);
                }

                foreach (ModuleConfig config in module.getConfigs())
                {
                    ListViewItem clvi = new ListViewItem();
                    clvi.Text = config.getName();
                    clvi.SubItems.Add(config.getType().ToString());
                    clvi.SubItems.Add(config.getPath());
                    clvi.Tag = config;
                    this.lvConfigs.Items.Add(clvi);
                }
            }
        }

        private void lvAdmins_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lvAdmins.Items.Count > 0 && this.lvAdmins.SelectedItems.Count > 0)
                {
                    this.btnAdmin_Remove.Enabled = true;
                    this.btnAdmin_Edit.Enabled = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                this.handleException(ex);
            }

            this.clearCurrentAdmin();
        }

        private void btnAdmin_Add_Click(object sender, EventArgs e)
        {
            if (this.lvModules.Items.Count > 0 && this.lvModules.SelectedItems.Count > 0)
            {
                ModuleAdmin admin = new ModuleAdmin();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = admin.getName();
                lvi.SubItems.Add(admin.getType().ToString());
                lvi.SubItems.Add(admin.getPath());
                lvi.Tag = admin;
                this.lvAdmins.Items.Add(lvi);
            }
        }

        private void btnAdmin_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvAdmins.Items.Count > 0 && this.lvAdmins.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = this.lvAdmins.FocusedItem;
                    this.lvAdmins.Items.Remove(lvi);
                }
            }
            catch (Exception ex)
            {
                this.handleException(ex);
            }
        }

        private void btnAdmin_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvAdmins.Items.Count > 0 && this.lvAdmins.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = this.lvAdmins.FocusedItem;
                    ModuleAdmin admin = (ModuleAdmin)lvi.Tag;

                    this.formEditItem = new frmEditItem(admin);
                    this.formEditItem.name = lvi.Text;
                    this.formEditItem.type = lvi.SubItems[1].Text;
                    this.formEditItem.path = lvi.SubItems[2].Text;

                    if (this.formEditItem.ShowDialog() == DialogResult.OK)
                    {
                        lvi.Text = formEditItem.name;
                        lvi.SubItems[1].Text = formEditItem.type;
                        lvi.SubItems[2].Text = formEditItem.path;
                    }
                }
            }
            catch (Exception ex)
            {
                this.handleException(ex);
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
                this.handleException(ex);
            }

            this.clearCurrentConfig();
        }

        private void btnConfig_Add_Click(object sender, EventArgs e)
        {
            if (this.lvModules.Items.Count > 0 && this.lvModules.SelectedItems.Count > 0)
            {
                ModuleConfig config = new ModuleConfig();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = config.getName();
                lvi.SubItems.Add(config.getType().ToString());
                lvi.SubItems.Add(config.getPath());
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
                this.handleException(ex);
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

                    this.formEditItem = new frmEditItem(config);
                    this.formEditItem.name = lvi.Text;
                    this.formEditItem.type = lvi.SubItems[1].Text;
                    this.formEditItem.path = lvi.SubItems[2].Text;

                    if (this.formEditItem.ShowDialog() == DialogResult.OK)
                    {
                        lvi.Text = formEditItem.name;
                        lvi.SubItems[1].Text = formEditItem.type;
                        lvi.SubItems[2].Text = formEditItem.path;
                    }
                }
            }
            catch (Exception ex)
            {
                this.handleException(ex);
            }
        }

        /**
         * <summary>
         * Set the selected module
         * </summary>
         */
        private void updateCurrentModule(Module module)
        {
            this.txtName.Text = module.getName();
            this.cmbType.Text = module.getType().ToString();
            this.lvAdmins.Items.Clear();
            this.lvConfigs.Items.Clear();

            if (module.getType() == ModuleType.Service)
            {
                this.txtServiceName.Text = module.getService();
            }

            if (module.getAdmins().Count > 0)
            {
                foreach (ModuleAdmin admin in module.getAdmins())
                {
                    ListViewItem alvi = new ListViewItem();
                    alvi.Text = admin.getName();
                    alvi.SubItems.Add(admin.getType().ToString());
                    alvi.SubItems.Add(admin.getPath());
                    alvi.Tag = admin;
                    this.lvAdmins.Items.Add(alvi);
                }
            }

            if (module.getConfigs().Count > 0)
            {
                foreach (ModuleConfig config in module.getConfigs())
                {
                    ListViewItem clvi = new ListViewItem();
                    clvi.Text = config.getName();
                    clvi.SubItems.Add(config.getType().ToString());
                    clvi.SubItems.Add(config.getPath());
                    clvi.Tag = config;
                    this.lvConfigs.Items.Add(clvi);
                }
            }
        }

        /**
         * <summary>
         * Clear the current module fields
         * </summary>
         */
        private void clearCurrentModule()
        {
            if (this.lvModules.SelectedItems.Count > 0)
                this.lvModules.FocusedItem.Focused = false;

            this.btnRemove.Enabled = false;
            this.grpModuleOptions.Enabled = false;
            this.txtName.Text = "";
            this.cmbType.Text = "";
            this.txtServiceName.Text = "";
            this.lvAdmins.Items.Clear();
            this.lvConfigs.Items.Clear();
        }

        /**
         * <summary>
         * Disable administration management
         * </summary>
         */
        private void clearCurrentAdmin()
        {
            this.btnAdmin_Edit.Enabled = false;
            this.btnAdmin_Remove.Enabled = false;
        }

        /**
         * <summary>
         * Disable configuration management
         * </summary>
         */
        private void clearCurrentConfig()
        {
            this.btnConfig_Edit.Enabled = false;
            this.btnConfig_Remove.Enabled = false;
        }

        private void handleException(Exception ex)
        {
            StackTrace stackTrace = new StackTrace(ex, true);
            StackFrame stackFrame = stackTrace.GetFrame(0);
            string message = ex.Message + " " + ex.InnerException + "\r\n" + stackFrame.GetFileName() + ":" +
                                stackFrame.GetFileLineNumber() + " -> " + stackFrame.GetMethod();
            MessageBox.Show(message, ex.GetType().ToString());
        }

    }
}