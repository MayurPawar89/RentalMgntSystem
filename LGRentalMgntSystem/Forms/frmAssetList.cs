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

namespace LGRentalMgntSystem.Forms
{
    public partial class frmAssetList : DevExpress.XtraEditors.XtraForm
    {
        public frmAssetList()
        {
            InitializeComponent();
        }
        public MasterType MasterType { get; set; }
        private void frmAssetList_Load(object sender, EventArgs e)
        {
            FillAssetList();

        }

        private void FillAssetList()
        {
            clsMasters oClsMaster = null;
            DataTable dt = null;
            try
            {
                oClsMaster = new clsMasters();
                dt = oClsMaster.GetMasterTypeData(this.MasterType.GetHashCode());
                if (dt != null)
                {
                    gvMasterList.GridControl.DataSource = dt;
                    gvMasterList.Columns["TypeID"].Visible = false;
                    gvMasterList.Columns["nAssetMainTypeID"].Visible = false;
                    gvMasterList.Columns["IsUsed"].Visible = false;
                    
                    switch (MasterType)
                    {
                        case MasterType.AssetType:
                        case MasterType.AssetType1:
                            gvMasterList.Columns["AssetType"].Visible = true;
                            gvMasterList.Columns["AllowAccess"].Visible = false;
                            gvMasterList.Columns["AllowSignatory"].Visible = false;
                            break;
                        case MasterType.Designation:
                            gvMasterList.Columns["AssetType"].Visible = false;
                            gvMasterList.Columns["AllowAccess"].Visible = true;
                            gvMasterList.Columns["AllowSignatory"].Visible = true;
                            break;
                        default: gvMasterList.Columns["AssetType"].Visible = false;
                            gvMasterList.Columns["AllowAccess"].Visible = false;
                            gvMasterList.Columns["AllowSignatory"].Visible = false;
                            break;
                    }
                }
                switch (MasterType)
                {
                    case MasterType.CompanyType:
                        {
                            lblFormHeader.Text = "Company Type Details";
                            lblTypeName.Text = "Company Type : "; break;
                        }

                    case MasterType.MaterialType:
                        {
                            lblFormHeader.Text = "Material Type Details";
                            lblTypeName.Text = "Material Type : "; break;
                        }
                    case MasterType.Designation:
                        {
                            lblFormHeader.Text = "Designation Details";
                            lblTypeName.Text = "Designation : "; break;
                        }
                    case MasterType.AssetType:
                        {
                            lblFormHeader.Text = "Asset Type Details";
                            lblTypeName.Text = "Asset Type : "; break;
                        }
                    case MasterType.AssetType1:
                        {
                            lblFormHeader.Text = "Asset Type 1 Details";
                            lblTypeName.Text = "Asset Type 1 : "; break;
                        }
                    case MasterType.PartyType:
                        {
                            lblFormHeader.Text = "Party Type Details";
                            lblTypeName.Text = "Party Type : "; break;
                        }
                    case MasterType.VehicleType:
                        {
                            lblFormHeader.Text = "Vehicle Type Details";
                            lblTypeName.Text = "Vehicle Type : "; break;
                        }
                    case MasterType.ColourType:
                        {
                            lblFormHeader.Text = "Colour Type Details";
                            lblTypeName.Text = "Colour Type : "; break;
                        }
                    case MasterType.DensityType:
                        {
                            lblFormHeader.Text = "Density Type Details";
                            lblTypeName.Text = "Density Type : "; break;
                        }
                    case MasterType.AssetMainType:
                        {
                            lblFormHeader.Text = "Asset Main Type Details";
                            lblTypeName.Text = "Asset Main Type : "; break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gvMasterList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Edit")
                {
                    Int64 nTypeID = 0;
                    var row = gvMasterList.GetFocusedDataRow();
                    
                    nTypeID = Convert.ToInt64(row[1]);
                    frmAssetMaster frmMaster = new frmAssetMaster();
                    frmMaster.MasterType = this.MasterType;
                    frmMaster.nTypeID = Convert.ToInt64(row[1]);
                    frmMaster.sTypeName = Convert.ToString(row[3]);
                    frmMaster.bIsAllowAccess = Convert.ToBoolean(row[5]);
                    frmMaster.bIsAllowSignatory = Convert.ToBoolean(row[6]);
                    switch (MasterType)
                    {
                        case MasterType.AssetType:
                        case MasterType.AssetType1:
                            frmMaster.nMainTypeID = Convert.ToInt64(row[2]);
                            break;
                    }
                    frmMaster.ShowDialog();
                    FillAssetList();
                }
                if (e.Column.Caption == "Delete")
                {
                    var row = gvMasterList.GetFocusedDataRow();
                    int n = Convert.ToString(gvMasterList.GetRowCellValue(e.RowHandle, "IsUsed")) == "" || Convert.ToString(gvMasterList.GetRowCellValue(e.RowHandle, "IsUsed")) == "0" ? 0 : 1;

                    if (n == 1)
                    {
                        return;
                    }
                    if (MessageBox.Show("Do you want to delete?", clsGlobal._sMessageboxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    clsMasters oclsMaster = new clsMasters();
                    oclsMaster.nMasterID = Convert.ToInt64(row[1]);
                    oclsMaster.MasterType = this.MasterType;
                    oclsMaster.DeleteMaster();
                    FillAssetList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = (DataView)gvMasterList.DataSource;

                string sSearchText = txtSearch.Text;
                string fileter = "";
                if (sSearchText != "")
                {
                    fileter = dv.Table.Columns["TypeName"].Caption + " Like '%" + sSearchText + "%'";
                    dv.RowFilter = fileter;
                }
                else
                {
                    dv.RowFilter = fileter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gvMasterList_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {
                //if (e.Column.Caption == "Edit")
                //{
                //    bool val = Convert.ToBoolean(gvMasterList.GetRowCellValue(e.RowHandle, "IsUsed"));
                //    if (val)
                //    {
                //        DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ritem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
                //        ritem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                //        ritem.ReadOnly = false;
                //        ritem.Buttons[0].Enabled = false;
                //        ritem.Buttons[0].Visible = false;
                //        e.RepositoryItem = ritem;
                //    }
                //}
                if (e.Column.Caption == "Delete")
                {
                    int nVal = Convert.ToString(gvMasterList.GetRowCellValue(e.RowHandle, "IsUsed")) == "" || Convert.ToString(gvMasterList.GetRowCellValue(e.RowHandle, "IsUsed")) == "0" ? 0 : 1;

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
            //var row=gvMasterList.GetRowCellValue(e.RowHandle,gvMasterList.Columns[3]);
            //if (row == "Cloth")
            //{
            //    DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ri = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
                
            //}
        }

        
    }
}
