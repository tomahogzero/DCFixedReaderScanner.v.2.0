namespace DCRFIDReader
{
    partial class frmGate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGate));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtGateNumber = new DevExpress.XtraEditors.TextEdit();
            this.gcGate = new DevExpress.XtraGrid.GridControl();
            this.gvGate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colServerIP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtGateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(242, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 27);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(158, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(78, 27);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(90, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 27);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(12, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 27);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(15, 49);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(63, 13);
            this.LabelControl1.TabIndex = 7;
            this.LabelControl1.Text = "Gate Number";
            // 
            // txtGateNumber
            // 
            this.txtGateNumber.Location = new System.Drawing.Point(90, 46);
            this.txtGateNumber.Name = "txtGateNumber";
            this.txtGateNumber.Size = new System.Drawing.Size(214, 20);
            this.txtGateNumber.TabIndex = 0;
            // 
            // gcGate
            // 
            this.gcGate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcGate.Location = new System.Drawing.Point(12, 72);
            this.gcGate.MainView = this.gvGate;
            this.gcGate.Name = "gcGate";
            this.gcGate.Size = new System.Drawing.Size(421, 335);
            this.gcGate.TabIndex = 1;
            this.gcGate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGate});
            // 
            // gvGate
            // 
            this.gvGate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colServerIP});
            this.gvGate.GridControl = this.gcGate;
            this.gvGate.Name = "gvGate";
            this.gvGate.OptionsView.ColumnAutoWidth = false;
            this.gvGate.OptionsView.ShowGroupPanel = false;
            this.gvGate.OptionsView.ShowViewCaption = true;
            this.gvGate.ViewCaption = "Gate";
            this.gvGate.DoubleClick += new System.EventHandler(this.gvGate_DoubleClick);
            // 
            // colServerIP
            // 
            this.colServerIP.Caption = "Gate Number";
            this.colServerIP.FieldName = "GateNumber";
            this.colServerIP.Name = "colServerIP";
            this.colServerIP.OptionsColumn.AllowEdit = false;
            this.colServerIP.OptionsColumn.ReadOnly = true;
            this.colServerIP.Visible = true;
            this.colServerIP.VisibleIndex = 0;
            this.colServerIP.Width = 110;
            // 
            // frmGate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 419);
            this.Controls.Add(this.gcGate);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.txtGateNumber);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Name = "frmGate";
            this.Text = "Gate";
            this.Load += new System.EventHandler(this.frmGate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.SimpleButton btnRefresh;
        internal DevExpress.XtraEditors.SimpleButton btnDelete;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.TextEdit txtGateNumber;
        private DevExpress.XtraGrid.GridControl gcGate;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGate;
        private DevExpress.XtraGrid.Columns.GridColumn colServerIP;
    }
}