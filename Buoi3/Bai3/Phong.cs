using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class Phong
    {
        private string tenPhong;
        private string maPhong;
        private string truongPhong;

        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TruongPhong { get => truongPhong; set => truongPhong = value; }

        public Phong()
        {

        }

        public void Nhap()
        {
            Console.WriteLine("\t\tNhap thong tin phong\t\t");
            Console.WriteLine("Ten phong: ");
            TenPhong = Console.ReadLine();
            Console.WriteLine("Ma phong: ");
            MaPhong = Console.ReadLine();
            Console.WriteLine("Truong phong: ");
            TruongPhong = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("\t\tTen phong: "+TenPhong+"\t\tMa phong: "+MaPhong+"\t\tTruong phong: "+TruongPhong);
        }
    }
}
