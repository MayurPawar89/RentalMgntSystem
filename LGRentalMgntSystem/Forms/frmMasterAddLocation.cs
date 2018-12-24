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
    public partial class frmMasterAddLocation : DevExpress.XtraEditors.XtraForm
    {
        public frmMasterAddLocation()
        {
            InitializeComponent();
            FillMasterData();
            GetAndSetSequence();
        }

        private void FillMasterData()
        {
            clsGeneral oclsGeneral = null;
            try
            {
                oclsGeneral = new clsGeneral();
                DataSet dsGaffer = oclsGeneral.GetGafferMaster();
                if (dsGaffer != null && dsGaffer.Tables.Count > 0)
                {
                    DataTable dtStateMaster = dsGaffer.Tables[0];
                    DataTable dtCityMaster = dsGaffer.Tables[1];
                    DataTable dtCountryMaster = dsGaffer.Tables[2];

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
                txtCode.Text = "LOC/" + Convert.ToString(oclsGeneral.GetSequenceNumber(MainMasterType.Location.GetHashCode()));
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
        public frmMasterAddLocation(Int64 nLocationID)
        {
            InitializeComponent();
            lblLocationID.Text = Convert.ToString(nLocationID);
            FillMasterData();
            GetAndSetSequence();
        }

        private void frmMasterAddLocation_Load(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt64(lblLocationID.Text) > 0)
                {
                    FillLocatioDetails(Convert.ToInt64(lblLocationID.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void FillLocatioDetails(long nLocationID)
        {
            LocationMaster oLocationMaster = null;
            DataTable dtLocationDetails = null;
            try
            {
                oLocationMaster = new LocationMaster();
                dtLocationDetails = oLocationMaster.GetLocationInformation(nLocationID);

                if (dtLocationDetails != null && dtLocationDetails.Rows.Count > 0)
                {
                    lblLocationID.Text = Convert.ToString(dtLocationDetails.Rows[0]["nLocationID"]);
                    txtCode.Text = Convert.ToString(dtLocationDetails.Rows[0]["sLocationCode"]);
                    txtDescription.Text = Convert.ToString(dtLocationDetails.Rows[0]["sDescription"]);
                    txtAddressLine1.Text = Convert.ToString(dtLocationDetails.Rows[0]["sAddressLine1"]);
                    txtAddressLine2.Text = Convert.ToString(dtLocationDetails.Rows[0]["sAddressLine2"]);
                    cmbCityMaster.Text = Convert.ToString(dtLocationDetails.Rows[0]["sCity"]);
                    cmbStateMaster.Text = Convert.ToString(dtLocationDetails.Rows[0]["sState"]);
                    cmbCountryMaster.Text = Convert.ToString(dtLocationDetails.Rows[0]["sCountry"]);
                    txtPincode.Text = Convert.ToString(dtLocationDetails.Rows[0]["sPincode"]);
                    txtVilageDistTown.Text = Convert.ToString(dtLocationDetails.Rows[0]["sVlgDstTwn"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveLocationMaster();
            }
        }

        private void SaveLocationMaster()
        {
            LocationMaster oclsLocationMaster = null;
            try
            {

                oclsLocationMaster = new LocationMaster();
                oclsLocationMaster.nLocationID = Convert.ToInt64(lblLocationID.Text);
                oclsLocationMaster.sLocationCode = Convert.ToString(txtCode.Text.Trim());
                oclsLocationMaster.sDescription = Convert.ToString(txtDescription.Text.Trim());
                oclsLocationMaster.sAddressLine1 = Convert.ToString(txtAddressLine1.Text.Trim());
                oclsLocationMaster.sAddressLine2 = Convert.ToString(txtAddressLine2.Text.Trim());
                oclsLocationMaster.sCity = Convert.ToString(cmbCityMaster.Text.Trim());
                oclsLocationMaster.sState = Convert.ToString(cmbStateMaster.Text.Trim());
                oclsLocationMaster.sCountry = Convert.ToString(cmbCountryMaster.Text.Trim());
                oclsLocationMaster.sPincode = Convert.ToString(txtPincode.Text.Trim());
                oclsLocationMaster.sVillageDistTown= Convert.ToString(txtVilageDistTown.Text.Trim());

                Int64 nLocationID = oclsLocationMaster.InsertUpdateLocationMaster();

                if (nLocationID != 0)
                {
                    MessageBox.Show("Gaffer is saved successfully.", clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public bool ValidateForm()
        {
            bool bIsValidForm = true;
            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("Please enter description.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bIsValidForm = false;
                txtDescription.Focus();
                return bIsValidForm;
            }

            return bIsValidForm;
        }
    }
}
