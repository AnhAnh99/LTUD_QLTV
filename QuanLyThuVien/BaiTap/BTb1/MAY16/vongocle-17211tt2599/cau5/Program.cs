using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cau5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.Write("Nhap so thu nhat: /n");
            Console.Write("Nhap so thu hai: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = num1 % 2;
            Console.WriteLine(" Tong của num1 va num2 la:", num1 + num2);
            Console.ReadLine();
        }
    }
}
