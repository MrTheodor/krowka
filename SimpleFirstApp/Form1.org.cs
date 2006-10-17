using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleFirstApp
{
    
    public partial class mainfrm : Form
    {
        
        public mainfrm()
        {
            InitializeComponent();
            
        }
        //public static automat KrowkaAutomat = new automat();
        
        //domyslne wartosci
        static Color s_ColorZajete = Color.Red;
        static Color s_ColorNiezajete = Color.White;
        private static Int32 s_iDefaultCellsWidth = 60;
        private static Int32 s_iDefaultCellsHeight = 60;
        private static Int32 s_iDefaultFrequency = 5;
        static SolidBrush s_OccBrush = new SolidBrush(s_ColorZajete);
        static SolidBrush s_UnoccBrush = new SolidBrush(s_ColorNiezajete);
        private static Int32 s_iCellWidth = 5;
        private static Int32 s_iCellHeight = 5;
        // a to juz nasza gra
        private automat m_Game = new automat(s_iDefaultCellsWidth, s_iDefaultCellsHeight);

        //a jak ktos wcisnie to co
        private bool m_bMouseDown = false;
        private bool m_start = false;

        // sami nie bedziemy popychac dalej tej gry
        private Timer m_Timer = new Timer();

        // nasz buffor ktory bedziemy nakladac
        Bitmap m_Image = new Bitmap(s_iCellWidth * s_iDefaultCellsWidth, s_iCellHeight * s_iDefaultCellsHeight);
        
        // rysujemy po tym
        Graphics m_Graphics;

        // nasz timer, co 5 rysujemy i nastepny stan gry
        private void OnTimer(Object sender, EventArgs e)
        {
            m_Game.next_state();
            CreateGraphics().DrawImage(m_Image, 0, 0);
        }

        private void RefreshImage()
        {
            m_Graphics.FillRectangle(s_UnoccBrush, 0, 0, m_Game.X * s_iCellWidth, m_Game.Y * s_iCellHeight);

            for (int x = 0; x < m_Game.X; x++)
            {
                for (int y = 0; y < m_Game.Y; y++)
                {
                    if (m_Game.GetCell(x, y))
                        m_Graphics.FillRectangle(s_OccBrush,
                            x * s_iCellWidth, y * s_iCellHeight,
                            s_iCellWidth, s_iCellHeight);
                }
            }
        }

        private void RedrawCell(Int32 iX, Int32 iY, bool bAlive)
        {
            Rectangle rect = new Rectangle(iX * s_iCellWidth, iY * s_iCellHeight, s_iCellWidth, s_iCellHeight);

            SolidBrush brush;
            if (bAlive)
                brush = s_OccBrush;
            else
                brush = s_UnoccBrush;
            m_Graphics.FillRectangle(brush, rect);
        }

        //mouse event
        private void OnMouseOccupyCell()
        {
            Int32 x = PointToClient(Control.MousePosition).X / s_iCellWidth;
            Int32 y = PointToClient(Control.MousePosition).Y / s_iCellHeight;
            if (!m_Game.GetCell(x, y))
            {
                m_Game.SetCell(x, y, true);
                Rectangle rect = new Rectangle(x * s_iCellWidth, y * s_iCellHeight, s_iCellWidth, s_iCellHeight);
                CreateGraphics().FillRectangle(s_OccBrush, rect);
                m_Graphics.FillRectangle(s_OccBrush,
                    x * s_iCellWidth, y * s_iCellHeight,
                    s_iCellWidth, s_iCellHeight);
            }
        }
        
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            // make grid ;)
            Graphics Gr = e.Graphics;
            Pen BlackPen = new Pen(Color.Black);
            //e.Graphics.DrawRectangle(BlackPen, Punkt);
            //e.Graphics.DrawRectangle(new Pen(Color.Blue, PenWidth), Punkt);
            /*for (int i = 0; i <= 60; i++)
            {
                Gr.DrawLine(BlackPen, i * 5, 0, i * 5, 300);
                Gr.DrawLine(BlackPen, 0, i * 5, 300, i * 5);
            }*/
            
            e.Graphics.DrawImage(m_Image, panel.ClientRectangle.X,panel.ClientRectangle.Y);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X / 5;
            int y = e.Y / 5;
            /*Pen BlackPen = new Pen(Color.Black);
            Gr.DrawRectangle(Pen,x,y,5,5);
            Invalidate();*/
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            if (m_start)
            {
                m_Timer.Stop();
                startbtn.Text = "Start";
                m_start = false;
            }
            else
            {
                startbtn.Text = "Pause";
                m_start = true;
                m_Timer.Start();
            }
        }

        private void mainfrm_Load(object sender, EventArgs e)
        {
            m_Game.CellChanged += new automat.CellChangedCallback(OnCellChange);

            m_Timer.Interval = 1000 / s_iDefaultFrequency;
            m_Timer.Tick += new EventHandler(OnTimer);

            m_Graphics = Graphics.FromImage(m_Image);
            RefreshImage();
            
        }

        private void OnCellChange(Object sender, Int32 iX, Int32 iY)
        {
            RedrawCell(iX, iY, !m_Game.GetCell(iX, iY));
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            m_bMouseDown = true;
            OnMouseOccupyCell();
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_bMouseDown)
                OnMouseOccupyCell();
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            m_bMouseDown = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Random random = new Random(System.DateTime.Now.Second);
            for (Int32 x = 0; x < m_Game.X; x++)
            {
                for (Int32 y = 0; y < m_Game.Y; y++)
                    m_Game.SetCell(x, y, random.Next(2) == 1);
            }
            RefreshImage();
            CreateGraphics().DrawImage(m_Image, 0, 0);
        }
    }
}