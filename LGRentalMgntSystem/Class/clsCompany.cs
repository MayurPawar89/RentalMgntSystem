using LGRentalMgntSystem.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGRentalMgntSystem
{
    class CompanyMaster
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public CompanyMaster()
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

        ~CompanyMaster()
        {
            Dispose(false);
        }
        #endregion

        #region "Properties"
        public Int64 nCompanyID { get; set; }
        public Int64 nCompTransportID { get; set; }
        public Int64 nCompWarehouseID { get; set; }
        public Int64 nCompImageID { get; set; }
        public string sCompanyName { get; set; }
        public string sCompanyCode { get; set; }
        public string sCompAbbrivation { get; set; }
        public Int64 nCompanyTypeID { get; set; }
        public Int64 nCompSignatoryID { get; set; }
        public string sCompAddressLine1 { get; set; }
        public string sCompAddressLine2 { get; set; }
        public string sCompCity { get; set; }
        public string sCompState { get; set; }
        public string sCompCountry { get; set; }
        public string sCompPincode { get; set; }
        public string sCompEmail { get; set; }
        public string sCompWebsite { get; set; }
        public string sCompPhone1 { get; set; }
        public string sCompPhone2 { get; set; }
        public string sCompPhone3 { get; set; }
        public string sCompPhone4 { get; set; }
        public string sCompPhone5 { get; set; }
        public string sCompAllPhoneNo { get; set; }

        public string sCompFax { get; set; }
        public string sCompHSN_SACCode { get; set; }
        public string sCompGSTNo { get; set; }
        public string sCompPANNo { get; set; }
        public DateTime dtCompanyFormedDate { get; set; }

        #region "Transportation Details"
        public string sTransporterID { get; set; }
        public string sTransDocumentName { get; set; }
        public string sTransDocumentNumber { get; set; }
        public string sTransDocumentDate { get; set; }
        #endregion

        #region "Warehouse Details"
        public Int64 nWHSupervisorID { get; set; }
        public string sWHAddressLine1 { get; set; }
        public string sWHAddressLine2 { get; set; }
        public string sWHCity { get; set; }
        public string sWHState { get; set; }
        public string sWHCountry { get; set; }
        public string sWHPincode { get; set; }
        public string sWHPhone1 { get; set; }
        public string sWHPhone2 { get; set; }
        public string sWHPhone3 { get; set; }
        public string sWHPhone4 { get; set; }
        public string sWHPhone5 { get; set; }
        public string sWHAllPhoneNo { get; set; }
        #endregion

        #region "Image Details"
        public byte[] imgCompHeader { get; set; }
        public byte[] imgCompFooter { get; set; }
        public byte[] imgTerms_Condition { get; set; }
        public string sTerms_Condition { get; set; }
        public Int32 nTerms_ConditionType { get; set; }
        #endregion
        #endregion

        #region "Method"
        public Int64 InsertUpdateCompanyMaster()
        {
            Int64 _nCompanyID = 0;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            Object objValue = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nCompanyID", this.nCompanyID, ParameterDirection.InputOutput, SqlDbType.BigInt);
                oDBParameter.Add("@sCompanyName", this.sCompanyName, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCompanyCode", this.sCompanyCode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCompAbbrivation", this.sCompAbbrivation, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@nCompanyTypeID", this.nCompanyTypeID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nCompanySignatory", this.nCompSignatoryID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@sCompAddressLine1", this.sCompAddressLine1, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCompAddressLine2", this.sCompAddressLine2, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCompCity", this.sCompCity, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCompState", this.sCompState, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCompCountry", this.sCompCountry, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCompPincode", this.sCompPincode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCompEmail", this.sCompEmail, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCompWebsite", this.sCompWebsite, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCompAllPhoneNo", this.sCompAllPhoneNo, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCompFax", this.sCompFax, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCompHSN_SACCode", this.sCompHSN_SACCode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCompGSTNo", this.sCompGSTNo, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCompPANNo", this.sCompPANNo, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@dtCompanyFormedOn", this.dtCompanyFormedDate, ParameterDirection.Input, SqlDbType.DateTime);

                oDBParameter.Add("@sTransporterID", this.sTransporterID, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sTransDocumentDate", this.sTransDocumentDate, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sTransDocumentName", this.sTransDocumentName, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sTransDocumentNumber", this.sTransDocumentNumber, ParameterDirection.Input, SqlDbType.VarChar);

                oDBParameter.Add("@sWHAddressLine1", this.sWHAddressLine1, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sWHAddressLine2", this.sWHAddressLine2, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sWHCity", this.sWHCity, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sWHState", this.sWHState, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sWHCountry", this.sWHCountry, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sWHPincode", this.sWHPincode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@nWHSupervisorID", this.nWHSupervisorID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@sWHAllPhoneNo", this.sWHAllPhoneNo, ParameterDirection.Input, SqlDbType.VarChar);

                oDBParameter.Add("@imgCompHeader", this.imgCompHeader, ParameterDirection.Input, SqlDbType.Image);
                oDBParameter.Add("@imgCompFooter", this.imgCompFooter, ParameterDirection.Input, SqlDbType.Image);
                oDBParameter.Add("@imgTerms_Condition", this.imgTerms_Condition, ParameterDirection.Input, SqlDbType.Image);
                oDBParameter.Add("@sTerms_Condition", this.sTerms_Condition, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@nTerms_ConditionType", this.nTerms_ConditionType, ParameterDirection.Input, SqlDbType.Int);

                oDBParameter.Add("@nTransportationID", this.nCompTransportID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nWarehouseID", this.nCompWarehouseID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nImageID", this.nCompImageID, ParameterDirection.Input, SqlDbType.BigInt);

                oDBAccess.OpenConnection(false);
                oDBAccess.Execute("lgsp_INUP_CompanyMasters", oDBParameter, out objValue);
                oDBAccess.CloseConnection(false);
                if (objValue != null)
                {
                    _nCompanyID = Convert.ToInt64(objValue);
                }
            }
            catch (Exception)
            {
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

            return _nCompanyID;
        }

        public DataSet GetCompanyInformation(Int64 nCompanyID)
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
                oDBParameter.Add("@nCompanyID", nCompanyID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_CompanyDetails", oDBParameter, out ds);
                oDBAccess.CloseConnection(false);
                
            }
            catch (Exception ex)
            {
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

        public DataTable GetCompanylist(Int64 nCompanyID)
        {
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataTable _dt = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nCompanyID", nCompanyID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_CompanyListDetails", oDBParameter, out _dt);
                oDBAccess.CloseConnection(false);

            }
            catch (Exception ex)
            {
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
