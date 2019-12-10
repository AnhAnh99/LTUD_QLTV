using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Bai6
    {
        static void Main(string[] args)
        {
            int nA;
            Console.Write("Nhap gia tri a: ");
            nA = Convert.ToInt32(Console.ReadLine());
            if (nA % 2 == 0)
            {
                Console.WriteLine("{0} la so chan", nA);
            }
            else
            {
                Console.WriteLine("{0} la so le", nA);
            }
            Console.ReadKey();
        }
    }
}
