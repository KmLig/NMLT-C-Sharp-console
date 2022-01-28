using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    class MaTran
    {
        //Nhap mang 2 chieu
        public static int[,] NhapMaTran(string Ghichu)
        {
            int[,] A;
            int n, m;
            Console.WriteLine(Ghichu);
            Console.WriteLine("Nhap so dong:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot:");
            m = int.Parse(Console.ReadLine());
            A = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Nhap A[{i},{j}]");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return A;
        }
        public static int[,] Nhapmt(string Ghichu)
        {
            Console.WriteLine(Ghichu);
            int N, M;
            Console.WriteLine("Nhap so cot");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so dong:");
            M = int.Parse(Console.ReadLine());
            int[,] A = new int[N,M];
            for (int i = 0; i <A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.WriteLine($"Nhap A[{i},{j}]");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return A;
        }
        public static void Xuatmt(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j]);                    
                }
                Console.WriteLine();
            }
        }
        public static void XuatMaTran(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"{A[i,j]}   ");
                }
                Console.WriteLine();
            }
        }
        public static int TinhTongMaTran(int[,] A)
        {
            int s = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    s += A[i, j];
                }
            }
            return s;
        }
        public static int TimMax(int[,] A)
        {
            int max = A[0, 0];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                    }
                }
            }
            return max;
        }
        public static int DemSoNguyenTo(int[,] A)
        {
            int dem = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_SoNguyen.SoNguyenToBai31(A[i, j]) == true)
                    {
                        dem++;
                    }
                }
            }
            return dem;
        }
        public static double TrungBinhCongDuong(int[,] A)
        {
            int count = 0;
            int s = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                    {
                        s += A[i, j];
                        count++;
                    }
                }
            }
            return 1.0*s / count;
        }
        public static double TrungBinhCongAm(int[,] A)
        {
            int count = 0;
            int s = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                    {
                        s += A[i, j];
                        count++;
                    }
                }
            }
            if (count > 0)
            {
                return 1.0 * s / count;
            }
            return 0;
            
        }
        //Phan tu nho nhat tren cot k
        public static int GTMinCotK(int[,] A, int k)
        {
            int min = A[0, k];
            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, k] < min)
                {
                    min = A[i, k];
                }
            }
            return min;
        }
        public static int TinhTongDongk(int[,] A, int k)
        {
            int s = A[k, 0];
            for (int j = 1; j < A.GetLength(1); j++)
            {
                s += A[k, j];
            }
            return s;
        }
        public static int TinhTichDuongCotk(int[,] A, int k)
        {
            int t = A[0, k];
            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, k] > 0)
                {
                    t *= A[i, k];
                }
            }
            return t;
        }
        public static int TinhTongBien(int[,] A)
        {
            int s = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                s += A[i,0];
                s += A[i, (A.GetLength(0) - 1)];
            }
            for (int j = 1; j < A.GetLength(1); j++)
            {
                s += A[0, j];
                s += A[(A.GetLength(0) - 1) - 2, j];
            }
            return s;
        }
        public static int ViTriMinCotK(int[,] A, int k)
        {
            int index = 0;
            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, k] < A[index, k])
                {
                    index = i;
                }
            }
            return index;
        }
        public static int MaxDongK(int[,] A, int k)
        {
            int max = A[k, 0];
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[k, j] > max)
                {
                    max = A[k, j];
                }
            }
            return max;
        }
        public static bool KiemTraTangdan(int[,] A)
        {
            int pre = A[0, 0];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < pre)
                    {
                        return false;
                    }
                    pre = A[i, j];
                }
            }
            return true;
        }
        public static int DemPhanTu(int[,] A, int k)
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == k)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
