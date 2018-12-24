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
    public partial class frmMainAssetList : DevExpress.XtraEditors.XtraForm
    {
        public frmMainAssetList()
        {
            InitializeComponent();
        }

        private void frmMainAssetList_Load(object sender, EventArgs e)
        {
            FillAssetList();
        }

        private void FillAssetList()
        {
            AssetMaster oAssetMaster = null;
            DataTable dt = null;
            try
            {
                oAssetMaster = new AssetMaster();
                dt = oAssetMaster.GetAssetList(0);
                if (dt!=null)
                {
                    gvAssetList.GridControl.DataSource = dt;
                    gvAssetList.Columns[1].Visible = false;
                    gvAssetList.Columns[8].Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = (DataView)gvAssetList.DataSource;
                //Company Code, Company Name, Country, State, City, Warehouse Supervisor, Company Type, Abbreviation
                string sSearchText = txtSearch.Text;
                string fileter = "";
                if (sSearchText != "")
                {
                    fileter = dv.Table.Columns["sAssetName"].Caption + " Like '%" + sSearchText + "%' OR "
                        + dv.Table.Columns["sAssetAbbrivation"].Caption + " Like '%" + sSearchText + "%'";
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
                    Int64 nAssetID = 0;
                    var row = gvAssetList.GetFocusedDataRow();

                    nAssetID = Convert.ToInt64(row[1]);
                    frmAddAsset frmAsset = new frmAddAsset(nAssetID);
                    frmAsset.ShowDialog();
                    FillAssetList();
                }
                if (e.Column.Caption == "Delete")
                {
                    var row = gvAssetList.GetFocusedDataRow();
                    int n = Convert.ToString(gvAssetList.GetRowCellValue(e.RowHandle, "IsUsed")) == "" || Convert.ToString(gvAssetList.GetRowCellValue(e.RowHandle, "IsUsed")) == "0" ? 0 : 1;

                    if (n == 1)
                    {
                        return;
                    }
                    if (MessageBox.Show("Do you want to delete?", clsGlobal._sMessageboxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    //clsMasters oclsMaster = new clsMasters();
                    //oclsMaster.nMasterID = Convert.ToInt64(row[1]);
                    //oclsMaster.MasterType = this.MasterType;
                    //oclsMaster.DeleteMaster();
                    FillAssetList();
                }
                if (e.Column.Caption == "Show Asset")
                {
                    Int64 nAssetID = 0;
                    var row = gvAssetList.GetFocusedDataRow();

                    nAssetID = Convert.ToInt64(row[1]);
                    frmMainAssetCodeList oFrmAssetCodeList = new frmMainAssetCodeList(nAssetID);
                    oFrmAssetCodeList.ShowDialog();
                    FillAssetList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex, clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
