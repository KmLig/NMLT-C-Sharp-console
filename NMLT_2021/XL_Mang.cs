using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    class XL_Mang
    {
        public static int[] NhapMang(string Ghichu)
        {
            int[] A;
            Console.WriteLine(Ghichu);
            Console.WriteLine("Nhap so luong phan tu cua mang:");
            int N = int.Parse(Console.ReadLine());
            A = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"Nhap A[{i}]");
                A[i] = int.Parse(Console.ReadLine());
            }
            return A;
        }
        public static void Xuatmang(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"{A[i]}    ");
            }
        }
        public static int TongMang(int[] A)
        {
            int S = 0;
            for (int i = 0; i < A.Length; i++)
            {
                S += A[i];
            }
            return S;
        }
        public static int[] TaoMangNgauNhien(string Ghichu)
        {
            System.Random random = new System.Random();
            int n = random.Next(minValue: 6, maxValue: 10);
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = random.Next(minValue: -100, maxValue: 100);
            }
            return A;
        }
        public static void HoanVi(int a, int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        public static double[] NhapMangSoThuc(string GhiChu)
        {
            double[] A;
            Console.WriteLine(GhiChu);
            int n;
            Console.WriteLine("Nhap so luong phan tu cua mang:");
            n = int.Parse(Console.ReadLine());
            A = new double[n];
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"Nhap A[{i}]:");
                A[i] = double.Parse(Console.ReadLine());
            }
            return A;
        }
        public static int TimViTriNhoNhat(int[] A)
        {
            int min = A[0];
            int index = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                    index = i;
                }
            }
            return index;
        }
        public static int ChanDauTien(int[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static int ChanCuoiCung(int[] A)
        {
            int index = -1;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] % 2 == 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static int ChanNhoNhat(int[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (A[i] < A[index] && A[i] % 2 == 0)
                    {
                        index = i;
                    }
                }
            }
            return index;
        }
        public static int ChanNhoNhi(int[] A)
        {
            int index = -1;
            int min2 = -1;
            for (int i = 0; i < A.Length; i++)
            {
                index = i;
                break;
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (A[i] < A[index] && A[i] % 2 == 0)
                    {
                        min2 = index;
                        index = i;
                    }
                    else if (A[min2] < A[i] && A[i] % 2 == 0)
                    {
                        min2 = i;
                    }
                }
            }
            return min2;
        }
        public static int ChanLonNhat(int[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (A[i] > A[index] && A[i] % 2 == 0)
                    {
                        index = i;
                    }
                }
            }
            return index;
        }
        public static int ChanLonNhi(int[] A)
        {
            int max2 = -1;
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (A[i] % 2 == 0 && A[i] > A[index])
                    {
                        max2 = index;
                        index = i;
                    }
                    else if (A[max2] < A[i])
                    {
                        max2 = i;
                    }
                }
            }
            return max2;
        }
        public static int NguyenToDauTien(int[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (SoNguyenTo.KiemTraSoNguyenTo(A[i]) == true)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static int NguyenToCuoiCung(int[] A)
        {
            int index = -1;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (SoNguyenTo.KiemTraSoNguyenTo(A[i]) == true)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static int NguyenToLonNhat(int[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (SoNguyenTo.KiemTraSoNguyenTo(A[i]) == true)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (SoNguyenTo.KiemTraSoNguyenTo(A[i]) == true && A[index] < A[i])
                    {
                        index = i;
                    }
                }
            }
            return index;
        }
        public static int HoanThienDauTien(int[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (XL_SoNguyen.SoHoanThienBai30(A[i]) == true)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static int HoanThienCuoiCung(int[] A)
        {
            int index = -1;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (XL_SoNguyen.SoHoanThienBai30(A[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static int HoanThienNhoNhat(int[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (XL_SoNguyen.SoHoanThienBai30(A[i]) == true)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (XL_SoNguyen.SoHoanThienBai30(A[i]) == true && A[i] < A[index])
                    {
                        index = i;
                    }
                }
            }
            return index;
        }
        public static int HoanThienLonNhat(int[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (XL_SoNguyen.SoHoanThienBai30(A[i]) == true)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (XL_SoNguyen.SoHoanThienBai30(A[i]) == true && A[index] < A[i])
                    {
                        index = i;
                    }
                }
            }
            return index;
        }
        public static int HoanThenLonNhi(int[] A)
        {
            int index = -1;
            int max2 = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (XL_SoNguyen.SoHoanThienBai30(A[i]) == true)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (A[index] < A[i])
                    {
                        max2 = index;
                        index = i;
                    }
                    else if (A[max2] < A[i])
                    {
                        max2 = i;
                    }
                }
            }
            return index;
        }
        public static int AmDauTien(int[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static int AmCuoiCung(int[] A)
        {
            int index = -1;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] < 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static int AmNhoNhat(int[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (A[i] < A[index])
                    {
                        index = i;
                    }
                }
            }
            return index;
        }
        public static int AmNhoNhi(int[] A)
        {
            int index = -1;
            int min2 = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (A[i] < A[index])
                    {
                        min2 = index;
                        index = i;
                    }
                    else if (A[min2] < A[i])
                    {
                        min2 = i;
                    }
                }
            }
            return min2;
        }
        public static int AmLonNhat(int[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (A[index] < A[i])
                    {
                        index = i;
                    }
                }
            }
            return index;
        }
        public static double DuongDauTien(double[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static double DuongCuoiCung(double[] A)
        {
            int index = -1;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] > 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static double DuongNhoNhat(double[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (A[index] > A[i] && A[i] > 0)
                    {
                        index = i;
                    }
                }
            }
            return index;
        }
        public static double DuongLonNhat(double[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (A[index] < A[i])
                    {
                        index = i;
                    }
                }
            }
            return index;
        }
        public static double DuongLonNhi(double[] A)
        {
            int index = -1;
            int max = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (A[index] < A[i])
                    {
                        max = index;
                        index = i;
                    }
                    else if (A[max] < A[i])
                    {
                        max = i;
                    }
                }
            }
            return max;
        }
        public static int[] SapXepTangDan(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        int t = A[i];
                        A[i] = A[j];
                        A[j] = t;
                    }
                }
            }
            return A;
        }       
        public static void LietKeViTriGiaTriAm(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static int TimViTriDuongDauTien(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int TimViTriChanCuoiCung(int[] A)
        {
            for (int i = A.Length -1; i >= 0; i--)
            {
                if (A[i] % 2 ==0)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int GiaTriDuongNhoNhat(int[] A)
        {
            int minIndex = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    minIndex = i;
                    break;
                }
            }
            if (minIndex >= 0)
            {
                for (int i = minIndex + 1; i < A.Length; i++)
                {
                    if (A[i] < A[minIndex] && A[i] > 0)
                    {
                        minIndex = i;
                    }
                }
            }            
            return minIndex;
        }                      
        public static int GiaTriLonNhat(int[] A)
        {
            int max = A[0];
            for (int i = 1; i < A.Length; i++) // chạy từ A[1]
            {
                if(max < A[i])
                {
                    max = A[i];
                }
            }
            return max;
        }       
        public static int GiaTriLonNhi(int[] A)
        {
            int max = A[0];
            int max2 = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (max < A[i])
                {
                    max2 = max;
                    max = A[i];                    
                }
                else if (max2 < A[i])
                {
                    max2 = A[i];
                }
            }
            return max2;
        }
        public static int DemSonNguyenTo(int[] A)
        {
            int Dem = 0;
            for (int i = 0; i < A.Length; i++) // chạy từ A[1]
            {
                if (A[i] < 100 && SoNguyenTo.KiemTraSoNguyenTo(A[i]) == true)
                {
                    Dem++; ;
                }
            }
            return Dem;
        }
        public static int TinhTong(int[] A)
        {
            int S = 0;
            for (int i = 0; i < A.Length; i++)
            {
                S += A[i];
            }
            return S;
        }
        //Bài 122: Viết hàm tìm giá trị lớn nhất trong mảng 1 chiều các số thực
        public static double TimGiaTriLonNhat(int[] A)
        {
            int max = A[0];

            for (int i = 0; i < A.Length; i++)
            {
                if (max < A[i])
                {
                    max = A[i];
                }
            }
            return max;
        }
        //Bài 151: Hãy tìm số nguyên tố lớn nhất trong mảng 1 chiều các số nguyên. Nếu mảng không có số nguyên tố thì trả về -1
        public static int TimSoNguyenToLonNhat(int[] A)
        {
            int maxNTindex = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (SoNguyenTo.KiemTraSoNguyenTo(A[i]))
                {
                    maxNTindex = i;
                    break;
                }
            }
            if (maxNTindex >= 0)
            {
                for (int i = maxNTindex + 1; i < A.Length; i++)
                {
                    if (A[maxNTindex] < A[i] && SoNguyenTo.KiemTraSoNguyenTo(A[i]))
                    {
                        maxNTindex = i;
                    }
                }
            }
            return maxNTindex;
        }
        public static int TimSoNguyenToNhoNhat(int[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (SoNguyenTo.KiemTraSoNguyenTo(A[i]) == true)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (A[i] < A[index] && SoNguyenTo.KiemTraSoNguyenTo(A[i])==true)
                    {
                        index = i;
                    }
                }
            }
            return index;
        }
        public static double TinhTrungBinhCongPhanTuLe(int[] A)
        {
            int count = 0;
            int S = 0;
            double tbc = 1.0*S / count;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 1)
                {
                    count++;
                    S += A[i];
                }
            }
            if (count == 0)
            {
                return 0;
            }
            return tbc;
        }
        public static double TinhTrungBinhCongSoNguyenTo(int[] A)
        {
            int count = 0;
            int S = 0;
            double tbc = 1.0 * S / count;            
            for (int i = 0; i < A.Length; i++)
            {
                if (SoNguyenTo.KiemTraSoNguyenTo(A[i])==true)
                {
                    count++;
                    S += A[i];
                }
            }
            if (count == 0)
            {
                return 0;
            }
            return tbc;
        }
        public static int DemSoNguyenTo(int[] A)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (XL_SoNguyen.SoNguyenToBai31(A[i]) == true)
                {
                    count++;
                }
            }
            return count;
        }
        public static void LietKeGiaTriAm(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    Console.WriteLine(A[i]);
                }
            }
        }
        public static int ViTriDuongDauTien(int[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    index =  i;
                }
            }
            return index;
        }
        public static int ViTriDuongThuHai(int[] A)
        {
            int dem = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    dem++;
                }
                if (dem == 2)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int ViTriDuongCuoiCung(int[] A)
        {
            for (int i = A.Length-1; i >+ 0; i++)
            {
                if (A[i] > 0)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int ViTriChanCuoiCung(int[] A)
        {
            for (int i = A.Length-1; i >= 0; i++)
            {
               if (A[i] % 2 == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int ViTriChanKeCuoi(int[] A)
        {
            int count = 0;
            for (int i = A.Length -1; i >= 0; i++)
            {
                if (A[i] % 2 == 0)
                {
                    count++;
                }
                if (count == 2)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int ViTriDuongNhoNhat(int[] A)
        {
            
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] >= 0)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index +1 ; i < A.Length; i++)
                {
                    if (A[index] > A[i])
                    {
                        index = i;
                    }
                }
            }
            return index;
        }
        public static int TimGiaTriDuongNhoNhat(int[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index +1; i < A.Length; i++)
                {
                    if (A[index] > A[i])
                    {
                        index = i;
                    }
                }
            }
            return A[index];
        }
        public static int TimGiaTriDuongNhoNhi(int[] A)
        {
            int index = -1;
            int min2 = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index +1; i < A.Length; i++)
                {
                    if (A[index] > A[i])
                    {
                        min2 = index;
                        index = i;
                    }
                    else if (A[min2] > A[i])
                    {
                        min2 = A[i];
                    }
                }
            }
            return min2;
        }
        public static int TimGiaTriNguyenToLonNhat(int[] A)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (SoNguyenTo.KiemTraSoNguyenTo(A[i]) == true)
                {
                    index = i;
                    for (int j = index + 1; j < A.Length; j++)
                    {
                        if (SoNguyenTo.KiemTraSoNguyenTo(A[j]) == true && A[index] < A[j])
                        {
                            index = j;
                        }
                    }
                }
            }
            return index;
        }
        public static int TimGiaTriNguyenToLonNhi(int[] A)
        {
            int max2 = -1;
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (SoNguyenTo.KiemTraSoNguyenTo(A[i]) == true)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (SoNguyenTo.KiemTraSoNguyenTo(A[i]) == true && A[index] < A[i])
                    {
                        max2 = index;
                        index = i;
                    }
                    else if (SoNguyenTo.KiemTraSoNguyenTo(A[i]) == true && A[max2] < A[i])
                    {
                        max2 = i;
                    }
                }
            }
            return max2;
        }
        public static int ViTriXaNhat(int[] A, int x)
        {
            int maxindex = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (Math.Abs(x - A[i]) > Math.Abs(x - A[maxindex]))
                {
                    maxindex = i;
                }
            }
            return maxindex;
        }
        public static int ViTriXaNhat(double[] A, double x)
        {
            int maxindex = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (Math.Abs(x - A[i]) > Math.Abs(x - A[maxindex]))
                {
                    maxindex = i;
                }
            }
            return maxindex;
        }
        public static int SoGanhDauTien(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == XL_SoNguyen.TimSoDaoNguoc(A[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public static int TimChuSoXuatHienItNhat(int[] A)
        {
            int[] dem = new int[10];
            for (int i = 0; i < A.Length; i++)
            {
                int t = Math.Abs(A[i]);
                if (t == 0)
                {
                    dem[0]++;
                }
                else if (t > 0)
                {
                    int d = t % 10;
                    dem[d]++;
                    t /= 10;
                }
            }
            int kq = GiaTriDuongNhoNhat(dem);
            return kq;
        }
        public static void CapGiaTriKhacNhau(int[] A)
        {
            for (int i = 0; i < A.Length -1; i++)
            {
                for (int j = i+1; j< A.Length;j++)
                {
                    if (A[i] < A[j])
                    {
                        Console.WriteLine($"{A[j]} & {A[i]}"); ;
                    }
                }
            }
        }
    }
}
