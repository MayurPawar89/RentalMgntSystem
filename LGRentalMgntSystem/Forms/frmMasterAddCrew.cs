using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGRentalMgntSystem
{
    public partial class frmMasterAddCrew : DevExpress.XtraEditors.XtraForm
    {
        public frmMasterAddCrew()
        {
            InitializeComponent();
            fillMasterData();
            GetAndSetSequence();
            txtEmployeeName.Focus();
        }

        public frmMasterAddCrew(Int64 nStaffID)
        {
            InitializeComponent();
            lblEmployeeID.Text = Convert.ToString(nStaffID);
            fillMasterData();
            GetAndSetSequence();
            txtEmployeeName.Focus();
        }

        private void GetAndSetSequence()
        {
            clsGeneral oclsGeneral = null;
            try
            {
                oclsGeneral = new clsGeneral();
                txtEmployeeCode.Text = "EMP/" + Convert.ToString(oclsGeneral.GetSequenceNumber(MainMasterType.Crew.GetHashCode()));
            }
            catch (Exception)
            {

            }
            finally
            {
                if (oclsGeneral != null)
                {
                    oclsGeneral.Dispose();
                    oclsGeneral = null;
                }
            }
        }

        private void fillMasterData()
        {
            clsGeneral oclsGeneral = null;
            try
            {
                oclsGeneral = new clsGeneral();
                DataSet dsCrew = oclsGeneral.GetCrewMaster();
                if (dsCrew != null && dsCrew.Tables.Count > 0)
                {
                    DataTable dtCompanyType = dsCrew.Tables[0];
                    DataTable dtStateMaster = dsCrew.Tables[1];
                    DataTable dtCityMaster = dsCrew.Tables[2];
                    DataTable dtCountryMaster = dsCrew.Tables[3];
                    DataTable dtDesignation = dsCrew.Tables[4];

                    cmbEmpCompany.DataSource = dtCompanyType;
                    cmbEmpCompany.DisplayMember = "sCompanyName";
                    cmbEmpCompany.ValueMember = "nCompanyID";

                    cmbStateMaster.DataSource = dtStateMaster;
                    cmbStateMaster.DisplayMember = "StateName";
                    cmbStateMaster.ValueMember = "StateName";
                    cmbStateMaster.Text = "Maharashtra";

                    cmbCityMaster.DataSource = dtCityMaster;
                    cmbCityMaster.DisplayMember = "CityName";
                    cmbCityMaster.ValueMember = "CityName";
                    cmbCityMaster.Text = "Mumbai";

                    cmbCountryMaster.DataSource = dtCountryMaster;
                    cmbCountryMaster.DisplayMember = "sCountryName";
                    cmbCountryMaster.ValueMember = "sCountryName";
                    cmbCountryMaster.Text = "India";

                    cmbEmpDesignation.DataSource = dtDesignation;
                    cmbEmpDesignation.DisplayMember = "sDesignationName";
                    cmbEmpDesignation.ValueMember = "nDesignationID";
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                if (oclsGeneral != null)
                {
                    oclsGeneral.Dispose();
                    oclsGeneral = null;
                }
            }
        }

        private int CheckPanelVisibility()
        {
            int nPanelCount = 0;
            if (pnlPhoneOne.Visible == true && pnlPhoneTwo.Visible == false && pnlPhoneThree.Visible == false && pnlPhoneFour.Visible == false && pnlPhoneFive.Visible == false)
            {
                nPanelCount = 2;
            }
            else if (pnlPhoneOne.Visible == true && pnlPhoneTwo.Visible == true && pnlPhoneThree.Visible == false && pnlPhoneFour.Visible == false && pnlPhoneFive.Visible == false)
            {
                nPanelCount = 3;
            }
            else if (pnlPhoneOne.Visible == true && pnlPhoneTwo.Visible == true && pnlPhoneThree.Visible == true && pnlPhoneFour.Visible == false && pnlPhoneFive.Visible == false)
            {
                nPanelCount = 4;
            }
            else if (pnlPhoneOne.Visible == true && pnlPhoneTwo.Visible == true && pnlPhoneThree.Visible == true && pnlPhoneFour.Visible == true && pnlPhoneFive.Visible == false)
            {
                nPanelCount = 5;
            }
            else if (pnlPhoneOne.Visible == true && pnlPhoneTwo.Visible == true && pnlPhoneThree.Visible == true && pnlPhoneFour.Visible == true && pnlPhoneFive.Visible == false)
            {
                nPanelCount = 6;
            }
            return nPanelCount;
        }

        private void ShowHidePhonePanel(string sPhoneNo = "", int PhoneCount = 1)
        {
            switch (PhoneCount)
            {
                case 1:
                    {
                        pnlPhoneOne.Visible = true;
                        pnlPhoneTwo.Visible = false;
                        pnlPhoneThree.Visible = false;
                        pnlPhoneFour.Visible = false;
                        pnlPhoneFive.Visible = false;
                        txtPhone1.Text = sPhoneNo;
                        break;
                    }
                case 2:
                    {
                        pnlPhoneOne.Visible = true;
                        pnlPhoneTwo.Visible = true;
                        pnlPhoneTwo.BringToFront();
                        pnlPhoneThree.Visible = false;
                        pnlPhoneFour.Visible = false;
                        pnlPhoneFive.Visible = false;
                        txtPhone2.Text = sPhoneNo;
                        break;
                    }
                case 3:
                    {
                        pnlPhoneOne.Visible = true;
                        pnlPhoneTwo.Visible = true;
                        pnlPhoneThree.Visible = true;
                        pnlPhoneThree.BringToFront();
                        pnlPhoneFour.Visible = false;
                        pnlPhoneFive.Visible = false;
                        txtPhone3.Text = sPhoneNo;
                        break;
                    }
                case 4:
                    {
                        pnlPhoneOne.Visible = true;
                        pnlPhoneTwo.Visible = true;
                        pnlPhoneThree.Visible = true;
                        pnlPhoneFour.Visible = true;
                        pnlPhoneFour.BringToFront();
                        pnlPhoneFive.Visible = false;
                        txtPhone4.Text = sPhoneNo;
                        break;
                    }
                case 5:
                    {
                        pnlPhoneOne.Visible = true;
                        pnlPhoneTwo.Visible = true;
                        pnlPhoneThree.Visible = true;
                        pnlPhoneFour.Visible = true;
                        pnlPhoneFive.Visible = true;
                        pnlPhoneFive.BringToFront();
                        txtPhone5.Text = sPhoneNo;
                        break;
                    }
            }
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            try
            {
                int nCompanyPhoneCount = CheckPanelVisibility();
                if (nCompanyPhoneCount <= 5)
                {
                    ShowHidePhonePanel("", nCompanyPhoneCount);
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        private void txtEmployeeName_EditValueChanged(object sender, EventArgs e)
        {
            txtEmpAbbrivation.Text = clsGlobal.GenerateAbbrivation(txtEmployeeName.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCrewMember();
        }

        private void SaveCrewMember()
        {
            StaffMaster clsStaffMaster = null;
            try
            {
                string sPhone1 = Convert.ToString(txtPhone1.Text.Trim());
                string sPhone2 = Convert.ToString(txtPhone2.Text.Trim());
                string sPhone3 = Convert.ToString(txtPhone3.Text.Trim());
                string sPhone4 = Convert.ToString(txtPhone4.Text.Trim());
                string sPhone5 = Convert.ToString(txtPhone5.Text.Trim());
                string sPhoneAll = string.Empty;
                if (sPhone1 != "")
                {
                    sPhoneAll += sPhone1;
                }
                if (sPhone2 != "")
                {
                    sPhoneAll += "," + sPhone2;
                }
                if (sPhone3 != "")
                {
                    sPhoneAll += "," + sPhone3;
                }
                if (sPhone4 != "")
                {
                    sPhoneAll += "," + sPhone4;
                }
                if (sPhone5 != "")
                {
                    sPhoneAll += "," + sPhone5;
                }
                byte[] EmployeeImage = null;

                if (picEmployeemage.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picEmployeemage.Image.Save(ms, ImageFormat.Jpeg);
                        EmployeeImage = new byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(EmployeeImage, 0, EmployeeImage.Length);
                    }
                }

                clsStaffMaster = new StaffMaster();
                clsStaffMaster.nStaffID = Convert.ToInt64(lblEmployeeID.Text);
                clsStaffMaster.nDesignationID = Convert.ToInt64(cmbEmpDesignation.SelectedValue);
                clsStaffMaster.nCompanyID = Convert.ToInt64(cmbEmpCompany.SelectedValue);
                clsStaffMaster.sStaffCode = Convert.ToString(txtEmployeeCode.Text.Trim());
                clsStaffMaster.sStaffName = Convert.ToString(txtEmployeeName.Text.Trim());
                clsStaffMaster.sStaffAbbrivation = Convert.ToString(txtEmpAbbrivation.Text.Trim());
                clsStaffMaster.dtDOB = Convert.ToDateTime(dtEmpBirthdate.Text.ToString());
                clsStaffMaster.sAge = Convert.ToString(txtEmpAge.Text.Trim());
                clsStaffMaster.sGender = Convert.ToString(cmbGender.SelectedValue);
                clsStaffMaster.sPhoneNo = sPhoneAll;
                clsStaffMaster.sPermanentAddressLine1 = Convert.ToString(txtPermanentAddressLine1.Text.Trim());
                clsStaffMaster.sPermanentAddressLine2 = Convert.ToString(txtPermanentAddressLine2.Text.Trim());
                clsStaffMaster.sPermanentPincode = Convert.ToString(txtPermanentPincode.Text.Trim());
                clsStaffMaster.sPermanentDistTown = Convert.ToString(txtDistrictTownVillage.Text.Trim());
                clsStaffMaster.sAddressLine1 = Convert.ToString(txtAddressLine1.Text.Trim());
                clsStaffMaster.sAddressLine2 = Convert.ToString(txtAddressLine2.Text.Trim());
                clsStaffMaster.sCity = Convert.ToString(cmbCityMaster.Text.Trim());
                clsStaffMaster.sState = Convert.ToString(cmbStateMaster.Text.Trim());
                clsStaffMaster.sCountry = Convert.ToString(cmbCountryMaster.Text.Trim());
                clsStaffMaster.sPincode = Convert.ToString(txtPincode.Text.Trim());
                clsStaffMaster.sEmail = Convert.ToString(txtEmail.Text.Trim());
                clsStaffMaster.dtDOJ = Convert.ToDateTime(dtEmpBirthdate.Text.ToString());
                clsStaffMaster.sGSTNNo = Convert.ToString(txtGSTNNo.Text.Trim());
                clsStaffMaster.sPANNo = Convert.ToString(txtPANNo.Text.Trim());
                clsStaffMaster.sAadharNo = Convert.ToString(txtAadharNo.Text.Trim());
                clsStaffMaster.sReferenceBy = Convert.ToString(txtReferenceBy.Text.Trim());
                clsStaffMaster.sAllergies = Convert.ToString(txtAllergies.Text.Trim());
                clsStaffMaster.sBloodGroup = Convert.ToString(cmbBloodGroup.Text.Trim());
                clsStaffMaster.sWorkingSince = Convert.ToString(txtWorkedSince.Text.Trim());
                clsStaffMaster.sSalary = Convert.ToString(txtSalary.Text.Trim());
                clsStaffMaster.sDailyWages = Convert.ToString(txtDailyWages.Text.Trim());
                clsStaffMaster.sUnionID = Convert.ToString(txtUnionID.Text.Trim());
                clsStaffMaster.dtUnionIDRenewalDate = Convert.ToDateTime(dtUnionRenewDate.Text.Trim());
                clsStaffMaster.sFirstLicenseNumber = Convert.ToString(txtlic1No.Text.Trim());
                clsStaffMaster.dtFirstLicenseRenewalDate = Convert.ToDateTime(dtLic1RenewDate.Text.Trim());
                clsStaffMaster.sSecondLicenseNumber = Convert.ToString(txtLic2No.Text.Trim());
                clsStaffMaster.dtSecondLicenseRenewalDate = Convert.ToDateTime(dtLic2RenewDate.Text.Trim());
                clsStaffMaster.sThirdLicenseNumber = Convert.ToString(txtLic2No.Text.Trim());
                clsStaffMaster.dtThirdLicenseRenewalDate = Convert.ToDateTime(dtLic3RenewDate.Text.Trim());
                clsStaffMaster.imgPhoto = EmployeeImage;

                Int64 nCrewMemberID = clsStaffMaster.InsertUpdateStaffMaster();

                if (nCrewMemberID != 0)
                {
                    MessageBox.Show("Crew member is saved successfully.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error while saving crew member.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void frmMasterAddCrew_Load(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt64(lblEmployeeID.Text) > 0)
                {
                    FillCrewMemberDetails(Convert.ToInt64(lblEmployeeID.Text));
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void FillCrewMemberDetails(long nStaffID)
        {
            StaffMaster clsStaffMaster = null;
            DataTable dtStaffDetails = null;
            try
            {
                dtStaffDetails = clsStaffMaster.GetStaffInformation(nStaffID);

                if (dtStaffDetails != null && dtStaffDetails.Rows.Count > 0)
                {
                    lblEmployeeID.Text = Convert.ToString(dtStaffDetails.Rows[0]["nStaffID"]);
                    txtEmployeeCode.Text = Convert.ToString(dtStaffDetails.Rows[0]["sStaffCode"]);
                    txtEmployeeName.Text = Convert.ToString(dtStaffDetails.Rows[0]["sStaffName"]);
                    cmbEmpDesignation.SelectedValue = Convert.ToString(dtStaffDetails.Rows[0]["nDesignationID"]);
                    cmbEmpCompany.SelectedValue = Convert.ToString(dtStaffDetails.Rows[0]["nCompanyID"]);
                    txtEmpAbbrivation.Text = Convert.ToString(dtStaffDetails.Rows[0]["sStaffAbbrivation"]);
                    cmbGender.SelectedValue = Convert.ToString(dtStaffDetails.Rows[0]["sGender"]);
                    dtEmpBirthdate.Text = Convert.ToString(dtStaffDetails.Rows[0]["dtDOB"]);
                    txtEmpAge.Text = Convert.ToString(dtStaffDetails.Rows[0]["sAge"]);
                    txtAddressLine1.Text = Convert.ToString(dtStaffDetails.Rows[0]["sAddressLine1"]);
                    txtAddressLine2.Text = Convert.ToString(dtStaffDetails.Rows[0]["sAddressLine2"]);
                    cmbCityMaster.Text = Convert.ToString(dtStaffDetails.Rows[0]["sCity"]);
                    cmbStateMaster.Text = Convert.ToString(dtStaffDetails.Rows[0]["sState"]);
                    cmbCountryMaster.Text = Convert.ToString(dtStaffDetails.Rows[0]["sCountry"]);
                    txtPincode.Text = Convert.ToString(dtStaffDetails.Rows[0]["sPincode"]);
                    txtEmail.Text = Convert.ToString(dtStaffDetails.Rows[0]["sEmail"]);
                    txtPermanentAddressLine1.Text = Convert.ToString(dtStaffDetails.Rows[0]["sPermanentAddressLine1"]);
                    txtPermanentAddressLine2.Text = Convert.ToString(dtStaffDetails.Rows[0]["sPermanentAddressLine2"]);
                    txtPermanentPincode.Text = Convert.ToString(dtStaffDetails.Rows[0]["sPermanentPincode"]);
                    txtDistrictTownVillage.Text = Convert.ToString(dtStaffDetails.Rows[0]["sPermanentDistTown"]);
                    dtEmpDOJ.Text = Convert.ToString(dtStaffDetails.Rows[0]["dtDOJ"]);
                    txtGSTNNo.Text = Convert.ToString(dtStaffDetails.Rows[0]["sGSTNNo"]);
                    txtPANNo.Text = Convert.ToString(dtStaffDetails.Rows[0]["sPANNo"]);
                    txtAadharNo.Text = Convert.ToString(dtStaffDetails.Rows[0]["sAadharNo"]);
                    txtReferenceBy.Text = Convert.ToString(dtStaffDetails.Rows[0]["sReferenceBy"]);
                    txtAllergies.Text = Convert.ToString(dtStaffDetails.Rows[0]["sAllergies"]);
                    cmbBloodGroup.Text = Convert.ToString(dtStaffDetails.Rows[0]["sBloodGroup"]);
                    txtWorkedSince.Text = Convert.ToString(dtStaffDetails.Rows[0]["sWorkingSince"]);
                    txtDailyWages.Text = Convert.ToString(dtStaffDetails.Rows[0]["sDailyWages"]);
                    txtSalary.Text = Convert.ToString(dtStaffDetails.Rows[0]["sSalary"]);
                    txtUnionID.Text = Convert.ToString(dtStaffDetails.Rows[0]["sUnionID"]);
                    dtUnionRenewDate.Text = Convert.ToString(dtStaffDetails.Rows[0]["dtUnionIDRenewalDate"]);
                    txtlic1No.Text = Convert.ToString(dtStaffDetails.Rows[0]["sFirstLicenseNumber"]);
                    dtLic1RenewDate.Text = Convert.ToString(dtStaffDetails.Rows[0]["dtFirstLicenseRenewalDate"]);
                    txtLic2No.Text = Convert.ToString(dtStaffDetails.Rows[0]["sSecondLicenseNumber"]);
                    dtLic2RenewDate.Text = Convert.ToString(dtStaffDetails.Rows[0]["dtSecondLicenseRenewalDate"]);
                    txtLic3No.Text = Convert.ToString(dtStaffDetails.Rows[0]["sThirdLicenseNumber"]);
                    dtLic3RenewDate.Text = Convert.ToString(dtStaffDetails.Rows[0]["dtThirdLicenseRenewalDate"]);

                    byte[] empImage = null;
                    if (dtStaffDetails.Rows[0]["sPhoto"] != DBNull.Value)
                    {
                        empImage = (byte[])dtStaffDetails.Rows[0]["sPhoto"];
                        MemoryStream msHeaderImage = new MemoryStream(empImage);
                        picEmployeemage.Image = Image.FromStream(msHeaderImage);
                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void dtEmpBirthdate_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32((DateTime.Now - Convert.ToDateTime(dtEmpBirthdate.Text)).Days) / 365;
                if (num > 0)
                {
                    txtEmpAge.Text = num.ToString();
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
    }
}
