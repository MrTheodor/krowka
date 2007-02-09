/// Based on
/// http://www.codeguru.pl/article-137.aspx
///
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimpleFirstApp
{
    public partial class PanelDB : System.Windows.Forms.Panel
    {
        public PanelDB()
        {
            InitializeComponent();
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);

        }
    }
}
