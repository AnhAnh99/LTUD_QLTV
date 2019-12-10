using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT7
{
    class Program
    {
        static void Main(string[] args)
        {
            int iN;
            Console.Write("Nhap vao so N : ");
            iN = int.Parse(Console.ReadLine());
            if (iN % 2 == 0)
            {
                Console.Write("SO Chan : " + (iN + 1));
            }
            else
            {
                Console.Write("SO le");
            }
            Console.ReadLine();
        }
    }
}
