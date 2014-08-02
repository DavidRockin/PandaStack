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
            JsonSettings settings = Program.PandaStack.GetJsonHandler().GetSettings();

            // Set timer sync interval
            if (settings.timerInterval >= 250 && settings.timerInterval <= 60000)
            {
                this.numTimerInterval.Value = settings.timerInterval;
            }
            else
            {
                this.numTimerInterval.Value = 2000;
            }

            // Set the minimize to tray checkbox
            if (settings.minimizeToTray == true)
            {
                this.chkMinimize.Checked = true;
            }

            // Set the display minimize tooltip checkbox
            if (settings.minimizeToolTip == true)
            {
                this.chkShowBalloonTip.Checked = true;
            }

            // Set the display debug messages checkbox
            if (settings.displayDebug == true)
            {
                this.chkDisplayDebug.Checked = true;
            }

            this.chkAutoStart.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // TODO: Take the values, update the config
        }
    }

}
