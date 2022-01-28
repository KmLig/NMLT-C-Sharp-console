using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    class SoNguyenTo
    {
        public static bool KiemTraSoNguyenTo(int N)
        {
            if (N <= 1)
            {
                return false;
            }
            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int TinhTongNguyenTo(int N)
        {
            int S = 0;
            for (int i = 2; i <= N; i++)
            {
                if (KiemTraSoNguyenTo(i) == true)
                {
                    S += i;
                }
            }
            return S;
        }
        public static int GiaTienSkill(int a)
        {
            int S;
            int T = 1;            
            for(int i = 1; i < a; i++)
            {
                T *= 3;                
            }
            S = T * 45000;
            return S;
        }
    }
}
