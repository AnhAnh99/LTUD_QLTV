using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baitap
{

    class Bai13
     public static Boolean kiemtraSNT(int nA)
    {
        bool check = true;
        for (int i = 2; i < nA; i++)
        {
            if (nA % i == 0)
            {
                check = true;
            }
            else
            {
                check = false;
            }
        }
    }

    static void Main(string[] args)
    {
        int nN = 0;

        Console.Write("Nhap N= ");
        nN = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i < nN; i++)
        {
            if (kiemtraSNT(i) == true)
            {
                Console.WriteLine("tat ca SNT la: " + i);
            }
        }

        Console.ReadKey();
    }
}
}