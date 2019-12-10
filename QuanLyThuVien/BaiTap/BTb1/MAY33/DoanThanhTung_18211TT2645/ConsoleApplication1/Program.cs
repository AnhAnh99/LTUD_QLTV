using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.WriteLine("Hello FIT-TDC");

            //2
            //Console.Write("Nhap name: ");
            //string Name= Console.ReadLine();
            //Console.WriteLine("Chao mung"+ " "+  Name + " " +"đen voi FIT-TDC");

            //3
            //int cOne = 100;
            //Console.WriteLine("Gia tri dau: " + cOne);
            //int cTwo = 0;
            //Console.WriteLine("Gia tri hai: " + cTwo);
            //cTwo = cOne;
            //Console.WriteLine("Gia tri mot gan gia tri hai: " + cTwo);

            //4
            //Console.Write("Nhap gia tri 1: ");
            //float bOne = float.Parse(Console.ReadLine());
            //Console.Write("Nhap gia tri 2: ");
            //float bTwo = float.Parse(Console.ReadLine());
            //float Cong = bOne + bTwo;
            //float Nhan = bOne * bTwo;
            //Console.WriteLine("Phep Cong a + b : "+Cong);
            //Console.WriteLine("Phep Nhan a * b :" +Nhan);

            //5
            //Console.Write("Nhap gia tri 1: ");
            //float aOne = float.Parse(Console.ReadLine());
            //Console.Write("Nhap gia tri 2: ");
            //float aTwo = float.Parse(Console.ReadLine());
            //float Tong = aOne + aTwo;
            //Console.WriteLine("Tong cua " + aOne + " Va " + aTwo + " La " + Tong);

            //6
            //TT: Console.Write("Nhap so nguyen duong: ");
            //int ccOne = int.Parse(Console.ReadLine());
            //if (ccOne < 0)
            //{
            //    goto TT;
            //}
            //if (ccOne % 2 == 0)
            //{
            //    Console.WriteLine(ccOne + " la so Chan");
            //}
            //else
            //{
            //    Console.WriteLine(ccOne + " la so Le");
            //}

            //7

            //TT: Console.Write("Nhap so nguyen duong: ");
            // int ccOne = int.Parse(Console.ReadLine());
            // if (ccOne < 0)
            // {
            //     goto TT;
            // }
            // if (ccOne % 2 == 0)
            // {
            //     ccOne = ccOne + 1;
            //     Console.WriteLine(ccOne );
            // }
            // else
            // {
            //     ccOne = ccOne - 1;
            //     Console.WriteLine(ccOne );
            // }

            //8
            //Console.Write("Nhap sale_1: ");
            //float sale_1 = float.Parse(Console.ReadLine());
            //Console.Write("Nhap sale_2: ");
            //float sale_2 = float.Parse(Console.ReadLine());
            //Console.Write("Nhap cm_rate: ");
            //float cm_rate = float.Parse(Console.ReadLine());

            //float total_sale = sale_1 + sale_2;

            //float commission = total_sale * cm_rate;
            //Console.WriteLine("Gia tri commission: "+ commission);

            //9

            //Console.Write("Nhap num1: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Nap num2: ");
            //int num2 = int.Parse(Console.ReadLine());

            //int cc = num2;
            //num2 = num1;
            //num1 = cc;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //10
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b&& a > c )
            {
                Console.WriteLine(a);
            }
            else if(b > a && b >c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }




            Console.Read();

        }

    }

   
}
