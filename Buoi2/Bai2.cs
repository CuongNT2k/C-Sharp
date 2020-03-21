using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class Bai2
    {
        static void Main(string[] args)
        {
            float A, x;
            int n;
            Nhap(out A, out x, out n);
            Console.WriteLine("Gia tri cua bieu thuc = {0}", bt(A,x,n));
            bt(A,x,n);
            Console.ReadKey();    
        }

        static void Nhap(out float A, out float x, out int n)
        {
            Console.WriteLine("Nhap so thuc A: ");
            A = float.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Nhap so thuc x > 0: ");
                x = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so nguyen 5 <= n <= 20: ");
                n = int.Parse(Console.ReadLine());
            } while (x <= 0 || n < 5 || n > 20);
        }

        static float cb2(float x, int k)
        {
            return (float)Math.Sqrt(Math.Pow(x, k));
        }

        static float bt(float A, float x, int n)
        {
            float S = A;
            for (int i = 1; i <= n; i++)
            {
                S += (float)Math.Pow(-1, i) * cb2(x, i) / (n + 1 - i);
            }
            return S;
        }
    }
}
