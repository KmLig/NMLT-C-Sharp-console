using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    public struct PHANSO
    {
        public int TuSo;
        public int MauSo;
    }

    class XL_PhanSo
    {
        public static PHANSO NhapPhanSo(string Ghichu)
        {
            Console.WriteLine(Ghichu);
            PHANSO kq;
            Console.WriteLine("Nhap tu so:");
            kq.TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so:");
            kq.MauSo = int.Parse(Console.ReadLine());
            return kq;

        }        
        public static void XuatPhanSo(PHANSO p)
        {
            Console.WriteLine($"{p.TuSo}/{p.MauSo}");
        }
        public static PHANSO TinhTong2PhanSo(PHANSO a, PHANSO b)
        {
            PHANSO kq;
            kq.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }
    }
}
