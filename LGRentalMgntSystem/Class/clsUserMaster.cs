using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGRentalMgntSystem.Class
{
    class UserMaster : IDisposable
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public UserMaster()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {

                }
            }
            disposed = true;
        }

        ~UserMaster()
        {
            Dispose(false);
        }
        #endregion

        #region "Properties"
        public Int64 nUserID { get; set; }
        public string sName { get; set; }
        public string sUserDesignation { get; set; }
        public string sAddressLine1 { get; set; }
        public string sAddressLine2 { get; set; }
        public string sCity { get; set; }
        public string sState { get; set; }
        public string sCountry { get; set; }
        public string sPincode { get; set; }
        public string sMobileNo { get; set; }
        public string sEmail { get; set; }
        public string sUserName { get; set; }
        public string sPassword { get; set; }
        public bool bIsActive { get; set; }

        #endregion

        #region Methods
        public  bool Login(string sUserName,string sPassword)
        {
            bool bIsValidUser = false;
            string sDecryptPassword = string.Empty;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataTable dt = new DataTable();
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@sUserName", sUserName, ParameterDirection.Input, SqlDbType.VarChar);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_getUserByUserName", oDBParameter, out dt);
                oDBAccess.CloseConnection(false);
                if (dt != null && dt.Rows.Count > 0)
                {
                    sDecryptPassword = clsEncryption.DecryptFromBase64String(Convert.ToString(dt.Rows[0]["sPassword"]));
                    if (sDecryptPassword==sPassword)
                    {
                        bIsValidUser = true;
                        this.nUserID = Convert.ToInt64(dt.Rows[0]["nUserID"]);
                        this.sName = Convert.ToString(dt.Rows[0]["sName"]);
                        this.sUserName = Convert.ToString(dt.Rows[0]["sUserName"]);
                        this.sUserDesignation = Convert.ToString(dt.Rows[0]["sUserDesignation"]);
                        this.bIsActive = Convert.ToBoolean(dt.Rows[0]["bIsActive"]); 
                    }
                }
            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(false);
                MessageBox.Show("Error: " + ex.ToString(), "Rental System LoginSP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return bIsValidUser;

        }

        #endregion
    }
}
