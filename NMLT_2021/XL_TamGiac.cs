
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    public struct TAMGIAC
    {
        public DIEM A;
        public DIEM B;
        public DIEM C;
    }

    class XL_TamGiac
    {
        public static TAMGIAC NhapTamGiac(string ghiChu)
        {
            TAMGIAC kq;
            Console.WriteLine(ghiChu);
            kq.A = XL_Diem.NhapDiem("Nhap diem A:");
            kq.B = XL_Diem.NhapDiem("Nhap diem B:");
            kq.C = XL_Diem.NhapDiem("Nhap diem C");
            return kq;
        }
        public static void XuatTamGiac(TAMGIAC tg)
        {
            Console.WriteLine($"Diem A: {tg.A}, Diem B {tg.B}, Diem C {tg.C}");
        }
        public static double TinhChuVi(TAMGIAC tg)
        {
            return XL_Diem.TinhKhoangCach(tg.A, tg.B) + XL_Diem.TinhKhoangCach(tg.A, tg.C) + XL_Diem.TinhKhoangCach(tg.B, tg.C);
        }
    }
}
