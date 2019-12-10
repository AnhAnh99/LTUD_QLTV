using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B4
{
    class Program
    {
        static void Main(string[] args)
        {
            //dong nhac nhap tu ban phim 2 bien iA, iB kieu so nguyen
            Console.Write("Nhap gia tri 1: ");
            int iA = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri 2: ");
            int iB = int.Parse(Console.ReadLine());

            int iCong = iA + iB;
            //xuat ket qua khi cong 2 bien
            Console.WriteLine("Cong A + B: {0}", iCong);

            int iTru = iA - iB;
            //xuat ket qua khi tru 2 bien
            Console.WriteLine("Tru A - B: {0}", iTru);

            int iNhan = iA * iB;
            //xuat ket qua khi nhan 2 bien
            Console.WriteLine("Nhan A * B: {0}", iNhan);

            int iChia = iA / iB;
            //xuat ket qua khi chia 2 bien
            Console.WriteLine("Chia A / B: {0}", iChia);

            Console.Read();

        }
    }
}
