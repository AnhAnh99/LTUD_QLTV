using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            //BT 1
            Console.WriteLine("Hello FIT-TDC");
            Console.ReadLine();

            //BT2
            Console.Write("Nhap Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Chao Mung" + " " + Name + " " + "den voi FIT-TDC");
            Console.Read();

            //BT3
            int iOne = 100;
            Console.WriteLine("Gia tri dau: " + iOne);
            int iTwo = 0;
            Console.WriteLine("Gia tri khoi tao: " + iTwo);
            iTwo = iOne;
            Console.WriteLine("Gia tri bang: " + iOne);
            Console.Read();

            //BT4
            Console.Write("Nhap gia tri 1: ");
            float gTri1 = float.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri 2: ");
            float gTri2 = float.Parse(Console.ReadLine());
            float Tong = gTri1 + gTri2;
            float Tru = gTri1 - gTri2;
            float Nhan = gTri1 * gTri2;
            float Chia = gTri1 / gTri2;
            Console.WriteLine("Tong = " + Tong);
            Console.WriteLine("Tru = " + Tru);
            Console.WriteLine("Nhan = " + Nhan);
            Console.WriteLine("Chia = " + Chia);
            Console.Read();

            //BT5
            Console.Write("Nhap So Thu Nhat A: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Nhap So Thu Hai B: ");
            float num2 = float.Parse(Console.ReadLine());
            float Tong = num1 + num2;
            Console.WriteLine("Tong cua" + " " + num1 + " va" + " " + num2 + " la: " + Tong);
            Console.Read();

        //BT6
        TT: Console.Write("Nhap so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                goto TT;
            }
            if (n % 2 == 0)
            {
                Console.WriteLine("La so chan", n);
            }
            else
            {
                Console.WriteLine("La so Le", n);
            }
            Console.Read();

        //BT7
        TT: Console.Write("Nhap so nguyen duong: ");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                goto TT;
            }
            if (num % 2 == 0)
            {
                num = num + 1;
                Console.WriteLine("gia tri moi:" + " " + num);
            }
            else
            {
                num = num - 1;
                Console.WriteLine("gia tri moi:" + " " + num);
            }
            Console.Read();

            //BT8
            Console.Write("Nhap gia tri sale_1: ");
            float sale_1 = float.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri sale_2: ");
            float sale_2 = float.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri commission_rate: ");
            float commission_rate = float.Parse(Console.ReadLine());

            float total_sale = sale_1 + sale_2;
            float commission = total_sale * commission_rate;
            Console.WriteLine("commission" + " " + commission);
            Console.Read();

            //BT9
            Console.Write("Nhap gia tri num1: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri num2: ");
            float num2 = float.Parse(Console.ReadLine());
            float temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("gia tri moi num1: " + num1);
            Console.WriteLine("gia tri moi num2: " + num2);
            Console.Read();

            //BT10
            Console.Write("Nhap gia tri a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri c: ");
            float c = float.Parse(Console.ReadLine());
            if(a > b && a > c)
            {
                Console.WriteLine("a la gia tri lon nhat: ");
            }
            else if(b > a && b > c)
            {
                Console.WriteLine("b la gia tri lon nhat: ");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("c la gia tri lon nhat: ");
            }
            Console.Read();
        }
    }
}
