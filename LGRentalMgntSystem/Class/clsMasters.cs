using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGRentalMgntSystem.Class
{
    class clsMasters
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public clsMasters()
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

        ~clsMasters()
        {
            Dispose(false);
        }
        #endregion
        public Int64 nMasterID { get; set; }
        public string sMasterName { get; set; }
        public Int64 nMasterMainID { get; set; }
        public MasterType MasterType { get; set; }


        public Int64 InsertUpdateMaster()
        {
            Int64 nMasterID = 0;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            Object objValue = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nMasterID", this.nMasterID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@sMasterName", this.sMasterName, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@nMasterMainID", this.nMasterMainID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nMasterType", this.MasterType.GetHashCode(), ParameterDirection.Input, SqlDbType.Int);
                oDBParameter.Add("@nReturnID", 0, ParameterDirection.InputOutput, SqlDbType.Int);


                oDBAccess.OpenConnection(false);
                oDBAccess.Execute("lgsp_INUP_Masters", oDBParameter,out objValue);
                oDBAccess.CloseConnection(false);
                if (objValue != null)
                {
                    nMasterID = Convert.ToInt64(objValue);
                }
            }
            catch (Exception)
            {
            }

            return nMasterID;
        }

        public int DeleteMaster()
        {
            int nMasterID = 0;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            Object objValue = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nMasterID", this.nMasterID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nMasterType", this.MasterType.GetHashCode(), ParameterDirection.Input, SqlDbType.Int);
                oDBParameter.Add("@nReturnID", 0, ParameterDirection.InputOutput, SqlDbType.Int);


                oDBAccess.OpenConnection(false);
                oDBAccess.Execute("lgsp_Delete_Masters", oDBParameter, out objValue);
                oDBAccess.CloseConnection(false);
                if (objValue != null)
                {
                    nMasterID = Convert.ToInt32(objValue);
                }
            }
            catch (Exception)
            {
            }

            return nMasterID;
        }

        public DataTable GetAssetMainMasterType(Int32 nAssetType=0)
        {
            DataTable dt = null;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nAssetType", nAssetType, ParameterDirection.Input, SqlDbType.VarChar);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_getAssetMasterList", oDBParameter, out dt);
                oDBAccess.CloseConnection(false);

            }
            catch (Exception)
            {
            }
            return dt;
        }
        public DataTable GetMasterTypeData(Int32 nMasterType)
        {
            DataTable dt = null;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nMasterType", nMasterType, ParameterDirection.Input, SqlDbType.VarChar);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_AllMastersData", oDBParameter, out dt);
                oDBAccess.CloseConnection(false);

            }
            catch (Exception)
            {
            }
            return dt;
        }
    }
}
