using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_8
{
    class Program
    {
        static void Main(string[] args)
        {
            float fSale_1 = 0;
            float fSale_2 = 0;
            float fCommission_rate = 0;
            float fTotle_sale = 0;
            float fCommission = 0;
            Console.Write("Nhap vao sale_1: ", fSale_1);
            fSale_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao sale_2: ", fSale_2);
            fSale_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao Commission_rate: ", fCommission_rate);
            fCommission_rate = Convert.ToInt32(Console.ReadLine());
            fTotle_sale = fSale_1 + fSale_2;
            Console.Write("Tong sale: " + fTotle_sale);
            Console.WriteLine();
            fCommission = fCommission_rate * fTotle_sale;
            Console.Write("commission sale: " + fCommission);
            Console.Read();
        }
    }
}
