using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum1, iNum2, iTong;
            String sInput;
            Console.Write("Nhap so thu nhat A: ");
            sInput = Console.ReadLine();
            iNum1 = Convert.ToInt32(sInput);
            Console.Write("Nhap so thu hai B: ");
            sInput = Console.ReadLine();
            iNum2 = Convert.ToInt32(sInput);
            iTong = iNum1 + iNum2;
            Console.Write("Tong cua " + iNum1 + " va " + iNum2 + " la: " + iTong);
            Console.ReadLine();
        }
    }
}
