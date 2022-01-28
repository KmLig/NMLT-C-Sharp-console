using System;


namespace MaTran
{
    class Program
    {
        static void Hoanvi(ref int a,ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }        
        static int[,] TaoMaTran(string Ghichu)
        {
            Console.WriteLine(Ghichu);
            int N, M;
            Console.WriteLine("Nhap so dong:");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot:");
            M = int.Parse(Console.ReadLine());
            int[,] A = new int[N, M];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.WriteLine($"Nhap A[{i},{j}]:");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return A;
        }
        public static void XuatMaTran(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"{A[i,j]} ");                    
                }
                Console.WriteLine();
            }
        }
        public static int TimGiaTriAmThuHai(int[,] A)
        {
            int row = -1;
            int column = -1;
            int index = -1;            
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                    {
                        row = i;
                        column = j;                        
                        break;
                    }
                } 
                if (row != -1)
                {
                    break;
                }
            }
            if (row >= 0)
            {
                if (column == A.GetLength(1) - 1)
                {
                    for (int i = row + 1; i < A.GetLength(0); i++)
                    {
                        for (int j = 0; j < A.GetLength(1); j++)
                        {
                            if (A[i, j] < 0)
                            {
                                index = A[i, j];
                                return index;
                            }
                        }
                    }
                }
                else if (column < A.GetLength(1) - 1)
                {
                    for (int i = row; i < A.GetLength(0); i++)
                    {
                        for (int j = column + 1; j < A.GetLength(1); j++)
                        {
                            if (A[i, j] < 0)
                            {
                                index = A[i, j];
                                return index;
                            }
                        }
                    }
                }
            }
            return index;
        }
        public static int TimGiaTriAmThuBa(int[,] A)
        {
            int row = -1;
            int column = -1;
            int index = -1;
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                    {
                        row = i;
                        column = j;
                        break;
                    }
                }
                if (row != -1)
                {
                    break;
                }
            }
            if (row >= 0)
            {
                if (column == A.GetLength(1) - 1)
                {
                    for (int i = row + 1; i < A.GetLength(0); i++)
                    {
                        for (int j = 0; j < A.GetLength(1); j++)
                        {
                            if (A[i, j] < 0)
                            {
                                index = A[i, j];
                                return index;
                            }
                        }
                    }
                }
                else if (column < A.GetLength(1) - 1)
                {
                    for (int i = row; i < A.GetLength(0); i++)
                    {
                        for (int j = column + 1; j < A.GetLength(1); j++)
                        {
                            if (A[i, j] < 0)
                            {
                                index = A[i, j];
                                count++;                                
                            }
                            if (count == 2)
                            {
                                return index;
                            }
                        }
                    }
                }
            }
            return index;
        }
        public static bool KiemTraNguyenTo(int a)
        {
            if (a <= 1)
            {
                return false;
            }
            for (int i = 2; i <= a/2; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int TimSoNguyenToThuHai(int[,] A)
        {
            int index = -1;
            int row = -1;
            int column = -1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (KiemTraNguyenTo(A[i, j]))
                    {
                        row = i;
                        column = j;
                        break;
                    }
                }
                if (row != -1)
                {
                    break;
                }
            }
            if (row >= 0)
            {
                if (column == A.GetLength(1) - 1)
                {
                    for (int i = row + 1; i < A.GetLength(0); i++)
                    {
                        for (int j = 0; j < A.GetLength(1); j++)
                        {
                            if (KiemTraNguyenTo(A[i, j]))
                            {
                                index = A[i, j];
                                return index;
                            }
                        }
                    }
                }
                else if (column < A.GetLength(1) - 1)
                {
                    for (int i = row; i < A.GetLength(0); i++)
                    {
                        for (int j = column + 1; j < A.GetLength(1); j++)
                        {
                            if (KiemTraNguyenTo(A[i, j]))
                            {
                                index = A[i, j];
                                return index;
                            }
                        }
                    }
                }
            }
            return index;
        }
        public static void SapXep(int[] A)
        {
            for (int i = 0; i < A.Length -1; i++)
            {
                for (int j = 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        int t = A[i];
                        A[i] = A[j];
                        A[j] = t;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            /*int x, y;
            Console.WriteLine("Nhap x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap y:");
            y = int.Parse(Console.ReadLine());

            //string result = (x > y) ? $"{x} is greater than {y}" : $"{x} is equal to or smaller than {y}";
            Console.WriteLine($"{x}     {y}");
            Hoanvi(ref x,ref y);
            Console.WriteLine($"{x}     {y}");*/
            // Nhap ma tran

            //Xuat ma tran
            /*int[,] A = TaoMaTran("Tao ma tran:");
            XuatMaTran(A);
            int kq = TimSoNguyenToThuHai(A);
            Console.WriteLine(kq);*/
            int n;
            Console.WriteLine("Nhap N:");
            n = int.Parse(Console.ReadLine());
            bool kq = KiemTraNguyenTo(n);
            Console.WriteLine(kq);

        }
    }
}
