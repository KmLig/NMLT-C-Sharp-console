using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapCuoiKy
{
    public struct HOCSINH
    {
        public string MaHocSinh;
        public string TenHocSinh;
        public double DiemToan;
        public double DiemVan;
    }
    public struct LOPHOC
    {
        public string MaLopHoc;
        public HOCSINH[] DanhSach;
    }

    class Program
    {
        public static int[,] NhapMaTran(string ghiChu)
        {
            int[,] A;
            int row, col;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap so dong:");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot:");
            col = int.Parse(Console.ReadLine());
            A = new int[row,col];
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
                    Console.Write($"{A[i,j]}  ");
                }
                Console.WriteLine();
            }
        }
        public static double[,] NhapMaTranSoThuc(string ghiChu)
        {
            double[,] A;
            int row, col;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap so dong:");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot:");
            col = int.Parse(Console.ReadLine());
            A = new double[row, col];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.WriteLine($"Nhap A[{i},{j}]:");
                    A[i, j] = double.Parse(Console.ReadLine());
                }
            }
            return A;
        }
        public static void XuatMaTranSoThuc(double[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.WriteLine($"{A[i,j]}  ");
                }
                Console.WriteLine();
            }
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
        public static int TimMax2(int[,] A)
        {
            int max = A[0, 0];
            int max2 = max;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i,j] > max)
                    {
                        max2 = max;
                        max = A[i, j];
                    }
                    if (A[i,j] < max && A[i,j] > max2)
                    {
                        max = A[i, j];
                    }
                }
            }
            return max2;
        }
        public static int TimMin(int[,] A)
        {
            int min = A[0, 0];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i,j] < min)
                    {
                        min = A[i, j];
                    }
                }
            }
            return min;
        }
        public static int TimMin2(int[,] A)
        {
            int min = A[0, 0];
            int min2 = min;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < min)
                    {
                        min2 = min;
                        min = A[i, j];
                    }
                    if (A[i, j] > min && A[i,j] < min2)
                    {
                        min2 = A[i, j];
                    }
                }
            }
            return min2;
        }
        public static bool KiemTraNguyenTo(int n)
        {
            for (int i = 0; i <= n/2; i++)
            {
                if (n%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int DemNguyenToMaTran(int[,] A)
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
        public static int TinhTongAm(int[,] A)
        {
            int sum = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i,j] < 0)
                    {
                        sum += A[i, j];
                    }
                }
            }
            return sum;
        }
        public static int TinhTongDong(int[,] A, int k)
        {
            int sum = A[k, 0];
            for (int j = 1; j < A.GetLength(1); j++)
            {
                sum += A[k, j];
            }
            return sum;
        }
        public static int TinhTongCot(int[,] A, int k)
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
            sum += TinhTongDong(A, 0);
            if (A.GetLength(0) > 1)
            {
                sum += TinhTongDong(A, A.GetLength(0) - 1);
            }
            for (int i = 1; i < A.GetLength(0) - 1; i++)
            {
                sum += A[i, 0] + A[i, A.GetLength(1)-1];
            }
            return sum;
        }
        public static void SapXepMangMotChieu(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
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
        public static void SapXepTangDan(int[,] A)
        {
            int n = A.GetLength(0) * A.GetLength(1);
            int m = A.GetLength(1);
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (A[i/m, i%m] > A[j/m, j%m])
                    {
                        int t = A[i / m, i % m];
                        A[i / m, i % m] = A[j / m, j % m];
                        A[j / m, j % m] = t;
                    }
                }
            }
        }
        public static void SapXepTangDan_C2(int[,] A)
        {
            // Do phan tu ra mang mot chieu B
            int n = A.GetLength(0) * A.GetLength(1);
            int[] B = new int[n];
            int k = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[k] = A[i, j];
                    k++;
                }
            }
            // Sap xep mang B
            SapXepMangMotChieu(B);
            // Do phan tu tu B qua ma tran
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = B[k];
                    k++;
                }
            }
        }
        public static void SapXepGiamDan(int[,] A)
        {
            int n = A.GetLength(0) * A.GetLength(1);
            int m = A.GetLength(1);
            for (int i = 0; i < n -1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i/m, i%m] < A[j/m,i%m])
                    {
                        int t = A[i / m, i % m];
                        A[i / m, i % m] = A[j / m, j % m];
                        A[j / m, j % m] = t;
                    }
                }
            }
        }
        public static int TichChanTrenCot(int[,] A, int k)
        {
            int mul = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i,k] %2 ==0)
                {
                    mul *= A[i, k];
                }
            }
            return mul;
        }
        public static void GiaiPTBac2(string ghiChu)
        {
            int a, b, c;
            double x, x1, x2;
            Console.WriteLine("Nhap a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            c = int.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem!");
            }
            else if (delta == 0)
            {
                x = -b / (2.0 * a);
                Console.WriteLine($"Phuong trinh co nghiem kep la {x}");
            }
            else
            {
                x1 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine($"Phuong trinh co 2 nghiem lan luot la {x1} va {x2}");
            }
        }
        public static void GiaiPhuongTrinhBacNhat(string ghiChu)
        {
            // ax + b =0;
            int a, b;
            double x;
            Console.WriteLine("Nhap a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            b = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b==0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem.");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
            }
            else
            {
                x = -b *1.0/a;
                Console.WriteLine($"Phuong trinh co nghiem la {x}");
            }
        }
        public static void NgayKeTiep(int ngay, int thang, int nam)
        {
            if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                if (ngay < 30)
                {
                    ngay +=1;
                }
                else
                {
                    ngay = 1;
                    thang += 1;
                }
            }
            else if (thang == 2)
            {
                if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                {
                    if (ngay < 29)
                    {
                        ngay += 1;
                    }
                    else
                    {
                        ngay = 1;
                        thang += 1;
                    }
                }
                else
                {
                    if (ngay < 28)
                    {
                        ngay += 1;
                    }
                    else
                    {
                        ngay = 1;
                        thang += 1;
                    }
                }
            }
            else
            {
                if (ngay < 31)
                {
                    ngay += 1;
                }
                else
                {
                    ngay = 1;
                    thang += 1;
                    if (thang > 12)
                    {
                        thang = 1;
                        nam += 1;
                    }
                }
            }
            Console.WriteLine($"{ngay}/{thang}/{nam}");
        }
        public static void SoNgayTrongThang(int thang, int nam)
        {
            int ngay = 31;
            if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                ngay = 31;
            }
            else if (thang == 2)
            {
                if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                {
                    ngay = 29;
                }
                else
                {
                    ngay = 28;
                }
            }
            Console.WriteLine(ngay);
        }
        public static void XuatCuuChuong(int a, int b)
        {
            int i = a;
            while(i <= b)
            {
                int j = 1;
                while(j <= 10)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                    j++;
                }
                i++;
                Console.WriteLine("=====");
            }
        }
        public static HOCSINH NhapHocSinh(string ghiChu)
        {
            HOCSINH a;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap Ma hoc sinh:");
            a.MaHocSinh = Console.ReadLine();
            Console.WriteLine("Nhap Ten hoc sinh:");
            a.TenHocSinh = Console.ReadLine();
            Console.WriteLine("Nhap diem toan:");
            a.DiemToan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem van:");
            a.DiemVan = double.Parse(Console.ReadLine());
            return a;
        }
        public static LOPHOC NhapLopHoc(string ghiChu)
        {
            LOPHOC lop;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ma lop hoc:");
            lop.MaLopHoc = Console.ReadLine();
            Console.WriteLine("Nhap so luong hoc sinh:");
            int n = int.Parse(Console.ReadLine());
            lop.DanhSach = new HOCSINH[n];
            for (int i = 0; i < n; i++)
            {
                lop.DanhSach[i] = NhapHocSinh($"Nhap hoc sinh thu {i+1}");
            }
            return lop;
        }
        public static HOCSINH DiemTBCaoNhat(LOPHOC lop)
        {
            int maxIndex = 0;
            for (int i = 1; i < lop.DanhSach.Length; i++)
            {
                if ((lop.DanhSach[i].DiemToan + lop.DanhSach[i].DiemVan)/2.0 > (lop.DanhSach[maxIndex].DiemToan + lop.DanhSach[maxIndex].DiemVan)/ 2.0)
                {
                    maxIndex = i;
                }
            }
            return lop.DanhSach[maxIndex];
        }
        static void Main(string[] args)
        {
            #region Ngày kế tiếp
            /*
            Console.WriteLine("thang");
            int thang = int.Parse(Console.ReadLine());
            Console.WriteLine("nam");
            int nam = int.Parse(Console.ReadLine());
            SoNgayTrongThang(thang, nam);
            */
            /*
            Console.WriteLine("a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b");
            int b = int.Parse(Console.ReadLine());
            XuatCuuChuong(a, b);
            */

            //int[,] A = NhapMaTran("Nhap ma tran:");
            //XuatMaTran(A);
            //SapXepTangDan(A);
            //XuatMaTran(A);
            //string kq = $"Ket qua la: {TinhTongAm(A)}";
            //Console.WriteLine(kq);

            /*
            Console.WriteLine("Nhap ngay:");
            int ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang:");
            int thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam:");
            int nam = int.Parse(Console.ReadLine());
            NgayKeTiep(ngay, thang, nam);
            */
            #endregion
            #region Bài 18: Tính S(n) = 1 + x^2/2! + x^4/4! + … + x^2n/(2n)!
            int x, n;
            Console.WriteLine("Nhap x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap n:");
            n = int.Parse(Console.ReadLine());

            double s = 1;
            int t = 1;
            int gt = 1;
            for (int i = 1; i <=n ; i++)
            {
                t *= x * x;
                gt *= (2 * i) * (2 * i - 1);
                s += 1.0*t / gt;
            }
            Console.WriteLine(s);
            #endregion

        }
    }
}
