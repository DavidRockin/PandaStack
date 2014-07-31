using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PandaStack
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            this.btnApply.Enabled = false;
            this.numTimerInterval.Enabled = false;
            this.chkAutoStart.Enabled = false;
            this.chkDisplayDebug.Enabled = false;
            this.chkMinimize.Enabled = false;
            this.chkShowBalloonTip.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
