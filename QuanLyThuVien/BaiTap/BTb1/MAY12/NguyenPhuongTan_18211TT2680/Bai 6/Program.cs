using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nA = 0;
            Console.Write("Nhap vao nguyen A: ", nA);
            nA = Convert.ToInt32(Console.ReadLine());
            if (nA % 2 == 0)
            {
                Console.Write("So: " + nA +" la so chan.");
                Console.Read();
            }
            else {
                Console.Write("So: " + nA + " la so le.");
                Console.Read();
            }
        }
    }
}
