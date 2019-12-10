using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B9
{
    class Program
    {
        static void Main(string[] args)
        {
            //dong nhac nhap tu ban phim 2 bien iA, iB kieu so nguyen
            Console.Write("Nhap gia tri num 1: ");
            int iNum1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri num 2: ");
            int iNum2 = int.Parse(Console.ReadLine());

            int c;
            c = iNum1;iNum1 = iNum2;iNum2 = c;
            Console.WriteLine("Hoan vi: Num1 = {0} va Num2 = {1} ",iNum1,iNum2);

            Console.Read();
        }
    }
}
