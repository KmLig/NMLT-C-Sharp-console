using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    class Class1
    {
        public int SoNgayTrongThang(int ngay, int thang, int nam)
        {
            Console.WriteLine("Nhập thang:");
            thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập nam:");
            nam = int.Parse(Console.ReadLine());
            ngay = 31;
            if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                ngay = 31;
            }
            else if (thang == 2)
            {
                if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                {
                    ngay = 30;
                }
                else
                {
                    ngay = 28;
                }
            }
            return ngay; 
        }
    }
}
