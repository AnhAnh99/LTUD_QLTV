using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nA;
            Console.Write("Nhap so nguyen duong: ");
            nA = Convert.ToInt32(Console.ReadLine());
            if (nA % 2 == 0)
            {
                Console.WriteLine(nA + " la so chan");
            }
            else
            {
                Console.WriteLine(nA + " la so le");
            }
            Console.ReadLine();
        }
    }
}
