using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    public struct DIEM
    {
        public int X;
        public int Y;
    }

    class XL_Diem
    {
        public static DIEM NhapDiem(string Ghichu)
        {
            DIEM kq;
            Console.WriteLine(Ghichu);
            Console.WriteLine("Nhap toa do X:");
            kq.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do Y:");
            kq.Y = int.Parse(Console.ReadLine());
            return kq;
        }
        
        public static string XuatDiem(DIEM d)
        {
            return $"Toa do {d.X}; Toa do {d.Y}";
        }
        public static double TinhKhoangCach(DIEM a, DIEM b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }
    }
}
