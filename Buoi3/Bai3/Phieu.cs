using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class Phieu
    {
        private string maPhieu;
        private string ngayKiem;
        private string nhanVien;
        private string chucVu;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string NgayKiem { get => ngayKiem; set => ngayKiem = value; }
        public string NhanVien { get => nhanVien; set => nhanVien = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }

        public Phieu()
        {

        }

        public void nhap()
        {
            Console.WriteLine("\t\tNhap thong tin phieu\t\t");
            Console.WriteLine("Ma phieu: ");
            MaPhieu = Console.ReadLine();
            Console.WriteLine("Ngay kiem: ");
            NgayKiem = Console.ReadLine();
            Console.WriteLine("Nhan vien kiem: ");
            NhanVien = Console.ReadLine();
            Console.WriteLine("Chuc vu: ");
            ChucVu = Console.ReadLine();
        }

        public void xuat()
        {
            Console.WriteLine("\t\tMa Phieu: "+MaPhieu+"\t\tNgay Kiem: "+NgayKiem+"\t\tNhan vien kiem: "+NhanVien+"\t\tChuc vu: ");
        }
    }
}
