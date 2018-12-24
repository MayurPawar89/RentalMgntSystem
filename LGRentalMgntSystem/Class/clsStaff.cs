using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGRentalMgntSystem
{
    class StaffMaster
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public StaffMaster()
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

        ~StaffMaster()
        {
            Dispose(false);
        }
        #endregion

        #region "Properties"

        public Int64 nStaffID { get; set; }
        public Int64 nDesignationID { get; set; }
        public Int64 nCompanyID { get; set; }
        public string sStaffCode { get; set; }
        public string sStaffName { get; set; }
        public string sStaffAbbrivation { get; set; }
        public DateTime dtDOB { get; set; }
        public string sAge { get; set; }
        public string sGender { get; set; }
        public string sPhoneNo { get; set; }
        public string sPermanentAddressLine1 { get; set; }
        public string sPermanentAddressLine2 { get; set; }
        public string sPermanentPincode { get; set; }
        public string sPermanentDistTown { get; set; }
        public string sAddressLine1 { get; set; }
        public string sAddressLine2 { get; set; }
        public string sCity { get; set; }
        public string sState { get; set; }
        public string sCountry { get; set; }
        public string sPincode { get; set; }
        public string sEmail { get; set; }
        public DateTime dtDOJ { get; set; }
        public string sGSTNNo { get; set; }
        public string sPANNo { get; set; }
        public string sAadharNo { get; set; }
        public string sReferenceBy { get; set; }
        public string sAllergies { get; set; }
        public string sBloodGroup { get; set; }
        public string sWorkingSince { get; set; }
        public string sSalary { get; set; }
        public string sDailyWages { get; set; }
        public string sUnionID { get; set; }
        public DateTime dtUnionIDRenewalDate { get; set; }
        public string sFirstLicenseNumber { get; set; }
        public DateTime dtFirstLicenseRenewalDate { get; set; }
        public string sSecondLicenseNumber { get; set; }
        public DateTime dtSecondLicenseRenewalDate { get; set; }
        public string sThirdLicenseNumber { get; set; }
        public DateTime dtThirdLicenseRenewalDate { get; set; }
        public byte[] imgPhoto { get; set; } 
        #endregion

        #region "Method"
        public Int64 InsertUpdateStaffMaster()
        {
            Int64 _nStaffID = 0;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            Object objValue = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nStaffID", this.nStaffID, ParameterDirection.InputOutput, SqlDbType.BigInt);
                oDBParameter.Add("@nDesignationID", this.nDesignationID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@nCompanyID", this.nCompanyID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBParameter.Add("@sStaffCode", this.sStaffCode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sStaffName", this.sStaffName, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sStaffAbbrivation", this.sStaffAbbrivation, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@dtDOB", this.dtDOB, ParameterDirection.Input, SqlDbType.DateTime);
                oDBParameter.Add("@sAge", this.sAge, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sGender", this.sGender, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPhoneNo", this.sPhoneNo, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPermanentAddressLine1", this.sPermanentAddressLine1, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPermanentAddressLine2", this.sPermanentAddressLine2, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPermanentPincode", this.sPermanentPincode, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPermanentDistTown", this.sPermanentDistTown, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAddressLine1", this.sAddressLine1, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAddressLine2", this.sAddressLine2, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCity", this.sCity, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sState", this.sState, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sCountry", this.sCountry, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPincode", this.sPincode, ParameterDirection.Input, SqlDbType.VarChar);

                oDBParameter.Add("@sEmail", this.sEmail, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@dtDOJ", this.dtDOJ, ParameterDirection.Input, SqlDbType.DateTime);
                oDBParameter.Add("@sGSTNNo", this.sGSTNNo, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sPANNo", this.sPANNo, ParameterDirection.Input, SqlDbType.VarChar);

                oDBParameter.Add("@sAadharNo", this.sAadharNo, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sReferenceBy", this.sReferenceBy, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sAllergies", this.sAllergies, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sBloodGroup", this.sBloodGroup, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sWorkingSince", this.sWorkingSince, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sSalary", this.sSalary, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sDailyWages", this.sDailyWages, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@sUnionID", this.sUnionID, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@dtUnionIDRenewalDate", this.dtUnionIDRenewalDate, ParameterDirection.Input, SqlDbType.DateTime);
                oDBParameter.Add("@sFirstLicenseNumber", this.sFirstLicenseNumber, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@dtFirstLicenseRenewalDate", this.dtFirstLicenseRenewalDate, ParameterDirection.Input, SqlDbType.DateTime);
                oDBParameter.Add("@sSecondLicenseNumber", this.sSecondLicenseNumber, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@dtSecondLicenseRenewalDate", this.dtSecondLicenseRenewalDate, ParameterDirection.Input, SqlDbType.DateTime);
                oDBParameter.Add("@sThirdLicenseNumber", this.sThirdLicenseNumber, ParameterDirection.Input, SqlDbType.VarChar);
                oDBParameter.Add("@dtThirdLicenseRenewalDate", this.dtThirdLicenseRenewalDate, ParameterDirection.Input, SqlDbType.DateTime);
                oDBParameter.Add("@imgPhoto", this.imgPhoto, ParameterDirection.Input, SqlDbType.Image);    

                oDBAccess.OpenConnection(false);
                oDBAccess.Execute("lgsp_INUP_CompanyStaff", oDBParameter, out objValue);
                oDBAccess.CloseConnection(false);
                if (objValue != null)
                {
                    _nStaffID = Convert.ToInt64(objValue);
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

            return _nStaffID;
        }

        public DataTable GetStaffInformation(Int64 nStaffID)
        {
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataTable _dt = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nStaffID", nStaffID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_StaffDetails", oDBParameter, out _dt);
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

        public DataTable GetStafflist(Int64 nStaffID)
        {
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataTable _dt = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nStaffID", nStaffID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_StaffListDetails", oDBParameter, out _dt);
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
