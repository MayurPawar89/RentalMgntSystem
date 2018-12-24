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
    public partial class frmMainAssetCodeList : DevExpress.XtraEditors.XtraForm
    {
        public Int64 nAssetID { get; set; }
        public frmMainAssetCodeList(Int64 AssetID)
        {
            InitializeComponent();
            nAssetID = AssetID;
        }

        private void frmMainAssetCodeList_Load(object sender, EventArgs e)
        {
            FillAssetCodeDetails();
        }

        private void FillAssetCodeDetails()
        {
            AssetMaster oAssetMaster = null;
            DataTable dtAssetCode = null;
            try
            {
                oAssetMaster = new AssetMaster();
                dtAssetCode = oAssetMaster.GetAssetCode(nAssetID);
                if (dtAssetCode!=null)
                {
                    gvAssetCodeList.GridControl.DataSource = dtAssetCode;
                    gvAssetCodeList.Columns[1].Visible = false;
                    gvAssetCodeList.Columns[2].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal._sMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }
    }
}
