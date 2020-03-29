using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class Bai1
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so luong hang hoa: ");
            n = int.Parse(Console.ReadLine());
            List <hangHoa> hangs = new List<hangHoa>(n);
            for(int i =0; i<n;i++)
            {
                hangHoa hang = new hangHoa();
                hang.Nhap();
                hangs.Add(hang);
            }
            hangHoa.sapXep(hangs, n);
            foreach(hangHoa x in hangs)
            {
                x.Xuat();
            }    
            Console.ReadKey();
        }
    }
}
