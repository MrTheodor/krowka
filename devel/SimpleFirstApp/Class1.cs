using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFirstApp
{
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
        }
        public int Y
        {
            get { return m_y; }
        }
        private int m_x;
        private int m_y;
    }
    
    public class automat
    {
        // bedziemy w tym przechowywac funkcje
        private Dictionary<int,int[]> function_description = new Dictionary<int,int[]>(); 

        private static Point[] s_PointSasiedzi = {	new Point( -1, -1 ), 
														new Point( 0, -1 ),
														new Point( 1, -1 ),
														new Point( -1, 0 ),
														new Point( 1, 0 ),
														new Point( -1, 1 ),
														new Point( 0, 1 ),
														new Point( 1, 1 )
													};
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
            /*m_siatka[5, 5] = 1;
            m_siatka[5, 6] = 1;
            m_siatka[5, 7] = 1;
            m_siatka[6, 5] = 1;
            m_siatka[6, 6] = 1;
            m_siatka[6, 7] = 1;*/

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
                    foreach (Point point in s_PointSasiedzi)
                    {
                        int cor_x = x + point.X;
                        int cor_y = y + point.Y;
                        // cholerne warunki brzegowe
                        if (cor_x < 0)
                        {
                            cor_x = X - 1;
                        }
                        if (cor_y < 0)
                        {
                            cor_y = Y - 1;
                        }
                        if (cor_x >= X)
                        {
                            cor_x = 0;
                        }
                        if (cor_y >= Y)
                        {
                            cor_y = 0;
                        }
                        if (GetCell(cor_x, cor_y)==1)
                            sasiedzi++;
                    }
                    //a teraz przeksztalcenie na poziomie funkcji
                    /* it was static game of life
                    if (komorka){
                        if (sasiedzi == 3 || sasiedzi == 2){
                            m_siatka_new[x,y] = true;
                        }
                    } else if (sasiedzi == 3 ) {
                        m_siatka_new[x,y] = true;
                    }*/
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
                if (stan_komorki == 1)
                {
                    if (function_description[sasiedzi][0] == 1)
                        ret = 1;
                }
                else
                {
                    if (function_description[sasiedzi][1] == 1)
                        ret = 1;
                }
            }
            return ret;
        }
        public void load_function(string[] funct_descr)
        {
            Dictionary<int,int[]> act_function_description = new Dictionary<int,int[]>();
            foreach (string line in funct_descr)
            {
                string if_0, if_1;
                if_1 = line[3].ToString();
                if_0 = line[4].ToString();
                int[] result = new int[2];
                result[0] = Convert.ToInt32(if_1);
                result[1] = Convert.ToInt32(if_0);
                act_function_description.Add(Convert.ToInt32(line[0].ToString()),result);
            }
            function_description = act_function_description;
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
        // siatka
        private int[,] m_siatka;
    }

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
