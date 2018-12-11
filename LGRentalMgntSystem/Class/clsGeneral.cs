using LGRentalMgntSystem.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGRentalMgntSystem
{
    class clsGeneral
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public clsGeneral()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {

                }
            }
            disposed = true;
        }

        ~clsGeneral()
        {
            Dispose(false);
        }
        #endregion

        #region "Methods"
        public Int64 GetSequenceNumber(int nMasterType)
        {
            Int64 nSequencNo = 0;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataTable _dt=null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nMasterType", nMasterType, ParameterDirection.Input, SqlDbType.Int);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_SequenceNo", oDBParameter,out _dt);
                oDBAccess.CloseConnection(false);
                if (_dt!=null&&_dt.Rows.Count>0)
                {
                    nSequencNo = Convert.ToInt64(_dt.Rows[0][0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (oDBAccess != null)
                {
                    oDBAccess.Dispose();
                    oDBAccess = null;
                }
                if (oDBParameter != null)
                {
                    oDBParameter.Dispose();
                    oDBParameter = null;
                }
            }

            return nSequencNo;
        }

        public DataSet GetCompanyMaster()
        {
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataSet _dsCompanyMaster = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_CompanyMasterDate", out _dsCompanyMaster);
                oDBAccess.CloseConnection(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), clsGlobal.MessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (oDBAccess!=null)
                {
                    oDBAccess.Dispose();
                    oDBAccess = null;
                }
                if (oDBParameter!=null)
                {
                    oDBParameter.Dispose();
                    oDBParameter = null;
                }
            }

            return _dsCompanyMaster;
        }
        #endregion
    }
}
