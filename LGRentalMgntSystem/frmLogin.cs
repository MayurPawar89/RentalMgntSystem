using LGRentalMgntSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGRentalMgntSystem
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public string sMessageboxCaption =string.Empty;
        public frmLogin()
        {
            InitializeComponent();
            //txtUsername.Text = "admin";
            //txtPassword.Text = "admin123";
            sMessageboxCaption = System.Configuration.ConfigurationManager.AppSettings["MessageboxCaption"];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text.Trim()=="")
                {
                    MessageBox.Show("Please enter username.",sMessageboxCaption,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtUsername.Focus();
                    return;
                }
                else if (txtPassword.Text.Trim()=="")
                {
                    MessageBox.Show("Please enter password.", sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                    return;
                }
                string sUserName = txtUsername.Text.Trim();
                string sTestPassword = clsEncryption.EncryptToBase64String(txtPassword.Text.Trim());
                string sPassword = txtPassword.Text.Trim();

                UserMaster clsUserMaster = new UserMaster();
                bool bIsUserValid=clsUserMaster.Login(sUserName,sPassword);
                if (bIsUserValid)
                {
                    clsGlobal.LoginUserName = clsUserMaster.sUserName;
                    clsGlobal.UserDesignation = clsUserMaster.sUserDesignation;
                    clsGlobal.UserID = clsUserMaster.nUserID;
                    this.Hide();
                    frmDashboard frmMain = new frmDashboard();
                    DialogResult dgResult= frmMain.ShowDialog();
                    if (dgResult==DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("User is not valid. Please check user name and Password.", sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Clear();
                    return;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.ToString(), sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
