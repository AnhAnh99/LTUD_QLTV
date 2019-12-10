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
            int x = 6;
            int y = 3;
            int tong, hieu, tich, thuong;
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
            tong = x + y;
            Console.WriteLine("Tong: X + Y = " + tong);
            hieu = x - y;
            Console.WriteLine("Hieu: X - Y = " + hieu);
            tich = x * y;
            Console.WriteLine("Tich: X * Y = " + tich);
            thuong = x / y;
            Console.WriteLine("Thuong: X / Y = " + thuong);
            Console.ReadLine();


        }
    }
}
