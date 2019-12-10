using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Bai5
    {
        static void Main(string[] args)
        {
            int nA, nB;
            Console.Write("Nhap gia tri a: ");
            nA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia tri b: ");
            nB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong {0} va {1}: {2}", nA, nB, (nA + nB));
            Console.ReadKey();
        }
    }
}
