using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_2021
{
    class Money
    {
        public static void TinhSoTo()
        {
            for (int i = 0; i <= 200; i++)
            {
                for (int j = 0; j <= 100; j++)
                {
                    int Sotienconlai = 200 - i - j * 2;
                    if (Sotienconlai >= 0 && Sotienconlai % 5 == 0)
                    {
                        int z = Sotienconlai / 5;
                        Console.WriteLine($"{i} to 1000, {j} to 2000, {z} to 5000");
                    }
                }
            }
        }
    }
}
