using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DavidRockin.PandaStack.PandaClass;

namespace DavidRockin.PandaStack.ModuleGenerator
{
    public partial class frmEditItem : Form
    {
        private ModuleConfig Config;
        private ModuleControl Control;

        public string Name;
        public string Type;
        public string Path;

        public frmEditItem(ModuleConfig config)
        {
            InitializeComponent();
            this.Config = config;
            this.Text = "Editing Module Config";

            foreach (ConfigType configType in Enum.GetValues(typeof(ConfigType)))
                this.cmbType.Items.Add(configType.ToString());
        }

        public frmEditItem(ModuleControl control)
        {
            InitializeComponent();
            this.Control = control;
            this.Text = "Editing Module Control";

            foreach (ControlType controlType in Enum.GetValues(typeof(ControlType)))
                this.cmbType.Items.Add(controlType.ToString());
        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {
            this.txtName.Text = this.Name;
            this.cmbType.Text = this.Type;
            this.txtPath.Text = this.Path;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.Name = this.txtName.Text;
            this.Type = this.cmbType.Text;
            this.Path = this.txtPath.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = this.cmbType.Text;
            this.btnFileOpen.Enabled = true;
            this.txtPath.Enabled = true;

            if (text == "Url" || text == "Command")
            {
                this.btnFileOpen.Enabled = false;
                this.lblPath.Text = (text == "Url" ? "URL Address" : "Command");
            }
            else if (text == "Separator")
            {
                this.btnFileOpen.Enabled = false;
                this.txtPath.Enabled = false;
                this.lblPath.Text = "Path";
            }
            else if (text == "Software")
            {
                this.lblPath.Text = "Application File";
            }
            else if (text == "Directory")
            {
                this.lblPath.Text = "Directory Path";
            }
            else if (Text == "File")
            {
                this.lblPath.Text = "Configuration File";
            }
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            if (this.cmbType.Text == "Software")
            {
                OpenFileDialog mnuFilePath = new OpenFileDialog();
                mnuFilePath.Title = "Select Application";
                mnuFilePath.Filter = "Applications (*.exe)|*.exe|Batch Files (*.bat;*.com)|*.bat;*.com|All Files (*.*)|*.*";

                if (mnuFilePath.ShowDialog() != DialogResult.Cancel)
                    this.txtPath.Text = mnuFilePath.FileName;
            }
            else if (this.Config != null && this.cmbType.Text == "File")
            {
                OpenFileDialog mnuFilePath = new OpenFileDialog();
                mnuFilePath.Title = "Select Configuration File";
                mnuFilePath.Filter = "All Files (*.*)|*.*";

                if (mnuFilePath.ShowDialog() != DialogResult.Cancel)
                    this.txtPath.Text = mnuFilePath.FileName;
            }
            else if (this.Config != null && this.cmbType.Text == "Directory")
            {
                FolderBrowserDialog mnuDirectory = new FolderBrowserDialog();

                if (mnuDirectory.ShowDialog() != DialogResult.Cancel)
                    this.txtPath.Text = mnuDirectory.SelectedPath;
            }
        }
    }
}
