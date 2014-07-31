using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PandaStack_Module_Generator
{
    public partial class frmMain : Form
    {

        private List<Module> modules = new List<Module>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lvAdmins.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvAdmins.Columns.Add("Type", 75, HorizontalAlignment.Left);
            lvAdmins.Columns.Add("Path", 250, HorizontalAlignment.Left);

            lvConfigs.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvConfigs.Columns.Add("Type", 75, HorizontalAlignment.Left);
            lvConfigs.Columns.Add("Path", 250, HorizontalAlignment.Left);

            var values = Enum.GetValues(typeof(ModuleType));
            foreach (ModuleType type in values)
            {
                this.cmbType.Items.Add(type.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Module module = new Module();
            this.modules.Add(module);

            ListViewItem lvi = new ListViewItem();
            lvi.Text = module.getName();
            lvi.Tag = module;

            this.lvModules.Items.Add(lvi);
        }

        private void lvModules_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (this.lvModules.Items.Count > 0 && this.lvModules.SelectedItems.Count > 0)
                {
                    Module module = (Module)this.lvModules.FocusedItem.Tag;
                    this.updateCurrentModule(module);
                    this.groupBox2.Enabled = true;
                    this.btnRemove.Enabled = true;

                    if (module.getConfigs().Count > 0)
                    {
                        this.lvConfigs.Items.Clear();

                        foreach (ModuleConfig config in module.getConfigs())
                        {
                            ListViewItem clvi = new ListViewItem();
                            clvi.Text = config.getName();
                            clvi.SubItems.Add(config.getType().ToString());
                            clvi.SubItems.Add(config.getPath());
                            this.lvConfigs.Items.Add(clvi);
                        }
                    }

                    return;
                }
            } catch {

            }

            this.clearCurrentModule();
        }

        private void updateCurrentModule(Module module)
        {
            this.txtName.Text = module.getName();
            this.cmbType.Text = module.getType().ToString();

            if (module.getType() == ModuleType.Service)
            {
                this.txtServiceName.Text = module.getService();
            }
        }

        private void clearCurrentModule()
        {
            if (this.lvModules.SelectedItems.Count > 0)
                this.lvModules.FocusedItem.Focused = false;

            this.btnRemove.Enabled = false;
            this.groupBox2.Enabled = false;
            this.txtName.Text = "";
            this.cmbType.Text = "";
            this.txtServiceName.Text = "";
            this.lvConfigs.Items.Clear();
        }

        private void clearCurrentConfig()
        {
            this.btnConfig_Edit.Enabled = false;
            this.btnConfig_Remove.Enabled = false;
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
            catch
            {
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
                module.getConfigs().Clear();

                if (lvConfigs.Items.Count > 0) {
                    foreach (ListViewItem clvi in this.lvConfigs.Items)
                    {
                        ModuleConfig config = (ModuleConfig)clvi.Tag;
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

                this.lvConfigs.Items.Clear();

                foreach (ModuleConfig config in module.getConfigs())
                {
                    ListViewItem clvi = new ListViewItem();
                    clvi.Text = config.getName();
                    clvi.SubItems.Add(config.getType().ToString());
                    clvi.SubItems.Add(config.getPath());
                    this.lvConfigs.Items.Add(clvi);
                }
            }
        }

        private void btnConfig_Add_Click(object sender, EventArgs e)
        {
            if (this.lvModules.Items.Count > 0 && this.lvModules.SelectedItems.Count > 0)
            {
                ListViewItem lvi = this.lvModules.FocusedItem;
                Module module = (Module)lvi.Tag;

                ModuleConfig config = new ModuleConfig();
                ListViewItem clvi = new ListViewItem();
                clvi.Text = config.getName();
                clvi.SubItems.Add(config.getType().ToString());
                clvi.SubItems.Add(config.getPath());
                clvi.Tag = config;
                this.lvConfigs.Items.Add(clvi);
            }
        }

        private void lvConfigs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lvConfigs.Items.Count > 0 && this.lvConfigs.SelectedItems.Count > 0)
                {
                    ModuleConfig config = (ModuleConfig)this.lvConfigs.FocusedItem.Tag;
                    this.btnConfig_Edit.Enabled = true;
                    this.btnConfig_Remove.Enabled = true;
                    return;
                }
            }
            catch
            {

            }

            this.clearCurrentConfig();
        }

        private void btnConfig_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvConfigs.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = this.lvConfigs.FocusedItem;
                    ModuleConfig config = (ModuleConfig)lvi.Tag;
                    this.lvConfigs.Items.Remove(lvi);
                }
            }
            catch
            {
            }
        }

    }
}
