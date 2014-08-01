namespace PandaStack_Module_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpModules = new System.Windows.Forms.GroupBox();
            this.btnMvDwn = new System.Windows.Forms.Button();
            this.btnMvUp = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvModules = new System.Windows.Forms.ListView();
            this.grpModuleOptions = new System.Windows.Forms.GroupBox();
            this.btnAdmin_Edit = new System.Windows.Forms.Button();
            this.btnAdmin_Remove = new System.Windows.Forms.Button();
            this.btnAdmin_Add = new System.Windows.Forms.Button();
            this.btnConfig_Edit = new System.Windows.Forms.Button();
            this.lvConfigs = new System.Windows.Forms.ListView();
            this.btnConfig_Remove = new System.Windows.Forms.Button();
            this.btnConfig_Add = new System.Windows.Forms.Button();
            this.lblConfigs = new System.Windows.Forms.Label();
            this.lvAdmins = new System.Windows.Forms.ListView();
            this.lblAdmins = new System.Windows.Forms.Label();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblModuleType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnImportConfig = new System.Windows.Forms.Button();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.grpModules.SuspendLayout();
            this.grpModuleOptions.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModules
            // 
            this.grpModules.Controls.Add(this.btnMvDwn);
            this.grpModules.Controls.Add(this.btnMvUp);
            this.grpModules.Controls.Add(this.btnRemove);
            this.grpModules.Controls.Add(this.btnAdd);
            this.grpModules.Controls.Add(this.lvModules);
            this.grpModules.Location = new System.Drawing.Point(12, 12);
            this.grpModules.Name = "grpModules";
            this.grpModules.Size = new System.Drawing.Size(244, 587);
            this.grpModules.TabIndex = 0;
            this.grpModules.TabStop = false;
            this.grpModules.Text = "Loaded Module";
            // 
            // btnMvDwn
            // 
            this.btnMvDwn.Enabled = false;
            this.btnMvDwn.Image = global::PandaStack_Module_Generator.Properties.Resources.arrow_270;
            this.btnMvDwn.Location = new System.Drawing.Point(148, 554);
            this.btnMvDwn.Name = "btnMvDwn";
            this.btnMvDwn.Size = new System.Drawing.Size(30, 27);
            this.btnMvDwn.TabIndex = 4;
            this.btnMvDwn.UseVisualStyleBackColor = true;
            // 
            // btnMvUp
            // 
            this.btnMvUp.Enabled = false;
            this.btnMvUp.Image = global::PandaStack_Module_Generator.Properties.Resources.arrow_090;
            this.btnMvUp.Location = new System.Drawing.Point(112, 554);
            this.btnMvUp.Name = "btnMvUp";
            this.btnMvUp.Size = new System.Drawing.Size(30, 27);
            this.btnMvUp.TabIndex = 3;
            this.btnMvUp.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Image = global::PandaStack_Module_Generator.Properties.Resources.minus;
            this.btnRemove.Location = new System.Drawing.Point(76, 554);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(30, 27);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PandaStack_Module_Generator.Properties.Resources.plus;
            this.btnAdd.Location = new System.Drawing.Point(40, 554);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 27);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvModules
            // 
            this.lvModules.FullRowSelect = true;
            this.lvModules.GridLines = true;
            this.lvModules.Location = new System.Drawing.Point(6, 19);
            this.lvModules.MultiSelect = false;
            this.lvModules.Name = "lvModules";
            this.lvModules.Size = new System.Drawing.Size(232, 529);
            this.lvModules.TabIndex = 1;
            this.lvModules.UseCompatibleStateImageBehavior = false;
            this.lvModules.View = System.Windows.Forms.View.Details;
            this.lvModules.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvModules_ItemSelectionChanged);
            // 
            // grpModuleOptions
            // 
            this.grpModuleOptions.Controls.Add(this.btnAdmin_Edit);
            this.grpModuleOptions.Controls.Add(this.btnAdmin_Remove);
            this.grpModuleOptions.Controls.Add(this.btnAdmin_Add);
            this.grpModuleOptions.Controls.Add(this.btnConfig_Edit);
            this.grpModuleOptions.Controls.Add(this.lvConfigs);
            this.grpModuleOptions.Controls.Add(this.btnConfig_Remove);
            this.grpModuleOptions.Controls.Add(this.btnConfig_Add);
            this.grpModuleOptions.Controls.Add(this.lblConfigs);
            this.grpModuleOptions.Controls.Add(this.lvAdmins);
            this.grpModuleOptions.Controls.Add(this.lblAdmins);
            this.grpModuleOptions.Controls.Add(this.btnDiscard);
            this.grpModuleOptions.Controls.Add(this.btnSave);
            this.grpModuleOptions.Controls.Add(this.txtServiceName);
            this.grpModuleOptions.Controls.Add(this.lblServiceName);
            this.grpModuleOptions.Controls.Add(this.cmbType);
            this.grpModuleOptions.Controls.Add(this.lblModuleType);
            this.grpModuleOptions.Controls.Add(this.txtName);
            this.grpModuleOptions.Controls.Add(this.lblModuleName);
            this.grpModuleOptions.Enabled = false;
            this.grpModuleOptions.Location = new System.Drawing.Point(262, 12);
            this.grpModuleOptions.Name = "grpModuleOptions";
            this.grpModuleOptions.Size = new System.Drawing.Size(506, 534);
            this.grpModuleOptions.TabIndex = 1;
            this.grpModuleOptions.TabStop = false;
            this.grpModuleOptions.Text = "Module Options";
            // 
            // btnAdmin_Edit
            // 
            this.btnAdmin_Edit.Enabled = false;
            this.btnAdmin_Edit.Image = global::PandaStack_Module_Generator.Properties.Resources.gear;
            this.btnAdmin_Edit.Location = new System.Drawing.Point(470, 200);
            this.btnAdmin_Edit.Name = "btnAdmin_Edit";
            this.btnAdmin_Edit.Size = new System.Drawing.Size(30, 27);
            this.btnAdmin_Edit.TabIndex = 20;
            this.btnAdmin_Edit.UseVisualStyleBackColor = true;
            this.btnAdmin_Edit.Click += new System.EventHandler(this.btnAdmin_Edit_Click);
            // 
            // btnAdmin_Remove
            // 
            this.btnAdmin_Remove.Enabled = false;
            this.btnAdmin_Remove.Image = global::PandaStack_Module_Generator.Properties.Resources.minus;
            this.btnAdmin_Remove.Location = new System.Drawing.Point(470, 167);
            this.btnAdmin_Remove.Name = "btnAdmin_Remove";
            this.btnAdmin_Remove.Size = new System.Drawing.Size(30, 27);
            this.btnAdmin_Remove.TabIndex = 19;
            this.btnAdmin_Remove.UseVisualStyleBackColor = true;
            this.btnAdmin_Remove.Click += new System.EventHandler(this.btnAdmin_Remove_Click);
            // 
            // btnAdmin_Add
            // 
            this.btnAdmin_Add.Image = global::PandaStack_Module_Generator.Properties.Resources.plus;
            this.btnAdmin_Add.Location = new System.Drawing.Point(470, 134);
            this.btnAdmin_Add.Name = "btnAdmin_Add";
            this.btnAdmin_Add.Size = new System.Drawing.Size(30, 27);
            this.btnAdmin_Add.TabIndex = 18;
            this.btnAdmin_Add.UseVisualStyleBackColor = true;
            this.btnAdmin_Add.Click += new System.EventHandler(this.btnAdmin_Add_Click);
            // 
            // btnConfig_Edit
            // 
            this.btnConfig_Edit.Enabled = false;
            this.btnConfig_Edit.Image = global::PandaStack_Module_Generator.Properties.Resources.gear;
            this.btnConfig_Edit.Location = new System.Drawing.Point(470, 351);
            this.btnConfig_Edit.Name = "btnConfig_Edit";
            this.btnConfig_Edit.Size = new System.Drawing.Size(30, 27);
            this.btnConfig_Edit.TabIndex = 17;
            this.btnConfig_Edit.UseVisualStyleBackColor = true;
            this.btnConfig_Edit.Click += new System.EventHandler(this.btnConfig_Edit_Click);
            // 
            // lvConfigs
            // 
            this.lvConfigs.FullRowSelect = true;
            this.lvConfigs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvConfigs.Location = new System.Drawing.Point(9, 265);
            this.lvConfigs.MultiSelect = false;
            this.lvConfigs.Name = "lvConfigs";
            this.lvConfigs.Size = new System.Drawing.Size(455, 133);
            this.lvConfigs.TabIndex = 14;
            this.lvConfigs.UseCompatibleStateImageBehavior = false;
            this.lvConfigs.View = System.Windows.Forms.View.Details;
            this.lvConfigs.SelectedIndexChanged += new System.EventHandler(this.lvConfigs_SelectedIndexChanged);
            // 
            // btnConfig_Remove
            // 
            this.btnConfig_Remove.Enabled = false;
            this.btnConfig_Remove.Image = global::PandaStack_Module_Generator.Properties.Resources.minus;
            this.btnConfig_Remove.Location = new System.Drawing.Point(470, 318);
            this.btnConfig_Remove.Name = "btnConfig_Remove";
            this.btnConfig_Remove.Size = new System.Drawing.Size(30, 27);
            this.btnConfig_Remove.TabIndex = 13;
            this.btnConfig_Remove.UseVisualStyleBackColor = true;
            this.btnConfig_Remove.Click += new System.EventHandler(this.btnConfig_Remove_Click);
            // 
            // btnConfig_Add
            // 
            this.btnConfig_Add.Image = global::PandaStack_Module_Generator.Properties.Resources.plus;
            this.btnConfig_Add.Location = new System.Drawing.Point(470, 285);
            this.btnConfig_Add.Name = "btnConfig_Add";
            this.btnConfig_Add.Size = new System.Drawing.Size(30, 27);
            this.btnConfig_Add.TabIndex = 12;
            this.btnConfig_Add.UseVisualStyleBackColor = true;
            this.btnConfig_Add.Click += new System.EventHandler(this.btnConfig_Add_Click);
            // 
            // lblConfigs
            // 
            this.lblConfigs.AutoSize = true;
            this.lblConfigs.Location = new System.Drawing.Point(9, 249);
            this.lblConfigs.Name = "lblConfigs";
            this.lblConfigs.Size = new System.Drawing.Size(74, 13);
            this.lblConfigs.TabIndex = 10;
            this.lblConfigs.Text = "Configurations";
            // 
            // lvAdmins
            // 
            this.lvAdmins.FullRowSelect = true;
            this.lvAdmins.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAdmins.Location = new System.Drawing.Point(9, 113);
            this.lvAdmins.MultiSelect = false;
            this.lvAdmins.Name = "lvAdmins";
            this.lvAdmins.Size = new System.Drawing.Size(455, 133);
            this.lvAdmins.TabIndex = 9;
            this.lvAdmins.UseCompatibleStateImageBehavior = false;
            this.lvAdmins.View = System.Windows.Forms.View.Details;
            this.lvAdmins.SelectedIndexChanged += new System.EventHandler(this.lvAdmins_SelectedIndexChanged);
            // 
            // lblAdmins
            // 
            this.lblAdmins.AutoSize = true;
            this.lblAdmins.Location = new System.Drawing.Point(9, 97);
            this.lblAdmins.Name = "lblAdmins";
            this.lblAdmins.Size = new System.Drawing.Size(77, 13);
            this.lblAdmins.TabIndex = 8;
            this.lblAdmins.Text = "Administrations";
            // 
            // btnDiscard
            // 
            this.btnDiscard.Image = global::PandaStack_Module_Generator.Properties.Resources.cross;
            this.btnDiscard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscard.Location = new System.Drawing.Point(125, 500);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(110, 28);
            this.btnDiscard.TabIndex = 7;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PandaStack_Module_Generator.Properties.Resources.disk;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(9, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(9, 74);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(194, 20);
            this.txtServiceName.TabIndex = 5;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(9, 58);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(74, 13);
            this.lblServiceName.TabIndex = 4;
            this.lblServiceName.Text = "Service Name";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(340, 35);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(160, 21);
            this.cmbType.TabIndex = 3;
            // 
            // lblModuleType
            // 
            this.lblModuleType.AutoSize = true;
            this.lblModuleType.Location = new System.Drawing.Point(337, 16);
            this.lblModuleType.Name = "lblModuleType";
            this.lblModuleType.Size = new System.Drawing.Size(69, 13);
            this.lblModuleType.TabIndex = 2;
            this.lblModuleType.Text = "Module Type";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(325, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Location = new System.Drawing.Point(9, 19);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(73, 13);
            this.lblModuleName.TabIndex = 0;
            this.lblModuleName.Text = "Module Name";
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnImportConfig);
            this.grpActions.Controls.Add(this.btnLoadConfig);
            this.grpActions.Location = new System.Drawing.Point(262, 552);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(506, 47);
            this.grpActions.TabIndex = 2;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // btnImportConfig
            // 
            this.btnImportConfig.Image = global::PandaStack_Module_Generator.Properties.Resources.page_white_get;
            this.btnImportConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportConfig.Location = new System.Drawing.Point(157, 14);
            this.btnImportConfig.Name = "btnImportConfig";
            this.btnImportConfig.Size = new System.Drawing.Size(142, 28);
            this.btnImportConfig.TabIndex = 8;
            this.btnImportConfig.Text = "Import Config";
            this.btnImportConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportConfig.UseVisualStyleBackColor = true;
            this.btnImportConfig.Click += new System.EventHandler(this.btnImportConfig_Click);
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Image = global::PandaStack_Module_Generator.Properties.Resources.folder_page;
            this.btnLoadConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadConfig.Location = new System.Drawing.Point(9, 14);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(142, 28);
            this.btnLoadConfig.TabIndex = 7;
            this.btnLoadConfig.Text = "Load Config";
            this.btnLoadConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 611);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpModuleOptions);
            this.Controls.Add(this.grpModules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PandaStack Module Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpModules.ResumeLayout(false);
            this.grpModuleOptions.ResumeLayout(false);
            this.grpModuleOptions.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModules;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvModules;
        private System.Windows.Forms.Button btnMvDwn;
        private System.Windows.Forms.Button btnMvUp;
        private System.Windows.Forms.GroupBox grpModuleOptions;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblModuleType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.ListView lvConfigs;
        private System.Windows.Forms.Button btnConfig_Remove;
        private System.Windows.Forms.Button btnConfig_Add;
        private System.Windows.Forms.Label lblConfigs;
        private System.Windows.Forms.Label lblAdmins;
        private System.Windows.Forms.Button btnConfig_Edit;
        private System.Windows.Forms.Button btnAdmin_Edit;
        private System.Windows.Forms.Button btnAdmin_Remove;
        private System.Windows.Forms.Button btnAdmin_Add;
        private System.Windows.Forms.ListView lvAdmins;
        private System.Windows.Forms.Button btnImportConfig;
        private System.Windows.Forms.Button btnLoadConfig;
    }
}

