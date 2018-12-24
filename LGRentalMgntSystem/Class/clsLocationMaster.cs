using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGRentalMgntSystem
{
    class LocationMaster
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public LocationMaster()
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

        ~LocationMaster()
        {
            Dispose(false);
        }
        #endregion

        #region "Properties"
        public Int64 nLocationID { get; set; }
        public string sDescription { get; set; }
        public string sLocationCode { get; set; }
        public string sAddressLine1 { get; set; }
        public string sAddressLine2 { get; set; }
        public string sCity { get; set; }
        public string sState { get; set; }
        public string sCountry { get; set; }
        public string sPincode { get; set; }
        public string sVillageDistTown { get; set; }
        #endregion

        #region "Method"
        public Int64 InsertUpdateLocationMaster()
        {
            Int64 _nLocationID = 0;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            Object objValue = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nLocationID", this.nLocationID, ParameterDirection.InputOutput, SqlDbType.BigInt);
                oDBParameter.Add("@sDescription", this.sDescription, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sLocationCode", this.sLocationCode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAddressLine1", this.sAddressLine1, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAddressLine2", this.sAddressLine2, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCity", this.sCity, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sState", this.sState, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPincode", this.sPincode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCountry", this.sCountry, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sVillageDistTown", this.sVillageDistTown, ParameterDirection.Input, SqlDbType.VarChar);

                oDBAccess.OpenConnection(false);
                oDBAccess.Execute("lgsp_INUP_LocationMaster", oDBParameter, out objValue);
                oDBAccess.CloseConnection(false);
                if (objValue != null)
                {
                    _nLocationID = Convert.ToInt64(objValue);
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

            return _nLocationID;
        }

        public DataTable GetLocationInformation(Int64 nLocationID)
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
                oDBParameter.Add("@nLocationID", nLocationID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_LocationDetails", oDBParameter, out _dt);
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

        public DataTable GetLocationlist(Int64 nLocationID)
        {
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataTable _dt = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nLocationID", nLocationID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_LocationListDetails", oDBParameter, out _dt);
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
