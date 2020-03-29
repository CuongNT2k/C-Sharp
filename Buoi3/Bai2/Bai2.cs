using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Buoi3
{
    class Bai2
    {
        static void Main(string[] args)
        {
            Ttb2 a = new Ttb2(1, 1, 1);
            Ttb2 b = new Ttb2(2, 2, 2);
            Ttb2 Tong = a + b;
            Ttb2 Hieu = a - b;
            a--;
            Console.WriteLine("Phuong trinh doi dau: ");
            a.Xuat();
            Console.WriteLine("Tong 2 phuong trinh: ");
            Tong.Xuat();
            Console.WriteLine("Hieu 2 phuong trinh: ");
            Hieu.Xuat();

            Console.ReadKey();
        }
    }
}
