namespace PandaStack
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpLoadedModules = new System.Windows.Forms.GroupBox();
            this.lvModules = new System.Windows.Forms.ListView();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.ctmConsole = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmConsole_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmConsole_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmConsole_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmConsole_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.grpModuleControl = new System.Windows.Forms.GroupBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.tmrSync = new System.Windows.Forms.Timer(this.components);
            this.ctmConfig = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.niMinimize = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctmMinimize = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmMinimize_restore = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmMinimize_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpLoadedModules.SuspendLayout();
            this.ctmConsole.SuspendLayout();
            this.grpModuleControl.SuspendLayout();
            this.ctmMinimize.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoadedModules
            // 
            this.grpLoadedModules.Controls.Add(this.lvModules);
            this.grpLoadedModules.Location = new System.Drawing.Point(12, 12);
            this.grpLoadedModules.Name = "grpLoadedModules";
            this.grpLoadedModules.Size = new System.Drawing.Size(516, 261);
            this.grpLoadedModules.TabIndex = 0;
            this.grpLoadedModules.TabStop = false;
            this.grpLoadedModules.Text = "Loaded Modules";
            // 
            // lvModules
            // 
            this.lvModules.FullRowSelect = true;
            this.lvModules.Location = new System.Drawing.Point(6, 19);
            this.lvModules.MultiSelect = false;
            this.lvModules.Name = "lvModules";
            this.lvModules.Size = new System.Drawing.Size(504, 236);
            this.lvModules.TabIndex = 0;
            this.lvModules.UseCompatibleStateImageBehavior = false;
            this.lvModules.View = System.Windows.Forms.View.Details;
            this.lvModules.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvModules_ColumnClick);
            this.lvModules.SelectedIndexChanged += new System.EventHandler(this.lvModules_SelectIndexChange);
            // 
            // rtbConsole
            // 
            this.rtbConsole.ContextMenuStrip = this.ctmConsole;
            this.rtbConsole.Location = new System.Drawing.Point(12, 341);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.Size = new System.Drawing.Size(516, 170);
            this.rtbConsole.TabIndex = 2;
            this.rtbConsole.Text = "";
            // 
            // ctmConsole
            // 
            this.ctmConsole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmConsole_Copy,
            this.ctmConsole_SelectAll,
            this.ctmConsole_Save,
            this.toolStripSeparator1,
            this.ctmConsole_Clear});
            this.ctmConsole.Name = "ctmConsole";
            this.ctmConsole.Size = new System.Drawing.Size(148, 98);
            // 
            // ctmConsole_Copy
            // 
            this.ctmConsole_Copy.Image = global::PandaStack.Properties.Resources.page_copy;
            this.ctmConsole_Copy.Name = "ctmConsole_Copy";
            this.ctmConsole_Copy.Size = new System.Drawing.Size(147, 22);
            this.ctmConsole_Copy.Text = "Copy";
            this.ctmConsole_Copy.Click += new System.EventHandler(this.ctmConsole_Copy_Click);
            // 
            // ctmConsole_SelectAll
            // 
            this.ctmConsole_SelectAll.Name = "ctmConsole_SelectAll";
            this.ctmConsole_SelectAll.Size = new System.Drawing.Size(147, 22);
            this.ctmConsole_SelectAll.Text = "Select All";
            this.ctmConsole_SelectAll.Click += new System.EventHandler(this.ctmConsole_SelectAll_Click);
            // 
            // ctmConsole_Save
            // 
            this.ctmConsole_Save.Image = global::PandaStack.Properties.Resources.disk;
            this.ctmConsole_Save.Name = "ctmConsole_Save";
            this.ctmConsole_Save.Size = new System.Drawing.Size(147, 22);
            this.ctmConsole_Save.Text = "Save";
            this.ctmConsole_Save.Click += new System.EventHandler(this.ctmConsole_Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // ctmConsole_Clear
            // 
            this.ctmConsole_Clear.Image = global::PandaStack.Properties.Resources.cross;
            this.ctmConsole_Clear.Name = "ctmConsole_Clear";
            this.ctmConsole_Clear.Size = new System.Drawing.Size(147, 22);
            this.ctmConsole_Clear.Text = "Clear Console";
            this.ctmConsole_Clear.Click += new System.EventHandler(this.ctmConsole_Clear_Click);
            // 
            // grpModuleControl
            // 
            this.grpModuleControl.Controls.Add(this.btnConfig);
            this.grpModuleControl.Controls.Add(this.btnControl);
            this.grpModuleControl.Controls.Add(this.btnToggle);
            this.grpModuleControl.Location = new System.Drawing.Point(12, 279);
            this.grpModuleControl.Name = "grpModuleControl";
            this.grpModuleControl.Size = new System.Drawing.Size(516, 56);
            this.grpModuleControl.TabIndex = 1;
            this.grpModuleControl.TabStop = false;
            this.grpModuleControl.Text = "Module Control";
            // 
            // btnConfig
            // 
            this.btnConfig.Enabled = false;
            this.btnConfig.Image = global::PandaStack.Properties.Resources.cog;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfig.Location = new System.Drawing.Point(262, 21);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(122, 28);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "Configs";
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnControl
            // 
            this.btnControl.Enabled = false;
            this.btnControl.Image = global::PandaStack.Properties.Resources.wrench;
            this.btnControl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnControl.Location = new System.Drawing.Point(134, 21);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(122, 28);
            this.btnControl.TabIndex = 1;
            this.btnControl.Text = "Controls";
            this.btnControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.Enabled = false;
            this.btnToggle.Location = new System.Drawing.Point(6, 21);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(122, 28);
            this.btnToggle.TabIndex = 0;
            this.btnToggle.Text = "Start Module";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // tmrSync
            // 
            this.tmrSync.Interval = 1000;
            this.tmrSync.Tick += new System.EventHandler(this.tmrSync_Tick);
            // 
            // ctmConfig
            // 
            this.ctmConfig.Name = "ctmConfig";
            this.ctmConfig.Size = new System.Drawing.Size(61, 4);
            // 
            // ctmControl
            // 
            this.ctmControl.Name = "ctmAdmin";
            this.ctmControl.Size = new System.Drawing.Size(61, 4);
            // 
            // niMinimize
            // 
            this.niMinimize.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niMinimize.BalloonTipText = "PandaStack has minimized to your system\'s tray, you can open it by double-clickin" +
                "g the PandaStack icon.";
            this.niMinimize.BalloonTipTitle = "PandaStack Minimized";
            this.niMinimize.ContextMenuStrip = this.ctmMinimize;
            this.niMinimize.Icon = ((System.Drawing.Icon)(resources.GetObject("niMinimize.Icon")));
            this.niMinimize.Text = "PandaStack";
            this.niMinimize.Visible = true;
            this.niMinimize.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niMinimize_MouseDoubleClick);
            // 
            // ctmMinimize
            // 
            this.ctmMinimize.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmMinimize_restore,
            this.ctmMinimize_exit});
            this.ctmMinimize.Name = "ctmMinimize";
            this.ctmMinimize.Size = new System.Drawing.Size(178, 48);
            // 
            // ctmMinimize_restore
            // 
            this.ctmMinimize_restore.Image = global::PandaStack.Properties.Resources.application_double;
            this.ctmMinimize_restore.Name = "ctmMinimize_restore";
            this.ctmMinimize_restore.Size = new System.Drawing.Size(177, 22);
            this.ctmMinimize_restore.Text = "Restore PandaStack";
            this.ctmMinimize_restore.Click += new System.EventHandler(this.ctmMinimize_Restore_Click);
            // 
            // ctmMinimize_exit
            // 
            this.ctmMinimize_exit.Image = global::PandaStack.Properties.Resources.cancel;
            this.ctmMinimize_exit.Name = "ctmMinimize_exit";
            this.ctmMinimize_exit.Size = new System.Drawing.Size(177, 22);
            this.ctmMinimize_exit.Text = "Exit PandaStack";
            this.ctmMinimize_exit.Click += new System.EventHandler(this.ctmMinimize_Exit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::PandaStack.Properties.Resources.cog;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(262, 517);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(119, 26);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::PandaStack.Properties.Resources.cancel;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(387, 517);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 26);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::PandaStack.Properties.Resources.information;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.Location = new System.Drawing.Point(137, 517);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(119, 26);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::PandaStack.Properties.Resources.arrow_refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(12, 517);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 26);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 554);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.rtbConsole);
            this.Controls.Add(this.grpModuleControl);
            this.Controls.Add(this.grpLoadedModules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PandaStack";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.grpLoadedModules.ResumeLayout(false);
            this.ctmConsole.ResumeLayout(false);
            this.grpModuleControl.ResumeLayout(false);
            this.ctmMinimize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoadedModules;
        private System.Windows.Forms.ListView lvModules;
        private System.Windows.Forms.GroupBox grpModuleControl;
        private System.Windows.Forms.Button btnToggle;
        public System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Timer tmrSync;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.ContextMenuStrip ctmConfig;
        private System.Windows.Forms.ContextMenuStrip ctmControl;
        private System.Windows.Forms.ContextMenuStrip ctmConsole;
        private System.Windows.Forms.ToolStripMenuItem ctmConsole_Copy;
        private System.Windows.Forms.ToolStripMenuItem ctmConsole_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem ctmConsole_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctmConsole_Clear;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.NotifyIcon niMinimize;
        private System.Windows.Forms.ContextMenuStrip ctmMinimize;
        private System.Windows.Forms.ToolStripMenuItem ctmMinimize_restore;
        private System.Windows.Forms.ToolStripMenuItem ctmMinimize_exit;
    }
}

