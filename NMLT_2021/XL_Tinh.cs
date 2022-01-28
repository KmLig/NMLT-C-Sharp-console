
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    public struct TINH
    {
        public short maTinh;
        public string tenTinh;
        public double dienTich;
    }

    class XL_Tinh
    {
        public static TINH NhapTinh(string ghiChu)
        {
            TINH A;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap Ma Tinh:");
            A.maTinh = short.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten tinh:");
            A.tenTinh = Console.ReadLine();
            if (A.tenTinh.Length > 30)
            {
                throw new Exception("Ky tu phai nho nho 30");
            }
            Console.WriteLine("Nhap dien tich");
            A.dienTich = double.Parse(Console.ReadLine());
            return A;
        }
        public static void XUATTINH(TINH A)
        {
            Console.WriteLine($"Ma tinh: {A.maTinh}");
            Console.WriteLine($"Ten tinh: {A.tenTinh}");
            Console.WriteLine($"Dien tich: {A.dienTich}");
        }
    }
}
