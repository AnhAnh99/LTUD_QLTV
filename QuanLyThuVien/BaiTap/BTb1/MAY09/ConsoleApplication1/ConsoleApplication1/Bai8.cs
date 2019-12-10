using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai8
{
    class Bai8
    {
        static void Main(string[] args)
        {
            int nSale1, nSale2,nCommission_rate;
            Console.Write("Nhap gia tri Sale1: ");
            nSale1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia tri Sale2: ");
            nSale2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap commission_rate: ");
            nCommission_rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total: " + (nSale1 + nSale2));
            Console.WriteLine("Commission: {0}", ((nSale1 + nSale2) * nCommission_rate));
            Console.ReadKey();
        }
    }
}
