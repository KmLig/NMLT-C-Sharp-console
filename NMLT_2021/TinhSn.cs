using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    class TinhSn
    {
        public static int TinhTongSn(int N)
        {
            //Bài 1: Tính S(n) = 1 + 2 + 3 + … + n            
            int i = 1;
            int S = 0;
            while(i <= N)
            {
                S += i;
                i++;
            }
            return S;
        }
        public static int TinhTongSnBai2(int N)
        {
            int i = 1;
            int S = 0;
            while(i <= N)
            {
                S += i * i;
                i++;
            }
            return S;
        }
        public static double TinhTongSnBai3(int N)
        {
            double S = 0;
            for(int i = 1; i <= N; i++)
            {
                S += (1.0 / i);
            }
            return S;
        }
        public static double TinhTongSnBai4(int N)
        {
            double S = 0;
            for(int i = 1; i <= N; i++)
            {
                S += 1.0 / (2 * i);                
            }
            return S;
        }
        public static double TinhTongSnBai5(int N)
        {
            double S = 0;
            for(int i = 1; i <= N; i++)
            {
                S += (1.0 / (2 * i + 1));
            }
            return S;
        }
        public static double TinhTongSnBai6(int N)
        {
            double S = 0;
            for(int i = 1; i <= N; i++)
            {
                S += 1.0 / (i * (i + 1));
            }
            return S;
        }
        public static double TinhTongSnBai7(int N)
        {
            double S = 0;
            for(int i = 1; i <= N; i++)
            {
                S += (1.0 * i) / (i + 1);
            }
            return S;
        }
        public static double TinhTongSnBai8(int N)
        {
            double S = 0;
            for(int i = 1; i <= N; i++)
            {
                S += (2.0 * i + 1) / (2 * i + 2);
            }
            return S;
        }
        public static int TinhTnBai9(int N)
        {
            int T = 1;
            for(int i = 1; i <= N; i++)
            {
                T *= i;
            }
            return T;
        }
        public static int TinhxmuNBai10(int x, int N)
        {
            int result = 1;
            for(int i = 1; i <= N; i++)
            {
                result *= x;
            }
            return result;
        }
        public static int TinhSnBai11(int N)
        {
            int T = 1;
            int S = 0;
            for(int i = 1; i <= N; i++)
            {
                T *= i;
                S += T;
            }
            return S;
        }
        public static int TinhSnBai12(int x, int N)
        {
            int T = 1;
            int S = 0;
            for(int i = 1; i <= N; i++)
            {
                T *= x;
                S += T;
            }
            return S;
        }
        public static int TinhTongSnBai13(int x, int N)
        {
            int T = 1;
            int S = 0;
            for(int i = 1; i <= N; i++)
            {
                T *= x * x;
                S += T;
            }
            return S;
        }
        public static int TinhTongSnBai14(int x, int N)
        {
            int T = x;
            int S = 0;
            for(int i = 1; i <= N; i++)
            {
                T *= x * x;
                S += T;
            }
            return S;
        }
        public static double TinhTongSnBai15(int N)
        {
            //Bài 15: Tính S(n) = 1 + 1 / 1 + 2 + 1 / 1 + 2 + 3 + …..+1 / 1 + 2 + 3 + …. +N
            int M = 0;
            double S = 0;
            for(int i = 1; i <= N; i++)
            {
                M += i;
                S += 1.0 / M;
            }
            return S;
        }
        public static double TinhTongSnBai16(int x, int N)
        {
            int T = 1;
            int M = 0;
            double S = 0;
            for(int i = 1; i <= N; i++)
            {
                T *= x;
                M += i;
                S += (1.0 * T) / M;
            }
            return S;
        }
        public static int TinhGiaiThua(int N)
        {
            int GT = 1;
            for(int i = 1; i <= N; i++)
            {
                GT *= i;
            }
            return GT;
        }
        public static int TinhGiaiThua2n(int N)
        {            
            int GT = 1;
            for(int i = 1; i <= N; i++)
            {
                GT *= (2 * i) * (2 * i - 1);
            }
            return GT;
        }
        public static int TinhGiaiThua2n1(int N)
        {
            int GT = 1;
            for(int i = 1; i <= N; i++)
            {
                GT *= (2 * i + 1) * (2 * i);
            }
            return GT;
        }
        public static int TinhGiaiThua2n2(int N)
        {
            int GT = 2;
            for(int i = 1; i <= N; i++)
            {
                GT *= (2 * i + 2) * (2 * i + 1);
            }
            return GT;
        }
        public static double TinhTongSnBai17(int x, int N)
        {
            int T = 1;
            int GT;
            double S = 0;
            for(int i = 1; i <= N; i++)
            {
                T *= x;
                GT = TinhGiaiThua(i); //hoặc gán GT = 1 & *= i trong vòng lặp
                S += (1.0 * T) / GT;
            }
            return S;
        }
        public static double TinhTongSnBai18(int x, int N)
        {
            int T = 1;
            int GT;
            double S = 1;
            for(int i = 1; i <= N; i++)
            {
                T *= x * x;
                GT = TinhGiaiThua2n(i);
                S += (1.0 * T) / GT;
            }
            return S;
        }
        public static double TinhTongSnBai19(int x, int N)
        {
            int T;
            int GT;
            double S = 1 + x;
            for (int i = 1; i <= N; i++)
            {
                T = TinhxmuNBai10(x, 2*i+1); // hoặc đặt T = x & *= x*x trong vòng lặp
                GT = TinhGiaiThua2n1(i);
                S += 1.0 * T / GT;
            }
            return S;
        }
    }
}
