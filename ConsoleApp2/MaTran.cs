using System;
using System.Collections.Generic;
using System.Text;

namespace MaTran
{
    class MaTran
    {
        //Bài 315: Viết hàm tìm giá trị lớn nhất trong ma trận số thực
        public static int TimMax(int[,] A)
        {
            int max = A[0, 0];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (max < A[i, j])
                    {
                        max = A[i, j];
                    }
                }
            }
            return max;
        }
        public static int TimMax2(int[,] A)
        {
            int max = A[0, 0];
            int max2 = A[0, 0];
            for(int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (max < A[i, j])
                    {
                        max2 = max;
                        max = A[i, j];                       
                    }
                    else if (max2 < A[i, j])
                    {
                        max2 = A[i, j];
                    }
                }
            }
            return max2;
        }
        //Dem nguyen to
        public static bool KiemTraNguyenTo(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= n/2; i++)
            {
                if (n % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int DemNguyenTo(int[,] A)
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (KiemTraNguyenTo(A[i, j]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        //Bài 318: Viết hàm tính tổng các giá trị âm trong ma trận số thực
        public static int TinhTongAm(int[,] A)
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                    {
                        count += A[i, j];
                    }
                }
            }
            return count;
        }
        public static int TinhTongDuong(int[,] A)
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                    {
                        count += A[i, j];
                    }
                }
            }
            return count;
        }
        public static void HoanVi(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        public static int TinhTichLe(int[,] A)
        {
            int mul = 1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 1)
                    {
                        mul *= A[i, j];
                    }
                }
            }
            return mul;
        
        }
        //Tong dong k
        public static int TongDongK(int[,] A, int k)
        {
            int sum = A[k,0];
            for (int j = 1; j < A.GetLength(1); j++)
            {
                sum += A[k, j];
            }
            return sum;
        }
        public static int TongCotK(int[,] A, int k)
        {
            int sum = A[0, k];
            for (int i = 1; i < A.GetLength(0); i++)
            {
                sum += A[i, k];
            }
            return sum;
        }
        public static int TinhTongBien(int[,] A)
        {
            int sum = 0;
            sum += TongDongK(A, 0) + TongDongK(A, A.GetLength(0) - 1);
            sum+= TongCotK(A, 1)
        }
    }
}
