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
            int nA, nB, nCom_Rate, nTotal,nCom;
            Console.Write("Nhap gia tri cho Sale_1: ");
            nA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia tri cho Sale_2: ");
            nB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia tri cho commission_rate: ");
            nCom_Rate = Convert.ToInt32(Console.ReadLine());
            nTotal = nA + nB;
            nCom = nTotal * nCom_Rate;
            Console.WriteLine("gia tri commission: " + nCom);
            Console.ReadLine();
        }
    }
}
