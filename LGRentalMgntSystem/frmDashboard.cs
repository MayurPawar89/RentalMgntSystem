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
    public enum MasterType
        {
            CompanyType = 0,
            MaterialType = 1,
            Designation = 2,
            AssetType = 3,
            AssetType1 = 4,
            PartyType = 5,
            VehicleType = 6,
            ColourType = 7,
            DensityType = 8,
            AssetMainType=9

        }
    public partial class frmDashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        

        private void ShowAsset()
        {
            frmAsset frmAsset = new frmAsset();
            frmAsset.ShowDialog();
        }

        private void btnAddAsset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowAsset();
        }

        private void btnAddCompanyType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMasterForm(MasterType.CompanyType);
        }

        private void btnCompanyTypeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMaster(MasterType.CompanyType);
        }

        private void btnAddMaterialType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMasterForm(MasterType.MaterialType);
        }

        private void btnMaterialTypeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMaster(MasterType.MaterialType);
        }

        private void btnAddDesigantion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMasterForm(MasterType.Designation);
        }

        private void btnDesignationList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMaster(MasterType.Designation);
        }

        private void btnAssetType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMasterForm(MasterType.AssetType);
        }

        private void btnAssetTypeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMaster(MasterType.AssetType);
        }

        private void btnAddAssetType1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMasterForm(MasterType.AssetType1);
        }

        private void btnAssetType1List_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMaster(MasterType.AssetType1);
        }

        private void btnPartyList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMaster(MasterType.PartyType);
        }

        private void btnAddPartyType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMasterForm(MasterType.PartyType);
        }

        private void btnAddVehicleType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMasterForm(MasterType.VehicleType);
        }

        private void btnVehicleList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMaster(MasterType.VehicleType);
        }

        private void btnAddColourType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMasterForm(MasterType.ColourType);
        }

        private void btnColourList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMaster(MasterType.ColourType);
        }

        private void btnAddDensityType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMasterForm(MasterType.DensityType);
        }

        public bool showMasterForm(MasterType MasterType)
        {
            bool _result = false;
            try
            {
                frmAssetMaster frmAssetMaster = null;
                switch (MasterType)
                {
                    case MasterType.CompanyType:
                        {
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            frmAssetMaster = new frmAssetMaster();
                            frmAssetMaster.MasterType = MasterType.CompanyType;
                            frmAssetMaster.ShowDialog();
                            _result= frmAssetMaster.IsMasterSave;
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            break;
                        }
                    case MasterType.MaterialType:
                        {
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            frmAssetMaster = new frmAssetMaster();
                            frmAssetMaster.MasterType = MasterType.MaterialType;
                            frmAssetMaster.ShowDialog();
                            _result = frmAssetMaster.IsMasterSave;
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            break;
                        }
                    case MasterType.Designation:
                        {
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            frmAssetMaster = new frmAssetMaster();
                            frmAssetMaster.MasterType = MasterType.Designation;
                            frmAssetMaster.ShowDialog();
                            _result = frmAssetMaster.IsMasterSave;
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            break;
                        }
                    case MasterType.AssetType:
                        {
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            frmAssetMaster = new frmAssetMaster();
                            frmAssetMaster.MasterType = MasterType.AssetType;
                            frmAssetMaster.ShowDialog();
                            _result = frmAssetMaster.IsMasterSave;
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            break;
                        }
                    case MasterType.AssetType1:
                        {
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            frmAssetMaster = new frmAssetMaster();
                            frmAssetMaster.MasterType = MasterType.AssetType1;
                            frmAssetMaster.ShowDialog();
                            _result = frmAssetMaster.IsMasterSave;
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            break;
                        }
                    case MasterType.PartyType:
                        {
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            frmAssetMaster = new frmAssetMaster();
                            frmAssetMaster.MasterType = MasterType.PartyType;
                            frmAssetMaster.ShowDialog();
                            _result = frmAssetMaster.IsMasterSave;
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            break;
                        }
                    case MasterType.VehicleType:
                        {
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            frmAssetMaster = new frmAssetMaster();
                            frmAssetMaster.MasterType = MasterType.VehicleType;
                            frmAssetMaster.ShowDialog();
                            _result = frmAssetMaster.IsMasterSave;
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            break;
                        }
                    case MasterType.ColourType:
                        {
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            frmAssetMaster = new frmAssetMaster();
                            frmAssetMaster.MasterType = MasterType.ColourType;
                            frmAssetMaster.ShowDialog();
                            _result = frmAssetMaster.IsMasterSave;
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            break;
                        }
                    case MasterType.DensityType:
                        {
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            frmAssetMaster = new frmAssetMaster();
                            frmAssetMaster.MasterType = MasterType.DensityType;
                            frmAssetMaster.ShowDialog();
                            _result = frmAssetMaster.IsMasterSave;
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            break;
                        }
                    case MasterType.AssetMainType:
                        {
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            frmAssetMaster = new frmAssetMaster();
                            frmAssetMaster.MasterType = MasterType.AssetMainType;
                            frmAssetMaster.ShowDialog();
                            _result = frmAssetMaster.IsMasterSave;
                            if (frmAssetMaster != null)
                            {
                                frmAssetMaster.Dispose();
                                frmAssetMaster = null;
                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }

            return _result;

        }

        public bool showMaster(MasterType MasterType)
        {
            bool _result = false;
            try
            {
                LGRentalMgntSystem.Forms.frmAssetList frmAssetMasterList = null;
                switch (MasterType)
                {
                    case MasterType.CompanyType:
                        {
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            frmAssetMasterList = new LGRentalMgntSystem.Forms.frmAssetList();
                            frmAssetMasterList.MasterType = MasterType.CompanyType;
                            frmAssetMasterList.ShowDialog();
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            break;
                        }
                    case MasterType.MaterialType:
                        {
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            frmAssetMasterList = new LGRentalMgntSystem.Forms.frmAssetList();
                            frmAssetMasterList.MasterType = MasterType.MaterialType;
                            frmAssetMasterList.ShowDialog();
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            break;
                        }
                    case MasterType.Designation:
                        {
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            frmAssetMasterList = new LGRentalMgntSystem.Forms.frmAssetList();
                            frmAssetMasterList.MasterType = MasterType.Designation;
                            frmAssetMasterList.ShowDialog();
                            
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            break;
                        }
                    case MasterType.AssetType:
                        {
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            frmAssetMasterList = new LGRentalMgntSystem.Forms.frmAssetList();
                            frmAssetMasterList.MasterType = MasterType.AssetType;
                            frmAssetMasterList.ShowDialog();
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            break;
                        }
                    case MasterType.AssetType1:
                        {
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            frmAssetMasterList = new LGRentalMgntSystem.Forms.frmAssetList();
                            frmAssetMasterList.MasterType = MasterType.AssetType1;
                            frmAssetMasterList.ShowDialog();
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            break;
                        }
                    case MasterType.PartyType:
                        {
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            frmAssetMasterList = new LGRentalMgntSystem.Forms.frmAssetList();
                            frmAssetMasterList.MasterType = MasterType.PartyType;
                            frmAssetMasterList.ShowDialog();
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            break;
                        }
                    case MasterType.VehicleType:
                        {
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            frmAssetMasterList = new LGRentalMgntSystem.Forms.frmAssetList();
                            frmAssetMasterList.MasterType = MasterType.VehicleType;
                            frmAssetMasterList.ShowDialog();
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            break;
                        }
                    case MasterType.ColourType:
                        {
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            frmAssetMasterList = new LGRentalMgntSystem.Forms.frmAssetList();
                            frmAssetMasterList.MasterType = MasterType.ColourType;
                            frmAssetMasterList.ShowDialog();
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            break;
                        }
                    case MasterType.DensityType:
                        {
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            frmAssetMasterList = new LGRentalMgntSystem.Forms.frmAssetList();
                            frmAssetMasterList.MasterType = MasterType.DensityType;
                            frmAssetMasterList.ShowDialog();
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            break;
                        }
                    case MasterType.AssetMainType:
                        {
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            frmAssetMasterList = new LGRentalMgntSystem.Forms.frmAssetList();
                            frmAssetMasterList.MasterType = MasterType.AssetMainType;
                            frmAssetMasterList.ShowDialog();
                            if (frmAssetMasterList != null)
                            {
                                frmAssetMasterList.Dispose();
                                frmAssetMasterList = null;
                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return _result;

        }

        private void btnDensityTypeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMaster(MasterType.DensityType);
        }

        private void btnAddAssetMainType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMasterForm(MasterType.AssetMainType);
        }

        private void btnAssetMainTypeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMaster(MasterType.AssetMainType);
        }
    }
}
