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
    public partial class frmMasterListGaffer : DevExpress.XtraEditors.XtraForm
    {
        public frmMasterListGaffer()
        {
            InitializeComponent();
        }

        private void gvGafferList_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Delete")
                {
                    int nVal = Convert.ToString(gvGafferList.GetRowCellValue(e.RowHandle, "IsUsed")) == "" || Convert.ToString(gvGafferList.GetRowCellValue(e.RowHandle, "IsUsed")) == "0" ? 0 : 1;

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

            }
        }

        private void gvGafferList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Edit")
                {
                    Int64 nPartyID = 0;
                    var row = gvGafferList.GetFocusedDataRow();

                    nPartyID = Convert.ToInt64(row[1]);
                    frmMasterAddGaffer frmGaffer = new frmMasterAddGaffer(nPartyID);
                    frmGaffer.ShowDialog();
                    FillGafferMasterList();
                }
                if (e.Column.Caption == "Delete")
                {
                    var row = gvGafferList.GetFocusedDataRow();
                    int n = Convert.ToString(gvGafferList.GetRowCellValue(e.RowHandle, "IsUsed")) == "" || Convert.ToString(gvGafferList.GetRowCellValue(e.RowHandle, "IsUsed")) == "0" ? 0 : 1;
                    
                    if (n == 1)
                    {
                        return;
                    }
                    if (MessageBox.Show("Do you want to delete?", clsGlobal._sMessageboxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    clsGeneral oclsGeneral = new clsGeneral();
                    if (oclsGeneral.GetDeleteMasterType(MainMasterType.Gaffer.GetHashCode(), Convert.ToInt64(row[1])) > 0)
                    {
                        MessageBox.Show("Gaffer details deleted successfully.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    FillGafferMasterList();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void FillGafferMasterList()
        {
            GafferMaster clsGafferMaster = null;
            DataTable dt = null;
            try
            {
                clsGafferMaster = new GafferMaster();
                dt = clsGafferMaster.GetGafferlist(0);

                if (dt!=null)
                {
                    gvGafferList.GridControl.DataSource = dt;
                    gvGafferList.Columns[1].Visible = false;
                    gvGafferList.Columns[8].Visible = false;

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void frmMasterListGaffer_Load(object sender, EventArgs e)
        {
            FillGafferMasterList();
        }
    }
}
