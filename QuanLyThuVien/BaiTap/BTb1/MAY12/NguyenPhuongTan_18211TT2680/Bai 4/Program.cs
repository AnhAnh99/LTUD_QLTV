using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nA =0;
            int nB=0;           
            Console.Write("Nhap vao a: ", nA);
            nA=Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao b: ", nB);
            nB= Convert.ToInt32(Console.ReadLine());
            int nTong = nA + nB;
            int nTru = nA - nB;
            int nNhan = nA * nB;
            Console.Write("Phep cong: " + nTong);
            Console.WriteLine();
            Console.Write("Phep tru: " + nTru);
            Console.WriteLine();
            Console.Write("Phep nhan: " + nNhan);
            Console.Read();
        }
    }
}
