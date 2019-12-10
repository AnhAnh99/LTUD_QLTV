using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B9
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum1, iNum2,iSwap;
            String sInput;
            Console.Write("Nhap so thu nhat A: ");
            sInput = Console.ReadLine();
            iNum1 = Convert.ToInt32(sInput);
            Console.Write("Nhap so thu hai B: ");
            sInput = Console.ReadLine();
            iNum2 = Convert.ToInt32(sInput);
            iSwap = iNum1;
            iNum1 = iNum2;
            iNum2 = iSwap;
            Console.WriteLine("Gia tri moi sau khi hoan vi cua A la : " + iNum1);
            Console.WriteLine("Gia tri moi sau khi hoan vi cua B la : " + iNum2);

            Console.ReadLine();

        }
    }
}
