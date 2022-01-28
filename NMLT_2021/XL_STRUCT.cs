using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    
    public struct PHANSO1
    {
        public int tuSo;
        public int mauSo;
    }
    public struct HONSO
    {
        public int phanNguyen;
        public PHANSO1 phanPhanso;        
    }

    public struct DIEM2
    {
        public int x;
        public int y;
    }
    public struct DIEM3
    {
        public int x;
        public int y;
        public int z;
    }

    public struct DAGIAC2
    {
        public DIEM2[] dsdinh;
    }
    public struct DONTHUC2
    {
        public int heSo;
        public int soMu;
    }
    public struct NGAY
    {
        public int ngay;
        public int thang;
        public int nam;
    }
    public struct DUONGTRON
    {
        public DIEM2 toaDoTam;
        public double banKinh;
    }

    class XL_STRUCT
    {
        //Ngay
        public static NGAY NhapNgay(string ghiChu)
        {
            NGAY date;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ngay:");
            date.ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang:");
            date.thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam:");
            date.nam = int.Parse(Console.ReadLine());
            return date;
        }
        public static string XuatNgay(NGAY date)
        {
            return $"{date.ngay}/{date.thang}/{date.nam}";
        }
        //Phan so
        public static PHANSO1 NhapPhanSo1(string ghiChu)
        {
            PHANSO1 p;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap tu so:");
            p.tuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so:");
            p.mauSo = int.Parse(Console.ReadLine());
            return p;
        }
        public static string XuatPhanSo(PHANSO1 a)
        {
            return $"{a.tuSo}/{a.mauSo}";
        }
        public static PHANSO1 CongHaiPhanSo(PHANSO1 a, PHANSO1 b)
        {
            PHANSO1 p;
            p.tuSo = a.tuSo * b.mauSo + b.tuSo * a.mauSo;
            p.mauSo = a.mauSo * b.mauSo;
            return p;
        }
        //Hon so
        public static HONSO NhapHonSo(string ghiChu)
        {
            HONSO a;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap phan nguyen:");
            a.phanNguyen = int.Parse(Console.ReadLine());
            a.phanPhanso = NhapPhanSo1("Nhap phan phan so:");
            return a;
        }
        public static string XuatHonSo(HONSO a)
        {
            return $"Hon so co phan nguyen la {a.phanNguyen}, phan phan so la {XuatPhanSo(a.phanPhanso)}";
        }
        public static PHANSO1 ChuyenHsthanhPhanSo(HONSO a)
        {
            PHANSO1 kq;
            kq.tuSo = a.phanNguyen * a.phanPhanso.mauSo + a.phanPhanso.tuSo;
            kq.mauSo = a.phanPhanso.mauSo;
            return kq;
        }
        public static PHANSO1 Cong2HonSo(HONSO a, HONSO b)
        {
            return CongHaiPhanSo(ChuyenHsthanhPhanSo(a), ChuyenHsthanhPhanSo(b));
        }
        // Diem
        public static DIEM2 NhapDiem2(string ghiChu)
        {
            DIEM2 A;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap toa do x:");
            A.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do y:");
            A.y = int.Parse(Console.ReadLine());
            return A;
        }
        public static string XuatDiem2(DIEM2 A)
        {
            return $"Diem A co toa do x la: {A.x}, toa do y la: {A.y}";
        }
        public static double TinhKhoangCach2Diem(DIEM2 A, DIEM2 B)
        {
            return Math.Sqrt((A.x - B.x) * (A.x - B.x) + (A.y - B.y) * (A.y - B.y)); 
        }
        // Diem 3 chieu
        public static DIEM3 NhapDiem3Chieu(string ghiChu)
        {
            DIEM3 D;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap toa do x:");
            D.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do y:");
            D.y = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do z:");
            D.z = int.Parse(Console.ReadLine());
            return D;
        }
        public static string XuatDiem3Chieu(DIEM3 D)
        {
            return $"Diem co toa do x: {D.x}, toa do y: {D.y}, toa do z: {D.z}";
        }
        //Da giac
        public static DAGIAC2 NhapDaGiac2(string ghiChu)
        {
            DAGIAC2 dg;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap so dinh cua da giac:");
            int dinh = int.Parse(Console.ReadLine());
            dg.dsdinh = new DIEM2[dinh];
            for (int i = 0; i < dg.dsdinh.Length; i++)
            {
                Console.WriteLine($"Nhap dinh {i}");
                dg.dsdinh[i] = NhapDiem2($"Nhap toa do cho dinh {i}");
            }
            return dg;
        }
        public static void XuatDaGiac(DAGIAC2 dg)
        {
            for (int i = 0; i < dg.dsdinh.Length; i++)
            {
                Console.WriteLine($"Dinh {i} co toa do la: {XuatDiem2(dg.dsdinh[i])}");
            }
        }
        //Don thuc
        public static DONTHUC2 NhapDonThuc(string ghiChu)
        {
            DONTHUC2 dt;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap he so:");
            dt.heSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so mu:");
            dt.soMu = int.Parse(Console.ReadLine());
            return dt;
        }
        public static double TinhDonThuc(DONTHUC2 a, int x)
        {
            return a.heSo * Math.Pow(x, a.soMu);
        }
        //Duong tron
        public static DUONGTRON NhapDuongTron(string ghiChu)
        {
            DUONGTRON dt;
            Console.WriteLine(ghiChu);
            dt.toaDoTam = NhapDiem2("Nhap toa do tam");
            Console.WriteLine("Nhap ban kinh:");
            dt.banKinh = double.Parse(Console.ReadLine());
            return dt;
        }
        public static string XuatDuongTron(DUONGTRON O)
        {
            return $"Duong trong co toa do tam la: {O.toaDoTam} va ban kinh la: {O.banKinh}";
        }
        public static double TinhDienTichHinhTron(DUONGTRON O)
        {
            return 3.14 * O.banKinh * O.banKinh;
        }
        public static double TinhChuViHinhTron(DUONGTRON O)
        {
            return 3.14 * O.banKinh * 2;
        }
    }
}
