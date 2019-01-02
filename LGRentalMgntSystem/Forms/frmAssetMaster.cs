using LGRentalMgntSystem.Class;
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
    public partial class frmAssetMaster : DevExpress.XtraEditors.XtraForm
    {
        public string sMessageboxCaption = string.Empty;
        public frmAssetMaster()
        {
            InitializeComponent();
            sMessageboxCaption = System.Configuration.ConfigurationManager.AppSettings["MessageboxCaption"];
        }
        public MasterType MasterType { get; set; }
        public bool IsMasterSave { get; set; }
        public Int64 nTypeID { get; set; }
        public string sTypeName { get; set; }
        public string sTypeCode { get; set; }
        public bool bIsAllowAccess { get; set; }
        public bool bIsAllowSignatory { get; set; }
        public Int64 nMainTypeID { get; set; }
        private void frmAssetMaster_Load(object sender, EventArgs e)
        {
            try
            {
                pnlAssetMainType.Visible = false;
                switch (MasterType)
                {
                    case MasterType.CompanyType:
                        {
                            this.Height = 170;
                            lblFormHeader.Text = "Company Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            txtMasterCode.Text = sTypeCode;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            break;
                        }
                    case MasterType.MaterialType:
                        {
                            this.Height = 170;
                            lblFormHeader.Text = "Material Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            txtMasterCode.Text = sTypeCode;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            break;
                        }
                    case MasterType.Designation:
                        {
                            this.Height = 216;
                            lblFormHeader.Text = "Designation";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            txtMasterCode.Text = sTypeCode;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            if (bIsAllowAccess)
                            {
                                rdAllowAccessYes.Checked=true;
                                rdAllowAccessNo.Checked = false;
                            }
                            else if (bIsAllowAccess==false)
                            {
                                rdAllowAccessYes.Checked=false;
                                rdAllowAccessNo.Checked = true;
                            }
                            if (bIsAllowSignatory)
                            {
                                rdAllowSignatoryYes.Checked = true;
                                rdAllowSignatoryNo.Checked = false;
                            }
                            else if (bIsAllowSignatory == false)
                            {
                                rdAllowSignatoryYes.Checked = false;
                                rdAllowSignatoryNo.Checked = true;
                            }
                            pnlAllowSettings.Visible = true;
                            break;
                        }
                    case MasterType.AssetType:
                        {
                            this.Height = 200;
                            lblFormHeader.Text = "Asset Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            txtMasterCode.Text = sTypeCode;
                            FillAssetMaintype();
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            pnlAssetMainType.Visible = true; 
                            
                            break;
                        }
                    case MasterType.AssetType1:
                        {
                            this.Height = 200;
                            lblFormHeader.Text = "Asset Type1";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            txtMasterCode.Text = sTypeCode;
                            FillAssetMaintype();
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            pnlAssetMainType.Visible = true;
                            break;
                        }
                    case MasterType.PartyType:
                        {
                            this.Height = 170;
                            lblFormHeader.Text = "Party Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            txtMasterCode.Text = sTypeCode;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            break;
                        }
                    case MasterType.VehicleType:
                        {
                            this.Height = 170;
                            lblFormHeader.Text = "Vehicle Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            txtMasterCode.Text = sTypeCode;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            break;
                        }
                    case MasterType.ColourType:
                        {
                            this.Height = 170;
                            lblFormHeader.Text = "Colour Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            txtMasterCode.Text = sTypeCode;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            break;
                        }
                    case MasterType.DensityType:
                        {
                            this.Height = 170;
                            lblFormHeader.Text = "Density Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            txtMasterCode.Text = sTypeCode;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            break;
                        }
                    case MasterType.AssetMainType:
                        {
                            this.Height = 170;
                            lblFormHeader.Text = "Asset Main Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            txtMasterCode.Text = sTypeCode;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void FillAssetMaintype()
        {
            clsMasters clsMaster = null;
            DataTable dtAssetMainMaster = null;
            try
            {
                clsMaster = new clsMasters();
                dtAssetMainMaster = clsMaster.GetAssetMainMasterType(1);
                DataRow dr = dtAssetMainMaster.NewRow();
                dr["nAssetMainTypeID"]=0;
                dr["sAssetType"] = "";
                dtAssetMainMaster.Rows.InsertAt(dr, 0);

                cmbAssetMainType.DataSource = dtAssetMainMaster;
                cmbAssetMainType.DisplayMember = "sAssetType";
                cmbAssetMainType.ValueMember = "nAssetMainTypeID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                if (clsMaster != null)
                {
                    clsMaster = null;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMainTypeName.Text.Trim()=="")
            {
                MessageBox.Show("Please Enter " + lblFormHeader.Text + ".", sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMainTypeName.Focus();
                return;
            }
            switch (MasterType)
            {
                case MasterType.AssetType:
                case MasterType.AssetType1:
                    {
                        if (Convert.ToInt64(cmbAssetMainType.SelectedValue) == 0)
                        {
                            MessageBox.Show("Please Select Main Asset Type.", sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMainTypeName.Focus();
                            return;
                        }
                        break; }
            }
            clsMasters clsMaster = null;
            try
            {
                bool bIsAllowAccess = false;
                bool bIsAllowSignatory = false;
                if (rdAllowAccessYes.Checked)
                {
                    bIsAllowAccess = true;
                }
                else if(rdAllowAccessNo.Checked)
                {
                    bIsAllowAccess = false;
                }

                if (rdAllowSignatoryYes.Checked)
                {
                    bIsAllowSignatory = true;
                }
                else if (rdAllowSignatoryNo.Checked)
                {
                    bIsAllowSignatory = false;
                }
                clsMaster = new clsMasters();
                clsMaster.MasterType = this.MasterType;
                clsMaster.nMasterID = Convert.ToInt64(lblTypeID.Text);
                clsMaster.nMasterMainID = Convert.ToInt64(cmbAssetMainType.SelectedValue);
                clsMaster.sMasterName = txtMainTypeName.Text.Trim();
                clsMaster.sMasterCode = txtMasterCode.Text.Trim();
                clsMaster.IsAllowAccess = bIsAllowAccess;
                clsMaster.IsAllowSignatory = bIsAllowSignatory;
                Int64 nResult=clsMaster.InsertUpdateMaster();
                if(nResult==-1)
                {
                    MessageBox.Show("Error while saving " + lblFormHeader.Text + ".", sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nResult == 2)
                {
                    MessageBox.Show(lblFormHeader.Text + " is already exists.", sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(lblFormHeader.Text + " is saved successfully.", sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                if (clsMaster!=null)
                {
                    clsMaster = null;
                }
            }
        }

        private void ClearForm()
        {
            txtMainTypeName.Text = string.Empty;
            txtMasterCode.Text = string.Empty;
            cmbAssetMainType.SelectedValue = 0;
        }
    }
}
