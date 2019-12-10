using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nA, nB;
            Console.Write("nhap gia tri A: ");
            nA = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap gia tri B: ");
            nB = Convert.ToInt32(Console.ReadLine());
            int nKq = nA + nB;
            Console.WriteLine("tong cua " + nA + " va " + nB + " la: " + nKq);
            Console.ReadKey();
        }
    }
}
