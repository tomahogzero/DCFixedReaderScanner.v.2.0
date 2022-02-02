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
    public partial class frmReaderAutoScan : Form
    {
        public frmReaderAutoScan()
        {
            InitializeComponent();
        }

        private void frmReaderAutoScan_Load(object sender, EventArgs e)
        {
            loadDevice();
        }

        private void loadDevice()
        {
            DataSet ds = Device.GetDataSet();
            gcDevice.DataSource = ds;
            gcDevice.DataMember = ds.Tables[0].TableName;
        }

        private void repBtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvDevice.GetRowCellValue(gvDevice.FocusedRowHandle, "Id") == null)
                    return;

                frmAppForm fAppForm = new frmAppForm();
                fAppForm.deviceid = gvDevice.GetRowCellValue(gvDevice.FocusedRowHandle, "Id").ToString();
                fAppForm.deviceip = gvDevice.GetRowCellValue(gvDevice.FocusedRowHandle, "IPAddress").ToString();
                fAppForm.deviceport = gvDevice.GetRowCellValue(gvDevice.FocusedRowHandle, "Port").ToString();
                fAppForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gate");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
