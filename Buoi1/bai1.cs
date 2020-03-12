using System;

namespace BaiTap
{
	class Program
	{
		static void Main(string[] args)
		{
			int a, b, c, d, e;
			Console.WriteLine("Nhap so: ");
			a = Convert.ToInt32(Console.ReadLine());
			b = Convert.ToInt32(Console.ReadLine());
			c = Convert.ToInt32(Console.ReadLine());
			d = Convert.ToInt32(Console.ReadLine());
			e = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("a = {0}, b = {1}, c = {2}, d= {3}, e = {4}", a, b, c, d, e);
			int val1 = a, val2 = a;
			if (val1 < b) val1 = b;
			if (val1 < c) val1 = c;
			if (val1 < d) val1 = d;
			if (val1 < e) val1 = e;
			if (val2 < b && b < val1) val2 = b;
			if (val2 < c && c < val1) val2 = c;
			if (val2 < d && d < val1) val2 = d;
			if (val2 < e && e < val2) val2 = e;
			Console.WriteLine("So lon nhat la: " + val1);
			Console.WriteLine("So lon thu 2 la: " + val2);
			Console.ReadKey();
		}
	}
}