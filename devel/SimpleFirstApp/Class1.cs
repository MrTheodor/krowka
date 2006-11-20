/*
 * Author: Jakub Krajniak (c) 2006
 * Licence: GPL
 * Version: 1.5
 * 
 * 2D celluar automate
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFirstApp
{   
    /// <summary>
    ///  Represent point
    /// </summary>
    public class Point
    {
        public Point(int x, int y)
        {
            m_x = x;
            m_y = y;
        }
        public int X
        {
            get { return m_x; }
            set { m_x = value; }
        }
        public int Y
        {
            get { return m_y; }
            set { m_y = value; }
        }
        private int m_x;
        private int m_y;
        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }
    }
    /// <summary>
    ///  It's for Alphabet for celluar automate
    /// </summary>
    public class Alphabet
    {
        private Dictionary<int, abc_pole> m_alphabet = new Dictionary<int, abc_pole>();
        private Dictionary<string, int> m_revers = new Dictionary<string, int>();
        private int last_key = 0;
        private const string alp = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz|+";
        public Alphabet(int args)
        {
            Add(new abc_pole(System.Drawing.Color.White, "0"));
            Add(new abc_pole(System.Drawing.Color.Lime, "1"));
            System.Array colorsArray = Enum.GetValues(typeof(System.Drawing.KnownColor));
            System.Drawing.KnownColor[] allColors = new System.Drawing.KnownColor[colorsArray.Length];

            Array.Copy(colorsArray, allColors, colorsArray.Length);

            for (int i = 2; i < args; i++)
            {
                Add(new abc_pole(System.Drawing.Color.FromName(allColors[i + 30].ToString()), alp[i].ToString()));
            }
        }
        public Alphabet()
        {
        }
        public abc_pole Get(int idx)
        {
            abc_pole pole = new abc_pole();
            if (m_alphabet.ContainsKey(idx))
                pole =  m_alphabet[idx];
            return pole;
        }
        public string code(int idx)
        {
            return alp[idx].ToString();
        }
        public int decode(string idx)
        {
            return alp.IndexOf(idx);
        }
        public int Get(string st)
        {
            int ret = -1;
            if (m_revers.ContainsKey(st))
                ret = m_revers[st];
            return ret;
        }
        public int Add(abc_pole pole)
        {
            bool finded = false;
            int finded_symbol = 0;
            int number_added = 0;
            foreach (KeyValuePair<int, abc_pole> key in m_alphabet)
            {
                if (key.Value.symbol == pole.symbol)
                {
                    finded = true;
                    finded_symbol = key.Key;
                }
            }
            if (finded)
            {
                m_alphabet[finded_symbol] = pole;
                number_added = finded_symbol;
            }
            if (!finded)
            {
                if (last_key <= 63 && (!m_alphabet.ContainsValue(pole)) && (!find_color(pole)))
                {
                    m_alphabet.Add(last_key, pole);
                    number_added = last_key;
                    m_revers.Add(pole.symbol, last_key);
                    last_key++;
                }
            }
            return number_added;
        }

        public bool find_color(abc_pole pole)
        {
            bool ret = false;
            foreach (KeyValuePair<int, abc_pole> key in m_alphabet)
            {
                if (key.Value.color == pole.color)
                    ret = true;
            }
            return ret;
        }

        public bool Remove(int idx)
        {
            bool ret = false;
            if (m_alphabet.ContainsKey(idx))
            {
                m_alphabet.Remove(idx);
                last_key--;
                ret = true;
            }
            return ret;
        }
        public void Remove(abc_pole pole)
        {
            if (!m_alphabet.ContainsValue(pole))
                foreach (KeyValuePair<int, abc_pole> key in m_alphabet)
                    if (key.Value == pole)
                    {
                        m_alphabet.Remove(key.Key);
                        last_key--;
                    }
        }

        public Dictionary<int, abc_pole> All()
        {
            return m_alphabet;
        }
        public List<string> All_symbols()
        {
            List<string> temp_list = new List<string>();
            foreach(string key in m_revers.Keys){
                temp_list.Add(key);
            }
            return temp_list;
        }
    }
    /// <summary>
    /// Class for parsing N2 file
    /// </summary>
    public class N2_file
    {
        public N2_file(string[] parse_file, Alphabet alp, List<int> arg_list)
        {
            load_n2_file(parse_file);
            my_alp = alp;
            my_arg_list = arg_list;
        }

        public N2_file(string[] parse_file)
        {
            load_n2_file(parse_file);        
        }

        public void load_n2_file(string[] file) // load file and parse it
        {
            my_parse_file = file;
            //try
            //{
                if (file[0] != "N2")
                    throw new System.ArgumentException("Invalid N2 file");
                my_n2_x = Convert.ToInt16(my_parse_file[1].Split(' ')[1]);
                my_n2_y = Convert.ToInt16(my_parse_file[1].Split(' ')[0]);
                my_neigb = Convert.ToInt16(my_parse_file[1].Split(' ')[2]);
                int x = Convert.ToInt16(my_parse_file[2].Split(' ')[1]);
                int y = Convert.ToInt16(my_parse_file[2].Split(' ')[0]);
                my_check_cell = new Point(x, y);
            //}
            //catch (Exception er)
            //{
            //    throw er;
            //}
        }

        public Point Get_checked_cell()
        {
            return my_check_cell;
        }

        public void Set_checked_cell(Point p)
        {
            my_check_cell = p;
        }

        public List<string> Get_description()
        {
            List<string> ret = new List<string>();
            for (int i = 3; i < my_n2_y + 3; i++)
            {
                string line = my_parse_file[i];
                ret.Add(line);
            }
            return ret;
        }

        public List<string> Get_decode_description()
        {
            List<string> ret = new List<string>();
            Alphabet m_alp = new Alphabet();
            foreach (string line in Get_description())
            {
                string ret_line = "";
                foreach (char znak in line)
                {
                    if (znak != '-')
                        ret_line += m_alp.decode(znak.ToString()).ToString();
                    else
                        ret_line += "-";
                }
                ret.Add(line);
            }
            return ret;
        }

        public int X
        {
            get { return my_n2_x; }
            set { my_n2_x = value; }
        }

        public int Y
        {
            get { return my_n2_y; }
            set { my_n2_y = value; }
        }

        public int Neigbours
        {
            get { return my_neigb; }
            set { my_neigb = value; }
        }

        public List<Point> Neigbours_points()
        {
            List<Point> ret = new List<Point>();
            List<int[]> ret_Window = new List<int[]>();
            int p_y = 0;
            foreach(string line in Get_description())
            {
                int p_x = 0;
                int[] ret_tab = new int[my_n2_x];
                foreach (char znak in line)
                {
                    if (znak != '-')
                    {
                        int arg = my_alp.decode(znak.ToString());
                        ret_tab[p_x] = arg;
                        if (my_arg_list.Contains(arg))
                        {
                            int point_nr = Convert.ToInt32(znak.ToString());
                            Point desc_cell = new Point(p_x, p_y);
                            Point insert_point = new Point(0, 0);
                            insert_point = desc_cell - my_check_cell;
                            insert_point.Y = insert_point.Y * (-1);
                            ret.Add(insert_point);
                        }
                    }
                    else
                    {
                        ret_tab[p_x] = -1;
                    }
                    p_x++;
                }
                ret_Window.Add(ret_tab);
                p_y++;
            }
            return ret;
        }
        public List<string> GetFile()
        {
            List<string> ret = new List<string>();
            ret.Add("N2");
            ret.Add(my_n2_y.ToString() + " " + my_n2_x.ToString() + " " + my_neigb.ToString());
            ret.Add(my_check_cell.Y.ToString() + " " + my_check_cell.X.ToString());
            foreach (int[] ls in Window)
            {
                string line = "";
                foreach (int i in ls)
                {
                    if (i == -1)
                        line += "-";
                    else
                        line += my_alp.Get(i).symbol;
                }
                ret.Add(line);
            }       
            return ret;
        }

        public void PutWindow(List<int[]> ls)
        {
            Window = ls;
        }

        public List<int[]> GetWindow()
        {
            return Window;
        }

        private int my_n2_x;
        private int my_n2_y;
        private int my_neigb;
        private Point my_check_cell;
        private Alphabet my_alp;
        private string[] my_parse_file;
        private List<int> my_arg_list;
        private List<int[]> Window;
    }

    public class FQT
    {
        public FQT()
        {
        }
        public List<string> parse_file(string[] file) //parsing file
        {
            int counter = 0;
            List<string> ret = new List<string>();
            try
            {
                foreach (string line in file)
                {
                    if (counter == 0)
                        if (line != "FQT")
                            throw new System.ArgumentException("Invalid format, can't parse it");
                    if (counter == 1)
                    {
                        my_argument_count = Convert.ToInt32(line.Split(' ')[0]);
                        my_alphabet_count = Convert.ToInt32(line.Split(' ')[1]);
                    }
                    if (counter == 2)
                        my_argument_list = line.Split(',');
                    if (counter > 2)
                        ret.Add(line);
                    counter++;
                }
                return ret;
            }
            catch (Exception er)
            {
                //throw new System.ArgumentException("Invalid format, can't parse it"+er.Message);
                throw;
            }
        }
        public string[] argument_list
        {
            get { return my_argument_list; }
        }
        public int argument_count
        {
            get { return argument_count; }
        }
        public int alphabet_count
        {
            get { return alphabet_count; }
        }
        private string[] my_argument_list;
        private int my_argument_count;
        private int my_alphabet_count;
    }

    public struct abc_pole
    {
        public System.Drawing.Color color;
        public string symbol;
        public abc_pole(System.Drawing.Color m_color, string m_symbol)
        {
            color = m_color;
            symbol = m_symbol;
        }
        public static bool operator ==(abc_pole a, abc_pole b)
        {
            if ((a.color == b.color) && (a.symbol == b.symbol))
                return true;
            else
                return false;
        }
        public static bool operator !=(abc_pole a, abc_pole b)
        {
            if ((a.color != b.color) || (a.symbol != b.symbol))
                return true;
            else
                return false;
        }
    };
    /// <summary>
    ///  This class is represent celluar automate
    /// </summary>
    public class automat
    {
        // bedziemy w tym przechowywac funkcje
        private Dictionary<int,int[]> function_description = new Dictionary<int,int[]>(); 
        // sasiedztwo jakies uniwersalne
        private List<Point> s_neighbours_n2 = new List<Point>();

        //nasz alfabet
        public Alphabet alphabet;
        public automat( int ix, int iy)
        {
            m_ix = ix;
            m_iy = iy;
            m_siatka = new int[X, Y];
            for (int x = 0; x < X; x++)
            {
                for (Int32 y = 0; y < Y; y++)
                    m_siatka[x, y] = 0;
            }
        }
        // zmienne obiekty, jak w pythonie
        public int X
        {
            get { return m_ix; }
        }

        public int Y
        {
            get { return m_iy; }
        }

        public int argout
        {
            get { return my_argout; }
        }
        

        // komorki przydaje sie ustawiac:
        public int GetCell(int ix, int iy)
        {
            if (ix >= X || ix < 0 || iy >= Y || iy < 0)
                return 0;
            else
                return m_siatka[ix, iy];
        }

        public void SetCell(int ix, int iy, int stan)
        {
            if (ix >= X || ix < 0 || iy >= Y || iy < 0)
                return;
            else
                m_siatka[ix, iy] = stan;
        }
        // state
        public void next_state()
        {
            int[,] m_siatka_new = new int[X, Y];
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                    m_siatka_new[x, y] = 0;
            }
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    int sasiedzi = 0;
                    int komorka = m_siatka[x, y];
                    //liczymy sasiadow 

                    foreach (Point point in s_neighbours_n2)
                    {
                        int cor_x = x + point.X;
                        int cor_y = y + point.Y;
                        // cholerne warunki brzegowe
                        if (cor_x < 0)
                            cor_x = X + point.X;
                        if (cor_y < 0)
                            cor_y = Y + point.Y;
                        if (cor_x >= X)
                            cor_x = cor_x % X;
                        if (cor_y >= Y)
                            cor_y = cor_y % Y;

                        sasiedzi += GetCell(cor_x, cor_y);

                    }

                    m_siatka_new[x, y] = check_cell(sasiedzi, komorka);
                }
            }
            m_siatka = m_siatka_new;
        }
        public int[,] current_state() {
            return m_siatka;
        }

        public void load_state(int[,] siatka)
        {
            m_siatka = siatka;
        }
        // resizing world, puting old grid on the center of new grid
        public void resize_grid(int world_size)
        {
            if (world_size >= X)
            {
                int[,] tmp_siatka = new int[world_size, world_size];
                int center = world_size / 2;
                for (int y = 0; y < Y; y++)
                    for (int x = 0; x < X; x++)
                    {
                        tmp_siatka[x + (center / 2), y + (center / 2)] = m_siatka[x, y];
                    }
            }
        }

        //--------other
        private int check_cell(int sasiedzi, int stan_komorki)
        {
            int ret = 0;
            if (function_description.ContainsKey(sasiedzi)) {
                ret = function_description[sasiedzi][stan_komorki];
            }
            return ret;
        }

        /// <summary>
        ///  Loading function and description about N2
        /// </summary>
        public void load_function(string[] funct_descr,string[] n2)
        {
            Dictionary<int,int[]> act_function_description = new Dictionary<int,int[]>();
            int counter = 0;
            List<int> arguments = new List<int>();
            int arg_size = 0;
            int arg_out, arg_int;
            // reading fqt function
            foreach (string line in funct_descr)
            {
                if (counter == 1)
                {
                    arg_size = Convert.ToInt32(line.Split(' ')[0]);
                    arg_out = Convert.ToInt32(line.Split(' ')[1]);
                    my_argout = arg_out;
                    alphabet = new Alphabet(arg_out);
                }
                if(counter == 2)
                {
                    foreach (string znak in line.Split(','))
                    {
                        arguments.Add(alphabet.decode(znak));
                    }
                }
                if (counter > 2)
                {
                    string[] line_strip = line.Split(':');
                    int neigbour = Convert.ToInt32(line_strip[0]);
                    int[] result = new int[my_argout];
                    int m_counter = 0;
                    foreach (char symbol in line_strip[1].Trim())
                    {
                        if(m_counter<my_argout)
                            result[m_counter] = alphabet.Get(symbol.ToString());
                        m_counter++;
                    }
                    act_function_description.Add(neigbour, result);
                }
                counter++;
            }
            
            function_description = act_function_description;
            N2_file n2_file = new N2_file(n2, alphabet, arguments);
            s_neighbours_n2 = n2_file.Neigbours_points();
        }



        public void reset()
        {
            for (Int32 x = 0; x < X; x++)
            {
                for (Int32 y = 0; y < Y; y++)
                    SetCell(x, y, 0);
            }

        }
        public void randomize()
        {
            Random random = new Random(System.DateTime.Now.Second);
            for (Int32 x = 0; x < X; x++)
            {
                for (Int32 y = 0; y < Y; y++)
                    SetCell(x, y, random.Next(2));
            }
        }
        
        // a tu co robimy jak sie komorka zmieni
        /*public event CellChangedCallback CellChanged;
        public delegate void CellChangedCallback(Object sender, int ix, int iy);*/

        // wymiary siatki, w sumie to ustalone, 500x500
        private int m_ix;
        private int m_iy;
        private int my_argout;
        // siatka
        private int[,] m_siatka;
    }
    /// <summary>
    /// Class that defined local observer.
    /// </summary>
    public class LocalObservers
    {
        public LocalObservers(int world_size)
        {
            myWorld_size = world_size; // size of world
            myGridSize = world_size - 1; // size of grid
            myStateCounter = (myWorld_size / 2);
            myWorld_states.Add(new int[myWorld_size, myWorld_size]);
            for (int i = 0; i < myStateCounter; i++)
            {
                myWorld_states.Add(new int[myWorld_size, myWorld_size]);
            }
            act_state = new int[myWorld_size, myWorld_size];
        }

        public void reset()
        {
            myWorld_states.Clear();
            for (int i = 0; i < myStateCounter; i++)
            {
                myWorld_states.Add(new int[myWorld_size, myWorld_size]);
            }
        }

        public void push_state(int[,] state)
        {
            List<int[,]> tmp = new List<int[,]>();
            tmp.Add(state);
            tmp.AddRange(myWorld_states.GetRange(0,myWorld_states.Count - 1));
            myWorld_states = tmp;
            current_state();
        }
        public void add_observer(Point punkt)
        {
            if (current_observer == 1)
                myLocalObservers[0] = punkt;
            if (!myLocalObservers.Contains(punkt))
            {
                myLocalObservers.Add(punkt);
                current_observer = 1;
            }
        }
        public void set_observer(int idx)
        {
            current_observer = idx;
        }
        private void current_state()
        {
            if (current_observer != 0)
            {
                Point pos_observer = myLocalObservers[current_observer-1];
                int[,] ret = new int[myWorld_size, myWorld_size];
                for (int i = myStateCounter; i >= 0; i=i-light_speed)
                    for (int x = pos_observer.X - i; x < pos_observer.X + i; x++)
                        for (int y = pos_observer.Y - i; y < pos_observer.Y + i; y++)
                        {
                            int cor_x = x;
                            int cor_y = y;
                            if (x < 0)
                                cor_x = x + myWorld_size-1;
                            if (y < 0)
                                cor_y = y + myWorld_size-1;
                            if (x > myGridSize)
                                cor_x = x % myWorld_size;
                            if (y > myGridSize)
                                cor_y = y % myWorld_size;
                            ret[cor_x, cor_y] = myWorld_states[i][cor_x, cor_y];
                        }
                act_state = ret;
            }
            else
            {
                act_state = myWorld_states[0];
            }

        }
        public int GetCell(int ix, int iy)
        {
            if (ix > myWorld_size  || ix < 0 || iy >= myWorld_size || iy < 0)
                return 0;
            else
                return act_state[ix, iy];
        }
        public void change_observer(int observer)
        {
            current_observer = observer;
        }
        public void set_speed(int speed)
        {
            if (speed<myStateCounter)
                light_speed = speed;
        }
        public Point get_observer()
        {
            if (current_observer != 0)
                return myLocalObservers[0];
            else
                return new Point(0, 0);
        }
        public void change_position(Point p)
        {
            if (current_observer != 0)
                myLocalObservers[0] = p;
        }

        public int get_current_observer()
        {
            return current_observer;
        }
        private int myWorld_size;
        private int myStateCounter;
        private int myGridSize;
        private int light_speed = 1;
        private int current_observer=0; // 0 - for god ;)
        private int[,] act_state;
        private static List<int[,]> myWorld_states = new List<int[,]>();
        private static List<Point> myLocalObservers = new List<Point>();
    }
}
