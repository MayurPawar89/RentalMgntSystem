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
    public partial class frmAddKit : DevExpress.XtraEditors.XtraForm
    {
        public frmAddKit()
        {
            InitializeComponent();
            lblKitID.Text = "0";
            GetAndSetSequence();
            FillAllAsset();
            txtKitName.Focus();
        }

        public frmAddKit(Int64 nKitID)
        {
            InitializeComponent();
            lblKitID.Text = Convert.ToString(nKitID);
            GetAndSetSequence();
            FillAllAsset();
            txtKitName.Focus();
        }
        DataTable dtAssetCode = new DataTable();

        private void GetAndSetSequence()
        {
            clsGeneral oclsGeneral = null;
            try
            {
                oclsGeneral = new clsGeneral();
                txtKitCode.Text = "KIT/" + Convert.ToString(oclsGeneral.GetSequenceNumber_Transaction(TransactionType.Kit));
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
        private void FillAllAsset()
        {
            AssetCode oAsset = null;
            DataTable dtAssetList = null;
            try
            {
                oAsset = new AssetCode();
                dtAssetList = oAsset.GetAssetCode();
                if (dtAssetList != null)
                {
                    DataRow drAsset = dtAssetList.NewRow();
                    drAsset["nAssetCodeID"] = 0;
                    drAsset["sAssetCodeName"] = "";
                    dtAssetList.Rows.InsertAt(drAsset, 0);

                    cmbAssetList.DataSource = dtAssetList;
                    cmbAssetList.DisplayMember = "sAssetCodeName";
                    cmbAssetList.ValueMember = "nAssetCodeID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void frmAddKit_Load(object sender, EventArgs e)
        {
            FillAssetCode();
            if (Convert.ToInt64(lblKitID.Text)>0)
            {
                pnlSave.Visible = false;
                FillKitInformation(Convert.ToInt64(lblKitID.Text));
            }
        }
        private void FillAssetCode(Int64 nKitID = 0)
        {
            KitMaster oKit = null;
            try
            {
                oKit = new KitMaster();
                dtAssetCode = oKit.GetKitAssetAssociation(nKitID);
                if (dtAssetCode != null)
                {
                    gvAssetList.GridControl.DataSource = dtAssetCode;
                    gvAssetList.Columns[1].Visible = false;
                    gvAssetList.Columns[2].Visible = false;
                    gvAssetList.Columns[5].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void FillKitInformation(long nKitID)
        {
            KitMaster oKitMaster = null;
            DataSet ds = null;
            try
            {
                oKitMaster = new KitMaster();
                ds = oKitMaster.GetKitDetails(nKitID);
                if (ds!=null&&ds.Tables.Count>0)
                {
                    DataTable dtKitDetails = ds.Tables[0];
                    DataTable dtKitAssetDetails = ds.Tables[1];

                    if (dtKitDetails!=null&&dtKitDetails.Rows.Count>0)
                    {
                        lblKitID.Text = Convert.ToString(dtKitDetails.Rows[0]["nKitID"]);
                        txtKitName.Text = Convert.ToString(dtKitDetails.Rows[0]["sKitName"]);
                        txtKitCode.Text = Convert.ToString(dtKitDetails.Rows[0]["sKitCode"]);
                        txtAbbrivation.Text = Convert.ToString(dtKitDetails.Rows[0]["sKitAbbrivation"]);
                        txtKitDescription.Text = Convert.ToString(dtKitDetails.Rows[0]["sKitDescription"]);
                        byte[] barcodeImage = (byte[])dtKitDetails.Rows[0]["Barcode"];

                        if (barcodeImage.Length > 0)
                        {
                            barcodeImage = (byte[])dtKitDetails.Rows[0]["Barcode"];
                            MemoryStream msHeaderImage = new MemoryStream(barcodeImage);
                            picBarcodeImage.Image = Image.FromStream(msHeaderImage);
                        }

                    }
                    if (dtKitAssetDetails!=null)
                    {
                        gvAssetList.GridControl.DataSource = dtKitAssetDetails;
                        gvAssetList.Columns[1].Visible = false;
                        gvAssetList.Columns[2].Visible = false;
                        gvAssetList.Columns[5].Visible = false;
                    }
                    btnUpdateKit.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtKitName_EditValueChanged(object sender, EventArgs e)
        {
            txtAbbrivation.Text = clsGlobal.GenerateAbbrivation(txtKitName.Text.Trim());
        }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateAssetCode())
                {
                    int num = 0;
                    string sValue = string.Empty;
                    num = dtAssetCode.Rows.Count;
                    num++;
                    sValue = num.ToString();
                    if (num < 1000)
                    {
                        sValue = num.ToString("000");
                    }
                    if (Convert.ToInt64(lblKitID.Text) > 0)
                    {
                        KitAsset oKitAsset = null;
                        if (btnAddAsset.Text.ToLower() == "add")
                        {
                            string[] sKitAssetName = cmbAssetList.Text.Trim().Split('-');
                            oKitAsset = new KitAsset();
                            oKitAsset.nAssetID = 0;
                            oKitAsset.nAssetCodeID = Convert.ToInt64(cmbAssetList.SelectedValue);
                            oKitAsset.nKitAssetID = 0;
                            oKitAsset.nKitID = Convert.ToInt64(lblKitID.Text);
                            oKitAsset.sAssetName = Convert.ToString(sKitAssetName[0]);
                            oKitAsset.sUniqueCode = Convert.ToString(sKitAssetName[1]);
                            oKitAsset.sAssetNameWithCode = Convert.ToString(cmbAssetList.Text);
                        }
                        else if (btnAddAsset.Text.ToLower() == "edit")
                        {
                            string[] sKitAssetName = cmbAssetList.Text.Trim().Split('-');
                            oKitAsset = new KitAsset();
                            oKitAsset.nAssetID = Convert.ToInt64(lblAssetID.Text);
                            oKitAsset.nAssetCodeID = Convert.ToInt64(lblAssetCodeID.Text);
                            oKitAsset.nKitAssetID = Convert.ToInt64(lblKitAssetID.Text);
                            oKitAsset.nKitID = Convert.ToInt64(lblKitID.Text);
                            oKitAsset.sAssetName = Convert.ToString(sKitAssetName[0]);
                            oKitAsset.sUniqueCode = Convert.ToString(sKitAssetName[1]);
                            oKitAsset.sAssetNameWithCode = Convert.ToString(lblAssetCodeName.Text);
                        }
                        Int64 nStatus = oKitAsset.UpdateAssetCode();

                        if (nStatus > 0)
                        {
                            FillAssetCode(oKitAsset.nKitID);
                        }
                    }
                    else
                    {
                        string[] sKitAssetName = cmbAssetList.Text.Trim().Split('-');

                        DataRow drKit = dtAssetCode.NewRow();
                        drKit["RowNo"] = num;
                        drKit["nKitAssetID"] = 0;
                        drKit["nKitID"] = 0;
                        drKit["nAssetID"] = 0;
                        drKit["nAssetCodeID"] = Convert.ToInt64(cmbAssetList.SelectedValue);
                        drKit["sUniqueCode"] = sKitAssetName[1];
                        drKit["sAssetName"] = sKitAssetName[0];
                        drKit["assetNameWithCode"] = cmbAssetList.Text.Trim();

                        dtAssetCode.Rows.Add(drKit);
                        gvAssetList.GridControl.DataSource = dtAssetCode;
                        gvAssetList.Columns[1].Visible = false;
                        gvAssetList.Columns[2].Visible = false;
                        gvAssetList.Columns[5].Visible = false;
                    }
                    ClearKitDetails(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error asset code: " + ex.ToString(), clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateAssetCode()
        {
            bool bIsValid = true;
            if (cmbAssetList.Text.Trim()=="")
            {
                MessageBox.Show("Select Asset Code.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbAssetList.Focus();
                return false;
            }
            if (Convert.ToInt64(lblKitID.Text)<=0)
            {
                Int64 nAssetCodeID = Convert.ToInt64(cmbAssetList.SelectedValue);
                DataRow[] dr = dtAssetCode.Select("nAssetCodeID=" + Convert.ToString(nAssetCodeID));
                if (dr.Length>0)
                {
                    MessageBox.Show("Asset Code already exist.\nPlease select other asset code.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbAssetList.Focus();
                    return false;
                }
            }
            return bIsValid;
        }
        private void ClearKitDetails()
        {
            cmbAssetList.SelectedValue = 0;
            txtAssetCode.Text = "";
        }

        private void gvAssetList_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {

        }

        private void gvAssetList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Edit")
                {
                    Int64 nKitID = 0;
                    var row = gvAssetList.GetFocusedDataRow();

                    lblKitAssetID.Text = Convert.ToString(row[1]);
                    lblKitID.Text = Convert.ToString(row[2]);
                    lblAssetID.Text = Convert.ToString(row[3]);
                    lblAssetCodeID.Text = Convert.ToString(row[4]);
                    lblAssetCodeName.Text = Convert.ToString(row[7]);
                    DataTable dtAssetList =(DataTable) cmbAssetList.DataSource;
                    DataRow drAsset = dtAssetList.NewRow();
                    drAsset["nAssetCodeID"] = lblAssetCodeID.Text;
                    drAsset["sAssetCodeName"] = Convert.ToString(row[7]);
                    dtAssetList.Rows.InsertAt(drAsset, 0);

                    cmbAssetList.DataSource = dtAssetList;
                    cmbAssetList.DisplayMember = "sAssetCodeName";
                    cmbAssetList.ValueMember = "nAssetCodeID";
                    cmbAssetList.SelectedIndex = 0;
                    btnAddAsset.Text = "Edit";
                }
                if (e.Column.Caption == "Delete")
                {
                    var row = gvAssetList.GetFocusedDataRow();
                    int n = Convert.ToString(gvAssetList.GetRowCellValue(e.RowHandle, "IsUsed")) == "" || Convert.ToString(gvAssetList.GetRowCellValue(e.RowHandle, "IsUsed")) == "0" ? 0 : 1;

                    if (n == 1)
                    {
                        return;
                    }
                    if (Convert.ToInt64(lblKitID.Text)>0)
                    {
                        Int64 nKitAssetID = Convert.ToInt64(row["nKitAssetID"]);
                        KitAsset oKitAsset = new KitAsset();
                        oKitAsset.nKitAssetID = nKitAssetID;
                        if(oKitAsset.DeleteKitAsset()>0)
                        {
                            MessageBox.Show("Asset code deleted successfully.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Asset code not deleted.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        FillAssetCode(Convert.ToInt64(lblKitID.Text));
                     
                        if (oKitAsset!=null)
                        {
                            oKitAsset.Dispose();
                            oKitAsset = null;
                        }
                    }
                    else
                    {
                        Int64 nAssetCodeID = Convert.ToInt64(row["nAssetCodeID"]);
                        DataRow[] drDelete = dtAssetCode.Select("nAssetCodeID=" + Convert.ToInt64(nAssetCodeID));
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
                    FillAllAsset();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex, clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveKitDetils();
            }
        }

        private void SaveKitDetils(bool bIsSaveKit_Asset = true)
        {
            KitMaster oKitMaster = null;
            try
            {

                oKitMaster = new KitMaster();
                oKitMaster.nKitID = Convert.ToInt64(lblKitID.Text);
                oKitMaster.sKitName = txtKitName.Text.Trim();
                oKitMaster.sKitCode = txtKitCode.Text.Trim();
                oKitMaster.sKitAbbrivation = txtAbbrivation.Text.Trim();
                oKitMaster.sKitDescription = txtKitDescription.Text.Trim();
                byte[] BarcodeImage = new byte[] { };
                if (picBarcodeImage != null)
                {
                    if (picBarcodeImage.Image != null)
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
                oKitMaster.kitBarcode = BarcodeImage;
                List<KitAsset> lstKitAsset = new List<KitAsset>();
                foreach (DataRow dr in dtAssetCode.Rows)
                {
                    using (KitAsset oKitAsset = new KitAsset())
                    {
                        oKitAsset.nKitID = Convert.ToInt64(dr["nKitID"]);
                        oKitAsset.nKitAssetID = Convert.ToInt64(dr["nKitAssetID"]);
                        oKitAsset.nAssetID = Convert.ToInt64(dr["nAssetID"]);
                        oKitAsset.nAssetCodeID = Convert.ToInt64(dr["nAssetCodeID"]);
                        oKitAsset.sAssetName = Convert.ToString(dr["sAssetName"]);
                        oKitAsset.sUniqueCode = Convert.ToString(dr["sUniqueCode"]);
                        oKitAsset.sAssetNameWithCode = Convert.ToString(dr["assetNameWithCode"]);
                        lstKitAsset.Add(oKitAsset);
                    }
                }
                oKitMaster.lstKitDetails = lstKitAsset;

                Int64 nKitID = oKitMaster.InsertUpdateKitDetails(bIsSaveKit_Asset);
                if (nKitID == 0)
                {
                    MessageBox.Show("Kit details not saved.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nKitID == 2)
                {
                    MessageBox.Show("Kit code already present. Please change asset code.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("kit details saved successfuly", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private bool ValidateForm()
        {
            if (txtKitName.Text.Trim()=="")
            {
                MessageBox.Show("Enter kit name.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKitName.Focus();
                return false;
            }
            return true;
        }

        private void btnUpdateKit_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveKitDetils(false);
            }
        }
    }
}
