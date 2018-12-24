using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGRentalMgntSystem
{
    class GafferMaster
    {
         #region "Constructor & Distructor"
        private bool disposed = false;
        public GafferMaster()
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

        ~GafferMaster()
        {
            Dispose(false);
        }
        #endregion

        #region "Properties"
        public Int64 nGafferID { get; set; }
        public Int64 nGafferTypeID { get; set; }
        public string sGafferName { get; set; }
        public string sGafferCode { get; set; }
        public string sGafferAbbrivation { get; set; }
        public string sGafferGender { get; set; }
        public DateTime dtGafferDOB { get; set; }
        public string sGafferAge { get; set; }
        public string sAddressLine1 { get; set; }
        public string sAddressLine2 { get; set; }
        public string sCity { get; set; }
        public string sState { get; set; }
        public string sCountry { get; set; }
        public string sPincode { get; set; }
        public string sEmail { get; set; }
        public string sAllPhoneNo { get; set; }
        public string sUserName { get; set; }
        public string sPassword { get; set; }
        public string sPin { get; set; }
        #endregion

        #region "Method"
        public Int64 InsertUpdateGafferMaster()
        {
            Int64 _nGafferID = 0;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            Object objValue = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nGafferID", this.nGafferID, ParameterDirection.InputOutput, SqlDbType.BigInt);
                oDBParameter.Add("@sGafferCode", this.sGafferCode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sGafferName", this.sGafferName, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sGafferAbbrivation", this.sGafferAbbrivation, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sGender", this.sGafferGender, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@dtDOB", this.dtGafferDOB, ParameterDirection.Input, SqlDbType.DateTime);
                oDBParameter.Add("@sAge", this.sGafferAge, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAddressLine1", this.sAddressLine1, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAddressLine2", this.sAddressLine2, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCity", this.sCity, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sState", this.sState, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPincode", this.sPincode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCountry", this.sCountry, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sEmail", this.sEmail, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAllPhoneNo", this.sAllPhoneNo, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sUserName", this.sUserName, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPassword", this.sPassword, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPin", this.sPin, ParameterDirection.Input, SqlDbType.VarChar);

                oDBAccess.OpenConnection(false);
                oDBAccess.Execute("lgsp_INUP_GafferMaster", oDBParameter, out objValue);
                oDBAccess.CloseConnection(false);
                if (objValue != null)
                {
                    _nGafferID = Convert.ToInt64(objValue);
                }
            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(false);
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                if (oDBAccess != null)
                {
                    oDBAccess.Dispose();
                    oDBAccess = null;
                }
                if (oDBParameter != null)
                {
                    oDBParameter.Dispose();
                    oDBParameter = null;
                }
            }

            return _nGafferID;
        }

        public DataTable GetGafferInformation(Int64 nGafferID)
        {
            DataSet ds = null;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataTable _dt = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nGafferID",nGafferID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_GafferDetails", oDBParameter, out _dt);
                oDBAccess.CloseConnection(false);

            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(false);
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (oDBAccess != null)
                {
                    oDBAccess.Dispose();
                    oDBAccess = null;
                }
                if (oDBParameter != null)
                {
                    oDBParameter.Dispose();
                    oDBParameter = null;
                }
            }

            return _dt;
        }

        public DataTable GetGafferlist(Int64 nGafferID)
        {
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataTable _dt = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nGafferID", nGafferID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_GafferListDetails", oDBParameter, out _dt);
                oDBAccess.CloseConnection(false);

            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(false);
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (oDBAccess != null)
                {
                    oDBAccess.Dispose();
                    oDBAccess = null;
                }
                if (oDBParameter != null)
                {
                    oDBParameter.Dispose();
                    oDBParameter = null;
                }
            }

            return _dt;
        }
        #endregion
    }
}
