using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int nA = 0;
            int nB = 0;
            int nC = 0;
            Console.Write("Nhap vao so A: ", nA);
            nA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so B: ", nB);
            nB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so C: ", nC);
            nC = Convert.ToInt32(Console.ReadLine());
            if (nA > nB)
            {
                if (nA > nC)
                {
                    Console.Write("So lon nhat la A = " + nA);
                }
                else
                {
                    Console.Write("So lon nhat la C = " + nC);
                }
            }
            else if(nB>nC)
            {
                Console.Write("So lon nhat la B = " + nB);
            }
            else Console.Write("So lon nhat la C = " + nC);
            Console.Read();
        }
    }
}
