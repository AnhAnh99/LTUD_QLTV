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
            int nA, nB;
            Console.Write("nhap gia tri cho A: ");
            nA = Convert.ToInt32(Console.ReadLine());
           
            if(nA%2==0)
            {
                Console.WriteLine("So chan: "+nA);
            }
            else
            {
                Console.WriteLine("So le: "+nA);

            }

            Console.ReadKey();
        }
    }
}
