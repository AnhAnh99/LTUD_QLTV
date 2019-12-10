using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B6
{
    class Program
    {
        static void Main(string[] args)
        {
            //dong nhac nhap tu ban phim kieu so nguyen
            Console.Write("Nhap So nguyen duong: ");
            int iSo = int.Parse(Console.ReadLine());
            if (iSo % 2 == 0)
                Console.WriteLine("Là số chẵn");
            else
                Console.WriteLine("Là số lẽ");
           
            Console.Read();
        }
    }
}
