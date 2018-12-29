using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGRentalMgntSystem
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
        public Int64 nCompanyID { get; set; }
        public Int64 nAssetMainTypeID { get; set; }
        public Int64 nAssetTypeID { get; set; }
        public Int64 nAssetTypeOneID { get; set; }
        public Int64 nAssetMaterialID { get; set; }
        public Int64 nAssetVendorID { get; set; }
        public Int64 nDensityID { get; set; }
        public Int64 nColorID { get; set; }
        public string sHSNCode { get; set; }
        public string sAssetName { get; set; }
        public string sAssetCode { get; set; }
        public string sAssetAbbrivation { get; set; }
        public string sAssetDescription { get; set; }
        public DateTime dtIntroductionDate { get; set; }
        public DateTime dtReorderDate { get; set; }
        public string sReorderDays { get; set; }
        public string sReorderQuntity { get; set; }
        public string sAssetRate { get; set; }
        public string sAssetMake { get; set; }
        public string sAssetSizeOrCapacity { get; set; }
        public string sAssetQuality { get; set; }
        public string sAssetDimention { get; set; }
        public string sAssetWeight { get; set; }
        public string sWattage { get; set; }
        public string sSpan { get; set; }
        public string sAttachment { get; set; }
        public string sAttachmentName { get; set; }
        public string sLength { get; set; }
        public string sCoreOrPole { get; set; }
        public string sAmps { get; set; }
        public string sPlug { get; set; }
        public string sPower { get; set; }
        public List<AssetCode> lstAssetCode { get; set; }
        #endregion

        #region "Methods"
        public Int64 InsertUpdateAsset(bool bIsSaveAsset_Code=true)
        {
            Int64 nAssetID = 0;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            Object objValue=null;
            Object objStatus=null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nAssetID", this.nAssetID, ParameterDirection.InputOutput, SqlDbType.BigInt);
                oDBParameter.Add("@nCompanyID", this.nCompanyID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nAssetMainTypeID", this.nAssetMainTypeID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nAssetTypeID", this.nAssetTypeID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nAssetTypeOneID", this.nAssetTypeOneID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nAssetMaterialID", this.nAssetMaterialID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nAssetVendorID", this.nAssetVendorID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nDensityID", this.nDensityID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nColorID", this.nColorID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@sHSNCode", this.sHSNCode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetName", this.sAssetName, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAssetAbbrivation", this.sAssetAbbrivation, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sDescription", this.sAssetDescription, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@dtIntroductionDate", this.dtIntroductionDate, ParameterDirection.Input, SqlDbType.DateTime);
                oDBParameter.Add("@dtReorderDate", this.dtReorderDate, ParameterDirection.Input, SqlDbType.DateTime);
                oDBParameter.Add("@sReorderDays", this.sReorderDays, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sReorderQuntity", this.sReorderQuntity, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sRate", this.sAssetRate, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sMake", this.sAssetMake, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sSizeOrCapacity", this.sAssetSizeOrCapacity, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sQuality", this.sAssetQuality, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sDimention", this.sAssetDimention, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sWeight", this.sAssetWeight, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sWattage", this.sWattage, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sSpan", this.sSpan, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAttachment", this.sAttachment, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAttachmentName", this.sAttachmentName, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sLength", this.sLength, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCoreOrPole", this.sCoreOrPole, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAmps", this.sAmps, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPlug", this.sPlug, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPower", this.sPower, ParameterDirection.Input, SqlDbType.VarChar);

                oDBAccess.OpenConnection(true);
                oDBAccess.Execute("lgsp_INUP_AssetMaster", oDBParameter, out objValue);
                
                if (objValue!=null)
                {
                    nAssetID = Convert.ToInt64(objValue);
                }
                if(nAssetID==0)
                {
                    oDBAccess.RollBack();
                    oDBAccess.CloseConnection(true);
                    return nAssetID;
                }
                if (nAssetID!=0)
                {
                    foreach (AssetCode item in lstAssetCode)
                    {
                        oDBParameter.clear();
                        oDBParameter.Add("@nAssetID", nAssetID, ParameterDirection.Input, SqlDbType.BigInt);
                        oDBParameter.Add("@nAssetCodeID", item.nAssetCodeID, ParameterDirection.Input, SqlDbType.BigInt);
                        oDBParameter.Add("@sInitialCode", item.sInitialCode, ParameterDirection.Input, SqlDbType.VarChar);
                        oDBParameter.Add("@nSequenceNo", item.nSequenceNo, ParameterDirection.Input, SqlDbType.BigInt);
                        oDBParameter.Add("@sUniqueCode", item.sUniqueCode, ParameterDirection.Input, SqlDbType.VarChar);
                        oDBParameter.Add("@barcode", item.barcode, ParameterDirection.Input, SqlDbType.Image);
                        oDBParameter.Add("@dtShelfLife", item.dtShelfLife, ParameterDirection.Input, SqlDbType.DateTime);
                        oDBParameter.Add("@sShelfLifeUnit", item.sShelfLifeUnit, ParameterDirection.Input, SqlDbType.VarChar);
                        oDBParameter.Add("@dtRetirementDate", item.dtRetirementDate, ParameterDirection.Input, SqlDbType.DateTime);
                        oDBParameter.Add("@nStatus", 0, ParameterDirection.InputOutput, SqlDbType.Int);

                        oDBAccess.Execute("lgsp_INUP_AssetCode", oDBParameter, out objStatus);
                        int nStatus=0;
                        if (objValue != null)
                        {
                            nStatus = Convert.ToInt32(objStatus);
                        }
                        if (nStatus<=0)
                        {
                            oDBAccess.RollBack();
                            oDBAccess.CloseConnection(true);
                            return nStatus;
                        }
                        if (nStatus==2)
                        {
                            oDBAccess.RollBack();
                            oDBAccess.CloseConnection(true);
                            return nStatus;
                        }
                    }
                }
                oDBAccess.Commit();
                //oDBAccess.CloseConnection(true);
            }
            catch (Exception ex)
            {
                oDBAccess.RollBack();
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
                oDBParameter.Add("@nAssetType", nAssetType, ParameterDirection.Input, SqlDbType.Int);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_getAssetMasterList",oDBParameter, out ds);
                oDBAccess.CloseConnection(false);
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
            return ds;
        }

        public DataTable GetAssetList(Int64 nAssetID)
        {
            DataTable dt = null;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nAssetID", nAssetID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_AssetListDetails", oDBParameter, out dt);
                oDBAccess.CloseConnection(false);
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
            return dt;
        }

        public DataSet GetAssetDetails(Int64 nAssetID)
        {
            DataSet ds = null;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nAssetID", nAssetID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_AssetDetails", oDBParameter, out ds);
                oDBAccess.CloseConnection(false);
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
            return ds;
        }

        public DataSet GetAllMasterData_ByMainType(Int64 nAssetMainType)
        {
            DataSet ds = null;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nAssetType", nAssetMainType, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_AssetMasterData_ByMainType",oDBParameter, out ds);
                oDBAccess.CloseConnection(false);
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
            return ds;
        }

        public DataTable GetAssetCode(Int64 nAssetID)
        {
            DataTable dt = null;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nAssetID", nAssetID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_AssetCodeDetails", oDBParameter, out dt);
                oDBAccess.CloseConnection(false);
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
            return dt;
        }

        public Int32 DeleteAsset()
        {
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            Int32 nDeletedID = 0;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nAssetID", this.nAssetID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                nDeletedID= oDBAccess.Execute("lgsp_Delete_Asset", oDBParameter);
                oDBAccess.CloseConnection(false);
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
            return nDeletedID;
        }
        #endregion
    }

    public class AssetCode:IDisposable
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public AssetCode()
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

        ~AssetCode()
        {
            Dispose(false);
        }
        #endregion
        public Int64 nAssetCodeID { get; set; }
        public Int64 nAssetID { get; set; }
        public string sInitialCode { get; set; }
        public int nSequenceNo { get; set; }
        public string sUniqueCode { get; set; }
        public string sShowStatus { get; set; }

        public string sAssignStatus { get; set; }
        public string sCurrentStatus { get; set; }
        public byte[] barcode { get; set; }
        public DateTime dtShelfLife { get; set; }
        public string sShelfLifeUnit { get; set; }
        public DateTime dtRetirementDate { get; set; }

        public string sDamageStatus { get; set; }


        public Int64 UpdateAssetCode()
        {
             Int64 nStatus = 0;

            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            Object objStatus = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();

                oDBParameter.clear();
                oDBParameter.Add("@nAssetID", this.nAssetID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nAssetCodeID", this.nAssetCodeID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@sInitialCode", this.sInitialCode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@nSequenceNo", this.nSequenceNo, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@sUniqueCode", this.sUniqueCode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@barcode", this.barcode, ParameterDirection.Input, SqlDbType.Image);
                oDBParameter.Add("@dtShelfLife", this.dtShelfLife, ParameterDirection.Input, SqlDbType.DateTime);
                oDBParameter.Add("@sShelfLifeUnit", this.sShelfLifeUnit, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@dtRetirementDate", this.dtRetirementDate, ParameterDirection.Input, SqlDbType.DateTime);
                oDBParameter.Add("@nStatus", 0, ParameterDirection.InputOutput, SqlDbType.Int);
                oDBAccess.OpenConnection(false);
                oDBAccess.Execute("lgsp_INUP_AssetCode", oDBParameter, out objStatus);
                oDBAccess.CloseConnection(false);
                if (objStatus != null)
                {
                    nStatus = Convert.ToInt32(objStatus);
                }
                if (nStatus <= 0)
                {
                    oDBAccess.RollBack();
                    oDBAccess.CloseConnection(true);
                    return nStatus;
                }
                if (nStatus == 2)
                {
                    oDBAccess.RollBack();
                    oDBAccess.CloseConnection(true);
                    return nStatus;
                }
                oDBAccess.Commit();
                //oDBAccess.CloseConnection(true);
            }
            catch (Exception ex)
            {
                oDBAccess.RollBack();
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

            return nStatus;
        }

        public DataTable GetAssetCode()
        {

            DatabaseAccess oDBAccess = null;
            DataTable dtAssetCode=null;
            //DatabaseParameters oDBParameter = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                //oDBParameter = new DatabaseParameters();

                //oDBParameter.clear();
                //oDBParameter.Add("@nAssetID", this.nAssetID, ParameterDirection.Input, SqlDbType.BigInt);
                //oDBParameter.Add("@nAssetCodeID", this.nAssetCodeID, ParameterDirection.Input, SqlDbType.BigInt);
                //oDBParameter.Add("@sInitialCode", this.sInitialCode, ParameterDirection.Input, SqlDbType.VarChar);
                //oDBParameter.Add("@nSequenceNo", this.nSequenceNo, ParameterDirection.Input, SqlDbType.BigInt);
                //oDBParameter.Add("@sUniqueCode", this.sUniqueCode, ParameterDirection.Input, SqlDbType.VarChar);
                //oDBParameter.Add("@barcode", this.barcode, ParameterDirection.Input, SqlDbType.Image);
                //oDBParameter.Add("@dtShelfLife", this.dtShelfLife, ParameterDirection.Input, SqlDbType.DateTime);
                //oDBParameter.Add("@sShelfLifeUnit", this.sShelfLifeUnit, ParameterDirection.Input, SqlDbType.VarChar);
                //oDBParameter.Add("@dtRetirementDate", this.dtRetirementDate, ParameterDirection.Input, SqlDbType.DateTime);
                //oDBParameter.Add("@nStatus", 0, ParameterDirection.InputOutput, SqlDbType.Int);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_AllNotUsedAsset", out dtAssetCode);
                oDBAccess.CloseConnection(false);
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
                
            }

            return dtAssetCode;
        }

        public Int32 DeleteAssetCode()
        {
            Int32 nRow = 0;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nAssetCodeID", this.nAssetCodeID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                nRow = oDBAccess.Execute("lgsp_Delete_AssetCode", oDBParameter);
                oDBAccess.CloseConnection(false);
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
            return nRow;
        }        
    }
}
