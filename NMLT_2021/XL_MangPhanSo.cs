using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    class XL_MangPhanSo
    {
        public static PHANSO[] NhapMangPhanSo(string ghiChu)
        {
            PHANSO[] P;
            Console.WriteLine(ghiChu);            
            Console.WriteLine("Nhap so luong phan tu cua mang:");
            int n = int.Parse(Console.ReadLine());
            P = new PHANSO[n];
            for (int i = 0; i < P.Length; i++)
            {
                Console.WriteLine($"Nhap P[{i}]");
                P[i] = XL_PhanSo.NhapPhanSo($"Nhap P[{i}]:");
            }
            return P;
        }
        public static void XuatMangPhanSo(PHANSO[] P)
        {
            for (int i = 0; i < P.Length; i++)
            {
                Console.WriteLine($"Phan so {i}");
                XL_PhanSo.XuatPhanSo(P[i]);
            }
        }
        public static PHANSO TongMang(PHANSO[] P)
        {
            PHANSO S = P[0];
            for (int i = 1; i < P.Length; i++)
            {
                S = XL_PhanSo.TinhTong2PhanSo(S, P[i]);
            }
            return S;
        }

    }
}
