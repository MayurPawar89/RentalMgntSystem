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
    public partial class frmMasterListCrewMember : DevExpress.XtraEditors.XtraForm
    {
        public frmMasterListCrewMember()
        {
            InitializeComponent();
        }
        private void FillCrewMasterList()
        {
            StaffMaster clsStaffMaster = null;
            DataTable dt = null;
            try
            {
                clsStaffMaster = new StaffMaster();
                dt = clsStaffMaster.GetStafflist(0);
                if (dt != null)
                {
                    gvCrewList.GridControl.DataSource = dt;
                    gvCrewList.Columns[1].Visible = false;
                    gvCrewList.Columns[8].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Company List: " + ex.ToString(), clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMasterListCrewMember_Load(object sender, EventArgs e)
        {
            FillCrewMasterList();
        }
        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = (DataView)gvCrewList.DataSource;
                //Company Code, Company Name, Country, State, City, Warehouse Supervisor, Company Type, Abbreviation
                string sSearchText = txtSearch.Text;
                string fileter = "";
                if (sSearchText != "")
                {
                    fileter = dv.Table.Columns["sStaffCode"].Caption + " Like '%" + sSearchText + "%' OR "
                        + dv.Table.Columns["sStaffName"].Caption + " Like '%" + sSearchText + "%' OR "
                        + dv.Table.Columns["sCompanyCode"].Caption + " Like '%" + sSearchText + "%' OR "
                        + dv.Table.Columns["sCity"].Caption + " Like '%" + sSearchText + "%'";
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

        private void gvCompanyList_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Delete")
                {
                    bool val = Convert.ToBoolean(gvCrewList.GetRowCellValue(e.RowHandle, "IsUsed"));
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

        private void gvCompanyList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Edit")
                {
                    Int64 nCompanyID = 0;
                    var row = gvCrewList.GetFocusedDataRow();

                    nCompanyID = Convert.ToInt64(row[1]);
                    frmMasterAddCrew frmMaster = new frmMasterAddCrew(nCompanyID);
                    frmMaster.ShowDialog();
                    FillCrewMasterList();
                }
                if (e.Column.Caption == "Delete")
                {
                    var row = gvCrewList.GetFocusedDataRow();
                    int n = Convert.ToString(gvAssetList.GetRowCellValue(e.RowHandle, "IsUsed")) == "" || Convert.ToString(gvAssetList.GetRowCellValue(e.RowHandle, "IsUsed")) == "0" ? 0 : 1;

                    if (n == 1)
                    {
                        return;
                    }
                    if (MessageBox.Show("Do you want to delete?", clsGlobal._sMessageboxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    clsGeneral oclsGeneral = new clsGeneral();
                    if (oclsGeneral.GetDeleteMasterType(MainMasterType.Crew.GetHashCode(), Convert.ToInt64(row[1])) > 0)
                    {
                        MessageBox.Show("Crew member details deleted successfully.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (oclsGeneral != null)
                    {
                        oclsGeneral.Dispose();
                        oclsGeneral = null;
                    }
                    //clsMasters oclsMaster = new clsMasters();
                    //oclsMaster.nMasterID = Convert.ToInt64(row[1]);
                    //oclsMaster.MasterType = this.MasterType;
                    //oclsMaster.DeleteMaster();
                    FillCrewMasterList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
