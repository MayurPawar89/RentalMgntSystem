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
    public partial class frmMainKitList : DevExpress.XtraEditors.XtraForm
    {
        public frmMainKitList()
        {
            InitializeComponent();
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = (DataView)gvKitList.DataSource;
                //Company Code, Company Name, Country, State, City, Warehouse Supervisor, Company Type, Abbreviation
                string sSearchText = txtSearch.Text;
                string fileter = "";
                if (sSearchText != "")
                {
                    fileter = dv.Table.Columns["sKitName"].Caption + " Like '%" + sSearchText + "%' OR "
                        + dv.Table.Columns["sKitCode"].Caption + " Like '%" + sSearchText + "%' OR "
                        + dv.Table.Columns["sKitAbbrivation"].Caption + " Like '%" + sSearchText + "%'";
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

        private void frmMainKitList_Load(object sender, EventArgs e)
        {
            FillKitList();
        }

        private void FillKitList()
        {
            KitMaster oKitMaster = null;
            DataTable dt = null;
            try
            {
                oKitMaster = new KitMaster();
                dt = oKitMaster.GetKitList(0);
                if (dt != null)
                {
                    gvKitList.GridControl.DataSource = dt;
                    gvKitList.Columns[1].Visible = false;
                    gvKitList.Columns[8].Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gvKitList_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Delete")
                {
                    bool val = Convert.ToBoolean(gvKitList.GetRowCellValue(e.RowHandle, "IsUsed"));
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

        private void gvKitList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Edit")
                {
                    Int64 nKitID = 0;
                    var row = gvKitList.GetFocusedDataRow();

                    nKitID = Convert.ToInt64(row[1]);
                    frmAddKit frmKit = new frmAddKit(nKitID);
                    frmKit.ShowDialog();
                    FillKitList();
                }
                if (e.Column.Caption == "Delete")
                {
                    var row = gvKitList.GetFocusedDataRow();
                    int n = Convert.ToInt32(row["IsUsed"]);
                    if (n == 1)
                    {
                        return;
                    }
                    if (MessageBox.Show("Do you want to delete?", clsGlobal._sMessageboxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    KitMaster oKitMaster = new KitMaster();
                    oKitMaster.nKitID = Convert.ToInt64(row[1]);
                    oKitMaster.DeleteKit();
                    if (oKitMaster!=null)
                    {
                        oKitMaster.Dispose();
                        oKitMaster = null;
                    }
                    //clsMasters oclsMaster = new clsMasters();
                    //oclsMaster.nMasterID = Convert.ToInt64(row[1]);
                    //oclsMaster.MasterType = this.MasterType;
                    //oclsMaster.DeleteMaster();
                    FillKitList();
                }
                if (e.Column.Caption == "Show Asset")
                {
                    Int64 nKitID = 0;
                    var row = gvKitList.GetFocusedDataRow();

                    nKitID = Convert.ToInt64(row[1]);
                    frmMainKitAssetList oFrmAssetCodeList = new frmMainKitAssetList(nKitID);
                    oFrmAssetCodeList.ShowDialog();
                    FillKitList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex, clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
