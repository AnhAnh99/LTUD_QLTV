using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnTap
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Moi ban nhap ten: ");
    //        Console.Write("Chao mung " + Console.ReadLine() + " den voi FIT-TDC");
    //        Console.Read();
    //    }
    //}

    //class Cau3
    //{
    //    static void Main(string[] args)
    //    {
    //        int a = 100;
    //        int b = a;
    //        Console.Write(b);
    //        Console.ReadLine();
    //    }
    //}

    //class Cau4
    //{
    //    static void Main(string[] args)
    //    {
    //        double a, b;
    //        Console.Write("Nhap a: ");
    //        a = Convert.ToDouble(Console.ReadLine());
           
    //        Console.Write("Nhap b: ");
    //        b = Convert.ToDouble(Console.ReadLine());

    //        Console.WriteLine("a + b = "+ (a + b));
    //        Console.WriteLine("a - b = " + (a - b));
    //        Console.WriteLine("a * b = " + (a * b));
    //        Console.WriteLine("a / b = " + (a / b));
    //        Console.Read();
    //    }
    //}

    //class Cau5
    //{
    //    static void Main(string[] args)
    //    {
    //        int a, b;
    //        Console.Write("Nhap a: ");
    //        a = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("Nhap b: ");
    //        b = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("Tong cua " + a + " va " + b + " la: " + (a + b));
    //        Console.Read();
    //    }
    //}

    //class Cau6
    //{
    //    static void Main(string[] args)
    //    {
    //        int a;
    //        do
    //        {
    //            Console.Write("Nhap a > 0: ");
    //            a = Convert.ToInt32(Console.ReadLine());
    //        } while (a <= 0);
            
    //        if(a % 2 == 0)
    //        {
    //            Console.Write("La so chan");
    //        }
    //        else
    //        {
    //            Console.Write("La so le");
    //        }
    //        Console.Read();
    //    }
    //}

    //class Cau7
    //{
    //    static void Main(string[] args)
    //    {
    //        int a;
    //        do
    //        {
    //            Console.Write("Nhap a > 0: ");
    //            a = Convert.ToInt32(Console.ReadLine());
    //        } while (a <= 0);

    //        if(a % 2 == 0)
    //        {
    //            a++;
    //        }
    //        else
    //        {
    //            a--;
    //        }
    //        Console.Write("Gia tri moi cua a: " + a);
    //        Console.Read();
    //    }
    //}

    //class Cau8
    //{
    //    static void Main(string[] args)
    //    {
    //        double sale_1, sale_2, commission_rate, total_sale, commission;
    //        Console.Write("Nhap sale_1: ");
    //        sale_1 = Convert.ToDouble(Console.ReadLine());
    //        Console.Write("Nhap sale_2: ");
    //        sale_2 = Convert.ToDouble(Console.ReadLine());

    //        Console.Write("Nhap commission_rate: ");
    //        commission_rate = Convert.ToDouble(Console.ReadLine());

    //        total_sale = sale_1 + sale_2;
    //        Console.WriteLine("total_sale = "+ total_sale);

    //        commission = total_sale * commission_rate;
    //        Console.Write("commission = " + commission);
    //        Console.Read();
    //    }
    //}

    //class Cau9
    //{
    //    static void Main(string[] args)
    //    {
    //        double num1, num2;
    //        Console.Write("Nhap num1: ");
    //        num1 = Convert.ToDouble(Console.ReadLine());
    //        Console.Write("Nhap num2: ");
    //        num2 = Convert.ToDouble(Console.ReadLine());

    //        double temp = num1;
    //        num1 = num2;
    //        num2 = temp;
    //        Console.WriteLine("Num1: " + num1);
    //        Console.Write("Num2: " + num2);
    //        Console.Read();
    //    }
    //}

    //class Cau10
    //{
    //    static void Main(string[] args)
    //    {
    //        double a, b, c;
    //        Console.Write("Nhap a: ");
    //        a = Convert.ToDouble(Console.ReadLine());
    //        Console.Write("Nhap b: ");
    //        b = Convert.ToDouble(Console.ReadLine());
    //        Console.Write("Nhap c: ");
    //        c = Convert.ToDouble(Console.ReadLine());

    //        double max = a;
    //        if(max < b)
    //        {
    //            max = b;
    //        }
    //        if(max < c)
    //        {
    //            max = c;
    //        }
    //        Console.Write("Max = " + max);
    //        Console.Read();
    //    }
    //}

    //class Cau11
    //{
    //    static void Main(string[] args)
    //    {
    //        int a;
           
    //            Console.Write("Nhap 0 <= a <= 9: ");
    //            a = Convert.ToInt32(Console.ReadLine());
            

    //        switch(a)
    //        {
    //            case 0:
    //                {
    //                    Console.Write("Khong");
    //                    break;
    //                }
    //            case 1:
    //            {
    //                Console.Write("Mot");
    //                break;
    //            }
    //            case 2:
    //                {
    //                    Console.Write("Hai");
    //                    break;
    //                }
    //            case 3:
    //                {
    //                    Console.Write("Ba");
    //                    break;
    //                }
    //            case 4:
    //                {
    //                    Console.Write("Bon");
    //                    break;
    //                }
    //            case 5:
    //                {
    //                    Console.Write("Nam");
    //                    break;
    //                }
    //            case 6:
    //                {
    //                    Console.Write("Sau");
    //                    break;
    //                }
    //            case 7:
    //                {
    //                    Console.Write("Bay");
    //                    break;
    //                }
    //            case 8:
    //                {
    //                    Console.Write("Tam");
    //                    break;
    //                }
    //            case 9:
    //                {
    //                    Console.Write("Chin");
    //                    break;
    //                }
    //            default:
    //                {
    //                    Console.Write("Khong doc duoc");
    //                    break;
    //                }
    //        }

    //        Console.Read();
    //    }
    //}

    class Cau12
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen duong n: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            if(kiemTraSNT(n) == true)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write("0");
            }
            
            Console.Read();
        }

        static bool kiemTraSNT(int n)
        {
            try
            {
                if (n < 2)
                {
                    return false;
                }
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                        return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
