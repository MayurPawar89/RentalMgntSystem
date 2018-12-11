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
            catch (Exception)
            {

                throw;
            }
        }

        private void gvCompanyList_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Delete")
                {
                    bool val = Convert.ToBoolean(gvCompanyList.GetRowCellValue(e.RowHandle, "IsUsed"));
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
                    int n = Convert.ToInt32(row[7]);
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
                    FillCompanyMasterList();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
