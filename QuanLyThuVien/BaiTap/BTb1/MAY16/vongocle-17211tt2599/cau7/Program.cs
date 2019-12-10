using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cau7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("\n\n");
            Console.Write("Nhap mot so nguyen bat ky: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = num1 % 2;
            if (num2 == 0)
                Console.WriteLine("{0} la so chan.\n", num1 + 1);
            else
                Console.WriteLine("{0} la so le.\n", num1 - 1);

            Console.ReadLine();
        }
    }
}
