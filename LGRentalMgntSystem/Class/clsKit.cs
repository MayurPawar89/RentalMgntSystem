using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGRentalMgntSystem
{
    class KitMaster:IDisposable
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public KitMaster()
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

        ~KitMaster()
        {
            Dispose(false);
        }
        #endregion

        public Int64 nKitID { get; set; }
        public string sKitName { get; set; }
        public string sKitCode { get; set; }
        public string sKitAbbrivation { get; set; }
        public string sKitDescription { get; set; }
        public byte[] kitBarcode { get; set; }
        public List<KitAsset> lstKitDetails { get; set; }

        public Int64 InsertUpdateKitDetails(bool bIsSaveKit_Asset = true)
        {
            Int64 nKitID = 0;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            Object objValue = null;
            Object objStatus = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nKitID", this.nKitID, ParameterDirection.InputOutput, SqlDbType.BigInt);
                oDBParameter.Add("@sKitName", this.sKitName, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sKitCode", this.sKitCode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sKitAbbrivation", this.sKitAbbrivation, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sKitDescription", this.sKitDescription, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@kitBarcode", this.kitBarcode, ParameterDirection.Input, SqlDbType.Image);

                oDBAccess.OpenConnection(true);
                oDBAccess.Execute("lgsp_INUP_KitMaster", oDBParameter, out objValue);

                if (objValue != null)
                {
                    nKitID = Convert.ToInt64(objValue);
                }
                if (nKitID == 0)
                {
                    oDBAccess.RollBack();
                    oDBAccess.CloseConnection(true);
                    return nKitID;
                }
                if (nKitID != 0 && bIsSaveKit_Asset)
                {
                    foreach (KitAsset item in lstKitDetails)
                    {
                        oDBParameter.clear();
                        oDBParameter.Add("@nKitID", nKitID, ParameterDirection.Input, SqlDbType.BigInt);
                        oDBParameter.Add("@nKitAssetID", item.nKitAssetID, ParameterDirection.Input, SqlDbType.BigInt);
                        oDBParameter.Add("@nAssetCodeID", item.nAssetCodeID, ParameterDirection.Input, SqlDbType.BigInt);
                        oDBParameter.Add("@nAssetID", item.nAssetID, ParameterDirection.Input, SqlDbType.BigInt);
                        oDBParameter.Add("@nStatus", 0, ParameterDirection.InputOutput, SqlDbType.Int);

                        oDBAccess.Execute("lgsp_INUP_KitAssetAssociation", oDBParameter, out objStatus);
                        int nStatus = 0;
                        if (objValue != null)
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
                    }
                }
                oDBAccess.Commit();
                
            }
            catch (Exception ex)
            {
                oDBAccess.RollBack();
                oDBAccess.CloseConnection(true);
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
            return nKitID;
        }
        public DataTable GetKitAssetAssociation(Int64 nKitID=0)
        {
            DataTable dt = null;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nKitID", nKitID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_KitAssetAssociationDetails", oDBParameter, out dt);
                oDBAccess.CloseConnection(false);
            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(true);
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
            return dt;
        }

        public DataTable GetKitList(Int64 nKitID)
        {
            DataTable dt = null;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nKitID", nKitID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_KitListDetails", oDBParameter, out dt);
                oDBAccess.CloseConnection(false);
            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(true);
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
            return dt;
        }

        public DataSet GetKitDetails(Int64 nKitID)
        {
            DataSet ds = null;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nKitID", nKitID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_KitDetails", oDBParameter, out ds);
                oDBAccess.CloseConnection(false);
            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(true);
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
            return ds;
        }

        public DataTable GetKitAssetList(Int64 nKitID = 0)
        {
            DataTable dt = null;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nKitID", nKitID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_KitAssetList", oDBParameter, out dt);
                oDBAccess.CloseConnection(false);
            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(true);
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
            return dt;
        }

        public Int32 DeleteKit()
        {
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            Int32 nDeletedID = 0;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nKitID", this.nKitID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                nDeletedID=oDBAccess.Execute("lgsp_Delete_Kit", oDBParameter);
                oDBAccess.CloseConnection(false);
            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(true);
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
            return nDeletedID;
        }
    }
    public class KitAsset:IDisposable
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public KitAsset()
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

        ~KitAsset()
        {
            Dispose(false);
        }
        #endregion

        public Int64 nKitID { get; set; }
        public Int64 nAssetCodeID { get; set; }
        public Int64 nKitAssetID { get; set; }
        public Int64 nAssetID { get; set; }

        public string sUniqueCode { get; set; }
        public string sAssetName { get; set; }
        public string sAssetNameWithCode { get; set; }

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
                oDBParameter.Add("@nKitID", this.nKitID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nKitAssetID", this.nKitAssetID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nAssetID", this.nAssetID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nAssetCodeID", this.nAssetCodeID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nStatus", 0, ParameterDirection.InputOutput, SqlDbType.Int);
                oDBAccess.OpenConnection(false);
                oDBAccess.Execute("lgsp_INUP_KitAssetAssociation", oDBParameter, out objStatus);
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
                oDBAccess.CloseConnection(true);
            }
            catch (Exception ex)
            {
                oDBAccess.RollBack(); 
                oDBAccess.CloseConnection(true);
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
            return nStatus;

        }

        public Int32 DeleteKitAsset()
        {
            Int32 nRow = 0;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nKitAssetID", this.nKitAssetID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                nRow= oDBAccess.Execute("lgsp_Delete_KitAsset", oDBParameter);
                oDBAccess.CloseConnection(false);
            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(true);
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
            return nRow;
        }
    }
}
