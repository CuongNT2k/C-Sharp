using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class bai5
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap n");
            n = int.Parse(Console.ReadLine());
            bool nt = true;
            if (n < 2)
            {
                Console.WriteLine("Khong phai so nguyen to");
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        nt = false;
                        break;
                    }
                    
                }
                Console.WriteLine(nt ? "La so nguyen to" : "Khong phai so nguyen to");
            }
            Console.ReadKey();
        }
    }
}
