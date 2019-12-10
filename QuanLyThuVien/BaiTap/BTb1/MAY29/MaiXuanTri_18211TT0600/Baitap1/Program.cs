using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baitap1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cau1
            Console.WriteLine("Hello FIT-TDC");
            //Cau2
            string sTen = Console.ReadLine();
            Console.WriteLine("Chao mung " + sTen + " den voi FIT-TDC");
            //Cau3
            int iN1 = 100;
            int iN2 = iN1;
            //Cau4
            Console.Write("Nhap A = ");
            int iN3 = int.Parse(Console.ReadLine());
            Console.Write("Nhap B = ");
            int iN4 = int.Parse(Console.ReadLine());
            Console.Write("Bieu thuc cong A va B : " + iN3 + " + " + iN4 + "\n");
            Console.Write("Bieu thuc tru A va B : " + iN3 + " - " + iN4 + "\n");
            Console.Write("Bieu thuc nhan A va B : " + iN3 + " * " + iN4 + "\n");
            Console.Write("Bieu thuc chia A va B : " + iN3 + " / " + iN4 + "\n");
            //Cau5
            Console.Write("Nhap so thu nhat A : ");
            int iNum1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai B : ");
            int iNum2 = int.Parse(Console.ReadLine());
            int iTong = iNum1 + iNum2;
            Console.WriteLine("Tong cua " + iNum1 + " va " + iNum2 + " la : " + iTong);
            //Cau6
            Console.Write("\nNhap so nguyen duong : ");
            int iSND = int.Parse(Console.ReadLine());
            if (iSND % 2 == 0)
            {
                Console.WriteLine(iSND + " la so chan");
            }
            else
            {
                Console.WriteLine(iSND + " la so le");
            }
            //Cau7
            Console.Write("\nNhap so nguyen duong : ");
            int iNum = int.Parse(Console.ReadLine());
            if (iNum % 2 == 0)
            {
                iNum += 1;
            }
            else
            {
                iNum -= 1;
            }
            Console.WriteLine("Gia tri moi cua Num : " + iNum);
            //Cau8
            Console.Write("\nNhap sale 1 : ");
            int iSale1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap sale 2 : ");
            int iSale2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap comission_rate : ");
            int iCommissionRate = int.Parse(Console.ReadLine());
            int iTotalSale = iSale1 + iSale2;
            int iCommission = iTotalSale * iCommissionRate;
            Console.WriteLine("Gia tri conmission : " + iCommission);
            //Cau9
            Console.Write("\nNhap A : ");
            int iA = int.Parse(Console.ReadLine());
            Console.Write("Nhap B : ");
            int iB = int.Parse(Console.ReadLine());
            int iTemp = 0;
            iTemp = iA;
            iA = iB;
            iB = iTemp;
            Console.Write("\nNew A : " + iA);
            Console.Write("\nNew B : " + iB);
            //Cau10
            Console.Write("\n\nNhap X : ");
            int iX = int.Parse(Console.ReadLine());
            Console.Write("Nhap Y : ");
            int iY = int.Parse(Console.ReadLine());
            Console.Write("Nhap Z : ");
            int iZ = int.Parse(Console.ReadLine());
            int iMAX = 0;
            if (iX > iY && iX > iZ)
            {
                iMAX = iX;
            }
            else if (iY > iZ)
            {
                iMAX = iY;
            }
            else
            {
                iMAX = iZ;
            }
            Console.Write("So lon nhat la : " + iMAX);
            //Cau11
            int iR;
            Console.WriteLine("\n\nNhap vao so nguyen tu 0 den 9 : ");
            iR = int.Parse(Console.ReadLine());
            switch (iR)
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
                    Console.WriteLine("Khong doc duoc");
                    break;
            }
            //Cau12
            Console.Write("Nhap vao so nguyen : ");
            int iCheck = int.Parse(Console.ReadLine());
            int iDem = 0;
            for (int i = 1; i <= iCheck; i++)
            {
                if (iCheck % i == 0)
                {
                    iDem++;
                }
            }
            if (iDem == 2)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
            //Cau13
            Console.ReadLine();
        }
    }
}
