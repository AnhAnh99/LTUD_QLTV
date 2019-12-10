using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baitap
{
    class Bai6
    {
        static void Main(string[] args)
        {
            int nN = 0;
            Console.Write("Nhap N= ");
            nN = Convert.ToInt32(Console.ReadLine());
            if(nN % 2 == 0)
            {
                Console.WriteLine("N la so chan");
            }
            else
            {
                Console.WriteLine("N la so le");
            }
            Console.ReadKey();
        }
    }
}