using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int iN1, iN2, iTemp;

            Console.Write("Nhập vào giá trị của số thứ nhất: ");
            iN1 = Int32.Parse(Console.ReadLine());
            Console.Write("Nhập vào giá trị của số thứ hai:");
            iN2 = Int32.Parse(Console.ReadLine());

            iTemp = iN1;
            iN1 = iN2;
            iN2 = iTemp;

            Console.WriteLine("HOÁN VỊ");
            Console.WriteLine("Giá trị của số thứ nhất là : {0}", iN1);
            Console.WriteLine("Giá trị của số thứ hai là : {0}", iN2);

            Console.ReadLine();

     
        }
    }
}
