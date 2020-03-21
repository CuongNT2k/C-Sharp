using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class Bai1
    {
        static void Main(string[] args)
        {
            int n = Nhapn();
            int[] a = new int[n];
            Console.WriteLine("Nhap mang: ");
            Nhapmang(a, n);
            Console.WriteLine("Phan tu o vi tri x: ");
            ttnt(a);
            Console.ReadKey();
        }
        static int Nhapn()
        {
            int n;
            do
            {
                Console.WriteLine("Nhap do nguyen duong n: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            return n;
        }

        static void Nhapmang(int[] mang, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a["+i+"]=");
                mang[i] = int.Parse(Console.ReadLine());
            }    
        }

        static bool nt (int n)
        {
            if (n < 2) return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }    
            }
            return true;
        }

        static void ttnt(int[] mang)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                if (nt(i))
                {
                    Console.Write(" " + mang[i] + " ");
                }
            }
        }
    }
}