using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baitap
{
    class Bai10
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            Console.Write("Nhap a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b= ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c= ");
            c = Convert.ToInt32(Console.ReadLine());
            int max = a;
            if(b > max)
            {
                max = b;
            }
            if(c > max)
            {
                max = c;
            }
            Console.WriteLine("Max = " + max);
            Console.ReadKey();
        }
    }
}