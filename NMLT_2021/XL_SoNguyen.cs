
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    class XL_SoNguyen
    {
        public static int NhapSoNguyen(string Ghichu)
        {
            Console.WriteLine(Ghichu);
            int a = int.Parse(Console.ReadLine());
            return a;
        }
        public static int TinhTong(int a, int b)
        {
            return a + b;
        }
        public static void LietKeTatcaUocSoBai20(int N)
        {
            Console.WriteLine(1);
            for(int i = 2; i <= N/2; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(N);
        }       
        public static int TongCacUocSoBai21(int N)
        {
            int S = 1 + N;
            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                {
                    S += i;
                }
            }
            return S;
        }
        public static int TichCacUocSoBai22(int N)
        {
            int T = 1 * N;
            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                {
                    T *= i;
                }
            }
            return T;
        }
        public static int DemUocSoBai23(int N)
        {
            int Count = 2;
            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                {
                    Count += 1;
                }
            }
            return Count;
        }        
        public static void LietKeUocLeBai24(int N)
        {
            Console.WriteLine(1);
            for (int i = 3; i <= N / 2; i += 2)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            if (N % 2 == 1)
            {
                Console.WriteLine(N);
            }
        }        
        public static int TinhTongUocChanBai25(int N)
        {
            int S = 0;
            for (int i = 2; i <= N / 2; i += 2)
            {
                if (N % i == 0)
                {
                    S += i;
                }
            }
            if (N % 2 == 0)
            {
                S += N;
            }
            return S;
        }        
        public static int TinhTichUocLeBai26(int N)
        {
            int T = 1;
            for (int i = 1; i <= N / 2; i += 2)
            {
                if (N % i == 0)
                {
                    T *= i;
                }
            }
            if (N % 2 == 1)
            {
                T *= N;
            }
            return T;
        }        
        public static int DemUocChanBai27(int N)
        {
            int count = 0;
            for (int i = 2; i <= N / 2; i += 2)
            {
                if (N % i == 0)
                {
                    count++;
                }
            }
            if (N % 2 == 0)
            {
                count++;
            }
            return count;
        }
        public static int TongUocNhoHonNBai28(int N)
        {
            int S = 1;
            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                {
                    S += i;
                }
            }
            return S;
        }
        public static int UocLeLonNhatBai29(int N)
        {
            int max = 1;
            for (int i = 3; i <= N / 2; i += 2)
            {
                if (N % i == 0)
                {
                    if (max < i)
                    {
                        max = i;
                    }
                }
            }
            return max;
        }
        public static bool SoHoanThienBai30(int N)
        {            
            int tonguoc = 1;
            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                {
                    tonguoc += i;
                }
            }
            if (tonguoc == N)
            {
                return true;
            }
            return false;
        }
        public static bool SoNguyenToBai31(int N)
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
        public static bool SoChinhPhuongBai32(int N)
        {
            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                if (i * i == N)
                {
                    return true;
                }
            }
            return false;
        }
        //Bài 42: Cho n là số nguyên dương. Hãy tìm giá trị nguyên dương k lớn nhất sao cho S(k)  < n. Trong đó chuỗi k được định nghĩa như sau: S(k) = 1 + 2 + 3 + … + k 
        public static int SoktrongdaysoBai42(int N)
        {
            int S = 0;
            int i = 0;
            while (S + (i +1) < N)
            {
                i++;
                S += i;                
            }
            return i;
        }
        public static int DemSLChuSo(int N)
        {
            int Dem = 0;            
            while (N > 0)
            {
                Dem++;
                N /= 10;                
            }
            return Dem;
        }
        public static int TongCacChuSo(int N)
        {
            int S = 0;
            int temp;
            while (N > 0)
            {
                temp = N % 10;
                S += temp;
                N /= 10;
            }
            return S;
        }
        public static int TichCacChuSo(int N)
        {
            int T = 1;
            int temp;
            while (N > 0)
            {
                temp = N % 10;
                T *= temp;
                N /= 10;
            }
            return N;
        }
        public static int DemSoLeBai46(int N)
        {
            int count = 0;
            int temp;
            while (N > 0)
            {
                temp = N % 10;
                if (temp % 2 == 1)
                {
                    count++;
                }
                N /= 10;
            }
            return count;
        }
        public static int TongSoChanBai47(int N)
        {
            int S = 0;
            int temp;
            while (N > 0)
            {
                temp = N % 10;
                if (temp % 2 == 0)
                {
                    S += temp;
                }
                N /= 10;
            }
            return S;
        }
        public static int TichCacSoLeBai48(int N)
        {
            int T = 1;
            int temp;
            while (N > 0)
            {
                temp = N % 10;
                if (temp % 2 == 1)
                {
                    T *= temp;
                }
                N /= 10;
            }
            return T;
        }
        public static int TimChuSoDauTienBai49(int N)
        {
            int Sodau;
            do
            {
                Sodau = N % 10;
                N /= 10;
            }
            while (N > 0);
            return Sodau;
        }
        public static int TimChuSoCuoiCung(int N)
        {
            int lastNum;
            do
            {
                lastNum = N % 10;
                break;
            }
            while (N > 0);
            return lastNum;
        }
        public static int TimSoDaoNguoc(int N)
        {
            if (N < 0)
            {
                N = -N;
            }
            int Sodaonguoc = 0;
            int temp;
            while (N > 0)
            {
                temp = N % 10;
                Sodaonguoc = Sodaonguoc * 10 + temp;
                N /= 10;
            }
            return Sodaonguoc;
        }
        public static bool KiemTraDoiXung(int N)
        {
            return TimSoDaoNguoc(N) == Math.Abs(N);
        }
        public static int TimSoLonNhat(int N)
        {
            int max = N % 10;
            int temp;
            while (N > 0)
            {
                temp = N % 10;
                if (max < temp)
                {
                    max = temp;
                }
                N /= 10;
            }
            return max;
        }
        public static int TimSoNhoNhatBai52(int N)
        {
            int min = N % 10;
            int temp;
            while (N > 0)
            {
                temp = N % 10;
                if (temp < min)
                {
                    min = temp;
                }
                N /= 10;
            }
            return min;
        }
        public static int DemSoLonNhatBai53(int N)
        {
            int Dem = 0;
            int max = N % 10;
            int temp;
            while (N > 0)
            {
                temp = N % 10;
                if (max == temp)
                {
                    Dem++;
                }
                if (max < temp)
                {
                    max = temp;
                    Dem = 1;
                }
                N /= 10;
            }
            return Dem;
        }
        public static int DemSoNhoNhatBai54(int N)
        {
            int Dem = 0;
            int min = N % 10;
            int temp;
            while (N > 0)
            {
                temp = N % 10;
                if (min == temp)
                {
                    Dem++;
                }
                if (min > temp)
                {
                    min = temp;
                    Dem = 1;
                }
                N /= 10;
            }
            return Dem;
        }
        public static bool KiemTraToanLeBai55(int N)
        {
            if (N < 0)
            {
                N = -N;
            }
            if (N == 0)
            {
                return false;
            }
            while (N > 0)
            {
                int temp = N % 10;
                if (temp % 2 == 0)
                {
                    return false;
                }
                N /= 10;
            }
            return true;
        }
        public static bool KiemTraToanChanBai56(int N)
        {
            if (N < 0)
            {
                N = -N;
            }
            if (N == 0)
            {
                return false;
            }
            while (N > 0)
            {
                int temp = N % 10;
                if (temp % 2 == 1)
                {
                    return false;
                }
                N /= 10;
            }
            return true;
        }
        public static bool KiemTraDoiXungBai59(int N)
        {
            int Sodoixung = 0;
            int temp;
            for (int M = N; M > 0; M /= 10)
            {
                temp = M % 10;
                Sodoixung = Sodoixung * 10 + temp;
            }
            if(Sodoixung == N)
            {
                return true;
            }
            return false;
        }
        public static bool KiemTraTangDanBai60(int N)
        {
            int temp;
            int increase = N % 10;
            N /= 10;
            while (N > 0)
            {
                temp = N % 10;
                if (temp >= increase)
                {
                    return false;
                }
                else
                {
                    increase = temp;
                }
                N /= 10;
            }
            return true;
        }
        public static bool KiemTraGiamDanBai61(int N)
        {
            int temp;
            int decrease = N % 10;
            N /= 10;
            while (N > 0)
            {
                temp = N % 10;
                if (temp <= decrease)
                {
                    return false;
                }
                else
                {
                    decrease = temp;
                }
                N /= 10;
            }
            return true;
        }
        public static int UocChungLonNhat(int a, int b)
        {
            int uocchunglonnhat = 1;
            int max = a > b ? a : b;
            int min = a < b ? a : b;
            for (int i = min; i >= 1; i--)
            {
                if (max % i == 0 && min % i == 0)
                {
                    uocchunglonnhat = i;
                }
            }
            
            return uocchunglonnhat;

        }
        public static int BoiChungNhoNhat(int a, int b)
        {
            int max = a > b ? a : b;            
            int index = a * b;
            if (a == b)
            {
                index = a;
            }
            for (int i = max; i <= a * b; i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                    index = i;
                }
            }
            return index;
        }
        public static void InBangCuuChuong(int a, int b)
        {
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    Console.WriteLine($"{i}*{j} = {i * j}");
                }
                Console.WriteLine("***");
            }
        }
        public static int LamTronXuong(double d)
        {
            return (int)Math.Floor(d);
        }
        public static int LamTronLen(double d)
        {
            return (int)Math.Ceiling(d);
        }
    }
}
