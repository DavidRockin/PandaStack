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
        private int SortColumn = -1;

        public frmServiceSelector()
        {
            InitializeComponent();
            this.lvServices.Columns.Add("Service Name", 200);
            this.lvServices.Columns.Add("Service", 175);
            this.lvServices.Columns.Add("Service Status", 150);
        }

        private void frmServiceSelector_Load(object sender, EventArgs e)
        {
            foreach (ServiceController service in ServiceController.GetServices()) {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = service.DisplayName;
                lvi.SubItems.Add(service.ServiceName);
                lvi.SubItems.Add(service.Status.ToString());
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

        private void lvServices_DoubleClick(object sender, EventArgs e)
        {
            if (this.lvServices.Items.Count > 0 && this.lvServices.SelectedItems.Count > 0)
            {
                this.ServiceName = this.lvServices.FocusedItem.SubItems[1].Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void lvServices_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != this.SortColumn)
            {
                this.SortColumn = e.Column;
                this.lvServices.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (this.lvServices.Sorting == SortOrder.Ascending)
                {
                    this.lvServices.Sorting = SortOrder.Descending;
                }
                else
                {
                    this.lvServices.Sorting = SortOrder.Ascending;
                }
            }

            this.lvServices.Sort();
            this.lvServices.ListViewItemSorter = new ListViewItemComparer(e.Column, this.lvServices.Sorting);
        }

    }

}
