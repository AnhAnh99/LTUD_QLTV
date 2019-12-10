using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = int.Parse(Console.ReadLine());
            if(num % 2 == 0)
            {
                num++;
                Console.WriteLine(num);
            }
            else
            {
                num--;
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
