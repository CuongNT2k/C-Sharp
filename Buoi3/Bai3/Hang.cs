using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class Hang
    {
        public static void Main(string[] args)
        {
            Phieu phieu = new Phieu();
            phieu.nhap();
            Phong phong = new Phong();
            phong.Nhap();
            Console.WriteLine("Nhap so luong tai san: ");
            int n = int.Parse(Console.ReadLine());
            List<Taisan> taisans = new List<Taisan>(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin tai san thu " + (i + 1));
                Taisan taisan = new Taisan();
                taisan.Nhap();
                taisans.Add(taisan);
            }
            phieu.xuat();
            phong.Xuat();
            foreach(Taisan x in taisans)
            {
                x.Xuat();
            }
            Console.WriteLine("Tong so luong: ");
            Console.ReadKey();
        }
    }
}
