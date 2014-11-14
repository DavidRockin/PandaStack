namespace DavidRockin.PandaStack.PandaStack
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.chkMinimizeTray = new System.Windows.Forms.CheckBox();
            this.chkMinimizeTooltip = new System.Windows.Forms.CheckBox();
            this.chkStartWindows = new System.Windows.Forms.CheckBox();
            this.chkStartMinimized = new System.Windows.Forms.CheckBox();
            this.chkTimerEnabled = new System.Windows.Forms.CheckBox();
            this.lblTimerInt = new System.Windows.Forms.Label();
            this.nudTimerInterval = new System.Windows.Forms.NumericUpDown();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(12, 12);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(143, 17);
            this.chkDebug.TabIndex = 0;
            this.chkDebug.Text = "Display debug messages";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // chkMinimizeTray
            // 
            this.chkMinimizeTray.AutoSize = true;
            this.chkMinimizeTray.Location = new System.Drawing.Point(12, 35);
            this.chkMinimizeTray.Name = "chkMinimizeTray";
            this.chkMinimizeTray.Size = new System.Drawing.Size(135, 17);
            this.chkMinimizeTray.TabIndex = 1;
            this.chkMinimizeTray.Text = "Minimize to System tray";
            this.chkMinimizeTray.UseVisualStyleBackColor = true;
            // 
            // chkMinimizeTooltip
            // 
            this.chkMinimizeTooltip.AutoSize = true;
            this.chkMinimizeTooltip.Location = new System.Drawing.Point(12, 58);
            this.chkMinimizeTooltip.Name = "chkMinimizeTooltip";
            this.chkMinimizeTooltip.Size = new System.Drawing.Size(126, 17);
            this.chkMinimizeTooltip.TabIndex = 2;
            this.chkMinimizeTooltip.Text = "Show minimize tooltip";
            this.chkMinimizeTooltip.UseVisualStyleBackColor = true;
            // 
            // chkStartWindows
            // 
            this.chkStartWindows.AutoSize = true;
            this.chkStartWindows.Enabled = false;
            this.chkStartWindows.Location = new System.Drawing.Point(12, 81);
            this.chkStartWindows.Name = "chkStartWindows";
            this.chkStartWindows.Size = new System.Drawing.Size(117, 17);
            this.chkStartWindows.TabIndex = 3;
            this.chkStartWindows.Text = "Start with Windows";
            this.chkStartWindows.UseVisualStyleBackColor = true;
            // 
            // chkStartMinimized
            // 
            this.chkStartMinimized.AutoSize = true;
            this.chkStartMinimized.Location = new System.Drawing.Point(12, 104);
            this.chkStartMinimized.Name = "chkStartMinimized";
            this.chkStartMinimized.Size = new System.Drawing.Size(96, 17);
            this.chkStartMinimized.TabIndex = 4;
            this.chkStartMinimized.Text = "Start minimized";
            this.chkStartMinimized.UseVisualStyleBackColor = true;
            // 
            // chkTimerEnabled
            // 
            this.chkTimerEnabled.AutoSize = true;
            this.chkTimerEnabled.Location = new System.Drawing.Point(273, 12);
            this.chkTimerEnabled.Name = "chkTimerEnabled";
            this.chkTimerEnabled.Size = new System.Drawing.Size(109, 17);
            this.chkTimerEnabled.TabIndex = 5;
            this.chkTimerEnabled.Text = "Enable timer sync";
            this.chkTimerEnabled.UseVisualStyleBackColor = true;
            this.chkTimerEnabled.CheckedChanged += new System.EventHandler(this.chkTimerEnabled_CheckedChanged);
            // 
            // lblTimerInt
            // 
            this.lblTimerInt.AutoSize = true;
            this.lblTimerInt.Location = new System.Drawing.Point(270, 36);
            this.lblTimerInt.Name = "lblTimerInt";
            this.lblTimerInt.Size = new System.Drawing.Size(160, 13);
            this.lblTimerInt.TabIndex = 6;
            this.lblTimerInt.Text = "Timer sync interval (milliseconds)\r\n";
            // 
            // nudTimerInterval
            // 
            this.nudTimerInterval.Enabled = false;
            this.nudTimerInterval.Location = new System.Drawing.Point(273, 52);
            this.nudTimerInterval.Maximum = new decimal(new int[] {
            1800000,
            0,
            0,
            0});
            this.nudTimerInterval.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudTimerInterval.Name = "nudTimerInterval";
            this.nudTimerInterval.Size = new System.Drawing.Size(102, 20);
            this.nudTimerInterval.TabIndex = 7;
            this.nudTimerInterval.Tag = "";
            this.nudTimerInterval.ThousandsSeparator = true;
            this.nudTimerInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnApply
            // 
            this.btnApply.Image = global::DavidRockin.PandaStack.PandaStack.Properties.Resources.tick;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.Location = new System.Drawing.Point(242, 112);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(117, 28);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::DavidRockin.PandaStack.PandaStack.Properties.Resources.cross;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(365, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(494, 152);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.nudTimerInterval);
            this.Controls.Add(this.lblTimerInt);
            this.Controls.Add(this.chkTimerEnabled);
            this.Controls.Add(this.chkStartMinimized);
            this.Controls.Add(this.chkStartWindows);
            this.Controls.Add(this.chkMinimizeTooltip);
            this.Controls.Add(this.chkMinimizeTray);
            this.Controls.Add(this.chkDebug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PandaStack Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.CheckBox chkMinimizeTray;
        private System.Windows.Forms.CheckBox chkMinimizeTooltip;
        private System.Windows.Forms.CheckBox chkStartWindows;
        private System.Windows.Forms.CheckBox chkStartMinimized;
        private System.Windows.Forms.CheckBox chkTimerEnabled;
        private System.Windows.Forms.Label lblTimerInt;
        private System.Windows.Forms.NumericUpDown nudTimerInterval;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
    }
}