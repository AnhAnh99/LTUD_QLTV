using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = int.Parse(Console.ReadLine());
            if (num >= 0 && num <= 100) ;
            {
                for(int i = 1; i < num; i++)
                {
                    int dem = 0;
                    for(int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            dem++;
                    }
                    if(dem == 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
