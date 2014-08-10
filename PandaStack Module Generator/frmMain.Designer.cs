﻿namespace PandaStack_Module_Generator
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
            this.btnConfig_MvDown = new System.Windows.Forms.Button();
            this.btnConfig_MvUp = new System.Windows.Forms.Button();
            this.btnControl_MvDown = new System.Windows.Forms.Button();
            this.btnControl_MvUp = new System.Windows.Forms.Button();
            this.btnLoadService = new System.Windows.Forms.Button();
            this.btnOpenLoc = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnControl_Edit = new System.Windows.Forms.Button();
            this.btnControl_Remove = new System.Windows.Forms.Button();
            this.btnControl_Add = new System.Windows.Forms.Button();
            this.btnConfig_Edit = new System.Windows.Forms.Button();
            this.lvConfigs = new System.Windows.Forms.ListView();
            this.btnConfig_Remove = new System.Windows.Forms.Button();
            this.btnConfig_Add = new System.Windows.Forms.Button();
            this.lblConfigs = new System.Windows.Forms.Label();
            this.lvControls = new System.Windows.Forms.ListView();
            this.lblControls = new System.Windows.Forms.Label();
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
            this.btnMvDwn.Location = new System.Drawing.Point(157, 554);
            this.btnMvDwn.Name = "btnMvDwn";
            this.btnMvDwn.Size = new System.Drawing.Size(30, 27);
            this.btnMvDwn.TabIndex = 4;
            this.btnMvDwn.UseVisualStyleBackColor = true;
            this.btnMvDwn.Click += new System.EventHandler(this.btnMvDwn_Click);
            // 
            // btnMvUp
            // 
            this.btnMvUp.Enabled = false;
            this.btnMvUp.Image = global::PandaStack_Module_Generator.Properties.Resources.arrow_090;
            this.btnMvUp.Location = new System.Drawing.Point(121, 554);
            this.btnMvUp.Name = "btnMvUp";
            this.btnMvUp.Size = new System.Drawing.Size(30, 27);
            this.btnMvUp.TabIndex = 3;
            this.btnMvUp.UseVisualStyleBackColor = true;
            this.btnMvUp.Click += new System.EventHandler(this.btnMvUp_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Image = global::PandaStack_Module_Generator.Properties.Resources.minus;
            this.btnRemove.Location = new System.Drawing.Point(85, 554);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(30, 27);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PandaStack_Module_Generator.Properties.Resources.plus;
            this.btnAdd.Location = new System.Drawing.Point(49, 554);
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
            this.lvModules.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvModules.HideSelection = false;
            this.lvModules.Location = new System.Drawing.Point(6, 19);
            this.lvModules.MultiSelect = false;
            this.lvModules.Name = "lvModules";
            this.lvModules.Size = new System.Drawing.Size(232, 529);
            this.lvModules.TabIndex = 1;
            this.lvModules.UseCompatibleStateImageBehavior = false;
            this.lvModules.View = System.Windows.Forms.View.Details;
            this.lvModules.SelectedIndexChanged += new System.EventHandler(this.lvModules_SelectedIndexChanged);
            // 
            // grpModuleOptions
            // 
            this.grpModuleOptions.Controls.Add(this.btnConfig_MvDown);
            this.grpModuleOptions.Controls.Add(this.btnConfig_MvUp);
            this.grpModuleOptions.Controls.Add(this.btnControl_MvDown);
            this.grpModuleOptions.Controls.Add(this.btnControl_MvUp);
            this.grpModuleOptions.Controls.Add(this.btnLoadService);
            this.grpModuleOptions.Controls.Add(this.btnOpenLoc);
            this.grpModuleOptions.Controls.Add(this.txtFilePath);
            this.grpModuleOptions.Controls.Add(this.lblFilePath);
            this.grpModuleOptions.Controls.Add(this.btnControl_Edit);
            this.grpModuleOptions.Controls.Add(this.btnControl_Remove);
            this.grpModuleOptions.Controls.Add(this.btnControl_Add);
            this.grpModuleOptions.Controls.Add(this.btnConfig_Edit);
            this.grpModuleOptions.Controls.Add(this.lvConfigs);
            this.grpModuleOptions.Controls.Add(this.btnConfig_Remove);
            this.grpModuleOptions.Controls.Add(this.btnConfig_Add);
            this.grpModuleOptions.Controls.Add(this.lblConfigs);
            this.grpModuleOptions.Controls.Add(this.lvControls);
            this.grpModuleOptions.Controls.Add(this.lblControls);
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
            // btnConfig_MvDown
            // 
            this.btnConfig_MvDown.Enabled = false;
            this.btnConfig_MvDown.Image = global::PandaStack_Module_Generator.Properties.Resources.arrow_270;
            this.btnConfig_MvDown.Location = new System.Drawing.Point(470, 457);
            this.btnConfig_MvDown.Name = "btnConfig_MvDown";
            this.btnConfig_MvDown.Size = new System.Drawing.Size(30, 27);
            this.btnConfig_MvDown.TabIndex = 28;
            this.btnConfig_MvDown.UseVisualStyleBackColor = true;
            this.btnConfig_MvDown.Click += new System.EventHandler(this.btnConfig_MvDown_Click);
            // 
            // btnConfig_MvUp
            // 
            this.btnConfig_MvUp.Enabled = false;
            this.btnConfig_MvUp.Image = global::PandaStack_Module_Generator.Properties.Resources.arrow_090;
            this.btnConfig_MvUp.Location = new System.Drawing.Point(470, 424);
            this.btnConfig_MvUp.Name = "btnConfig_MvUp";
            this.btnConfig_MvUp.Size = new System.Drawing.Size(30, 27);
            this.btnConfig_MvUp.TabIndex = 27;
            this.btnConfig_MvUp.UseVisualStyleBackColor = true;
            this.btnConfig_MvUp.Click += new System.EventHandler(this.btnConfig_MvUp_Click);
            // 
            // btnControl_MvDown
            // 
            this.btnControl_MvDown.Enabled = false;
            this.btnControl_MvDown.Image = global::PandaStack_Module_Generator.Properties.Resources.arrow_270;
            this.btnControl_MvDown.Location = new System.Drawing.Point(470, 256);
            this.btnControl_MvDown.Name = "btnControl_MvDown";
            this.btnControl_MvDown.Size = new System.Drawing.Size(30, 27);
            this.btnControl_MvDown.TabIndex = 26;
            this.btnControl_MvDown.UseVisualStyleBackColor = true;
            this.btnControl_MvDown.Click += new System.EventHandler(this.btnControl_MvDown_Click);
            // 
            // btnControl_MvUp
            // 
            this.btnControl_MvUp.Enabled = false;
            this.btnControl_MvUp.Image = global::PandaStack_Module_Generator.Properties.Resources.arrow_090;
            this.btnControl_MvUp.Location = new System.Drawing.Point(470, 223);
            this.btnControl_MvUp.Name = "btnControl_MvUp";
            this.btnControl_MvUp.Size = new System.Drawing.Size(30, 27);
            this.btnControl_MvUp.TabIndex = 25;
            this.btnControl_MvUp.UseVisualStyleBackColor = true;
            this.btnControl_MvUp.Click += new System.EventHandler(this.btnControl_MvUp_Click);
            // 
            // btnLoadService
            // 
            this.btnLoadService.Enabled = false;
            this.btnLoadService.Image = global::PandaStack_Module_Generator.Properties.Resources.server_connect;
            this.btnLoadService.Location = new System.Drawing.Point(195, 70);
            this.btnLoadService.Name = "btnLoadService";
            this.btnLoadService.Size = new System.Drawing.Size(30, 27);
            this.btnLoadService.TabIndex = 24;
            this.btnLoadService.UseVisualStyleBackColor = true;
            this.btnLoadService.Click += new System.EventHandler(this.btnLoadService_Click);
            // 
            // btnOpenLoc
            // 
            this.btnOpenLoc.Enabled = false;
            this.btnOpenLoc.Image = global::PandaStack_Module_Generator.Properties.Resources.folder_page;
            this.btnOpenLoc.Location = new System.Drawing.Point(470, 70);
            this.btnOpenLoc.Name = "btnOpenLoc";
            this.btnOpenLoc.Size = new System.Drawing.Size(30, 27);
            this.btnOpenLoc.TabIndex = 23;
            this.btnOpenLoc.UseVisualStyleBackColor = true;
            this.btnOpenLoc.Click += new System.EventHandler(this.btnOpenLoc_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(247, 74);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(217, 20);
            this.txtFilePath.TabIndex = 22;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(244, 58);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(90, 13);
            this.lblFilePath.TabIndex = 21;
            this.lblFilePath.Text = "Program Location";
            // 
            // btnControl_Edit
            // 
            this.btnControl_Edit.Enabled = false;
            this.btnControl_Edit.Image = global::PandaStack_Module_Generator.Properties.Resources.gear;
            this.btnControl_Edit.Location = new System.Drawing.Point(470, 190);
            this.btnControl_Edit.Name = "btnControl_Edit";
            this.btnControl_Edit.Size = new System.Drawing.Size(30, 27);
            this.btnControl_Edit.TabIndex = 20;
            this.btnControl_Edit.UseVisualStyleBackColor = true;
            this.btnControl_Edit.Click += new System.EventHandler(this.btnControl_Edit_Click);
            // 
            // btnControl_Remove
            // 
            this.btnControl_Remove.Enabled = false;
            this.btnControl_Remove.Image = global::PandaStack_Module_Generator.Properties.Resources.minus;
            this.btnControl_Remove.Location = new System.Drawing.Point(470, 157);
            this.btnControl_Remove.Name = "btnControl_Remove";
            this.btnControl_Remove.Size = new System.Drawing.Size(30, 27);
            this.btnControl_Remove.TabIndex = 19;
            this.btnControl_Remove.UseVisualStyleBackColor = true;
            this.btnControl_Remove.Click += new System.EventHandler(this.btnControl_Remove_Click);
            // 
            // btnControl_Add
            // 
            this.btnControl_Add.Image = global::PandaStack_Module_Generator.Properties.Resources.plus;
            this.btnControl_Add.Location = new System.Drawing.Point(470, 124);
            this.btnControl_Add.Name = "btnControl_Add";
            this.btnControl_Add.Size = new System.Drawing.Size(30, 27);
            this.btnControl_Add.TabIndex = 18;
            this.btnControl_Add.UseVisualStyleBackColor = true;
            this.btnControl_Add.Click += new System.EventHandler(this.btnControl_Add_Click);
            // 
            // btnConfig_Edit
            // 
            this.btnConfig_Edit.Enabled = false;
            this.btnConfig_Edit.Image = global::PandaStack_Module_Generator.Properties.Resources.gear;
            this.btnConfig_Edit.Location = new System.Drawing.Point(470, 391);
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
            this.lvConfigs.HideSelection = false;
            this.lvConfigs.Location = new System.Drawing.Point(9, 313);
            this.lvConfigs.MultiSelect = false;
            this.lvConfigs.Name = "lvConfigs";
            this.lvConfigs.Size = new System.Drawing.Size(455, 181);
            this.lvConfigs.TabIndex = 14;
            this.lvConfigs.UseCompatibleStateImageBehavior = false;
            this.lvConfigs.View = System.Windows.Forms.View.Details;
            this.lvConfigs.SelectedIndexChanged += new System.EventHandler(this.lvConfigs_SelectedIndexChanged);
            // 
            // btnConfig_Remove
            // 
            this.btnConfig_Remove.Enabled = false;
            this.btnConfig_Remove.Image = global::PandaStack_Module_Generator.Properties.Resources.minus;
            this.btnConfig_Remove.Location = new System.Drawing.Point(470, 358);
            this.btnConfig_Remove.Name = "btnConfig_Remove";
            this.btnConfig_Remove.Size = new System.Drawing.Size(30, 27);
            this.btnConfig_Remove.TabIndex = 13;
            this.btnConfig_Remove.UseVisualStyleBackColor = true;
            this.btnConfig_Remove.Click += new System.EventHandler(this.btnConfig_Remove_Click);
            // 
            // btnConfig_Add
            // 
            this.btnConfig_Add.Image = global::PandaStack_Module_Generator.Properties.Resources.plus;
            this.btnConfig_Add.Location = new System.Drawing.Point(470, 325);
            this.btnConfig_Add.Name = "btnConfig_Add";
            this.btnConfig_Add.Size = new System.Drawing.Size(30, 27);
            this.btnConfig_Add.TabIndex = 12;
            this.btnConfig_Add.UseVisualStyleBackColor = true;
            this.btnConfig_Add.Click += new System.EventHandler(this.btnConfig_Add_Click);
            // 
            // lblConfigs
            // 
            this.lblConfigs.AutoSize = true;
            this.lblConfigs.Location = new System.Drawing.Point(9, 297);
            this.lblConfigs.Name = "lblConfigs";
            this.lblConfigs.Size = new System.Drawing.Size(74, 13);
            this.lblConfigs.TabIndex = 10;
            this.lblConfigs.Text = "Configurations";
            // 
            // lvControls
            // 
            this.lvControls.FullRowSelect = true;
            this.lvControls.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvControls.HideSelection = false;
            this.lvControls.Location = new System.Drawing.Point(9, 113);
            this.lvControls.MultiSelect = false;
            this.lvControls.Name = "lvControls";
            this.lvControls.Size = new System.Drawing.Size(455, 181);
            this.lvControls.TabIndex = 9;
            this.lvControls.UseCompatibleStateImageBehavior = false;
            this.lvControls.View = System.Windows.Forms.View.Details;
            this.lvControls.SelectedIndexChanged += new System.EventHandler(this.lvControls_SelectedIndexChanged);
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.Location = new System.Drawing.Point(9, 97);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(45, 13);
            this.lblControls.TabIndex = 8;
            this.lblControls.Text = "Controls";
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
            this.txtServiceName.Enabled = false;
            this.txtServiceName.Location = new System.Drawing.Point(9, 74);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(180, 20);
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
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
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
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Button btnConfig_Edit;
        private System.Windows.Forms.Button btnControl_Edit;
        private System.Windows.Forms.Button btnControl_Remove;
        private System.Windows.Forms.Button btnControl_Add;
        private System.Windows.Forms.ListView lvControls;
        private System.Windows.Forms.Button btnImportConfig;
        private System.Windows.Forms.Button btnLoadConfig;
        private System.Windows.Forms.Button btnOpenLoc;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnLoadService;
        private System.Windows.Forms.Button btnConfig_MvDown;
        private System.Windows.Forms.Button btnConfig_MvUp;
        private System.Windows.Forms.Button btnControl_MvDown;
        private System.Windows.Forms.Button btnControl_MvUp;
    }
}

