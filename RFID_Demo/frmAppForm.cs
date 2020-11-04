using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Symbol.RFID3;
using System.Threading.Tasks;

namespace CS_RFID3_Host_Sample1
{
    public partial class frmAppForm : Form
    {
        internal RFIDReader m_ReaderAPI;
        internal bool m_IsConnected;
        internal ConnectionForm m_ConnectionForm;
        internal ReadForm m_ReadForm;
        internal WriteForm m_WriteForm;
        internal LockForm m_LockForm;
        internal KillForm m_KillForm;
        internal BlockEraseForm m_BlockEraseForm;
        internal AccessOperationResult m_AccessOpResult;

        internal string m_SelectedTagID = null;

        private delegate void UpdateStatus(Events.StatusEventData eventData);
        private UpdateStatus m_UpdateStatusHandler = null;
        private delegate void UpdateRead(Events.ReadEventData eventData);
        private UpdateRead m_UpdateReadHandler = null;
        private TagData m_ReadTag = null;
        private Hashtable m_TagTable;
        private Button button1;
        private uint m_TagTotalCount;

        public DataSet dsTag;
        public DataSet dsBox;
        public DataSet dsProduct;
        public DataSet dsPO;

        public string dbserver = "";
        public string dbname = "";
        public string uid = "";
        public string pwd = "";
        public bool reading = false;
        public bool internal_cal = false;

        internal class AccessOperationResult
        {
            public RFIDResults m_Result;
            public String m_VendorMessage;
            public String m_StatusDescription;
            public ACCESS_OPERATION_CODE m_OpCode;

            public AccessOperationResult()
            {
                m_Result = RFIDResults.RFID_NO_ACCESS_IN_PROGRESS;
                m_OpCode = ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ;
            }
        }

        public frmAppForm()
        {
            InitializeComponent();
            m_ReadTag = new Symbol.RFID3.TagData();
            m_UpdateStatusHandler = new UpdateStatus(myUpdateStatus);
            m_UpdateReadHandler = new UpdateRead(myUpdateRead);
            m_ConnectionForm = new ConnectionForm(this);
            m_ReadForm = new ReadForm(this);
            m_TagTable = new Hashtable();
            m_AccessOpResult = new AccessOperationResult();
            m_IsConnected = false;
            m_TagTotalCount = 0;

            dbValues.dbserver = "server.tesco.kaewsai.net";// System.Configuration.ConfigurationManager.AppSettings["db_servername"].Trim();
            dbValues.dbname = "ApplicationDb";// System.Configuration.ConfigurationManager.AppSettings["db_databasename"].Trim();
            dbValues.uid = "developer";//System.Configuration.ConfigurationManager.AppSettings["db_uid"].Trim();
            dbValues.pwd = "f2Kfec9#c&wvx6gtweaJPrne";//System.Configuration.ConfigurationManager.AppSettings["db_pwd"].Trim();

            //load_tags();
        }

        private void myUpdateStatus(Events.StatusEventData eventData)
        {
            switch (eventData.StatusEventType)
            {
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.INVENTORY_START_EVENT:
                    functionCallStatusLabel.Text = "Inventory started";
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.INVENTORY_STOP_EVENT:
                    functionCallStatusLabel.Text = "Inventory stopped";
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ACCESS_START_EVENT:
                    functionCallStatusLabel.Text = "Access Operation started";
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ACCESS_STOP_EVENT:
                    functionCallStatusLabel.Text = "Access Operation stopped";

                    if (this.m_SelectedTagID == string.Empty)
                    {
                        uint successCount, failureCount;
                        successCount = failureCount = 0;
                        m_ReaderAPI.Actions.TagAccess.GetLastAccessResult(ref successCount, ref failureCount);
                        functionCallStatusLabel.Text = "Access completed - Success Count: " + successCount.ToString()
                            + ", Failure Count: " + failureCount.ToString();
                    }
                    resetButtonState();
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.BUFFER_FULL_WARNING_EVENT:
                    functionCallStatusLabel.Text = " Buffer full warning";
                    myUpdateRead(null);
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.BUFFER_FULL_EVENT:
                    functionCallStatusLabel.Text = "Buffer full";
                    myUpdateRead(null);
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.DISCONNECTION_EVENT:
                    functionCallStatusLabel.Text = "Disconnection Event " + eventData.DisconnectionEventData.DisconnectEventInfo.ToString();
                    connectBackgroundWorker.RunWorkerAsync("Disconnect");
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ANTENNA_EVENT:
                    functionCallStatusLabel.Text = "Antenna Status Update";
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.READER_EXCEPTION_EVENT:
                    functionCallStatusLabel.Text = "Reader ExceptionEvent " + eventData.ReaderExceptionEventData.ReaderExceptionEventInfo;
                    break;
                default:
                    break;
            }
        }

        private void myUpdateRead(Events.ReadEventData eventData)
        {
            int index = 0;
            ListViewItem item;

            Symbol.RFID3.TagData[] tagData = m_ReaderAPI.Actions.GetReadTags(1000);
            if (tagData != null)
            {
                for (int nIndex = 0; nIndex < tagData.Length; nIndex++)
                {
                    if (tagData[nIndex].OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_NONE ||
                        (tagData[nIndex].OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ &&
                        tagData[nIndex].OpStatus == ACCESS_OPERATION_STATUS.ACCESS_SUCCESS))
                    {
                        Symbol.RFID3.TagData tag = tagData[nIndex];
                        string tagID = tag.TagID;
                        bool isFound = false;

                        lock (m_TagTable.SyncRoot)
                        {
                            isFound = m_TagTable.ContainsKey(tagID);
                            if (!isFound)
                            {
                                tagID += ((uint)tag.MemoryBank + tag.MemoryBankDataOffset);
                                isFound = m_TagTable.ContainsKey(tagID);
                            }
                        }

                        if (isFound)
                        {
                            uint count = 0;
                            item = (ListViewItem)m_TagTable[tagID];
                            try
                            {
                                count = uint.Parse(item.SubItems[2].Text) + tagData[nIndex].TagSeenCount;
                                m_TagTotalCount += tagData[nIndex].TagSeenCount;
                            }
                            catch (FormatException fe)
                            {
                                functionCallStatusLabel.Text = fe.Message;
                                break;
                            }
                            item.SubItems[1].Text = tag.AntennaID.ToString();
                            item.SubItems[2].Text = count.ToString();
                            item.SubItems[3].Text = tag.PeakRSSI.ToString();

                            string memoryBank = tag.MemoryBank.ToString();
                            index = memoryBank.LastIndexOf('_');
                            if (index != -1)
                            {
                                memoryBank = memoryBank.Substring(index + 1);
                            }
                            if (tag.MemoryBankData.Length > 0 && !memoryBank.Equals(item.SubItems[5].Text))
                            {
                                item.SubItems[5].Text = tag.MemoryBankData;
                                item.SubItems[6].Text = memoryBank;
                                item.SubItems[7].Text = tag.MemoryBankDataOffset.ToString();

                                lock (m_TagTable.SyncRoot)
                                {
                                    m_TagTable.Remove(tagID);
                                    m_TagTable.Add(tag.TagID + tag.MemoryBank.ToString()
                                        + tag.MemoryBankDataOffset.ToString(), item);
                                }
                            }
                        }
                        else
                        {
                                                        
                            item = new ListViewItem(tag.TagID);
                            ListViewItem.ListViewSubItem subItem;

                            subItem = new ListViewItem.ListViewSubItem(item, tag.AntennaID.ToString());
                            item.SubItems.Add(subItem);

                            subItem = new ListViewItem.ListViewSubItem(item, tag.TagSeenCount.ToString());
                            m_TagTotalCount += tag.TagSeenCount;
                            item.SubItems.Add(subItem);

                            subItem = new ListViewItem.ListViewSubItem(item, tag.PeakRSSI.ToString());
                            item.SubItems.Add(subItem);
                            subItem = new ListViewItem.ListViewSubItem(item, tag.PC.ToString("X"));
                            item.SubItems.Add(subItem);

                            subItem = new ListViewItem.ListViewSubItem(item, "");
                            item.SubItems.Add(subItem);
                            subItem = new ListViewItem.ListViewSubItem(item, "");
                            item.SubItems.Add(subItem);
                            subItem = new ListViewItem.ListViewSubItem(item, "");
                            item.SubItems.Add(subItem);

                            subItem = new ListViewItem.ListViewSubItem(item, "");
                            item.SubItems.Add(subItem);

                            inventoryList.BeginUpdate();
                            inventoryList.Items.Add(item);
                            inventoryList.EndUpdate();

                            lock (m_TagTable.SyncRoot)
                            {
                                m_TagTable.Add(tagID, item);
                            }

                            re_update_sku2(tag.TagID);
                        }
                    }
                }
                totalTagValueLabel.Text = m_TagTable.Count + "(" + m_TagTotalCount + ")";
            }
        }

        private void Events_ReadNotify(object sender, Events.ReadEventArgs readEventArgs)
        {
            try
            {
                this.Invoke(m_UpdateReadHandler, new object[] { readEventArgs.ReadEventData });
            }
            catch (Exception)
            {

            }
        }

        public void Events_StatusNotify(object sender, Events.StatusEventArgs statusEventArgs)
        {
            try
            {
                this.Invoke(m_UpdateStatusHandler, new object[] { statusEventArgs.StatusEventData });
            }
            catch (Exception)
            {
            }
        }

        private void accessBackgroundWorker_DoWork(object sender, DoWorkEventArgs accessEvent)
        {
            try
            {
                m_AccessOpResult.m_OpCode = (ACCESS_OPERATION_CODE)accessEvent.Argument;
                m_AccessOpResult.m_Result = RFIDResults.RFID_API_SUCCESS;

                if ((ACCESS_OPERATION_CODE)accessEvent.Argument == ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ)
                {
                    if (m_SelectedTagID != String.Empty)
                    {
                        m_ReadTag = m_ReaderAPI.Actions.TagAccess.ReadWait(
                        m_SelectedTagID, m_ReadForm.m_ReadParams, null);
                    }
                    else
                    {
                        functionCallStatusLabel.Text = "Enter Tag-Id";
                    }
                }
                else if ((ACCESS_OPERATION_CODE)accessEvent.Argument == ACCESS_OPERATION_CODE.ACCESS_OPERATION_WRITE)
                {
                    if (m_SelectedTagID != String.Empty)
                    {
                        m_ReaderAPI.Actions.TagAccess.WriteWait(
                            m_SelectedTagID, m_WriteForm.m_WriteParams, null);
                    }
                    else
                    {
                        functionCallStatusLabel.Text = "Enter Tag-Id";
                    }
                }
                else if ((ACCESS_OPERATION_CODE)accessEvent.Argument == ACCESS_OPERATION_CODE.ACCESS_OPERATION_LOCK)
                {
                    if (m_SelectedTagID != String.Empty)
                    {
                        m_ReaderAPI.Actions.TagAccess.LockWait(
                            m_SelectedTagID, m_LockForm.m_LockParams, null);
                    }
                    else
                    {
                        functionCallStatusLabel.Text = "Enter Tag-Id";
                    }
                }
                else if ((ACCESS_OPERATION_CODE)accessEvent.Argument == ACCESS_OPERATION_CODE.ACCESS_OPERATION_KILL)
                {
                    if (m_SelectedTagID != String.Empty)
                    {
                        m_ReaderAPI.Actions.TagAccess.KillWait(
                            m_SelectedTagID, m_KillForm.m_KillParams, null);
                    }
                }
                else if ((ACCESS_OPERATION_CODE)accessEvent.Argument == ACCESS_OPERATION_CODE.ACCESS_OPERATION_BLOCK_ERASE)
                {
                    if (m_SelectedTagID != String.Empty)
                    {
                        m_ReaderAPI.Actions.TagAccess.BlockEraseWait(
                            m_SelectedTagID, m_BlockEraseForm.m_BlockEraseParams, null);
                    }
                    else
                    {
                        functionCallStatusLabel.Text = "Enter Tag-Id";
                    }
                }
            }
            catch (OperationFailureException ofe)
            {
                m_AccessOpResult.m_Result = ofe.Result;
                m_AccessOpResult.m_StatusDescription = ofe.StatusDescription;
                m_AccessOpResult.m_VendorMessage = ofe.VendorMessage;
            }
            catch (InvalidUsageException ex)
            {
                m_AccessOpResult.m_Result = RFIDResults.RFID_API_PARAM_ERROR;
                m_AccessOpResult.m_StatusDescription = ex.Info;
                m_AccessOpResult.m_VendorMessage = ex.VendorMessage;
            }
            accessEvent.Result = m_AccessOpResult;
        }

        private void accessBackgroundWorker_ProgressChanged(object sender,
            ProgressChangedEventArgs pce)
        {

        }

        private void accessBackgroundWorker_RunWorkerCompleted(object sender,
            RunWorkerCompletedEventArgs accessEvents)
        {
            int index = 0;
            if (accessEvents.Error != null)
            {
                functionCallStatusLabel.Text = accessEvents.Error.Message;
            }
            else
            {
                // Handle AccessWait Operations              
                AccessOperationResult accessOpResult = (AccessOperationResult)accessEvents.Result;
                if (accessOpResult.m_Result == RFIDResults.RFID_API_SUCCESS)
                {
                    if (accessOpResult.m_OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ)
                    {
                        if (inventoryList.SelectedItems.Count > 0)
                        {
                            ListViewItem item = inventoryList.SelectedItems[0];
                            string tagID = m_ReadTag.TagID + m_ReadTag.MemoryBank.ToString()
                                + m_ReadTag.MemoryBankDataOffset.ToString();

                            if (item.SubItems[5].Text.Length > 0)
                            {
                                bool isFound = false;

                                // Search or add new one
                                lock (m_TagTable.SyncRoot)
                                {
                                    isFound = m_TagTable.ContainsKey(tagID);
                                }

                                if (!isFound)
                                {
                                    ListViewItem newItem = new ListViewItem(m_ReadTag.TagID);
                                    ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(newItem, m_ReadTag.AntennaID.ToString());
                                    newItem.SubItems.Add(subItem);
                                    subItem = new ListViewItem.ListViewSubItem(item, m_ReadTag.TagSeenCount.ToString());
                                    newItem.SubItems.Add(subItem);
                                    subItem = new ListViewItem.ListViewSubItem(item, m_ReadTag.PeakRSSI.ToString());
                                    newItem.SubItems.Add(subItem);
                                    subItem = new ListViewItem.ListViewSubItem(item, m_ReadTag.PC.ToString("X"));
                                    newItem.SubItems.Add(subItem);
                                    subItem = new ListViewItem.ListViewSubItem(item, m_ReadTag.MemoryBankData);
                                    newItem.SubItems.Add(subItem);

                                    string memoryBank = m_ReadTag.MemoryBank.ToString();
                                    index = memoryBank.LastIndexOf('_');
                                    if (index != -1)
                                    {
                                        memoryBank = memoryBank.Substring(index + 1);
                                    }

                                    subItem = new ListViewItem.ListViewSubItem(item, memoryBank);
                                    newItem.SubItems.Add(subItem);
                                    subItem = new ListViewItem.ListViewSubItem(item, m_ReadTag.MemoryBankDataOffset.ToString());
                                    newItem.SubItems.Add(subItem);

                                    inventoryList.BeginUpdate();
                                    inventoryList.Items.Add(newItem);
                                    inventoryList.EndUpdate();

                                    lock (m_TagTable.SyncRoot)
                                    {
                                        m_TagTable.Add(tagID, newItem);
                                    }
                                }
                            }
                            else
                            {
                                // Empty Memory Bank Slot
                                item.SubItems[5].Text = m_ReadTag.MemoryBankData;

                                string memoryBank = m_ReadForm.m_ReadParams.MemoryBank.ToString();
                                index = memoryBank.LastIndexOf('_');
                                if (index != -1)
                                {
                                    memoryBank = memoryBank.Substring(index + 1);
                                }
                                item.SubItems[6].Text = memoryBank;
                                item.SubItems[7].Text = m_ReadTag.MemoryBankDataOffset.ToString();

                                lock (m_TagTable.SyncRoot)
                                {
                                    if (m_ReadTag.TagID != null)
                                    {
                                        m_TagTable.Remove(m_ReadTag.TagID);
                                    }
                                    m_TagTable.Add(tagID, item);
                                }
                            }
                            this.m_ReadForm.ReadData_TB.Text = m_ReadTag.MemoryBankData;
                            functionCallStatusLabel.Text = "Read Succeed";
                        }
                    }
                    else if (accessOpResult.m_OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_WRITE)
                    {
                        functionCallStatusLabel.Text = "Write Succeed";
                    }
                    else if (accessOpResult.m_OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_LOCK)
                    {
                        functionCallStatusLabel.Text = "Lock Succeed";
                    }
                    else if (accessOpResult.m_OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_KILL)
                    {
                        functionCallStatusLabel.Text = "Kill Succeed";
                    }
                    else if (accessOpResult.m_OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_BLOCK_ERASE)
                    {
                        functionCallStatusLabel.Text = "BlockErase Succeed";
                    }
                }
                else
                {
                    functionCallStatusLabel.Text = accessOpResult.m_StatusDescription + " [" + accessOpResult.m_VendorMessage + "]";
                }
                resetButtonState();
            }
        }

        private void resetButtonState()
        {
            if (m_ReadForm != null)
                m_ReadForm.readButton.Enabled = true;
            if (m_WriteForm != null)
                m_WriteForm.writeButton.Enabled = true;
            if (m_LockForm != null)
                m_LockForm.lockButton.Enabled = true;
            if (m_KillForm != null)
                m_KillForm.killButton.Enabled = true;
            if (m_BlockEraseForm != null)
                m_BlockEraseForm.eraseButton.Enabled = true;
        }

        private void connectBackgroundWorker_DoWork(object sender, DoWorkEventArgs workEventArgs)
        {
            connectBackgroundWorker.ReportProgress(0, workEventArgs.Argument);

            if ((string)workEventArgs.Argument == "Connect")
            {
                m_ReaderAPI = new RFIDReader(m_ConnectionForm.IpText, uint.Parse(m_ConnectionForm.PortText), 0);

                try
                {
                    m_ReaderAPI.Connect();
                    m_IsConnected = true;
                    workEventArgs.Result = "Connect Succeed";

                }
                catch (OperationFailureException operationException)
                {
                    workEventArgs.Result = operationException.StatusDescription;
                }
                catch (Exception ex)
                {
                    workEventArgs.Result = ex.Message;
                }
            }
            else if ((string)workEventArgs.Argument == "Disconnect")
            {
                try
                {

                    m_ReaderAPI.Disconnect();
                    m_IsConnected = false;
                    workEventArgs.Result = "Disconnect Succeed";
                    m_ReaderAPI = null;

                }
                catch (OperationFailureException ofe)
                {
                    workEventArgs.Result = ofe.Result;
                }
            }

        }

        private void connectBackgroundWorker_ProgressChanged(object sender,
            ProgressChangedEventArgs progressEventArgs)
        {
            m_ConnectionForm.connectionButton.Enabled = false;
        }

        private void connectBackgroundWorker_RunWorkerCompleted(object sender,
            RunWorkerCompletedEventArgs connectEventArgs)
        {
            if (m_ConnectionForm.connectionButton.Text == "Connect")
            {
                if (connectEventArgs.Result.ToString() == "Connect Succeed")
                {
                    /*
                     *  UI Updates
                     */
                    m_ConnectionForm.connectionButton.Text = "Disconnect";
                    m_ConnectionForm.hostname_TB.Enabled = false;
                    m_ConnectionForm.port_TB.Enabled = false;
                    m_ConnectionForm.Close();
                    this.readButton.Enabled = true;
                    this.readButton.Text = "Start Reading";

                    /*
                     *  Events Registration
                     */
                    m_ReaderAPI.Events.ReadNotify += new Events.ReadNotifyHandler(Events_ReadNotify);
                    m_ReaderAPI.Events.AttachTagDataWithReadEvent = false;
                    m_ReaderAPI.Events.StatusNotify += new Events.StatusNotifyHandler(Events_StatusNotify);
                    m_ReaderAPI.Events.NotifyGPIEvent = true;
                    m_ReaderAPI.Events.NotifyBufferFullEvent = true;
                    m_ReaderAPI.Events.NotifyBufferFullWarningEvent = true;
                    m_ReaderAPI.Events.NotifyReaderDisconnectEvent = true;
                    m_ReaderAPI.Events.NotifyReaderExceptionEvent = true;
                    m_ReaderAPI.Events.NotifyAccessStartEvent = true;
                    m_ReaderAPI.Events.NotifyAccessStopEvent = true;
                    m_ReaderAPI.Events.NotifyInventoryStartEvent = true;
                    m_ReaderAPI.Events.NotifyInventoryStopEvent = true;

                    this.Text = "Connected to " + m_ConnectionForm.IpText;
                    this.connectionStatus.BackgroundImage =
                        global::CS_RFID3_Host_Sample1.Properties.Resources.connected;
                }
            }
            else if (m_ConnectionForm.connectionButton.Text == "Disconnect")
            {
                if (connectEventArgs.Result.ToString() == "Disconnect Succeed")
                {
                    this.Text = "CS_RFID3_Host_Sample1";
                    this.connectionStatus.BackgroundImage =
                        global::CS_RFID3_Host_Sample1.Properties.Resources.disconnected;

                    m_ConnectionForm.connectionButton.Text = "Connect";
                    m_ConnectionForm.hostname_TB.Enabled = true;
                    m_ConnectionForm.port_TB.Enabled = true;
                    this.readButton.Enabled = false;
                    this.readButton.Text = "Start Reading";

                }
            }
            functionCallStatusLabel.Text = connectEventArgs.Result.ToString();
            m_ConnectionForm.connectionButton.Enabled = true;
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            load_company();
            dsTag = QTags.get_epc("");
            dsBox = QTags.get_box("", "");
            dsProduct = QTags.get_product("", "");
            dsPO = QTags.get_po("", "");
            load_tags();
            //MessageBox.Show("load tag complete");
            //connectBackgroundWorker.RunWorkerAsync("Connect");        
        }

        private void load_tags()
        {
            gcTag.DataSource = dsTag;
            gcTag.DataMember = dsTag.Tables[0].TableName;

            gcBox.DataSource = dsBox;
            gcBox.DataMember = dsBox.Tables[0].TableName;

            gcUPC.DataSource = dsProduct;
            gcUPC.DataMember = dsProduct.Tables[0].TableName;

            gcPO.DataSource = dsPO;
            gcPO.DataMember = dsPO.Tables[0].TableName;
        }

        private void AppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (m_IsConnected)
                {
                    connectBackgroundWorker.RunWorkerAsync("Disconnect");
                }
                this.Dispose();
            }
            catch (Exception ex)
            {
                functionCallStatusLabel.Text = ex.Message;
            }
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_ConnectionForm.ShowDialog(this);
        }

        private void capabilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapabilitiesForm capabilitiesForm = new CapabilitiesForm(this);
            capabilitiesForm.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_IsConnected)
            {
                connectBackgroundWorker.RunWorkerAsync("Disconnect");
            }
            this.Dispose();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                m_ReadForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                functionCallStatusLabel.Text = "Read Form:" + ex.Message;
            }
        }

        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_WriteForm)
            {
                m_WriteForm = new WriteForm(this, false);
            }
            m_WriteForm.ShowDialog(this);
        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_LockForm)
            {
                m_LockForm = new LockForm(this);
            }
            m_LockForm.ShowDialog(this);
        }

        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_KillForm)
            {
                m_KillForm = new KillForm(this);
            }
            m_KillForm.ShowDialog(this);
        }

        private void blockWriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_WriteForm)
            {
                m_WriteForm = new WriteForm(this, true);
            }
            m_WriteForm.ShowDialog(this);
        }

        private void blockEraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_BlockEraseForm)
            {
                m_BlockEraseForm = new BlockEraseForm(this);
            }
            m_BlockEraseForm.ShowDialog(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpDialog = new HelpForm(this);
            if (helpDialog.ShowDialog(this) == DialogResult.Yes)
            {

            }
            helpDialog.Dispose();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_IsConnected)
                {
                    if (readButton.Text == "Start Reading")
                    {
                        //tabControl1.SelectedIndex = 0;
                        m_ReaderAPI.Actions.Inventory.Perform(null, null, null);

                        inventoryList.Items.Clear();
                        m_TagTable.Clear();
                        m_TagTotalCount = 0;

                        dsTag.Tables[0].Rows.Clear();

                        reading = true;

                        readButton.Text = "Stop Reading";

                        // timecount
                        TimeCount.set_start(ref dsPO);
                        timecount_start();
                                                
                        //update_ui();
                    }
                    else if (readButton.Text == "Stop Reading")
                    {
                        if (m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0)
                        {
                            m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence();
                        }
                        else
                        {
                            m_ReaderAPI.Actions.Inventory.Stop();
                        }

                        readButton.Text = "Start Reading";
                        //tabControl1.SelectedIndex = 1;

                        reading = false;
                        //re_update_sku();

                        // timecount
                        timecount_stop();
                    }
                }
                else
                {
                    functionCallStatusLabel.Text = "Please connect to a reader";
                }
            }
            catch (InvalidOperationException ioe)
            {
                functionCallStatusLabel.Text = ioe.Message;
            }
            catch (InvalidUsageException iue)
            {
                functionCallStatusLabel.Text = iue.Info;
            }
            catch (OperationFailureException ofe)
            {
                functionCallStatusLabel.Text = ofe.Result + ":" + ofe.StatusDescription;
            }
            catch (Exception ex)
            {
                functionCallStatusLabel.Text = ex.Message;
            }
        }

        void inventoryList_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataContextMenuStrip.Show(inventoryList, new Point(e.X, e.Y));
            }
        }

        private void tagDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TagDataForm tagDataForm = new TagDataForm(this);
            tagDataForm.ShowDialog(this);
        }

        private void readDataContextMenuItem_Click(object sender, EventArgs e)
        {
            m_ReadForm.ShowDialog(this);
        }

        private void writeDataContextMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_WriteForm)
            {
                m_WriteForm = new WriteForm(this, false);
            }
            m_WriteForm.ShowDialog(this);
        }

        private void lockDataContextMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_LockForm)
            {
                m_LockForm = new LockForm(this);
            }
            m_LockForm.ShowDialog(this);
        }

        private void killDataContextMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_KillForm)
            {
                m_KillForm = new KillForm(this);
            }
            m_KillForm.ShowDialog(this);
        }

        private void blockWriteDataContextMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_WriteForm)
            {
                m_WriteForm = new WriteForm(this, true);
            }
            m_WriteForm.ShowDialog(this);
        }

        private void blockEraseDataContextMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_BlockEraseForm)
            {
                m_BlockEraseForm = new BlockEraseForm(this);
            }
            m_BlockEraseForm.ShowDialog(this);
        }

        private void resetToFactoryDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_ReaderAPI.IsConnected)
                {
                    m_ReaderAPI.Config.ResetFactoryDefaults();
                }
            }
            catch (Exception ex)
            {
                functionCallStatusLabel.Text = ex.Message;
            }
        }

        private void clearReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.inventoryList.Items.Clear();
            this.m_TagTable.Clear();
        }

        private void clearReports_CB_CheckedChanged(object sender, EventArgs e)
        {
            this.totalTagValueLabel.Text = "0(0)";
            this.lblTotalBox.Text   = "0";
            this.lblTotalSKU.Text = "0";
            this.inventoryList.Items.Clear();
            this.m_TagTable.Clear();

            dsTag.Tables[0].Clear();
            dsBox.Tables[0].Clear();
            dsProduct.Tables[0].Clear();

            clearReports_CB.Checked = false;
        }

        private void AppForm_ClientSizeChanged(object sender, EventArgs e)
        {
            functionCallStatusLabel.Width = this.Width - 77;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void update_ui()
        {
            //if (this.InvokeRequired)
            //{
            //    this.Invoke(new Action(update_ui));
            //}
            //else {
                
            //}

            var t = Task.Run(() => {
                while (reading == true)
                {
                    if (internal_cal == false)
                    {
                        re_update_sku();
                    }
                }
            });
            t.Wait();
        }

        private void re_update_sku()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(re_update_sku));
            }
            else {
                internal_cal = true;
                for (int i = 0; i <= inventoryList.Items.Count - 1; i++)
                {
                    if (inventoryList.Items[i].SubItems[8].Text != "")
                    {
                        string tag = inventoryList.Items[i].SubItems[0].Text;
                        DataSet ds = QTags.get_epc(tag);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow dr = ds.Tables[0].Rows[0];
                            QTagsUpdate_EPC.add(ref dsTag, tag, dr["ProductSku"].ToString(), dr["Upc"].ToString(), dr["Description"].ToString(), dr["ContainerId"].ToString(), int.Parse(dr["Status"].ToString()), dr["location"].ToString(), dr["vendorid"].ToString());
                            QTagsUpdate.add_box(ref dsBox, dr["OrderNumber"].ToString(), dr["StoreNumber"].ToString(), dr["ContainerId"].ToString());
                            QTagsUpdate.add_product(ref dsProduct, dr["OrderNumber"].ToString(), dr["StoreNumber"].ToString(), dr["ContainerId"].ToString(), dr["ProductSku"].ToString());
                            QTagsUpdate.add_sl(ref dsPO, dr["OrderNumber"].ToString(), dr["StoreNumber"].ToString());
                        }

                        // mark read
                        inventoryList.Items[i].SubItems[8].Text = "1";
                        for (int c = 0; c <= inventoryList.Columns.Count - 1; c++)
                        {
                            inventoryList.Items[i].BackColor = Color.LightGreen;
                        }
                    }
                }
                lblTotalBox.Text = QTSumary.SumBox(ref dsBox);
                lblTotalSKU.Text = QTSumary.SumSKU(ref dsPO);
                internal_cal = false;

                this.Refresh();
            } 
        }

        private delegate void dg_re_update_sku2(string tags);

        private void re_update_sku2(string tags)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new dg_re_update_sku2(re_update_sku2),tags);
            }
            else
            {
                internal_cal = true;
                string tag = tags;// item.SubItems[0].Text;
                DataSet ds = QTags.get_epc(tag);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    QTagsUpdate_EPC.add(ref dsTag, tag, dr["ProductSku"].ToString(), dr["Upc"].ToString(), dr["Description"].ToString(), dr["ContainerId"].ToString(),int.Parse( dr["Status"].ToString()), dr["LocationName"].ToString(), dr["StoreNumber"].ToString());
                    QTagsUpdate.add_box(ref dsBox, dr["OrderNumber"].ToString(), dr["StoreNumber"].ToString(), dr["ContainerId"].ToString());
                    QTagsUpdate.add_product(ref dsProduct, dr["OrderNumber"].ToString(), dr["StoreNumber"].ToString(), dr["ContainerId"].ToString(), dr["ProductSku"].ToString());
                    QTagsUpdate.add_sl(ref dsPO, dr["OrderNumber"].ToString(), dr["StoreNumber"].ToString());
                }
                //else {
                //    QTagsUpdate_EPC.add(ref dsTag, tag,"","", "", "", 0,"", "");
                //}

                gcTag.Refresh();
                gcBox.Refresh();
                gcUPC.Refresh();
                gcPO.Refresh();
                // mark read
                //item.SubItems[8].Text = "1";
                //for (int c = 0; c <= inventoryList.Columns.Count - 1; c++)
                //{
                //    item.BackColor = Color.LightGreen;
                //}


                //item.BackColor = Color.LightGreen;


                lblNumberOfBox.Text = QTSumary.SumBox(ref dsBox);
                lblTotalUPC.Text = QTSumary.SumSKU(ref dsProduct);

                lblNumberOfBox.Refresh();
                lblTotalUPC.Refresh();
                totalTagValueLabel.Refresh();

                internal_cal = false;
            }
        }

        private void btnLoadPO_Click(object sender, EventArgs e)
        {
            try
            {
                dsTag = QTags.get_epc("");
                dsBox = QTags.get_box(cboVendor.EditValue.ToString(), cboBookingNo.EditValue.ToString());
                dsProduct = QTags.get_product(cboVendor.EditValue.ToString(), cboBookingNo.EditValue.ToString());
                dsPO = QTags.get_po(cboVendor.EditValue.ToString(), cboBookingNo.EditValue.ToString());
                load_tags();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }

        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            this.totalTagValueLabel.Text = "0(0)";
            this.lblTotalBox.Text = "0";
            this.lblTotalSKU.Text = "0";

            lblNumberOfBox.Text = "0/0";
            lblTotalUPC.Text = "0/0";

            this.inventoryList.Items.Clear();
            this.m_TagTable.Clear();

            dsTag.Tables[0].Clear();
            dsBox.Tables[0].Clear();
            dsProduct.Tables[0].Clear();
            dsPO.Tables[0].Clear();

            clearReports_CB.Checked = false;
        }

        private void clear_ui()
        {
            this.totalTagValueLabel.Text = "0(0)";
            this.lblTotalBox.Text = "0";
            this.lblTotalSKU.Text = "0";


            lblNumberOfBox.Text = "0/0";
            lblTotalUPC.Text = "0/0";

            this.inventoryList.Items.Clear();
            this.m_TagTable.Clear();

            dsTag.Tables[0].Clear();
            dsBox.Tables[0].Clear();
            dsProduct.Tables[0].Clear();
            dsPO.Tables[0].Clear();

            clearReports_CB.Checked = false;
        }

        private void load_company()
        {
            DataSet dst = QTags.get_company();
            cboVendor.Properties.DataSource = dst.Tables[0];
            cboVendor.Properties.ValueMember = "CompanyId";
            cboVendor.Properties.DisplayMember = "CompanyName";
                 
        }

        private void load_booking(string vendorid)
        {
            DataSet dst = QTags.get_booking(vendorid);
            cboBookingNo.Properties.DataSource = dst.Tables[0];
            cboBookingNo.Properties.ValueMember = "BookingNumber";
            cboBookingNo.Properties.DisplayMember = "BookingNumber";
        }

        private void gvPO_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            int QtyRead = Convert.ToInt32(gvPO.GetRowCellValue(e.RowHandle, "QtyRead"));
            int DigitalQuantity = Convert.ToInt32(gvPO.GetRowCellValue(e.RowHandle, "DigitalQuantity"));

            if (DigitalQuantity != QtyRead)
            {
                e.Appearance.BackColor = Color.LightYellow;
            }
            else
            {
                e.Appearance.BackColor = Color.LightGreen;
            }

            //Override any other formatting  
            e.HighPriority = true;
        }

        private void gvBox_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            int QtyRead = Convert.ToInt32(gvBox.GetRowCellValue(e.RowHandle, "QtyRead"));
            int DigitalQuantity = Convert.ToInt32(gvBox.GetRowCellValue(e.RowHandle, "DigitalQuantity"));

            if (DigitalQuantity != QtyRead)
            {
                e.Appearance.BackColor = Color.LightYellow;
            }
            else
            {
                e.Appearance.BackColor = Color.LightGreen;
            }

            //Override any other formatting  
            e.HighPriority = true;
        }

        private void gvUPC_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            int QtyRead = Convert.ToInt32(gvUPC.GetRowCellValue(e.RowHandle, "QtyRead"));
            int DigitalQuantity = Convert.ToInt32(gvUPC.GetRowCellValue(e.RowHandle, "DigitalQuantity"));

            if (DigitalQuantity != QtyRead)
            {
                e.Appearance.BackColor = Color.LightYellow;
            }
            else
            {
                e.Appearance.BackColor = Color.LightGreen;
            }

            //Override any other formatting  
            e.HighPriority = true;
        }

        private void cboVendor_EditValueChanged(object sender, EventArgs e)
        {
            if (cboVendor.EditValue == null)
            {
                load_booking("");
            }
            else {
                load_booking(cboVendor.EditValue.ToString());
            } 
        }

        private void update_time_count()
        {

        }

        private void timecount_start()
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void timecount_stop()
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (worker.CancellationPending == false) {
                TimeCount.update_time_count(ref dsPO);
                System.Threading.Thread.Sleep(1000);
            }

            e.Cancel = true;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            gcPO.Refresh();
        }
    }
}
