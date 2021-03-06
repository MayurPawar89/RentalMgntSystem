﻿using System;
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
        public Int64 nSignatoryID { get; set; }
        private void GetAndSetSequence()
        {
            clsGeneral oclsGeneral = null;
            try
            {
                oclsGeneral = new clsGeneral();
                txtEmployeeCode.Text = "EMP/" + Convert.ToString(oclsGeneral.GetSequenceNumber(MainMasterType.Crew.GetHashCode()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            txtCountry.Text = "India";
            txtCity.Text = "Mumbai";
            txtState.Text = "Maharashtra";
            clsGeneral oclsGeneral = null;
            try
            {
                oclsGeneral = new clsGeneral();
                DataSet dsCrew = oclsGeneral.GetCrewMaster();
                if (dsCrew != null && dsCrew.Tables.Count > 0)
                {
                    DataTable dtCompanyType = dsCrew.Tables[0];
                    //DataTable dtStateMaster = dsCrew.Tables[1];
                    //DataTable dtCityMaster = dsCrew.Tables[2];
                    //DataTable dtCountryMaster = dsCrew.Tables[3];
                    DataTable dtDesignation = dsCrew.Tables[4];

                    DataRow drComp = dtCompanyType.NewRow();
                    drComp["nCompanyID"] = 0;
                    drComp["sCompanyName"] = "";
                    dtCompanyType.Rows.InsertAt(drComp, 0);

                    DataRow drDesg = dtDesignation.NewRow();
                    drDesg["nDesignationID"] = 0;
                    drDesg["sDesignationName"] = "";
                    drDesg["SettingStatus"] = 0;
                    dtDesignation.Rows.InsertAt(drDesg, 0);

                    cmbEmpCompany.DataSource = dtCompanyType;
                    cmbEmpCompany.DisplayMember = "sCompanyName";
                    cmbEmpCompany.ValueMember = "nCompanyID";

                    //cmbStateMaster.DataSource = dtStateMaster;
                    //cmbStateMaster.DisplayMember = "StateName";
                    //cmbStateMaster.ValueMember = "StateName";
                    //cmbStateMaster.Text = "Maharashtra";

                    //cmbCityMaster.DataSource = dtCityMaster;
                    //cmbCityMaster.DisplayMember = "CityName";
                    //cmbCityMaster.ValueMember = "CityName";
                    //cmbCityMaster.Text = "Mumbai";

                    //cmbCountryMaster.DataSource = dtCountryMaster;
                    //cmbCountryMaster.DisplayMember = "sCountryName";
                    //cmbCountryMaster.ValueMember = "sCountryName";
                    //cmbCountryMaster.Text = "India";

                    cmbEmpDesignation.SelectedIndexChanged -= cmbEmpDesignation_SelectedIndexChanged;
                    cmbEmpDesignation.DataSource = dtDesignation;
                    cmbEmpDesignation.DisplayMember = "sDesignationName";
                    cmbEmpDesignation.ValueMember = "nDesignationID";
                    cmbEmpDesignation.SelectedIndexChanged += cmbEmpDesignation_SelectedIndexChanged;

                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        void cmbEmpDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt64(cmbEmpDesignation.SelectedValue) != 0)
                {
                    bool bAllowAccess = false;
                    DataTable dtSource = (DataTable)cmbEmpDesignation.DataSource;
                    if (dtSource != null)
                    {
                        DataRow[] dr = dtSource.Select("nDesignationID=" + cmbEmpDesignation.SelectedValue);
                        if (dr != null)
                        {
                            bAllowAccess = Convert.ToBoolean(dr[0]["SettingStatus"]);
                        }
                    }
                    if (bAllowAccess==true)
                    {
                        pnlLoginDetails.Visible = true;
                    }
                    else
                    {
                        pnlLoginDetails.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtEmployeeName_EditValueChanged(object sender, EventArgs e)
        {
            txtEmpAbbrivation.Text = clsGlobal.GenerateAbbrivation(txtEmployeeName.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveCrewMember();
            }
        }
        public bool ValidateForm()
        {
            bool bIsValidForm = true;
            if (txtEmployeeName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter employee name.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bIsValidForm = false;
                txtEmployeeName.Focus();
                return bIsValidForm;
            }
            if (cmbEmpDesignation.Text.Trim()=="")
            {
                 MessageBox.Show("Please select designation.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bIsValidForm = false;
                cmbEmpDesignation.Focus();
                return bIsValidForm;
            }
            if (cmbEmpCompany.Text.Trim() == "")
            {
                MessageBox.Show("Please select company.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bIsValidForm = false;
                cmbEmpCompany.Focus();
                return bIsValidForm;
            }
            if (pnlLoginDetails.Visible==true)
            {
                if (txtGafferUserName.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter username.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bIsValidForm = false;
                    txtGafferUserName.Focus();
                    return bIsValidForm;
                }
                if (txtGafferPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter password.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bIsValidForm = false;
                    txtGafferPassword.Focus();
                    return bIsValidForm;
                }
                if (txtGafferConfirmPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter confirm password.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bIsValidForm = false;
                    txtGafferConfirmPassword.Focus();
                    return bIsValidForm;
                }
                if (txtGafferPin.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter pin.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bIsValidForm = false;
                    txtGafferPin.Focus();
                    return bIsValidForm;
                }
                if (txtGafferPassword.Text.Length <8)
                {
                    MessageBox.Show("Password shold be more than 8 characters.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bIsValidForm = false;
                    txtGafferPassword.Focus();
                    return bIsValidForm;
                }
                if (txtGafferPassword.Text.Trim() != txtGafferConfirmPassword.Text.Trim())
                {
                    MessageBox.Show("Password and confirm password not match.\nPassword & confirm password must be same.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bIsValidForm = false;
                    txtGafferPassword.Focus();
                    return bIsValidForm;
                } 
            }
            return bIsValidForm;
        }
        private void SaveCrewMember()
        {
            StaffMaster clsStaffMaster = null;
            try
            {
                string sPhone1 = Convert.ToString(txtPhone1.Text.Trim());
                string sPhone2 = Convert.ToString(txtPhone4.Text.Trim());
                string sPhone3 = Convert.ToString(txtPhone5.Text.Trim());
                string sPhone4 = Convert.ToString(txtPhone3.Text.Trim());
                string sPhone5 = Convert.ToString(txtPhone2.Text.Trim());
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
                clsStaffMaster.sCity = Convert.ToString(txtCity.Text.Trim());
                clsStaffMaster.sState = Convert.ToString(txtState.Text.Trim());
                clsStaffMaster.sCountry = Convert.ToString(txtCountry.Text.Trim());
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
                if (pnlLoginDetails.Visible==true)
                {
                    clsStaffMaster.bIsAllowAccess = true;
                    clsStaffMaster.sUserName = Convert.ToString(txtGafferUserName.Text.Trim());
                    clsStaffMaster.sPin = Convert.ToString(txtGafferPin.Text.Trim());
                    clsStaffMaster.sPassword = Convert.ToString(clsEncryption.EncryptToBase64String(txtGafferConfirmPassword.Text.Trim())); 
                }
                
                Int64 nCrewMemberID = clsStaffMaster.InsertUpdateStaffMaster();

                if (nCrewMemberID != 0)
                {
                    MessageBox.Show("Crew member is saved successfully.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Error while saving crew member.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void frmMasterAddCrew_Load(object sender, EventArgs e)
        {
            try
            {
                dtEmpBirthdate.EditValueChanged-=dtEmpBirthdate_EditValueChanged;
                dtEmpBirthdate.EditValue = DateTime.Now;
                dtEmpBirthdate.EditValueChanged += dtEmpBirthdate_EditValueChanged;

                dtEmpDOJ.EditValue = DateTime.Now;
                dtLic1RenewDate.EditValue = DateTime.Now;
                dtLic2RenewDate.EditValue = DateTime.Now;
                dtLic3RenewDate.EditValue = DateTime.Now;
                dtUnionRenewDate.EditValue = DateTime.Now;
                if (Convert.ToInt64(lblEmployeeID.Text) > 0)
                {
                    FillCrewMemberDetails(Convert.ToInt64(lblEmployeeID.Text));
                }
                if (nSignatoryID != 0)
                {
                    cmbEmpDesignation.SelectedValue = nSignatoryID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void FillCrewMemberDetails(long nStaffID)
        {
            StaffMaster clsStaffMaster = null;
            DataTable dtStaffDetails = null;
            try
            {
                clsStaffMaster = new StaffMaster();
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
                    dtEmpBirthdate.EditValue = Convert.ToDateTime(dtStaffDetails.Rows[0]["dtDOB"]);
                    txtEmpAge.Text = Convert.ToString(dtStaffDetails.Rows[0]["sAge"]);
                    txtAddressLine1.Text = Convert.ToString(dtStaffDetails.Rows[0]["sAddressLine1"]);
                    txtAddressLine2.Text = Convert.ToString(dtStaffDetails.Rows[0]["sAddressLine2"]);
                    txtCity.Text = Convert.ToString(dtStaffDetails.Rows[0]["sCity"]);
                    txtState.Text = Convert.ToString(dtStaffDetails.Rows[0]["sState"]);
                    txtCountry.Text = Convert.ToString(dtStaffDetails.Rows[0]["sCountry"]);
                    txtPincode.Text = Convert.ToString(dtStaffDetails.Rows[0]["sPincode"]);
                    txtEmail.Text = Convert.ToString(dtStaffDetails.Rows[0]["sEmail"]);
                    txtPermanentAddressLine1.Text = Convert.ToString(dtStaffDetails.Rows[0]["sPermanentAddressLine1"]);
                    txtPermanentAddressLine2.Text = Convert.ToString(dtStaffDetails.Rows[0]["sPermanentAddressLine2"]);
                    txtPermanentPincode.Text = Convert.ToString(dtStaffDetails.Rows[0]["sPermanentPincode"]);
                    txtDistrictTownVillage.Text = Convert.ToString(dtStaffDetails.Rows[0]["sPermanentDistTown"]);
                    dtEmpDOJ.EditValue = Convert.ToDateTime(dtStaffDetails.Rows[0]["dtDOJ"]);
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
                    dtUnionRenewDate.EditValue = Convert.ToDateTime(dtStaffDetails.Rows[0]["dtUnionIDRenewalDate"]);
                    txtlic1No.Text = Convert.ToString(dtStaffDetails.Rows[0]["sFirstLicenseNumber"]);
                    dtLic1RenewDate.EditValue = Convert.ToDateTime(dtStaffDetails.Rows[0]["dtFirstLicenseRenewalDate"]);
                    txtLic2No.Text = Convert.ToString(dtStaffDetails.Rows[0]["sSecondLicenseNumber"]);
                    dtLic2RenewDate.EditValue = Convert.ToDateTime(dtStaffDetails.Rows[0]["dtSecondLicenseRenewalDate"]);
                    txtLic3No.Text = Convert.ToString(dtStaffDetails.Rows[0]["sThirdLicenseNumber"]);
                    dtLic3RenewDate.EditValue = Convert.ToDateTime(dtStaffDetails.Rows[0]["dtThirdLicenseRenewalDate"]);

                    string[] sPhoneAll = Convert.ToString(dtStaffDetails.Rows[0]["sPhoneNo"]).Split(',');
                    if (sPhoneAll.Length > 0)
                    {
                        int nCompPanelCount = GetPanelCount(sPhoneAll.Length);
                        for (int i = 0; i < nCompPanelCount; i++)
                        {
                            ShowHidePhonePanel(sPhoneAll[i], i + 1);
                        }
                    }
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
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private int GetPanelCount(int nStringLength)
        {
            int nPanelCount = 0;
            if (nStringLength <= 5)
            {
                switch (nStringLength)
                {
                    case 1: nPanelCount = 1; break;
                    case 2: nPanelCount = 2; break;
                    case 3: nPanelCount = 3; break;
                    case 4: nPanelCount = 4; break;
                    case 5: nPanelCount = 5; break;
                }
            }
            return nPanelCount;
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
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void ClearForm()
        {
            txtEmployeeName.Text = string.Empty;
            cmbEmpDesignation.SelectedValue = 0;
            cmbEmpCompany.SelectedValue = 0;
            txtEmpAbbrivation.Text = string.Empty;
            cmbGender.SelectedValue = "";
            dtEmpBirthdate.EditValue = DateTime.Now;
            txtEmpAge.Text = string.Empty;
            txtAddressLine1.Text = string.Empty;
            txtAddressLine2.Text = string.Empty;
            txtCountry.Text = "India";
            txtCity.Text = "Mumbai";
            txtState.Text = "Maharashtra";
            txtPincode.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPermanentAddressLine1.Text = string.Empty;
            txtPermanentAddressLine2.Text = string.Empty;
            txtPermanentPincode.Text = string.Empty;
            txtDistrictTownVillage.Text = string.Empty;
            dtEmpDOJ.EditValue = DateTime.Now;
            txtGSTNNo.Text = string.Empty;
            txtPANNo.Text = string.Empty;
            txtAadharNo.Text = string.Empty;
            txtReferenceBy.Text = string.Empty;
            txtAllergies.Text = string.Empty;
            cmbBloodGroup.Text = string.Empty;
            txtWorkedSince.Text = string.Empty;
            txtDailyWages.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtUnionID.Text = string.Empty;
            dtUnionRenewDate.EditValue = DateTime.Now;
            txtlic1No.Text = string.Empty;
            dtLic1RenewDate.EditValue = DateTime.Now;
            txtLic2No.Text = string.Empty;
            dtLic2RenewDate.EditValue = DateTime.Now;
            txtLic3No.Text = string.Empty;
            dtLic3RenewDate.EditValue = DateTime.Now;

            txtPhone1.Text = string.Empty;
            txtPhone2.Text = string.Empty;
            txtPhone3.Text = string.Empty;
            txtPhone4.Text = string.Empty;
            txtPhone5.Text = string.Empty;
            GetAndSetSequence();
            if (picEmployeemage != null)
            {
                picEmployeemage.Image = null;
            }
        }
    }
}
