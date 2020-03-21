using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class Bai7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thuc c: ");
            float c = float.Parse(Console.ReadLine());
            float xm = 1, fact = 1, i = 1, s=0;
            while ((xm / fact) >= c)
            {
                s += xm / fact;
                xm *= x;
                fact *= i;
                i++;
            }
            Console.WriteLine("e^x = " + s);
            Console.ReadKey();
        }
    }
}
