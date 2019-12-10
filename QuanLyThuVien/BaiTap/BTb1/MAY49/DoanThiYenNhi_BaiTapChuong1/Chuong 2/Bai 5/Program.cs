using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int iN1, iN2, iTong;

            Console.Write("Nhập vào giá trị của số thứ nhất: ");
            iN1 = Int32.Parse(Console.ReadLine());
            Console.Write("Nhập vào giá trị của số thứ hai:");
            iN2 = Int32.Parse(Console.ReadLine());
            iTong = iN1 + iN2;

            Console.WriteLine("Tổng hai số {0} và {1} là: {2}", iN1, iN2, iTong);
            Console.ReadLine();
        }
    }
}
