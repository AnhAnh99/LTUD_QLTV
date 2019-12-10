using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,gtLonNhat=0;
            String userInput;
            Console.Write("Nhap so thu nhat A: ");
            userInput = Console.ReadLine();
            a = Convert.ToInt32(userInput);
            Console.Write("Nhap so thu hai B: ");
            userInput = Console.ReadLine();
            b = Convert.ToInt32(userInput);
            Console.Write("Nhap so thu ba C: ");
            userInput = Console.ReadLine();
            c = Convert.ToInt32(userInput);
            ///di tim gia tri lon nhat
            if(a>b && b>c)
            {
                gtLonNhat = a;
            }else if(a<b && b > c)
            {
                gtLonNhat = b;
            }else if(a<b && b < c)
            {
                gtLonNhat = c;
            }
            Console.WriteLine("********Gia tri lon nhat la " + gtLonNhat);
            Console.ReadLine();

        }
    }
}
