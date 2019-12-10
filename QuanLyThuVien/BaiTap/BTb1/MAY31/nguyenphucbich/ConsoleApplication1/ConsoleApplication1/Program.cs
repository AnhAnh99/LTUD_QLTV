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
            ////cau1:
            //Console.WriteLine("Hello FIT-TDC");
            ////cau2:
            //Console.Write(" nhap ten:");
            //string ten= Console.ReadLine();
            //Console.WriteLine("chao mung" + " " +ten + " " +"den voi FIT-TDC");
            ////cau3:
            //int a = 100;
            //int b = 0;
            //Console.Write(" ket qua cua b la:");
            //Console.WriteLine(b = a);
            //cau 4:
            //int nC = 8;
            //int nD = 4;
            //Console.Write(" ket qua cua c+d  la:");
            //Console.WriteLine(nC + nD);
            //Console.Write(" ket qua cua c-d  la:");
            //Console.WriteLine(nC - nD);
            //Console.Write(" ket qua cua c*d  la:");
            //Console.WriteLine(nC * nD);
            //Console.Write(" ket qua cua c/d  la:");
            //Console.WriteLine(nC / nD);
            ////cau5
            //Console.Write(" nhap a:");
            //int nA = int.Parse(Console.ReadLine());
            //Console.Write(" nhap b:");
            //int nB = int.Parse(Console.ReadLine());
            //Console.Write(" ket qua cua a+b  la:");
            //Console.WriteLine(nA+nB);
            //cau6:               
            //    Console.Write(" nhap vao so nguyen duong:");
            //    int nE = int.Parse(Console.ReadLine());    
            //if(nE %2 ==0)
            //{
            //    Console.WriteLine(" nE la so chan:");
            //}else
            //{
            //    Console.WriteLine(" nE la so le :");
            //}
            //cau7:
            //Console.Write(" nhap vao so nguyen duong:");
            //int nF = int.Parse(Console.ReadLine());
            //if (nF % 2 == 0)
            //{
            //    Console.WriteLine(nF+1);
            //}
            //else
            //{
            //    Console.WriteLine(nF-1);
            //}
            ////cau8:

            //Console.Write(" nhap sale1:");
            //int sale1 = int.Parse(Console.ReadLine());
            //Console.Write(" nhap sale2:");
            //int sale2 = int.Parse(Console.ReadLine());
            //Console.Write(" nhap commisson_rate:");
            //int commisson_rate = int.Parse(Console.ReadLine());
            //int totalsale = sale1 + sale2;
            //int commisson = totalsale * commisson_rate;
            //Console.WriteLine("commision la:"+ commisson);
            ////cau9:
            //Console.Write(" nhap nN:");
            //int nN = int.Parse(Console.ReadLine());
            //Console.Write(" nhap nM:");
            //int nM = int.Parse(Console.ReadLine());
            //int temp = nN;
            //nN = nM;
            //nM = temp;
            //Console.WriteLine("nN la:"+nN);
            //Console.WriteLine("nM la:"+nM);
            ////cau 10:
            //Console.Write(" nhap nP:");
            //int nP = int.Parse(Console.ReadLine());
            //Console.Write(" nhap nQ:");
            //int nQ = int.Parse(Console.ReadLine());
            //Console.Write(" nhap nR:");
            //int nR = int.Parse(Console.ReadLine());
            //int max = nP;
            //if (max < nQ)
            //{
            //    max = nQ;
            //}
            //if (max < nR)
            //{
            //    max = nR;
            //}
            //Console.WriteLine("So lon nhat trong 3 so " + max);
            ////cau 11:
            Console.Write("nhap so tu 1-9:");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("mot");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("hai");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("ba");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("bon");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("nam ");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("sau");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("bay");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("tam");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("chin");
                        break;
                    }
                
            }
            ////cau12:
            //Console.Write("nhap so:");
            //int num = int.Parse(Console.ReadLine());
            //if (num < 2)
            //{
            //    Console.WriteLine ( " 1");
                
            //}
            //int count = 0;
            //for (int i = 2; i <= sqrt(num); i++)
            //{
            //    if (num % i == 0)
            //    {
            //        count++;
            //    }
            //}
            //if (count == 0)
            //{
            //    Console.WriteLine(" 1");
            //}
            //else
            //{
            //    Console.WriteLine(" 0");
            //}
            Console.ReadLine();
        }
    }
}
