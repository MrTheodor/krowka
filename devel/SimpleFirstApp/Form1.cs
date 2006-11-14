/*
 * Jakub Krajniak (c) 2006
 * Licence: GPL
 * Wersja: 1
 * 
 * Program realizuj¹cy funkcje quasi-totalistyczn¹, domyœlnie realizuje algorytm Game of life
*/
using System;
using System.IO;
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
        //
        static Color s_ColorZajete = Color.Red;
        static Color s_ColorNiezajete = Color.White;
        private static Int32 s_CellsWidth = 63; // number of cells on grid 'n'x'n'
        private static Int32 s_CellsHeight = 63; //
        private static Int32 s_Timer = 5;
        static Pen s_BrushZajete = new Pen(s_ColorZajete);
        static Pen s_BrushWolne = new Pen(s_ColorNiezajete);
        private static Int32 s_CellHeight = 505/s_CellsHeight; //in px
        private static Int32 s_CellWidth = 505/s_CellsWidth; //in px
        private static bool s_showgrid = false;
        private static bool s_showObserver = false;
        private static int step_counter = 0;
        private static Color s_colorObserver = Color.BlueViolet;

        private static Point observ_director = new Point(0, 0);
        private static bool m_Panel_dir = false;

        private int[,] siatka_state1 = new int[s_CellsHeight, s_CellsWidth];
        private int[,] siatka_state2 = new int[s_CellsHeight, s_CellsWidth];
        private int[,] siatka_state3 = new int[s_CellsHeight, s_CellsWidth];

        static AboutBox1 about = new AboutBox1();

        //default function description, for static game of live and for tests
        private string[] default_function = { "2: 10", "3: 11" };

        private static int s_statcounter = 0;

        // a to juz nasza gra
        private automat m_Game = new automat(s_CellsHeight, s_CellsWidth);
        // obserwator, domyœlnie 0 - god
        private LocalObservers obserwator = new LocalObservers(s_CellsHeight);
        //a jak ktos wcisnie to co
        private bool m_bMouseDown = false;
        private bool m_start = false;
        private int local_observer_define = 0;

        // sami nie bedziemy popychac dalej tej gry
        private Timer m_Timer = new Timer();

        private void save_step()
        {
            if (s_statcounter == 0)
            {
                siatka_state1 = m_Game.current_state();
                lblstep1.Text = step_counter.ToString();
                state1.Refresh();
            }
            if (s_statcounter == 1)
            {
                siatka_state2 = m_Game.current_state();
                lblstep2.Text = step_counter.ToString();
                state2.Refresh();
            }
            if (s_statcounter == 2)
            {
                siatka_state3 = m_Game.current_state();
                lblstep3.Text = step_counter.ToString();
                state3.Refresh();
                s_statcounter = 0;
            }
            else
            {
                s_statcounter++;
            }
        }

        private void step_by_step()
        {

            m_Game.next_state();
            obserwator.push_state(m_Game.current_state());

            if (!(observ_director.X == 0 && observ_director.Y == 0))
            {
                Point new_obs = obserwator.get_observer();
                int cor_x = new_obs.X - (observ_director.X * (-1));
                int cor_y = new_obs.Y - (observ_director.Y * (-1));
                if (obs_speed.Value > 0)
                {
                    cor_x+=Convert.ToInt32(obs_speed.Value);
                    cor_y+=Convert.ToInt32(obs_speed.Value);
                }
                if (cor_x < 0)
                    cor_x = s_CellsWidth;
                if (cor_x > s_CellsWidth)
                    cor_x = 0;
                if (cor_y < 0)
                    cor_y = s_CellsHeight;
                if (cor_y > s_CellsHeight)
                    cor_y = 0;
                new_obs = new Point(cor_x, cor_y);
                if (obs_speed.Value <= 0)
                {
                    if ((step_counter % (obs_speed.Value * (-1))) == 0)
                        obserwator.change_position(new_obs);
                }
                else
                {
                    obserwator.change_position(new_obs);
                }
                lbl_obs.Text = obserwator.get_observer().X.ToString() + "x" + obserwator.get_observer().Y.ToString();
            }
            step_counter++;
            step_label.Text = step_counter.ToString();
            if (savestate.Value != 0)
            {
                if (step_counter % savestate.Value == 0)
                {
                    save_step();
                }
            }
            panel.Refresh();
        }

        private void OnTimer(Object sender, EventArgs e)
        {
            step_by_step();
        }

        //mouse event
     
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            // make grid ;)
            Graphics Gr = e.Graphics;
            Pen BlackPen = new Pen(Color.Black);
            if (s_showgrid)
            {
                for (int i = 0; i < s_CellsWidth; i++)
                {
                    Gr.DrawLine(BlackPen, i * s_CellHeight, 0, i * s_CellHeight, 505);
                    Gr.DrawLine(BlackPen, 0, i * s_CellHeight, 505, i * s_CellHeight);
                }
            }
            for (int x = 0; x < s_CellsHeight; x++)
            {
                for (int y = 0; y < s_CellsWidth; y++)
                {
                    if ((obserwator.GetCell(x, y)) == 1)
                    {
                        Rectangle punkt = new Rectangle(x * s_CellHeight, y * s_CellWidth, s_CellWidth, s_CellHeight);
                        SolidBrush pedzel = new SolidBrush(s_ColorZajete);
                        Gr.FillRectangle(pedzel, punkt);
                        Gr.DrawRectangle(s_BrushZajete, punkt);
                        //Gr.DrawRectangle(s_BrushZajete, x * s_CellHeight, y * s_CellWidth, s_CellWidth, s_CellHeight);
                    }
                }
            }
            if (s_showObserver)
            {
                int cor_x = obserwator.get_observer().X;
                int cor_y = obserwator.get_observer().Y;
                Rectangle kwadrat = new Rectangle(cor_x * s_CellHeight, cor_y * s_CellWidth, s_CellWidth, s_CellHeight);
                Pen s_observeator = new Pen(s_colorObserver);
                Gr.DrawRectangle(s_observeator, kwadrat);
            }

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
            this.Text = Application.ProductName + " " + Application.ProductVersion;
            obserwator.push_state(m_Game.current_state());
            if (File.Exists("options.par"))
            {
                StreamReader sr = new StreamReader("options.par");
                String line;
                int counter = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (counter == 0)
                        s_ColorZajete = Color.FromName(line);
                    if (counter == 1){
                        if (line == "True"){
                            checkBox1.Checked = true;
                        } else if (line == "False"){
                            checkBox1.Checked = false;
                        }
                    }
                    if (counter == 2)
                        refresh.Value = Convert.ToInt32(line);
                    if (counter == 3)
                        savestate.Value = Convert.ToInt32(line);
                    counter++;
                }
            }

            obs_color.BackColor = s_colorObserver;

            m_Game.load_function(default_function);
            //enabledcolor.BackColor = s_ColorZajete;
            m_Timer.Interval = 1000 / s_Timer;
            m_Timer.Tick += new EventHandler(OnTimer);
            step_label.Text = step_counter.ToString();
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            m_Game.randomize();
            panel.Refresh();
        }

        private void stepbtn_Click(object sender, EventArgs e)
        {
            if (m_Timer.Enabled)
            {
                m_Timer.Stop();
                startbtn.Text = "Start";
            }
            
            step_by_step();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if ((!m_bMouseDown) && (local_observer_define == 0))
                m_bMouseDown = true;
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            int cor_x = e.X / s_CellHeight;
            int cor_y = e.Y / s_CellWidth;
            if (m_bMouseDown)
            {
                if ((m_Game.GetCell(cor_x, cor_y))==1)
                {
                    m_Game.SetCell(cor_x, cor_y, 0);
                }
                else
                {
                    m_Game.SetCell(cor_x, cor_y, 1);
                }
                panel.Refresh();
            }
            if (local_observer_define == 1)
            {
                btn_localobs.BackColor = Color.FromName("Control");
                lbl_obs.Text = cor_x.ToString() + "x" + cor_y.ToString();
                Point p = new Point(cor_x, cor_y);
                obserwator.add_observer(p);
                local_observer_define = 0;

            }

        }

        private void checkBox1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            s_showgrid = checkBox1.Checked;
            panel.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            m_Game.reset();
            obserwator.reset();
            step_counter = 0;
            panel.Refresh();
        }

        private void enabledcolor_Click(object sender, EventArgs e)
        {
            // Keeps the user from selecting a custom color.
            colordialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            colordialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            // Update the text box color if the user clicks OK 
            if (colordialog.ShowDialog() == DialogResult.OK)
            {
                //enabledcolor.BackColor = colordialog.Color;
                s_ColorZajete = colordialog.Color;
            }
            panel.Refresh();
            state1.Refresh();
            state2.Refresh();
            state3.Refresh();
            
        }

        private void refresh_ValueChanged(object sender, EventArgs e)
        {
            s_Timer = Convert.ToInt32(refresh.Value);
            m_Timer.Interval = 1000 / s_Timer;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            save_step();
        }

        private void state1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Gr = e.Graphics;
            for (int x = 0; x < s_CellsHeight; x++)
            {
                for (int y = 0; y < s_CellsWidth; y++)
                {
                    if ((siatka_state1[x, y])==1)
                    {
                        Rectangle punkt = new Rectangle(x*(100 / s_CellsHeight), y*(100 / s_CellsWidth), 100 / s_CellsHeight, 100 / s_CellsWidth);
                        SolidBrush pedzel = new SolidBrush(s_ColorZajete);
                        Gr.FillRectangle(pedzel, punkt);
                        Gr.DrawRectangle(s_BrushZajete, punkt);
                        //Gr.DrawRectangle(s_BrushZajete, x * s_CellHeight, y * s_CellWidth, s_CellWidth, s_CellHeight);
                    }
                }
            }
        }

        private void state2_Paint(object sender, PaintEventArgs e)
        {
            Graphics Gr = e.Graphics;
            for (int x = 0; x < s_CellsHeight; x++)
            {
                for (int y = 0; y < s_CellsWidth; y++)
                {
                    if ((siatka_state2[x, y])==1)
                    {
                        Rectangle punkt = new Rectangle(x * (100 / s_CellsHeight), y * (100 / s_CellsWidth), 100 / s_CellsHeight, 100 / s_CellsWidth);
                        SolidBrush pedzel = new SolidBrush(s_ColorZajete);
                        Gr.FillRectangle(pedzel, punkt);
                        Gr.DrawRectangle(s_BrushZajete, punkt);
                        //Gr.DrawRectangle(s_BrushZajete, x * s_CellHeight, y * s_CellWidth, s_CellWidth, s_CellHeight);
                    }
                }
            }
        }

        private void state3_Paint(object sender, PaintEventArgs e)
        {
            Graphics Gr = e.Graphics;
            for (int x = 0; x < s_CellsHeight; x++)
            {
                for (int y = 0; y < s_CellsWidth; y++)
                {
                    if ((siatka_state3[x, y])==1)
                    {
                        Rectangle punkt = new Rectangle(x * (100 / s_CellsHeight), y * (100 / s_CellsWidth), 100 / s_CellsHeight, 100 / s_CellsWidth);
                        SolidBrush pedzel = new SolidBrush(s_ColorZajete);
                        Gr.FillRectangle(pedzel, punkt);
                        Gr.DrawRectangle(s_BrushZajete, punkt);
                        //Gr.DrawRectangle(s_BrushZajete, x * s_CellHeight, y * s_CellWidth, s_CellWidth, s_CellHeight);
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private string change_check(bool val)
        {
            if (val)
                return "1";
            else
                return "0";
        }

        private void cell_on_CheckedChanged(object sender, EventArgs e)
        {
            cell_on.Text = change_check(cell_on.Checked);
        }

        private void cell_next_on_CheckedChanged(object sender, EventArgs e)
        {
            cell_next_on.Text = change_check(cell_next_on.Checked);
        }

        private void state1_Click(object sender, EventArgs e)
        {
            m_Game.load_state(siatka_state1);
            panel.Refresh();
        }

        private void state2_Click(object sender, EventArgs e)
        {
            m_Game.load_state(siatka_state2);
            panel.Refresh();
        }

        private void state3_Click(object sender, EventArgs e)
        {
            m_Game.load_state(siatka_state3);
            panel.Refresh();
        }

        private void savestate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void update_function()
        {
            
            string[] act_function = { };
            foreach (string item in function_list.Items)
            {
                Array.Resize(ref act_function, act_function.Length + 1);
                act_function[act_function.Length - 1] = item;
            }
            m_Game.load_function(act_function);
        }

        private void add_def_Click(object sender, EventArgs e)
        {
            string ret = "";
            int item_exist = -1;
            foreach (string item in function_list.Items)
            {
                if (item[0].ToString() == neighbours_count.Value.ToString())
                    item_exist = function_list.Items.IndexOf(item);
            }
            if (item_exist >= 0)
                function_list.Items.RemoveAt(item_exist);
            ret = neighbours_count.Value.ToString() + ": " + cell_on.Checked.ToString() + cell_next_on.Checked.ToString();
            function_list.Items.Add(ret.Replace("False", "0").Replace("True", "1"));
            update_function();
        }

        private void function_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            func_remove.Enabled = true;
        }

        private void function_list_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            func_remove.Enabled = true;
        }

        private void func_remove_Click(object sender, EventArgs e)
        {
            function_list.Items.RemoveAt(function_list.SelectedIndex);
            update_function();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            int counter = 0;
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                if(counter>2)
                    function_list.Items.Add(line);
                counter++;
            }
            update_function();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            sw.WriteLine("FQT");
            sw.WriteLine("2 2 0");
            sw.WriteLine("1,2");
            foreach(String item in function_list.Items){
                sw.WriteLine(item.ToString());
            }

            sw.Close();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            about.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            saveFileDialog2.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter sw = new StreamWriter(saveFileDialog2.FileName);
            for (int x = 0; x < m_Game.X; x++)
            {
                for (int y = 0; y < m_Game.Y; y++)
                {
                    if ((m_Game.current_state()[x, y])==1)
                        sw.WriteLine(x.ToString() + " " + y.ToString());
                }
            }
            sw.Close();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            int[,] siatka = new int[s_CellsHeight, s_CellsWidth];
            StreamReader sr = new StreamReader(openFileDialog2.FileName);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] spliter;
                spliter = line.Split(' ');
                siatka[Convert.ToInt32(spliter[0].ToString()), Convert.ToInt32(spliter[1].ToString())] = 1;
            }
            sr.Close();
            m_Game.load_state(siatka);
            panel.Refresh();
        }

        private void mainfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("options.par");
            sw.WriteLine(s_ColorZajete.ToKnownColor().ToString());
            sw.WriteLine(checkBox1.Checked.ToString());
            sw.WriteLine(refresh.Value.ToString());
            sw.WriteLine(savestate.Value.ToString());
            sw.Close();

        }

        private void panel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            step_label.Text = e.Shift.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (local_observer_define == 1)
            {
                btn_localobs.BackColor = Color.FromName("Control");
                lbl_obs.Text = "god";
                obserwator.set_observer(0);
                local_observer_define = 0;
            }
            else
            {
                btn_localobs.BackColor = Color.White;
                local_observer_define=1;
            }
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            int cor_x = e.X / s_CellHeight;
            int cor_y = e.Y / s_CellWidth;
            lbl_stat_cursor.Text = cor_x.ToString() + "x" + cor_y.ToString();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Gr = e.Graphics;
            Pen BlackPen = new Pen(Color.Black);
                for (int i = 1; i < 3; i++)
                {
                    Gr.DrawLine(BlackPen, i * 29, 0, i * 29, 90);
                    Gr.DrawLine(BlackPen, 0, i * 29, 90, i * 29);
                }

            Gr.DrawEllipse(BlackPen, 38, 38, 10, 10);
            //Gr.DrawLine(BlackPen, 43, 43, 80, 43);
            
        }

        private void dir_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (!m_Panel_dir)
                m_Panel_dir= true;
        }

        private void dir_panel_MouseUp(object sender, MouseEventArgs e)
        {
            int cor_x = e.X / 30;
            int cor_y = e.Y / 30;
            
            if (m_Panel_dir)
            {
                switch (cor_y)
                {
                    case 0: cor_y = -1; break;
                    case 1: cor_y = 0; break;
                    case 2: cor_y = 1; break;
                }
                switch (cor_x)
                {
                    case 0: cor_x = -1; break;
                    case 1: cor_x = 0; break;
                    case 2: cor_x = 1; break;
                }

                Point p = new Point(cor_x, cor_y);
                observ_director = p;
                lbl_direction.Text = cor_x.ToString() + "x" + cor_y.ToString();
            }
            
        }

        private void dir_panel_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_show_obs_Click(object sender, EventArgs e)
        {
            if (!s_showObserver)
            {
                s_showObserver = true;
                btn_show_obs.BackColor = Color.White;
                panel.Refresh();
            }
            else
            {
                s_showObserver = false;
                btn_show_obs.BackColor = Color.FromName("Control");
            }
        }

        private void obs_color_Click(object sender, EventArgs e)
        {
            if (colordialog.ShowDialog() == DialogResult.OK)
                s_colorObserver = colordialog.Color;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            obserwator.set_speed(Convert.ToInt32(numericUpDown1.Value));
        }


    }
}