using System;

namespace Baitap
{
    class bai2
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Nhap 3 so thuc k am: ");
            do
            {
                a = float.Parse(Console.ReadLine());
                b = float.Parse(Console.ReadLine());
                c = float.Parse(Console.ReadLine());
            } while (a < 0 || b < 0 || c < 0);

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a * a + b * b == c * c || a * a + c * c == b * b || c * c + b * b == a * a)
                {
                    if (a == b || a == c || b == c)
                        Console.WriteLine("Tam giac vuong can");
                    else
                        Console.WriteLine("Tam giac vuong");
                }
                else if (a == b && a == c)
                    Console.WriteLine("Tam giac deu");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("Tam giac can");
                else
                    Console.WriteLine("Tam giac thuong");
            }
            else
                Console.WriteLine("Khong phai tam giac");
            Console.ReadKey();
        }

    }
}
