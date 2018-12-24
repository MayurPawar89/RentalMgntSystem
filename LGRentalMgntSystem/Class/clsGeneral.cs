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
        public Int64 GetSequenceNumber_Transaction(TransactionType oTransactionType)
        {
            Int64 nSequencNo = 0;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataTable _dt = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nTransactionType", oTransactionType.GetHashCode(), ParameterDirection.Input, SqlDbType.Int);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_SequenceNoTransaction", oDBParameter, out _dt);
                oDBAccess.CloseConnection(false);
                if (_dt != null && _dt.Rows.Count > 0)
                {
                    nSequencNo = Convert.ToInt64(_dt.Rows[0][0]);
                }
            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(false);
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
                oDBAccess.CloseConnection(false);
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
                oDBAccess.CloseConnection(false);
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

        public DataSet GetCrewMaster()
        {
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataSet _dsCompanyMaster = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_CrewMasterData", out _dsCompanyMaster);
                oDBAccess.CloseConnection(false);
            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(false);
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

            return _dsCompanyMaster;
        }

        public DataSet GetPartyMaster()
        {
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataSet _dsCompanyMaster = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_PartyMasterData", out _dsCompanyMaster);
                oDBAccess.CloseConnection(false);
            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(false);
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

            return _dsCompanyMaster;
        }

        public DataSet GetGafferMaster()
        {
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataSet _dsCompanyMaster = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_CSCMasterData", out _dsCompanyMaster);
                oDBAccess.CloseConnection(false);
            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(false);
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

            return _dsCompanyMaster;
        }

        public DataSet GetLocationMaster()
        {
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataSet _dsCompanyMaster = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Get_CSCMasterData", out _dsCompanyMaster);
                oDBAccess.CloseConnection(false);
            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(false);
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

            return _dsCompanyMaster;
        }

        public Int64 GetDeleteMasterType(int nMasterType, Int64 nID)
        {
            Int64 nSequencNo = 0;
            DatabaseAccess oDBAccess = null;
            DatabaseParameters oDBParameter = null;
            DataTable _dt = null;
            try
            {
                oDBAccess = new DatabaseAccess();
                oDBParameter = new DatabaseParameters();
                oDBParameter.clear();
                oDBParameter.Add("@nMasterType", nMasterType, ParameterDirection.Input, SqlDbType.Int);
                oDBParameter.Add("@nID", nID, ParameterDirection.Input, SqlDbType.BigInt);
                oDBAccess.OpenConnection(false);
                oDBAccess.Retrive("lgsp_Delete_MasterType", oDBParameter, out _dt);
                oDBAccess.CloseConnection(false);
                if (_dt != null && _dt.Rows.Count > 0)
                {
                    nSequencNo = Convert.ToInt64(_dt.Rows[0][0]);
                }
            }
            catch (Exception ex)
            {
                oDBAccess.CloseConnection(false);
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
        #endregion
    }
}
