﻿using System;
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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void assetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void partyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void siteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsb_Asset_Click(object sender, EventArgs e)
        {
            ShowAsset();
        }

        private void ShowAsset()
        {
            frmAsset frmAsset = new frmAsset();
            frmAsset.ShowDialog();
        }

        private void assetToolStripMenuItemAsset_Click(object sender, EventArgs e)
        {
            ShowAsset();
        }
    }
}