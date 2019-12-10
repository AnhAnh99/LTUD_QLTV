using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B7
{
    class Program
    {
        static void Main(string[] args)
        {
            //dong nhac nhap tu ban phim kieu so nguyen
            Console.Write("Nhap So nguyen duong: ");
            int iSo = int.Parse(Console.ReadLine());
            if (iSo % 2 == 0)
            {
                iSo = iSo + 1;
                           }
            else
            {
                iSo = iSo - 1;
            }
            Console.WriteLine("Ket qua: {0}", iSo);

            Console.Read();
        }
    }
}
