/*
 * Jakub Krajniak (c) 2006
 * Licence: GPL
 * Version: 1.5
 * 
 * 2D celluar automate
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
        static Pen s_BrushZajete = new Pen(Color.Empty);
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
        // "0: 0100000000000000000000000000000000000000000000000000000000000000", 
        private string[] default_function = { "FQT","8 2 2", "1,2,3,4,6,7,8,9", "2: 01", "3: 11" };
        private static string[] default_n2 = { "N2","3 3 8", "1 1", "123", "4-6", "789"};

        private static int s_statcounter = 0;

        // a to juz nasza gra
        private automat m_Game = new automat(s_CellsHeight, s_CellsWidth);
        private N2_file n2_file = new N2_file(default_n2);

        // obserwator, domyœlnie 0 - god
        private LocalObservers obserwator = new LocalObservers(s_CellsHeight);
        //a jak ktos wcisnie to co
        private bool m_bMouseDown = false;
        private bool m_start = false;
        private int local_observer_define = 0;
        private Point local_oberver = new Point(0, 0);

        // sami nie bedziemy popychac dalej tej gry
        private Timer m_Timer = new Timer();

        // other variables
        private const string alp = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz|+";
        private bool drawing_and_running = false;
        private Point n2_cell_selected;
        private List<object> n2_object_grid = new List<object>();

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
            if (drawing_and_running)
            {
                m_Game.next_state();
                obserwator.push_state(m_Game.current_state());

                //local observer can run over the world with variable speed
                if (!(observ_director.X == 0 && observ_director.Y == 0))
                {
                    Point new_obs = obserwator.get_observer();
                    int cor_x = new_obs.X - (observ_director.X * (-1));
                    int cor_y = new_obs.Y - (observ_director.Y * (-1));
                    if (obs_speed.Value > 0)
                    {
                        cor_x += Convert.ToInt32(obs_speed.Value);
                        cor_y += Convert.ToInt32(obs_speed.Value);
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
        }

        private void OnTimer(Object sender, EventArgs e)
        {
            step_by_step();
        }

        //mouse event
     
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            if (drawing_and_running)
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
                        int color_idx = obserwator.GetCell(x, y);

                            Rectangle punkt = new Rectangle(x * s_CellHeight, y * s_CellWidth, s_CellWidth, s_CellHeight);
                            SolidBrush pedzel = new SolidBrush(m_Game.alphabet.Get(color_idx).color);
                            Gr.FillRectangle(pedzel, punkt);
                            Gr.DrawRectangle(s_BrushZajete, punkt);

                            //Gr.DrawRectangle(s_BrushZajete, x * s_CellHeight, y * s_CellWidth, s_CellWidth, s_CellHeight);

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

            //ladujemy domyslny alfabet


            //m_Game.alphabet.Add(new abc_pole(s_ColorNiezajete,"0") );
            //m_Game.alphabet.Add(new abc_pole(s_ColorZajete,"1") );

            obs_color.BackColor = s_colorObserver;

            m_Game.load_function(default_function,default_n2);
            //enabledcolor.BackColor = s_ColorZajete;
            m_Timer.Interval = 1000 / s_Timer;
            m_Timer.Tick += new EventHandler(OnTimer);
            step_label.Text = step_counter.ToString();
            function_list.Items.Add(default_function[3]);
            function_list.Items.Add(default_function[4]);
            foreach (KeyValuePair<int, abc_pole> key in m_Game.alphabet.All())
            {
                int idx = abc_color_grid.Rows.Add(key.Key.ToString(), key.Value.symbol, key.Value.color.Name);
                abc_color_grid.Rows[idx].Cells[2].Style.BackColor = key.Value.color;
            }
            
            //n2_window_x.Text = n2_file.X.ToString();
            //n2_window_y.Text = n2_file.Y.ToString();
            n2_window_x.Maximum = s_CellsHeight;
            n2_window_y.Maximum = s_CellsWidth;
            function_parametrs.Text = default_function[2];
            
            string function_entry = "";
            for (int idx = 0; idx < m_Game.argout; idx++)
            {
                function_entry_was.Items.Add(m_Game.alphabet.All()[idx].symbol);
                function_entry_change_to.Items.Add(m_Game.alphabet.All()[idx].symbol);
                function_entry += "0";
            }
            
            function_entry_list.Items.Add(function_entry);
            function_arguments_size.Value = Convert.ToDecimal(m_Game.argout);
            /*foreach (KeyValuePair<int, abc_pole> key in m_Game.alphabet.All())
            {
                function_entry_was.Items.Add(key.Value.symbol);
                function_entry_change_to.Items.Add(key.Value.symbol);
            }*/

            for (int i = 0; i < n2_file.X; i++)
            {
                n2_grid.Columns.Add("n2_grid_col_" + i.ToString(), i.ToString());
            }

            for (int i = 0; i < n2_file.Y; i++)
            {
                object[] row = new object[n2_file.X];
                for (int x = 0; x < n2_file.X; x++)
                {
                    row[x] = n2_file.Get_decode_description()[i][x].ToString();
                }
                n2_grid.Rows.Add(row);
            }
            n2_grid.Rows[n2_file.Get_checked_cell().Y].Cells[n2_file.Get_checked_cell().X].Style.BackColor = Color.LightYellow;
            n2_cell_selected = n2_file.Get_checked_cell();
           

        }

        private void update_was_change_field(int size)
        {
            function_entry_was.Items.Clear();
            function_entry_change_to.Items.Clear();
            for (int idx = 0; idx < size; idx++)
            {
                function_entry_was.Items.Add(m_Game.alphabet.code(idx));
                function_entry_change_to.Items.Add(m_Game.alphabet.code(idx));
            }
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
                m_start = false;
            }
            
            step_by_step();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (m_Timer.Enabled)
            {
                m_Timer.Stop();
                startbtn.Text = "Start";
                m_start = false;
            }
            if ((!m_bMouseDown) && (local_observer_define == 0))
            {
                m_bMouseDown = true;
                //Point tmp = obserwator.get_observer();
                lbl_obs.Text = "god";
                int prev_obs = obserwator.get_current_observer();
                obserwator.set_observer(0);
                panel.Refresh();
                if(prev_obs==1)
                    obserwator.set_observer(1);
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            int cor_x = e.X / s_CellHeight;
            int cor_y = e.Y / s_CellWidth;
            if (m_bMouseDown && local_observer_define == 0)
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
                local_oberver = p;
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

        private string[] make_function()
        {
            string[] act_function = { "FQT", function_parametrs.Text.Split(',').Length.ToString() + " " + function_arguments_size.Value.ToString() + " " + function_arguments_size.Value.ToString(), function_parametrs.Text };
            foreach (string item in function_list.Items)
            {
                Array.Resize(ref act_function, act_function.Length + 1);
                act_function[act_function.Length - 1] = item;
            }
            return act_function;
        }

        private string[] make_n2()
        {
            string[] act_n2 = { "N2", "", n2_cell_selected.Y.ToString() + " " + n2_cell_selected.X.ToString() };
            int neighbours_count = 0;
            foreach (DataGridViewRow row in n2_grid.Rows)
            {
                string line = "";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() != "-")
                        line += m_Game.alphabet.code(Convert.ToInt32(cell.Value));
                    else
                    {
                        line += cell.Value;
                        neighbours_count++;
                    }
                }
                Array.Resize(ref act_n2, act_n2.Length + 1);
                act_n2[act_n2.Length - 1] = line;
            }
            act_n2[1] = n2_window_y.Value.ToString() + " " + n2_window_x.Value.ToString() + " " + neighbours_count.ToString();
            return act_n2;
        }

        private void update_function()
        {
            m_Game.load_function(make_function(),make_n2());
        }

        private void add_def_Click(object sender, EventArgs e)
        {
            int item_idx = m_Game.alphabet.Get(function_entry_was.Text);
            string ret_ret = "";
            List<string> ret = new List<string>();
            foreach(char z in function_entry_list.Items[0].ToString())
                ret.Add(z.ToString());
            ret[item_idx] = function_entry_change_to.Text;
            foreach (string z in ret)
                ret_ret += z;
            function_entry_list.Items[0] = ret_ret;
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
            //update_function();
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
            FQT fqt = new FQT();
            string[] ret_fqt = { };
            while ((line = sr.ReadLine()) != null)
            {
                Array.Resize(ref ret_fqt, ret_fqt.Length + 1);
                ret_fqt[ret_fqt.Length - 1] = line;
            }
            //update_function();
            try
            {
                function_list.Items.Clear();
                foreach (string line_srajn in fqt.parse_file(ret_fqt))
                {
                    function_list.Items.Add(line_srajn);
                }
                function_parametrs.Text = string.Join(",", fqt.argument_list);
            }
            catch (Exception er)
            {
                ShowErrorBox(er.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            foreach(String item in make_function()){
                sw.WriteLine(item);
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
            try
            {
                StreamWriter sw = new StreamWriter("options.par");
                sw.WriteLine(s_ColorZajete.ToKnownColor().ToString());
                sw.WriteLine(checkBox1.Checked.ToString());
                sw.WriteLine(refresh.Value.ToString());
                sw.WriteLine(savestate.Value.ToString());
                sw.Close();
            }
            catch (Exception er)
            {
                ShowErrorBox("Nothing important, can't save options, don't worry");
            }

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
                if (m_Timer.Enabled)
                {
                    m_Timer.Stop();
                    startbtn.Text = "Start";
                    m_start = false;
                }
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

        private void abc_btn_color_Click(object sender, EventArgs e)
        {
            if (colordialog.ShowDialog() == DialogResult.OK)
                abc_btn_color.BackColor = colordialog.Color;
        }

        private void abc_add_symbol_Click(object sender, EventArgs e)
        {
            //int number = abc_color_grid.Rows[abc_color_grid.Rows.GetLastRow(new DataGridViewElementStates())][0];
            abc_pole pole = new abc_pole(abc_btn_color.BackColor,abc_symbol.Text);
            int idx = Convert.ToInt32(abc_color_grid.SelectedRows[0].Cells[0].Value.ToString());
            if (!m_Game.alphabet.All().ContainsValue(pole))
            {
                if (!m_Game.alphabet.find_color(pole))
                {

                    int number = m_Game.alphabet.Add(pole);
                    if (number != idx)
                    {
                        idx = abc_color_grid.Rows.Add(number.ToString(), abc_symbol.Text, abc_btn_color.BackColor.Name);
                    }
                    else
                    {
                        idx = number;
                        abc_color_grid.Rows[idx].Cells[2].Value = abc_btn_color.BackColor.Name;
                    }
                    abc_color_grid.Rows[idx].Cells[2].Style.BackColor = abc_btn_color.BackColor;
                }
                else
                {
                    //MessageBox.Show(this,
                    MessageBox.Show("Color already used, change it", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void abc_color_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            abc_symbol.Text = abc_color_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            //abc_color_grid.Rows[idx].Cells[2].Style.BackColor = key.Value.color;
            abc_btn_color.BackColor = abc_color_grid.Rows[e.RowIndex].Cells[2].Style.BackColor;
            abc_add_symbol.Text = "Add/Change";
            abc_del_symbol.Enabled = true;
        }

        private void abc_del_symbol_Click(object sender, EventArgs e)
        {
            int idx = Convert.ToInt32(abc_color_grid.SelectedRows[0].Cells[0].Value.ToString());
            if(m_Game.alphabet.Remove(idx))
                abc_color_grid.Rows.Remove(abc_color_grid.Rows[idx]);
        }

        private void n2_window_x_TextChanged(object sender, EventArgs e) // kolumny
        {
            
        }

        private void n2_window_y_TextChanged(object sender, EventArgs e) // wiersze
        {

        }

        private void function_entry_change_to_Validating(object sender, CancelEventArgs e)
        {
            if (!m_Game.alphabet.All_symbols().Contains(function_entry_change_to.Text))
                e.Cancel = true;
        }

        private void n2_window_x_Leave(object sender, EventArgs e)
        {
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(function_entry_neigbour.Text != "")
                try
                {
                    if (Convert.ToInt32(function_entry_neigbour.Text) > (Convert.ToInt32(n2_window_y.Value) * Convert.ToInt32(n2_window_x.Value) * Convert.ToInt32(function_arguments_size.Value - 1)))
                        ShowErrorBox("Too many neigbours.");
                }
                catch (Exception er)
                {
                    ShowErrorBox(er.Message);
                    function_entry_neigbour.Text = "";
                }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            drawing_and_running = true;
        }

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            drawing_and_running = false;
        }

        private void panel_Click(object sender, EventArgs e)
        {

        }

        private void n2_window_x_ValueChanged(object sender, EventArgs e)
        {
            int col = Convert.ToInt32(n2_window_x.Value);
            if (col < n2_grid.ColumnCount)
                n2_grid.ColumnCount = Convert.ToInt32(n2_window_x.Value);
            else
            {
                for (int i = n2_grid.ColumnCount; i < col; i++)
                {
                    n2_grid.Columns.Add("n2_grid_col_" + i.ToString(), i.ToString());
                }
                for (int i = 0; i < n2_grid.RowCount; i++)
                    n2_grid.Rows[i].Cells[col - 1].Value = "-";
            }
            
        }

        private void n2_window_y_ValueChanged(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(n2_window_y.Value);
            n2_grid.RowCount = row;
            for (int i = 0; i < n2_grid.ColumnCount; i++)
                n2_grid.Rows[row - 1].Cells[i].Value = "-";
        }

        private void n2_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n2_grid.Rows[n2_cell_selected.Y].Cells[n2_cell_selected.X].Style.BackColor = Color.White;
            n2_cell_selected = new Point(e.ColumnIndex, e.RowIndex);
            n2_grid.Rows[n2_cell_selected.Y].Cells[n2_cell_selected.X].Style.BackColor = Color.LightYellow;
        }

        private void n2_grid_ContextMenuStripChanged(object sender, EventArgs e)
        {
            
        }
                private void symbol_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            extra_status_lbl.Text = e.ClickedItem.Text;
        }

        private void n2_group_Enter(object sender, EventArgs e)
        {

        }

        private void function_parametrs_Leave(object sender, EventArgs e)
        {
            string fst = function_parametrs.Text;
            List<string> arg_to_remove = new List<string>();
            string ret_ret = "";
            fst = fst.Replace(" ", ",");
            fst = fst.Replace(";", ",");
            string[] ret = fst.Split(',');
            string exam_element = "";
            try
            {
                foreach (string element in ret)
                {
                    exam_element = element;
                    int el = Convert.ToInt32(element);
                    if (el > n2_window_x.Value * n2_window_y.Value)
                    {
                        ShowErrorBox("Argument to big, can be only from range 0.." + (n2_window_x.Value * n2_window_y.Value).ToString());
                        arg_to_remove.Add(element);
                    }
                }

            }
            catch (Exception er)
            {
                ShowErrorBox(er.Message + " Only integers separated by commas,semicolons or spaces");
                function_parametrs.Text = function_parametrs.Text.Trim(',');
                arg_to_remove.Add(exam_element);
                //throw;
            }
            finally
            {
                if (arg_to_remove.Count > 0)
                {
                    foreach (string element in ret)
                    {
                        if (!arg_to_remove.Contains(element))
                            ret_ret += element + ",";
                    }
                    function_parametrs.Text = ret_ret.Trim(',');
                }
                else
                {
                    function_parametrs.Text = fst;
                }
            }
        }

        private void ShowErrorBox(string st)
        {
            string[] funny = { "Don't touch me!", "Why are you do that?", "Don't try to angry me!", "And so..?", "Houston we have a problem" };
            Random random = new Random(System.DateTime.Now.Second);
            MessageBox.Show(funny[random.Next(5)]+"\n"+st, "Funy error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void function_parametrs_TextChanged(object sender, EventArgs e)
        {

        }

        private void function_list_Click(object sender, EventArgs e)
        {
            if (function_list.SelectedIndex >= 0)
            {
                function_entry_btn_insert.Text = "Insert/Change";
                function_entry_neigbour.Text = function_list.SelectedItem.ToString().Split(':')[0];
                function_entry_list.Items[0] = function_list.SelectedItem.ToString().Split(':')[1].Trim();
            }
        }

        private void function_entry_btn_insert_Click(object sender, EventArgs e)
        {
            int finded = -1;
            foreach (string line in function_list.Items)
            {
                if (line.Split(':')[0] == function_entry_neigbour.Text)
                    finded = function_list.Items.IndexOf(line);
            }
            if (finded > -1)
                function_list.Items[finded] = function_entry_neigbour.Text + ": " + function_entry_list.Items[0];
            else
                function_list.Items.Add(function_entry_neigbour.Text + ": " + function_entry_list.Items[0]);
            
        }

        private void function_entry_changed_commit()
        {
            if (function_entry_was.Text == "")
                function_entry_was.Text = "0";
            if (function_entry_change_to.Text == "")
                function_entry_change_to.Text = "0";
            int item_idx = m_Game.alphabet.Get(function_entry_was.Text);
            string ret_ret = "";
            List<string> ret = new List<string>();
            foreach (char z in function_entry_list.Items[0].ToString())
                ret.Add(z.ToString());
            ret[item_idx] = function_entry_change_to.Text;
            foreach (string z in ret)
                ret_ret += z;
            function_entry_list.Items[0] = ret_ret;
        }

        private void function_entry_change_to_SelectionChangeCommitted(object sender, EventArgs e)
        {
            function_entry_changed_commit();
        }

        private void function_entry_was_SelectionChangeCommitted(object sender, EventArgs e)
        {
            function_entry_changed_commit();
        }

        private void function_arguments_size_ValueChanged(object sender, EventArgs e)
        {
            int ar = Convert.ToInt32(function_arguments_size.Value);
            int len = function_entry_list.Items[0].ToString().Length;
            if (len > ar)
                function_entry_list.Items[0] = function_entry_list.Items[0].ToString().Remove(ar, len - ar);
            else
                for (int i = len; i < ar; i++)
                    function_entry_list.Items[0] += "0";
            update_was_change_field(ar);
        }

        private void n2_grid_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (n2_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "-")
            {
                try
                {
                    int cell_content = Convert.ToInt32(n2_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    int size = Convert.ToInt32(n2_window_x.Value) * Convert.ToInt32(n2_window_y.Value);
                    if (cell_content > 63 || cell_content > size)
                    {
                        n2_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                        throw new System.ArgumentException("Value out of range. (1.." + size.ToString());
                    }
                }
                catch (Exception er)
                {
                //    throw;

                    ShowErrorBox(er.Message);

                }
            }
        }

        private void n2_btn_set_Click(object sender, EventArgs e)
        {
            update_function();
        }

        private void n2_save_btn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (String item in make_n2())
                {
                    sw.WriteLine(item);
                }
                sw.Close();
            }
        }

        private void n2_load_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] ret_n2 = { };
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Array.Resize(ref ret_n2, ret_n2.Length + 1);
                        ret_n2[ret_n2.Length - 1] = line;
                    }
                }
                catch (Exception er)
                {
                    ShowErrorBox(er.Message);
                }
                try
                {
                    N2_file n2_fufufu = new N2_file(ret_n2);
                    n2_grid.ColumnCount = n2_fufufu.X;
                    n2_grid.RowCount = n2_fufufu.Y;
                    n2_grid.Rows.Clear();
                    for (int i = 0; i < n2_fufufu.Y; i++)
                    {
                        object[] row = new object[n2_fufufu.X];
                        for (int x = 0; x < n2_fufufu.X; x++)
                        {
                            row[x] = n2_file.Get_description()[i][x].ToString();
                        }
                        n2_grid.Rows.Add(row);
                    }
                    n2_grid.Rows[n2_fufufu.Get_checked_cell().Y].Cells[n2_fufufu.Get_checked_cell().X].Style.BackColor = Color.LightYellow;
                    n2_cell_selected = n2_fufufu.Get_checked_cell();
                }
                catch (Exception er)
                {
                    ShowErrorBox(er.Message);
                }
            }
        }


    }
}