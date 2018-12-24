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
    public partial class frmMasterAddParty : DevExpress.XtraEditors.XtraForm
    {
        public frmMasterAddParty()
        {
            InitializeComponent();
            fillMasterData();
            GetAndSetSequence();
            txtPartyName.Focus();
        }

        public frmMasterAddParty(Int64 nPartyID)
        {
            InitializeComponent();
            lblPartyID.Text = Convert.ToString(nPartyID);
            fillMasterData();
            GetAndSetSequence();
            txtPartyName.Focus();
        }

        private void fillMasterData()
        {
            clsGeneral oclsGeneral = null;
            try
            {
                oclsGeneral = new clsGeneral();
                DataSet dsParty = oclsGeneral.GetPartyMaster();
                if (dsParty != null && dsParty.Tables.Count > 0)
                {
                    DataTable dtPartyType = dsParty.Tables[0];
                    DataTable dtStateMaster = dsParty.Tables[1];
                    DataTable dtCityMaster = dsParty.Tables[2];
                    DataTable dtCountryMaster = dsParty.Tables[3];

                    cmbPartyType.DataSource = dtPartyType;
                    cmbPartyType.DisplayMember = "sPartyTypeName";
                    cmbPartyType.ValueMember = "nPartyTypeID";

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

        private void GetAndSetSequence()
        {
            clsGeneral oclsGeneral = null;
            try
            {
                oclsGeneral = new clsGeneral();
                txtPartyCode.Text = "PRT/" + Convert.ToString(oclsGeneral.GetSequenceNumber(MainMasterType.Party.GetHashCode()));
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

        private void frmMasterAddParty_Load(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt64(lblPartyID.Text) > 0)
                {
                    FillPartyDetails(Convert.ToInt64(lblPartyID.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void FillPartyDetails(Int64 nPartyID)
        {
            PartyMaster clsPartyMaster = null;
            DataTable dtPartyDetails = null;
            try
            {
                clsPartyMaster = new PartyMaster();
                dtPartyDetails = clsPartyMaster.GetPartyInformation(nPartyID);

                if (dtPartyDetails!=null&&dtPartyDetails.Rows.Count>0)
                {
                    lblPartyID.Text = Convert.ToString(dtPartyDetails.Rows[0]["nPartyID"]);
                    txtPartyCode.Text = Convert.ToString(dtPartyDetails.Rows[0]["sPartyCode"]);
                    txtPartyAbbrivation.Text = Convert.ToString(dtPartyDetails.Rows[0]["sPartyAbbrivation"]);
                    txtPartyName.Text = Convert.ToString(dtPartyDetails.Rows[0]["sPartyName"]);
                    cmbPartyType.SelectedValue = Convert.ToString(dtPartyDetails.Rows[0]["nPartyType"]);
                    txtAddressLine1.Text = Convert.ToString(dtPartyDetails.Rows[0]["sAddressLine1"]);
                    txtAddressLine2.Text = Convert.ToString(dtPartyDetails.Rows[0]["sAddressLine2"]);
                    cmbCityMaster.Text = Convert.ToString(dtPartyDetails.Rows[0]["sCity"]);
                    cmbStateMaster.Text = Convert.ToString(dtPartyDetails.Rows[0]["sState"]);
                    cmbCountryMaster.Text = Convert.ToString(dtPartyDetails.Rows[0]["sCountry"]);
                    txtPincode.Text = Convert.ToString(dtPartyDetails.Rows[0]["sPincode"]);
                    txtEmailID.Text = Convert.ToString(dtPartyDetails.Rows[0]["sEmail"]);
                    txtFaxNo.Text = Convert.ToString(dtPartyDetails.Rows[0]["sFax"]);
                    txtBillToAddressLine1.Text = Convert.ToString(dtPartyDetails.Rows[0]["sBillToAddressLine1"]);
                    txtBillToAddressLine2.Text = Convert.ToString(dtPartyDetails.Rows[0]["sBillToAddressLine2"]);
                    txtBillToPincode.Text = Convert.ToString(dtPartyDetails.Rows[0]["sBillToPincode"]);
                    txtShipToAddressLine1.Text = Convert.ToString(dtPartyDetails.Rows[0]["sShipToAddressLine1"]);
                    txtShipToAddressLine1.Text = Convert.ToString(dtPartyDetails.Rows[0]["sShipToAddressLine2"]);
                    txtShipToPincode.Text = Convert.ToString(dtPartyDetails.Rows[0]["sShipToPincode"]);
                    txtGSTNo.Text = Convert.ToString(dtPartyDetails.Rows[0]["sGSTNO"]);
                    txtPANNo.Text = Convert.ToString(dtPartyDetails.Rows[0]["sPANNO"]);
                    txtTANNo.Text = Convert.ToString(dtPartyDetails.Rows[0]["sTANNO"]);
                    string[] sPhoneAll = Convert.ToString(dtPartyDetails.Rows[0]["sPhoneNo"]).Split(',');
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

        private void txtPartyName_EditValueChanged(object sender, EventArgs e)
        {
            txtPartyAbbrivation.Text = clsGlobal.GenerateAbbrivation(txtPartyName.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SavePartyMember(); 
            }
        }
        public bool ValidateForm()
        {
            bool bIsValidForm = true;
            if (txtPartyName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter party name.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bIsValidForm = false;
                txtPartyName.Focus();
                return bIsValidForm;
            }
            if (cmbPartyType.Text=="")
            {
                MessageBox.Show("Please select party type.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bIsValidForm = false;
                cmbPartyType.Focus();
                return bIsValidForm;
            }
            return bIsValidForm;
        }
        private void SavePartyMember()
        {
            PartyMaster clsPartyMaster = null;
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

                clsPartyMaster = new PartyMaster();
                clsPartyMaster.nPartyID = Convert.ToInt64(lblPartyID.Text);
                clsPartyMaster.nPartyTypeID = Convert.ToInt64(cmbPartyType.SelectedValue);
                clsPartyMaster.sPartyName = Convert.ToString(txtPartyName.Text.Trim());
                clsPartyMaster.sPartyCode = Convert.ToString(txtPartyCode.Text.Trim());
                clsPartyMaster.sPartyAbbrivation = Convert.ToString(txtPartyAbbrivation.Text.Trim());
                clsPartyMaster.sAddressLine1 = Convert.ToString(txtAddressLine1.Text.Trim());
                clsPartyMaster.sAddressLine2 = Convert.ToString(txtAddressLine2.Text.Trim());
                clsPartyMaster.sCity = Convert.ToString(cmbCityMaster.Text.Trim());
                clsPartyMaster.sState = Convert.ToString(cmbStateMaster.Text.Trim());
                clsPartyMaster.sCountry = Convert.ToString(cmbCountryMaster.Text.Trim());
                clsPartyMaster.sPincode = Convert.ToString(txtPincode.Text.Trim());
                clsPartyMaster.sEmail = Convert.ToString(txtEmailID.Text.Trim());
                clsPartyMaster.sAllPhoneNo = sPhoneAll;
                clsPartyMaster.sFax = Convert.ToString (txtFaxNo.Text.ToString());
                clsPartyMaster.sGSTNo = Convert.ToString(txtGSTNo.Text.Trim());
                clsPartyMaster.sPANNo = Convert.ToString(txtPANNo.Text.Trim());
                clsPartyMaster.sTANNo = Convert.ToString(txtTANNo.Text.Trim());
                clsPartyMaster.sBillToAddressLine1 = Convert.ToString(txtBillToAddressLine1.Text.Trim());
                clsPartyMaster.sBillToAddressLine2 = Convert.ToString(txtBillToAddressLine1.Text.Trim());
                clsPartyMaster.sBillToPincode = Convert.ToString(txtBillToPincode.Text.Trim());
                clsPartyMaster.sShipToAddressLine1 = Convert.ToString(txtShipToAddressLine1.Text.Trim());
                clsPartyMaster.sShipToAddressLine2 = Convert.ToString(txtShipToPincode.Text.Trim());
                clsPartyMaster.sShipToPincode = Convert.ToString(txtShipToPincode.Text.Trim());

                Int64 nCrewMemberID = clsPartyMaster.InsertUpdatePartyMaster();

                if (nCrewMemberID != 0)
                {
                    MessageBox.Show("Party is saved successfully.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error while saving party.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
