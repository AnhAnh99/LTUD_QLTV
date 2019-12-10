using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baitap
{
    class Bai12
    {
        static void Main(string[] args)
        {
            int nN = 0;
            int nDem = 0;
            Console.Write("Nhap N= ");
            nN = Convert.ToInt32(Console.ReadLine());
           for(int i = 2; i < nN; i++)
            {
                if(nN % i == 0)
                {
                    nDem++;
                }
            }
           if(nDem == 0)
            {
                Console.WriteLine("1");
            }
           else
            {
                Console.WriteLine("0");
            }
            Console.ReadKey();
        }
    }
}