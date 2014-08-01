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

    public partial class frmEditItem : Form
    {

        private ListViewItem _lvi;
        private bool _isAdmin; // For now

        private ModuleConfig _config;
        private ModuleAdmin _admin;

        public frmEditItem(ModuleAdmin admin, ListViewItem lvi)
        {
            this._isAdmin = true;
            this._admin = admin;
            this._lvi = lvi;

            this.txtName.Text = admin.getName();
            this.cmbType.Text = admin.getType().ToString();
            this.txtPath.Text = admin.getPath();

            InitializeComponent();
        }

        public frmEditItem(ModuleConfig config, ListViewItem lvi)
        {
            this._isAdmin = false;
            this._config = config;
            this._lvi = lvi;

            this.txtName.Text = config.getName();
            this.cmbType.Text = config.getType().ToString();
            this.txtPath.Text = config.getPath();

            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (this._isAdmin == true)
            {
                this._admin.setName(this.txtName.Text);
                this._admin.setType((ModuleAdminType)Enum.Parse(typeof(ModuleAdminType), this.cmbType.Text));
                this._admin.setPath(this.txtPath.Text);
            }
            else
            {
                this._config.setName(this.txtName.Text);
                this._config.setType((ModuleConfigType)Enum.Parse(typeof(ModuleConfigType), this.cmbType.Text));
                this._config.setPath(this.txtPath.Text);
            }
        }

    }

}
