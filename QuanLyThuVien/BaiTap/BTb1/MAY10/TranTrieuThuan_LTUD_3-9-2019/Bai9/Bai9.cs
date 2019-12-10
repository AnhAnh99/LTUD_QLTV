using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            int nA, nB, nCache;
            Console.Write("nhap gia tri A: ");
            nA = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap gia tri B: ");
            nB = Convert.ToInt32(Console.ReadLine());
            nCache = nA;
            nA = nB;
            nB = nCache;
            Console.WriteLine("gia tri cua A: " + nA);
            Console.WriteLine("gia tri cua B: " + nB);
            Console.ReadKey();
        }
    }
}
