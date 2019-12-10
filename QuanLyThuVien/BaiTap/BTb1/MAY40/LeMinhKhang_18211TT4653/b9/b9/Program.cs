using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.ReadLine();

        }
    }
}
