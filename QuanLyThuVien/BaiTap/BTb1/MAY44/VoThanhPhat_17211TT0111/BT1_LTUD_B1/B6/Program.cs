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
            a:
            int iN = 0;
            String sInput;
            Console.Write("Nhap so nguyen duong: ");
            sInput = Console.ReadLine();
            iN = Convert.ToInt32(sInput);
            if (iN >= 0)
            {
                if (iN % 2 == 0)
                {
                    Console.WriteLine("So vua nhap la so chan");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("So vua nhap la so le");
                    Console.ReadLine();

                }

            }

            else
                goto a;



        }
    }
}
