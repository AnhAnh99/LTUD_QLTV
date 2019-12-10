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
            int iNum, iKiemTra;

            Console.Write("Nhập vào số nguyên dương Num: ");
            iNum = Int32.Parse(Console.ReadLine());

            iKiemTra = iNum % 2;
            if (iKiemTra == 0)
            {
                iNum = iNum + 1;

            }
            else
            {
                iNum = iNum - 1;

            }

            Console.Write("Giá trị mới của số nguyên dương Num là: {0}", iNum);

            Console.ReadLine();
        }
    }
}
