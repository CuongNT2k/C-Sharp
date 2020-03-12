using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class bai4
    {
        static void Main(string [] args)
        {
            int n, S1 = 0, S2 = 1, S3 = 0;
            Console.WriteLine("Nhap so n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                S1 = S1 + i;
                S2 = S2 * i;
                S3 = S3 + i * (i + 1);
            }
            Console.WriteLine("S1= {0} S2= {1} S3= {2}", S1, S2, S3);
            Console.ReadKey();
        }
    }
}