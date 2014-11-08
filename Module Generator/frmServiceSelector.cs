using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using DavidRockin.PandaStack.PandaClass;

namespace DavidRockin.PandaStack.ModuleGenerator
{
    public partial class frmServiceSelector : Form
    {
        public string ServiceName;
        private int SortColumn = -1;

        public frmServiceSelector()
        {
            InitializeComponent();
        }

        private void frmServiceSelector_Load(object sender, EventArgs e)
        {
            foreach (ServiceController service in ServiceController.GetServices())
            {
                ListViewItem listServiceItem = new ListViewItem();
                listServiceItem.Text = service.DisplayName;
                listServiceItem.SubItems.Add(service.ServiceName);
                listServiceItem.SubItems.Add(service.Status.ToString());
                this.lvwServices.Items.Add(listServiceItem);
            }
        }

        #region Services list

        private void lvwServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvwServices.Items.Count > 0 && this.lvwServices.SelectedItems.Count >= 0)
                this.btnSelect.Enabled = true;
            else
                this.btnSelect.Enabled = false;
        }

        private void lvwServices_DoubleClick(object sender, EventArgs e)
        {
            this.UseService();
        }
        
        private void lvwServices_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != this.SortColumn)
            {
                this.SortColumn = e.Column;
                this.lvwServices.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (this.lvwServices.Sorting == SortOrder.Ascending)
                {
                    this.lvwServices.Sorting = SortOrder.Descending;
                }
                else
                {
                    this.lvwServices.Sorting = SortOrder.Ascending;
                }
            }

            this.lvwServices.Sort();
            this.lvwServices.ListViewItemSorter = new ListViewItemComparer(e.Column, this.lvwServices.Sorting);
        }

        #endregion

        #region Actions

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.UseService();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion

        private void UseService()
        {
            if (this.lvwServices.Items.Count == 0 || this.lvwServices.SelectedItems.Count == 0)
                return;

            this.ServiceName = this.lvwServices.FocusedItem.SubItems[1].Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
