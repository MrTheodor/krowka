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
            m_siatka = new bool[X, Y];
            for (int x = 0; x < X; x++)
            {
                for (Int32 y = 0; y < Y; y++)
                    m_siatka[x, y] = false;
            }
            m_siatka[5, 5] = true;
            m_siatka[5, 6] = true;
            m_siatka[5, 7] = true;
            m_siatka[6, 5] = true;
            m_siatka[6, 6] = true;
            m_siatka[6, 7] = true;

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
        public bool GetCell(int ix, int iy)
        {
            if (ix >= X || ix < 0 || iy >= Y || iy < 0)
                return false;
            else
                return m_siatka[ix, iy];
        }
        public void SetCell(int ix, int iy, bool bAlive)
        {
            if (ix >= X || ix < 0 || iy >= Y || iy < 0)
                return;
            else
                m_siatka[ix, iy] = bAlive;
        }
        // state
        public void next_state()
        {
            bool[,] m_siatka_new = new bool[X, Y];
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                    m_siatka_new[x, y] = false;
            }
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    int sasiedzi = 0;
                    bool komorka = m_siatka[x, y];
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
                        if (GetCell(cor_x, cor_y))
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
        public bool[,] current_state() {
            return m_siatka;
        }
        public void load_state(bool[,] siatka)
        {
            m_siatka = siatka;
        }
        //other
        private bool check_cell(int sasiedzi, bool stan_komorki)
        {
            bool ret = false;
            if (function_description.ContainsKey(sasiedzi)) {
                if (stan_komorki)
                {
                    if (function_description[sasiedzi][0] == 1)
                        ret = true;
                }
                else
                {
                    if (function_description[sasiedzi][1] == 1)
                        ret = true;
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
                    SetCell(x, y, false);
            }

        }
        public void randomize()
        {
            Random random = new Random(System.DateTime.Now.Second);
            for (Int32 x = 0; x < X; x++)
            {
                for (Int32 y = 0; y < Y; y++)
                    SetCell(x, y, random.Next(2) == 1);
            }
        }
        
        // a tu co robimy jak sie komorka zmieni
        /*public event CellChangedCallback CellChanged;
        public delegate void CellChangedCallback(Object sender, int ix, int iy);*/

        // wymiary siatki, w sumie to ustalone, 500x500
        private int m_ix;
        private int m_iy;
        // siatka
        private bool[,] m_siatka;
    }

}
