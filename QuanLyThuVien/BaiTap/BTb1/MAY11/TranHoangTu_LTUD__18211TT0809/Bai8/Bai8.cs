using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sale_1, sale_2, commission_rate, total_sale, commission;
            Console.Write("Nhap sale_1: ");
            sale_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap sale_2: ");
            sale_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap commission_rate: ");
            commission_rate = Convert.ToInt32(Console.ReadLine());

            total_sale = sale_1 + sale_2;
            //Console.WriteLine("total_sale = " + total_sale);

            commission = total_sale * commission_rate;
            Console.WriteLine("Commission = " + commission);

            Console.ReadLine();
        }
    }
}
