using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class Ttb2
    {
        private double a;
        private double b;
        private double c;

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public Ttb2()
        {

        }

        public Ttb2(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
    
        public void Xuat()
        {
            Console.WriteLine("Phuong trinh co dang: ");
            Console.WriteLine(A+"x^2+"+B+"x+"+C);
        }

        public static Ttb2 operator--(Ttb2 x)
        {
            Ttb2 ttdoidau = new Ttb2();
            ttdoidau.A = -1 * x.A;
            ttdoidau.B = -1 * x.B;
            ttdoidau.C = -1 * x.C;
            return ttdoidau;
        }

        public static Ttb2 operator+(Ttb2 tt1, Ttb2 tt2)
        {
            Ttb2 Tong = new Ttb2();
            Tong.A = tt1.A + tt2.A;
            Tong.B = tt1.B + tt2.B;
            Tong.C = tt1.C + tt2.C;
            return Tong;
        }

        public static Ttb2 operator -(Ttb2 tt1, Ttb2 tt2)
        {
            Ttb2 Hieu = new Ttb2();
            Hieu.A = tt1.A - tt2.A;
            Hieu.B = tt1.B - tt2.B;
            Hieu.C = tt1.C - tt2.C;
            return Hieu;
        }
    }
}
