using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B11
{
    class Program
    {
        static void Main(string[] args)
        {
            //dong nhac nhap tu ban phim
            Console.Write("Nhap gia tri: ");
            int iA = int.Parse(Console.ReadLine());

            if (iA >= 0 && iA <= 9)
                Console.WriteLine(" {0} ", iA);
            else
                Console.WriteLine("Khong doc duoc!");

            Console.Read();
        }
    }
}
