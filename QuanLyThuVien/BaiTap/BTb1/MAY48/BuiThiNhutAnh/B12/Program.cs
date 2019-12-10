using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B12
{
    class Program
    {
        static void Main(string[] args)
        {
            //dong nhac nhap tu ban phim
            Console.Write("Nhap gia tri: ");
            int iA = int.Parse(Console.ReadLine());

            int dem=0;

            for (int i = 1; i <= iA; i++)
            {
                if (iA % i == 0)
                    dem++;
            }

            if (dem == 2)
                Console.WriteLine(" 1 ");
            else
                Console.WriteLine(" 0 ");


            Console.Read();
        }
    }
}
