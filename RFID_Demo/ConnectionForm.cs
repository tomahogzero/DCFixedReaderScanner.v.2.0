using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Symbol.RFID3;

namespace DCRFIDReader
{
    public partial class ConnectionForm : Form
    {
        private frmAppForm m_AppForm;

        public ConnectionForm(frmAppForm appForm)
        {
            InitializeComponent();
            m_AppForm = appForm;
        }

        public string IpText
        {
            get
            {
                return hostname_TB.Text;
            }
        }

        public string PortText
        {
            get
            {
                return port_TB.Text;
            }
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_AppForm.connectBackgroundWorker.RunWorkerAsync(connectionButton.Text);
            }
            catch (Exception ex)
            {
                m_AppForm.functionCallStatusLabel.Text = ex.Message;
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", ""), "connectionButton_Click | " + ex.Message);
            }
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {

        }
    }
}