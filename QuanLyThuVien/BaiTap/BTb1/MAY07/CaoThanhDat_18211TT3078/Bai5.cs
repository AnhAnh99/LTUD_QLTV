using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baitap
{
    class Bai5
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            Console.Write("Nhap so thu nhat A: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai B: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong cua " + num1 + " va " + num2 + " la: " + (num1 + num2));
            Console.ReadKey();
        }
    }
}