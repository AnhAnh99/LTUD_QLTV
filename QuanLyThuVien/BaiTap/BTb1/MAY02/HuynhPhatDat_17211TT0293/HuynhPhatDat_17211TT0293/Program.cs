using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuynhPhatDat_17211TT0293
{
    class Program
    {

        static void Main(string[] args)
        {
            //Xuất Dòng HelloFitTDC lên màn hình
            Console.WriteLine("Hello FIT-TDC");
            Console.WriteLine("-------------------\n");
            // nhập tên cùng dòng come to TDC
            string name;
            Console.WriteLine("Input Your Name:");
            name = Console.ReadLine();
            Console.WriteLine(name + "come to TDC");
            Console.WriteLine("-------------------\n");
            // khởi tạo vào gán biến
            int n1 = 100;
            int n2 = n1;
            Console.WriteLine("Value:"+ n2);
            //  nhập hai biến và xuất biểu thức toán học
            Console.WriteLine("Input value a:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Input value b:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Summation:");
            Console.WriteLine(a + "+" + b);
            Console.WriteLine("Subtraction:");
            Console.WriteLine(a + "+" + b);
            Console.WriteLine("Muliplication:");
            Console.WriteLine(a + "+" + b);
            Console.WriteLine("Division:");
            Console.WriteLine(a + "+" + b);
            Console.WriteLine("------------------\n");
            // nhập hai biến và xuất tổng
            Console.WriteLine("Input value num1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input value num2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Result:" +(num1 + num2));
            Console.WriteLine("------------------\n");
            //nhập số nguyên dương và kiểm tra chẵn lẻ
            Console.WriteLine("Input value:");
            int iR = int.Parse(Console.ReadLine());
            int iRe = iR % 2;
            if (iRe == 0)
            {
                Console.WriteLine("Value is an even number!");
            }
            else
            {
                Console.WriteLine("Value is an odd number!");
            }
            //nhập số nguyên dương và kiểm tra tăng khi là số chẵn giảm khi là số lẻ
            Console.WriteLine("Input value:");
            int iR1 = int.Parse(Console.ReadLine());
            int iRe1 = iR % 2;
            if (iRe1 == 0)
            {
                Console.WriteLine("Value is an even number!");
                iRe1++;
                Console.WriteLine("Post Value is:" + iRe1);
            }
            else
            {
                Console.WriteLine("Value is an odd number!");
                iRe1--;
                Console.WriteLine("Post Value is:" + iRe1--);
            }
            Console.WriteLine("------------------\n");
            // tính commission
            Console.WriteLine("Input value sale_1:");
            float sale_1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Input value sale_2:");
            float sale_2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Input value commission_rate:");
            float commission_rate = float.Parse(Console.ReadLine());
            float total_sale = sale_1 + sale_2;
            Console.WriteLine("commission result:" + total_sale*commission_rate);
            //hoán vị
            int temp;
            Console.WriteLine("input first value:");
            int st = int.Parse(Console.ReadLine());
            Console.WriteLine("input second value:");
            int sc = int.Parse(Console.ReadLine());

            temp = st;
            st = sc;
            sc = temp;
            Console.WriteLine("New First value{0}, New second value{1}",st, sc);
            
            Console.ReadLine();
        }
    }
}
