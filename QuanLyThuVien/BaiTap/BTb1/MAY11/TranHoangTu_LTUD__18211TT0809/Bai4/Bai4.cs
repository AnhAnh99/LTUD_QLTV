using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nM, nN, nTong, nHieu, nTich;
            float nThuong;

            Console.Write("Nhap so thu nhat: ");
            nN = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            nM = Convert.ToInt32(Console.ReadLine());

            nTong = nM + nN;
            Console.WriteLine("Tong = " + nTong);

            nHieu = nM - nM;
            Console.WriteLine("Hieu = " + nHieu);

            nTich = nM * nN;
            Console.WriteLine("Tich = " + nTich);

            nThuong = nM / nN;
            Console.WriteLine("Thuong = " + nThuong);
            Console.ReadLine();
        }
    }
}
