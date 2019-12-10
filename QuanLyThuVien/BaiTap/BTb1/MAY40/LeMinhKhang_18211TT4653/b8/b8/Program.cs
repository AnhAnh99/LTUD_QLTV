using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b8
{
    class Program
    {
        static void Main(string[] args)
        {
            float sale1, sale2, commision_rate, total_sale, commision;
            sale1 = float.Parse(Console.ReadLine());
            sale2 = float.Parse(Console.ReadLine());
            commision_rate = float.Parse(Console.ReadLine());
            total_sale = sale1 + sale2;
            commision = total_sale * commision_rate;
            //string.Format("{0:n}", total_sale);
            //string.Format("{0:n}", commision);
            Console.Write(total_sale);
            Console.Write(commision);
            Console.ReadLine();
        }
    }
}
