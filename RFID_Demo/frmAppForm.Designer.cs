namespace CS_RFID3_Host_Sample1
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.readButton = new System.Windows.Forms.Button();
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
            this.totalTagValueLabel = new System.Windows.Forms.Label();
            this.totalTagLabel = new System.Windows.Forms.Label();
            this.clearReports_CB = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotalBox = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalUPC = new System.Windows.Forms.Label();
            this.lblTotalSKU = new System.Windows.Forms.Label();
            this.lblNumberOfBox = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gcPO = new DevExpress.XtraGrid.GridControl();
            this.gvPO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gcBox = new DevExpress.XtraGrid.GridControl();
            this.gvBox = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDDB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repPic = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gcUPC = new DevExpress.XtraGrid.GridControl();
            this.gvUPC = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gcTag = new DevExpress.XtraGrid.GridControl();
            this.gvTag = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bntClear = new System.Windows.Forms.Button();
            this.btnLoadPO = new System.Windows.Forms.Button();
            this.cboVendor = new DevExpress.XtraEditors.LookUpEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboBookingNo = new DevExpress.XtraEditors.LookUpEdit();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.gpiStateGB.SuspendLayout();
            this.transmitPowerGB.SuspendLayout();
            this.dataContextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPic)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVendor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBookingNo.Properties)).BeginInit();
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
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.capabilitiesToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.connectionToolStripMenuItem.Text = "Connection...";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // capabilitiesToolStripMenuItem
            // 
            this.capabilitiesToolStripMenuItem.Name = "capabilitiesToolStripMenuItem";
            this.capabilitiesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.capabilitiesToolStripMenuItem.Text = "Capabilities...";
            this.capabilitiesToolStripMenuItem.Click += new System.EventHandler(this.capabilitiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
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
            this.inventoryList.Size = new System.Drawing.Size(1071, 302);
            this.inventoryList.TabIndex = 1;
            this.inventoryList.UseCompatibleStateImageBehavior = false;
            this.inventoryList.View = System.Windows.Forms.View.Details;
            this.inventoryList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inventoryList_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "EPC ID";
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
            // readButton
            // 
            this.readButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.readButton.Enabled = false;
            this.readButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readButton.Location = new System.Drawing.Point(201, 96);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(190, 54);
            this.readButton.TabIndex = 2;
            this.readButton.Text = "Start Reading";
            this.readButton.UseVisualStyleBackColor = false;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
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
            this.connectionStatus.BackgroundImage = global::CS_RFID3_Host_Sample1.Properties.Resources.disconnected;
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
            // totalTagValueLabel
            // 
            this.totalTagValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.totalTagValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalTagValueLabel.Location = new System.Drawing.Point(192, 16);
            this.totalTagValueLabel.Name = "totalTagValueLabel";
            this.totalTagValueLabel.Size = new System.Drawing.Size(197, 28);
            this.totalTagValueLabel.TabIndex = 26;
            this.totalTagValueLabel.Text = "0(0)";
            this.totalTagValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalTagLabel
            // 
            this.totalTagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalTagLabel.Location = new System.Drawing.Point(52, 16);
            this.totalTagLabel.Name = "totalTagLabel";
            this.totalTagLabel.Size = new System.Drawing.Size(134, 28);
            this.totalTagLabel.TabIndex = 25;
            this.totalTagLabel.Text = "TOTAL TAGS : ";
            this.totalTagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblTotalBox);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.totalTagLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTotalUPC);
            this.groupBox1.Controls.Add(this.lblTotalSKU);
            this.groupBox1.Controls.Add(this.totalTagValueLabel);
            this.groupBox1.Controls.Add(this.lblNumberOfBox);
            this.groupBox1.Location = new System.Drawing.Point(598, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 126);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SUMMARY";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(424, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 28);
            this.label16.TabIndex = 25;
            this.label16.Text = "Total Box : ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Visible = false;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(731, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 28);
            this.label13.TabIndex = 25;
            this.label13.Text = "Total SKU : ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Visible = false;
            // 
            // lblTotalBox
            // 
            this.lblTotalBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalBox.Location = new System.Drawing.Point(528, 55);
            this.lblTotalBox.Name = "lblTotalBox";
            this.lblTotalBox.Size = new System.Drawing.Size(197, 28);
            this.lblTotalBox.TabIndex = 26;
            this.lblTotalBox.Text = "0";
            this.lblTotalBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalBox.Visible = false;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.Location = new System.Drawing.Point(11, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(175, 28);
            this.label17.TabIndex = 25;
            this.label17.Text = "Total Quantity : ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Number Of Box : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalUPC
            // 
            this.lblTotalUPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalUPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalUPC.Location = new System.Drawing.Point(192, 92);
            this.lblTotalUPC.Name = "lblTotalUPC";
            this.lblTotalUPC.Size = new System.Drawing.Size(197, 28);
            this.lblTotalUPC.TabIndex = 26;
            this.lblTotalUPC.Text = "0/0";
            this.lblTotalUPC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalSKU
            // 
            this.lblTotalSKU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalSKU.Location = new System.Drawing.Point(835, 55);
            this.lblTotalSKU.Name = "lblTotalSKU";
            this.lblTotalSKU.Size = new System.Drawing.Size(173, 28);
            this.lblTotalSKU.TabIndex = 26;
            this.lblTotalSKU.Text = "0";
            this.lblTotalSKU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalSKU.Visible = false;
            // 
            // lblNumberOfBox
            // 
            this.lblNumberOfBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblNumberOfBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberOfBox.Location = new System.Drawing.Point(192, 55);
            this.lblNumberOfBox.Name = "lblNumberOfBox";
            this.lblNumberOfBox.Size = new System.Drawing.Size(197, 28);
            this.lblNumberOfBox.TabIndex = 26;
            this.lblNumberOfBox.Text = "0/0";
            this.lblNumberOfBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 156);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 344);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gcPO);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1080, 318);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "SUMARY P/O";
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
            this.repositoryItemPictureEdit3});
            this.gcPO.Size = new System.Drawing.Size(1074, 309);
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
            this.gridColumn24,
            this.gridColumn25,
            this.gridColumn31,
            this.gridColumn32,
            this.gridColumn26});
            this.gvPO.GridControl = this.gcPO;
            this.gvPO.Name = "gvPO";
            this.gvPO.OptionsView.ColumnAutoWidth = false;
            this.gvPO.OptionsView.RowAutoHeight = true;
            this.gvPO.OptionsView.ShowAutoFilterRow = true;
            this.gvPO.OptionsView.ShowFooter = true;
            this.gvPO.OptionsView.ShowGroupPanel = false;
            this.gvPO.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvPO_RowStyle);
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "P/O NO.";
            this.gridColumn24.FieldName = "OrderNumber";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.OptionsColumn.AllowEdit = false;
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 0;
            this.gridColumn24.Width = 116;
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "STORE";
            this.gridColumn25.FieldName = "StoreNumber";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.OptionsColumn.AllowEdit = false;
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 1;
            this.gridColumn25.Width = 84;
            // 
            // gridColumn31
            // 
            this.gridColumn31.Caption = "TOTAL QTY";
            this.gridColumn31.FieldName = "DigitalQuantity";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.OptionsColumn.AllowEdit = false;
            this.gridColumn31.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DigitalQuantity", "{0:0.##}")});
            this.gridColumn31.Visible = true;
            this.gridColumn31.VisibleIndex = 2;
            this.gridColumn31.Width = 129;
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
            this.gridColumn32.VisibleIndex = 3;
            this.gridColumn32.Width = 133;
            // 
            // gridColumn26
            // 
            this.gridColumn26.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn26.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn26.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn26.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn26.Caption = "TIME";
            this.gridColumn26.FieldName = "time_count";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.OptionsColumn.AllowEdit = false;
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 4;
            this.gridColumn26.Width = 166;
            // 
            // repositoryItemPictureEdit3
            // 
            this.repositoryItemPictureEdit3.Name = "repositoryItemPictureEdit3";
            this.repositoryItemPictureEdit3.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.repositoryItemPictureEdit3.ZoomAccelerationFactor = 1D;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gcBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1080, 318);
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
            this.gcBox.Size = new System.Drawing.Size(1071, 309);
            this.gcBox.TabIndex = 1;
            this.gcBox.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBox});
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
            this.gridColumn20,
            this.gridColumn5,
            this.gridColumn4,
            this.colIDDB,
            this.gridColumn11,
            this.gridColumn2});
            this.gvBox.GridControl = this.gcBox;
            this.gvBox.Name = "gvBox";
            this.gvBox.OptionsView.ColumnAutoWidth = false;
            this.gvBox.OptionsView.RowAutoHeight = true;
            this.gvBox.OptionsView.ShowAutoFilterRow = true;
            this.gvBox.OptionsView.ShowFooter = true;
            this.gvBox.OptionsView.ShowGroupPanel = false;
            this.gvBox.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvBox_RowStyle);
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "P/O NO.";
            this.gridColumn20.FieldName = "OrderNumber";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderNumber", "Total {0} BOXs")});
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 0;
            this.gridColumn20.Width = 141;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "STORE";
            this.gridColumn5.FieldName = "StoreNumber";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "BOX NO";
            this.gridColumn4.FieldName = "BoxOfTotal";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // colIDDB
            // 
            this.colIDDB.Caption = "CID";
            this.colIDDB.FieldName = "ContainerId";
            this.colIDDB.Name = "colIDDB";
            this.colIDDB.OptionsColumn.AllowEdit = false;
            this.colIDDB.OptionsColumn.ReadOnly = true;
            this.colIDDB.Visible = true;
            this.colIDDB.VisibleIndex = 3;
            this.colIDDB.Width = 210;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "TOTAL QTY";
            this.gridColumn11.FieldName = "DigitalQuantity";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DigitalQuantity", "{0:0.##}")});
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            this.gridColumn11.Width = 101;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "QTY READ";
            this.gridColumn2.FieldName = "QtyRead";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyRead", "{0:0.##}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 110;
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
            this.tabPage3.Size = new System.Drawing.Size(1080, 318);
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
            this.gcUPC.Size = new System.Drawing.Size(1074, 312);
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
            // gridColumn19
            // 
            this.gridColumn19.Caption = "P/O NO.";
            this.gridColumn19.FieldName = "OrderNumber";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderNumber", "Total {0} SKU")});
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 0;
            this.gridColumn19.Width = 95;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "STORE";
            this.gridColumn17.FieldName = "StoreNumber";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "BOX NO";
            this.gridColumn3.FieldName = "BoxOfTotal";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 73;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "CID";
            this.gridColumn21.FieldName = "ContainerId";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.AllowEdit = false;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 3;
            this.gridColumn21.Width = 169;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "SKU";
            this.gridColumn7.FieldName = "ProductSku";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 135;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "UPC";
            this.gridColumn8.FieldName = "Upc";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            this.gridColumn8.Width = 154;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "DESCRIPTION";
            this.gridColumn9.FieldName = "Description";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            this.gridColumn9.Width = 296;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "TOTAL QTY";
            this.gridColumn10.FieldName = "DigitalQuantity";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DigitalQuantity", "{0:0.##}")});
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 7;
            this.gridColumn10.Width = 96;
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
            this.gridColumn22.VisibleIndex = 8;
            this.gridColumn22.Width = 106;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.inventoryList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1080, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read Tags";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gcTag);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1080, 318);
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
            this.gcTag.Size = new System.Drawing.Size(1071, 360);
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
            this.gridColumn13,
            this.gridColumn16,
            this.gridColumn23,
            this.gridColumn6});
            this.gvTag.GridControl = this.gcTag;
            this.gvTag.Name = "gvTag";
            this.gvTag.OptionsView.ColumnAutoWidth = false;
            this.gvTag.OptionsView.RowAutoHeight = true;
            this.gvTag.OptionsView.ShowAutoFilterRow = true;
            this.gvTag.OptionsView.ShowFooter = true;
            this.gvTag.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "EPC ID";
            this.gridColumn18.FieldName = "EPC";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.AllowEdit = false;
            this.gridColumn18.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "EPC", "Total {0} EPC")});
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 0;
            this.gridColumn18.Width = 187;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Box ID";
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
            this.gridColumn14.Caption = "SKU";
            this.gridColumn14.FieldName = "ProductSku";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 1;
            this.gridColumn14.Width = 122;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "UPC";
            this.gridColumn15.FieldName = "Upc";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 2;
            this.gridColumn15.Width = 172;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Location";
            this.gridColumn13.FieldName = "LocationName";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.OptionsColumn.ReadOnly = true;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 6;
            this.gridColumn13.Width = 76;
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
            this.gridColumn23.VisibleIndex = 7;
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
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            this.repositoryItemPictureEdit2.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.repositoryItemPictureEdit2.ZoomAccelerationFactor = 1D;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(577, 102);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(445, 18);
            this.progressBar1.TabIndex = 30;
            this.progressBar1.Visible = false;
            // 
            // bntClear
            // 
            this.bntClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bntClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bntClear.Location = new System.Drawing.Point(397, 96);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(190, 54);
            this.bntClear.TabIndex = 31;
            this.bntClear.Text = "Clear";
            this.bntClear.UseVisualStyleBackColor = false;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // btnLoadPO
            // 
            this.btnLoadPO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLoadPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoadPO.Location = new System.Drawing.Point(5, 96);
            this.btnLoadPO.Name = "btnLoadPO";
            this.btnLoadPO.Size = new System.Drawing.Size(190, 54);
            this.btnLoadPO.TabIndex = 31;
            this.btnLoadPO.Text = "Load P/O";
            this.btnLoadPO.UseVisualStyleBackColor = false;
            this.btnLoadPO.Click += new System.EventHandler(this.btnLoadPO_Click);
            // 
            // cboVendor
            // 
            this.cboVendor.Location = new System.Drawing.Point(129, 25);
            this.cboVendor.Name = "cboVendor";
            this.cboVendor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cboVendor.Properties.Appearance.Options.UseFont = true;
            this.cboVendor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboVendor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Vendor")});
            this.cboVendor.Properties.NullText = "";
            this.cboVendor.Size = new System.Drawing.Size(238, 26);
            this.cboVendor.TabIndex = 32;
            this.cboVendor.EditValueChanged += new System.EventHandler(this.cboVendor_EditValueChanged);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(31, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 28);
            this.label14.TabIndex = 25;
            this.label14.Text = "Vendor : ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(4, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 28);
            this.label15.TabIndex = 25;
            this.label15.Text = "Booking No. : ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboBookingNo
            // 
            this.cboBookingNo.Location = new System.Drawing.Point(129, 57);
            this.cboBookingNo.Name = "cboBookingNo";
            this.cboBookingNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cboBookingNo.Properties.Appearance.Options.UseFont = true;
            this.cboBookingNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBookingNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BookingNumber", "Booking No.")});
            this.cboBookingNo.Properties.NullText = "";
            this.cboBookingNo.Size = new System.Drawing.Size(238, 26);
            this.cboBookingNo.TabIndex = 32;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // frmAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1101, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboBookingNo);
            this.Controls.Add(this.cboVendor);
            this.Controls.Add(this.btnLoadPO);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.bntClear);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.clearReports_CB);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.readButton);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(16, 250);
            this.Name = "frmAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RFID Demo DC Receive";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppForm_FormClosing);
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.ClientSizeChanged += new System.EventHandler(this.AppForm_ClientSizeChanged);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gpiStateGB.ResumeLayout(false);
            this.gpiStateGB.PerformLayout();
            this.transmitPowerGB.ResumeLayout(false);
            this.transmitPowerGB.PerformLayout();
            this.dataContextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPic)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVendor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBookingNo.Properties)).EndInit();
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
        private System.Windows.Forms.Button readButton;
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
        private System.Windows.Forms.Label totalTagValueLabel;
        private System.Windows.Forms.Label totalTagLabel;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.CheckBox clearReports_CB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotalBox;
        private System.Windows.Forms.Label lblTotalSKU;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
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
        private System.Windows.Forms.ProgressBar progressBar1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfBox;
        private System.Windows.Forms.Label lblTotalUPC;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private System.Windows.Forms.TabPage tabPage5;
        private DevExpress.XtraGrid.GridControl gcPO;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPO;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit3;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.Button btnLoadPO;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private DevExpress.XtraEditors.LookUpEdit cboVendor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.LookUpEdit cboBookingNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}