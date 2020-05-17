using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class HocVien : SinhVienHaUI
    {
        private int congNo;
        public int CongNo { get => congNo; set => congNo = value; }
        public HocVien()
        {
            this.CongNo = 10000;
        }
        public void nhap()
        {
            base.Nhap();
        }
        public void xuat()
        {
            base.Xuat();
            Console.WriteLine("Cong no: "+ this.congNo+"\n");
        }
        public void thanhToanCn( int TienTT)
        {
            this.congNo -= TienTT;
        }
    }
}
