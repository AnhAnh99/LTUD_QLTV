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
            int nNum1, nNum2, nTam;
            Console.Write("Nhap So Thu Nhat nNum1: ");
            nNum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap So Thu Hai nNum2: ");
            nNum2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Thu tu hai gia tri ban dau: " + nNum1 + " " + nNum2);
            nTam = nNum1;
            nNum1 = nNum2;
            nNum2 = nTam;
            Console.WriteLine();
            Console.Write("Thu tu hai gia tri sau khi hoan vi: " + nNum1 + " " + nNum2);
            Console.ReadLine();
        }
    }
}
