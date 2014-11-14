namespace DavidRockin.PandaStack.PandaStack
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
            this.grpModulesLoaded = new System.Windows.Forms.GroupBox();
            this.lvwModulesLoaded = new System.Windows.Forms.ListView();
            this.lvwModulesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwModulesStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwModulesType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpModuleControl = new System.Windows.Forms.GroupBox();
            this.tblModuleControl = new System.Windows.Forms.TableLayoutPanel();
            this.btnModuleConfigs = new System.Windows.Forms.Button();
            this.btnModuleToggle = new System.Windows.Forms.Button();
            this.btnModuleControls = new System.Windows.Forms.Button();
            this.tblActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmsConfig = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsConsole = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsConsole_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsConsole_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsConsole_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsConsole_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsConsole_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.cmsMinimize = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsMinimize_Restore = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMinimize_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.niMinimize = new System.Windows.Forms.NotifyIcon(this.components);
            this.tmrServiceUpdate = new System.Windows.Forms.Timer(this.components);
            this.grpModulesLoaded.SuspendLayout();
            this.grpModuleControl.SuspendLayout();
            this.tblModuleControl.SuspendLayout();
            this.tblActions.SuspendLayout();
            this.cmsConsole.SuspendLayout();
            this.cmsMinimize.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModulesLoaded
            // 
            this.grpModulesLoaded.Controls.Add(this.lvwModulesLoaded);
            this.grpModulesLoaded.Location = new System.Drawing.Point(12, 12);
            this.grpModulesLoaded.Name = "grpModulesLoaded";
            this.grpModulesLoaded.Size = new System.Drawing.Size(570, 234);
            this.grpModulesLoaded.TabIndex = 0;
            this.grpModulesLoaded.TabStop = false;
            this.grpModulesLoaded.Text = "Loaded Modules";
            // 
            // lvwModulesLoaded
            // 
            this.lvwModulesLoaded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwModulesName,
            this.lvwModulesStatus,
            this.lvwModulesType});
            this.lvwModulesLoaded.FullRowSelect = true;
            this.lvwModulesLoaded.GridLines = true;
            this.lvwModulesLoaded.HideSelection = false;
            this.lvwModulesLoaded.Location = new System.Drawing.Point(6, 19);
            this.lvwModulesLoaded.MultiSelect = false;
            this.lvwModulesLoaded.Name = "lvwModulesLoaded";
            this.lvwModulesLoaded.Size = new System.Drawing.Size(558, 209);
            this.lvwModulesLoaded.TabIndex = 0;
            this.lvwModulesLoaded.UseCompatibleStateImageBehavior = false;
            this.lvwModulesLoaded.View = System.Windows.Forms.View.Details;
            this.lvwModulesLoaded.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwModulesLoaded_ColumnClick);
            this.lvwModulesLoaded.SelectedIndexChanged += new System.EventHandler(this.lvwModulesLoaded_SelectedIndexChanged);
            // 
            // lvwModulesName
            // 
            this.lvwModulesName.Text = "Module Name";
            this.lvwModulesName.Width = 150;
            // 
            // lvwModulesStatus
            // 
            this.lvwModulesStatus.Text = "Module Status";
            this.lvwModulesStatus.Width = 130;
            // 
            // lvwModulesType
            // 
            this.lvwModulesType.Text = "Module Type";
            this.lvwModulesType.Width = 150;
            // 
            // grpModuleControl
            // 
            this.grpModuleControl.Controls.Add(this.tblModuleControl);
            this.grpModuleControl.Location = new System.Drawing.Point(12, 252);
            this.grpModuleControl.Name = "grpModuleControl";
            this.grpModuleControl.Size = new System.Drawing.Size(570, 59);
            this.grpModuleControl.TabIndex = 1;
            this.grpModuleControl.TabStop = false;
            this.grpModuleControl.Text = "Module Control";
            // 
            // tblModuleControl
            // 
            this.tblModuleControl.ColumnCount = 4;
            this.tblModuleControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblModuleControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblModuleControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblModuleControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblModuleControl.Controls.Add(this.btnModuleConfigs, 1, 0);
            this.tblModuleControl.Controls.Add(this.btnModuleToggle, 0, 0);
            this.tblModuleControl.Controls.Add(this.btnModuleControls, 2, 0);
            this.tblModuleControl.Location = new System.Drawing.Point(6, 19);
            this.tblModuleControl.Name = "tblModuleControl";
            this.tblModuleControl.RowCount = 1;
            this.tblModuleControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblModuleControl.Size = new System.Drawing.Size(558, 34);
            this.tblModuleControl.TabIndex = 0;
            // 
            // btnModuleConfigs
            // 
            this.btnModuleConfigs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModuleConfigs.Enabled = false;
            this.btnModuleConfigs.Image = global::DavidRockin.PandaStack.PandaStack.Properties.Resources.cog;
            this.btnModuleConfigs.Location = new System.Drawing.Point(142, 3);
            this.btnModuleConfigs.Name = "btnModuleConfigs";
            this.btnModuleConfigs.Size = new System.Drawing.Size(133, 28);
            this.btnModuleConfigs.TabIndex = 2;
            this.btnModuleConfigs.Text = "Configs";
            this.btnModuleConfigs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModuleConfigs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModuleConfigs.UseVisualStyleBackColor = true;
            this.btnModuleConfigs.Click += new System.EventHandler(this.btnModuleConfigs_Click);
            // 
            // btnModuleToggle
            // 
            this.btnModuleToggle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModuleToggle.Enabled = false;
            this.btnModuleToggle.Image = global::DavidRockin.PandaStack.PandaStack.Properties.Resources.control_play;
            this.btnModuleToggle.Location = new System.Drawing.Point(3, 3);
            this.btnModuleToggle.Name = "btnModuleToggle";
            this.btnModuleToggle.Size = new System.Drawing.Size(133, 28);
            this.btnModuleToggle.TabIndex = 0;
            this.btnModuleToggle.Text = "Start Module";
            this.btnModuleToggle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModuleToggle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModuleToggle.UseVisualStyleBackColor = true;
            this.btnModuleToggle.Click += new System.EventHandler(this.btnModuleToggle_Click);
            // 
            // btnModuleControls
            // 
            this.btnModuleControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModuleControls.Enabled = false;
            this.btnModuleControls.Image = global::DavidRockin.PandaStack.PandaStack.Properties.Resources.wrench;
            this.btnModuleControls.Location = new System.Drawing.Point(281, 3);
            this.btnModuleControls.Name = "btnModuleControls";
            this.btnModuleControls.Size = new System.Drawing.Size(133, 28);
            this.btnModuleControls.TabIndex = 3;
            this.btnModuleControls.Text = "Controls";
            this.btnModuleControls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModuleControls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModuleControls.UseVisualStyleBackColor = true;
            this.btnModuleControls.Click += new System.EventHandler(this.btnModuleControls_Click);
            // 
            // tblActions
            // 
            this.tblActions.ColumnCount = 4;
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblActions.Controls.Add(this.btnExit, 3, 0);
            this.tblActions.Controls.Add(this.btnSettings, 2, 0);
            this.tblActions.Controls.Add(this.btnAbout, 1, 0);
            this.tblActions.Controls.Add(this.btnRefresh, 0, 0);
            this.tblActions.Location = new System.Drawing.Point(12, 526);
            this.tblActions.Name = "tblActions";
            this.tblActions.RowCount = 1;
            this.tblActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblActions.Size = new System.Drawing.Size(570, 34);
            this.tblActions.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Image = global::DavidRockin.PandaStack.PandaStack.Properties.Resources.cancel;
            this.btnExit.Location = new System.Drawing.Point(429, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.Image = global::DavidRockin.PandaStack.PandaStack.Properties.Resources.wrench;
            this.btnSettings.Location = new System.Drawing.Point(287, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(136, 28);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbout.Image = global::DavidRockin.PandaStack.PandaStack.Properties.Resources.information;
            this.btnAbout.Location = new System.Drawing.Point(145, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(136, 28);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Image = global::DavidRockin.PandaStack.PandaStack.Properties.Resources.arrow_refresh;
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 28);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmsConfig
            // 
            this.cmsConfig.Name = "cmsConfig";
            this.cmsConfig.Size = new System.Drawing.Size(61, 4);
            // 
            // cmsControl
            // 
            this.cmsControl.Name = "cmsControl";
            this.cmsControl.Size = new System.Drawing.Size(61, 4);
            // 
            // cmsConsole
            // 
            this.cmsConsole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsConsole_Copy,
            this.cmsConsole_SelectAll,
            this.cmsConsole_Save,
            this.cmsConsole_Separator1,
            this.cmsConsole_Clear});
            this.cmsConsole.Name = "cmsConsole";
            this.cmsConsole.Size = new System.Drawing.Size(148, 98);
            // 
            // cmsConsole_Copy
            // 
            this.cmsConsole_Copy.Image = global::DavidRockin.PandaStack.PandaStack.Properties.Resources.page_copy;
            this.cmsConsole_Copy.Name = "cmsConsole_Copy";
            this.cmsConsole_Copy.Size = new System.Drawing.Size(147, 22);
            this.cmsConsole_Copy.Text = "Copy";
            this.cmsConsole_Copy.Click += new System.EventHandler(this.cmsConsole_Copy_Click);
            // 
            // cmsConsole_SelectAll
            // 
            this.cmsConsole_SelectAll.Name = "cmsConsole_SelectAll";
            this.cmsConsole_SelectAll.Size = new System.Drawing.Size(147, 22);
            this.cmsConsole_SelectAll.Text = "Select All";
            this.cmsConsole_SelectAll.Click += new System.EventHandler(this.cmsConsole_SelectAll_Click);
            // 
            // cmsConsole_Save
            // 
            this.cmsConsole_Save.Image = global::DavidRockin.PandaStack.PandaStack.Properties.Resources.disk;
            this.cmsConsole_Save.Name = "cmsConsole_Save";
            this.cmsConsole_Save.Size = new System.Drawing.Size(147, 22);
            this.cmsConsole_Save.Text = "Save";
            this.cmsConsole_Save.Click += new System.EventHandler(this.cmsConsole_Save_Click);
            // 
            // cmsConsole_Separator1
            // 
            this.cmsConsole_Separator1.Name = "cmsConsole_Separator1";
            this.cmsConsole_Separator1.Size = new System.Drawing.Size(144, 6);
            // 
            // cmsConsole_Clear
            // 
            this.cmsConsole_Clear.Image = global::DavidRockin.PandaStack.PandaStack.Properties.Resources.cross;
            this.cmsConsole_Clear.Name = "cmsConsole_Clear";
            this.cmsConsole_Clear.Size = new System.Drawing.Size(147, 22);
            this.cmsConsole_Clear.Text = "Clear Console";
            this.cmsConsole_Clear.Click += new System.EventHandler(this.cmsConsole_Clear_Click);
            // 
            // rtbConsole
            // 
            this.rtbConsole.ContextMenuStrip = this.cmsConsole;
            this.rtbConsole.Location = new System.Drawing.Point(12, 317);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbConsole.Size = new System.Drawing.Size(570, 203);
            this.rtbConsole.TabIndex = 7;
            this.rtbConsole.Text = "";
            // 
            // cmsMinimize
            // 
            this.cmsMinimize.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsMinimize_Restore,
            this.cmsMinimize_Exit});
            this.cmsMinimize.Name = "cmsMinimize";
            this.cmsMinimize.Size = new System.Drawing.Size(178, 48);
            // 
            // cmsMinimize_Restore
            // 
            this.cmsMinimize_Restore.Image = global::DavidRockin.PandaStack.PandaStack.Properties.Resources.application_double;
            this.cmsMinimize_Restore.Name = "cmsMinimize_Restore";
            this.cmsMinimize_Restore.Size = new System.Drawing.Size(177, 22);
            this.cmsMinimize_Restore.Text = "Restore PandaStack";
            this.cmsMinimize_Restore.Click += new System.EventHandler(this.cmsMinimize_Restore_Click);
            // 
            // cmsMinimize_Exit
            // 
            this.cmsMinimize_Exit.Image = global::DavidRockin.PandaStack.PandaStack.Properties.Resources.cross;
            this.cmsMinimize_Exit.Name = "cmsMinimize_Exit";
            this.cmsMinimize_Exit.Size = new System.Drawing.Size(177, 22);
            this.cmsMinimize_Exit.Text = "Exit";
            this.cmsMinimize_Exit.Click += new System.EventHandler(this.cmsMinimize_Exit_Click);
            // 
            // niMinimize
            // 
            this.niMinimize.BalloonTipText = "PandaStack has minimized to your system\'s tray, you can open it by double-clickin" +
                "g the PandaStack icon.";
            this.niMinimize.BalloonTipTitle = "PandaStack Minimized";
            this.niMinimize.ContextMenuStrip = this.cmsMinimize;
            this.niMinimize.Icon = ((System.Drawing.Icon)(resources.GetObject("niMinimize.Icon")));
            this.niMinimize.Text = "PandaStack";
            this.niMinimize.Visible = true;
            this.niMinimize.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niMinimize_MouseDoubleClick);
            // 
            // tmrServiceUpdate
            // 
            this.tmrServiceUpdate.Interval = 1000;
            this.tmrServiceUpdate.Tick += new System.EventHandler(this.tmrServiceUpdate_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 572);
            this.Controls.Add(this.rtbConsole);
            this.Controls.Add(this.tblActions);
            this.Controls.Add(this.grpModuleControl);
            this.Controls.Add(this.grpModulesLoaded);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PandaStack";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.grpModulesLoaded.ResumeLayout(false);
            this.grpModuleControl.ResumeLayout(false);
            this.tblModuleControl.ResumeLayout(false);
            this.tblActions.ResumeLayout(false);
            this.cmsConsole.ResumeLayout(false);
            this.cmsMinimize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModulesLoaded;
        private System.Windows.Forms.ListView lvwModulesLoaded;
        private System.Windows.Forms.GroupBox grpModuleControl;
        private System.Windows.Forms.TableLayoutPanel tblModuleControl;
        private System.Windows.Forms.Button btnModuleConfigs;
        private System.Windows.Forms.Button btnModuleToggle;
        private System.Windows.Forms.TableLayoutPanel tblActions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnModuleControls;
        private System.Windows.Forms.ContextMenuStrip cmsConfig;
        private System.Windows.Forms.ContextMenuStrip cmsControl;
        private System.Windows.Forms.ContextMenuStrip cmsConsole;
        private System.Windows.Forms.ToolStripMenuItem cmsConsole_Copy;
        private System.Windows.Forms.ToolStripMenuItem cmsConsole_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem cmsConsole_Save;
        private System.Windows.Forms.ToolStripSeparator cmsConsole_Separator1;
        private System.Windows.Forms.ToolStripMenuItem cmsConsole_Clear;
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.ContextMenuStrip cmsMinimize;
        private System.Windows.Forms.ToolStripMenuItem cmsMinimize_Restore;
        private System.Windows.Forms.ToolStripMenuItem cmsMinimize_Exit;
        private System.Windows.Forms.NotifyIcon niMinimize;
        private System.Windows.Forms.ColumnHeader lvwModulesName;
        private System.Windows.Forms.ColumnHeader lvwModulesStatus;
        private System.Windows.Forms.ColumnHeader lvwModulesType;
        private System.Windows.Forms.Timer tmrServiceUpdate;
    }
}

