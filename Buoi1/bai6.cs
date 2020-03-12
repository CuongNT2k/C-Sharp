using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class bai6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So nguyen n: ");
            int n = int.Parse(Console.ReadLine()),i = 2;
            while (n > 0)
            {
                while (n % i == 0)
                {
                    n /= i;
                    if (n == 1)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + " x ");
                    }
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
