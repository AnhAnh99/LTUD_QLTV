using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baitap
{
    class Bai11
    {
        static void Main(string[] args)
        {
            int nN = 0;
            Console.Write("Nhap N= ");
            nN = Convert.ToInt32(Console.ReadLine());
            switch (nN)
            {
                case 1:
                    Console.WriteLine("Mot");
                    break;
                case 2:
                    Console.WriteLine("Hai");
                    break;
                case 3:
                    Console.WriteLine("Ba");
                    break;
                case 4:
                    Console.WriteLine("Bon");
                    break;
                case 5:
                    Console.WriteLine("Nam");
                    break;
                case 6:
                    Console.WriteLine("Sau");
                    break;
                case 7:
                    Console.WriteLine("Bay");
                    break;
                case 8:
                    Console.WriteLine("Tam");
                    break;
                case 9:
                    Console.WriteLine("Chin");
                    break;
                default:
                    Console.WriteLine("Khong doc duoc ");
                    break;
            }
            Console.ReadKey();
        }
    }
}