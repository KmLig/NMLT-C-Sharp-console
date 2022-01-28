using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    class Comment
    {
        #region Khái niệm
        /*int x, y, z;
        Console.WriteLine("Nhap gia tri cua x:");
        string s = Console.ReadLine();
        x = int.Parse(s);
        Console.WriteLine("Nhap gia tri cua y");
        y = int.Parse(Console.ReadLine());            
        //z = x + y;
        double d = 1.0*x / y;
        Console.WriteLine($"Tong cua {x} % {y} = {d}");*/

        /*Console.WriteLine("Nhap chuoi:");
        string s = Console.ReadLine();
        Console.WriteLine("Nhap ki tu can tim:");
        char c = char.Parse(Console.ReadLine()); 
        int sl = 0;
        bool answer = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == c)
            {
                answer = true;
                sl++;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine($"So lan xuat hien la: {sl}");*/
        #endregion
        #region Phương trinh bậc nhất
        // Phương trình bậc nhất ax+b= 0
        /*Console.OutputEncoding = Encoding.UTF8;
        int a, b;
        double kq;
        Console.WriteLine("Nhap a");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap b");
        b = int.Parse(Console.ReadLine());
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phương trình có vô số nghiệm");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
        }
        else
        {
            kq = -b * 1.0 / a;
            Console.WriteLine($"Kết quả là: {kq}");
        }
        */
        #endregion
        #region    Phương trình bậc 2 ax2 + bx +c = 0; xét a khác 0;
        /*
        Console.OutputEncoding = Encoding.UTF8;
        int a, b, c;
        double x, x1, x2;
        Console.WriteLine("Nhap a:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap b:");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap c:");
        c = int.Parse(Console.ReadLine());
        double delta = b * b - 4 * a * c;
        if(delta < 0)
        {
            Console.WriteLine("Phương trình vô nghiệm!");
        }
        else if(delta == 0)
        {
            x = -b / (2.0 * a);
            Console.WriteLine($"Phương trình có nghiệm kép là {x}");
        }
        else
        {
            x1 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            x2 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine($"Phương trình có nghiệm kép lần lượt là {x1}, {x2}");
        }
        Console.ReadLine();
        */
        #endregion
        #region  Giải phương trình bậc 2   
        /*Console.WriteLine("Nhap gia tri cua a");            
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap gia tri cua b");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap gia tri cua c");
        int c = int.Parse(Console.ReadLine());
        int delta = b * b - 4 * a * c;
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                double xb1 = -c * 1.0 / b;
                Console.WriteLine($"Phuong trinh có nghiem la {xb1}");
            }
        }
        else
        {
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                double x = -b * 1.0 / (2 * a);
                Console.WriteLine($"Phuong trinh co nghiem kep la {x}");
            }
            else
            {
                double x1 = 1.0 * (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = 1.0 * (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phuong trinh co hai nghiem  la {x1} và {x2}");
            }
        }
        */
        #endregion
        #region Bài 1 Tính S(n) = 1 + 2 + 3 + … + n
        //Tinh S(n) = 1 + 2 + 3 + … + n
        /*int N, S;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        int i = 1;
        S = 0;
        while(i <= N)
        {
            S += i;
            i++;
        }
        Console.WriteLine($"Ket qua la {S}");
        */
        #endregion
        #region Bài 2 Tính S(n) = 1^2 + 2^2 + … + n^2
        //S(n) = 1^2 + 2^2 + … + n^2
        /*int N, S, i;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        S = 0;
        i = 1;
        while (i <= N)
        {
            S +=i*i;
            i++;
        }
        Console.WriteLine($"Ket qua la: {S}");
        */
        #endregion
        #region Bai 3 Tính S(n) = 1 + ½ + 1/3 + … + 1/n
        //S(n) = 1 + ½ + 1/3 + … + 1/n
        /*int N, i;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        double S = 0;
        i = 1;
        while(i <= N)
        {
            S += (1.0 / i);
            i++;
        }
        Console.WriteLine($"Ket qua la: {S}");
        */
        #endregion
        #region Bài 4: Tính S(n) = ½ + ¼ + … + 1/2n
        /*int N, i;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        double S = 0;            
        i = 1;
        while (i <=N)
        {
            S += 1 / (2.0 * i);
            i++;
        }
        Console.WriteLine($"Ket qua la: {S}");
        */
        #endregion
        #region Bài 6: Tính S(n) = 1/1×2 + 1/2×3 +…+ 1/n x (n + 1)
        /*int N, i;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        double T;
        double S = 0;
        i = 1;
        while (i <= N)
        {
            T = 1.0 / (i * (i + 1));
            S += T;
            i++;
        }
        Console.WriteLine($"Ket qua la : {S}");
        */
        #endregion
        #region Bài 7: Tính S(n) = ½ + 2/3 + ¾ + …. + n / n + 1
        /*int N, i;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        double T;
        double S = 0;
        i = 1;
        while (i <= N)
        {
            T = 1.0 * i / (i + 1);
            S += T;
            i++;
        }
        Console.WriteLine($"Ket qua la: {S}");
        */
        #endregion
        #region Bài 8: Tính S(n) = ½ + ¾ + 5/6 + … + 2n + 1/ 2n + 2
        /*int N, i;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        double T;
        double S = 0;
        i = 0;
        while(i<=N)
        {
            T =  (2.0 * i + 1) / (2 * i + 2);
            S += T;
            i++;
        }
        Console.WriteLine($"Ket qua la: {S}");
        */
        #endregion
        #region Bài 9: Tính T(n) = 1 x 2 x 3…x N
        // N phải khác 0;
        /*
        int N, T, i;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        T = 1;
        i = 1;
        while (i <= N)
        {
            T *= i;
            i++;
        }
        Console.WriteLine($"Ket qua la: {T}");
        */
        #endregion
        #region Bai 10 Tinh x^N
        /*int x, N, T, i;
        Console.WriteLine("Nhap x:");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        T = 1;
        i = 1;
        while (i<=N)
        {
            T *= x;
            i++;
        }
        Console.WriteLine($"Ket qua la: {T}");
        */
        #endregion
        #region Bài 11: Tính S(n) = 1 + 1.2 + 1.2.3 + … + 1.2.3….N
        /*int S, T, i, N;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        S = 0;
        T = 1;
        i = 1;
        while (i <= N)
        {
            T *= i;
            S += T;
            i++;
        }
        Console.WriteLine($"Ket qua la: {S}");
        */
        #endregion
        #region Bài 12: Tính S(n) = x + x^2 + x^3 + … + x^n
        /*int x, N, i, T, S;
        Console.WriteLine("Nhap x:");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        T = 1;
        S = 0;
        i = 1;
        while(i <= N)
        {
            T *= x;
            S += T;
            i++;
        }
        Console.WriteLine($"Ket qua la: {S}");
        */
        #endregion
        #region Bài 13: Tính S(n) = x^2 + x^4 + … + x^2n
        /*int x, N, i;
        double T, S;
        Console.WriteLine("Nhap x:");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 1;
        T = 1;
        S = 0;
        while(i <= N)
        {
            T *= x*x; // hoặc nếu xài hàm Math.Pow thì không khai báo giá trị của T mà chỉ dùng để lưu
            S += T;
            i++;
        }
        Console.WriteLine($"Ket qua la: {S}");
        */
        #endregion
        #region Bài 14: Tính S(n) = x + x ^ 3 + x ^ 5 + … +x ^ 2n + 1
        /*int x, N, i;
        double T, S;
        Console.WriteLine("Nhap x:");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 1;
        T = x;
        S = 0;
        while (i <= N)
        {
            T *= x*x;               
            S += T;
            i++;
        }
        Console.WriteLine($"Ket qua la: {S}");
        */
        #endregion
        #region Bài 15: Tính S(n) = 1 + 1/1 + 2 + 1/ 1 + 2 + 3 + ….. + 1/ 1 + 2 + 3 + …. + N
        /*int N, i; 
        double D, S1, S2;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 1;
        S1 = 0;
        S2 = 0;
        while (i <= N)
        {
            S1 += i;
            D = 1 / S1;
            S2 += D;
            i++;
        }
        Console.WriteLine($"Ket qua la: {S2}");
        */
        #endregion
        #region Bài 16: Tính S(n) = x + x^2/1 + 2 + x^3/1 + 2 + 3 + … + x^n/1 + 2 + 3 + …. + N
        /*int x, N, i, T, S1;
        double D, S2;
        Console.WriteLine("Nhap x:");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 1;
        T = 1;
        S1 = 0;
        S2 = 0;
        while (i <= N)
        {
            T *= x;
            S1 += i;
            D = T / S1;
            S2 += D;
        }
        Console.WriteLine($"Ket qua la: {S2}");
        */
        #endregion
        #region Bài 17: Tính S(n) = x + x^2/2! + x^3/3! + … + x^n/N!
        /*int x, N, i, T, GT;
        double D, S2;
        Console.WriteLine("Nhap x:");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 1;
        T = 1;
        GT = 1;
        S2 = 0;
        while (i <= N)
        {
            T *= x;
            GT *= i;
            D = 1.0* T / GT;
            S2 += D;
            i++;
        }
        Console.WriteLine($"Ket qua la: {S2}");
        */
        #endregion
        #region Bài 18: Tính S(n) = 1 + x^2/2! + x^4/4! + … + x^2n/(2n)!
        /*int x, N, i, T, M, GT;
        double D, S;            
        Console.WriteLine("Nhap x:");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 1;
        T = 1;
        GT = 1;
        S = 1;
        while (i <= N)
        {
            T *= x*x;
            M = 2*i;
            GT *= M * (M - 1);
            D = 1.0 * T / GT;
            S += D;
            i++;
        }
        Console.WriteLine($"Ket qua la: {S}");
        */
        #endregion
        #region Bài 19: Tính S(n) = 1 + x + x^3/3! + x^5/5! + … + x^(2n+1)/(2n+1)!
        /*
        int x, N, i, T, GT, M;
        Console.WriteLine("Nhap x:");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        double D, S;
        i = 1;
        T = x;
        GT = 1;
        S = 1 + x;
        while (i <= N)
        {
            T *= x * x; 
            M = 2 * i +1;
            GT *= M * (M - 1);
            D = 1.0 * T / GT;
            S += D;
            i++;
        }
        Console.WriteLine($"Ket qua la {S}");
        */
        #endregion
        #region Bài 20: Liệt kê tất cả các “ước số” của số nguyên dương n
        /*
        int N, i;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 1;
        while(i <= N/2)
        {
            if(N % i ==0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
        Console.WriteLine(N);
        */
        #endregion
        #region Bài 21: Tính tổng tất cả các “ ước số” của số nguyên dương n
        /*
        int N, i, S;
        i = 1;
        S = 0;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        while(i <= N/2)
        {
            if (N % i == 0)
            {
                S += i;
            }
            i++;
        }
        S += N;
        Console.WriteLine(S);
        */
        #endregion
        #region Bài 22:Tính tích tất cả các “ước số” của số nguyên dương n
        /*
        int N, i, T;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 1;
        T = 1;
        while (i <= N/2)
        {
            if(N % i ==0)
            {
                T *= i;
            }
            i++;
        }
        T *= N;
        Console.WriteLine(T);
        */

        #endregion
        #region Bài 23: Đếm số lượng “ước số” của số nguyên dương n
        /*
        int N, i, C;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 1;
        C = 0;
        while(i <= N/2)
        {
            if(N % i ==0)
            {
                C += 1;
            }
            i++;
        }
        C += 1;
        Console.WriteLine($"Ket qua la: {C}");
        */
        #endregion
        #region Bài 24: Liệt kê tất cả các “ước số lẻ” của số nguyên dương n
        /*
        int N, i;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 1;
        while(i <= N/2)
        {
            if(N % i == 0)
            {
                Console.WriteLine(i);
            }
            i +=2;
        }
        if(N % 2 ==1)
        {
            Console.WriteLine(N);
        }
        */
        #endregion
        #region Bài 25: Tính tổng tất cả các “ước số chẵn” của số nguyên dương n
        /*
        int N, i, S;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 2;
        S = 0;
        while(i <= N/2)
        {
            if(N % i ==0 && i % 2 == 0)
            {
                S += i;
            }
            i += 2;
        }
        if(N % 2 == 0)
        {
            S += N;
        }
        Console.WriteLine($"Ket qua la: {S}");
        */
        #endregion
        #region Bài 26: Tính tích tất cả các “ước số lẻ” của số nguyên dương n
        /*
        int N, i, T;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 1;
        T = 1;
        while(i <= N/2)
        {
            if(N % i == 0)
            {
                T *= i;
            }
            i += 2;
        }
        if(N % 2 ==1)
        {
            T *= N;
        }
        Console.WriteLine($"Ket qua la: {T}");
        */
        #endregion
        #region Bài 27: Đếm số lượng “ước số chẵn” của số nguyên dương n
        /*
        int N, i, C;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 2;
        C = 0;
        while(i <= N/2)
        {
            if(N % i == 0)
            {
                C++;
            }
            i += 2;
        }
        if(N % 2 == 0)
        {
            C++;
        }
        Console.WriteLine($"Ket qua la: {C}");
        */
        #endregion
        #region Bài 28: Cho số nguyên dương n. Tính tổng các ước số nhỏ hơn chính nó
        /*
        int N, i, S;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 1;
        S = 0;
        while(i <= N/2)
        {
            if(N % i == 0)
            {
                S += i;
            }
            i++;
        }
        Console.WriteLine($"Ket qua la: {S}");
        */
        #endregion
        #region Bài 29: Tìm ước số lẻ lớn nhất của số nguyên dương n. Ví dụ n = 100 ước lẻ lớn nhất là 25
        /*
        int N, i, max;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 1;
        max = 1;
        while (i <= N / 2)
        {
            if (N % i == 0)
            {
                if(max < i)
                {
                    max = i;
                }
            }
            i += 2;
        }
        if (N % 2 == 1)
        {
            max = N;
        }
        Console.WriteLine(max);
        */
        #endregion
        #region Bài 30: Cho số nguyên dương n. Kiểm tra xem n có phải là số hoàn thiện hay không
        /*
        int N, i, S;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 1;
        S = 0;
        while(i <= N/2)
        {
            if(N % i == 0)
            {
                S += i;
            }
            i++;
        }
        if (S == N)
        {
            Console.WriteLine($"{N} la so hoan thien!");
        }
        else
        {
            Console.WriteLine($"{N} khong phai la so hoan thien!");
        }
        */
        #endregion
        #region Bài 31: Cho số nguyên dương n. Kiểm tra xem n có phải là số nguyên tố hay không
        /*
        int N, i;
        bool SoNguyento = true;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 2;
        if(N < 2)
        {
            SoNguyento = false;
        }
        else if(N == 2)
        {
            SoNguyento = true;
        }
        else
        {
            while (i <= N / 2)
            {
                if (N % i == 0)
                {
                    SoNguyento = false;
                    break;
                }
                i+=2;
            }                
        }
        if(SoNguyento == true)
        {
            Console.WriteLine($"{N} la so nguyen to");
        }
        else
        {
            Console.WriteLine($"{N} khong phai la so nguyen to");
        }
        */
        #endregion
        #region Bài 32: Cho số nguyên dương n. Kiểm tra xem n có phải là số chính phương hay không
        // có thể thực hiện ép kiểu
        /*
        int N, i;
        bool soChinhPhuong = false;
        N = int.Parse(Console.ReadLine());
        i = 1;
        while(i <= Math.Sqrt(N))
        {
            if(i*i == N)
            {
                soChinhPhuong = true;
            }
            i++;
        }
        if(soChinhPhuong == true)
        {
            Console.WriteLine($"{N} la so chinh phuong!");
        }
        else
        {
            Console.WriteLine($"{N} khong phai la so chinh phuong!");
        }
        */
        #endregion
        #region Bài 44: Hãy tính tổng các chữ số của số nguyên dương n
        /*
        int N, T, S;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        S = 0;
        while(N > 0)
        {
            T = N % 10;
            S += T;
            N /= 10;
        }
        Console.WriteLine($"Ket qua la: {S}");
        */
        #endregion
        #region  Bài 45: Hãy tính tích các chữ số của số nguyên dương n
        /*int N, temp, T;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        T = 1;
        while(N > 0)    
        {
            temp = N % 10;
            T *= temp;
            N /= 10;
        }
        Console.WriteLine($"Ket qua la: {T}");
        */
        #endregion
        #region Bài 101: Viết chương trình nhập tháng, năm. Hãy cho biết tháng đó có bao nhiêu ngày
        /*Console.OutputEncoding = Encoding.UTF8;
        int ngay, thang, nam;
        Console.WriteLine("Nhập tháng:");
        thang = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập năm:");
        nam = int.Parse(Console.ReadLine());
        ngay = 31;
        if(thang == 4 || thang == 6 || thang == 9 || thang == 11)
        {
            ngay = 30;
        }
        else if(thang == 2)
        {
            if((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
            {
                ngay = 30;
            }
            else
            {
                ngay = 28;
            }
        }
        Console.WriteLine($"Số ngày là: {ngay}");
        */
        #endregion
        #region Bài 102: Viết chương trình nhập vào 1 ngày ( ngày, tháng, năm). Tìm ngày kế ngày vừa nhập (ngày, tháng, năm)
        /*
        int ngay, thang, nam;
        Console.WriteLine("Nhap ngay:");
        ngay = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap thang:");
        thang = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap nam:");
        nam = int.Parse(Console.ReadLine());
        if(thang == 4 || thang == 6 || thang == 9 || thang == 11)
        {
            if(ngay <30)
            {
                ngay += 1;
            }
            else
            {
                ngay = 1;
                thang += 1;
            }
        }
        else if(thang == 2)
        {
            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
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
            if(ngay < 31)
            {
                ngay += 1;
            }
            else
            {
                ngay = 1;
                thang += 1;
            }
        }
        Console.WriteLine($"Ngay thang ke tiep la: {ngay}/ {thang}");
        */
        #endregion
        #region Bài 103: Viết chương trình nhập vào 1 ngày(ngày, tháng, năm).Tìm ngày trước ngày vừa nhập(ngày, tháng, năm) //chua xong
        /*int ngay, thang, nam;
        Console.WriteLine("Nhap ngay:");
        ngay = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap thang:");
        thang = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap nam:");
        nam = int.Parse(Console.ReadLine());
        if(thang == 4 || thang == 6 || thang == 9 || thang == 11)
        {
            if(ngay > 1)
            {
                ngay -= 1;

            }
            else
            {
                ngay = 
            }
        }
        */
        #endregion
        #region Bài 108:  Viết hàm tính S = x ^ y
        #endregion
        #region Bài 109: Viết chương trình in bảng cửu chương ra màn hình
        /*
        int i, j;
        i = 1;
        while(i <= 9)
        {
            j = 1;
            while(j <= 9)
            {
                Console.WriteLine($"{i}*{j} = {i*j}");
                j++;
            }
            Console.WriteLine("===================");
            i++;
        }
        */
        #endregion
        #region Tinh (2n+2)!

        /*
         * int N, i, M, GT;
        Console.WriteLine("Nhap N:");
        N = int.Parse(Console.ReadLine());
        i = 1;
        GT = 1*2;            
        while(i <= N)
        {
            M = 2 * i + 2;
            GT *= M*(M-1);               
            i++;
        }
        Console.WriteLine(GT);
        */
        #endregion
        #region Ví dụ về out 
        /*
         * int ngayKe, thangKe, namKe;
        Time.NgayKeTiep(8, 9, 2021, out ngayKe, out thangKe, out namKe);
        Console.WriteLine($"{ngayKe} // {thangKe} // {namKe}");
        */
        #endregion
        #region Mảng 1 chiều
        /*
        int[] A;
        A = XL_Mang.NhapMang("Nhap mang A:");
        int S = XL_Mang.TongMang(A);
        Console.WriteLine($"Tong la {S}");
        int max = XL_Mang.GiaTriLonNhat(A);
        int kq = XL_Mang.DemSonNguyenTo(A);
        int giatien = SoNguyenTo.GiaTienSkill(7);
        Console.WriteLine($"Ket qua la {giatien}");
        */
        #endregion
        /*int[] A;
        A = XL_Mang.NhapMang("Nhap mang A:");
        XL_Mang.Xuatmang(A);
        int kq = XL_Mang.TinhTong(A);
        Console.WriteLine("====");
        Console.WriteLine(kq);
        int[] sx = XL_Mang.SapXepTangDan(A);
        XL_Mang.Xuatmang(sx);*/
        /*
        int[,] A;
        A = MaTran.NhapMaTran("Nhap ma tran:");
            int kq = MaTran.DemPhanTuk(A, 30);
        Console.WriteLine($"Ket qua la: {kq}");

        */

        //Console.WriteLine($"Ket qua la: {min}");
    }
}
