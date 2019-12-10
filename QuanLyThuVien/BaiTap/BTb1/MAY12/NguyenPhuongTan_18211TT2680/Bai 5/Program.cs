using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nA = 0;
            int nB = 0;
            Console.Write("Nhap vao so thu nhat: ", nA);
            nA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ", nB);
            nB = Convert.ToInt32(Console.ReadLine());
            int nTong = nA + nB;
            Console.Write("Phep cong cua: "+ nA+ " va " +nB+" la: "  + nTong);
            Console.Read();
        }
    }
}
