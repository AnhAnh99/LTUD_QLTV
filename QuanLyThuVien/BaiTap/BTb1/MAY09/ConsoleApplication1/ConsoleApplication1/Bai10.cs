using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            Console.Write("Nhap gia tri A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia tri B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia tri C: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("{0} lon nhat", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("{0} lon nhat", b);
            }
            else
            {
                Console.WriteLine("{0} lon nhat", c);
            }
            Console.ReadKey();
        }
    }
}