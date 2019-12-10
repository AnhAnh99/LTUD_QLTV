using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baitap
{
    class Bai4
    {
        static void Main(string[] args)
        {
            int nA = 0;
            int nB = 0;
            Console.Write("Nhap A= ");
            // chuyen tu dang chuoi ve kieu int 
            nA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap B= ");
            nB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A + B =  " + (nA + nB));
            Console.WriteLine("A - B =  " + (nA - nB));
            Console.WriteLine("A * B = " + (nA * nB));
            Console.WriteLine("A / B = " + (nA / nB));
            Console.ReadKey();
        }
    }
}