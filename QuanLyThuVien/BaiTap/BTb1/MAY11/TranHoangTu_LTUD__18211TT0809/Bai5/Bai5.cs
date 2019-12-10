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
            int nA, nB, nTong;
            Console.Write("Nhap So Thu Nhat A: ");
            nA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap So Thu Hai B: ");
            nB = Convert.ToInt32(Console.ReadLine());

            nTong = nA + nB;
            Console.WriteLine("Tong cua " + nA + " va " + nB + " la: " + nTong);
            Console.ReadLine();
        }
    }
}
