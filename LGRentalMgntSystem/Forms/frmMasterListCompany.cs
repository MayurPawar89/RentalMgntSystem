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
    public partial class frmMasterListCompany : DevExpress.XtraEditors.XtraForm
    {
        public frmMasterListCompany()
        {
            InitializeComponent();
        }

        private void FillCompanyMasterList()
        {
            CompanyMaster clsCompanyMaster = null;
            DataTable dt = null;
            try
            {
                clsCompanyMaster = new CompanyMaster();
                dt = clsCompanyMaster.GetCompanylist(0);
                if (dt != null)
                {
                    gvCompanyList.GridControl.DataSource = dt;
                    gvCompanyList.Columns[1].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Company List: " + ex.ToString(), clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMasterListCompany_Load(object sender, EventArgs e)
        {
            FillCompanyMasterList();
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = (DataView)gvCompanyList.DataSource;
                //Company Code, Company Name, Country, State, City, Warehouse Supervisor, Company Type, Abbreviation
                string sSearchText = txtSearch.Text;
                string fileter = "";
                if (sSearchText != "")
                {
                    fileter = dv.Table.Columns["sCompanyCode"].Caption + " Like '%" + sSearchText + "%' OR "
                        + dv.Table.Columns["sCompanyName"].Caption + " Like '%" + sSearchText + "%' OR "
                        + dv.Table.Columns["sCountry"].Caption + " Like '%" + sSearchText + "%' OR "
                        + dv.Table.Columns["sState"].Caption + " Like '%" + sSearchText + "%' OR "
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
                    int nVal = Convert.ToString(gvCompanyList.GetRowCellValue(e.RowHandle, "IsUsed")) == "" || Convert.ToString(gvCompanyList.GetRowCellValue(e.RowHandle, "IsUsed")) == "0" ? 0 : 1;

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

        private void gvCompanyList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Edit")
                {
                    Int64 nCompanyID = 0;
                    var row = gvCompanyList.GetFocusedDataRow();

                    nCompanyID = Convert.ToInt64(row[1]);
                    frmMasterAddCompany frmMaster = new frmMasterAddCompany(nCompanyID);
                    frmMaster.ShowDialog();
                    FillCompanyMasterList();
                }
                if (e.Column.Caption == "Delete")
                {
                    var row = gvCompanyList.GetFocusedDataRow();
                    int n = Convert.ToString(gvCompanyList.GetRowCellValue(e.RowHandle, "IsUsed")) == "" || Convert.ToString(gvCompanyList.GetRowCellValue(e.RowHandle, "IsUsed")) == "0" ? 0 : 1;
                    
                    if (n == 1)
                    {
                        return;
                    }
                    if (MessageBox.Show("Do you want to delete?", clsGlobal._sMessageboxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    clsGeneral oclsGeneral = new clsGeneral();
                    if (oclsGeneral.GetDeleteMasterType(MainMasterType.Company.GetHashCode(), Convert.ToInt64(row[1]))>0)
                    {
                        MessageBox.Show("Company details deleted successfully.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    FillCompanyMasterList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
