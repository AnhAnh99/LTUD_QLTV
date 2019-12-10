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
            int iA, iB, iC;
            String sInput;
            Console.Write("Nhap so thu nhat A: ");
            sInput = Console.ReadLine();
            iA = Convert.ToInt32(sInput);
            Console.Write("Nhap so thu hai B: ");
            sInput = Console.ReadLine();
            iB = Convert.ToInt32(sInput);
            Console.Write("Nhap so thu ba C: ");
            sInput = Console.ReadLine();
            iC = Convert.ToInt32(sInput);
            if (iA > iB && iB > iC)
            {
                Console.WriteLine("A la so lon nhat");
                Console.ReadLine();

            }
            else if (iA < iB && iB > iC)
            {
                Console.WriteLine("B la so lon nhat");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("C la so lon nhat");
                Console.ReadLine();
            }


        }
    }
}
