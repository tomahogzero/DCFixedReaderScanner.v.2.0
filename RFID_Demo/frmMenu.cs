using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCRFIDReader
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.Text = "RFID DC Receive v." + Application.ProductVersion.ToString();

            if (aconfig.AutoStart() == "1")
            {
                AutoStart();
            }
        }

        private void btnGate_Click(object sender, EventArgs e)
        {
            frmGate fGate = new frmGate();
            fGate.StartPosition = FormStartPosition.CenterScreen;
            fGate.ShowDialog();
        }

        private void btnReaderDevice_Click(object sender, EventArgs e)
        {
            frmDevice fDevice = new frmDevice();
            fDevice.StartPosition = FormStartPosition.CenterScreen;
            fDevice.ShowDialog();
        }

        private void btnSettingDeviceToGate_Click(object sender, EventArgs e)
        {
            frmGateDeviceSetting fGateDeviceSetting = new frmGateDeviceSetting();
            fGateDeviceSetting.StartPosition = FormStartPosition.CenterScreen;
            fGateDeviceSetting.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReaderAutoScan_Click(object sender, EventArgs e)
        {
            frmReaderAutoScan fReaderAutoScan = new frmReaderAutoScan();
            fReaderAutoScan.StartPosition = FormStartPosition.CenterScreen;
            fReaderAutoScan.Show();
        }

        private void AutoStart()
        {
            DataSet ds = Device.GetDataSet();

            try
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if ((bool)dr["enable"] == true)
                    {
                        frmAppForm fAppForm = new frmAppForm();
                        fAppForm.deviceid = dr["Id"].ToString();
                        fAppForm.deviceip = dr["IPAddress"].ToString();
                        fAppForm.deviceport = dr["Port"].ToString();
                        fAppForm.Show();
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void mnuShow_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void frmMenu_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                //this.notifyIcon1.ShowBalloonTip(100, "Notify Message", "Please click for see more detail..", ToolTipIcon.Info);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
