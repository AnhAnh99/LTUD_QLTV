using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Bai4
    {
        static void Main(string[] args)
        {
            int nA, nB;
            Console.Write("Nhap gia tri a: ");
            nA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia tri b: ");
            nB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong a va b: " + (nA + nB));
            Console.WriteLine("Hieu a va b: " + (nA - nB));
            Console.WriteLine("Tich a va b: " + (nA * nB));
            Console.WriteLine("Thuong a va b: " + (nA / nB));
            Console.ReadKey();
        }
    }
}
