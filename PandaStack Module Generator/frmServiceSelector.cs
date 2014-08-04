using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;

namespace PandaStack_Module_Generator
{

    public partial class frmServiceSelector : Form
    {

        public string ServiceName;

        public frmServiceSelector()
        {
            InitializeComponent();
            this.lvServices.Columns.Add("Service Name", 200);
            this.lvServices.Columns.Add("Service", 150);
        }

        private void frmServiceSelector_Load(object sender, EventArgs e)
        {
            foreach (ServiceController service in ServiceController.GetServices()) {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = service.DisplayName;
                lvi.SubItems.Add(service.ServiceName);
                this.lvServices.Items.Add(lvi);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (this.lvServices.Items.Count > 0 && this.lvServices.SelectedItems.Count > 0)
            {
                this.ServiceName = this.lvServices.FocusedItem.SubItems[1].Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void lvServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvServices.Items.Count > 0 && this.lvServices.SelectedItems.Count > 0)
            {
                this.btnSelect.Enabled = true;
            }
            else
            {
                this.btnSelect.Enabled = false;
            }
        }

    }

}
