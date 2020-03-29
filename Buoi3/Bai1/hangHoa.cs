using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class hangHoa
    {
        private string maHang;
        private string tenHang;
        private int donGia;
        private int soLuong;

        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public void Nhap()
        {
            Console.WriteLine("Nhap ma hang: ");
            this.maHang = Console.ReadLine();
            Console.WriteLine("Nhap ten hang: ");
            this.tenHang = Console.ReadLine();
            Console.WriteLine("Nhap don gia: ");
            this.donGia = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so luong: ");
            this.soLuong = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ma hang: "+ this.maHang + "\tTen hang: "+ this.tenHang + 
            "\tDon gia: " + this.donGia + "\tSo luong: " + this.soLuong + "Thanh tien: \t\t" + thanhTien());
        }
        
        public int thanhTien()
        {
            return this.donGia * this.soLuong;
        }

        public static void sapXep(List<hangHoa> hang, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (hang[j].thanhTien() < hang[i].thanhTien())
                    {
                        hangHoa temp = hang[j];
                        hang[j] = hang[i];
                        hang[i] = temp;
                    }    
                }    
            }    
        }
    }
}
