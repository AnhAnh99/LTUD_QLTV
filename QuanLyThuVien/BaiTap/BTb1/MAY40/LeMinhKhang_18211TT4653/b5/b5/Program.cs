using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Nhap So Thu Nhat A: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap So Thu Hai B: ");
            num2 = int.Parse(Console.ReadLine());
            int total = num1 + num2;
            Console.Write("Tong cua {0} va {1} la {2}", num1, num2, total);
            Console.ReadLine();

        }
    }
}
