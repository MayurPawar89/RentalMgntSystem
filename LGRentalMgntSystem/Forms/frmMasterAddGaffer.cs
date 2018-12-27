using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGRentalMgntSystem
{
    public partial class frmMasterAddGaffer : DevExpress.XtraEditors.XtraForm
    {
        public frmMasterAddGaffer()
        {
            InitializeComponent();
            FillMasterData();
            GetAndSetSequence();
            txtGafferName.Focus();
        }
        public frmMasterAddGaffer(Int64 nGafferID)
        {
            InitializeComponent();
            lblGafferID.Text = Convert.ToString(nGafferID);
            FillMasterData();
            GetAndSetSequence();
            txtGafferName.Focus();
        }

      
        private void frmMasterAddGaffer_Load(object sender, EventArgs e)
        {
            try
            {
                dtGafferBirthdate.EditValue = DateTime.Now;

                if (Convert.ToInt64(lblGafferID.Text) > 0)
                {
                    FillGafferMemberDetails(Convert.ToInt64(lblGafferID.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void FillMasterData()
        {
            txtCountry.Text = "India";
            txtCity.Text = "Mumbai";
            txtState.Text = "Maharashtra";
            //clsGeneral oclsGeneral = null;
            //try
            //{
            //    oclsGeneral = new clsGeneral();
            //    DataSet dsGaffer = oclsGeneral.GetGafferMaster();
            //    if (dsGaffer != null && dsGaffer.Tables.Count > 0)
            //    {
            //        DataTable dtStateMaster = dsGaffer.Tables[0];
            //        DataTable dtCityMaster = dsGaffer.Tables[1];
            //        DataTable dtCountryMaster = dsGaffer.Tables[2];

            //        cmbStateMaster.DataSource = dtStateMaster;
            //        cmbStateMaster.DisplayMember = "StateName";
            //        cmbStateMaster.ValueMember = "StateName";
            //        cmbStateMaster.Text = "Maharashtra";

            //        cmbCityMaster.DataSource = dtCityMaster;
            //        cmbCityMaster.DisplayMember = "CityName";
            //        cmbCityMaster.ValueMember = "CityName";
            //        cmbCityMaster.Text = "Mumbai";

            //        cmbCountryMaster.DataSource = dtCountryMaster;
            //        cmbCountryMaster.DisplayMember = "sCountryName";
            //        cmbCountryMaster.ValueMember = "sCountryName";
            //        cmbCountryMaster.Text = "India";

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //finally
            //{
            //    if (oclsGeneral != null)
            //    {
            //        oclsGeneral.Dispose();
            //        oclsGeneral = null;
            //    }
            //}
        }
        private void GetAndSetSequence()
        {
            clsGeneral oclsGeneral = null;
            try
            {
                oclsGeneral = new clsGeneral();
                txtGafferCode.Text = "EMP/GF/" + Convert.ToString(oclsGeneral.GetSequenceNumber(MainMasterType.Gaffer.GetHashCode()));
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
        private void FillGafferMemberDetails(long nGafferID)
        {
            GafferMaster oclsGafferMaster = null;
            DataTable dtGafferDetails = null;
            try
            {
                oclsGafferMaster = new GafferMaster();
                dtGafferDetails = oclsGafferMaster.GetGafferInformation(nGafferID);

                if (dtGafferDetails != null && dtGafferDetails.Rows.Count > 0)
                {
                    lblGafferID.Text = Convert.ToString(dtGafferDetails.Rows[0]["nGafferID"]);
                    txtGafferCode.Text = Convert.ToString(dtGafferDetails.Rows[0]["sGafferCode"]);
                    txtGafferName.Text = Convert.ToString(dtGafferDetails.Rows[0]["sGafferName"]);
                    txtGafferAbbrivation.Text = Convert.ToString(dtGafferDetails.Rows[0]["sGafferAbbrivation"]);
                    cmbGender.Text = Convert.ToString(dtGafferDetails.Rows[0]["sGender"]);
                    dtGafferBirthdate.Text = Convert.ToString(dtGafferDetails.Rows[0]["dtDOB"]);
                    txtGafferAge.Text = Convert.ToString(dtGafferDetails.Rows[0]["sAge"]);
                    txtAddressLine1.Text = Convert.ToString(dtGafferDetails.Rows[0]["sAddressLine1"]);
                    txtAddressLine2.Text = Convert.ToString(dtGafferDetails.Rows[0]["sAddressLine2"]);
                    txtCity.Text = Convert.ToString(dtGafferDetails.Rows[0]["sCity"]);
                    txtState.Text = Convert.ToString(dtGafferDetails.Rows[0]["sState"]);
                    txtCountry.Text = Convert.ToString(dtGafferDetails.Rows[0]["sCountry"]);
                    txtPincode.Text = Convert.ToString(dtGafferDetails.Rows[0]["sPincode"]);
                    txtEmail.Text = Convert.ToString(dtGafferDetails.Rows[0]["sEmail"]);
                    txtGafferUserName.Text = Convert.ToString(dtGafferDetails.Rows[0]["sLoginName"]);
                    txtGafferPin.Text = Convert.ToString(dtGafferDetails.Rows[0]["sLoginPin"]);
                    txtGafferPassword.Text = Convert.ToString(dtGafferDetails.Rows[0]["sPassword"]);
                    txtGafferConfirmPassword.Text = Convert.ToString(dtGafferDetails.Rows[0]["sPassword"]);

                    string[] sPhoneAll = Convert.ToString(dtGafferDetails.Rows[0]["sPhoneNo"]).Split(',');
                    if (sPhoneAll.Length > 0)
                    {
                        int nCompPanelCount = GetPanelCount(sPhoneAll.Length);
                        for (int i = 0; i < nCompPanelCount; i++)
                        {
                            ShowHidePhonePanel(sPhoneAll[i], i + 1);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dtGafferBirthdate_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32((DateTime.Now - Convert.ToDateTime(dtGafferBirthdate.Text)).Days) / 365;
                if (num > 0)
                {
                    txtGafferAge.Text = num.ToString();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveGafferMember();
            }
        }
        public bool ValidateForm()
        {
            bool bIsValidForm = true;
            if (txtGafferName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter gaffer name.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bIsValidForm = false;
                txtGafferName.Focus();
                return bIsValidForm;
            }
            
            return bIsValidForm;
        }
        private void SaveGafferMember()
        {
            GafferMaster oclsGafferMaster = null;
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

                oclsGafferMaster = new GafferMaster();
                oclsGafferMaster.nGafferID = Convert.ToInt64(lblGafferID.Text);
                oclsGafferMaster.sGafferName = Convert.ToString(txtGafferName.Text.Trim());
                oclsGafferMaster.sGafferCode = Convert.ToString(txtGafferCode.Text.Trim());
                oclsGafferMaster.sGafferAbbrivation = Convert.ToString(txtGafferAbbrivation.Text.Trim());
                oclsGafferMaster.sGafferGender = Convert.ToString(cmbGender.Text.Trim());
                oclsGafferMaster.dtGafferDOB = Convert.ToDateTime(dtGafferBirthdate.Text.Trim());
                oclsGafferMaster.sGafferAge = Convert.ToString(txtGafferAge.Text.Trim()); 
                oclsGafferMaster.sAddressLine1 = Convert.ToString(txtAddressLine1.Text.Trim());
                oclsGafferMaster.sAddressLine2 = Convert.ToString(txtAddressLine2.Text.Trim());
                oclsGafferMaster.sCity = Convert.ToString(txtCity.Text.Trim());
                oclsGafferMaster.sState = Convert.ToString(txtState.Text.Trim());
                oclsGafferMaster.sCountry = Convert.ToString(txtCountry.Text.Trim());
                oclsGafferMaster.sPincode = Convert.ToString(txtPincode.Text.Trim());
                oclsGafferMaster.sEmail = Convert.ToString(txtEmail.Text.Trim());
                oclsGafferMaster.sAllPhoneNo = sPhoneAll;
                oclsGafferMaster.sUserName = Convert.ToString(txtGafferUserName.Text.Trim());
                oclsGafferMaster.sPassword = Convert.ToString(txtGafferConfirmPassword.Text.Trim());
                oclsGafferMaster.sPin = Convert.ToString(txtGafferPin.Text.Trim());

                Int64 nGafferMemberID = oclsGafferMaster.InsertUpdateGafferMaster();

                if (nGafferMemberID != 0)
                {
                    MessageBox.Show("Gaffer is saved successfully.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Error while saving gaffer.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void txtGafferName_EditValueChanged(object sender, EventArgs e)
        {
            txtGafferAbbrivation.Text = clsGlobal.GenerateAbbrivation(txtGafferName.Text.Trim());
        }

        private void ClearForm()
        {
            txtGafferCode.Text = string.Empty;
            txtGafferName.Text = string.Empty;
            txtGafferAbbrivation.Text = string.Empty;
            cmbGender.Text = string.Empty;
            dtGafferBirthdate.EditValue = DateTime.Now;
            txtGafferAge.Text = string.Empty;
            txtAddressLine1.Text = string.Empty;
            txtAddressLine2.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtState.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPincode.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtGafferUserName.Text = string.Empty;
            txtGafferPin.Text = string.Empty;
            txtGafferPassword.Text = string.Empty;
            txtGafferConfirmPassword.Text = string.Empty;

            txtPhone1.Text = string.Empty;
            txtPhone2.Text = string.Empty;
            txtPhone3.Text = string.Empty;
            txtPhone4.Text = string.Empty;
            txtPhone5.Text = string.Empty;

            GetAndSetSequence();
        }
    }
}
