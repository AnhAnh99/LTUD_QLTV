using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baitap
{
    class Bai9
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            Console.Write("Nhap num1= ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap num2= ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2 );
            Console.ReadKey();
        }
    }
}