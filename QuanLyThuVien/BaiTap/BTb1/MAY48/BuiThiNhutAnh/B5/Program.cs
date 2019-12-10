using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {
            //dong nhac nhap tu ban phim 2 bien  iNum1 , iNum2 kieu so nguyen
            Console.Write("Nhap So thu nhat A: ");
            int iNum1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap So thu hai B: ");
            int iNum2 = int.Parse(Console.ReadLine());

            int iCong = iNum1 + iNum2;
            //xuat ket qua khi cong 2 bien
            Console.WriteLine("Tong cua {0} va {1} la: {2}",iNum1 ,iNum2,iCong);
            Console.Read();
        }
    }
}
