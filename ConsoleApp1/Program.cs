using System;

namespace ConsoleApp1
{
    class Car
    {
        string color = "red";
        static void Main(string[] args)
        {
            #region
            /*
            //(2n)!
            int N, i, M, GT;            
            Console.WriteLine("Nhap N:");
            N = int.Parse(Console.ReadLine());
            i = 1;
            GT = 1;
            while (i <= N)
            {
                M = i * 2;
                GT *= M * (M - 1);                
                i++;
            }
            Console.WriteLine($"Ket qua la: {GT}");
            
            int N, i;
            int KQ = 1;
            int S;
            Console.WriteLine("Nhap level:");
            N = int.Parse(Console.ReadLine());
            i = 1;            
            while (i < N)
            {
                KQ *= 3;
                i++;                
            }
            S = KQ * 45000;
            Console.WriteLine($"So luong skill level can su dung la: {KQ}");
            Console.WriteLine($"So tien can phai nap: {S}");
            Console.WriteLine("Uoc tinh moi skill co gia 45 000 VND");
            */
            /*
            // Chuyển từ thập sang nhị
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            short x;
            Console.WriteLine("Nhập x:");
            x = short.Parse(Console.ReadLine());
            int[] a = new int[16];
            string s = "";
            for (int i = 15; i >= 0; i--)
            {
                a[i] = (x >> (i)) & 1;
                s += a[i];                
            }
            Console.WriteLine($"Giá trị thập phân của {x} là {s}");
            */
            #endregion
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Car obj = new Car();            
            Console.WriteLine(obj.color);
            
            

        }
    }
}
