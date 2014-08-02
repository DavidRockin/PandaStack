using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PandaStack
{

    public class ListViewItemComparer : IComparer
    {

        private int Column;
        private SortOrder Order;

        public ListViewItemComparer()
        {
            this.Column = 0;
            this.Order = SortOrder.Ascending;
        }

        public ListViewItemComparer(int column, SortOrder order)
        {
            this.Column = column;
            this.Order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = String.Compare(((ListViewItem)x).SubItems[this.Column].Text, ((ListViewItem)y).SubItems[this.Column].Text);

            if (this.Order == SortOrder.Descending)
            {
                returnVal *= -1;
            }

            return returnVal;
        }
    }

}
