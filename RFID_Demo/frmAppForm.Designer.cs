namespace DCRFIDReader
{
    partial class frmAppForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettingDeviceToGate = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capabilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpiLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.functionCallStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.connectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpiStateGB = new System.Windows.Forms.GroupBox();
            this.gpiNumberLabel = new System.Windows.Forms.Label();
            this.transmitPowerGB = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.dataContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tagDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readDataContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeDataContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockDataContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killDataContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockWriteDataContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockEraseDataContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.accessBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.clearReports_CB = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gcPO = new DevExpress.XtraGrid.GridControl();
            this.gvPO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOGateNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOBookingNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcoltime_count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repBtnPOCommit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gcBox = new DevExpress.XtraGrid.GridControl();
            this.gvBox = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDDB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repPic = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gcUPC = new DevExpress.XtraGrid.GridControl();
            this.gvUPC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gcTag = new DevExpress.XtraGrid.GridControl();
            this.gvTag = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lstSyncLog = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTotalEPC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.timer1_timecount = new System.Windows.Forms.Timer(this.components);
            this.btnStartAuto = new DevExpress.XtraEditors.SimpleButton();
            this.btnStopAuto = new DevExpress.XtraEditors.SimpleButton();
            this.btnStartRead = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.timer_getCommand = new System.Windows.Forms.Timer(this.components);
            this.btnScanCommandManual = new System.Windows.Forms.Button();
            this.btnResetRequest = new DevExpress.XtraEditors.SimpleButton();
            this.timer_reconnect = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer_clear_buffer = new System.Windows.Forms.Timer(this.components);
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.gpiStateGB.SuspendLayout();
            this.transmitPowerGB.SuspendLayout();
            this.dataContextMenuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBtnPOCommit)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPic)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1101, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Visible = false;
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGate,
            this.mnuDevice,
            this.mnuSettingDeviceToGate,
            this.connectionToolStripMenuItem,
            this.capabilitiesToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configToolStripMenuItem.Text = "Configuration";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // mnuGate
            // 
            this.mnuGate.Name = "mnuGate";
            this.mnuGate.Size = new System.Drawing.Size(194, 22);
            this.mnuGate.Text = "Gate";
            this.mnuGate.Click += new System.EventHandler(this.mnuGate_Click);
            // 
            // mnuDevice
            // 
            this.mnuDevice.Name = "mnuDevice";
            this.mnuDevice.Size = new System.Drawing.Size(194, 22);
            this.mnuDevice.Text = "Reader Device";
            this.mnuDevice.Click += new System.EventHandler(this.mnuDevice_Click);
            // 
            // mnuSettingDeviceToGate
            // 
            this.mnuSettingDeviceToGate.Name = "mnuSettingDeviceToGate";
            this.mnuSettingDeviceToGate.Size = new System.Drawing.Size(194, 22);
            this.mnuSettingDeviceToGate.Text = "Setting Reader  to Gate";
            this.mnuSettingDeviceToGate.Click += new System.EventHandler(this.mnuSettingDeviceToGate_Click);
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.connectionToolStripMenuItem.Text = "Connection...";
            this.connectionToolStripMenuItem.Visible = false;
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // capabilitiesToolStripMenuItem
            // 
            this.capabilitiesToolStripMenuItem.Name = "capabilitiesToolStripMenuItem";
            this.capabilitiesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.capabilitiesToolStripMenuItem.Text = "Capabilities...";
            this.capabilitiesToolStripMenuItem.Visible = false;
            this.capabilitiesToolStripMenuItem.Click += new System.EventHandler(this.capabilitiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // inventoryList
            // 
            this.inventoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9});
            this.inventoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryList.FullRowSelect = true;
            this.inventoryList.GridLines = true;
            this.inventoryList.HideSelection = false;
            this.inventoryList.Location = new System.Drawing.Point(3, 3);
            this.inventoryList.MultiSelect = false;
            this.inventoryList.Name = "inventoryList";
            this.inventoryList.Size = new System.Drawing.Size(1071, 407);
            this.inventoryList.TabIndex = 1;
            this.inventoryList.UseCompatibleStateImageBehavior = false;
            this.inventoryList.View = System.Windows.Forms.View.Details;
            this.inventoryList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inventoryList_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "EPC ID.";
            this.columnHeader1.Width = 202;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Antenna";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tag Count";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RSSI";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PC Bits";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Memory Bank Data";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MB";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Offset";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "cal";
            this.columnHeader9.Width = 0;
            // 
            // gpiLabel
            // 
            this.gpiLabel.AutoSize = true;
            this.gpiLabel.Location = new System.Drawing.Point(6, 27);
            this.gpiLabel.Name = "gpiLabel";
            this.gpiLabel.Size = new System.Drawing.Size(68, 13);
            this.gpiLabel.TabIndex = 5;
            this.gpiLabel.Text = "Red For Low";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(80, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(114, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GreenYellow;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(150, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(185, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(321, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "  ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.GreenYellow;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(288, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(254, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.GreenYellow;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(220, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "  ";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionCallStatusLabel,
            this.connectionStatusLabel,
            this.connectionStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 503);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(1101, 25);
            this.statusStrip.TabIndex = 19;
            this.statusStrip.Text = "statusStrip";
            // 
            // functionCallStatusLabel
            // 
            this.functionCallStatusLabel.AutoSize = false;
            this.functionCallStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.functionCallStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.functionCallStatusLabel.Margin = new System.Windows.Forms.Padding(2, 3, 0, 2);
            this.functionCallStatusLabel.Name = "functionCallStatusLabel";
            this.functionCallStatusLabel.Size = new System.Drawing.Size(716, 20);
            this.functionCallStatusLabel.Text = "Ready";
            this.functionCallStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // connectionStatus
            // 
            this.connectionStatus.AutoSize = false;
            this.connectionStatus.BackgroundImage = global::DCRFIDReader.Properties.Resources.disconnected;
            this.connectionStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connectionStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.connectionStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(50, 20);
            this.connectionStatus.Text = "Disconnected";
            // 
            // gpiStateGB
            // 
            this.gpiStateGB.Controls.Add(this.gpiNumberLabel);
            this.gpiStateGB.Controls.Add(this.label6);
            this.gpiStateGB.Controls.Add(this.label7);
            this.gpiStateGB.Controls.Add(this.label8);
            this.gpiStateGB.Controls.Add(this.label9);
            this.gpiStateGB.Controls.Add(this.label5);
            this.gpiStateGB.Controls.Add(this.label4);
            this.gpiStateGB.Controls.Add(this.label3);
            this.gpiStateGB.Controls.Add(this.label2);
            this.gpiStateGB.Controls.Add(this.gpiLabel);
            this.gpiStateGB.Location = new System.Drawing.Point(12, 331);
            this.gpiStateGB.Name = "gpiStateGB";
            this.gpiStateGB.Size = new System.Drawing.Size(347, 54);
            this.gpiStateGB.TabIndex = 20;
            this.gpiStateGB.TabStop = false;
            this.gpiStateGB.Text = "GPI State";
            // 
            // gpiNumberLabel
            // 
            this.gpiNumberLabel.AutoSize = true;
            this.gpiNumberLabel.Location = new System.Drawing.Point(77, 38);
            this.gpiNumberLabel.Name = "gpiNumberLabel";
            this.gpiNumberLabel.Size = new System.Drawing.Size(259, 13);
            this.gpiNumberLabel.TabIndex = 18;
            this.gpiNumberLabel.Text = " 1          2          3         4          5          6         7         8";
            // 
            // transmitPowerGB
            // 
            this.transmitPowerGB.Controls.Add(this.label12);
            this.transmitPowerGB.Controls.Add(this.label10);
            this.transmitPowerGB.Controls.Add(this.label11);
            this.transmitPowerGB.Controls.Add(this.hScrollBar1);
            this.transmitPowerGB.Location = new System.Drawing.Point(11, 331);
            this.transmitPowerGB.Name = "transmitPowerGB";
            this.transmitPowerGB.Size = new System.Drawing.Size(347, 53);
            this.transmitPowerGB.TabIndex = 23;
            this.transmitPowerGB.TabStop = false;
            this.transmitPowerGB.Text = "Transmit Power (dbm)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "2920";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "1620";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "1620";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(13, 16);
            this.hScrollBar1.Maximum = 2920;
            this.hScrollBar1.Minimum = 1620;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(314, 19);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Value = 1620;
            // 
            // dataContextMenuStrip
            // 
            this.dataContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tagDataToolStripMenuItem,
            this.readDataContextMenuItem,
            this.writeDataContextMenuItem,
            this.lockDataContextMenuItem,
            this.killDataContextMenuItem,
            this.blockWriteDataContextMenuItem,
            this.blockEraseDataContextMenuItem});
            this.dataContextMenuStrip.Name = "dataContextMenuStrip";
            this.dataContextMenuStrip.Size = new System.Drawing.Size(135, 158);
            // 
            // tagDataToolStripMenuItem
            // 
            this.tagDataToolStripMenuItem.Name = "tagDataToolStripMenuItem";
            this.tagDataToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.tagDataToolStripMenuItem.Text = "Tag Data";
            this.tagDataToolStripMenuItem.Click += new System.EventHandler(this.tagDataToolStripMenuItem_Click);
            // 
            // readDataContextMenuItem
            // 
            this.readDataContextMenuItem.Name = "readDataContextMenuItem";
            this.readDataContextMenuItem.Size = new System.Drawing.Size(134, 22);
            this.readDataContextMenuItem.Text = "Read";
            this.readDataContextMenuItem.Click += new System.EventHandler(this.readDataContextMenuItem_Click);
            // 
            // writeDataContextMenuItem
            // 
            this.writeDataContextMenuItem.Name = "writeDataContextMenuItem";
            this.writeDataContextMenuItem.Size = new System.Drawing.Size(134, 22);
            this.writeDataContextMenuItem.Text = "Write";
            this.writeDataContextMenuItem.Click += new System.EventHandler(this.writeDataContextMenuItem_Click);
            // 
            // lockDataContextMenuItem
            // 
            this.lockDataContextMenuItem.Name = "lockDataContextMenuItem";
            this.lockDataContextMenuItem.Size = new System.Drawing.Size(134, 22);
            this.lockDataContextMenuItem.Text = "Lock";
            this.lockDataContextMenuItem.Click += new System.EventHandler(this.lockDataContextMenuItem_Click);
            // 
            // killDataContextMenuItem
            // 
            this.killDataContextMenuItem.Name = "killDataContextMenuItem";
            this.killDataContextMenuItem.Size = new System.Drawing.Size(134, 22);
            this.killDataContextMenuItem.Text = "Kill";
            this.killDataContextMenuItem.Click += new System.EventHandler(this.killDataContextMenuItem_Click);
            // 
            // blockWriteDataContextMenuItem
            // 
            this.blockWriteDataContextMenuItem.Name = "blockWriteDataContextMenuItem";
            this.blockWriteDataContextMenuItem.Size = new System.Drawing.Size(134, 22);
            this.blockWriteDataContextMenuItem.Text = "Block Write";
            this.blockWriteDataContextMenuItem.Click += new System.EventHandler(this.blockWriteDataContextMenuItem_Click);
            // 
            // blockEraseDataContextMenuItem
            // 
            this.blockEraseDataContextMenuItem.Name = "blockEraseDataContextMenuItem";
            this.blockEraseDataContextMenuItem.Size = new System.Drawing.Size(134, 22);
            this.blockEraseDataContextMenuItem.Text = "Block Erase";
            this.blockEraseDataContextMenuItem.Click += new System.EventHandler(this.blockEraseDataContextMenuItem_Click);
            // 
            // connectBackgroundWorker
            // 
            this.connectBackgroundWorker.WorkerReportsProgress = true;
            this.connectBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.connectBackgroundWorker_DoWork);
            this.connectBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.connectBackgroundWorker_ProgressChanged);
            this.connectBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.connectBackgroundWorker_RunWorkerCompleted);
            // 
            // accessBackgroundWorker
            // 
            this.accessBackgroundWorker.WorkerReportsProgress = true;
            this.accessBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.accessBackgroundWorker_DoWork);
            this.accessBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.accessBackgroundWorker_ProgressChanged);
            this.accessBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.accessBackgroundWorker_RunWorkerCompleted);
            // 
            // clearReports_CB
            // 
            this.clearReports_CB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearReports_CB.AutoSize = true;
            this.clearReports_CB.Location = new System.Drawing.Point(999, 71);
            this.clearReports_CB.Name = "clearReports_CB";
            this.clearReports_CB.Size = new System.Drawing.Size(90, 17);
            this.clearReports_CB.TabIndex = 27;
            this.clearReports_CB.Text = "Clear Reports";
            this.clearReports_CB.UseVisualStyleBackColor = true;
            this.clearReports_CB.Visible = false;
            this.clearReports_CB.CheckedChanged += new System.EventHandler(this.clearReports_CB_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 465);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gcPO);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1080, 439);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "SUMMARY P/O";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gcPO
            // 
            this.gcPO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPO.Location = new System.Drawing.Point(3, 3);
            this.gcPO.MainView = this.gvPO;
            this.gcPO.Name = "gcPO";
            this.gcPO.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit3,
            this.repBtnPOCommit});
            this.gcPO.Size = new System.Drawing.Size(1074, 433);
            this.gcPO.TabIndex = 3;
            this.gcPO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPO});
            // 
            // gvPO
            // 
            this.gvPO.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvPO.Appearance.FooterPanel.Options.UseFont = true;
            this.gvPO.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvPO.Appearance.GroupFooter.Options.UseFont = true;
            this.gvPO.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvPO.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPO.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvPO.Appearance.Row.Options.UseFont = true;
            this.gvPO.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvPO.Appearance.ViewCaption.Options.UseFont = true;
            this.gvPO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn25,
            this.colPOGateNumber,
            this.colPOBookingNo,
            this.gridColumn36,
            this.gridColumn24,
            this.gridColumn32,
            this.gridColumn26,
            this.gridColumn28,
            this.gcoltime_count});
            this.gvPO.GridControl = this.gcPO;
            this.gvPO.Name = "gvPO";
            this.gvPO.OptionsView.ColumnAutoWidth = false;
            this.gvPO.OptionsView.RowAutoHeight = true;
            this.gvPO.OptionsView.ShowAutoFilterRow = true;
            this.gvPO.OptionsView.ShowFooter = true;
            this.gvPO.OptionsView.ShowGroupPanel = false;
            this.gvPO.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvPO_RowStyle);
            this.gvPO.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPO_CellValueChanged);
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "No.";
            this.gridColumn25.FieldName = "row";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.OptionsColumn.AllowEdit = false;
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 0;
            this.gridColumn25.Width = 62;
            // 
            // colPOGateNumber
            // 
            this.colPOGateNumber.Caption = "GATE NO.";
            this.colPOGateNumber.FieldName = "GateNumber";
            this.colPOGateNumber.Name = "colPOGateNumber";
            this.colPOGateNumber.Visible = true;
            this.colPOGateNumber.VisibleIndex = 1;
            this.colPOGateNumber.Width = 94;
            // 
            // colPOBookingNo
            // 
            this.colPOBookingNo.Caption = "BOOKING NO.";
            this.colPOBookingNo.FieldName = "BookingNo";
            this.colPOBookingNo.Name = "colPOBookingNo";
            this.colPOBookingNo.Visible = true;
            this.colPOBookingNo.VisibleIndex = 2;
            this.colPOBookingNo.Width = 126;
            // 
            // gridColumn36
            // 
            this.gridColumn36.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn36.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn36.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn36.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn36.Caption = "P/O NO.";
            this.gridColumn36.FieldName = "OrderNumber";
            this.gridColumn36.Name = "gridColumn36";
            this.gridColumn36.OptionsColumn.AllowEdit = false;
            this.gridColumn36.Visible = true;
            this.gridColumn36.VisibleIndex = 3;
            this.gridColumn36.Width = 141;
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "TOTAL QTY";
            this.gridColumn24.FieldName = "DigitalQuantity";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 4;
            this.gridColumn24.Width = 122;
            // 
            // gridColumn32
            // 
            this.gridColumn32.Caption = "TOTAL READ";
            this.gridColumn32.FieldName = "QtyRead";
            this.gridColumn32.Name = "gridColumn32";
            this.gridColumn32.OptionsColumn.AllowEdit = false;
            this.gridColumn32.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyRead", "{0:0.##}")});
            this.gridColumn32.Visible = true;
            this.gridColumn32.VisibleIndex = 5;
            this.gridColumn32.Width = 133;
            // 
            // gridColumn26
            // 
            this.gridColumn26.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn26.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn26.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn26.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn26.Caption = "เริ่มรับเวลา";
            this.gridColumn26.DisplayFormat.FormatString = "HH:mm:ss";
            this.gridColumn26.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn26.FieldName = "start_time";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.OptionsColumn.AllowEdit = false;
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 6;
            this.gridColumn26.Width = 138;
            // 
            // gridColumn28
            // 
            this.gridColumn28.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn28.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn28.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn28.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn28.Caption = "สิ้นสุดเวลา";
            this.gridColumn28.DisplayFormat.FormatString = "HH:mm:ss";
            this.gridColumn28.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn28.FieldName = "stop_time";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.OptionsColumn.AllowEdit = false;
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 7;
            this.gridColumn28.Width = 138;
            // 
            // gcoltime_count
            // 
            this.gcoltime_count.AppearanceCell.Options.UseTextOptions = true;
            this.gcoltime_count.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcoltime_count.AppearanceHeader.Options.UseTextOptions = true;
            this.gcoltime_count.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcoltime_count.Caption = "เป็นเวลา";
            this.gcoltime_count.FieldName = "time_count";
            this.gcoltime_count.Name = "gcoltime_count";
            this.gcoltime_count.OptionsColumn.AllowEdit = false;
            this.gcoltime_count.Visible = true;
            this.gcoltime_count.VisibleIndex = 8;
            this.gcoltime_count.Width = 138;
            // 
            // repositoryItemPictureEdit3
            // 
            this.repositoryItemPictureEdit3.Name = "repositoryItemPictureEdit3";
            this.repositoryItemPictureEdit3.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.repositoryItemPictureEdit3.ZoomAccelerationFactor = 1D;
            // 
            // repBtnPOCommit
            // 
            this.repBtnPOCommit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.repBtnPOCommit.Appearance.Options.UseFont = true;
            this.repBtnPOCommit.AutoHeight = false;
            this.repBtnPOCommit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Accept", -1, true, true, false, editorButtonImageOptions1)});
            this.repBtnPOCommit.Name = "repBtnPOCommit";
            this.repBtnPOCommit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gcBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1080, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BOX";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gcBox
            // 
            this.gcBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBox.Location = new System.Drawing.Point(3, 3);
            this.gcBox.MainView = this.gvBox;
            this.gcBox.Name = "gcBox";
            this.gcBox.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repPic});
            this.gcBox.Size = new System.Drawing.Size(1071, 433);
            this.gcBox.TabIndex = 1;
            this.gcBox.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBox});
            this.gcBox.Click += new System.EventHandler(this.gcBox_Click);
            // 
            // gvBox
            // 
            this.gvBox.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvBox.Appearance.FooterPanel.Options.UseFont = true;
            this.gvBox.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvBox.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvBox.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvBox.Appearance.Row.Options.UseFont = true;
            this.gvBox.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn27,
            this.gridColumn31,
            this.gridColumn29,
            this.gridColumn20,
            this.gridColumn5,
            this.gridColumn4,
            this.colIDDB,
            this.gridColumn11,
            this.gridColumn2,
            this.gridColumn30});
            this.gvBox.GridControl = this.gcBox;
            this.gvBox.Name = "gvBox";
            this.gvBox.OptionsView.ColumnAutoWidth = false;
            this.gvBox.OptionsView.RowAutoHeight = true;
            this.gvBox.OptionsView.ShowAutoFilterRow = true;
            this.gvBox.OptionsView.ShowFooter = true;
            this.gvBox.OptionsView.ShowGroupPanel = false;
            this.gvBox.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvBox_RowStyle);
            // 
            // gridColumn27
            // 
            this.gridColumn27.Caption = "No.";
            this.gridColumn27.FieldName = "row";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.OptionsColumn.AllowEdit = false;
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 0;
            this.gridColumn27.Width = 60;
            // 
            // gridColumn31
            // 
            this.gridColumn31.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn31.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn31.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn31.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn31.Caption = "GATE NO.";
            this.gridColumn31.FieldName = "GateNumber";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.OptionsColumn.AllowEdit = false;
            this.gridColumn31.Visible = true;
            this.gridColumn31.VisibleIndex = 1;
            this.gridColumn31.Width = 84;
            // 
            // gridColumn29
            // 
            this.gridColumn29.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn29.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn29.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn29.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn29.Caption = "BOOKING NO.";
            this.gridColumn29.FieldName = "BookingNo";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.OptionsColumn.AllowEdit = false;
            this.gridColumn29.Visible = true;
            this.gridColumn29.VisibleIndex = 2;
            this.gridColumn29.Width = 113;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "P/O NO.";
            this.gridColumn20.FieldName = "OrderNumber";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderNumber", "Total {0} BOXES")});
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 3;
            this.gridColumn20.Width = 141;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "STORE";
            this.gridColumn5.FieldName = "StoreNumber";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "BOX NO.";
            this.gridColumn4.FieldName = "BoxOfTotal";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            // 
            // colIDDB
            // 
            this.colIDDB.Caption = "CID.";
            this.colIDDB.FieldName = "ContainerId";
            this.colIDDB.Name = "colIDDB";
            this.colIDDB.OptionsColumn.AllowEdit = false;
            this.colIDDB.OptionsColumn.ReadOnly = true;
            this.colIDDB.Visible = true;
            this.colIDDB.VisibleIndex = 6;
            this.colIDDB.Width = 210;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "TOTAL QTY.";
            this.gridColumn11.FieldName = "DigitalQuantity";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DigitalQuantity", "{0:0.##}")});
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 7;
            this.gridColumn11.Width = 124;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "QTY.  READ";
            this.gridColumn2.FieldName = "QtyRead";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyRead", "{0:0.##}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 8;
            this.gridColumn2.Width = 123;
            // 
            // gridColumn30
            // 
            this.gridColumn30.Caption = "OrderNumber";
            this.gridColumn30.FieldName = "OrderNumber";
            this.gridColumn30.Name = "gridColumn30";
            // 
            // repPic
            // 
            this.repPic.Name = "repPic";
            this.repPic.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.repPic.ZoomAccelerationFactor = 1D;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gcUPC);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1080, 439);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SKU";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gcUPC
            // 
            this.gcUPC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcUPC.Location = new System.Drawing.Point(3, 3);
            this.gcUPC.MainView = this.gvUPC;
            this.gcUPC.Name = "gcUPC";
            this.gcUPC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gcUPC.Size = new System.Drawing.Size(1074, 432);
            this.gcUPC.TabIndex = 2;
            this.gcUPC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUPC});
            // 
            // gvUPC
            // 
            this.gvUPC.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvUPC.Appearance.FooterPanel.Options.UseFont = true;
            this.gvUPC.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvUPC.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvUPC.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvUPC.Appearance.Row.Options.UseFont = true;
            this.gvUPC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn13,
            this.gridColumn34,
            this.gridColumn33,
            this.gridColumn19,
            this.gridColumn17,
            this.gridColumn3,
            this.gridColumn21,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn22});
            this.gvUPC.GridControl = this.gcUPC;
            this.gvUPC.Name = "gvUPC";
            this.gvUPC.OptionsView.ColumnAutoWidth = false;
            this.gvUPC.OptionsView.RowAutoHeight = true;
            this.gvUPC.OptionsView.ShowAutoFilterRow = true;
            this.gvUPC.OptionsView.ShowFooter = true;
            this.gvUPC.OptionsView.ShowGroupPanel = false;
            this.gvUPC.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvUPC_RowStyle);
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "No.";
            this.gridColumn13.FieldName = "rw";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            this.gridColumn13.Width = 54;
            // 
            // gridColumn34
            // 
            this.gridColumn34.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn34.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn34.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn34.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn34.Caption = "GATE NO.";
            this.gridColumn34.FieldName = "GateNumber";
            this.gridColumn34.Name = "gridColumn34";
            this.gridColumn34.OptionsColumn.AllowEdit = false;
            this.gridColumn34.Visible = true;
            this.gridColumn34.VisibleIndex = 1;
            this.gridColumn34.Width = 84;
            // 
            // gridColumn33
            // 
            this.gridColumn33.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn33.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn33.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn33.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn33.Caption = "BOOKING NO.";
            this.gridColumn33.FieldName = "BookingNo";
            this.gridColumn33.Name = "gridColumn33";
            this.gridColumn33.OptionsColumn.AllowEdit = false;
            this.gridColumn33.Visible = true;
            this.gridColumn33.VisibleIndex = 2;
            this.gridColumn33.Width = 113;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "P/O NO.";
            this.gridColumn19.FieldName = "OrderNumber";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderNumber", "Total {0} SKU")});
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 3;
            this.gridColumn19.Width = 141;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "STORE";
            this.gridColumn17.FieldName = "StoreNumber";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 4;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "BOX NO.";
            this.gridColumn3.FieldName = "BoxOfTotal";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 73;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "CID.";
            this.gridColumn21.FieldName = "ContainerId";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.AllowEdit = false;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 6;
            this.gridColumn21.Width = 169;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "SKU.";
            this.gridColumn7.FieldName = "ProductSku";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 135;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "UPC.";
            this.gridColumn8.FieldName = "Upc";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            this.gridColumn8.Width = 154;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "DESCRIPTION";
            this.gridColumn9.FieldName = "Description";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 9;
            this.gridColumn9.Width = 296;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "TOTAL QTY.";
            this.gridColumn10.FieldName = "DigitalQuantity";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DigitalQuantity", "{0:0.##}")});
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 10;
            this.gridColumn10.Width = 114;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "TOTAL READ";
            this.gridColumn22.FieldName = "QtyRead";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.OptionsColumn.AllowEdit = false;
            this.gridColumn22.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyRead", "{0:0.##}")});
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 11;
            this.gridColumn22.Width = 106;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gcTag);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1080, 439);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "EPC";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gcTag
            // 
            this.gcTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTag.Location = new System.Drawing.Point(3, 3);
            this.gcTag.MainView = this.gvTag;
            this.gcTag.Name = "gcTag";
            this.gcTag.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit2});
            this.gcTag.Size = new System.Drawing.Size(1071, 433);
            this.gcTag.TabIndex = 3;
            this.gcTag.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTag});
            // 
            // gvTag
            // 
            this.gvTag.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn18,
            this.gridColumn1,
            this.gridColumn12,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn23,
            this.gridColumn6,
            this.gridColumn35,
            this.gridColumn37});
            this.gvTag.GridControl = this.gcTag;
            this.gvTag.Name = "gvTag";
            this.gvTag.OptionsView.ColumnAutoWidth = false;
            this.gvTag.OptionsView.RowAutoHeight = true;
            this.gvTag.OptionsView.ShowAutoFilterRow = true;
            this.gvTag.OptionsView.ShowFooter = true;
            this.gvTag.OptionsView.ShowGroupPanel = false;
            this.gvTag.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvTag_RowStyle);
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "EPC ID.";
            this.gridColumn18.FieldName = "EPC";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "EPC", "Total {0} EPC")});
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 0;
            this.gridColumn18.Width = 187;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Box ID.";
            this.gridColumn1.FieldName = "ContainerId";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 210;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Status";
            this.gridColumn12.FieldName = "Status";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.ReadOnly = true;
            this.gridColumn12.Width = 56;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "SKU.";
            this.gridColumn14.FieldName = "ProductSku";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 1;
            this.gridColumn14.Width = 122;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "UPC.";
            this.gridColumn15.FieldName = "Upc";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 2;
            this.gridColumn15.Width = 172;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Description";
            this.gridColumn16.FieldName = "Description";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 3;
            this.gridColumn16.Width = 309;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "P/O NO.";
            this.gridColumn23.FieldName = "OrderNumber";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.OptionsColumn.AllowEdit = false;
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 6;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "STORE NO.";
            this.gridColumn6.FieldName = "StoreNumber";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 147;
            // 
            // gridColumn35
            // 
            this.gridColumn35.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn35.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn35.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn35.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn35.Caption = "Qty Read";
            this.gridColumn35.FieldName = "QtyRead";
            this.gridColumn35.Name = "gridColumn35";
            this.gridColumn35.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyRead", "Received={0:0} EPC")});
            this.gridColumn35.Visible = true;
            this.gridColumn35.VisibleIndex = 7;
            // 
            // gridColumn37
            // 
            this.gridColumn37.Caption = "PRProductItemId";
            this.gridColumn37.FieldName = "PRProductItemId";
            this.gridColumn37.Name = "gridColumn37";
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            this.repositoryItemPictureEdit2.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.repositoryItemPictureEdit2.ZoomAccelerationFactor = 1D;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lstSyncLog);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1080, 439);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "SYNC LOG";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lstSyncLog
            // 
            this.lstSyncLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSyncLog.FormattingEnabled = true;
            this.lstSyncLog.Location = new System.Drawing.Point(3, 4);
            this.lstSyncLog.Name = "lstSyncLog";
            this.lstSyncLog.Size = new System.Drawing.Size(1071, 433);
            this.lstSyncLog.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTotalEPC);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.inventoryList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1080, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read Tags";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTotalEPC
            // 
            this.lblTotalEPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalEPC.AutoSize = true;
            this.lblTotalEPC.Location = new System.Drawing.Point(77, 417);
            this.lblTotalEPC.Name = "lblTotalEPC";
            this.lblTotalEPC.Size = new System.Drawing.Size(13, 13);
            this.lblTotalEPC.TabIndex = 2;
            this.lblTotalEPC.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total EPC : ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "VS2010";
            // 
            // timer1_timecount
            // 
            this.timer1_timecount.Interval = 1000;
            this.timer1_timecount.Tick += new System.EventHandler(this.timer1_timecount_Tick);
            // 
            // btnStartAuto
            // 
            this.btnStartAuto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStartAuto.ImageOptions.Image")));
            this.btnStartAuto.Location = new System.Drawing.Point(1, 1);
            this.btnStartAuto.Name = "btnStartAuto";
            this.btnStartAuto.Size = new System.Drawing.Size(133, 27);
            this.btnStartAuto.TabIndex = 39;
            this.btnStartAuto.Text = "Start Auto Scan";
            this.btnStartAuto.Click += new System.EventHandler(this.btnStartAuto_Click);
            // 
            // btnStopAuto
            // 
            this.btnStopAuto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStopAuto.ImageOptions.Image")));
            this.btnStopAuto.Location = new System.Drawing.Point(140, 2);
            this.btnStopAuto.Name = "btnStopAuto";
            this.btnStopAuto.Size = new System.Drawing.Size(110, 27);
            this.btnStopAuto.TabIndex = 39;
            this.btnStopAuto.Text = "Stop Auto Scan";
            this.btnStopAuto.Click += new System.EventHandler(this.btnStopAuto_Click);
            // 
            // btnStartRead
            // 
            this.btnStartRead.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnStartRead.Appearance.Options.UseFont = true;
            this.btnStartRead.Location = new System.Drawing.Point(343, 2);
            this.btnStartRead.Name = "btnStartRead";
            this.btnStartRead.Size = new System.Drawing.Size(146, 27);
            this.btnStartRead.TabIndex = 39;
            this.btnStartRead.Text = "Start Reading";
            this.btnStartRead.Click += new System.EventHandler(this.btnStartRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(495, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 27);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // timer_getCommand
            // 
            this.timer_getCommand.Interval = 1000;
            this.timer_getCommand.Tick += new System.EventHandler(this.timer_getCommand_Tick);
            // 
            // btnScanCommandManual
            // 
            this.btnScanCommandManual.Location = new System.Drawing.Point(805, 12);
            this.btnScanCommandManual.Name = "btnScanCommandManual";
            this.btnScanCommandManual.Size = new System.Drawing.Size(147, 22);
            this.btnScanCommandManual.TabIndex = 40;
            this.btnScanCommandManual.Text = "Scan Command Manual";
            this.btnScanCommandManual.UseVisualStyleBackColor = true;
            this.btnScanCommandManual.Visible = false;
            this.btnScanCommandManual.Click += new System.EventHandler(this.btnScanCommandManual_Click);
            // 
            // btnResetRequest
            // 
            this.btnResetRequest.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResetRequest.ImageOptions.Image")));
            this.btnResetRequest.Location = new System.Drawing.Point(674, 2);
            this.btnResetRequest.Name = "btnResetRequest";
            this.btnResetRequest.Size = new System.Drawing.Size(115, 27);
            this.btnResetRequest.TabIndex = 39;
            this.btnResetRequest.Text = "Reset Request";
            this.btnResetRequest.Click += new System.EventHandler(this.btnResetRequest_Click);
            // 
            // timer_reconnect
            // 
            this.timer_reconnect.Enabled = true;
            this.timer_reconnect.Interval = 5000;
            this.timer_reconnect.Tick += new System.EventHandler(this.timer_reconnect_Tick);
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
            // timer_clear_buffer
            // 
            this.timer_clear_buffer.Interval = 20000;
            this.timer_clear_buffer.Tick += new System.EventHandler(this.timer_clear_buffer_Tick);
            // 
            // frmAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1101, 528);
            this.Controls.Add(this.btnScanCommandManual);
            this.Controls.Add(this.btnStopAuto);
            this.Controls.Add(this.btnResetRequest);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStartRead);
            this.Controls.Add(this.btnStartAuto);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.clearReports_CB);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(16, 250);
            this.Name = "frmAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RFID DC Receive Reader IP : xx.xx.xx.xx";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppForm_FormClosing);
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.ClientSizeChanged += new System.EventHandler(this.AppForm_ClientSizeChanged);
            this.Move += new System.EventHandler(this.frmAppForm_Move);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gpiStateGB.ResumeLayout(false);
            this.gpiStateGB.PerformLayout();
            this.transmitPowerGB.ResumeLayout(false);
            this.transmitPowerGB.PerformLayout();
            this.dataContextMenuStrip.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBtnPOCommit)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPic)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label gpiLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capabilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpiStateGB;
        private System.Windows.Forms.Label gpiNumberLabel;
        private System.Windows.Forms.GroupBox transmitPowerGB;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatusLabel;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip dataContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tagDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readDataContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeDataContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockDataContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killDataContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockWriteDataContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockEraseDataContextMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatus;
        internal System.ComponentModel.BackgroundWorker connectBackgroundWorker;
        internal System.ComponentModel.BackgroundWorker accessBackgroundWorker;
        internal System.Windows.Forms.ToolStripStatusLabel functionCallStatusLabel;
        internal System.Windows.Forms.ListView inventoryList;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.CheckBox clearReports_CB;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gcBox;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBox;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDB;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repPic;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraGrid.GridControl gcTag;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTag;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.GridControl gcUPC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUPC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.TabPage tabPage4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private System.Windows.Forms.TabPage tabPage5;
        private DevExpress.XtraGrid.GridControl gcPO;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPO;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit3;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repBtnPOCommit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ListBox lstSyncLog;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gcoltime_count;
        private System.Windows.Forms.Timer timer1_timecount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private System.Windows.Forms.ToolStripMenuItem mnuGate;
        private System.Windows.Forms.ToolStripMenuItem mnuDevice;
        private System.Windows.Forms.ToolStripMenuItem mnuSettingDeviceToGate;
        private DevExpress.XtraGrid.Columns.GridColumn colPOGateNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colPOBookingNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        internal DevExpress.XtraEditors.SimpleButton btnStartAuto;
        internal DevExpress.XtraEditors.SimpleButton btnStopAuto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        internal DevExpress.XtraEditors.SimpleButton btnStartRead;
        internal DevExpress.XtraEditors.SimpleButton btnClear;
        private System.Windows.Forms.Label lblTotalEPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_getCommand;
        private System.Windows.Forms.Button btnScanCommandManual;
        internal DevExpress.XtraEditors.SimpleButton btnResetRequest;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
        private System.Windows.Forms.Timer timer_reconnect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuShow;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer_clear_buffer;
    }
}