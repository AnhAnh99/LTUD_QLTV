using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2;

            Console.Write("Nhập vào giá trị của N1: ");
            N1 = Int32.Parse(Console.ReadLine());
            Console.Write("Nhập vào giá trị của N2:");
            N2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Tổng hai số là: {0}", N1 + N2);
            Console.WriteLine("Hiệu hai số là: {0}", N1 - N2);
            Console.WriteLine("Tích hai số là: {0}", N1 * N2);
            Console.WriteLine("Thương hai số là: {0}", N1 / N2);

            Console.ReadLine();
        }
    }
}
