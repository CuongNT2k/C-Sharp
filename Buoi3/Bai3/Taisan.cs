using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class Taisan
    {
        private string tenTs;
        private int soLuong;
        private string tinhTrang;

        public string TenTs { get => tenTs; set => tenTs = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public Taisan()
        {

        }

        public void Nhap()
        {
            Console.WriteLine("\t\tNhap thong tin phong\t\t");
            Console.WriteLine("Ten tai san: ");
            TenTs = Console.ReadLine();
            Console.WriteLine("So luong : ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Tinh trang tai san: ");
            TinhTrang = Console.ReadLine();
        }
        
        public void Xuat()
        {
            Console.WriteLine("\t\tTen: "+TenTs+"\t\tSo Luong: "+SoLuong+"\t\tTinh trang: "+TinhTrang);
        }

        public static int Tong(Taisan taisan, int n)
        {
            return taisan.SoLuong * n;
        }
    }
}
