namespace PandaStack_Module_Generator
{
    partial class frmEditItem
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnOpenLoc = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 48);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(15, 64);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(181, 21);
            this.cmbType.TabIndex = 3;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 88);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(73, 13);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "Path Location";
            // 
            // btnOpenLoc
            // 
            this.btnOpenLoc.Image = global::PandaStack_Module_Generator.Properties.Resources.folder_page;
            this.btnOpenLoc.Location = new System.Drawing.Point(394, 101);
            this.btnOpenLoc.Name = "btnOpenLoc";
            this.btnOpenLoc.Size = new System.Drawing.Size(28, 25);
            this.btnOpenLoc.TabIndex = 5;
            this.btnOpenLoc.UseVisualStyleBackColor = true;
            this.btnOpenLoc.Click += new System.EventHandler(this.btnOpenLoc_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(15, 104);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(373, 20);
            this.txtPath.TabIndex = 6;
            // 
            // btnApply
            // 
            this.btnApply.Image = global::PandaStack_Module_Generator.Properties.Resources.tick;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.Location = new System.Drawing.Point(15, 130);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(104, 25);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::PandaStack_Module_Generator.Properties.Resources.cross;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(125, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 25);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 167);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnOpenLoc);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditItem";
            this.Load += new System.EventHandler(this.frmEditItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnOpenLoc;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
    }
}