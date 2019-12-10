using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap8
{
    class Program
    {
        static void Main(string[] args)
        {
            float fSale_1;
            Console.Write("Nhap gia tri Sale_1:");
            fSale_1 = float.Parse(Console.ReadLine());
            float fSale_2;
            Console.Write("Nhap gia tri Sale_2:");
            fSale_2 = float.Parse(Console.ReadLine());
            float commission_rate;
            Console.Write("Nhap gia tri commission_rate:");
            commission_rate = float.Parse(Console.ReadLine());
            //total_sale
            float total_sale = (fSale_1 + fSale_2);
            Console.WriteLine("total_sale = " + total_sale);
            //commission
            float commission = total_sale * commission_rate;
            Console.WriteLine("commission = " + commission);
            Console.ReadLine();
        }
    }
}
