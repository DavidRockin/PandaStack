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

    partial class frmEditItem : Form
    {

        private ModuleConfig _config;
        private ModuleAdmin _admin;

        public string name;
        public string type;
        public string path;

        public frmEditItem(ModuleAdmin admin)
        {
            InitializeComponent();

            this._admin = admin;
            var values = Enum.GetValues(typeof(ModuleAdminType));
            foreach (ModuleAdminType type in values)
            {
                this.cmbType.Items.Add(type.ToString());
            }
        }

        public frmEditItem(ModuleConfig config)
        {
            InitializeComponent();

            this._config = config;
            var values = Enum.GetValues(typeof(ModuleConfigType));
            foreach (ModuleConfigType type in values)
            {
                this.cmbType.Items.Add(type.ToString());
            }
        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {
            this.txtName.Text = this.name;
            this.cmbType.Text = this.type;
            this.txtPath.Text = this.path;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.name = this.txtName.Text;
            this.type = this.cmbType.Text;
            this.path = this.txtPath.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOpenLoc_Click(object sender, EventArgs e)
        {
            if (this.cmbType.Text == "Software")
            {
                OpenFileDialog ofdPath = new OpenFileDialog();
                ofdPath.Title = "Select Application";
                ofdPath.Filter = "Applications (*.exe)|*.exe|Batch Files (*.bat;*.com)|*.bat;*.com|All Files (*.*)|*.*";

                if (ofdPath.ShowDialog() != DialogResult.Cancel)
                {
                    this.txtPath.Text = ofdPath.FileName;
                }
            }
            else if (this._config != null && this.cmbType.Text == "File") {
                OpenFileDialog ofdPath = new OpenFileDialog();
                ofdPath.Title = "Select Configuration File";
                ofdPath.Filter = "All Files (*.*)|*.*";

                if (ofdPath.ShowDialog() != DialogResult.Cancel)
                {
                    this.txtPath.Text = ofdPath.FileName;
                }
            }
            else if (this._config != null && this.cmbType.Text == "Directory")
            {
                FolderBrowserDialog fbdPath = new FolderBrowserDialog();

                if (fbdPath.ShowDialog() != DialogResult.Cancel)
                {
                    this.txtPath.Text = fbdPath.SelectedPath;
                }
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = this.cmbType.Text;

            if (text == "Url" || text == "Command")
            {
                this.btnOpenLoc.Enabled = false;
                this.lblPath.Text = (text == "URL" ? "URL Address" : "Command");
                return;
            }
            else if (text == "Software")
            {
                this.lblPath.Text = "Application File";
            }
            else if (text == "Directory")
            {
                this.lblPath.Text = "Directory Path";
            }
            else if (text == "File")
            {
                this.lblPath.Text = "Configuration File";
            }

            this.btnOpenLoc.Enabled = true;
        }

    }

}
