using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            //1:
            System.Console.WriteLine("Hello FIT-TDC");
            Console.WriteLine("Nhap vao ten cua ban:");
            string name = Console.ReadLine();
            //2:
            Console.WriteLine("Chao mung " + name + " den voi FIT-TDC ");
            Console.ReadKey();
            //3:
            int n = 100;
            int m = n;
            Console.WriteLine("m = " + m);
            Console.ReadLine();
            //4:
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap a:");

            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 so vua nhap la {0} va {1}", a, b);

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, a * 1.0 / b);
            Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
            Console.ReadKey();
            //5
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap so 1 la a:");

            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so 2 la b:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong cua " + num1 + " va " + num2 + " la : ");
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);

            Console.ReadKey();
            //6 
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap so nguyen duong:");
            int snd = Convert.ToInt32(Console.ReadLine());
            int rem1;
            rem1 = snd % 2;
            if (rem1 == 0)

                Console.WriteLine("{0} la so chan", snd);
            else
                Console.WriteLine("{0} la so le", snd);

            Console.ReadKey();
            //7:
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap so nguyen duong:");
            int snd2 = Convert.ToInt32(Console.ReadLine());
            int rem2;
            rem2 = snd % 2;
            if (rem2 == 0)

                Console.WriteLine("{0} la so chan", snd2);
            else
                Console.WriteLine("{0} la so le", snd2);
            Console.WriteLine("gia tri moi cua num la " + snd2 + 1);

            Console.ReadKey();
            //8:
            Console.WriteLine("Nhap so sale_1 la:");

            int sale1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so sale_2 la:");
            int sale2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so commission_rate la:");
            int com1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("total_sale = sale_1 + sale_2 " + sale1 + sale2);
        }
    }
}
