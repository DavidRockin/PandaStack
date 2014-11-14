using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using DavidRockin.PandaStack.PandaClass;
using DavidRockin.PandaStack.PandaClass.Json;

namespace DavidRockin.PandaStack.PandaStack
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            JsonSettings settings = Program.PandaStack.JsonHandler.GetSettings();

            // Set timer interval
            if (settings.timerInterval >= this.nudTimerInterval.Minimum &&
                settings.timerInterval <= this.nudTimerInterval.Maximum)
            {
                this.nudTimerInterval.Value = settings.timerInterval;
            }
            else
            {
                this.nudTimerInterval.Value = 1000;
            }

            // Set checkboxes
            this.chkMinimizeTray.Checked = settings.minimizeToTray;
            this.chkMinimizeTooltip.Checked = settings.minimizeToolTip;
            this.chkStartMinimized.Checked = settings.startMinimized;
            this.chkDebug.Checked = settings.displayDebug;
            this.chkTimerEnabled.Checked = settings.timerEnabled;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // Set the options
            JsonSettings settings = Program.PandaStack.JsonHandler.GetSettings();
            settings.timerInterval = int.Parse(this.nudTimerInterval.Value.ToString());
            settings.displayDebug = this.chkDebug.Checked;
            settings.minimizeToTray = this.chkMinimizeTray.Checked;
            settings.minimizeToolTip = this.chkMinimizeTooltip.Checked;
            settings.startMinimized = this.chkStartMinimized.Checked;
            settings.timerEnabled = this.chkTimerEnabled.Checked;

            try
            {
                // Serialize the settings, save to configuration
                string serial = Program.PandaStack.JsonHandler.Serialize();
                StreamWriter file = new StreamWriter(Program.PandaStack.JsonHandler.ConfigPath);
                file.WriteLine(serial);
                file.Close();
            }
            catch (Exception ex)
            {
                Information.HandleException(ex);
            }

            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void chkTimerEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.nudTimerInterval.Enabled = this.chkTimerEnabled.Checked;
        }
    }
}
