using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            float iNum1;
            
            Console.Write("Nhap so thu nhat A: " );
            iNum1 = float.Parse(Console.ReadLine());
            float iNum2;
            Console.Write("Nhap so thu nhat B: " );
            iNum2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Tong cua "+ iNum1+" va " + iNum2+" la "+(iNum1+iNum2));
            Console.ReadLine();
        }
    }
}
