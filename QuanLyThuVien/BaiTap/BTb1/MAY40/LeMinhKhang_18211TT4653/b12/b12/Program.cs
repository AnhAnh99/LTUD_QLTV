using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, count = 0;
            num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    count++;
            }
            if (count == 2)
                Console.WriteLine("So Nguyen To");
            else
                Console.WriteLine("Khong phai la So Nguyen To");

            Console.ReadLine();
        }
    }
}
