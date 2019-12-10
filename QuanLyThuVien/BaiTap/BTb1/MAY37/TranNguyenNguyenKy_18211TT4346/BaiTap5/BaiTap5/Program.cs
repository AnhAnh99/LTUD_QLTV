using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap5
{
    //Chuong trinh nhap vao num1 , num2 va thuc hien chuc nang
    class Program
    {
        static void Main(string[] args)
        {
            float iNum1;
            Console.Write("Nhap so thu nhat A: ");
            iNum1 = float.Parse(Console.ReadLine());
            float iNum2;
            Console.Write("Nhap so thu nhat B: ");
            iNum2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Tong cua " + iNum1 + " Va " + iNum2 + " La: " + (iNum1 + iNum2));
            Console.ReadLine();

        }
    }
}
