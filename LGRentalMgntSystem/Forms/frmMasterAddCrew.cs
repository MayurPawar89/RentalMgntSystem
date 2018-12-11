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
    public partial class frmMasterAddCrew : DevExpress.XtraEditors.XtraForm
    {
        public frmMasterAddCrew()
        {
            InitializeComponent();
            fillMasterData();
            GetAndSetSequence();
            txtEmployeeName.Focus();
        }

        private void GetAndSetSequence()
        {
            throw new NotImplementedException();
        }

        private void fillMasterData()
        {
            throw new NotImplementedException();
        }

        private int CheckPanelVisibility()
        {
            int nPanelCount = 0;
            if (pnlPhoneOne.Visible == true && pnlPhoneTwo.Visible == false && pnlPhoneThree.Visible == false && pnlPhoneFour.Visible == false && pnlPhoneFive.Visible == false)
            {
                nPanelCount = 2;
            }
            else if (pnlPhoneOne.Visible == true && pnlPhoneTwo.Visible == true && pnlPhoneThree.Visible == false && pnlPhoneFour.Visible == false && pnlPhoneFive.Visible == false)
            {
                nPanelCount = 3;
            }
            else if (pnlPhoneOne.Visible == true && pnlPhoneTwo.Visible == true && pnlPhoneThree.Visible == true && pnlPhoneFour.Visible == false && pnlPhoneFive.Visible == false)
            {
                nPanelCount = 4;
            }
            else if (pnlPhoneOne.Visible == true && pnlPhoneTwo.Visible == true && pnlPhoneThree.Visible == true && pnlPhoneFour.Visible == true && pnlPhoneFive.Visible == false)
            {
                nPanelCount = 5;
            }
            else if (pnlPhoneOne.Visible == true && pnlPhoneTwo.Visible == true && pnlPhoneThree.Visible == true && pnlPhoneFour.Visible == true && pnlPhoneFive.Visible == false)
            {
                nPanelCount = 6;
            }
            return nPanelCount;
        }

        private void ShowHidePhonePanel(string sPhoneNo = "", int PhoneCount = 1)
        {
            switch (PhoneCount)
            {
                case 1:
                    {
                        pnlPhoneOne.Visible = true;
                        pnlPhoneTwo.Visible = false;
                        pnlPhoneThree.Visible = false;
                        pnlPhoneFour.Visible = false;
                        pnlPhoneFive.Visible = false;
                        txtPhone1.Text = sPhoneNo;
                        break;
                    }
                case 2:
                    {
                        pnlPhoneOne.Visible = true;
                        pnlPhoneTwo.Visible = true;
                        pnlPhoneTwo.BringToFront();
                        pnlPhoneThree.Visible = false;
                        pnlPhoneFour.Visible = false;
                        pnlPhoneFive.Visible = false;
                        txtPhone2.Text = sPhoneNo;
                        break;
                    }
                case 3:
                    {
                        pnlPhoneOne.Visible = true;
                        pnlPhoneTwo.Visible = true;
                        pnlPhoneThree.Visible = true;
                        pnlPhoneThree.BringToFront();
                        pnlPhoneFour.Visible = false;
                        pnlPhoneFive.Visible = false;
                        txtPhone3.Text = sPhoneNo;
                        break;
                    }
                case 4:
                    {
                        pnlPhoneOne.Visible = true;
                        pnlPhoneTwo.Visible = true;
                        pnlPhoneThree.Visible = true;
                        pnlPhoneFour.Visible = true;
                        pnlPhoneFour.BringToFront();
                        pnlPhoneFive.Visible = false;
                        txtPhone4.Text = sPhoneNo;
                        break;
                    }
                case 5:
                    {
                        pnlPhoneOne.Visible = true;
                        pnlPhoneTwo.Visible = true;
                        pnlPhoneThree.Visible = true;
                        pnlPhoneFour.Visible = true;
                        pnlPhoneFive.Visible = true;
                        pnlPhoneFive.BringToFront();
                        txtPhone5.Text = sPhoneNo;
                        break;
                    }
            }
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            int nCompanyPhoneCount = CheckPanelVisibility();
            if (nCompanyPhoneCount <= 5)
            {
                ShowHidePhonePanel("", nCompanyPhoneCount);
            }
        }
    }
}
