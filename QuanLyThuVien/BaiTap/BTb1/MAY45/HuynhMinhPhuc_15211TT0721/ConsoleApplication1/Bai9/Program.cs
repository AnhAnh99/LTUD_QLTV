using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, swap;
            String userInput;
            Console.Write("Nhap gia tri num 1: ");
            userInput = Console.ReadLine();
            num1 = Convert.ToInt32(userInput);
            Console.Write("Nhap gia tri num 2: ");
            userInput = Console.ReadLine();
            num2 = Convert.ToInt32(userInput);

            swap = num1;
            num1 = num2;
            num2 = swap;
           
            Console.WriteLine("gia tri moi cua num1 la: " + num1);
            Console.WriteLine("gia tri moi cua num2 la: " + num2);
            Console.ReadLine();
        }
    }
}
