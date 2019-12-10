using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT6
{
    class Program
    {
        static void Main(string[] args)
        {
            int iN;
            Console.Write("Nhap vao so nguyen ");
            iN = int.Parse(Console.ReadLine());
            if(iN % 2 ==0)
            {
                Console.WriteLine("La So Chan");
            }
            else
            {
                Console.WriteLine("La So Le");
            }
            Console.ReadLine();
        }
    }
}
