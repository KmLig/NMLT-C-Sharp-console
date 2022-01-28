using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    class Time
    {
        public static int NgayToiDaTrongThang(int thang, int nam)
        {
            int ngaytoida = 31;
            if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                ngaytoida = 30;
            }
            else if (thang == 2)
            {
                if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                {
                    ngaytoida = 29;
                }
                else
                {
                    ngaytoida = 28;
                }
            }            
            return ngaytoida;
        }
        public static void NgayKeTiep(int ngay, int thang, int nam, out int ngayKe, out int thangKe, out int namKe)
        {
            ngayKe = ngay + 1;
            thangKe = thang;
            namKe = nam;
            if (ngayKe > NgayToiDaTrongThang(thang, nam))
            {
                ngayKe = 1;
                thangKe += 1;
            }
            if (thangKe > 12)
            {
                thangKe = 1;
                namKe += 1;
            }
        }
    }
}
