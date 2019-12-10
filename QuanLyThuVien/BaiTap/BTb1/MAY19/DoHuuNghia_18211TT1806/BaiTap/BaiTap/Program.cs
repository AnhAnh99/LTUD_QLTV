using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai 1:
            Console.WriteLine("Hello FIT-TDC");
            //Bai 2:
            Console.WriteLine("Nhap ten:  ");
            string sName = Console.ReadLine();
            Console.WriteLine("Chao Mung " + sName + " den voi FIT-TDC");
            //Bai 3:
            int nN = 100;
            int nX = nN;
            Console.WriteLine("nN duoc gan cho nX: {0}", nX);
            //Bai 4:
            Console.OutputEncoding = Encoding.UTF8;
            int A;
            Console.WriteLine("Nhap A: ");
            A = Int32.Parse(Console.ReadLine());
            int B;
            Console.WriteLine("Nhap B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hai so vua nhap la: {0} va {1}", A, B);
            Console.WriteLine("{0} + {1} = {2} ", A, B, A + B);
            Console.WriteLine("{0} - {1} = {2} ", A, B, A - B);
            Console.WriteLine("{0} * {1} = {2} ", A, B, A * B);
            Console.WriteLine("{0} / {1} = {2} ", A, B, A / B);
            //Bai 5:
            int M;
            Console.WriteLine("Nhap M: ");
            M = Int32.Parse(Console.ReadLine());
            int N;
            Console.WriteLine("Nhap N: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong cua {0} va {1} la: {2}", M, N, M + N);
            //Bai 6:
            int Y = 0;
            Console.WriteLine("Nhap Y: ");
            if (Y % 2 == 0)
            {
                Console.WriteLine("La so chan");
            }
            else
            {
                Console.WriteLine("La so le");
            }
            Console.Read();
        }
    }
}