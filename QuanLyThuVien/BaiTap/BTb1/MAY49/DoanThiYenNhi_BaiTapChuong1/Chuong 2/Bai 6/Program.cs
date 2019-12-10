using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int iN, iKiemTra;

            Console.Write("Nhập vào số nguyên dương bất kỳ: ");
            iN = Int32.Parse(Console.ReadLine());

            iKiemTra = iN % 2;
            if(iKiemTra == 0)
            {
                Console.WriteLine("{0} là số chắn", iN);

            }
            else
            {
                Console.WriteLine("{0} là số lẻ", iN);
           
            }

            Console.ReadLine();
        }
    }
}
