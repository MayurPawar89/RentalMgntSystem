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
    public partial class frmMainKitAssetList : DevExpress.XtraEditors.XtraForm
    {
        public frmMainKitAssetList(Int64 KitID)
        {
            InitializeComponent();
            nKitID = KitID;
        }
        public Int64 nKitID { get; set; }
        private void frmMainKitAssetList_Load(object sender, EventArgs e)
        {
            FillAssetKitDetails(nKitID);
        }

        private void FillAssetKitDetails(long nKitID)
        {
            KitMaster oKitMaster = null;
            DataTable dtAssetCode = null;
            try
            {
                oKitMaster = new KitMaster();
                dtAssetCode = oKitMaster.GetKitAssetList(nKitID);
                if (dtAssetCode != null)
                {
                    gvKitAssetList.GridControl.DataSource = dtAssetCode;
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
                DataView dv = (DataView)gvKitAssetList.DataSource;
                //Company Code, Company Name, Country, State, City, Warehouse Supervisor, Company Type, Abbreviation
                string sSearchText = txtSearch.Text;
                string fileter = "";
                if (sSearchText != "")
                {
                    fileter = dv.Table.Columns["sUniqueCode"].Caption + " Like '%" + sSearchText + "%'";
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
    }
}
