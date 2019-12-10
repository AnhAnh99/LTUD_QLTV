using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B10
{
    class Program
    {
        static void Main(string[] args)
        {
            //dong nhac nhap tu ban phim
            Console.Write("Nhap gia tri 1: ");
            int iA = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri 2: ");
            int iB = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri 3: ");
            int iC = int.Parse(Console.ReadLine());

            if (iA > iB)
            {
                if (iA > iC)
                    Console.WriteLine("So thu nhat la so lon nhat trong ba so.");
                else
                    Console.WriteLine("So thu ba la so lon nhat trong ba so.");
            }
            else if (iB > iC)
                Console.WriteLine("So thu hai la so lon nhat trong ba so.");
            else
                Console.WriteLine("So thu ba la so lon nhat trong ba so.");

            Console.Read();
        }
    }
}
