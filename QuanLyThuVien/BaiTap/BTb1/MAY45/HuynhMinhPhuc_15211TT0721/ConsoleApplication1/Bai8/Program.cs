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
            int sale_1, sale_2,total_sale, commission_rate,commission;
            String userInput;
            Console.Write("Nhap gia tri sale_1: ");
            userInput = Console.ReadLine();
            sale_1 = Convert.ToInt32(userInput);
            Console.Write("Nhap gia tri sale_2: ");
            userInput = Console.ReadLine();
            sale_2 = Convert.ToInt32(userInput);
            Console.Write("Nhap gia tri commission_rate: ");
            userInput = Console.ReadLine();
            commission_rate = Convert.ToInt32(userInput);
             //tinh total_sale
            total_sale = sale_1 + sale_2;
            //tinh commision
            commission = total_sale * commission_rate;
            Console.WriteLine("Gia tri cua commission la: " + commission);
            Console.ReadLine();


        }
    }
}
