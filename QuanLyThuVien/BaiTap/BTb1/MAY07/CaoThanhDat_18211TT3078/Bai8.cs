using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baitap
{
    class Bai8
    {
        static void Main(string[] args)
        {
            int sale_1 = 0;
            int sale_2 = 0;
            int commission_rate = 0;
            Console.Write("Nhap sale_1= ");
            sale_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap sale_2= ");
            sale_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap commission_rate= ");
            commission_rate = Convert.ToInt32(Console.ReadLine());
            int total_sale = sale_1 + sale_2;
            int commission = total_sale * commission_rate;
            Console.WriteLine("Total_sale = " + total_sale);
            Console.WriteLine("commission = " + commission);
            Console.ReadKey();
        }
    }
}