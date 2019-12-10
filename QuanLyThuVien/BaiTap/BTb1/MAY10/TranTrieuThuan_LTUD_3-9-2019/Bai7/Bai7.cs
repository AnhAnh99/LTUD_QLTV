using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nA;
            Console.Write("nhap vao gia tri: ");
            nA = Convert.ToInt32(Console.ReadLine());
            if(nA%2==0)
            {
                nA += 1;
                Console.WriteLine("Gia tri sau khi tang: " + nA);
            }
            else
            {
                nA -= 1;
                Console.WriteLine("Gia tri sau khi giam: " + nA);
            }
            Console.ReadKey();
        }
    }
}
