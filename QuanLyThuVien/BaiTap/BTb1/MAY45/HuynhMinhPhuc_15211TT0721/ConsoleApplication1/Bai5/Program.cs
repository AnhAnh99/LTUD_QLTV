using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,tong;
            String userInput;
            ///nhap so thu nhat
            Console.Write("Nhap so thu nhat A: ");
            userInput = Console.ReadLine();
            ///doi qua Int
            num1 = Convert.ToInt32(userInput);
            ///nhap so thu hai
            Console.Write("Nhap so thu hai B: ");
            userInput = Console.ReadLine();
            ///doi qua Int
            num2 = Convert.ToInt32(userInput);
            tong = num1 + num2;
            Console.WriteLine("Tong cua " + num1 + " va " + num2 + " la: " + tong );
            Console.ReadLine();

        }
    }
}
