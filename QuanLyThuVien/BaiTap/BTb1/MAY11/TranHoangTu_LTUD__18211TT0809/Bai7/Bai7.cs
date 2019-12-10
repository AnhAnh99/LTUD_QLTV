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
            int nNum;
            Console.Write("Nhap so nguyen duong: ");
            nNum = Convert.ToInt32(Console.ReadLine());
            if (nNum % 2 == 0)
            {
                Console.WriteLine("La so chan nen so moi se la: " + (nNum + 1));
            }
            else
            {
                Console.WriteLine("La so le nen so moi se la: " + (nNum - 1));
            }
            Console.ReadLine();
        }
    }
}
