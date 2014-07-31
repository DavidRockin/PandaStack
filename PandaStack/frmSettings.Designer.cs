namespace PandaStack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.chkDisplayDebug = new System.Windows.Forms.CheckBox();
            this.grpPSS = new System.Windows.Forms.GroupBox();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.numTimerInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkMinimize = new System.Windows.Forms.CheckBox();
            this.chkShowBalloonTip = new System.Windows.Forms.CheckBox();
            this.grpPSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimerInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // chkDisplayDebug
            // 
            this.chkDisplayDebug.AutoSize = true;
            this.chkDisplayDebug.Location = new System.Drawing.Point(9, 19);
            this.chkDisplayDebug.Name = "chkDisplayDebug";
            this.chkDisplayDebug.Size = new System.Drawing.Size(143, 17);
            this.chkDisplayDebug.TabIndex = 0;
            this.chkDisplayDebug.Text = "Display debug messages";
            this.chkDisplayDebug.UseVisualStyleBackColor = true;
            // 
            // grpPSS
            // 
            this.grpPSS.Controls.Add(this.chkShowBalloonTip);
            this.grpPSS.Controls.Add(this.chkMinimize);
            this.grpPSS.Controls.Add(this.chkAutoStart);
            this.grpPSS.Controls.Add(this.numTimerInterval);
            this.grpPSS.Controls.Add(this.label1);
            this.grpPSS.Controls.Add(this.chkDisplayDebug);
            this.grpPSS.Location = new System.Drawing.Point(12, 12);
            this.grpPSS.Name = "grpPSS";
            this.grpPSS.Size = new System.Drawing.Size(531, 157);
            this.grpPSS.TabIndex = 1;
            this.grpPSS.TabStop = false;
            this.grpPSS.Text = "PandaStack Settings";
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Location = new System.Drawing.Point(9, 42);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(140, 17);
            this.chkAutoStart.TabIndex = 3;
            this.chkAutoStart.Text = "Auto start with Windows";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            // 
            // numTimerInterval
            // 
            this.numTimerInterval.Location = new System.Drawing.Point(288, 39);
            this.numTimerInterval.Name = "numTimerInterval";
            this.numTimerInterval.Size = new System.Drawing.Size(98, 20);
            this.numTimerInterval.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Timer Status Interval (milliseconds)";
            // 
            // btnApply
            // 
            this.btnApply.Image = global::PandaStack.Properties.Resources.tick;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.Location = new System.Drawing.Point(12, 175);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(102, 26);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::PandaStack.Properties.Resources.cross;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(120, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 26);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkMinimize
            // 
            this.chkMinimize.AutoSize = true;
            this.chkMinimize.Location = new System.Drawing.Point(9, 65);
            this.chkMinimize.Name = "chkMinimize";
            this.chkMinimize.Size = new System.Drawing.Size(133, 17);
            this.chkMinimize.TabIndex = 4;
            this.chkMinimize.Text = "Minimize to system tray";
            this.chkMinimize.UseVisualStyleBackColor = true;
            // 
            // chkShowBalloonTip
            // 
            this.chkShowBalloonTip.AutoSize = true;
            this.chkShowBalloonTip.Location = new System.Drawing.Point(9, 88);
            this.chkShowBalloonTip.Name = "chkShowBalloonTip";
            this.chkShowBalloonTip.Size = new System.Drawing.Size(126, 17);
            this.chkShowBalloonTip.TabIndex = 5;
            this.chkShowBalloonTip.Text = "Show minimize tooltip";
            this.chkShowBalloonTip.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 206);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpPSS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.Text = "PandaStack Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.grpPSS.ResumeLayout(false);
            this.grpPSS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimerInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDisplayDebug;
        private System.Windows.Forms.GroupBox grpPSS;
        private System.Windows.Forms.NumericUpDown numTimerInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkShowBalloonTip;
        private System.Windows.Forms.CheckBox chkMinimize;
    }
}