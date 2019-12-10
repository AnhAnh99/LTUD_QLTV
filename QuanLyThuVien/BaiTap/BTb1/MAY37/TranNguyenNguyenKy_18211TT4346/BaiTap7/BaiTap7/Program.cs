using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap7
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum;
            Console.Write("Nhap vao so num:");
            iNum = int.Parse(Console.ReadLine());
            if (iNum % 2 == 0)
            {
                Console.WriteLine("La so chan");
                iNum = iNum + 1;
            }
            else
            {
                Console.WriteLine("La so le");
                iNum = iNum - 1;
            }
            Console.WriteLine(iNum);
            Console.ReadLine();
        }
    }
}
