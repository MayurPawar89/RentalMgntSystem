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
    public partial class frmMasterAddCompany : DevExpress.XtraEditors.XtraForm
    {
        public frmMasterAddCompany()
        {
            InitializeComponent();
            fillMasterData();
            GetAndSetSequence();
            txtCompanyName.Focus();
            ShowHidePhonePanel();
        }

        public frmMasterAddCompany(Int64 nCompanyID)
        {
            InitializeComponent();
            lblCompanyID.Text = Convert.ToString(nCompanyID);
            fillMasterData();
            //GetAndSetSequence();
            txtCompanyName.Focus();
            ShowHidePhonePanel();
        }

        private void ShowHidePhonePanel(string sPhoneType="",string sPhoneNo="",int PhoneCount=1)
        {
            switch (PhoneCount)
            {
                case 1:
                    {
                        if (sPhoneType.ToLower() == "company")
                        {
                            pnlPhoneOne.Visible = true;
                            pnlPhoneTwo.Visible = false;
                            pnlPhoneThree.Visible = false;
                            pnlPhoneFour.Visible = false;
                            pnlPhoneFive.Visible = false;
                            txtPhone1.Text = sPhoneNo;
                        }
                        else if (sPhoneType.ToLower() == "wh")
                        {
                            pnlWHPhone1.Visible = true;
                            pnlWHPhone2.Visible = false;
                            pnlWHPhone3.Visible = false;
                            pnlWHPhone4.Visible = false;
                            pnlWHPhone5.Visible = false;
                            txtWHPhone1.Text = sPhoneNo;
                        }
                        else
                        {
                            pnlPhoneOne.Visible = true;
                            pnlPhoneTwo.Visible = false;
                            pnlPhoneThree.Visible = false;
                            pnlPhoneFour.Visible = false;
                            pnlPhoneFive.Visible = false;

                            pnlWHPhone1.Visible = true;
                            pnlWHPhone2.Visible = false;
                            pnlWHPhone3.Visible = false;
                            pnlWHPhone4.Visible = false;
                            pnlWHPhone5.Visible = false;

                            txtPhone1.Text = sPhoneNo;
                            txtWHPhone1.Text = sPhoneNo;
                        }
                        break;
                    }
                case 2:
                    {
                        if (sPhoneType.ToLower() == "company")
                        {
                            pnlPhoneOne.Visible = true;
                            pnlPhoneTwo.Visible = true;
                            pnlPhoneTwo.BringToFront();
                            pnlPhoneThree.Visible = false;
                            pnlPhoneFour.Visible = false;
                            pnlPhoneFive.Visible = false;
                            txtPhone2.Text = sPhoneNo;
                        }
                        else if (sPhoneType.ToLower() == "wh")
                        {
                            pnlWHPhone1.Visible = true;
                            pnlWHPhone2.Visible = true;
                            pnlWHPhone2.BringToFront();
                            pnlWHPhone3.Visible = false;
                            pnlWHPhone4.Visible = false;
                            pnlWHPhone5.Visible = false;
                            txtWHPhone2.Text = sPhoneNo;
                        }
                        else
                        {
                            pnlPhoneOne.Visible = true;
                            pnlPhoneTwo.Visible = true;
                            pnlPhoneTwo.BringToFront();
                            pnlPhoneThree.Visible = false;
                            pnlPhoneFour.Visible = false;
                            pnlPhoneFive.Visible = false;

                            pnlWHPhone1.Visible = true;
                            pnlWHPhone2.Visible = true;
                            pnlWHPhone2.BringToFront();
                            pnlWHPhone3.Visible = false;
                            pnlWHPhone4.Visible = false;
                            pnlWHPhone5.Visible = false;

                            txtPhone2.Text = sPhoneNo;
                            txtWHPhone2.Text = sPhoneNo;
                        }
                        break;
                    }
                case 3:
                    {
                        if (sPhoneType.ToLower() == "company")
                        {
                            pnlPhoneOne.Visible = true;
                            pnlPhoneTwo.Visible = true;
                            pnlPhoneThree.Visible = true;
                            pnlPhoneThree.BringToFront();
                            pnlPhoneFour.Visible = false;
                            pnlPhoneFive.Visible = false;
                            txtPhone3.Text = sPhoneNo;
                        }
                        else if (sPhoneType.ToLower() == "wh")
                        {
                            pnlWHPhone1.Visible = true;
                            pnlWHPhone2.Visible = true;
                            pnlWHPhone3.Visible = true;
                            pnlWHPhone3.BringToFront();
                            pnlWHPhone4.Visible = false;
                            pnlWHPhone5.Visible = false;
                            txtWHPhone3.Text = sPhoneNo;
                        }
                        else
                        {
                            pnlPhoneOne.Visible = true;
                            pnlPhoneTwo.Visible = true;
                            pnlPhoneThree.Visible = true;
                            pnlPhoneThree.BringToFront();
                            pnlPhoneFour.Visible = false;
                            pnlPhoneFive.Visible = false;

                            pnlWHPhone1.Visible = true;
                            pnlWHPhone2.Visible = true;
                            pnlWHPhone3.Visible = true;
                            pnlWHPhone3.BringToFront();
                            pnlWHPhone4.Visible = false;
                            pnlWHPhone5.Visible = false;

                            txtPhone3.Text = sPhoneNo;
                            txtWHPhone3.Text = sPhoneNo;
                        }
                        break;
                    }
                case 4:
                    {
                        if (sPhoneType.ToLower() == "company")
                        {
                            pnlPhoneOne.Visible = true;
                            pnlPhoneTwo.Visible = true;
                            pnlPhoneThree.Visible = true;
                            pnlPhoneFour.Visible = true;
                            pnlPhoneFour.BringToFront();
                            pnlPhoneFive.Visible = false;
                            txtPhone4.Text = sPhoneNo;
                        }
                        else if (sPhoneType.ToLower() == "wh")
                        {
                            pnlWHPhone1.Visible = true;
                            pnlWHPhone2.Visible = true;
                            pnlWHPhone3.Visible = true;
                            pnlWHPhone4.Visible = true;
                            pnlWHPhone4.BringToFront();
                            pnlWHPhone5.Visible = false;
                            txtWHPhone4.Text = sPhoneNo;
                        }
                        else
                        {
                            pnlPhoneOne.Visible = true;
                            pnlPhoneTwo.Visible = true;
                            pnlPhoneThree.Visible = true;
                            pnlPhoneFour.Visible = true;
                            pnlPhoneFour.BringToFront();
                            pnlPhoneFive.Visible = false;

                            pnlWHPhone1.Visible = true;
                            pnlWHPhone2.Visible = true;
                            pnlWHPhone3.Visible = true;
                            pnlWHPhone4.Visible = true;
                            pnlWHPhone4.BringToFront();
                            pnlWHPhone5.Visible = false;

                            txtPhone4.Text = sPhoneNo;
                            txtWHPhone4.Text = sPhoneNo;
                        }
                        break;
                    }
                case 5:
                    {
                        if (sPhoneType.ToLower() == "company")
                        {
                            pnlPhoneOne.Visible = true;
                            pnlPhoneTwo.Visible = true;
                            pnlPhoneThree.Visible = true;
                            pnlPhoneFour.Visible = true;
                            pnlPhoneFive.Visible = true;
                            pnlPhoneFive.BringToFront();
                            txtPhone5.Text = sPhoneNo;
                        }
                        else if (sPhoneType.ToLower() == "wh")
                        {
                            pnlWHPhone1.Visible = true;
                            pnlWHPhone2.Visible = true;
                            pnlWHPhone3.Visible = true;
                            pnlWHPhone4.Visible = true;
                            pnlWHPhone5.Visible = true;
                            pnlWHPhone5.BringToFront();
                            txtWHPhone5.Text = sPhoneNo;
                        }
                        else
                        {
                            pnlPhoneOne.Visible = true;
                            pnlPhoneTwo.Visible = true;
                            pnlPhoneThree.Visible = true;
                            pnlPhoneFour.Visible = true;
                            pnlPhoneFive.Visible = true;
                            pnlPhoneFive.BringToFront();

                            pnlWHPhone1.Visible = true;
                            pnlWHPhone2.Visible = true;
                            pnlWHPhone3.Visible = true;
                            pnlWHPhone4.Visible = true;
                            pnlWHPhone5.Visible = true;
                            pnlWHPhone5.BringToFront();

                            txtPhone5.Text = sPhoneNo;
                            txtWHPhone5.Text = sPhoneNo;
                        }
                        break;
                    }

            }
            
        }

        private void fillMasterData()
        {
            clsGeneral oclsGeneral = null;
            try
            {
                oclsGeneral = new clsGeneral();
                DataSet dsCompanyMaster=oclsGeneral.GetCompanyMaster();
                if (dsCompanyMaster!=null && dsCompanyMaster.Tables.Count>0)
                {
                    DataTable dtCompanyType = dsCompanyMaster.Tables[0];
                    DataTable dtStateMaster = dsCompanyMaster.Tables[1];
                    DataTable dtCityMaster = dsCompanyMaster.Tables[2];
                    DataTable dtCountryMaster = dsCompanyMaster.Tables[3];

                    cmbCompanyType.DataSource = dtCompanyType;
                    cmbCompanyType.DisplayMember = "sCompanyTypeName";
                    cmbCompanyType.ValueMember = "nCompanyTypeID";

                    cmbCompStateMaster.DataSource = dtStateMaster;
                    cmbCompStateMaster.DisplayMember = "StateName";
                    cmbCompStateMaster.ValueMember = "StateName";
                    cmbCompStateMaster.Text = "Maharashtra";

                    cmbCompCityMaster.DataSource = dtCityMaster;
                    cmbCompCityMaster.DisplayMember = "CityName";
                    cmbCompCityMaster.ValueMember = "CityName";
                    cmbCompCityMaster.Text = "Mumbai";

                    cmbCompCountryMaster.DataSource = dtCountryMaster;
                    cmbCompCountryMaster.DisplayMember = "sCountryName";
                    cmbCompCountryMaster.ValueMember = "sCountryName";
                    cmbCompCountryMaster.Text = "India";

                    cmbWHCState.DataSource = dtStateMaster.Copy();
                    cmbWHCState.DisplayMember = "StateName";
                    cmbWHCState.ValueMember = "StateName";
                    cmbWHCState.Text = "Maharashtra";

                    cmbWHCity.DataSource = dtCityMaster.Copy();
                    cmbWHCity.DisplayMember = "CityName";
                    cmbWHCity.ValueMember = "CityName";
                    cmbWHCity.Text = "Mumbai";

                    cmbWHCountry.DataSource = dtCountryMaster.Copy();
                    cmbWHCountry.DisplayMember = "sCountryName";
                    cmbWHCountry.ValueMember = "sCountryName";
                    cmbWHCountry.Text = "India";
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

        private void GetAndSetSequence()
        {
            clsGeneral oclsGeneral = null;
            try
            {
                oclsGeneral = new clsGeneral();
                txtCompanyCode.Text = "CMP/" + Convert.ToString(oclsGeneral.GetSequenceNumber(MainMasterType.Company.GetHashCode()));
            }
            catch (Exception)
            {

            }
            finally
            {
                if (oclsGeneral!=null)
                {
                    oclsGeneral.Dispose();
                    oclsGeneral = null;
                }
            }
        }

        private void btnAddCompanyPhone_Click(object sender, EventArgs e)
        {
            int nCompanyPhoneCount = CheckPanelVisibility("Company");
            if (nCompanyPhoneCount <= 5)
            {
                ShowHidePhonePanel("Company", "", nCompanyPhoneCount);
            }
        }

        private int CheckPanelVisibility(string sCheckPanelFor)
        {
            int nPanelCount = 0;
            switch (sCheckPanelFor)
            {
                case "Company":
                    {
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
                        break;
                    }
                case "WH":
                    {
                        if (pnlWHPhone1.Visible == true && pnlWHPhone2.Visible == false && pnlWHPhone3.Visible == false && pnlWHPhone4.Visible == false && pnlWHPhone5.Visible == false)
                        {
                            nPanelCount = 2;
                        }
                        else if (pnlWHPhone1.Visible == true && pnlWHPhone2.Visible == true && pnlWHPhone3.Visible == false && pnlWHPhone4.Visible == false && pnlWHPhone5.Visible == false)
                        {
                            nPanelCount = 3;
                        }
                        else if (pnlWHPhone1.Visible == true && pnlWHPhone2.Visible == true && pnlWHPhone3.Visible == true && pnlWHPhone4.Visible == false && pnlWHPhone5.Visible == false)
                        {
                            nPanelCount = 4;
                        }
                        else if (pnlWHPhone1.Visible == true && pnlWHPhone2.Visible == true && pnlWHPhone3.Visible == true && pnlWHPhone4.Visible == true && pnlWHPhone5.Visible == false)
                        {
                            nPanelCount = 5;
                        }
                        else if (pnlWHPhone1.Visible == true && pnlWHPhone2.Visible == true && pnlWHPhone3.Visible == true && pnlWHPhone4.Visible == true && pnlWHPhone5.Visible == false)
                        {
                            nPanelCount = 6;
                        }
                        break;
                    }
            }
            return nPanelCount;
        }

        private void btnWHAddPhone_Click(object sender, EventArgs e)
        {
            int nWHPhoneCount = CheckPanelVisibility("WH");
            if (nWHPhoneCount <= 5)
            {
                ShowHidePhonePanel("WH","", nWHPhoneCount);
            }
        }

        private void rdImageFormat_CheckedChanged(object sender, EventArgs e)
        {
            FillTermsCondition();
        }
        private void rdTextFormat_CheckedChanged(object sender, EventArgs e)
        {
            FillTermsCondition();
        }
        private void FillTermsCondition()
        {
            if (rdImageFormat.Checked)
            {
                pnlTermsImage.Visible = true;
                pnlTermsImage.BringToFront();
                pnlTermsText.Visible = false;
            }
            else
            {
                pnlTermsText.Visible = true;
                pnlTermsText.BringToFront();
                pnlTermsImage.Visible = false;
            }
        }
        
        private void frmMasterAddCompany_Load(object sender, EventArgs e)
        {
            rdImageFormat.Checked = true;
            if (Convert.ToInt64(lblCompanyID.Text)>0)
            {
                FillCompanyDetails(Convert.ToInt64(lblCompanyID.Text));
            }
        }

        private void FillCompanyDetails(Int64 nCompanyID)
        {
            CompanyMaster clsCompanyMaster = null;
            DataSet ds = null;
            DataTable dtCompDetails = null;
            DataTable dtCompTransDetails = null;
            DataTable dtCompWHDetails = null;
            DataTable dtCompImageDetails = null;
            try
            {
                clsCompanyMaster = new CompanyMaster();
                ds = clsCompanyMaster.GetCompanyInformation(nCompanyID);
                if (ds!=null&&ds.Tables.Count>0)
                {
                    dtCompDetails = ds.Tables[0];
                    dtCompTransDetails = ds.Tables[1];
                    dtCompWHDetails = ds.Tables[2];
                    dtCompImageDetails = ds.Tables[3];

                    if (dtCompDetails!=null&&dtCompDetails.Rows.Count>0)
                    {
                        lblCompanyID.Text = Convert.ToString(dtCompDetails.Rows[0]["nCompanyID"]);
                        lblCompanyInfoImageID.Text = Convert.ToString(dtCompDetails.Rows[0]["nCompanyImageInfoID"]);
                        lblCompanyTransportID.Text = Convert.ToString(dtCompDetails.Rows[0]["nCompanyTransporterID"]);
                        lblCompWarehouseID.Text = Convert.ToString(dtCompDetails.Rows[0]["nCompanyWarehouseID"]);

                        txtCompanyCode.Text = Convert.ToString(dtCompDetails.Rows[0]["sCompanyCode"]);
                        txtCompanyAbbrivation.Text = Convert.ToString(dtCompDetails.Rows[0]["sCompAbbrivation"]);
                        txtCompanyName.Text = Convert.ToString(dtCompDetails.Rows[0]["sCompanyName"]);
                        cmbCompanyType.SelectedValue = Convert.ToInt64(dtCompDetails.Rows[0]["nCompanyTypeID"]);
                        cmbCompanySignatory.SelectedValue = Convert.ToInt64(dtCompDetails.Rows[0]["nCompanySignatory"]);
                        txtAddressLine1.Text = Convert.ToString(dtCompDetails.Rows[0]["sAddressLine1"]);
                        txtAddressLine2.Text = Convert.ToString(dtCompDetails.Rows[0]["sAddressLine2"]);
                        cmbCompCityMaster.Text = Convert.ToString(dtCompDetails.Rows[0]["sCity"]);
                        cmbCompStateMaster.Text = Convert.ToString(dtCompDetails.Rows[0]["sState"]);
                        cmbCompCountryMaster.Text = Convert.ToString(dtCompDetails.Rows[0]["sCountry"]);
                        txtPincode.Text = Convert.ToString(dtCompDetails.Rows[0]["sPincode"]);
                        txtEmail.Text = Convert.ToString(dtCompDetails.Rows[0]["sEmail"]);
                        txtWebsiteURL.Text = Convert.ToString(dtCompDetails.Rows[0]["sWebsite"]);
                        txtFaxNo.Text = Convert.ToString(dtCompDetails.Rows[0]["sFax"]);
                        txtHSN_SAVCode.Text = Convert.ToString(dtCompDetails.Rows[0]["sHSN_SACCode"]);
                        txtGSTNo.Text = Convert.ToString(dtCompDetails.Rows[0]["sGSTNO"]);
                        txtPANNo.Text = Convert.ToString(dtCompDetails.Rows[0]["sPANNO"]);
                        dtCompanyFormedOn.Text = Convert.ToString(dtCompDetails.Rows[0]["dtCompanyFormedOn"]);

                        string[] sPhoneAll = Convert.ToString(dtCompDetails.Rows[0]["sPhoneNo"]).Split(',');
                        if (sPhoneAll.Length > 0)
                        {
                            int nCompPanelCount = GetPanelCount(sPhoneAll.Length);
                            for (int i = 0; i < nCompPanelCount; i++)
                            {
                                ShowHidePhonePanel("Company", sPhoneAll[i], i + 1);
                            }
                        }
                    }

                    if (dtCompTransDetails!=null&&dtCompTransDetails.Rows.Count>0)
                    {
                        txtTransporterID.Text = Convert.ToString(dtCompTransDetails.Rows[0]["sTransportorID"]);
                        txtDocumentName.Text = Convert.ToString(dtCompTransDetails.Rows[0]["sDoumentName"]);
                        txtDocumentNumber.Text = Convert.ToString(dtCompTransDetails.Rows[0]["sDoumentNumber"]);
                        txtDocumentDate.Text = Convert.ToString(dtCompTransDetails.Rows[0]["sDocumentDate"]);
                    }

                    if (dtCompWHDetails!=null&&dtCompWHDetails.Rows.Count>0)
                    {
                        txtWHAddressLine1.Text = Convert.ToString(dtCompWHDetails.Rows[0]["sWarehouseAddressLine1"]);
                        txtWHAddressLine2.Text = Convert.ToString(dtCompWHDetails.Rows[0]["sWarehouseAddressLine2"]);
                        cmbWHCity.Text = Convert.ToString(dtCompWHDetails.Rows[0]["sCity"]);
                        cmbWHCState.Text = Convert.ToString(dtCompWHDetails.Rows[0]["sState"]);
                        cmbWHCountry.Text = Convert.ToString(dtCompWHDetails.Rows[0]["sCountry"]);
                        txtWHPincode.Text = Convert.ToString(dtCompWHDetails.Rows[0]["sPincode"]);
                        cmbWarehouseSupervisor.Text = Convert.ToString(dtCompWHDetails.Rows[0]["nSupervisorID"]);

                        string[] sWHPhoneAll = Convert.ToString(dtCompWHDetails.Rows[0]["sPhoneNo"]).Split(',');
                        if (sWHPhoneAll.Length > 0)
                        {
                            int nPanelCount = GetPanelCount(sWHPhoneAll.Length);
                            for (int i = 0; i < nPanelCount; i++)
                            {
                                ShowHidePhonePanel("WH", sWHPhoneAll[i], i+1);
                            }
                        }
                    }

                    if (dtCompImageDetails!=null&&dtCompImageDetails.Rows.Count>0)
                    {
                        byte[] HeaderImage = null;
                        byte[] FooterImage = null;
                        byte[] Terms_CondImage = null;
                        string sTermsAndCondition = string.Empty;

                        if (dtCompImageDetails.Rows[0]["imgHeaderAddress"] != DBNull.Value)
                        {
                            HeaderImage = (byte[])dtCompImageDetails.Rows[0]["imgHeaderAddress"];
                            MemoryStream msHeaderImage = new MemoryStream(HeaderImage);
                            picHeaderImage.Image = Image.FromStream(msHeaderImage);
                        }
                        if (dtCompImageDetails.Rows[0]["imgFooterAddress"] != DBNull.Value)
                        {
                            FooterImage = (byte[])dtCompImageDetails.Rows[0]["imgFooterAddress"];
                            MemoryStream msFooterImage = new MemoryStream(FooterImage);
                            picFooterImage.Image = Image.FromStream(msFooterImage);
                        }

                        if (Convert.ToInt32(dtCompImageDetails.Rows[0]["nTermsAndConditionType"]) == 0)
                        {
                            rdImageFormat.Checked = true;
                            if (dtCompImageDetails.Rows[0]["imgTermsAndCondition"]!=DBNull.Value)
                            {
                                Terms_CondImage = (byte[])dtCompImageDetails.Rows[0]["imgTermsAndCondition"];
                                MemoryStream msTerms_CondImage = new MemoryStream(Terms_CondImage);
                                picFooterImage.Image = Image.FromStream(msTerms_CondImage); 
                            }
                        }
                        else if (Convert.ToInt32(dtCompImageDetails.Rows[0]["nTermsAndConditionType"]) == 1)
                        {
                            rdTextFormat.Checked = true;
                            sTermsAndCondition = Convert.ToString(dtCompImageDetails.Rows[0]["sTermsAndCondition"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        private int GetPanelCount(int nStringLength)
        {
            int nPanelCount = 0;
            if (nStringLength<=5)
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

        public Int64 SaveCompanyDetails()
        {
            Int64 nresult = 0;
            CompanyMaster clsCompanyMaster = null;
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

                string sWHPhone1 = Convert.ToString(txtWHPhone1.Text.Trim());
                string sWHPhone2 = Convert.ToString(txtWHPhone2.Text.Trim());
                string sWHPhone3 = Convert.ToString(txtWHPhone3.Text.Trim());
                string sWHPhone4 = Convert.ToString(txtWHPhone4.Text.Trim());
                string sWHPhone5 = Convert.ToString(txtWHPhone5.Text.Trim());
                string sWHPhoneAll = string.Empty;
                if (sWHPhone1 != "")
                {
                    sWHPhoneAll += sWHPhone1;
                }
                if (sWHPhone2 != "")
                {
                    sWHPhoneAll += "," + sWHPhone2;
                }
                if (sWHPhone3 != "")
                {
                    sWHPhoneAll += "," + sWHPhone3;
                }
                if (sWHPhone4 != "")
                {
                    sWHPhoneAll += "," + sWHPhone4;
                }
                if (sWHPhone5 != "")
                {
                    sWHPhoneAll += "," + sWHPhone5;
                }
                clsCompanyMaster = new CompanyMaster();
                clsCompanyMaster.nCompanyID = Convert.ToInt64(lblCompanyID.Text);
                clsCompanyMaster.nCompTransportID = Convert.ToInt64(lblCompanyTransportID.Text);
                clsCompanyMaster.nCompWarehouseID = Convert.ToInt64(lblCompWarehouseID.Text);
                clsCompanyMaster.nCompImageID = Convert.ToInt64(lblCompanyInfoImageID.Text);
                clsCompanyMaster.sCompanyCode = Convert.ToString(txtCompanyCode.Text.Trim());
                clsCompanyMaster.sCompanyName = Convert.ToString(txtCompanyName.Text.Trim());
                clsCompanyMaster.sCompAbbrivation = Convert.ToString(txtCompanyAbbrivation.Text.Trim());
                clsCompanyMaster.nCompanyTypeID = Convert.ToInt64(cmbCompanyType.SelectedValue);
                clsCompanyMaster.nCompSignatoryID = Convert.ToInt64(cmbCompanySignatory.SelectedValue);
                clsCompanyMaster.sCompAddressLine1 = Convert.ToString(txtAddressLine1.Text.Trim());
                clsCompanyMaster.sCompAddressLine2 = Convert.ToString(txtAddressLine2.Text.Trim());
                clsCompanyMaster.sCompCity = Convert.ToString(cmbCompCityMaster.Text.Trim());
                clsCompanyMaster.sCompState = Convert.ToString(cmbCompStateMaster.Text.Trim());
                clsCompanyMaster.sCompCountry = Convert.ToString(cmbCompCountryMaster.Text.Trim());
                clsCompanyMaster.sCompPincode = Convert.ToString(txtPincode.Text.Trim());
                clsCompanyMaster.sCompEmail = Convert.ToString(txtEmail.Text.Trim());
                clsCompanyMaster.sCompWebsite = Convert.ToString(txtWebsiteURL.Text.Trim());
                clsCompanyMaster.sCompFax = Convert.ToString(txtFaxNo.Text.Trim());
                clsCompanyMaster.sCompHSN_SACCode = Convert.ToString(txtHSN_SAVCode.Text.Trim());
                clsCompanyMaster.sCompGSTNo = Convert.ToString(txtGSTNo.Text.Trim());
                clsCompanyMaster.sCompPANNo = Convert.ToString(txtPANNo.Text.Trim());
                clsCompanyMaster.dtCompanyFormedDate = Convert.ToDateTime(dtCompanyFormedOn.Text.Trim());
                clsCompanyMaster.sCompAllPhoneNo = sPhoneAll;

                
                clsCompanyMaster.sTransporterID = Convert.ToString(txtTransporterID.Text.Trim());
                clsCompanyMaster.sTransDocumentDate = Convert.ToString(txtDocumentDate.Text.Trim());
                clsCompanyMaster.sTransDocumentName = Convert.ToString(txtDocumentName.Text.Trim());
                clsCompanyMaster.sTransDocumentNumber = Convert.ToString(txtDocumentNumber.Text.Trim());

                clsCompanyMaster.sWHAddressLine1 = Convert.ToString(txtWHAddressLine1.Text.Trim());
                clsCompanyMaster.sWHAddressLine2 = Convert.ToString(txtWHAddressLine2.Text.Trim());
                clsCompanyMaster.sWHCity = Convert.ToString(cmbWHCity.Text.Trim());
                clsCompanyMaster.sWHState = Convert.ToString(cmbWHCState.Text.Trim());
                clsCompanyMaster.sWHCountry = Convert.ToString(cmbWHCountry.Text.Trim());
                clsCompanyMaster.sWHPincode = Convert.ToString(txtWHPincode.Text.Trim());
                clsCompanyMaster.nWHSupervisorID = Convert.ToInt64(cmbWarehouseSupervisor.SelectedValue);
                clsCompanyMaster.sWHAllPhoneNo = sWHPhoneAll;

                byte[] HeaderImage = null;
                byte[] FooterImage = null;
                byte[] Terms_CondImage = null;
                string sTermsAndCondition=string.Empty;

                if (picHeaderImage.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picHeaderImage.Image.Save(ms, ImageFormat.Jpeg);
                        HeaderImage = new byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(HeaderImage, 0, HeaderImage.Length); 
                    }
                }
                if (picFooterImage.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picFooterImage.Image.Save(ms, ImageFormat.Jpeg);
                        FooterImage = new byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(FooterImage, 0, FooterImage.Length);
                    }
                }
                if (rdImageFormat.Checked && picTermsCondition.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picFooterImage.Image.Save(ms, ImageFormat.Jpeg);
                        Terms_CondImage = new byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(Terms_CondImage, 0, Terms_CondImage.Length);
                    }
                }
                else if (rdTextFormat.Checked)
                {
                    sTermsAndCondition = txtTermsCondition.Text.Trim();
                }
                clsCompanyMaster.imgCompHeader = HeaderImage;
                clsCompanyMaster.imgCompFooter = FooterImage;
                clsCompanyMaster.imgTerms_Condition=Terms_CondImage;
                if (rdImageFormat.Checked)
                {
                    clsCompanyMaster.nTerms_ConditionType = 0;
                }
                else
                {
                    clsCompanyMaster.nTerms_ConditionType = 1;
                }
                clsCompanyMaster.sTerms_Condition = sTermsAndCondition;

                Int64 nCompanyID=clsCompanyMaster.InsertUpdateCompanyMaster();

                if (nCompanyID!=0)
                {
                    MessageBox.Show("Company is saved successfully.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error while saving company.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

            }
            return nresult;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCompanyDetails();
        }

        private void txtCompanyName_EditValueChanged(object sender, EventArgs e)
        {
            txtCompanyAbbrivation.Text= clsGlobal.GenerateAbbrivation(txtCompanyName.Text.Trim());
        }

        
    }
}
