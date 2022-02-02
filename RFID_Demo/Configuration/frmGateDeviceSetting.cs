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
    public partial class frmGateDeviceSetting : Form
    {
        string id = "";
        public frmGateDeviceSetting()
        {
            InitializeComponent();
        }

        private void frmGate_Load(object sender, EventArgs e)
        {
            loadGate();
            loadDevice();
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
            if (cboGateNumber.EditValue == null)
            {
                MessageBox.Show("กรุณาเลือก Gate Number ด้วย", this.Text);
                cboDevice.Focus();
                return;
            }

            if (cboDevice.EditValue == null)
            {
                MessageBox.Show("กรุณาเลือก Device IP ด้วย", this.Text);
                cboDevice.Focus();
                return;
            }

            if (cboAntenna.Text == "")
            {
                MessageBox.Show("กรุณาเลือก Antenna ด้วย", this.Text);
                cboAntenna.Focus();
                return;
            }

            string res = save();
            if (res != "")
            {
                MessageBox.Show(res,this.Text);
                return;
            }

            loaddata();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการลบข้อมูลนี้หรือไม่?", this.Text, MessageBoxButtons.YesNo) == DialogResult.No) return;

            if (cboGateNumber.EditValue == null)
            {
                MessageBox.Show("กรุณาเลือก Gate Number ด้วย", this.Text);
                cboDevice.Focus();
                return;
            }

            if (cboDevice.EditValue == null)
            {
                MessageBox.Show("กรุณาเลือก Device IP ด้วย", this.Text);
                cboDevice.Focus();
                return;
            }

            if (cboAntenna.Text == "")
            {
                MessageBox.Show("กรุณาเลือก Antenna ด้วย", this.Text);
                cboAntenna.Focus();
                return;
            }

            string res = delete();
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
                if (gvDevice.GetRowCellValue(gvDevice.FocusedRowHandle, "GateNumber") == null)
                    return;

                cboGateNumber.EditValue = gvDevice.GetRowCellValue(gvDevice.FocusedRowHandle, "GateNumber").ToString();
                cboDevice.EditValue = gvDevice.GetRowCellValue(gvDevice.FocusedRowHandle, "ReaderDeviceId").ToString();
                cboAntenna.EditValue = gvDevice.GetRowCellValue(gvDevice.FocusedRowHandle, "Antenna").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }
    }
}
