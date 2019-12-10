using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap11
{
    class Program
    {

        static void Main(string[] args)
        {
            int sSo ;
            Console.Write("Nhap tu 0 - 9: ");
            sSo =int.Parse(Console.ReadLine());
            switch(sSo)
            {
                case 1:Console.WriteLine("So Mot");
                    break;
                case 2:
                    Console.WriteLine("So Hai");
                    break;
                case 3:
                    Console.WriteLine("So Ba");
                    break;
                case 4:
                    Console.WriteLine("So Bon");
                    break;
                case 5:
                    Console.WriteLine("So Nam");
                    break;
                case 6:
                    Console.WriteLine("So Sau");
                    break;
                case 7:
                    Console.WriteLine("So Bay");
                    break;
                case 8:
                    Console.WriteLine("So Tam");
                    break;
                case 9:
                    Console.WriteLine("So Chin");
                    break;
                default:
                    Console.WriteLine("Khong doc duoc");
                    break;
            }
            Console.ReadLine();

        }
    }
}
