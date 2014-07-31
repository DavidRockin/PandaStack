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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMvDwn = new System.Windows.Forms.Button();
            this.btnMvUp = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvModules = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConfig_Edit = new System.Windows.Forms.Button();
            this.lvConfigs = new System.Windows.Forms.ListView();
            this.btnConfig_Remove = new System.Windows.Forms.Button();
            this.btnConfig_Add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lvAdmins = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMvDwn);
            this.groupBox1.Controls.Add(this.btnMvUp);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lvModules);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 587);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loaded Module";
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
            this.lvModules.View = System.Windows.Forms.View.List;
            this.lvModules.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvModules_ItemSelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConfig_Edit);
            this.groupBox2.Controls.Add(this.lvConfigs);
            this.groupBox2.Controls.Add(this.btnConfig_Remove);
            this.groupBox2.Controls.Add(this.btnConfig_Add);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lvAdmins);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnDiscard);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtServiceName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbType);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(262, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 531);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Module Options";
            // 
            // btnConfig_Edit
            // 
            this.btnConfig_Edit.Enabled = false;
            this.btnConfig_Edit.Image = global::PandaStack_Module_Generator.Properties.Resources.gear;
            this.btnConfig_Edit.Location = new System.Drawing.Point(470, 331);
            this.btnConfig_Edit.Name = "btnConfig_Edit";
            this.btnConfig_Edit.Size = new System.Drawing.Size(30, 27);
            this.btnConfig_Edit.TabIndex = 17;
            this.btnConfig_Edit.UseVisualStyleBackColor = true;
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
            this.btnConfig_Remove.Location = new System.Drawing.Point(470, 298);
            this.btnConfig_Remove.Name = "btnConfig_Remove";
            this.btnConfig_Remove.Size = new System.Drawing.Size(30, 27);
            this.btnConfig_Remove.TabIndex = 13;
            this.btnConfig_Remove.UseVisualStyleBackColor = true;
            this.btnConfig_Remove.Click += new System.EventHandler(this.btnConfig_Remove_Click);
            // 
            // btnConfig_Add
            // 
            this.btnConfig_Add.Image = global::PandaStack_Module_Generator.Properties.Resources.plus;
            this.btnConfig_Add.Location = new System.Drawing.Point(470, 265);
            this.btnConfig_Add.Name = "btnConfig_Add";
            this.btnConfig_Add.Size = new System.Drawing.Size(30, 27);
            this.btnConfig_Add.TabIndex = 12;
            this.btnConfig_Add.UseVisualStyleBackColor = true;
            this.btnConfig_Add.Click += new System.EventHandler(this.btnConfig_Add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Configurations";
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Administrations";
            // 
            // btnDiscard
            // 
            this.btnDiscard.Image = global::PandaStack_Module_Generator.Properties.Resources.cross;
            this.btnDiscard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscard.Location = new System.Drawing.Point(122, 497);
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
            this.btnSave.Location = new System.Drawing.Point(6, 497);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Service Name";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Module Type";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(325, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(262, 549);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 611);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PandaStack Module Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvModules;
        private System.Windows.Forms.Button btnMvDwn;
        private System.Windows.Forms.Button btnMvUp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.ListView lvConfigs;
        private System.Windows.Forms.Button btnConfig_Remove;
        private System.Windows.Forms.Button btnConfig_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvAdmins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfig_Edit;
    }
}

