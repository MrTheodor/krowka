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
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private static Int32 s_CellsWidth = 101; // number of cells on grid 'n'x'n'
        private static Int32 s_CellsHeight = 101; //
        private static Int32 s_Timer = 5;
        private static Pen s_BrushZajete = new Pen(Color.Aqua);
        private static Pen BlackPen = new Pen(Color.LightGray);
        private static SolidBrush pedzel = new SolidBrush(Color.AliceBlue);
        private static Rectangle punkt = new Rectangle();
        private static Pen s_BrushWolne = new Pen(s_ColorNiezajete);
        private static Int32 s_CellHeight = 505/s_CellsHeight; //in px
        private static Int32 s_CellWidth = 505/s_CellsWidth; //in px
        private static bool s_showgrid = false;
        private static bool s_showObserver = false;
        private static int step_counter = 0;
        private static Color s_colorObserver = Color.BlueViolet;

        private static Point observ_director = new Point(0, 0);
        private static bool m_Panel_dir = false;

        private static Bitmap bmpsave;

        //states
        private int[,] siatka_state1 = new int[s_CellsHeight, s_CellsWidth];
        private int[,] siatka_state2 = new int[s_CellsHeight, s_CellsWidth];
        private int[,] siatka_state3 = new int[s_CellsHeight, s_CellsWidth];
        string state_path = "";

        // private int[,] temp_state = new int[s_CellsHeight, s_CellsWidth]; // horrible, only for drawing
        // private int[,] akuku_state = new int[s_CellsHeight, s_CellsWidth]; // horrible, only for drawing
        // private static TextBox[,] grid_kurwa_grid = new TextBox[s_CellsHeight, s_CellsWidth];

        static AboutBox1 about = new AboutBox1();

        //default function description, for static game of live and for tests
        // "0: 0100000000000000000000000000000000000000000000000000000000000000", 
        private string[] default_function = { "FQT","8 2 2", "1,2,3,4,6,7,8,9", "2: 01", "3: 11" };
        private static string[] default_n2 = { "N2","3 3 8", "1 1", "123", "4-6", "789"};

        private static int s_statcounter = 0;

        // a to juz nasza gra
        private automat m_Game = new automat(s_CellsHeight, s_CellsWidth);
        private N2_file n2_file = new N2_file(default_n2);
        private static List<string> n2_grid_cells = new List<string>();


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
        private Point grid_context_menu_cell_selected;
        private string grid_context_menu_selected_item = "0";
        private List<object> n2_object_grid = new List<object>();
        bool load_n2_from_file_block = false;
        // components
        private List<int[,]> components_list = new List<int[,]>();
        private static bool component_move = false;
        private static int[,] component_to_draw;

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
            if (state_chck_tofile.Checked == true)
            {
                save_state_to_file(state_path + "_" + step_counter.ToString() + ".txt");
            }
        }

        private void step_by_step()
        {
            if (drawing_and_running)
            {
                m_Game.next_state();
                obserwator.push_state(m_Game.current_state());
                //akuku_state = obserwator.get_act_state();
                //local observer can run over the world with variable speed
                if (!(observ_director.X == 0 && observ_director.Y == 0))
                {
                    Point new_obs = obserwator.get_observer();
                    int cor_x = new_obs.X - (observ_director.X * (-1));
                    int cor_y = new_obs.Y - (observ_director.Y * (-1));
                    if (obs_speed.Value > 0)
                    {
                        cor_x += Convert.ToInt32(obs_speed.Value)*observ_director.X;
                        cor_y += Convert.ToInt32(obs_speed.Value) * observ_director.Y;
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
                    if (obs_speed.Value < 0)
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
                panel.Invalidate();
            }
        }

        private void OnTimer(Object sender, EventArgs e)
        {
            step_by_step();
        }

        //mouse event
     
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            if (drawing_and_running )
            {
                // make grid ;)
                //Graphics panel_gr = e.Graphics;
                //bmpsave = new Bitmap(505, 505, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                Graphics Gr = e.Graphics;

                for (int x = 0; x < s_CellsHeight; x++)
                {
                    for (int y = 0; y < s_CellsWidth; y++)
                    {
                        int act_cell = obserwator.GetCell(x, y);
                        //int prev_cell = temp_state[x, y];
                        if (act_cell > 0)
                        {
                            punkt.Height = s_CellHeight;
                            punkt.Width = s_CellWidth;
                            punkt.X = x * s_CellHeight;
                            punkt.Y = y * s_CellWidth;
                            pedzel.Color = m_Game.alphabet.Get(act_cell).color;
                            Gr.FillRectangle(pedzel, punkt);
                            Gr.DrawRectangle(s_BrushZajete, punkt);
                        }
                        //Gr.DrawRectangle(s_BrushZajete, x * s_CellHeight, y * s_CellWidth, s_CellWidth, s_CellHeight);
                        //extra_status_lbl.Text = act_cell.ToString() + " - " + prev_cell.ToString();
                    }
                }

                if (s_showgrid)
                {
                    for (int i = 0; i < s_CellsWidth; i++)
                    {
                        if ((i % 10) == 0)
                            BlackPen.Color = Color.Black;
                        else
                            BlackPen.Color = Color.LightGray;
                        Gr.DrawLine(BlackPen, i * s_CellHeight, 0, i * s_CellHeight, 505);
                        Gr.DrawLine(BlackPen, 0, i * s_CellHeight, 505, i * s_CellHeight);
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
                //panel_gr.DrawImage(bmpsave,0,0);
                //bmpsave.Dispose();
                //temp_state = akuku_state;
                //Gr.Dispose();
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
            Splash.SetStatus("Loading configuration...");
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
                symbol_menu.Items.Add(key.Value.symbol);
            }
            Splash.SetStatus("Loading alphabet...");
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
            Splash.SetStatus("Setting default function...");
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
                    int cell = n2_file.Get_decode_description()[i][x];
                    if (cell == -1)
                        row[x] = "-";
                    else
                        row[x] = cell.ToString();
                }
                n2_grid.Rows.Add(row);
            }
            Splash.SetStatus("Putting weirdie green cows..");
            n2_grid.Rows[n2_file.Get_checked_cell().Y].Cells[n2_file.Get_checked_cell().X].Style.BackColor = Color.LightYellow;
            n2_cell_selected = n2_file.Get_checked_cell();
            int[,] glider = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    glider[i, j] = 1;
            glider[0, 0] = 0;
            glider[2, 0] = 0;
            glider[0, 1] = 0;
            glider[1, 1] = 0;
            components_list.Add(glider);
            
            Splash.CloseForm();
        }

        private void update_was_change_field(int size)
        {
            function_entry_was.Items.Clear();
            function_entry_change_to.Items.Clear();
            symbol_menu.Items.Clear();
            for (int idx = 0; idx < size; idx++)
            {
                function_entry_was.Items.Add(m_Game.alphabet.code(idx));
                function_entry_change_to.Items.Add(m_Game.alphabet.code(idx));
                symbol_menu.Items.Add(m_Game.alphabet.code(idx));
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
            if ((!m_bMouseDown) && (local_observer_define == 0) && (!component_move))
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
            if (m_bMouseDown && local_observer_define == 0 && component_move == false)
            {
                //symbol_menu.Show(panel, e.Location);
                if(m_Game.GetCell(cor_x,cor_y) != 0)
                    m_Game.SetCell(cor_x, cor_y, 0);
                else
                    m_Game.SetCell(cor_x, cor_y, m_Game.alphabet.decode(grid_context_menu_selected_item));
                /*if ((m_Game.GetCell(cor_x, cor_y))==1)
                {
                    m_Game.SetCell(cor_x, cor_y, 0);
                    //temp_state[cor_x, cor_y] = 0;
                }
                else
                {
                    m_Game.SetCell(cor_x, cor_y, 1);
                    //temp_state[cor_x, cor_y] = 1;
                }*/
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
            if (component_move)
            {

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

        private void draw_grid_content(Graphics gr, int[,] siatka)
        {
            Rectangle m_punkt = new Rectangle();
            SolidBrush m_pedzel = new SolidBrush(s_ColorZajete);
            m_punkt.Height = 1;
            m_punkt.Width = 1;
            for (int x = 0; x < s_CellsHeight; x++)
            {
                for (int y = 0; y < s_CellsWidth; y++)
                {
                    if (siatka[x, y] > 0)
                    {
                        m_punkt.X = x;
                        m_punkt.Y = y;
                        m_pedzel.Color = m_Game.alphabet.Get(siatka[x,y]).color;
                        gr.FillRectangle(m_pedzel, m_punkt);
                        gr.DrawRectangle(s_BrushZajete, m_punkt);
                        //Gr.DrawRectangle(s_BrushZajete, x * s_CellHeight, y * s_CellWidth, s_CellWidth, s_CellHeight);
                    }
                }
            }
        }

        private void state1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Gr = e.Graphics;
            draw_grid_content(Gr, siatka_state1);
        }

        private void state2_Paint(object sender, PaintEventArgs e)
        {
            Graphics Gr = e.Graphics;
            draw_grid_content(Gr, siatka_state2);
            /*for (int x = 0; x < s_CellsHeight; x++)
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
            }*/
        }

        private void state3_Paint(object sender, PaintEventArgs e)
        {
            Graphics Gr = e.Graphics;
            draw_grid_content(Gr, siatka_state3);
            /*for (int x = 0; x < s_CellsHeight; x++)
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
            }*/
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

        private void put_from_stage(int[,] siatka)
        {
            m_Game.load_state(siatka);
            obserwator.push_state(siatka);
        }

        private void state1_Click(object sender, EventArgs e)
        {
            put_from_stage(siatka_state1);
            panel.Refresh();
        }

        private void state2_Click(object sender, EventArgs e)
        {
            put_from_stage(siatka_state2);
            panel.Refresh();
        }

        private void state3_Click(object sender, EventArgs e)
        {
            put_from_stage(siatka_state3);
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
            List<string> check_it = new List<string>() ; // check if neighbour exists on list
            int neighbours_count = 0;
            
            foreach (DataGridViewRow row in n2_grid.Rows)
            {
                string line = "";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() != "-")
                    {
                        
                        if (!check_it.Contains(cell.Value.ToString()))
                        {
                            line += m_Game.alphabet.code(Convert.ToInt32(cell.Value));
                            check_it.Add(cell.Value.ToString());
                            neighbours_count++;
                        }
                    }
                    else
                    {
                        line += cell.Value;
                        
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
            abc_color_grid.Rows.Clear();
            symbol_menu.Items.Clear();
            foreach (KeyValuePair<int, abc_pole> key in m_Game.alphabet.All())
            {
                int idx = abc_color_grid.Rows.Add(key.Key.ToString(), key.Value.symbol, key.Value.color.Name);
                abc_color_grid.Rows[idx].Cells[2].Style.BackColor = key.Value.color;
                symbol_menu.Items.Add(key.Value.symbol);
            }
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
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
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    foreach (String item in make_function())
                    {
                        sw.WriteLine(item);
                    }
                    sw.Close();
                } catch (Exception er)
                {
                    ShowErrorBox(er.Message);
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

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
            if(saveFileDialog2.ShowDialog() == DialogResult.OK)
                save_state_to_file(saveFileDialog2.FileName);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog2.FileName);
                    string l = sr.ReadLine();
                    int[,] siatka = new int[Convert.ToInt32(l.Split(' ')[0]), Convert.ToInt32(l.Split(' ')[1])];
                    s_CellsWidth = Convert.ToInt32(l.Split(' ')[1]);
                    s_CellsHeight = Convert.ToInt32(l.Split(' ')[0]);
                    String line;
                    for(int y = 0; y<s_CellsHeight;y++)
                    {
                        line = sr.ReadLine();
                        int x = 0;
                        foreach(char s in line)
                        {
                            siatka[x,y] = m_Game.alphabet.decode(s.ToString());
                            x++;
                        }
                    }
                    /*while ((line = sr.ReadLine()) != null)
                    {
                        string[] spliter;
                        spliter = line.Split(' ');

                        siatka[Convert.ToInt32(spliter[0].ToString()), Convert.ToInt32(spliter[1].ToString())] = Convert.ToInt32(spliter[2]);
                        m_Game.load_state(siatka);
                        obserwator.push_state(siatka);
                    }*/
                    line = sr.ReadLine();
                    if (line.Split(' ')[0] != "-1")
                        if (line.Split(' ')[1] != "-1")
                        {
                            obserwator.change_position(new Point(Convert.ToInt32(line.Split(' ')[0]), Convert.ToInt32(line.Split(' ')[1])));
                        }
                    m_Game.load_state(siatka);
                    obserwator.push_state(siatka);
                    sr.Close();
                }
                catch (Exception er)
                {
                    ShowErrorBox("Invalid world state file\n" + er.Message);
                }

                panel.Refresh();
            }
        }

        private void save_state_to_file(string file_name)
        {
            try
            {
                StreamWriter sw = new StreamWriter(file_name);
                sw.WriteLine(m_Game.X.ToString() + " " + m_Game.Y.ToString());
                for (int y = 0; y < m_Game.Y; y++)
                {
                    string line = "";
                    for (int x = 0; x < m_Game.X; x++)
                    {
                        line += m_Game.alphabet.code(m_Game.current_state()[x, y]);
                    }
                    sw.WriteLine(line);
                }
                if (obserwator.get_observer().Y == 0 && obserwator.get_observer().X == 0)
                    sw.WriteLine("-1 -1");
                else
                    sw.WriteLine(obserwator.get_observer().X.ToString() + " " + obserwator.get_observer().Y.ToString());
                sw.Close();
            }
            catch (Exception er)
            {
                ShowErrorBox("There were some problems with writing world state to file\n" + er.Message);
            }
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

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
            //s_CellsHeight, s_CellsWidth

            int cor_x = e.X / s_CellHeight;
            int cor_y = e.Y / s_CellWidth;
            lbl_stat_cursor.Text = cor_x.ToString() + "x" + cor_y.ToString() + " symbol: " + m_Game.alphabet.Get(m_Game.GetCell(cor_x, cor_y)).symbol.ToString();
            //grid_info_tooltip.Show("Symbol: " + m_Game.alphabet.Get(m_Game.GetCell(cor_x, cor_y)).symbol.ToString(), panel, e.X, e.Y);
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
            Gr.DrawLine(BlackPen, 43, 43, (observ_director.X+1)*40, (observ_director.Y+1)*40);
            
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
                dir_panel.Invalidate();
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
                    ShowErrorBox("Color already used, change it");
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
            grid_context_menu_selected_item = abc_symbol.Text;
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
            if (!load_n2_from_file_block)
            {
                int col = Convert.ToInt32(n2_window_x.Value);
                if (col <= n2_grid.ColumnCount)
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
            
        }

        private void n2_window_y_ValueChanged(object sender, EventArgs e)
        {
            if (!load_n2_from_file_block)
            {
                int row = Convert.ToInt32(n2_window_y.Value);
                int col = Convert.ToInt32(n2_window_x.Value);
                if (row <= n2_grid.RowCount)
                    n2_grid.RowCount = Convert.ToInt32(n2_window_y.Value);
                else
                {
                    object[] row_new = new object[col];
                    for (int i = 0; i < n2_grid.ColumnCount; i++)
                        row_new[i] = "-";
   //                 for (int i = row-n2_grid.RowCount; i < row; i++)
   //                 {
                        n2_grid.Rows.Add(row_new);
   //                 }
                    for (int i = 0; i < n2_grid.ColumnCount; i++)
                        n2_grid.Rows[row - 1].Cells[i].Value = "-";
                }
            }
            /*int row = Convert.ToInt32(n2_window_y.Value);
            n2_grid.RowCount = row;
            for (int i = 0; i < n2_grid.ColumnCount; i++)
                n2_grid.Rows[row - 1].Cells[i].Value = "-";*/
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
            extra_status_lbl.Text = "Selected symbol: " + e.ClickedItem.Text;
            grid_context_menu_selected_item = e.ClickedItem.Text;
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
            fst = fst.Trim(',');
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
            //string[] funny = { "Don't touch me!", "Why are you do that?", "Don't try to angry me!", "And so..?", "Houston we have a problem" };
            Random random = new Random(System.DateTime.Now.Second);
            MessageBox.Show(st, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int item_idx = m_Game.alphabet.decode(function_entry_was.Text);
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
            {
                function_entry_list.Items[0] = function_entry_list.Items[0].ToString().Remove(ar, len - ar);
                for (int i = 0; i < function_list.Items.Count; i++)
                    function_list.Items[i] = function_list.Items[i].ToString().Remove(ar, len - ar);
            }
            else
                for (int i = len; i < ar; i++)
                {
                    function_entry_list.Items[0] += "0";
                    for (int j = 0; j < function_list.Items.Count; j++)
                        function_list.Items[j] += "0";
                }
            update_was_change_field(ar);
        }

        private void n2_grid_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (n2_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                try
                {

                    if (n2_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "-")
                    {

                        int cell_content = Convert.ToInt32(n2_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                        int size = Convert.ToInt32(n2_window_x.Value) * Convert.ToInt32(n2_window_y.Value);
                        if (cell_content > 63 || cell_content > size)
                        {
                            n2_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                            throw new System.ArgumentException("Value out of range. (1.." + size.ToString());
                        }

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
                    load_n2_from_file_block = true;
                    n2_window_x.Value = n2_fufufu.X;
                    n2_window_y.Value = n2_fufufu.Y;
                    List<string> nasz = new List<string>();
                    nasz = n2_fufufu.Get_description();
                    for (int i = 0; i < n2_fufufu.Y; i++)
                    {
                        object[] row = new object[n2_fufufu.X];
                        for (int x = 0; x < n2_fufufu.X; x++)
                        {

                            int cell = n2_fufufu.Get_decode_description()[i][x];
                            if (cell == -1)
                                row[x] = "-";
                            else
                                row[x] = cell.ToString();
                        }
                        n2_grid.Rows.Add(row);
                    }
                    n2_grid.Rows[n2_fufufu.Get_checked_cell().Y].Cells[n2_fufufu.Get_checked_cell().X].Style.BackColor = Color.LightYellow;
                    n2_cell_selected = n2_fufufu.Get_checked_cell();
                    load_n2_from_file_block = false;

                }
                catch (Exception er)
                {
                    ShowErrorBox(er.Message);
                }
                finally
                {
                    load_n2_from_file_block = false;
                }
            }
        }

        private void panel_ContextMenuStripChanged(object sender, EventArgs e)
        {
            
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                m_bMouseDown = false; 
                symbol_menu.Show(panel, e.Location);
                grid_context_menu_cell_selected = new Point(e.X/s_CellHeight, e.Y/s_CellWidth);
            }
        }

        private void n2_grid_Leave(object sender, EventArgs e)
        {
            List<string> cells = new List<string>();
            for (int x = 0; x < n2_window_x.Value; x++)
            {
                for (int y = 0; y < n2_window_y.Value; y++)
                {
                    string cell = n2_grid.Rows[y].Cells[x].Value.ToString();
                    cells.Add(cell);
                }
            }
            string ret_function_parametrs = "";
            n2_grid_cells = cells;
            foreach (string z in function_parametrs.Text.Split(','))
            {
                if (cells.Contains(z))
                {
                    ret_function_parametrs += z + ",";
                }
            }
            function_parametrs.Text = ret_function_parametrs.Trim(',');
        }

        private void mainfrm_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void mainfrm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            component_move = true;
            component_to_draw = components_list[0];
            //component_show.Size = new Size(component_to_draw.Length * 6, component_to_draw.Length * 6);
            
        }

        private void component_show_Paint(object sender, PaintEventArgs e)
        {
            /*if (component_move)
            {
                Graphics Gr = e.Graphics;
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        if ((component_to_draw[x, y]) == 1)
                        {
                            Rectangle punkt = new Rectangle(x * (100 / 6), y * (100 / 6), 100 / 6, 100 / 6);
                            SolidBrush pedzel = new SolidBrush(s_ColorZajete);
                            Gr.FillRectangle(pedzel, punkt);
                            Gr.DrawRectangle(s_BrushZajete, punkt);
                            //Gr.DrawRectangle(s_BrushZajete, x * s_CellHeight, y * s_CellWidth, s_CellWidth, s_CellHeight);
                        }
                    }
                }
            }*/
        }

        private void mainfrm_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (component_move)
            {
                component_show.Location = new System.Drawing.Point(e.X, e.Y);
                
            }*/
        }

        private void InfoBox(string st)
        {
            MessageBox.Show(st, "Funny info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gliderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /*component_move = true;
            component_to_draw = components_list[0];*/
            InfoBox("Planning in next version");
        }

        private void state_chck_tofile_CheckStateChanged(object sender, EventArgs e)
        {
            if(state_chck_tofile.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    state_path = openFileDialog1.FileName; 
            }
        }

        private void blinkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoBox("Planning in next version");
        }

        private void loadToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InfoBox("Planning in next version");
        }

        private void saveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InfoBox("Planning in next version");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoBox("Krowka is very simple and powerful software.\nYou don't need help");
        }


        private int ticker = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            //bmpsave.Save("screen.bmp",System.Drawing.Imaging.ImageFormat.Bmp);
            InfoBox("Next version");
        }

        private void x(object sender, PaintEventArgs e)
        {

        }

        private void mainfrm_Resize(object sender, EventArgs e)
        {

        }

        private void btnChangeWorldSize_Click(object sender, EventArgs e)
        {
            s_CellsHeight = Convert.ToInt32(worldX.Value);
            s_CellsWidth = Convert.ToInt32(worldY.Value);
            s_CellHeight = 505/s_CellsHeight; //in px
            s_CellWidth = 505/s_CellsWidth; //in px
            m_Game.resize_grid(s_CellsHeight);
            obserwator.resize_world(s_CellsHeight);
            m_start = true;
            m_Timer.Start();
            m_Timer.Stop();
            m_start = false;
            panel.Refresh();
        }

        private void worldX_ValueChanged(object sender, EventArgs e)
        {
            worldY.Value = worldX.Value;
        }


    }
}