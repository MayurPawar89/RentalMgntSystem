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
    public partial class frmMasterListLocation : DevExpress.XtraEditors.XtraForm
    {
        public frmMasterListLocation()
        {
            InitializeComponent();
        }

        private void gvLocationList_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Delete")
                {
                    bool val = Convert.ToBoolean(gvLocationList.GetRowCellValue(e.RowHandle, "IsUsed"));
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

        private void gvLocationList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Edit")
                {
                    Int64 nPartyID = 0;
                    var row = gvLocationList.GetFocusedDataRow();

                    nPartyID = Convert.ToInt64(row[1]);
                    frmMasterAddLocation frmLocation = new frmMasterAddLocation(nPartyID);
                    frmLocation.ShowDialog();
                    FillLocationMasterList();
                }
                if (e.Column.Caption == "Delete")
                {
                    var row = gvLocationList.GetFocusedDataRow();
                    int n = Convert.ToInt32(row["IsUsed"]);
                    if (n == 1)
                    {
                        return;
                    }
                    if (MessageBox.Show("Do you want to delete?", clsGlobal._sMessageboxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    clsGeneral oclsGeneral = new clsGeneral();
                    if (oclsGeneral.GetDeleteMasterType(MainMasterType.Location.GetHashCode(), Convert.ToInt64(row[1])) > 0)
                    {
                        MessageBox.Show("Location details deleted successfully.", clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    FillLocationMasterList();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void frmMasterListLocation_Load(object sender, EventArgs e)
        {
            FillLocationMasterList();
        }

        private void FillLocationMasterList()
        {
            LocationMaster clsLocationMaster = null;
            DataTable dt = null;
            try
            {
                clsLocationMaster = new LocationMaster();
                dt = clsLocationMaster.GetLocationlist(0);

                if (dt != null)
                {
                    gvLocationList.GridControl.DataSource = dt;
                    gvLocationList.Columns[1].Visible = false;
                    gvLocationList.Columns[8].Visible = false;

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
