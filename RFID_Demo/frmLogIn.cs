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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            //dbValues.url_api_id = System.Configuration.ConfigurationManager.AppSettings["url_api_id"].Trim();
            //dbValues.url_api_app = System.Configuration.ConfigurationManager.AppSettings["url_api_app"].Trim();
            //txtUsername.Text = aconfig.api_username();
            //txtPassword.Text = aconfig.api_password();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string err = "";
            webAPI.Models.model_Res_Login ret = webAPI.WebAPI.Login(dbValues.url_api_id, txtUsername.Text.Trim(), txtPassword.Text.Trim(), ref dbValues.Cookies, ref err);

            if (ret != null)
            {
                dbValues.token = "Bearer " + ret.access_token;
                //MessageBox.Show("Log in Complete");

                //dbValues.companyid = QTags.get_companyid(txtUsername.Text.Trim());

                dbValues.username = txtUsername.Text.Trim();

                frmAppForm frm = new frmAppForm();
                frm.Show();
            }
            else {
                MessageBox.Show(err);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
