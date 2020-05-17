using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Program
    {
        static List<HocVien> HV = new List<HocVien>();
        static List<Leader> LD = new List<Leader>();
        static int n,m;
        static void Nhap()
        {
            Console.WriteLine("Nhap so hoc vien: "); n = Convert.ToInt32(Console.ReadLine());
            for(int i =0;i<n;i++)
            {
                Console.WriteLine("             Nhap Hoc vien thu " + (i+1)+"             ");
                HocVien hocVien = new HocVien();
                hocVien.nhap();
                HV.Add(hocVien);
            }
            Console.WriteLine("Nhap so leader: "); m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("             Nhap leader thu " + (i+1) + "             ");
                Leader ld = new Leader();
                ld.nhap();
                LD.Add(ld);
            }    
        }
        static void Xuat()
        {
            Console.WriteLine("                  Danh sach hoc vien               ");
            for(int i =0; i< HV.Count;i++)
            {
                HV[i].xuat();
            }
            Console.WriteLine("                  Danh sach leader              ");
            for (int i = 0; i < LD.Count; i++)
            {
                LD[i].xuat();
            }
        }
        static void thanhToanCn(string name, int TienTT)
        {
            for(int i =0;i<n-1;i++)
            {
                if(name.CompareTo(HV[i].HoTen1)==0)
                {
                    HV[i].thanhToanCn(TienTT);
                    HV[i].xuat();
                }
                else
                {
                    Console.WriteLine("Khong co hoc vien nay!!!!");
                }    
            } 
        }
        static void RanDom()
        {
            Random rd = new Random();
            int i = rd.Next(0, n - 1);
            Console.Write("\nHoc vien ngau nhien khong co ny: \n");
            while (HV[i].TTYD1.CompareTo("Yes") == 0)
            {
                i = rd.Next(0, n - 1);
            }
            HV[i].xuat();
        }
        static void TangCn()
        {
            for(int i = 0;i<n-1;i++)
            {
                if(HV[i].TTYD1.CompareTo("Yes") == 0)
                {
                    HV[i].CongNo += 5000;
                }
                HV[i].xuat();
            }    
        }
        static void Main()
        {
            Nhap();
            Xuat();
            string name;
            int TienTT;
            Console.WriteLine("Nhap ten sinh vien can thanh toan: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhap so tien can thanh toan: ");
            TienTT = Convert.ToInt32(Console.ReadLine());
            thanhToanCn(name, TienTT);
            Console.ReadKey();
            RanDom();
            TangCn();
        }
    }
}
