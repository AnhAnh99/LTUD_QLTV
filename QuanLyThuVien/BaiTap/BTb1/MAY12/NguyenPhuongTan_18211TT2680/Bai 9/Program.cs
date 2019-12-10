using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_9
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
            Console.Write("thu tu hai gia tri ban dau: " + nA + "  " + nB);
            int tam = 0;
            tam = nA;
            nA = nB;
            nB = tam;
            Console.WriteLine();
            Console.Write("thu tu hai gia tri ban dau: " + nA + "  " + nB);
            Console.Read();
        }
    }
}
