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
    public partial class frmAddAsset : DevExpress.XtraEditors.XtraForm
    {
        public frmAddAsset()
        {
            InitializeComponent();
        }

        public frmAddAsset(long nAssetID)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            lblAssetID.Text= Convert.ToString(nAssetID);
        }
        DataTable dtAssetCode = new DataTable();
        private long nAssetID;
        private void frmAddAsset_Load(object sender, EventArgs e)
        {
            try
            {
                dtIntroductionDate.EditValue = DateTime.Now;
                dtReorderTime.EditValue = DateTime.Now;
                dtShelfLife.EditValue = DateTime.Now;
                dtRetirementDate.EditValue = DateTime.Now;
                FillAssetMaster();
                FillAssetCode();

                if (Convert.ToInt64(lblAssetID.Text) != 0)
                {
                    pnlSave.Visible = false;
                    FillAssetDetails(Convert.ToInt64(lblAssetID.Text));
                    EnableDisableCodeControl(Convert.ToInt64(lblAssetID.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FillAssetDetails(long nAssetID)
        {
            AssetMaster oAssetMaster = null;
            DataSet ds = null;
            try
            {
                oAssetMaster = new AssetMaster();
                ds= oAssetMaster.GetAssetDetails(nAssetID);
                if (ds!=null && ds.Tables.Count>0)
                {
                    DataTable dtAssetDetails = ds.Tables[0];
                    DataTable dtAssetCodeDetails = ds.Tables[1];

                    if (dtAssetDetails!=null && dtAssetDetails.Rows.Count>0)
                    {
                        lblAssetID.Text = Convert.ToString(dtAssetDetails.Rows[0]["nAssetID"]);
                        cmbCompanyMst.SelectedValue = Convert.ToInt64(dtAssetDetails.Rows[0]["nCompanyID"]);
                        cmbMainType.SelectedValue = Convert.ToInt64(dtAssetDetails.Rows[0]["nAssetMainTypeID"]);
                        cmbType.SelectedValue = Convert.ToInt64(dtAssetDetails.Rows[0]["nAssetTypeID"]);
                        cmbType1.SelectedValue = Convert.ToInt64(dtAssetDetails.Rows[0]["nAssetTypeOneID"]);
                        cmbMaterialType.SelectedValue = Convert.ToInt64(dtAssetDetails.Rows[0]["nAssetMaterialID"]);
                        cmbPartyVendor.SelectedValue = Convert.ToInt64(dtAssetDetails.Rows[0]["nAssetVendorID"]);
                        cmbDensity.SelectedValue = Convert.ToInt64(dtAssetDetails.Rows[0]["nDensityID"]);
                        cmbColor.SelectedValue = Convert.ToInt64(dtAssetDetails.Rows[0]["nColorID"]);
                        cmbHSNCode.SelectedValue = Convert.ToInt64(dtAssetDetails.Rows[0]["nHSNCodeID"]);
                        txtAssetName.Text = Convert.ToString(dtAssetDetails.Rows[0]["sAssetName"]);
                        txtAssetAbbrivation.Text = Convert.ToString(dtAssetDetails.Rows[0]["sAssetAbbrivation"]);
                        txtAssetDescription.Text = Convert.ToString(dtAssetDetails.Rows[0]["sDescription"]);
                        dtIntroductionDate.Text = Convert.ToString(dtAssetDetails.Rows[0]["dtIntroductionDate"]);
                        dtReorderTime.Text = Convert.ToString(dtAssetDetails.Rows[0]["dtReorderDate"]);
                        txtReorderDays.Text = Convert.ToString(dtAssetDetails.Rows[0]["sReorderDays"]);
                        txtReorderQuantity.Text = Convert.ToString(dtAssetDetails.Rows[0]["sReorderQuality"]);
                        txtAssetRate.Text = Convert.ToString(dtAssetDetails.Rows[0]["sRate"]);
                        txtAssetMake.Text = Convert.ToString(dtAssetDetails.Rows[0]["sMake"]);
                        txtSizeHeight.Text = Convert.ToString(dtAssetDetails.Rows[0]["sSizeOrCapacity"]);
                        txtQuality.Text = Convert.ToString(dtAssetDetails.Rows[0]["sQuality"]);
                        txtDimention.Text = Convert.ToString(dtAssetDetails.Rows[0]["sDimention"]);
                        txtWeight.Text = Convert.ToString(dtAssetDetails.Rows[0]["sWeight"]);
                        txtWattage.Text = Convert.ToString(dtAssetDetails.Rows[0]["sWattage"]);
                        txtSpan.Text = Convert.ToString(dtAssetDetails.Rows[0]["sSpan"]);
                        txtAttachment.Text = Convert.ToString(dtAssetDetails.Rows[0]["sAttachment"]);
                        txtAttachmentName.Text = Convert.ToString(dtAssetDetails.Rows[0]["sAttachmentName"]);
                        txtLength.Text = Convert.ToString(dtAssetDetails.Rows[0]["sLength"]);
                        txtCore.Text = Convert.ToString(dtAssetDetails.Rows[0]["sCoreOrPole"]);
                        txtAmps.Text = Convert.ToString(dtAssetDetails.Rows[0]["sAmps"]);
                        txtPlug.Text = Convert.ToString(dtAssetDetails.Rows[0]["sPlug"]);
                        txtPower.Text = Convert.ToString(dtAssetDetails.Rows[0]["sPower"]);
                        txtAssetCode.Text = GenerateCode();
                    }
                    if (dtAssetCodeDetails!=null)
                    {
                        gvAssetList.GridControl.DataSource = dtAssetCodeDetails;
                        gvAssetList.Columns[1].Visible = false;
                        gvAssetList.Columns[6].Visible = false;
                    }
                    btnUpdateAsset.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (oAssetMaster!=null)
                {
                    oAssetMaster.Dispose();
                    oAssetMaster = null;
                }
                if (ds!=null)
                {
                    ds.Dispose();
                    ds = null;
                }
            }
        }

        private void FillAssetCode(Int64 nAssetID=0)
        {
            AssetMaster oAsset = null;
            try
            {
                oAsset = new AssetMaster();
                dtAssetCode = oAsset.GetAssetCode(nAssetID);
                if (dtAssetCode != null)
                {
                    gvAssetList.GridControl.DataSource = dtAssetCode;
                    gvAssetList.Columns[1].Visible = false;
                    gvAssetList.Columns[6].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                if (oAsset != null)
                {
                    oAsset.Dispose();
                    oAsset = null;
                }
                
            }
        }

        private void FillAssetMaster()
        {
            AssetMaster clsAsset = null;
            DataSet dsMaster = null;
            try
            {
                clsAsset = new AssetMaster();
                dsMaster = clsAsset.GetAllMasterData_ByMainType(0);

                if (dsMaster != null && dsMaster.Tables.Count > 0)
                {
                    DataTable dtMainType = dsMaster.Tables[0].Copy();
                    DataTable dtCompany = dsMaster.Tables[1].Copy();
                    DataTable dtMaterialType = dsMaster.Tables[2].Copy();
                    DataTable dtColorType = dsMaster.Tables[3].Copy();
                    DataTable dtDensity = dsMaster.Tables[4].Copy();

                    DataRow drMainType = dtMainType.NewRow();
                    drMainType["ID"] = 0;
                    drMainType["Code"] = "";
                    dtMainType.Rows.InsertAt(drMainType, 0);

                    DataRow drCompany = dtCompany.NewRow();
                    drCompany["ID"] = 0;
                    drCompany["Code"] = "";
                    dtCompany.Rows.InsertAt(drCompany, 0);


                    DataRow drMaterialType = dtMaterialType.NewRow();
                    drMaterialType["ID"] = 0;
                    drMaterialType["Code"] = "";
                    dtMaterialType.Rows.InsertAt(drMaterialType, 0);

                    DataRow drColorType = dtColorType.NewRow();
                    drColorType["ID"] = 0;
                    drColorType["Code"] = "";
                    dtColorType.Rows.InsertAt(drColorType, 0);

                    DataRow drDensity = dtDensity.NewRow();
                    drDensity["ID"] = 0;
                    drDensity["Code"] = "";
                    dtDensity.Rows.InsertAt(drDensity, 0);

                    cmbMainType.DataSource = dtMainType;
                    cmbMainType.DisplayMember = "Code";
                    cmbMainType.ValueMember = "ID";

                    cmbCompanyMst.DataSource = dtCompany;
                    cmbCompanyMst.DisplayMember = "Code";
                    cmbCompanyMst.ValueMember = "ID";

                    cmbColor.DataSource = dtColorType;
                    cmbColor.DisplayMember = "Code";
                    cmbColor.ValueMember = "ID";

                    cmbMaterialType.DataSource = dtMaterialType;
                    cmbMaterialType.DisplayMember = "Code";
                    cmbMaterialType.ValueMember = "ID";

                    cmbDensity.SelectedIndexChanged -= cmbDensity_SelectedIndexChanged;
                    cmbDensity.DataSource = dtDensity;
                    cmbDensity.DisplayMember = "Code";
                    cmbDensity.ValueMember = "ID";
                    cmbDensity.SelectedIndexChanged += cmbDensity_SelectedIndexChanged;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (clsAsset != null)
                {
                    clsAsset.Dispose();
                    clsAsset = null;
                }
                if (dsMaster != null)
                {
                    dsMaster.Dispose();
                    dsMaster = null;
                }
            }

        }

        private void txtAssetName_EditValueChanged(object sender, EventArgs e)
        {
            txtAssetAbbrivation.Text = clsGlobal.GenerateAbbrivation(txtAssetName.Text.Trim());
        }

        private void cmbMainType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMainType.SelectedIndex > 0)
            {
                FillAssetSubType(Convert.ToInt64(cmbMainType.SelectedValue));
                txtAssetCode.Text= GenerateCode();
            }
            EnableDisableControl(cmbMainType.Text);

        }

        private void FillAssetSubType(Int64 nMaintype)
        {
            AssetMaster clsAsset = null;
            DataSet dsAssetSubtype = null;
            try
            {
                clsAsset = new AssetMaster();
                dsAssetSubtype = clsAsset.GetAllMasterData_ByMainType(nMaintype);
                if (dsAssetSubtype != null && dsAssetSubtype.Tables.Count > 0)
                {
                    DataTable dtType = dsAssetSubtype.Tables[0].Copy();
                    DataTable dtTypeOne = dsAssetSubtype.Tables[1].Copy();
                    //DataTable dtSequenceNo = dsAssetSubtype.Tables[2].Copy();

                    DataRow drType = dtType.NewRow();
                    drType["ID"] = 0;
                    drType["Code"] = "";
                    dtType.Rows.InsertAt(drType, 0);

                    DataRow drTypeOne = dtTypeOne.NewRow();
                    drTypeOne["ID"] = 0;
                    drTypeOne["Code"] = "";
                    dtTypeOne.Rows.InsertAt(drTypeOne, 0);

                    cmbType.SelectedIndexChanged -= cmbType_SelectedIndexChanged;
                    cmbType.DataSource = dtType;
                    cmbType.DisplayMember = "Code";
                    cmbType.ValueMember = "ID";
                    cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;

                    cmbType1.DataSource = dtTypeOne;
                    cmbType1.DisplayMember = "Code";
                    cmbType1.ValueMember = "ID";

                    //string sControlsName = Convert.ToString(dtControls.Rows[0]["ControlNames"]);
                    //string sMainType = Convert.ToString(dtControls.Rows[0]["AssetName"]);
                    //if (dtSequenceNo != null && dtSequenceNo.Rows.Count > 0)
                    //{
                    //    lblSequenceNo.Text = Convert.ToString(dtSequenceNo.Rows[0]["SequenceNo"]);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (clsAsset != null)
                {
                    clsAsset.Dispose();
                    clsAsset = null;
                }
                if (dsAssetSubtype != null)
                {
                    dsAssetSubtype.Dispose();
                    dsAssetSubtype = null;
                }
            }
        }

        private void EnableDisableControl(string sMainType)
        {
            switch (sMainType)
            {
                case "Cloth":
                    {//cloth: Wattage,Span,Attachment,Attachment Name,Length,Core,Amps,Plug,Power
                        txtWattage.ReadOnly = true;
                        txtSpan.ReadOnly = true;
                        txtAttachment.ReadOnly = true;
                        txtAttachmentName.ReadOnly = true;
                        txtLength.ReadOnly = true;
                        txtCore.ReadOnly = true;
                        txtAmps.ReadOnly = true;
                        txtPlug.ReadOnly = true;
                        txtPower.ReadOnly = true;
                        txtSizeHeight.ReadOnly = false;
                        cmbColor.Enabled = true;
                        txtQuality.ReadOnly = false;
                        cmbDensity.Enabled = true;
                        break;
                    }
                case "Grip":
                    {
                        //Grip: Density,Wattage,Color,Length,Core,Amps,Plug,Power
                        txtQuality.ReadOnly = false;
                        cmbDensity.Enabled = false;
                        txtWattage.ReadOnly = true;
                        cmbColor.Enabled = false;
                        txtLength.ReadOnly = true;
                        txtCore.ReadOnly = true;
                        txtAmps.ReadOnly = true;
                        txtPlug.ReadOnly = true;
                        txtPower.ReadOnly = true;
                        txtSizeHeight.ReadOnly = false;
                        txtSpan.ReadOnly = false;
                        txtAttachment.ReadOnly = false;
                        txtAttachmentName.ReadOnly = false;
                        break;

                    }
                case "Accessories":
                case "":
                    {
                        //Accessories: 
                        txtSizeHeight.ReadOnly = false;
                        cmbColor.Enabled = true;
                        txtQuality.ReadOnly = false;
                        cmbDensity.Enabled = true;
                        txtSpan.ReadOnly = false;
                        txtAttachment.ReadOnly = false;
                        txtAttachmentName.ReadOnly = false;
                        txtCore.ReadOnly = false;
                        txtAmps.ReadOnly = false;
                        txtPlug.ReadOnly = false;
                        txtWattage.ReadOnly = false;
                        txtPower.ReadOnly = false;
                        txtLength.ReadOnly = false;
                        break;
                    }
                case "Light":
                    {
                        //light: size,Color, Density, Span,Attachment,Attachment Name,Length,Core,Amps,Plug,Power
                        txtSizeHeight.ReadOnly = true;
                        cmbColor.Enabled = false;
                        cmbDensity.Enabled = false;
                        txtSpan.ReadOnly = true;
                        txtAttachment.ReadOnly = true;
                        txtAttachmentName.ReadOnly = true;
                        txtLength.ReadOnly = true;
                        txtCore.ReadOnly = true;
                        txtAmps.ReadOnly = true;
                        txtPlug.ReadOnly = true;
                        txtPower.ReadOnly = true;
                        txtQuality.ReadOnly = false;
                        txtWattage.ReadOnly = false;
                        break;

                    }
                case "Light Accessories":
                    {
                        //light Accessories: size,Color,Quality, Density, Span,Attachment,Attachment Name,Core,Amps,Plug
                        txtSizeHeight.ReadOnly = true;
                        cmbColor.Enabled = false;
                        txtQuality.ReadOnly = true;
                        cmbDensity.Enabled = false;
                        txtSpan.ReadOnly = true;
                        txtAttachment.ReadOnly = true;
                        txtAttachmentName.ReadOnly = true;
                        txtCore.ReadOnly = true;
                        txtAmps.ReadOnly = true;
                        txtPlug.ReadOnly = true;
                        txtWattage.ReadOnly = false;
                        txtPower.ReadOnly = false;
                        txtLength.ReadOnly = false;
                        break;

                    }
                case "Power Distribution":
                    {
                        //Power Distribution: size,Color,Quality, Density,Wattage, Span,Attachment,Attachment Name,Power
                        txtSizeHeight.ReadOnly = true;
                        cmbColor.Enabled = false;
                        txtQuality.ReadOnly = true;
                        cmbDensity.Enabled = false;
                        txtWattage.ReadOnly = true;
                        txtSpan.ReadOnly = true;
                        txtAttachment.ReadOnly = true;
                        txtAttachmentName.ReadOnly = true;
                        txtPower.ReadOnly = true;
                        txtCore.ReadOnly = false;
                        txtAmps.ReadOnly = false;
                        txtPlug.ReadOnly = false;
                        txtLength.ReadOnly = false;
                        break;

                    }
            }
        }

        private string GenerateAssetAbbrivation(string sAssetName)
        {
            string sAbbrivation = string.Empty;
            string[] sFullName = sAssetName.Split(' ');
            foreach (var item in sFullName)
            {
                if (item.All(char.IsDigit))
                {
                    sAbbrivation = sAbbrivation + item.ToString();
                }
                else
                {
                    sAbbrivation = sAbbrivation + item[0].ToString().ToUpper();
                }
            }
            return sAbbrivation;
        }
        private void EnableDisableCodeControl(Int64 nAssetID)
        {
            if (nAssetID>0)
            {
                switch (cmbMainType.Text.Trim().ToLower())
                {
                    case "cloth":
                        {
                            txtSizeHeight.ReadOnly = true;
                            cmbType.Enabled = false;
                            cmbMainType.Enabled = false;
                            cmbDensity.Enabled = false;
                            break;
                        }
                    case "accessories": {
                        cmbType.Enabled = false;
                        break;
                    }
                    case "light":
                    case "stands":
                    case "grip": {
                        txtAssetMake.ReadOnly = true;
                        cmbType.Enabled = false;
                        cmbMainType.Enabled = false;
                        txtQuality.ReadOnly = true;
                        break;
                    }
                } 
            }
        }
        private string GenerateCode()
        {
            //For Fixtures,Equipment’s, & Lights:  Make (Char 3) Voltage(Char 4) Fixture Type (Char 3) Type (Char 3) Sr.No (Number 3)
            //Cloth Size (Char 5) Density (Char 4) Type (Char 4) Sr. No.(Number 3)
            //Accessories Type(NumChar 5) Sr.no.(Number 3)
            string sAssetCode = string.Empty;
            Int32 number = Convert.ToInt32(lblSequenceNo.Text)+1;
            switch (cmbMainType.Text.Trim().ToString().ToLower())
            {
                case "cloth":
                    {
                        string sSize = string.Empty;
                        string sDensity = string.Empty;
                        string sType = string.Empty;
                        string sNumber = string.Empty;
                        if (txtSizeHeight.Text.Trim().Replace(" ", "") != "")
                        {
                            if (txtSizeHeight.Text.Length <= 5)
                            {
                                sSize = txtSizeHeight.Text.Trim().Replace(" ", "");
                            }
                            else if (txtSizeHeight.Text.Length > 5)
                            {
                                sSize = txtSizeHeight.Text.Substring(0, 5).Trim().Replace(" ", "");
                            }
                        }
                        if (cmbDensity.Text.Trim().Replace(" ", "") != "")
                        {
                            if (cmbDensity.Text.Length <= 4)
                            {
                                sDensity = cmbDensity.Text.Trim().Replace(" ", "");
                            }
                            else if (cmbDensity.Text.Length > 4)
                            {
                                sDensity = cmbDensity.Text.Substring(0, 4).Trim().Replace(" ", "");
                            }
                        }
                        if (cmbType.Text.Trim().Replace(" ", "") != "")
                        {
                            if (cmbType.Text.Length <= 4)
                            {
                                sType = cmbType.Text.Trim().Replace(" ", "");
                            }
                            else if (cmbType.Text.Length > 4)
                            {
                                sType = cmbType.Text.Substring(0, 4).Trim().Replace(" ", "");
                            }
                        }
                        //sNumber = number.ToString();
                        //string sSize = txtSizeHeight.Text.Trim().Replace(" ","") == "" ? "" : txtSizeHeight.Text.Substring(0, 5);
                        //string sDensity = cmbDensity.Text.Substring(0, 4);
                        //string sType = cmbType.Text.Substring(0, 4);
                        //string sNumber = lblSequenceNo.Text;
                        sAssetCode = sSize + sDensity + sType;// +sNumber;
                        break;
                    }
                case "accessories":
                    {
                        string sType = string.Empty;
                        string sNumber = string.Empty;
                        if (cmbType.Text.Trim().Replace(" ", "") != "")
                        {
                            if (cmbType.Text.Length <= 5)
                            {
                                sType = cmbType.Text.Trim().Replace(" ", "");
                            }
                            else if (cmbType.Text.Length > 5)
                            {
                                sType = cmbType.Text.Substring(0, 5).Trim().Replace(" ", "");
                            }
                        }
                        //sNumber = number.ToString();
                        sAssetCode = sType;//+ sNumber;
                        break;
                    }
                case "light":
                case "stands":
                case "grip":
                    {
                        string sMake = string.Empty;
                        string sVoltage = string.Empty;
                        string sFixtureType = string.Empty;
                        string sType = string.Empty;
                        string sNumber = string.Empty;
                        if (txtAssetMake.Text.Trim().Replace(" ", "") != "")
                        {
                            if (txtAssetMake.Text.Length <= 3)
                            {
                                sMake = txtAssetMake.Text.Trim().Replace(" ", "");
                            }
                            else if (txtAssetMake.Text.Length > 3)
                            {
                                sMake = txtAssetMake.Text.Substring(0, 3).Trim().Replace(" ", "");
                            }
                        }
                        if (txtQuality.Text.Trim().Replace(" ", "") != "")
                        {
                            if (txtQuality.Text.Length <= 4)
                            {
                                sVoltage = txtQuality.Text.Trim().Replace(" ", "");
                            }
                            else if (txtQuality.Text.Length > 4)
                            {
                                sVoltage = txtQuality.Text.Substring(0, 4).Trim().Replace(" ", "");
                            }
                        }
                        if (cmbMainType.Text.Trim().Replace(" ", "") != "")
                        {
                            if (cmbMainType.Text.Length <= 3)
                            {
                                sFixtureType = cmbMainType.Text.Trim().Replace(" ", "");
                            }
                            else if (cmbMainType.Text.Length > 3)
                            {
                                sFixtureType = cmbMainType.Text.Substring(0, 3).Trim().Replace(" ", "");
                            }
                        }
                        if (cmbType.Text.Trim().Replace(" ", "") != "")
                        {
                            if (cmbType.Text.Length <= 3)
                            {
                                sType = cmbType.Text.Trim().Replace(" ", "");
                            }
                            else if (cmbType.Text.Length > 3)
                            {
                                sType = cmbType.Text.Substring(0, 3).Trim().Replace(" ", "");
                            }
                        }
                        //sNumber = number.ToString();

                        sAssetCode = sMake + sVoltage + sFixtureType + sType;// +sNumber;
                        break;
                    }
            }
            return sAssetCode;
        }
        private void btnAddBarcodeDetails_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 0;
                byte[] BarcodeImage = new byte[] { };
                if (picBarcodeImage != null)
                {
                    if (picBarcodeImage.Image!=null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            picBarcodeImage.Image.Save(ms, ImageFormat.Jpeg);
                            BarcodeImage = new byte[ms.Length];
                            ms.Position = 0;
                            ms.Read(BarcodeImage, 0, BarcodeImage.Length);
                        } 
                    }
                }
                string sValue = string.Empty;
                num = dtAssetCode.Rows.Count;
                num++;
                sValue = num.ToString();
                if (num < 1000)
                {
                    sValue = num.ToString("000");
                }
                if (Convert.ToInt64(lblAssetID.Text) > 0)
                {
                    AssetCode oAssetCode = null;
                    if (btnAddBarcodeDetails.Text.ToLower() == "add")
                    {
                        oAssetCode = new AssetCode();
                        oAssetCode.nAssetID = Convert.ToInt64(lblAssetID.Text);
                        oAssetCode.nAssetCodeID = Convert.ToInt64(lblAssetCodeID.Text);
                        oAssetCode.nSequenceNo = num;
                        oAssetCode.sInitialCode = txtAssetCode.Text;
                        oAssetCode.sUniqueCode = txtAssetCode.Text + lblSequenceNo.Text;
                        oAssetCode.barcode = BarcodeImage;
                        oAssetCode.dtShelfLife = Convert.ToDateTime(dtShelfLife.Text);
                        oAssetCode.dtRetirementDate = Convert.ToDateTime(dtRetirementDate.Text);
                        oAssetCode.sShelfLifeUnit = txtShelfLifeUnit.Text.Trim();
                    }
                    else if(btnAddBarcodeDetails.Text.ToLower()=="edit")
                    {
                        oAssetCode = new AssetCode();
                        oAssetCode.nAssetID = Convert.ToInt64(lblAssetID.Text);
                        oAssetCode.nAssetCodeID = Convert.ToInt64(lblAssetCodeID.Text);
                        oAssetCode.nSequenceNo = 0;
                        oAssetCode.sInitialCode = lblInitialCode.Text;
                        oAssetCode.sUniqueCode = lblInitialCode.Text + lblSequenceNo.Text;
                        oAssetCode.barcode = BarcodeImage;
                        oAssetCode.dtShelfLife = Convert.ToDateTime(dtShelfLife.Text);
                        oAssetCode.dtRetirementDate = Convert.ToDateTime(dtRetirementDate.Text);
                        oAssetCode.sShelfLifeUnit = txtShelfLifeUnit.Text.Trim();
                    }
                    Int64 nStatus = oAssetCode.UpdateAssetCode();

                    if (nStatus > 0)
                    {
                        FillAssetCode(oAssetCode.nAssetID);
                    }
                }
                else
                {
                    if (btnAddBarcodeDetails.Text.ToLower() == "edit")
                    {
                        DataRow[] drSelected = dtAssetCode.Select("RowNo=" + lblSelectedRow.Text);
                        foreach (DataRow drAsset in drSelected)
                        {
                            drAsset["barcode"] = BarcodeImage;
                            drAsset["dtShelfLife"] = Convert.ToDateTime(dtShelfLife.Text.ToString());
                            drAsset["sShelfLifeUnit"] = txtShelfLifeUnit.Text.Trim().ToString();
                            drAsset["dtRetirementDate"] = Convert.ToDateTime(dtRetirementDate.Text.ToString());
                        }
                        dtAssetCode.AcceptChanges();
                        gvAssetList.RefreshData();
                    }
                    else
                    {
                        //string sValue = string.Empty;
                        //num = dtAssetCode.Rows.Count;
                        //num++;
                        //sValue = num.ToString();
                        //if (num < 1000)
                        //{
                        //    sValue = num.ToString("000");
                        //}
                        //MessageBox.Show("Value: " + sValue);
                        DataRow drAsset = dtAssetCode.NewRow();
                        drAsset["nSequenceNo"] = sValue;
                        drAsset["sInitialCode"] = txtAssetCode.Text.Trim();
                        drAsset["sUniqueCode"] = txtAssetCode.Text.Trim() + num.ToString();
                        drAsset["barcode"] = BarcodeImage;
                        drAsset["dtShelfLife"] = Convert.ToDateTime(dtShelfLife.Text.ToString());
                        drAsset["sShelfLifeUnit"] = txtShelfLifeUnit.Text.Trim().ToString();
                        drAsset["dtRetirementDate"] = Convert.ToDateTime(dtRetirementDate.Text.ToString());
                        drAsset["RowNo"] = num;
                        dtAssetCode.Rows.Add(drAsset);
                        gvAssetList.GridControl.DataSource = dtAssetCode;
                        gvAssetList.Columns[1].Visible = false;
                        gvAssetList.Columns[6].Visible = false;
                    }
                }
                ClearAssetCodeDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error asset code: " + ex.ToString(), clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAssetCodeDetails()
        {
            if (picBarcodeImage!=null)
            {
                picBarcodeImage.Image = null;
            }
            dtShelfLife.EditValue = DateTime.Now;
            dtRetirementDate.EditValue = DateTime.Now;
            txtShelfLifeUnit.Text = "";

            lblAssetCodeID.Text = "0";
            lblInitialCode.Text = "0";
            lblSequenceNo.Text = "0";
            btnAddBarcodeDetails.Text = "Add";
        }

        private void txtSizeHeight_EditValueChanged(object sender, EventArgs e)
        {
            //if (txtSizeHeight.Text.Trim() != "")
            //{
            //    txtAssetCode.Text = GenerateCode();
            //}
            //UpdateAssetCodeTable();
        }

        private void UpdateAssetCodeTable()
        {
            txtAssetCode.Text = GenerateCode();
            DataColumn dc = new DataColumn("sUniqueCode");
            dc.DataType = typeof(string);
            dc.DefaultValue = GenerateCode();
            dtAssetCode.Columns.Remove("sUniqueCode");
            dtAssetCode.Columns.Add(dc);
            dtAssetCode.AcceptChanges();
            gvAssetList.RefreshData();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbType.Text.Trim() != "")
            //{
            //    txtAssetCode.Text = GenerateCode();
            //}
        }

        private void cmbDensity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbDensity.Text.Trim() != "")
            //{
            //    txtAssetCode.Text = GenerateCode();
            //}

        }

        private void txtAssetMake_EditValueChanged(object sender, EventArgs e)
        {
            //if (txtAssetMake.Text.Trim() != "")
            //{
            //    txtAssetCode.Text = GenerateCode();
            //}

        }

        private void txtQuality_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void txtSizeHeight_Leave(object sender, EventArgs e)
        {
            UpdateAssetCodeTable();

        }

        private void cmbType_Leave(object sender, EventArgs e)
        {
            UpdateAssetCodeTable();

        }

        private void txtAssetMake_Leave(object sender, EventArgs e)
        {
            if (cmbMainType.Text == "Grip" || cmbMainType.Text == "Light")
            {
                UpdateAssetCodeTable();
            } 

        }

        private void txtQuality_Leave(object sender, EventArgs e)
        {
            if (cmbMainType.Text == "Grip" || cmbMainType.Text == "Light")
            {
                UpdateAssetCodeTable();
            }

        }

        private void cmbDensity_Leave(object sender, EventArgs e)
        {
            if (cmbMainType.Text == "Cloth")
            {
                UpdateAssetCodeTable();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveAssetDetails();
            }
        }

        private void SaveAssetDetails(bool bIsSaveAsset_Code=true)
        {
            AssetMaster oAsset = null;
            try
            {
                oAsset = new AssetMaster();
                oAsset.nAssetID = Convert.ToInt64(lblAssetID.Text);
                oAsset.nCompanyID = Convert.ToInt64(cmbCompanyMst.SelectedValue);
                oAsset.nAssetMainTypeID = Convert.ToInt64(cmbMainType.SelectedValue);
                oAsset.nAssetTypeID = Convert.ToInt64(cmbType.SelectedValue);
                oAsset.nAssetTypeOneID = Convert.ToInt64(cmbType1.SelectedValue);
                oAsset.nAssetMaterialID = Convert.ToInt64(cmbMaterialType.SelectedValue);
                oAsset.nAssetVendorID = Convert.ToInt64(cmbPartyVendor.SelectedValue);
                oAsset.nDensityID = cmbDensity.Enabled == true ? Convert.ToInt64(cmbDensity.SelectedValue) : 0;
                oAsset.nColorID = cmbColor.Enabled == true ? Convert.ToInt64(cmbColor.SelectedValue) : 0;
                oAsset.nHSNCodeID = Convert.ToInt64(cmbHSNCode.SelectedValue);
                oAsset.sAssetName = Convert.ToString(txtAssetName.Text);
                oAsset.sAssetAbbrivation = Convert.ToString(txtAssetAbbrivation.Text);
                oAsset.sAssetDescription = Convert.ToString(txtAssetDescription.Text);
                oAsset.dtReorderDate = Convert.ToDateTime(dtReorderTime.Text);
                oAsset.dtIntroductionDate = Convert.ToDateTime(dtIntroductionDate.Text);
                oAsset.sReorderDays = Convert.ToString(txtReorderDays.Text);
                oAsset.sReorderQuntity = Convert.ToString(txtReorderQuantity.Text);
                oAsset.sAssetRate = Convert.ToString(txtAssetRate.Text);
                oAsset.sAssetMake = Convert.ToString(txtAssetMake.Text);
                oAsset.sAssetSizeOrCapacity = Convert.ToString(txtSizeHeight.Text);
                oAsset.sAssetQuality = Convert.ToString(txtAssetAbbrivation.Text);
                oAsset.sAssetDimention = Convert.ToString(txtWeight.Text);
                oAsset.sAssetWeight = Convert.ToString(txtWeight.Text);
                oAsset.sWattage = Convert.ToString(txtWattage.Text);
                oAsset.sSpan = Convert.ToString(txtSpan.Text);
                oAsset.sAttachment = Convert.ToString(txtAttachment.Text);
                oAsset.sAttachmentName = Convert.ToString(txtAttachmentName.Text);
                oAsset.sLength = Convert.ToString(txtLength.Text);
                oAsset.sCoreOrPole = Convert.ToString(txtCore.Text);
                oAsset.sAmps = Convert.ToString(txtAmps.Text);
                oAsset.sPlug = Convert.ToString(txtPlug.Text);
                oAsset.sPower = Convert.ToString(txtPower.Text);
                List<AssetCode> lstAssetCode = new List<AssetCode>();
                foreach (DataRow dr in dtAssetCode.Rows)
                {
                    using (AssetCode oAssetCode = new AssetCode())
                    {
                        oAssetCode.nAssetCodeID = 0;
                        oAssetCode.nSequenceNo = Convert.ToInt32(dr["nSequenceNo"]);
                        oAssetCode.sInitialCode = Convert.ToString(dr["sInitialCode"]);
                        oAssetCode.sUniqueCode = Convert.ToString(dr["sUniqueCode"]);
                        oAssetCode.barcode = (byte[])dr["barcode"];
                        oAssetCode.dtShelfLife = Convert.ToDateTime(dr["dtShelfLife"]);
                        oAssetCode.sShelfLifeUnit = Convert.ToString(dr["sShelfLifeUnit"]);
                        oAssetCode.dtRetirementDate = Convert.ToDateTime(dr["dtRetirementDate"]);
                        lstAssetCode.Add(oAssetCode);
                    }
                }
                oAsset.lstAssetCode = lstAssetCode;
                Int64 nAssetID = oAsset.InsertUpdateAsset(bIsSaveAsset_Code);
                if (nAssetID == 0)
                {
                    MessageBox.Show("Asset details not saved.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nAssetID == 2)
                {
                    MessageBox.Show("Asset code already present. Please change asset code.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Asset details saved successfuly", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Save : " + ex.Message, clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (oAsset!=null)
                {
                    oAsset.Dispose();
                    oAsset = null;
                }
            }
        }
        public bool ValidateForm()
        {
            if (txtAssetName.Text.Trim()=="")
            {
                MessageBox.Show("Enter Asset Name.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAssetName.Focus();
                return false;
            }
            if (cmbMainType.Text.Trim()=="")
            {
                MessageBox.Show("Select Asset Type.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMainType.Focus();
                return false;
            }

            return true;
        }

        private void dtReorderTime_EditValueChanged(object sender, EventArgs e)
        {
            double nDays = 0;
            DateTime dtIntroDate = Convert.ToDateTime(dtIntroductionDate.Text);
            DateTime dtROrderDate = Convert.ToDateTime(dtReorderTime.Text);
            nDays = (dtROrderDate - dtIntroDate).TotalDays;
            txtReorderDays.Text=Convert.ToString(nDays);
        }

        private void gvAssetList_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Delete")
                {
                    int nVal = Convert.ToString(gvAssetList.GetRowCellValue(e.RowHandle, "IsUsed")) == "" || Convert.ToString(gvAssetList.GetRowCellValue(e.RowHandle, "IsUsed")) == "0" ? 0 : 1;
                    
                    bool val = Convert.ToBoolean(nVal);
                    if (val)
                    {
                        DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ritem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
                        ritem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                        ritem.ReadOnly = false;
                        ritem.Buttons[0].Enabled = false;
                        ritem.Buttons[0].Visible = false;
                        e.RepositoryItem = ritem;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gvAssetList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Edit")
                {
                    var row = gvAssetList.GetFocusedDataRow();

                    txtShelfLifeUnit.Text=Convert.ToString(row[11]);
                    dtShelfLife.Text=Convert.ToString(row[10]);
                    dtRetirementDate.Text=Convert.ToString(row[12]);
                    byte[] barcodeImage = (byte[])row[9];
                    lblAssetCodeID.Text = Convert.ToString(row[1]);
                    lblInitialCode.Text = Convert.ToString(row[3]);
                    lblSequenceNo.Text = Convert.ToString(row[4]);
                    lblSelectedRow.Text = Convert.ToString(row[0]);
                    btnAddBarcodeDetails.Text = "Edit";
                    if (barcodeImage.Length > 0)
                    {
                        barcodeImage = (byte[])row[9];
                        MemoryStream msHeaderImage = new MemoryStream(barcodeImage);
                        picBarcodeImage.Image = Image.FromStream(msHeaderImage);
                    }
                }
                if (e.Column.Caption == "Delete")
                {
                    var row = gvAssetList.GetFocusedDataRow();
                    int n = Convert.ToString(gvAssetList.GetRowCellValue(e.RowHandle, "IsUsed")) == "" || Convert.ToString(gvAssetList.GetRowCellValue(e.RowHandle, "IsUsed")) == "0" ? 0 : 1;
                    
                    if (n == 1)
                    {
                        return;
                    }
                    if (Convert.ToInt64(lblAssetID.Text)>0)
                    {
                        Int64 nAssetCodeID = Convert.ToInt64(row["nAssetCodeID"]);
                        AssetCode oAssetCode = new AssetCode();
                        oAssetCode.nAssetCodeID = nAssetCodeID;
                        if (oAssetCode.DeleteAssetCode() > 0)
                        {
                            MessageBox.Show("Asset code deleted successfully.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Asset code not deleted.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        FillAssetCode(Convert.ToInt64(lblAssetID.Text));

                        if (oAssetCode != null)
                        {
                            oAssetCode.Dispose();
                            oAssetCode = null;
                        }
                    }
                    else
                    {
                        Int64 nRowNo = Convert.ToInt64(row["RowNo"]);
                        DataRow[] drDelete = dtAssetCode.Select("RowNo=" + Convert.ToInt64(nRowNo));
                        foreach (DataRow dr in drDelete)
                        {
                            dr.Delete();
                        }
                        dtAssetCode.AcceptChanges();
                        int nRow = 0;
                        foreach (DataRow dr in dtAssetCode.Rows)
                        {
                            nRow++;
                            dr["RowNo"] = nRow;
                        }
                        //gvAssetList.GridControl.DataSource = dtAssetCode;
                        //gvAssetList.RefreshData();
                    }
                    gvAssetList.GridControl.DataSource = dtAssetCode;
                    gvAssetList.RefreshData();
                    //FillAssetCode();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex, clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateAsset_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveAssetDetails(false);
            }
        }
    }
}
