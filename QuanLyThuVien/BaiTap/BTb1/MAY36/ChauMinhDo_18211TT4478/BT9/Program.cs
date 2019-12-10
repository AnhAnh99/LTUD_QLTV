using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT9
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum1;
            Console.Write("Nhap Num1 ");
            iNum1 = int.Parse(Console.ReadLine());
            int iNum2;
            Console.Write("Nhap Num2 ");
            iNum2 = int.Parse(Console.ReadLine());
            int iNum3;
            iNum3 = iNum1;
            iNum1 = iNum2;
            iNum2 = iNum3;
            Console.WriteLine("Num1 " + iNum1);
            Console.WriteLine("Num2 " + iNum2);
            Console.ReadLine();
        }
    }
}
