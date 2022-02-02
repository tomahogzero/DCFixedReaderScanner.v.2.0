namespace DCRFIDReader
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnReaderAutoScan = new DevExpress.XtraEditors.SimpleButton();
            this.btnSettingDeviceToGate = new DevExpress.XtraEditors.SimpleButton();
            this.btnReaderDevice = new DevExpress.XtraEditors.SimpleButton();
            this.btnGate = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(56, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(277, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReaderAutoScan
            // 
            this.btnReaderAutoScan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReaderAutoScan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReaderAutoScan.ImageOptions.Image")));
            this.btnReaderAutoScan.Location = new System.Drawing.Point(56, 212);
            this.btnReaderAutoScan.Name = "btnReaderAutoScan";
            this.btnReaderAutoScan.Size = new System.Drawing.Size(277, 45);
            this.btnReaderAutoScan.TabIndex = 4;
            this.btnReaderAutoScan.Text = "Reader Auto Scan";
            this.btnReaderAutoScan.Click += new System.EventHandler(this.btnReaderAutoScan_Click);
            // 
            // btnSettingDeviceToGate
            // 
            this.btnSettingDeviceToGate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSettingDeviceToGate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSettingDeviceToGate.ImageOptions.Image")));
            this.btnSettingDeviceToGate.Location = new System.Drawing.Point(56, 161);
            this.btnSettingDeviceToGate.Name = "btnSettingDeviceToGate";
            this.btnSettingDeviceToGate.Size = new System.Drawing.Size(277, 45);
            this.btnSettingDeviceToGate.TabIndex = 4;
            this.btnSettingDeviceToGate.Text = "Setting Reader Device to Gate";
            this.btnSettingDeviceToGate.Click += new System.EventHandler(this.btnSettingDeviceToGate_Click);
            // 
            // btnReaderDevice
            // 
            this.btnReaderDevice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReaderDevice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReaderDevice.ImageOptions.Image")));
            this.btnReaderDevice.Location = new System.Drawing.Point(56, 110);
            this.btnReaderDevice.Name = "btnReaderDevice";
            this.btnReaderDevice.Size = new System.Drawing.Size(277, 45);
            this.btnReaderDevice.TabIndex = 4;
            this.btnReaderDevice.Text = "Reader Device";
            this.btnReaderDevice.Click += new System.EventHandler(this.btnReaderDevice_Click);
            // 
            // btnGate
            // 
            this.btnGate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGate.ImageOptions.Image")));
            this.btnGate.Location = new System.Drawing.Point(56, 59);
            this.btnGate.Name = "btnGate";
            this.btnGate.Size = new System.Drawing.Size(277, 45);
            this.btnGate.TabIndex = 4;
            this.btnGate.Text = "Gate";
            this.btnGate.Click += new System.EventHandler(this.btnGate_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShow,
            this.mnuExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // mnuShow
            // 
            this.mnuShow.Name = "mnuShow";
            this.mnuShow.Size = new System.Drawing.Size(103, 22);
            this.mnuShow.Text = "Show";
            this.mnuShow.Click += new System.EventHandler(this.mnuShow_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(103, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RFID DC Setting";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 395);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReaderAutoScan);
            this.Controls.Add(this.btnSettingDeviceToGate);
            this.Controls.Add(this.btnReaderDevice);
            this.Controls.Add(this.btnGate);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFID DC Receive";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Move += new System.EventHandler(this.frmMenu_Move);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.SimpleButton btnGate;
        internal DevExpress.XtraEditors.SimpleButton btnReaderDevice;
        internal DevExpress.XtraEditors.SimpleButton btnSettingDeviceToGate;
        internal DevExpress.XtraEditors.SimpleButton btnReaderAutoScan;
        internal DevExpress.XtraEditors.SimpleButton btnExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuShow;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}