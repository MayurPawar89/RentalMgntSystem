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
    public partial class frmAsset : Form
    {
        public frmAsset()
        {
            InitializeComponent();
        }

        private void tsb_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save asset?", clsGlobal.MessageboxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.No)
            {
                return;
            }
            else
            {
                SaveAsset();
            }
        }

        private void tsb_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save asset?", clsGlobal.MessageboxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                SaveAsset();
            }
        }

        private Int64 SaveAsset()
        {
            AssetMaster oAssetMaster = null;
            Int64 nAssetID = 0;
            try
            {
                oAssetMaster = new AssetMaster();
                oAssetMaster.nAssetID = 0;
                oAssetMaster.sAssetName = txtAssetName.Text.Trim();
                oAssetMaster.sAssetDescription = txtAssetDescription.Text.Trim();
                oAssetMaster.sAssetShortDescription = txtAssetShortDescription.Text.Trim();
                oAssetMaster.nCompanyID = Convert.ToInt64(cmbCompanyList.SelectedValue);
                //oAssetMaster.nBarcodeID = Convert.ToInt64(txtAssetBarcode.Text.Trim());
                oAssetMaster.nAssetMainTypeID = Convert.ToInt64(cmbAssetTypeName.SelectedValue);
                oAssetMaster.sAssetSize = txtAssetSize.Text.Trim();
                oAssetMaster.sAssetCapacity = txtAssetCapacity.Text.Trim();
                oAssetMaster.sAssetDensity = txtAssetDensity.Text.Trim();
                oAssetMaster.sAssetQuality = txtAssetQuality.Text.Trim();
                oAssetMaster.nAssetMaterialID = Convert.ToInt64(cmbAssetmaterialType.SelectedValue);
                oAssetMaster.sAssetMake = txtAssetMake.Text.Trim();
                oAssetMaster.nAssetTypeID = Convert.ToInt64(cmbAssetType.SelectedValue);
                oAssetMaster.nAssetTypeOneID = Convert.ToInt64(cmbAssetType1.SelectedValue);
                oAssetMaster.sAssetWeight = txtAssetWeight.Text.Trim();
                oAssetMaster.sAssetPackingDimention = txtAssetPackingDimention.Text.Trim();
                oAssetMaster.sAssetShelfLife = txtAssetShelfLife.Text.Trim();
                oAssetMaster.sAssetShelfLifeUnit = cmbAssetShelfLifeUnit.Text.Trim();
                oAssetMaster.sAssetHSN_SACCode = txtAssetHSNOrSACCode.Text.Trim();
                oAssetMaster.sAssetVendor = txtAssetVendor.Text.Trim();
                oAssetMaster.sAssetReorderTime = txtAssetReorderTime.Text.Trim();
                oAssetMaster.dtAssetDateOFIntroduction =Convert.ToDateTime(dtpIntroductionDate.Text.ToString());
                oAssetMaster.dtAssetDateOfRetirement = Convert.ToDateTime(dtpRetirementDate.Text.ToString());
                oAssetMaster.sAssetRate = txtAssetRate.Text.Trim();
                oAssetMaster.sAssetRentalRate = txtAssetRentalRate.Text.Trim();
                oAssetMaster.sAssetAbbrivation = GenerateAbbrivation(txtAssetName.Text.Trim());
                oAssetMaster.sAssetCode = GenerateCode();

                nAssetID= oAssetMaster.InsertUpdateAsset();
            }
            catch (Exception ex)
            {
                
                throw;
            }
            return nAssetID;
        }

        private string GenerateAbbrivation(string sAssetName)
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
        
        private string GenerateCode()
        {
            //For Fixtures,Equipment’s, & Lights:  Make (Char 3) Voltage(Char 4) Fixture Type (Char 3) Type (Char 3) Sr.No (Number 3)
            //Cloth Size (Char 5) Density (Char 4) Type (Char 4) Sr. No.(Number 3)
            //Accessories Type(NumChar 5) Sr.no.(Number 3)
            string sAssetCode = string.Empty;
            switch (cmbAssetTypeName.Text.Trim().ToString())
            {
                case "Cloth":
                    {
                        string sSize = txtAssetSize.Text.Substring(0, 3);
                        string sDensity = txtAssetDensity.Text.Substring(0, 4);
                        string sType = cmbAssetType.Text.Substring(0, 3);
                        string sNumber = "";
                        sAssetCode = sSize + sDensity + sType + sNumber; 
                        break;
                    }
                case "Accessories":
                    {
                        string sType = cmbAssetType.Text.Substring(0, 3);
                        string sNumber = "";
                        sAssetCode = sType + sNumber; 
                        break;
                    }
                case "Light":
                case "Stands":
                case "Grip":
                    {
                        string sMake = txtAssetMake.Text.Substring(0, 3);
                        string sVoltage = txtAssetCapacity.Text.Substring(0, 4);
                        string sFixtureType = "";
                        string sType = cmbAssetType.Text.Substring(0, 3);
                        string sNumber = "";
                        sAssetCode = sMake + sVoltage + sFixtureType + sType + sNumber;
                        break;
                    }
            }
            return sAssetCode;
        }

        private void frmAsset_Load(object sender, EventArgs e)
        {
            //get CompanyList
            LoadMasterData();
        }
        private void LoadMasterData()
        {
            AssetMaster oAssetMaster = null;
            DataSet dsMaster = null;
            try
            {
                 oAssetMaster = new AssetMaster();
                 dsMaster = oAssetMaster.GetAllMasterData(0);
                
                if (dsMaster != null && dsMaster.Tables.Count > 0)
                {
                    cmbAssetTypeName.DataSource = dsMaster.Tables[0];
                    cmbAssetTypeName.DisplayMember = "sAssetType";
                    cmbAssetTypeName.ValueMember = "nAssetMainTypeID";

                    cmbAssetmaterialType.DataSource = dsMaster.Tables[1];
                    cmbAssetmaterialType.DisplayMember = "sAssetMaterialName";
                    cmbAssetmaterialType.ValueMember = "nAssetMaterialID";

                    cmbAssetType.DataSource = dsMaster.Tables[2];
                    cmbAssetType.DisplayMember = "sAssetTypeName";
                    cmbAssetType.ValueMember = "nAssetTypeID";

                    cmbAssetType1.DataSource = dsMaster.Tables[3];
                    cmbAssetType1.DisplayMember = "sAssetTypeOneName";
                    cmbAssetType1.ValueMember = "nAssetTypeOneID";

                    cmbAssetShelfLifeUnit.DataSource = dsMaster.Tables[4];
                    cmbAssetShelfLifeUnit.DisplayMember = "sAssetShelfLifeUnit";
                    cmbAssetShelfLifeUnit.ValueMember = "nAssetShelfLifeUnit";
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                if (oAssetMaster != null)
                {
                    oAssetMaster.Dispose();
                    oAssetMaster = null;
                }
            }
        }
    }
}
