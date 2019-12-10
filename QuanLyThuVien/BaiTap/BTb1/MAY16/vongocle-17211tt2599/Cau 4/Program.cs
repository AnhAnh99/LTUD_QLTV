using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cau_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            Console.WriteLine("\nTong cua hai so y+x = " + (x + y));
            Console.WriteLine("\nhieu cua hai so y-x = " + (y - x));
            Console.WriteLine("\nTich cua hai so y*x = " + y * x);
            Console.WriteLine("\nthuong cua hai so y/x = " + y / x);
            Console.WriteLine("\nPhan du cua thuong y/x = " + y % x);

            Console.ReadLine();
        }
    }
}
