using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            a:
            int i;
            String userInput;
            Console.Write("Nhap vao so nguyen duong: ");
            userInput = Console.ReadLine();
            i = Convert.ToInt32(userInput);
            if( i > 0)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("So " + i + " la so chan.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("So " + i + " la so le.");
                    Console.ReadLine();
                }
            }
            else
            {
                goto a;
            }
            

        }
    }
}
