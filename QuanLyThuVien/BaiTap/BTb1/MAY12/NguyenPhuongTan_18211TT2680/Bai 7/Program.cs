using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nA = 0;
            Console.Write("Nhap vao nguyen duong: ", nA);
            nA = Convert.ToInt32(Console.ReadLine());
            if (nA % 2 == 0)
            {
                Console.Write("So: " + nA + " la so chan. -> ta co so moi la: " + (nA+1));
                Console.Read();
            }
            else
            {
                Console.Write("So: " + nA + " la so le. ->ta co so moi la: " + (nA-1));
                Console.Read();
            }

        }
    }
}
