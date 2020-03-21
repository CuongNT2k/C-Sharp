using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class bai3
    {
        static string[] str;
        static void Main(string[] args)
        {
            Console.WriteLine("Mhap chuoi : ");
            string s = Console.ReadLine();
            Split(s);
            ht();
            Console.ReadKey();
        }
        static void Split(string s)
        {
            str = s.Split(' ');
            Console.Write("str[]= ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + ",");
            }
        }
        static void ht()
        {
            Console.WriteLine("\nHo: " + str[0]);
            Console.WriteLine("Ten Dem: " + str[1]);
            Console.WriteLine("Ten: " + str[2]);
            Console.WriteLine("nam Sinh: " + str[3]);
            int x = DateTime.Now.Year - int.Parse(str[str.Length - 1]);
            Console.WriteLine("Tuoi: {0}", x);
        }
    }
}
