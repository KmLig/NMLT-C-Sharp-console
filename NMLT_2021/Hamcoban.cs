using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    class Hamcoban
    {
        public static int F(int x)
        {
            int kq = 2 * x + 1;
            return kq;
        }
        public static int TinhS1(int N)
        {
            int S = 0;
            for(int i = 1; i <= N; i++)
            {
                S += i;                
            }
            return S;
        }
        public static int TinhS2(int N)
        {
            int S = 0;
            for(int i = 1; i <= N; i++)
            {
                S += i * i;
            }
            return S;
        }
        public static int TimMin(int a, int b)
        {
            if(a < b)
            {
                return a;
            }
            return b;
            
        }
        public static int TimSoNhoNhattrong3So(int a, int b, int c)
        {
            int min = a;
            if (min > b)
            {
                min = b;
            }
            else if (min > c)
            {
                min = c;
            }
            return min;            
        }
        public static int TinhGiaiThua(int N)
        {
            int T = 1;
            for (int i = 2; i <= N; i++)
            {
                T *= i;                
            }
            return T;
        }
        public static int TinhTongS11(int N)
        {
            int S = 0;
            for(int i = 2; i <= N; i++)
            {
                S += TinhGiaiThua(i);
            }
            return S;
        }
    }
}
