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
    public partial class frmDevice : Form
    {
        string id = ""; 
        public frmDevice()
        {
            InitializeComponent();
        }

        private void frmGate_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtIPAddress.Text.Trim() == "")
            {
                MessageBox.Show("กรุณาป้อน IP Address ด้วย", "Gate");
                txtIPAddress.Focus();
                return;
            }
            if (txtPort.Text.Trim() == "")
            {
                MessageBox.Show("กรุณาป้อน Port ด้วย", "Gate");
                txtPort.Focus();
                return;
            }

            string res = save();
            if (res != "") {
                MessageBox.Show(res, "Gate");
                return;
            }

            loaddata();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการลบข้อมูลนี้หรือไม่?", this.Text, MessageBoxButtons.YesNo) == DialogResult.No) return;

            if (id.Trim() == "")
            {
                MessageBox.Show("กรุณาเลือก รายการที่ต้องการลบข้อมูล", this.Text);
                txtIPAddress.Focus();
                return;
            }

            string res = delete(id);
            if (res != "")
            {
                MessageBox.Show(res, this.Text);
                return;
            }

            loaddata();
            clear();
        }

        private void gvGate_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gvDevice.GetRowCellValue(gvDevice.FocusedRowHandle, "Id") == null)
                    return;

                id = gvDevice.GetRowCellValue(gvDevice.FocusedRowHandle, "Id").ToString();
                txtIPAddress.Text = gvDevice.GetRowCellValue(gvDevice.FocusedRowHandle, "IPAddress").ToString();
                txtPort.Text = gvDevice.GetRowCellValue(gvDevice.FocusedRowHandle, "Port").ToString();
                chkEnable.Checked = (bool)gvDevice.GetRowCellValue(gvDevice.FocusedRowHandle, "enable");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,this.Text);
            }
        }
    }
}
