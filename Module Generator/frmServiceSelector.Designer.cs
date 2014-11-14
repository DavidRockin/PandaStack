namespace DavidRockin.PandaStack.ModuleGenerator
{
    partial class frmServiceSelector
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
            this.tblServiceSelctor = new System.Windows.Forms.TableLayoutPanel();
            this.lvwServices = new System.Windows.Forms.ListView();
            this.lvwServiceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwServiceStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tblActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblServiceSelctor.SuspendLayout();
            this.tblActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblServiceSelctor
            // 
            this.tblServiceSelctor.ColumnCount = 1;
            this.tblServiceSelctor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblServiceSelctor.Controls.Add(this.lvwServices, 0, 0);
            this.tblServiceSelctor.Controls.Add(this.tblActions, 0, 1);
            this.tblServiceSelctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblServiceSelctor.Location = new System.Drawing.Point(0, 0);
            this.tblServiceSelctor.Name = "tblServiceSelctor";
            this.tblServiceSelctor.RowCount = 2;
            this.tblServiceSelctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblServiceSelctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tblServiceSelctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblServiceSelctor.Size = new System.Drawing.Size(566, 480);
            this.tblServiceSelctor.TabIndex = 1;
            // 
            // lvwServices
            // 
            this.lvwServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwServiceName,
            this.lvwService,
            this.lvwServiceStatus});
            this.lvwServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwServices.FullRowSelect = true;
            this.lvwServices.GridLines = true;
            this.lvwServices.HideSelection = false;
            this.lvwServices.Location = new System.Drawing.Point(3, 3);
            this.lvwServices.MultiSelect = false;
            this.lvwServices.Name = "lvwServices";
            this.lvwServices.Size = new System.Drawing.Size(560, 435);
            this.lvwServices.TabIndex = 0;
            this.lvwServices.UseCompatibleStateImageBehavior = false;
            this.lvwServices.View = System.Windows.Forms.View.Details;
            this.lvwServices.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwServices_ColumnClick);
            this.lvwServices.SelectedIndexChanged += new System.EventHandler(this.lvwServices_SelectedIndexChanged);
            this.lvwServices.DoubleClick += new System.EventHandler(this.lvwServices_DoubleClick);
            // 
            // lvwServiceName
            // 
            this.lvwServiceName.Text = "Service Name";
            this.lvwServiceName.Width = 175;
            // 
            // lvwService
            // 
            this.lvwService.Text = "Service";
            this.lvwService.Width = 175;
            // 
            // lvwServiceStatus
            // 
            this.lvwServiceStatus.Text = "Service Status";
            this.lvwServiceStatus.Width = 125;
            // 
            // tblActions
            // 
            this.tblActions.ColumnCount = 3;
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblActions.Controls.Add(this.btnSelect, 0, 0);
            this.tblActions.Controls.Add(this.btnCancel, 1, 0);
            this.tblActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblActions.Location = new System.Drawing.Point(3, 444);
            this.tblActions.Name = "tblActions";
            this.tblActions.RowCount = 1;
            this.tblActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblActions.Size = new System.Drawing.Size(560, 33);
            this.tblActions.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.tick;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.Location = new System.Drawing.Point(3, 3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(119, 27);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Use Service";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::DavidRockin.PandaStack.ModuleGenerator.Properties.Resources.cross;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(128, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 27);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmServiceSelector
            // 
            this.AcceptButton = this.btnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(566, 480);
            this.Controls.Add(this.tblServiceSelctor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmServiceSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Selector";
            this.Load += new System.EventHandler(this.frmServiceSelector_Load);
            this.tblServiceSelctor.ResumeLayout(false);
            this.tblActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblServiceSelctor;
        private System.Windows.Forms.ListView lvwServices;
        private System.Windows.Forms.TableLayoutPanel tblActions;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader lvwServiceName;
        private System.Windows.Forms.ColumnHeader lvwService;
        private System.Windows.Forms.ColumnHeader lvwServiceStatus;
    }
}