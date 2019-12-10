using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap6
{
    /// <summary>
    /// chuong trinh Kiem tra so chan hoac so le
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int iN;
            Console.Write("Nhap vao so nguyen: ");
            iN = int.Parse(Console.ReadLine());
            if(iN % 2 == 0)
            {
                Console.WriteLine("La so chan");
            }
            else
            {
                Console.WriteLine("La so le");
            }
            Console.ReadLine();
        }
    }
}
