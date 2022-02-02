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
    public partial class frmGate : Form
    {
        string id = ""; 
        public frmGate()
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
            if (txtGateNumber.Text.Trim() == "")
            {
                MessageBox.Show("กรุณาป้อน GateNumber ด้วย", "Gate");
                txtGateNumber.Focus();
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
            if (MessageBox.Show("คุณต้องการลบข้อมูลนี้หรือไม่?", "Gate", MessageBoxButtons.YesNo) == DialogResult.No) return;

            if (txtGateNumber.Text.Trim() == "")
            {
                MessageBox.Show("กรุณาป้อน GateNumber ด้วย", "Gate");
                txtGateNumber.Focus();
                return;
            }

            string res = delete(txtGateNumber.Text.Trim());
            if (res != "")
            {
                MessageBox.Show(res, "Gate");
                return;
            }

            loaddata();
            clear();
        }

        private void gvGate_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gvGate.GetRowCellValue(gvGate.FocusedRowHandle, "Id") == null)
                    return;

                id = gvGate.GetRowCellValue(gvGate.FocusedRowHandle, "Id").ToString();
                txtGateNumber.Text = gvGate.GetRowCellValue(gvGate.FocusedRowHandle, "GateNumber").ToString();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Gate");
            }
        }
    }
}
