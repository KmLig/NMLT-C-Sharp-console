using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{    
    public struct DONTHUC
    {
        public int heSo;
        public int soMu;
    }
    class Program
    {
        public static DONTHUC NhapDonThuc(string ghiChu)
        {
            DONTHUC KQ;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap he so:");
            KQ.heSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so mu:");
            KQ.soMu = int.Parse(Console.ReadLine());
            return KQ;
        }

        public static string XuatPhanSo(PHANSO p)
        {
            return $"{p.TuSo}/{p.MauSo}";
        }
        
        
        public static double TinhDonThuc(DONTHUC d, double x)
        {
            return d.heSo * Math.Pow(x, d.soMu);
        }
        static void Main(string[] args)
        {
            #region;
            /*DONTHUC a;
            a = NhapDonThuc("Nhap don thuc a:");
            int x0 = 3;
            double kq = TinhDonThuc(a, x0);
            string Chuoi = "Ket qua la " + kq;
            Console.WriteLine(Chuoi);*/

            /*
            DIEM a, b;
            a = NhapDiem("Nhap phan so a:");
            b = NhapDiem("Nhap phan so b:");
            double kc = TinhKhoangCach(a, b);
            string kq = "Ket qua la " + kc;
            Console.WriteLine(kq);
            */
            #endregion
            /*int[] A;
            A = XL_Mang.NhapMang("Nhap mang mot chieu:");
            XL_Mang.Xuatmang(A);
            int kq = XL_Mang.TimGiaTriNguyenToLonNhi(A);
            string Chuoi = "Ket qua la " + kq;
            Console.WriteLine(Chuoi);
            Console.WriteLine($"Gia tri la: {A[kq]}");*/

            /*PHANSO A = XL_PhanSo.NhapPhanSo("Nhap phan so:");
            PHANSO B = XL_PhanSo.NhapPhanSo("Nhap phan so:");
            PHANSO C = XL_PhanSo.TinhTong2PhanSo(A,B);
            string ketqua = XuatPhanSo(C);
            Console.WriteLine(ketqua);
            TINH KhanhHoa = XL_Tinh.NhapTinh("Khanh Hoa");
            XL_Tinh.XUATTINH(KhanhHoa);*/
            /*DONTHUC2 A = XL_STRUCT.NhapDonThuc("Nhap don thuc a:");
            int x = 4;
            double kq = XL_STRUCT.TinhDonThuc(A, x);
            Console.WriteLine($"Ket qua la {kq}");*/
            //TINH A = XL_Tinh.NhapTinh("Nhap tinh a");
            //XL_Tinh.XUATTINH(A);

            Console.WriteLine("nhap a:");
            Console.ReadLine();






        }
    }
}
