/* Krowka
 * Author: Jakub Krajniak (c) 2006-2007 
 * Licence: GPL
 * 
 * 
Krowka - 2D celluar automate
Copyright (C) 2006-2007  Jakub Krajniak

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
*/
 
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
            //Splash.ShowSplashScreen();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //try
            //{
                Application.Run(new mainfrm());
            //}
            //catch (Exception er)
            //{
                //MessageBox.Show("Don't worry be happy.\n"+er.Message,"Funny error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    System.Console.WriteLine("ERROR:"+er.Message);
            //}
        }
    }
}