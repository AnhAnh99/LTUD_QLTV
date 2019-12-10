using System;
namespace Bai12
{
    class Program
    {
        public static bool ktSNT(int a)
        {
            if (a < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int nNum;
            Console.WriteLine("Nhap so nguyen nNum: ");
            nNum = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i < nNum; i++)
            {
                if (ktSNT(i) == true)
                {
                    Console.Write("{0}",i+" ");
                }
            }
            Console.ReadKey();
        }

    }
}