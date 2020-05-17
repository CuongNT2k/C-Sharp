using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Leader : SinhVienHaUI
    {
        private string ChucVu;
        public Leader()
        {
            
        }

        public string ChucVu1 { get => ChucVu; set => ChucVu = value; }

        public void nhap()
        {
            base.Nhap();
            Console.Write("Nhap chuc vu: ");
            this.ChucVu1 = Console.ReadLine();
        }
        public void xuat()
        {
            base.Xuat();
            Console.WriteLine("Chuc vu: " + this.ChucVu1 + "\n");
        }
    }
}
