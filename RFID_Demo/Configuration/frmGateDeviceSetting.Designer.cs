namespace DCRFIDReader
{
    partial class frmGateDeviceSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGateDeviceSetting));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDevice = new DevExpress.XtraGrid.GridControl();
            this.gvDevice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGateNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServerIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAntenna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboGateNumber = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboAntenna = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboDevice = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAntenna.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDevice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(242, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(158, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(78, 27);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(90, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(12, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(26, 101);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(41, 13);
            this.LabelControl1.TabIndex = 7;
            this.LabelControl1.Text = "Antenna";
            // 
            // gcDevice
            // 
            this.gcDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDevice.Location = new System.Drawing.Point(12, 124);
            this.gcDevice.MainView = this.gvDevice;
            this.gcDevice.Name = "gcDevice";
            this.gcDevice.Size = new System.Drawing.Size(640, 283);
            this.gcDevice.TabIndex = 2;
            this.gcDevice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDevice});
            // 
            // gvDevice
            // 
            this.gvDevice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGateNumber,
            this.colServerIP,
            this.colAntenna});
            this.gvDevice.GridControl = this.gcDevice;
            this.gvDevice.Name = "gvDevice";
            this.gvDevice.OptionsView.ColumnAutoWidth = false;
            this.gvDevice.OptionsView.ShowGroupPanel = false;
            this.gvDevice.OptionsView.ShowViewCaption = true;
            this.gvDevice.ViewCaption = "Setting Reader to Gate";
            this.gvDevice.DoubleClick += new System.EventHandler(this.gvGate_DoubleClick);
            // 
            // colGateNumber
            // 
            this.colGateNumber.Caption = "Gate Number";
            this.colGateNumber.FieldName = "GateNumber";
            this.colGateNumber.Name = "colGateNumber";
            this.colGateNumber.OptionsColumn.AllowEdit = false;
            this.colGateNumber.Visible = true;
            this.colGateNumber.VisibleIndex = 0;
            // 
            // colServerIP
            // 
            this.colServerIP.Caption = "IP Address";
            this.colServerIP.FieldName = "IPAddress";
            this.colServerIP.Name = "colServerIP";
            this.colServerIP.OptionsColumn.AllowEdit = false;
            this.colServerIP.OptionsColumn.ReadOnly = true;
            this.colServerIP.Visible = true;
            this.colServerIP.VisibleIndex = 1;
            this.colServerIP.Width = 110;
            // 
            // colAntenna
            // 
            this.colAntenna.Caption = "Antenna";
            this.colAntenna.FieldName = "Antenna";
            this.colAntenna.Name = "colAntenna";
            this.colAntenna.OptionsColumn.AllowEdit = false;
            this.colAntenna.Visible = true;
            this.colAntenna.VisibleIndex = 2;
            this.colAntenna.Width = 63;
            // 
            // cboGateNumber
            // 
            this.cboGateNumber.Location = new System.Drawing.Point(101, 46);
            this.cboGateNumber.Name = "cboGateNumber";
            this.cboGateNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGateNumber.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GateNumber", "Gate Number")});
            this.cboGateNumber.Properties.NullText = "";
            this.cboGateNumber.Size = new System.Drawing.Size(203, 20);
            this.cboGateNumber.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Gate Number";
            // 
            // cboAntenna
            // 
            this.cboAntenna.Location = new System.Drawing.Point(101, 98);
            this.cboAntenna.Name = "cboAntenna";
            this.cboAntenna.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboAntenna.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboAntenna.Size = new System.Drawing.Size(100, 20);
            this.cboAntenna.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 75);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Device IP";
            // 
            // cboDevice
            // 
            this.cboDevice.Location = new System.Drawing.Point(101, 72);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDevice.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IPAddress", "Device IP Address")});
            this.cboDevice.Properties.NullText = "";
            this.cboDevice.Size = new System.Drawing.Size(203, 20);
            this.cboDevice.TabIndex = 8;
            // 
            // frmGateDeviceSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 419);
            this.Controls.Add(this.cboAntenna);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.cboGateNumber);
            this.Controls.Add(this.gcDevice);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Name = "frmGateDeviceSetting";
            this.Text = "Setting Reader Device to Gate";
            this.Load += new System.EventHandler(this.frmGate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAntenna.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDevice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.SimpleButton btnRefresh;
        internal DevExpress.XtraEditors.SimpleButton btnDelete;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        private DevExpress.XtraGrid.GridControl gcDevice;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDevice;
        private DevExpress.XtraGrid.Columns.GridColumn colServerIP;
        private DevExpress.XtraGrid.Columns.GridColumn colAntenna;
        private DevExpress.XtraGrid.Columns.GridColumn colGateNumber;
        private DevExpress.XtraEditors.LookUpEdit cboGateNumber;
        internal DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cboAntenna;
        internal DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit cboDevice;
    }
}