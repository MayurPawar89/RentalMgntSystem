using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGRentalMgntSystem
{
    class PartyMaster
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public PartyMaster()
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

        ~PartyMaster()
        {
            Dispose(false);
        }
        #endregion

        #region "Properties"
        public Int64 nPartyID { get; set; }
        public Int64 nPartyTypeID { get; set; }
        public string sPartyName { get; set; }
        public string sPartyCode { get; set; }
        public string sPartyAbbrivation { get; set; }
        public string sAddressLine1 { get; set; }
        public string sAddressLine2 { get; set; }
        public string sCity { get; set; }
        public string sState { get; set; }
        public string sCountry { get; set; }
        public string sPincode { get; set; }
        public string sEmail { get; set; }
        public string sFax { get; set; }
        public string sAllPhoneNo { get; set; }

        public string sBillToAddressLine1 { get; set; }
        public string sBillToAddressLine2 { get; set; }
        public string sBillToPincode { get; set; }

        public string sShipToAddressLine1 { get; set; }
        public string sShipToAddressLine2 { get; set; }
        public string sShipToPincode { get; set; }
        public string sGSTNo { get; set; }
        public string sPANNo { get; set; }
        public string sTANNo { get; set; }
        #endregion

        #region "Method"
        public Int64 InsertUpdatePartyMaster()
        {
            Int64 _nPartyID = 0;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            Object objValue = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nPartyID", this.nPartyID, ParameterDirection.InputOutput, SqlDbType.BigInt);
                oDBParameter.Add("@sPartyCode", this.sPartyCode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPartyName", this.sPartyName, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPartyAbbrivation", this.sPartyAbbrivation, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@nPartyTypeID", this.nPartyTypeID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@sAddressLine1", this.sAddressLine1, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAddressLine2", this.sAddressLine2, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCity", this.sCity, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sState", this.sState, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPincode", this.sPincode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCountry", this.sCountry, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sEmail", this.sEmail, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sFax", this.sFax, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAllPhoneNo", this.sAllPhoneNo, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sBillToAddressLine1", this.sBillToAddressLine1, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sBillToAddressLine2", this.sBillToAddressLine1, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sBillToPincode", this.sBillToAddressLine1, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sShipToAddressLine1", this.sShipToAddressLine1, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sShipToAddressLine2", this.sShipToAddressLine1, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sShipToPincode", this.sShipToPincode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sGSTNO", this.sGSTNo, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPANNO", this.sPANNo, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sTANNO", this.sTANNo, ParameterDirection.Input, SqlDbType.VarChar);

                
                oDBAccess.OpenConnection(false);
                oDBAccess.Execute("lgsp_INUP_PartyMaster", oDBParameter, out objValue);
                oDBAccess.CloseConnection(false);
                if (objValue != null)
                {
                    _nPartyID = Convert.ToInt64(objValue);
                }
            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(false);
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                if (oDBAccess!=null)
                {
                    oDBAccess.Dispose();
                    oDBAccess = null;
                }
                if (oDBParameter!=null)
                {
                    oDBParameter.Dispose();
                    oDBParameter = null;
                }
            }

            return _nPartyID;
        }

        public DataTable GetPartyInformation(Int64 nPartyID)
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
                oDBParameter.Add("@nPartyID", nPartyID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_PartyDetails", oDBParameter, out _dt);
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

        public DataTable GetPartylist(Int64 nPartyID)
        {
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataTable _dt = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nPartyID", nPartyID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_PartyListDetails", oDBParameter, out _dt);
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
