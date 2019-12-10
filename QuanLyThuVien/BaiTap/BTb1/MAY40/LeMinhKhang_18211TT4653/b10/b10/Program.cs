using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, max;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
