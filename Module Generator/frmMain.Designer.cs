namespace DavidRockin.PandaStack.ModuleGenerator
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
            this.grpModulesLoaded = new System.Windows.Forms.GroupBox();
            this.tblModuleActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnModuleMvDown = new System.Windows.Forms.Button();
            this.btnModuleMvUp = new System.Windows.Forms.Button();
            this.btnModuleDelete = new System.Windows.Forms.Button();
            this.btnModuleCreate = new System.Windows.Forms.Button();
            this.lvwModulesLoaded = new System.Windows.Forms.ListView();
            this.lvwModulesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpModuleOptions = new System.Windows.Forms.GroupBox();
            this.tblModuleControlsBtns = new System.Windows.Forms.TableLayoutPanel();
            this.btnControlMvDown = new System.Windows.Forms.Button();
            this.btnControlMvUp = new System.Windows.Forms.Button();
            this.btnControlEdit = new System.Windows.Forms.Button();
            this.btnControlDelete = new System.Windows.Forms.Button();
            this.btnControlCreate = new System.Windows.Forms.Button();
            this.tblModuleConfigBtns = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfigMvDown = new System.Windows.Forms.Button();
            this.btnConfigMvUp = new System.Windows.Forms.Button();
            this.btnConfigEdit = new System.Windows.Forms.Button();
            this.btnConfigDelete = new System.Windows.Forms.Button();
            this.btnConfigCreate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.lvwModuleControls = new System.Windows.Forms.ListView();
            this.lvwControlName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwControlType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwControlPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblModuleControls = new System.Windows.Forms.Label();
            this.lvwModuleConfigs = new System.Windows.Forms.ListView();
            this.lvwConfigName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwConfigType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwConfigPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblConfigs = new System.Windows.Forms.Label();
            this.btnModuleProgram = new System.Windows.Forms.Button();
            this.txtModuleProgram = new System.Windows.Forms.TextBox();
            this.lblModuleProgram = new System.Windows.Forms.Label();
            this.btnModuleService = new System.Windows.Forms.Button();
            this.txtModuleService = new System.Windows.Forms.TextBox();
            this.lblModuleService = new System.Windows.Forms.Label();
            this.cmbModuleType = new System.Windows.Forms.ComboBox();
            this.lblModuleType = new System.Windows.Forms.Label();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.tblActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnConsole = new System.Windows.Forms.Button();
            this.grpModulesLoaded.SuspendLayout();
            this.tblModuleActions.SuspendLayout();
            this.grpModuleOptions.SuspendLayout();
            this.tblModuleControlsBtns.SuspendLayout();
            this.tblModuleConfigBtns.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.tblActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModulesLoaded
            // 
            this.grpModulesLoaded.Controls.Add(this.tblModuleActions);
            this.grpModulesLoaded.Controls.Add(this.lvwModulesLoaded);
            this.grpModulesLoaded.Location = new System.Drawing.Point(12, 12);
            this.grpModulesLoaded.Name = "grpModulesLoaded";
            this.grpModulesLoaded.Size = new System.Drawing.Size(223, 548);
            this.grpModulesLoaded.TabIndex = 0;
            this.grpModulesLoaded.TabStop = false;
            this.grpModulesLoaded.Text = "Loaded Modules";
            // 
            // tblModuleActions
            // 
            this.tblModuleActions.ColumnCount = 6;
            this.tblModuleActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.88736F));
            this.tblModuleActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.55632F));
            this.tblModuleActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.55632F));
            this.tblModuleActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.55632F));
            this.tblModuleActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.55632F));
            this.tblModuleActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.88736F));
            this.tblModuleActions.Controls.Add(this.btnModuleMvDown, 4, 0);
            this.tblModuleActions.Controls.Add(this.btnModuleMvUp, 3, 0);
            this.tblModuleActions.Controls.Add(this.btnModuleDelete, 2, 0);
            this.tblModuleActions.Controls.Add(this.btnModuleCreate, 1, 0);
            this.tblModuleActions.Location = new System.Drawing.Point(6, 504);
            this.tblModuleActions.Name = "tblModuleActions";
            this.tblModuleActions.RowCount = 1;
            this.tblModuleActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblModuleActions.Size = new System.Drawing.Size(211, 39);
            this.tblModuleActions.TabIndex = 0;
            // 
            // btnModuleMvDown
            // 
            this.btnModuleMvDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModuleMvDown.Enabled = false;
            this.btnModuleMvDown.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.arrow_270;
            this.btnModuleMvDown.Location = new System.Drawing.Point(147, 3);
            this.btnModuleMvDown.Name = "btnModuleMvDown";
            this.btnModuleMvDown.Size = new System.Drawing.Size(33, 33);
            this.btnModuleMvDown.TabIndex = 4;
            this.btnModuleMvDown.UseVisualStyleBackColor = true;
            this.btnModuleMvDown.Click += new System.EventHandler(this.btnModuleMvDown_Click);
            // 
            // btnModuleMvUp
            // 
            this.btnModuleMvUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModuleMvUp.Enabled = false;
            this.btnModuleMvUp.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.arrow_090;
            this.btnModuleMvUp.Location = new System.Drawing.Point(108, 3);
            this.btnModuleMvUp.Name = "btnModuleMvUp";
            this.btnModuleMvUp.Size = new System.Drawing.Size(33, 33);
            this.btnModuleMvUp.TabIndex = 3;
            this.btnModuleMvUp.UseVisualStyleBackColor = true;
            this.btnModuleMvUp.Click += new System.EventHandler(this.btnModuleMvUp_Click);
            // 
            // btnModuleDelete
            // 
            this.btnModuleDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModuleDelete.Enabled = false;
            this.btnModuleDelete.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.minus;
            this.btnModuleDelete.Location = new System.Drawing.Point(69, 3);
            this.btnModuleDelete.Name = "btnModuleDelete";
            this.btnModuleDelete.Size = new System.Drawing.Size(33, 33);
            this.btnModuleDelete.TabIndex = 2;
            this.btnModuleDelete.UseVisualStyleBackColor = true;
            this.btnModuleDelete.Click += new System.EventHandler(this.btnModuleDelete_Click);
            // 
            // btnModuleCreate
            // 
            this.btnModuleCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModuleCreate.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.plus;
            this.btnModuleCreate.Location = new System.Drawing.Point(30, 3);
            this.btnModuleCreate.Name = "btnModuleCreate";
            this.btnModuleCreate.Size = new System.Drawing.Size(33, 33);
            this.btnModuleCreate.TabIndex = 0;
            this.btnModuleCreate.UseVisualStyleBackColor = true;
            this.btnModuleCreate.Click += new System.EventHandler(this.btnModuleCreate_Click);
            // 
            // lvwModulesLoaded
            // 
            this.lvwModulesLoaded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwModulesName});
            this.lvwModulesLoaded.FullRowSelect = true;
            this.lvwModulesLoaded.GridLines = true;
            this.lvwModulesLoaded.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvwModulesLoaded.HideSelection = false;
            this.lvwModulesLoaded.Location = new System.Drawing.Point(6, 19);
            this.lvwModulesLoaded.MultiSelect = false;
            this.lvwModulesLoaded.Name = "lvwModulesLoaded";
            this.lvwModulesLoaded.Size = new System.Drawing.Size(211, 479);
            this.lvwModulesLoaded.TabIndex = 0;
            this.lvwModulesLoaded.UseCompatibleStateImageBehavior = false;
            this.lvwModulesLoaded.View = System.Windows.Forms.View.Details;
            this.lvwModulesLoaded.SelectedIndexChanged += new System.EventHandler(this.lvwModulesLoaded_SelectedIndexChanged);
            // 
            // lvwModulesName
            // 
            this.lvwModulesName.Text = "Module Name";
            this.lvwModulesName.Width = 180;
            // 
            // grpModuleOptions
            // 
            this.grpModuleOptions.Controls.Add(this.tblModuleControlsBtns);
            this.grpModuleOptions.Controls.Add(this.tblModuleConfigBtns);
            this.grpModuleOptions.Controls.Add(this.btnSave);
            this.grpModuleOptions.Controls.Add(this.btnDiscard);
            this.grpModuleOptions.Controls.Add(this.lvwModuleControls);
            this.grpModuleOptions.Controls.Add(this.lblModuleControls);
            this.grpModuleOptions.Controls.Add(this.lvwModuleConfigs);
            this.grpModuleOptions.Controls.Add(this.lblConfigs);
            this.grpModuleOptions.Controls.Add(this.btnModuleProgram);
            this.grpModuleOptions.Controls.Add(this.txtModuleProgram);
            this.grpModuleOptions.Controls.Add(this.lblModuleProgram);
            this.grpModuleOptions.Controls.Add(this.btnModuleService);
            this.grpModuleOptions.Controls.Add(this.txtModuleService);
            this.grpModuleOptions.Controls.Add(this.lblModuleService);
            this.grpModuleOptions.Controls.Add(this.cmbModuleType);
            this.grpModuleOptions.Controls.Add(this.lblModuleType);
            this.grpModuleOptions.Controls.Add(this.txtModuleName);
            this.grpModuleOptions.Controls.Add(this.lblModuleName);
            this.grpModuleOptions.Enabled = false;
            this.grpModuleOptions.Location = new System.Drawing.Point(241, 12);
            this.grpModuleOptions.Name = "grpModuleOptions";
            this.grpModuleOptions.Size = new System.Drawing.Size(541, 486);
            this.grpModuleOptions.TabIndex = 1;
            this.grpModuleOptions.TabStop = false;
            this.grpModuleOptions.Text = "Module Options";
            // 
            // tblModuleControlsBtns
            // 
            this.tblModuleControlsBtns.ColumnCount = 1;
            this.tblModuleControlsBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblModuleControlsBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblModuleControlsBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblModuleControlsBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblModuleControlsBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblModuleControlsBtns.Controls.Add(this.btnControlMvDown, 0, 4);
            this.tblModuleControlsBtns.Controls.Add(this.btnControlMvUp, 0, 3);
            this.tblModuleControlsBtns.Controls.Add(this.btnControlEdit, 0, 2);
            this.tblModuleControlsBtns.Controls.Add(this.btnControlDelete, 0, 1);
            this.tblModuleControlsBtns.Controls.Add(this.btnControlCreate, 0, 0);
            this.tblModuleControlsBtns.Location = new System.Drawing.Point(497, 287);
            this.tblModuleControlsBtns.Name = "tblModuleControlsBtns";
            this.tblModuleControlsBtns.RowCount = 5;
            this.tblModuleControlsBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblModuleControlsBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblModuleControlsBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblModuleControlsBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblModuleControlsBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblModuleControlsBtns.Size = new System.Drawing.Size(38, 155);
            this.tblModuleControlsBtns.TabIndex = 17;
            // 
            // btnControlMvDown
            // 
            this.btnControlMvDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnControlMvDown.Enabled = false;
            this.btnControlMvDown.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.arrow_270;
            this.btnControlMvDown.Location = new System.Drawing.Point(3, 127);
            this.btnControlMvDown.Name = "btnControlMvDown";
            this.btnControlMvDown.Size = new System.Drawing.Size(32, 25);
            this.btnControlMvDown.TabIndex = 4;
            this.btnControlMvDown.UseVisualStyleBackColor = true;
            this.btnControlMvDown.Click += new System.EventHandler(this.btnControlMvDown_Click);
            // 
            // btnControlMvUp
            // 
            this.btnControlMvUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnControlMvUp.Enabled = false;
            this.btnControlMvUp.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.arrow_090;
            this.btnControlMvUp.Location = new System.Drawing.Point(3, 96);
            this.btnControlMvUp.Name = "btnControlMvUp";
            this.btnControlMvUp.Size = new System.Drawing.Size(32, 25);
            this.btnControlMvUp.TabIndex = 3;
            this.btnControlMvUp.UseVisualStyleBackColor = true;
            this.btnControlMvUp.Click += new System.EventHandler(this.btnControlMvUp_Click);
            // 
            // btnControlEdit
            // 
            this.btnControlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnControlEdit.Enabled = false;
            this.btnControlEdit.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.gear;
            this.btnControlEdit.Location = new System.Drawing.Point(3, 65);
            this.btnControlEdit.Name = "btnControlEdit";
            this.btnControlEdit.Size = new System.Drawing.Size(32, 25);
            this.btnControlEdit.TabIndex = 2;
            this.btnControlEdit.UseVisualStyleBackColor = true;
            this.btnControlEdit.Click += new System.EventHandler(this.btnControlEdit_Click);
            // 
            // btnControlDelete
            // 
            this.btnControlDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnControlDelete.Enabled = false;
            this.btnControlDelete.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.minus;
            this.btnControlDelete.Location = new System.Drawing.Point(3, 34);
            this.btnControlDelete.Name = "btnControlDelete";
            this.btnControlDelete.Size = new System.Drawing.Size(32, 25);
            this.btnControlDelete.TabIndex = 1;
            this.btnControlDelete.UseVisualStyleBackColor = true;
            this.btnControlDelete.Click += new System.EventHandler(this.btnControlDelete_Click);
            // 
            // btnControlCreate
            // 
            this.btnControlCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnControlCreate.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.plus;
            this.btnControlCreate.Location = new System.Drawing.Point(3, 3);
            this.btnControlCreate.Name = "btnControlCreate";
            this.btnControlCreate.Size = new System.Drawing.Size(32, 25);
            this.btnControlCreate.TabIndex = 0;
            this.btnControlCreate.UseVisualStyleBackColor = true;
            this.btnControlCreate.Click += new System.EventHandler(this.btnControlCreate_Click);
            // 
            // tblModuleConfigBtns
            // 
            this.tblModuleConfigBtns.ColumnCount = 1;
            this.tblModuleConfigBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblModuleConfigBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblModuleConfigBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblModuleConfigBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblModuleConfigBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblModuleConfigBtns.Controls.Add(this.btnConfigMvDown, 0, 4);
            this.tblModuleConfigBtns.Controls.Add(this.btnConfigMvUp, 0, 3);
            this.tblModuleConfigBtns.Controls.Add(this.btnConfigEdit, 0, 2);
            this.tblModuleConfigBtns.Controls.Add(this.btnConfigDelete, 0, 1);
            this.tblModuleConfigBtns.Controls.Add(this.btnConfigCreate, 0, 0);
            this.tblModuleConfigBtns.Location = new System.Drawing.Point(497, 113);
            this.tblModuleConfigBtns.Name = "tblModuleConfigBtns";
            this.tblModuleConfigBtns.RowCount = 5;
            this.tblModuleConfigBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblModuleConfigBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblModuleConfigBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblModuleConfigBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblModuleConfigBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblModuleConfigBtns.Size = new System.Drawing.Size(38, 155);
            this.tblModuleConfigBtns.TabIndex = 16;
            // 
            // btnConfigMvDown
            // 
            this.btnConfigMvDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfigMvDown.Enabled = false;
            this.btnConfigMvDown.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.arrow_270;
            this.btnConfigMvDown.Location = new System.Drawing.Point(3, 127);
            this.btnConfigMvDown.Name = "btnConfigMvDown";
            this.btnConfigMvDown.Size = new System.Drawing.Size(32, 25);
            this.btnConfigMvDown.TabIndex = 4;
            this.btnConfigMvDown.UseVisualStyleBackColor = true;
            this.btnConfigMvDown.Click += new System.EventHandler(this.btnConfigMvDown_Click);
            // 
            // btnConfigMvUp
            // 
            this.btnConfigMvUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfigMvUp.Enabled = false;
            this.btnConfigMvUp.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.arrow_090;
            this.btnConfigMvUp.Location = new System.Drawing.Point(3, 96);
            this.btnConfigMvUp.Name = "btnConfigMvUp";
            this.btnConfigMvUp.Size = new System.Drawing.Size(32, 25);
            this.btnConfigMvUp.TabIndex = 3;
            this.btnConfigMvUp.UseVisualStyleBackColor = true;
            this.btnConfigMvUp.Click += new System.EventHandler(this.btnConfigMvUp_Click);
            // 
            // btnConfigEdit
            // 
            this.btnConfigEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfigEdit.Enabled = false;
            this.btnConfigEdit.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.gear;
            this.btnConfigEdit.Location = new System.Drawing.Point(3, 65);
            this.btnConfigEdit.Name = "btnConfigEdit";
            this.btnConfigEdit.Size = new System.Drawing.Size(32, 25);
            this.btnConfigEdit.TabIndex = 2;
            this.btnConfigEdit.UseVisualStyleBackColor = true;
            this.btnConfigEdit.Click += new System.EventHandler(this.btnConfigEdit_Click);
            // 
            // btnConfigDelete
            // 
            this.btnConfigDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfigDelete.Enabled = false;
            this.btnConfigDelete.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.minus;
            this.btnConfigDelete.Location = new System.Drawing.Point(3, 34);
            this.btnConfigDelete.Name = "btnConfigDelete";
            this.btnConfigDelete.Size = new System.Drawing.Size(32, 25);
            this.btnConfigDelete.TabIndex = 1;
            this.btnConfigDelete.UseVisualStyleBackColor = true;
            this.btnConfigDelete.Click += new System.EventHandler(this.btnConfigDelete_Click);
            // 
            // btnConfigCreate
            // 
            this.btnConfigCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfigCreate.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.plus;
            this.btnConfigCreate.Location = new System.Drawing.Point(3, 3);
            this.btnConfigCreate.Name = "btnConfigCreate";
            this.btnConfigCreate.Size = new System.Drawing.Size(32, 25);
            this.btnConfigCreate.TabIndex = 0;
            this.btnConfigCreate.UseVisualStyleBackColor = true;
            this.btnConfigCreate.Click += new System.EventHandler(this.btnConfigCreate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.disk;
            this.btnSave.Location = new System.Drawing.Point(9, 448);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 26);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.cross;
            this.btnDiscard.Location = new System.Drawing.Point(141, 448);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(126, 26);
            this.btnDiscard.TabIndex = 14;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // lvwModuleControls
            // 
            this.lvwModuleControls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwControlName,
            this.lvwControlType,
            this.lvwControlPath});
            this.lvwModuleControls.FullRowSelect = true;
            this.lvwModuleControls.HideSelection = false;
            this.lvwModuleControls.Location = new System.Drawing.Point(9, 287);
            this.lvwModuleControls.MultiSelect = false;
            this.lvwModuleControls.Name = "lvwModuleControls";
            this.lvwModuleControls.Size = new System.Drawing.Size(482, 155);
            this.lvwModuleControls.TabIndex = 13;
            this.lvwModuleControls.UseCompatibleStateImageBehavior = false;
            this.lvwModuleControls.View = System.Windows.Forms.View.Details;
            this.lvwModuleControls.SelectedIndexChanged += new System.EventHandler(this.lvwModuleControls_SelectedIndexChanged);
            // 
            // lvwControlName
            // 
            this.lvwControlName.Text = "Name";
            this.lvwControlName.Width = 130;
            // 
            // lvwControlType
            // 
            this.lvwControlType.Text = "Type";
            this.lvwControlType.Width = 85;
            // 
            // lvwControlPath
            // 
            this.lvwControlPath.Text = "Path";
            this.lvwControlPath.Width = 240;
            // 
            // lblModuleControls
            // 
            this.lblModuleControls.AutoSize = true;
            this.lblModuleControls.Location = new System.Drawing.Point(6, 271);
            this.lblModuleControls.Name = "lblModuleControls";
            this.lblModuleControls.Size = new System.Drawing.Size(45, 13);
            this.lblModuleControls.TabIndex = 12;
            this.lblModuleControls.Text = "Controls";
            // 
            // lvwModuleConfigs
            // 
            this.lvwModuleConfigs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwConfigName,
            this.lvwConfigType,
            this.lvwConfigPath});
            this.lvwModuleConfigs.FullRowSelect = true;
            this.lvwModuleConfigs.HideSelection = false;
            this.lvwModuleConfigs.Location = new System.Drawing.Point(9, 113);
            this.lvwModuleConfigs.MultiSelect = false;
            this.lvwModuleConfigs.Name = "lvwModuleConfigs";
            this.lvwModuleConfigs.Size = new System.Drawing.Size(482, 155);
            this.lvwModuleConfigs.TabIndex = 11;
            this.lvwModuleConfigs.UseCompatibleStateImageBehavior = false;
            this.lvwModuleConfigs.View = System.Windows.Forms.View.Details;
            this.lvwModuleConfigs.SelectedIndexChanged += new System.EventHandler(this.lvwModuleConfigs_SelectedIndexChanged);
            // 
            // lvwConfigName
            // 
            this.lvwConfigName.Text = "Name";
            this.lvwConfigName.Width = 130;
            // 
            // lvwConfigType
            // 
            this.lvwConfigType.Text = "Type";
            this.lvwConfigType.Width = 85;
            // 
            // lvwConfigPath
            // 
            this.lvwConfigPath.Text = "Path";
            this.lvwConfigPath.Width = 240;
            // 
            // lblConfigs
            // 
            this.lblConfigs.AutoSize = true;
            this.lblConfigs.Location = new System.Drawing.Point(6, 97);
            this.lblConfigs.Name = "lblConfigs";
            this.lblConfigs.Size = new System.Drawing.Size(74, 13);
            this.lblConfigs.TabIndex = 10;
            this.lblConfigs.Text = "Configurations";
            // 
            // btnModuleProgram
            // 
            this.btnModuleProgram.Enabled = false;
            this.btnModuleProgram.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.folder_page1;
            this.btnModuleProgram.Location = new System.Drawing.Point(503, 69);
            this.btnModuleProgram.Name = "btnModuleProgram";
            this.btnModuleProgram.Size = new System.Drawing.Size(32, 28);
            this.btnModuleProgram.TabIndex = 9;
            this.btnModuleProgram.UseVisualStyleBackColor = true;
            this.btnModuleProgram.Click += new System.EventHandler(this.btnModuleProgram_Click);
            // 
            // txtModuleProgram
            // 
            this.txtModuleProgram.Enabled = false;
            this.txtModuleProgram.Location = new System.Drawing.Point(229, 74);
            this.txtModuleProgram.Name = "txtModuleProgram";
            this.txtModuleProgram.Size = new System.Drawing.Size(268, 20);
            this.txtModuleProgram.TabIndex = 8;
            // 
            // lblModuleProgram
            // 
            this.lblModuleProgram.AutoSize = true;
            this.lblModuleProgram.Location = new System.Drawing.Point(229, 58);
            this.lblModuleProgram.Name = "lblModuleProgram";
            this.lblModuleProgram.Size = new System.Drawing.Size(90, 13);
            this.lblModuleProgram.TabIndex = 7;
            this.lblModuleProgram.Text = "Program Location";
            // 
            // btnModuleService
            // 
            this.btnModuleService.Enabled = false;
            this.btnModuleService.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.server_connect;
            this.btnModuleService.Location = new System.Drawing.Point(191, 69);
            this.btnModuleService.Name = "btnModuleService";
            this.btnModuleService.Size = new System.Drawing.Size(32, 28);
            this.btnModuleService.TabIndex = 6;
            this.btnModuleService.UseVisualStyleBackColor = true;
            this.btnModuleService.Click += new System.EventHandler(this.btnModuleService_Click);
            // 
            // txtModuleService
            // 
            this.txtModuleService.Enabled = false;
            this.txtModuleService.Location = new System.Drawing.Point(9, 74);
            this.txtModuleService.Name = "txtModuleService";
            this.txtModuleService.Size = new System.Drawing.Size(176, 20);
            this.txtModuleService.TabIndex = 5;
            // 
            // lblModuleService
            // 
            this.lblModuleService.AutoSize = true;
            this.lblModuleService.Location = new System.Drawing.Point(6, 58);
            this.lblModuleService.Name = "lblModuleService";
            this.lblModuleService.Size = new System.Drawing.Size(74, 13);
            this.lblModuleService.TabIndex = 4;
            this.lblModuleService.Text = "Service Name";
            // 
            // cmbModuleType
            // 
            this.cmbModuleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModuleType.FormattingEnabled = true;
            this.cmbModuleType.Location = new System.Drawing.Point(405, 35);
            this.cmbModuleType.Name = "cmbModuleType";
            this.cmbModuleType.Size = new System.Drawing.Size(130, 21);
            this.cmbModuleType.TabIndex = 3;
            this.cmbModuleType.SelectedIndexChanged += new System.EventHandler(this.cmbModuleType_SelectedIndexChanged);
            // 
            // lblModuleType
            // 
            this.lblModuleType.AutoSize = true;
            this.lblModuleType.Location = new System.Drawing.Point(402, 19);
            this.lblModuleType.Name = "lblModuleType";
            this.lblModuleType.Size = new System.Drawing.Size(69, 13);
            this.lblModuleType.TabIndex = 2;
            this.lblModuleType.Text = "Module Type";
            // 
            // txtModuleName
            // 
            this.txtModuleName.Location = new System.Drawing.Point(9, 35);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(390, 20);
            this.txtModuleName.TabIndex = 1;
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Location = new System.Drawing.Point(6, 19);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(73, 13);
            this.lblModuleName.TabIndex = 0;
            this.lblModuleName.Text = "Module Name";
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.tblActions);
            this.grpActions.Location = new System.Drawing.Point(241, 504);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(541, 56);
            this.grpActions.TabIndex = 2;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // tblActions
            // 
            this.tblActions.ColumnCount = 4;
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblActions.Controls.Add(this.btnImport, 0, 0);
            this.tblActions.Controls.Add(this.btnLoad, 0, 0);
            this.tblActions.Controls.Add(this.btnExport, 3, 0);
            this.tblActions.Controls.Add(this.btnConsole, 2, 0);
            this.tblActions.Location = new System.Drawing.Point(9, 15);
            this.tblActions.Name = "tblActions";
            this.tblActions.RowCount = 1;
            this.tblActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblActions.Size = new System.Drawing.Size(524, 31);
            this.tblActions.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImport.Enabled = false;
            this.btnImport.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.page_white_get;
            this.btnImport.Location = new System.Drawing.Point(134, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(125, 25);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import Config";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Visible = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.folder_page;
            this.btnLoad.Location = new System.Drawing.Point(3, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(125, 25);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Config";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.page_white_put;
            this.btnExport.Location = new System.Drawing.Point(396, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(125, 25);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export Config";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnConsole
            // 
            this.btnConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConsole.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.application_xp_terminal;
            this.btnConsole.Location = new System.Drawing.Point(265, 3);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(125, 25);
            this.btnConsole.TabIndex = 4;
            this.btnConsole.Text = "Show Console";
            this.btnConsole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsole.UseVisualStyleBackColor = true;
            this.btnConsole.Click += new System.EventHandler(this.btnConsole_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpModuleOptions);
            this.Controls.Add(this.grpModulesLoaded);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PandaStack Module Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpModulesLoaded.ResumeLayout(false);
            this.tblModuleActions.ResumeLayout(false);
            this.grpModuleOptions.ResumeLayout(false);
            this.grpModuleOptions.PerformLayout();
            this.tblModuleControlsBtns.ResumeLayout(false);
            this.tblModuleConfigBtns.ResumeLayout(false);
            this.grpActions.ResumeLayout(false);
            this.tblActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModulesLoaded;
        private System.Windows.Forms.ListView lvwModulesLoaded;
        private System.Windows.Forms.GroupBox grpModuleOptions;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.TableLayoutPanel tblActions;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TableLayoutPanel tblModuleActions;
        private System.Windows.Forms.Button btnModuleMvDown;
        private System.Windows.Forms.Button btnModuleMvUp;
        private System.Windows.Forms.Button btnModuleDelete;
        private System.Windows.Forms.Button btnModuleCreate;
        private System.Windows.Forms.ComboBox cmbModuleType;
        private System.Windows.Forms.Label lblModuleType;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Label lblModuleProgram;
        private System.Windows.Forms.Button btnModuleProgram;
        private System.Windows.Forms.TextBox txtModuleProgram;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.ListView lvwModuleControls;
        private System.Windows.Forms.Label lblModuleControls;
        private System.Windows.Forms.ListView lvwModuleConfigs;
        private System.Windows.Forms.Label lblConfigs;
        private System.Windows.Forms.TableLayoutPanel tblModuleConfigBtns;
        private System.Windows.Forms.Button btnConfigMvDown;
        private System.Windows.Forms.Button btnConfigMvUp;
        private System.Windows.Forms.Button btnConfigEdit;
        private System.Windows.Forms.Button btnConfigDelete;
        private System.Windows.Forms.Button btnConfigCreate;
        private System.Windows.Forms.TableLayoutPanel tblModuleControlsBtns;
        private System.Windows.Forms.Button btnControlMvDown;
        private System.Windows.Forms.Button btnControlMvUp;
        private System.Windows.Forms.Button btnControlEdit;
        private System.Windows.Forms.Button btnControlDelete;
        private System.Windows.Forms.Button btnControlCreate;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.ColumnHeader lvwModulesName;
        private System.Windows.Forms.ColumnHeader lvwControlName;
        private System.Windows.Forms.ColumnHeader lvwControlType;
        private System.Windows.Forms.ColumnHeader lvwControlPath;
        private System.Windows.Forms.ColumnHeader lvwConfigName;
        private System.Windows.Forms.ColumnHeader lvwConfigType;
        private System.Windows.Forms.ColumnHeader lvwConfigPath;
        private System.Windows.Forms.Button btnModuleService;
        private System.Windows.Forms.TextBox txtModuleService;
        private System.Windows.Forms.Label lblModuleService;
    }
}

