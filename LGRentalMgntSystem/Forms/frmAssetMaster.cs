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
                            lblFormHeader.Text = "Company Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            break;
                        }
                    case MasterType.MaterialType:
                        {
                            lblFormHeader.Text = "Material Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            break;
                        }
                    case MasterType.Designation:
                        {
                            lblFormHeader.Text = "Designation";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            break;
                        }
                    case MasterType.AssetType:
                        {
                            lblFormHeader.Text = "Asset Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            FillAssetMaintype(); 
                            pnlAssetMainType.Visible = true; 
                            
                            break;
                        }
                    case MasterType.AssetType1:
                        {
                            lblFormHeader.Text = "Asset Type1";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            FillAssetMaintype();
                            pnlAssetMainType.Visible = true;
                            break;
                        }
                    case MasterType.PartyType:
                        {
                            lblFormHeader.Text = "Party Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            break;
                        }
                    case MasterType.VehicleType:
                        {
                            lblFormHeader.Text = "Vehicle Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            break;
                        }
                    case MasterType.ColourType:
                        {
                            lblFormHeader.Text = "Colour Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            break;
                        }
                    case MasterType.DensityType:
                        {
                            lblFormHeader.Text = "Density Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
                            cmbAssetMainType.SelectedValue = nMainTypeID;
                            break;
                        }
                    case MasterType.AssetMainType:
                        {
                            lblFormHeader.Text = "Asset Main Type";
                            lblTypeID.Text = Convert.ToString(nTypeID);
                            txtMainTypeName.Text = sTypeName;
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
                clsMaster = new clsMasters();
                clsMaster.MasterType = this.MasterType;
                clsMaster.nMasterID = Convert.ToInt64(lblTypeID.Text);
                clsMaster.nMasterMainID = Convert.ToInt64(cmbAssetMainType.SelectedValue);
                clsMaster.sMasterName = txtMainTypeName.Text.Trim();
                if(clsMaster.InsertUpdateMaster()==-1)
                {
                    MessageBox.Show("Error while saving " + lblFormHeader.Text + ".", sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    MessageBox.Show(lblFormHeader.Text + " is saved successfully.", sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
