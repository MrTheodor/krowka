using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleFirstApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //try
            //{
                Application.Run(new mainfrm());
            //}
            //catch (Exception er)
            //{
            //    MessageBox.Show("Don't worry be happy.\n"+er.Message,"Funy error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
        }
    }
}