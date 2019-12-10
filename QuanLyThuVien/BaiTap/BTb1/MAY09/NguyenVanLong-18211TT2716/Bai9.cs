using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap gia tri A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia tri B: ");
            b = Convert.ToInt32(Console.ReadLine());
            int tam = a;
            a = b;
            b = tam;
            Console.WriteLine("A={0}, B={1}", a, b);
            Console.ReadKey();   
        }
    }
}