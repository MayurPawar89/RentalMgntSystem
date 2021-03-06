﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGRentalMgntSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                clsGlobal._sMessageboxCaption = System.Configuration.ConfigurationManager.AppSettings["MessageboxCaption"];
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmLogin());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Rental System Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
