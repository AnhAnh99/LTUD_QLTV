using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nA, nB,nKQ;
            Console.Write("Nhap gia tri cho A: ");
            nA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia tri cho B: ");
            nB = Convert.ToInt32(Console.ReadLine());
            nKQ = nA + nB;
            Console.WriteLine("Ket qua cho phep cong: "+nKQ);
            nKQ = nA - nB;
            Console.WriteLine("Ket qua cho phep tru: " + nKQ);
            nKQ = nA * nB;
            Console.WriteLine("Ket qua cho phep nhan: " + nKQ);
            nKQ = nA / nB;
            Console.WriteLine("Ket qua cho phep chia: " + nKQ);
            Console.ReadKey();
        }
    }
}
