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
            this.grpModuleControl = new System.Windows.Forms.GroupBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.tmrSync = new System.Windows.Forms.Timer(this.components);
            this.ctmConfig = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmAdmin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpLoadedModules.SuspendLayout();
            this.grpModuleControl.SuspendLayout();
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
            this.lvModules.SelectedIndexChanged += new System.EventHandler(this.lvModules_SelectIndexChange);
            // 
            // rtbConsole
            // 
            this.rtbConsole.Location = new System.Drawing.Point(12, 335);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.Size = new System.Drawing.Size(516, 170);
            this.rtbConsole.TabIndex = 2;
            this.rtbConsole.Text = "";
            // 
            // grpModuleControl
            // 
            this.grpModuleControl.Controls.Add(this.btnConfig);
            this.grpModuleControl.Controls.Add(this.btnAdmin);
            this.grpModuleControl.Controls.Add(this.btnToggle);
            this.grpModuleControl.Location = new System.Drawing.Point(12, 279);
            this.grpModuleControl.Name = "grpModuleControl";
            this.grpModuleControl.Size = new System.Drawing.Size(516, 50);
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
            this.btnConfig.Size = new System.Drawing.Size(122, 23);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "Configuration";
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Enabled = false;
            this.btnAdmin.Image = global::PandaStack.Properties.Resources.wrench;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.Location = new System.Drawing.Point(134, 21);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(122, 23);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Administration";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.Enabled = false;
            this.btnToggle.Location = new System.Drawing.Point(6, 21);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(122, 23);
            this.btnToggle.TabIndex = 0;
            this.btnToggle.Text = "Start Module";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // tmrSync
            // 
            this.tmrSync.Interval = 777;
            this.tmrSync.Tick += new System.EventHandler(this.tmrSync_Tick);
            // 
            // ctmConfig
            // 
            this.ctmConfig.Name = "ctmConfig";
            this.ctmConfig.Size = new System.Drawing.Size(61, 4);
            // 
            // ctmAdmin
            // 
            this.ctmAdmin.Name = "ctmAdmin";
            this.ctmAdmin.Size = new System.Drawing.Size(61, 4);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::PandaStack.Properties.Resources.cancel;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(238, 511);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 23);
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
            this.btnAbout.Location = new System.Drawing.Point(125, 511);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(107, 23);
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
            this.btnRefresh.Location = new System.Drawing.Point(12, 511);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 23);
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
            this.ClientSize = new System.Drawing.Size(540, 542);
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
            this.grpLoadedModules.ResumeLayout(false);
            this.grpModuleControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoadedModules;
        private System.Windows.Forms.ListView lvModules;
        private System.Windows.Forms.GroupBox grpModuleControl;
        private System.Windows.Forms.Button btnToggle;
        public System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Timer tmrSync;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.ContextMenuStrip ctmConfig;
        private System.Windows.Forms.ContextMenuStrip ctmAdmin;
    }
}

