using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            a:
            int num;
            String userInput;
            Console.Write("Nhap vao so nguyen duong: ");
            userInput = Console.ReadLine();
            num = Convert.ToInt32(userInput);
            if (num >= 0)
            {
                if (num % 2 == 0)
                {
                    num++;
                }
                else
                {
                    num--;
                }
                Console.WriteLine("Gia tri moi cua num la: " + num);
                Console.ReadLine();
            }
            else
            {
                goto a;
            }
        }
    }
}
