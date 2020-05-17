using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class SinhVienHaUI
    {
        private string HoTen;
        private string GioiTinh;
        private string QueQuan;
        private string TTYD;

        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string QueQuan1 { get => QueQuan; set => QueQuan = value; }
        public string TTYD1 { get => TTYD; set => TTYD = value; }

        public SinhVienHaUI()
        {

        }

        public void Nhap()
        {
            Console.WriteLine("Nhap Ho Ten Sinh Vien: "); this.HoTen = Console.ReadLine();
            Console.WriteLine("Nhap Gioi Tinh Vien: "); this.GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhap Que Quan Sinh Vien: "); this.QueQuan = Console.ReadLine();
            Console.WriteLine("Nhap TTYD cua Sinh Vien(Yes/No): "); this.TTYD = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.Write("Ho ten: " + this.HoTen + ", Gioi tinh: " + this.GioiTinh + ", Que quan: " + this.QueQuan + ", Tinh trang hon nhan: " + this.TTYD + ", ");
        }
    }

}
