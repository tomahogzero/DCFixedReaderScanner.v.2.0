using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Symbol.RFID3;

namespace CS_RFID3_Host_Sample1
{
    public partial class frmRFIDScan : Form
    {
        private frmAppForm m_AppForm;

        public frmRFIDScan(frmAppForm appForm)
        {
            InitializeComponent();
            m_AppForm = appForm;
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
            }
        }
    }
}
