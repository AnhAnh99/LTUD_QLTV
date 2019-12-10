using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            a:
            int i;
            string userInput;
            Console.Write("Nhap vao so nguyen tu 0 den 9: ");
            userInput = Console.ReadLine();
            i = Convert.ToInt32(userInput);
            if( i>=0 && i <= 9)
            {
                switch(i)
                {
                    case 0:
                        Console.WriteLine("khong");
                        Console.ReadLine();
                        break;
                    case 1:
                        Console.WriteLine("mot");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("hai");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("ba");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("bon");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("nam");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("sau");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("bay");
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("tam");
                        Console.ReadLine();
                        break;
                    case 9:
                        Console.WriteLine("chin");
                        Console.ReadLine();
                        break;

                }
              
            }
            else
            {
                Console.WriteLine("- Khong doc duoc");
                Console.WriteLine("- Moi ban nhap lai");
                goto a;
            }
        }
    }
}
