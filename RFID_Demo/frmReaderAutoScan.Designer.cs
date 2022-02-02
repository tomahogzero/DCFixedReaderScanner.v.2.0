namespace DCRFIDReader
{
    partial class frmReaderAutoScan
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReaderAutoScan));
            this.gcDevice = new DevExpress.XtraGrid.GridControl();
            this.gvDevice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colServerIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repBtnOpen = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBtnOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDevice
            // 
            this.gcDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDevice.Location = new System.Drawing.Point(3, 36);
            this.gcDevice.MainView = this.gvDevice;
            this.gcDevice.Name = "gcDevice";
            this.gcDevice.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repBtnOpen});
            this.gcDevice.Size = new System.Drawing.Size(467, 371);
            this.gcDevice.TabIndex = 3;
            this.gcDevice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDevice});
            // 
            // gvDevice
            // 
            this.gvDevice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colServerIP,
            this.colPort,
            this.gridColumn1});
            this.gvDevice.GridControl = this.gcDevice;
            this.gvDevice.Name = "gvDevice";
            this.gvDevice.OptionsView.ColumnAutoWidth = false;
            this.gvDevice.OptionsView.ShowGroupPanel = false;
            this.gvDevice.OptionsView.ShowViewCaption = true;
            this.gvDevice.ViewCaption = "Reader Device";
            // 
            // colServerIP
            // 
            this.colServerIP.Caption = "IP Address";
            this.colServerIP.FieldName = "IPAddress";
            this.colServerIP.Name = "colServerIP";
            this.colServerIP.OptionsColumn.AllowEdit = false;
            this.colServerIP.OptionsColumn.ReadOnly = true;
            this.colServerIP.Visible = true;
            this.colServerIP.VisibleIndex = 0;
            this.colServerIP.Width = 110;
            // 
            // colPort
            // 
            this.colPort.Caption = "Port";
            this.colPort.FieldName = "Port";
            this.colPort.Name = "colPort";
            this.colPort.OptionsColumn.AllowEdit = false;
            this.colPort.Visible = true;
            this.colPort.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Open";
            this.gridColumn1.ColumnEdit = this.repBtnOpen;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // repBtnOpen
            // 
            this.repBtnOpen.AutoHeight = false;
            this.repBtnOpen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Open", -1, true, true, false, editorButtonImageOptions1)});
            this.repBtnOpen.Name = "repBtnOpen";
            this.repBtnOpen.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repBtnOpen.Click += new System.EventHandler(this.repBtnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 27);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmReaderAutoScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 410);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gcDevice);
            this.Name = "frmReaderAutoScan";
            this.Text = "Reader Auto Scan";
            this.Load += new System.EventHandler(this.frmReaderAutoScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBtnOpen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDevice;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDevice;
        private DevExpress.XtraGrid.Columns.GridColumn colServerIP;
        private DevExpress.XtraGrid.Columns.GridColumn colPort;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repBtnOpen;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
    }
}