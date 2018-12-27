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
            lblFormHeader.Text = "Edit Company";
            fillMasterData();
            //GetAndSetSequence();
            txtCompanyName.Focus();
            ShowHidePhonePanel();
        }

        private void ShowHidePhonePanel(string sPhoneType = "", string sPhoneNo = "", int PhoneCount = 1)
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

        private void ShowHideSignWHPanel(string sPanelType = "", Int64 nID = 0, int PhoneCount = 1)
        {
            switch (PhoneCount)
            {
                case 1:
                    {
                        if (sPanelType.ToLower() == "sign")
                        {
                            pnlCompSign1.Visible = true;
                            pnlCompSign2.Visible = false;
                            pnlCompSign3.Visible = false;
                            cmbCompanySignatory1.SelectedValue = nID;
                        }
                        else if (sPanelType.ToLower() == "wh")
                        {
                            pnlWHSupervisor1.Visible = true;
                            pnlWHSupervisor2.Visible = false;
                            pnlWHSupervisor3.Visible = false;
                            cmbWarehouseSupervisor1.SelectedValue = nID;
                        }
                        else
                        {
                            pnlCompSign1.Visible = true;
                            pnlCompSign2.Visible = false;
                            pnlCompSign3.Visible = false;

                            pnlWHSupervisor1.Visible = true;
                            pnlWHSupervisor2.Visible = false;
                            pnlWHSupervisor3.Visible = false;

                            cmbCompanySignatory1.SelectedValue = nID;
                            cmbWarehouseSupervisor1.SelectedValue = nID;
                        }
                        break;
                    }
                case 2:
                    {
                        if (sPanelType.ToLower() == "sign")
                        {
                            pnlCompSign1.Visible = true;
                            pnlCompSign2.Visible = true;
                            pnlCompSign2.BringToFront();
                            pnlCompSign3.Visible = false;
                            cmbCompanySignatory2.SelectedValue = nID;
                        }
                        else if (sPanelType.ToLower() == "wh")
                        {
                            pnlWHSupervisor1.Visible = true;
                            pnlWHSupervisor2.Visible = true;
                            pnlWHSupervisor2.BringToFront();
                            pnlWHSupervisor3.Visible = false;
                            cmbWarehouseSupervisor2.SelectedValue = nID;
                        }
                        else
                        {
                            pnlCompSign1.Visible = true;
                            pnlCompSign2.Visible = true;
                            pnlCompSign2.BringToFront();
                            pnlCompSign3.Visible = false;

                            pnlWHSupervisor1.Visible = true;
                            pnlWHSupervisor2.Visible = true;
                            pnlWHSupervisor2.BringToFront();
                            pnlWHSupervisor3.Visible = false;

                            cmbCompanySignatory2.SelectedValue = nID;
                            cmbWarehouseSupervisor2.SelectedValue = nID;

                        }
                        break;
                    }
                case 3:
                    {
                        if (sPanelType.ToLower() == "sign")
                        {
                            pnlCompSign1.Visible = true;
                            pnlCompSign2.Visible = true;
                            pnlCompSign3.Visible = true;
                            pnlCompSign3.BringToFront();
                            cmbCompanySignatory3.SelectedValue = nID;
                        }
                        else if (sPanelType.ToLower() == "wh")
                        {
                            pnlWHSupervisor1.Visible = true;
                            pnlWHSupervisor2.Visible = true;
                            pnlWHSupervisor3.Visible = true;
                            pnlWHSupervisor3.BringToFront();

                            cmbWarehouseSupervisor3.SelectedValue = nID;
                        }
                        else
                        {
                            pnlCompSign1.Visible = true;
                            pnlCompSign2.Visible = true;
                            pnlCompSign3.Visible = true;
                            pnlCompSign3.BringToFront();

                            pnlWHSupervisor1.Visible = true;
                            pnlWHSupervisor2.Visible = true;
                            pnlWHSupervisor3.Visible = true;
                            pnlWHSupervisor3.BringToFront();

                            cmbCompanySignatory3.SelectedValue = nID;
                            cmbWarehouseSupervisor3.SelectedValue = nID;

                        }
                        break;
                    }
            }

        }
        private void fillMasterData()
        {
            txtCountry.Text = "India";
            txtCity.Text = "Mumbai";
            txtState.Text = "Maharashtra";
            txtWHCountry.Text = "India";
            txtWHCity.Text = "Mumbai";
            txtWHState.Text = "Maharashtra";
            clsGeneral oclsGeneral = null;
            try
            {
                oclsGeneral = new clsGeneral();
                DataSet dsCompanyMaster = oclsGeneral.GetCompanyMaster();
                if (dsCompanyMaster != null && dsCompanyMaster.Tables.Count > 0)
                {
                    DataTable dtCompanyType = dsCompanyMaster.Tables[0];
                    //DataTable dtStateMaster = dsCompanyMaster.Tables[1];
                    //DataTable dtCityMaster = dsCompanyMaster.Tables[2];
                    //DataTable dtCountryMaster = dsCompanyMaster.Tables[3];

                    DataRow drCompanyType = dtCompanyType.NewRow();
                    drCompanyType["nCompanyTypeID"] = "0";
                    drCompanyType["sCompanyTypeName"] = "";
                    dtCompanyType.Rows.InsertAt(drCompanyType, 0);

                    cmbCompanyType.DataSource = dtCompanyType;
                    cmbCompanyType.DisplayMember = "sCompanyTypeName";
                    cmbCompanyType.ValueMember = "nCompanyTypeID";

                    //cmbCompStateMaster.DataSource = dtStateMaster;
                    //cmbCompStateMaster.DisplayMember = "StateName";
                    //cmbCompStateMaster.ValueMember = "StateName";
                    //cmbCompStateMaster.Text = "Maharashtra";

                    //cmbCompCityMaster.DataSource = dtCityMaster;
                    //cmbCompCityMaster.DisplayMember = "CityName";
                    //cmbCompCityMaster.ValueMember = "CityName";
                    //cmbCompCityMaster.Text = "Mumbai";

                    //cmbCompCountryMaster.DataSource = dtCountryMaster;
                    //cmbCompCountryMaster.DisplayMember = "sCountryName";
                    //cmbCompCountryMaster.ValueMember = "sCountryName";
                    //cmbCompCountryMaster.Text = "India";

                    //cmbWHCState.DataSource = dtStateMaster.Copy();
                    //cmbWHCState.DisplayMember = "StateName";
                    //cmbWHCState.ValueMember = "StateName";
                    //cmbWHCState.Text = "Maharashtra";

                    //cmbWHCity.DataSource = dtCityMaster.Copy();
                    //cmbWHCity.DisplayMember = "CityName";
                    //cmbWHCity.ValueMember = "CityName";
                    //cmbWHCity.Text = "Mumbai";

                    //cmbWHCountry.DataSource = dtCountryMaster.Copy();
                    //cmbWHCountry.DisplayMember = "sCountryName";
                    //cmbWHCountry.ValueMember = "sCountryName";
                    //cmbWHCountry.Text = "India";
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
                txtCompanyCode.Text = "CMP/" + Convert.ToString(oclsGeneral.GetSequenceNumber(MainMasterType.Company.GetHashCode()));
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
        private int CheckPanelSignWHVisibility(string sCheckPanelFor)
        {
            int nPanelCount = 0;
            switch (sCheckPanelFor)
            {
                case "Sign":
                    {
                        if (pnlCompSign1.Visible == true && pnlCompSign2.Visible == false && pnlCompSign3.Visible == false)
                        {
                            nPanelCount = 2;
                        }
                        else if (pnlCompSign1.Visible == true && pnlCompSign2.Visible == true && pnlCompSign3.Visible == false)
                        {
                            nPanelCount = 3;
                        }
                        else if (pnlCompSign1.Visible == true && pnlCompSign2.Visible == true && pnlCompSign3.Visible == true)
                        {
                            nPanelCount = 4;
                        }
                        break;
                    }
                case "WH":
                    {
                        if (pnlWHSupervisor1.Visible == true && pnlWHSupervisor2.Visible == false && pnlWHSupervisor3.Visible == false)
                        {
                            nPanelCount = 2;
                        }
                        else if (pnlWHSupervisor1.Visible == true && pnlWHSupervisor2.Visible == true && pnlWHSupervisor3.Visible == false)
                        {
                            nPanelCount = 3;
                        }
                        else if (pnlWHSupervisor1.Visible == true && pnlWHSupervisor2.Visible == true && pnlWHSupervisor3.Visible == true)
                        {
                            nPanelCount = 4;
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
                ShowHidePhonePanel("WH", "", nWHPhoneCount);
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
            dtCompanyFormedOn.EditValue = DateTime.Now;
            txtDocumentDate.EditValue = DateTime.Now;
            FillSignatoryInfo();
            FillWarehouseSuperintendentInfo();

            if (Convert.ToInt64(lblCompanyID.Text) > 0)
            {
                FillCompanyDetails(Convert.ToInt64(lblCompanyID.Text));
            }
            //clsGlobal.SetDateFormat(dtCompanyFormedOn);
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
                if (ds != null && ds.Tables.Count > 0)
                {
                    dtCompDetails = ds.Tables[0];
                    dtCompTransDetails = ds.Tables[1];
                    dtCompWHDetails = ds.Tables[2];
                    dtCompImageDetails = ds.Tables[3];

                    if (dtCompDetails != null && dtCompDetails.Rows.Count > 0)
                    {
                        lblCompanyID.Text = Convert.ToString(dtCompDetails.Rows[0]["nCompanyID"]);
                        lblCompanyInfoImageID.Text = Convert.ToString(dtCompDetails.Rows[0]["nCompanyImageInfoID"]);
                        lblCompanyTransportID.Text = Convert.ToString(dtCompDetails.Rows[0]["nCompanyTransporterID"]);
                        lblCompWarehouseID.Text = Convert.ToString(dtCompDetails.Rows[0]["nCompanyWarehouseID"]);

                        txtCompanyCode.Text = Convert.ToString(dtCompDetails.Rows[0]["sCompanyCode"]);
                        txtCompanyAbbrivation.Text = Convert.ToString(dtCompDetails.Rows[0]["sCompAbbrivation"]);
                        txtCompanyName.Text = Convert.ToString(dtCompDetails.Rows[0]["sCompanyName"]);
                        cmbCompanyType.SelectedValue = Convert.ToInt64(dtCompDetails.Rows[0]["nCompanyTypeID"]);
                        //cmbCompanySignatory1.SelectedValue = Convert.ToInt64(dtCompDetails.Rows[0]["nCompanySignatory"]);
                        txtAddressLine1.Text = Convert.ToString(dtCompDetails.Rows[0]["sAddressLine1"]);
                        txtAddressLine2.Text = Convert.ToString(dtCompDetails.Rows[0]["sAddressLine2"]);
                        txtCity.Text = Convert.ToString(dtCompDetails.Rows[0]["sCity"]);
                        txtState.Text = Convert.ToString(dtCompDetails.Rows[0]["sState"]);
                        txtCountry.Text = Convert.ToString(dtCompDetails.Rows[0]["sCountry"]);
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

                        string[] sSignatoryAll = Convert.ToString(dtCompDetails.Rows[0]["sCompanySignatory"]).Split(',');
                        if (sSignatoryAll.Length > 0)
                        {
                            int nCompPanelCount = GetPanelCount(sSignatoryAll.Length);
                            for (int i = 0; i < nCompPanelCount; i++)
                            {
                                ShowHideSignWHPanel("Sign", Convert.ToInt64(sSignatoryAll[i]), i + 1);
                            }
                        }
                    }

                    if (dtCompTransDetails != null && dtCompTransDetails.Rows.Count > 0)
                    {
                        txtTransporterID.Text = Convert.ToString(dtCompTransDetails.Rows[0]["sTransportorID"]);
                        txtDocumentName.Text = Convert.ToString(dtCompTransDetails.Rows[0]["sDoumentName"]);
                        txtDocumentNumber.Text = Convert.ToString(dtCompTransDetails.Rows[0]["sDoumentNumber"]);
                        txtDocumentDate.Text = Convert.ToString(dtCompTransDetails.Rows[0]["sDocumentDate"]);
                    }

                    if (dtCompWHDetails != null && dtCompWHDetails.Rows.Count > 0)
                    {
                        txtWHAddressLine1.Text = Convert.ToString(dtCompWHDetails.Rows[0]["sWarehouseAddressLine1"]);
                        txtWHAddressLine2.Text = Convert.ToString(dtCompWHDetails.Rows[0]["sWarehouseAddressLine2"]);
                        txtWHCity.Text = Convert.ToString(dtCompWHDetails.Rows[0]["sCity"]);
                        txtWHState.Text = Convert.ToString(dtCompWHDetails.Rows[0]["sState"]);
                        txtWHCountry.Text = Convert.ToString(dtCompWHDetails.Rows[0]["sCountry"]);
                        txtWHPincode.Text = Convert.ToString(dtCompWHDetails.Rows[0]["sPincode"]);
                        //cmbWarehouseSupervisor1.SelectedValue = Convert.ToInt64(dtCompWHDetails.Rows[0]["nSupervisorID"]);

                        string[] sWHPhoneAll = Convert.ToString(dtCompWHDetails.Rows[0]["sPhoneNo"]).Split(',');
                        if (sWHPhoneAll.Length > 0)
                        {
                            int nPanelCount = GetPanelCount(sWHPhoneAll.Length);
                            for (int i = 0; i < nPanelCount; i++)
                            {
                                ShowHidePhonePanel("WH", sWHPhoneAll[i], i + 1);
                            }
                        }
                        string[] sSupervisorAll = Convert.ToString(dtCompWHDetails.Rows[0]["nSupervisorID"]).Split(',');
                        if (sSupervisorAll.Length > 0)
                        {
                            int nCompPanelCount = GetPanelCount(sSupervisorAll.Length);
                            for (int i = 0; i < nCompPanelCount; i++)
                            {
                                ShowHideSignWHPanel("WH", Convert.ToInt64(sSupervisorAll[i]), i + 1);
                            }
                        }
                    }

                    if (dtCompImageDetails != null && dtCompImageDetails.Rows.Count > 0)
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
                            if (dtCompImageDetails.Rows[0]["imgTermsAndCondition"] != DBNull.Value)
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
                            txtTermsCondition.Text = sTermsAndCondition;
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

                string sCompSign1 = Convert.ToString(cmbCompanySignatory1.SelectedValue);
                string sCompSign2 = Convert.ToString(cmbCompanySignatory2.SelectedValue);
                string sCompSign3 = Convert.ToString(cmbCompanySignatory3.SelectedValue);
                string sCompSign = string.Empty;
                if (sCompSign1 != "0")
                {
                    sCompSign += sCompSign1;
                }
                if (sCompSign2 != "0")
                {
                    sCompSign += "," + sCompSign2;
                }
                if (sCompSign3 != "0")
                {
                    sCompSign += "," + sCompSign3;
                }

                string sWHSupervisor1 = Convert.ToString(cmbWarehouseSupervisor1.SelectedValue);
                string sWHSupervisor2 = Convert.ToString(cmbWarehouseSupervisor2.SelectedValue);
                string sWHSupervisor3 = Convert.ToString(cmbWarehouseSupervisor3.SelectedValue);
                string sWHSupervisor = string.Empty;
                if (sWHSupervisor1 != "0")
                {
                    sWHSupervisor += sWHSupervisor1;
                }
                if (sWHSupervisor2 != "0")
                {
                    sWHSupervisor += "," + sWHSupervisor2;
                }
                if (sWHSupervisor3 != "0")
                {
                    sWHSupervisor += "," + sWHSupervisor3;
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
                clsCompanyMaster.sCompSignatoryID = sCompSign == "" ? "0" : sCompSign;
                clsCompanyMaster.sCompAddressLine1 = Convert.ToString(txtAddressLine1.Text.Trim());
                clsCompanyMaster.sCompAddressLine2 = Convert.ToString(txtAddressLine2.Text.Trim());
                clsCompanyMaster.sCompCity = Convert.ToString(txtCity.Text.Trim());
                clsCompanyMaster.sCompState = Convert.ToString(txtState.Text.Trim());
                clsCompanyMaster.sCompCountry = Convert.ToString(txtCountry.Text.Trim());
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
                clsCompanyMaster.sWHCity = Convert.ToString(txtCity.Text.Trim());
                clsCompanyMaster.sWHState = Convert.ToString(txtState.Text.Trim());
                clsCompanyMaster.sWHCountry = Convert.ToString(txtCountry.Text.Trim());
                clsCompanyMaster.sWHPincode = Convert.ToString(txtWHPincode.Text.Trim());
                clsCompanyMaster.nWHSupervisorID = sWHSupervisor==""?"0":sWHSupervisor;
                clsCompanyMaster.sWHAllPhoneNo = sWHPhoneAll;

                byte[] HeaderImage = null;
                byte[] FooterImage = null;
                byte[] Terms_CondImage = null;
                string sTermsAndCondition = string.Empty;

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
                clsCompanyMaster.imgTerms_Condition = Terms_CondImage;
                if (rdImageFormat.Checked)
                {
                    clsCompanyMaster.nTerms_ConditionType = 0;
                }
                else
                {
                    clsCompanyMaster.nTerms_ConditionType = 1;
                }
                clsCompanyMaster.sTerms_Condition = sTermsAndCondition;

                Int64 nCompanyID = clsCompanyMaster.InsertUpdateCompanyMaster();

                if (nCompanyID != 0)
                {
                    MessageBox.Show("Company is saved successfully.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Error while saving company.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return nresult;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveCompanyDetails();
            }
        }

        public bool ValidateForm()
        {
            bool bIsValidForm = true;
            if (txtCompanyName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter company name.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bIsValidForm = false;
                txtCompanyName.Focus();
                return bIsValidForm;
            }
            if (cmbCompanyType.Text.Trim() == "")
            {
                MessageBox.Show("Please enter company type.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bIsValidForm = false;
                cmbCompanyType.Focus();
                return bIsValidForm;
            }
            return bIsValidForm;
        }
        private void txtCompanyName_EditValueChanged(object sender, EventArgs e)
        {
            txtCompanyAbbrivation.Text = clsGlobal.GenerateAbbrivation(txtCompanyName.Text.Trim());
        }

        private void btnAddCompanySignatory_Click(object sender, EventArgs e)
        {
            int nCompanyPhoneCount = CheckPanelSignWHVisibility("Sign");
            if (nCompanyPhoneCount <= 3)
            {
                ShowHideSignWHPanel("Sign", 0, nCompanyPhoneCount);
            }
            return;
            clsMasters clsMaster = null;
            try
            {
                clsMaster = new clsMasters();
                Int64 nSignatoryID = 0;
                DataTable dtMaster = clsMaster.GetMasterTypeDataBbValue(MasterType.Designation.GetHashCode(), "Signatory");
                if (dtMaster != null && dtMaster.Rows.Count > 0)
                {
                    nSignatoryID = Convert.ToInt64(dtMaster.Rows[0]["TypeID"]);
                }
                frmMasterAddCrew frmMasterCrew = new frmMasterAddCrew();
                frmMasterCrew.nSignatoryID = nSignatoryID;
                frmMasterCrew.ShowDialog(this);

                FillSignatoryInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void FillSignatoryInfo()
        {
            CompanyMaster oCompanyMaster = null;
            DataTable dt = null;
            try
            {
                oCompanyMaster = new CompanyMaster();
                dt = oCompanyMaster.GetListData("signatory");
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow dr = dt.NewRow();
                    dr["ID"] = 0;
                    dr["Code"] = "";
                    dt.Rows.InsertAt(dr, 0);

                    cmbCompanySignatory1.DataSource = dt;
                    cmbCompanySignatory1.DisplayMember = "Code";
                    cmbCompanySignatory1.ValueMember = "ID";

                    cmbCompanySignatory2.DataSource = dt.Copy();
                    cmbCompanySignatory2.DisplayMember = "Code";
                    cmbCompanySignatory2.ValueMember = "ID";

                    cmbCompanySignatory3.DataSource = dt.Copy();
                    cmbCompanySignatory3.DisplayMember = "Code";
                    cmbCompanySignatory3.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (oCompanyMaster != null)
                {
                    oCompanyMaster.Dispose();
                    oCompanyMaster = null;
                }

            }
        }

        private void FillWarehouseSuperintendentInfo()
        {
            CompanyMaster oCompanyMaster = null;
            DataTable dt = null;
            try
            {
                oCompanyMaster = new CompanyMaster();
                dt = oCompanyMaster.GetListData("Warehouse Superintendent");
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow dr = dt.NewRow();
                    dr["ID"] = 0;
                    dr["Code"] = "";
                    dt.Rows.InsertAt(dr, 0);

                    cmbWarehouseSupervisor1.DataSource = dt;
                    cmbWarehouseSupervisor1.DisplayMember = "Code";
                    cmbWarehouseSupervisor1.ValueMember = "ID";

                    cmbWarehouseSupervisor2.DataSource = dt.Copy();
                    cmbWarehouseSupervisor2.DisplayMember = "Code";
                    cmbWarehouseSupervisor2.ValueMember = "ID";

                    cmbWarehouseSupervisor3.DataSource = dt.Copy();
                    cmbWarehouseSupervisor3.DisplayMember = "Code";
                    cmbWarehouseSupervisor3.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (oCompanyMaster != null)
                {
                    oCompanyMaster.Dispose();
                    oCompanyMaster = null;
                }

            }
        }

        private void ClearForm()
        {
            txtCompanyAbbrivation.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            cmbCompanyType.SelectedValue = 0;
            txtAddressLine1.Text = string.Empty;
            txtAddressLine2.Text = string.Empty;
            txtCity.Text = "Mumbai";
            txtState.Text = "Maharashtra";
            txtCountry.Text = "India";
            txtPincode.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtWebsiteURL.Text = string.Empty;
            txtFaxNo.Text = string.Empty;
            txtHSN_SAVCode.Text = string.Empty;
            txtGSTNo.Text = string.Empty;
            txtPANNo.Text = string.Empty;
            dtCompanyFormedOn.EditValue = DateTime.Now;

            txtPhone1.Text = string.Empty;
            txtPhone2.Text = string.Empty;
            txtPhone3.Text = string.Empty;
            txtPhone4.Text = string.Empty;
            txtPhone5.Text = string.Empty;

            txtTransporterID.Text = string.Empty;
            txtDocumentName.Text = string.Empty;
            txtDocumentNumber.Text = string.Empty;
            txtDocumentDate.EditValue = DateTime.Now;

            txtWHAddressLine1.Text = string.Empty;
            txtWHAddressLine2.Text = string.Empty;
            txtWHCity.Text = "Mumbai";
            txtWHState.Text = "Maharashtra";
            txtWHCountry.Text = "India";
            txtWHPincode.Text = string.Empty;

            txtWHPhone1.Text = string.Empty;
            txtWHPhone2.Text = string.Empty;
            txtWHPhone3.Text = string.Empty;
            txtWHPhone4.Text = string.Empty;
            txtWHPhone5.Text = string.Empty;
            GetAndSetSequence();
            cmbCompanySignatory1.SelectedValue = 0;
            cmbCompanySignatory2.SelectedValue = 0;
            cmbCompanySignatory3.SelectedValue = 0;

            cmbWarehouseSupervisor1.SelectedValue = 0;
            cmbWarehouseSupervisor2.SelectedValue = 0;
            cmbWarehouseSupervisor3.SelectedValue = 0;


            rdImageFormat.Checked = true;
            if (picFooterImage != null)
            {
                picFooterImage.Image = null;
            }
            if (picHeaderImage != null)
            {
                picHeaderImage.Image = null;
            }
            if (picTermsCondition != null)
            {
                picTermsCondition.Image = null;
            }
            if (txtTermsCondition.Text != "")
            {
                txtTermsCondition.Text = "";
            }
        }

        private void btnWHAddSupervisor_Click(object sender, EventArgs e)
        {
            int nCompanyPhoneCount = CheckPanelSignWHVisibility("WH");
            if (nCompanyPhoneCount <= 3)
            {
                ShowHideSignWHPanel("WH", 0, nCompanyPhoneCount);
            }
            return;
            clsMasters clsMaster = null;
            try
            {
                clsMaster = new clsMasters();
                Int64 nSignatoryID = 0;
                DataTable dtMaster = clsMaster.GetMasterTypeDataBbValue(MasterType.Designation.GetHashCode(), "Warehouse Superintendent");
                if (dtMaster != null && dtMaster.Rows.Count > 0)
                {
                    nSignatoryID = Convert.ToInt64(dtMaster.Rows[0]["TypeID"]);
                }
                frmMasterAddCrew frmMasterCrew = new frmMasterAddCrew();
                frmMasterCrew.nSignatoryID = nSignatoryID;
                frmMasterCrew.ShowDialog(this);

                FillWarehouseSuperintendentInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        
        

    }
}
