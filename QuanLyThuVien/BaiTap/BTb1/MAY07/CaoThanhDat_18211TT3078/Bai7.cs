using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baitap
{
    class Bai7
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Nhap N= ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("N la so chan +1 = " + (num + 1));
            }
            else
            {
                Console.WriteLine("N la so le -1 = " + (num -1));
            }
            Console.ReadKey();
        }
    }
}