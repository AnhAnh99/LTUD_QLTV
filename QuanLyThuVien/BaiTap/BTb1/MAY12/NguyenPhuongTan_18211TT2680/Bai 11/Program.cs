using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int nA = 0;
            nA = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (nA)
                    case '1':
                    Console.Write("Mot");
            } while (nA < 0 || nA > 10);
        }
    }
}
