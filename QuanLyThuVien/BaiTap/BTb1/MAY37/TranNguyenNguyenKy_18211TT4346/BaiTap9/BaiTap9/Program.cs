using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap9
{
    /// <summary>
    /// Hoan vi
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int iNum1;
            Console.Write("Nhap num1:");
            iNum1 = int.Parse(Console.ReadLine());
            int iNum2;
            Console.Write("Nhap num2:");
            iNum2 = int.Parse(Console.ReadLine());
            int iNum3;
            iNum3 = iNum1;
            iNum1 = iNum2;
            iNum2 = iNum3;
            Console.WriteLine(iNum1);
            Console.WriteLine(iNum2);
            Console.ReadLine();

        }
    }
}
