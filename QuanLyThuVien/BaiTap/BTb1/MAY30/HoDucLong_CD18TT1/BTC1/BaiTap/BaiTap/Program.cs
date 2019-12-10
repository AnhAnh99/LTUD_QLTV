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
            //cau 1:
            Console.WriteLine("Hello FIT-TDC");

            //cau 2:
            Console.Write("Ten: ");
            string sTen = (Console.ReadLine());
            Console.WriteLine("Chao mung" + " " + sTen + " den voi FIT-TDC");
          
            //cau 3:
            int iA = 100;
            int iB = iA;
            Console.Write("ket qua b: ");
            Console.WriteLine(iB = iA);
            //cau 4:
            Console.Write("Nhap a: ");
            int nC = 6;
            int nD = 3;

            Console.Write("c + d: ");
            Console.WriteLine(nC + nD);
            Console.Write("c - d: ");
            Console.WriteLine(nC - nD);
            Console.Write("c * d: ");
            Console.WriteLine(nC * nD);
            Console.Write("c / d: ");
            Console.WriteLine(nC / nD);
  

            //cau 5:
            Console.Write("Nhap a: ");
            int nA = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int nB = int.Parse(Console.ReadLine());

            Console.Write("a + b: ");
            Console.WriteLine(nA+ nB);

            //cau 6:
            Console.Write("Nhap: ");
            int nN = int.Parse(Console.ReadLine());
            if (nN % 2 == 0)
            {
                Console.WriteLine(nN + "La so chan");
            }
               
            else
            {
                Console.WriteLine(nN + "La so le");
            }
            //cau 7:
            Console.Write("Nhap: ");
            int nNum = int.Parse(Console.ReadLine());
            if (nNum % 2 == 0)
                Console.WriteLine(nNum + 1);
            else
                Console.WriteLine(nNum - 1);
      

            //cau 8:
            Console.Write("Nhap sale_1: ");
            int sale_1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap sale_2: ");
            int sale_2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap commission_rate: ");
            int commission_rate = int.Parse(Console.ReadLine());
            int total_sale = sale_1 + sale_2;
            int commission = total_sale * commission_rate;
            Console.WriteLine("Commission: " + commission);

            //cau 9:
            Console.Write("Nhap: ");
            int nNum1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap: ");
            int nNum2 = int.Parse(Console.ReadLine());

            int tem = nNum1;
            nNum1 = nNum2;
            nNum2 = tem;
            Console.WriteLine("Cout: " + nNum1);
            Console.WriteLine("Cout: " + nNum2);

            //cau 10:
            Console.Write("Nhap a: ");
            int a = int .Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            int c = int.Parse(Console.ReadLine());

            int max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            Console.WriteLine("So lon nhat trong 3 so: " + max);
            //cau 11:
            Console.Write("Nhap so: ");
            int number = int.Parse(Console.ReadLine());
            switch(number)
            {
                case 1:
                    {
                        Console.WriteLine("Mot");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Hai");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Ba");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Bon");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Nam");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Sau");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Bay");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Tam");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Chin");
                        break;
                    }
                default:
                    Console.WriteLine("0' doc dc");
                    break;
            }

            //cau 12:
            Console.Write("Nhap vao so nguyen duong: ");
            int soDuong = int.Parse(Console.ReadLine());
            if(soDuong < 2 )
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
            Console.ReadLine();
        }
    }

}
