using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            num1 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
                Console.WriteLine("So chan");
            else
                Console.WriteLine("So le");
            Console.ReadLine();
        }
    }
}
