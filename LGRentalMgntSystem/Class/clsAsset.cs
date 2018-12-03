using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGRentalMgntSystem.Class
{
    class AssetMaster:IDisposable
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public AssetMaster()
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

        ~AssetMaster()
        {
            Dispose(false);
        }
        #endregion

        #region "Properties"

        public Int64 nAssetID { get; set; }
        public string sAssetCode { get; set; }
        public string sAssetAbbrivation { get; set; }
        public string sAssetName { get; set; }
        public string sAssetDescription { get; set; }
        public string sAssetShortDescription { get; set; }
        public Int64 nCompanyID { get; set; }
        //public Int64 nBarcodeID { get; set; }
        public Int64 nAssetMainTypeID { get; set; }
        public string sAssetSize { get; set; }
        public string sAssetCapacity { get; set; }
        public string sAssetDensity { get; set; }
        public string sAssetQuality { get; set; }
        public Int64 nAssetMaterialID { get; set; }
        public string sAssetMake { get; set; }
        public Int64 nAssetTypeID { get; set; }
        public Int64 nAssetTypeOneID { get; set; }
        public string sAssetWeight { get; set; }
        public string sAssetPackingDimention { get; set; }
        public string sAssetShelfLife { get; set; }
        public string sAssetShelfLifeUnit { get; set; }
        public string sAssetHSN_SACCode { get; set; }
        public string sAssetVendor { get; set; }
        public string sAssetReorderTime { get; set; }
        public DateTime dtAssetDateOFIntroduction { get; set; }
        public DateTime dtAssetDateOfRetirement { get; set; }
        public string sAssetRate { get; set; }
        public string sAssetRentalRate { get; set; }

        #endregion

        #region "Methods"
        public Int64 InsertUpdateAsset()
        {
            Int64 nAssetID = 0;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            Object objValue=null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nAssetID", this.nAssetID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@sAssetCode", this.sAssetCode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetName", this.sAssetName, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetDescription", this.sAssetDescription, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetShortDescription", this.sAssetShortDescription, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@nCompanyID", this.nCompanyID, ParameterDirection.Input, SqlDbType.BigInt);
                //oDBParameter.Add("@sBarcodeID", this.nBarcodeID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nAssetMainTypeID", this.nAssetMainTypeID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@sAssetSize", this.sAssetSize, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetCapacity", this.sAssetCapacity, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetDensity", this.sAssetDensity, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetQuality", this.sAssetQuality, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@nAssetMaterialID", this.nAssetMaterialID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@sAssetMake", this.sAssetMake, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@nAssetTypeID", this.nAssetTypeID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nAssetTypeOneID", this.nAssetTypeOneID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@sAssetWeight", this.sAssetWeight, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetPackingDimention", this.sAssetPackingDimention, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetShelfLife", this.sAssetShelfLife, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetShelfLifeUnit", this.sAssetShelfLifeUnit, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetHSN_SACCode", this.sAssetHSN_SACCode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetVendor", this.sAssetVendor, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetReorderTIme", this.sAssetReorderTime, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@dtAssetDateOFIntroduction", this.dtAssetDateOFIntroduction, ParameterDirection.Input, SqlDbType.DateTime);
                oDBParameter.Add("@dtAssetDateOfRetirement", this.dtAssetDateOfRetirement, ParameterDirection.Input, SqlDbType.DateTime);
                oDBParameter.Add("@sAssetRate", this.sAssetRate, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetRentalRate", this.sAssetRentalRate, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetAbbrivation", this.sAssetAbbrivation, ParameterDirection.Input, SqlDbType.VarChar);

                oDBAccess.OpenConnection(false);
                oDBAccess.Execute("lgsp_INUP_AssetMaster", oDBParameter, out objValue);
                oDBAccess.CloseConnection(false);
                if (objValue!=null)
                {
                    nAssetID = Convert.ToInt64(objValue);
                }
            }
            catch (Exception)
            {
            }

            return nAssetID;
        }

        public DataSet GetAllMasterData(int nAssetType=0)
        {
            DataSet ds = null;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nAssetType", nAssetType, ParameterDirection.Input, SqlDbType.VarChar);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_getAssetMasterList",oDBParameter, out ds);
                oDBAccess.CloseConnection(false);
                
            }
            catch (Exception)
            {
            }
            return ds;
        }

        #endregion
    }
}
