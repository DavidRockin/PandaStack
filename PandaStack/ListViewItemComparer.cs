using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PandaStack
{

    class ListViewItemComparer : IComparer
    {

        private int _column;
        private SortOrder _order;

        public ListViewItemComparer()
        {
            this._column = 0;
            this._order = SortOrder.Ascending;
        }

        public ListViewItemComparer(int column, SortOrder order)
        {
            this._column = column;
            this._order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = String.Compare(((ListViewItem)x).SubItems[this._column].Text,
                                    ((ListViewItem)y).SubItems[this._column].Text);

            if (this._order == SortOrder.Descending)
            {
                returnVal *= -1;
            }

            return returnVal;
        }
    }

}
