using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class bai4
    {
		struct Date
		{
			public int Day;
			public int Month;
			public int Year;
		}

		struct Student
		{
			public int ID;
			public string Name;
			public Date DateOfBirth;
		}

		static void nhap(Student[] a, int n)
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("Nhap thong tin sinh vien thu "+ i+ ": ");
				Console.WriteLine("Nhap ID: ");
				a[i].ID = int.Parse(Console.ReadLine());
				Console.WriteLine("Nhap ten: ");
				a[i].Name = Console.ReadLine();
				Console.WriteLine("Nhap ngay sinh: ");
				a[i].DateOfBirth.Day = int.Parse(Console.ReadLine());
				Console.Write("Thang sinh: ");
				a[i].DateOfBirth.Month = int.Parse(Console.ReadLine());
				Console.Write("Nam sinh: ");
				a[i].DateOfBirth.Year = int.Parse(Console.ReadLine());
			}				
		}

		static void sx(Student[] a, int n)
		{
			for (int i = 0; i < n; i++)
				for (int j = i + 1; j < a.Length; j++)
					if (a[i].DateOfBirth.Year > a[j].DateOfBirth.Year)
					{
						Student temp = a[i];
						a[i] = a[j];
						a[j] = temp;
					}
		}

		static void xuat(Student[] a, int n)
		{
			for (int i = 0; i <n; i++)
			{
				Console.WriteLine("Sinh vien thu " + i + ": ");
				Console.WriteLine(a[i].ID + "\t" + a[i].Name + "\t" + a[i].DateOfBirth.Day + "/" + a[i].DateOfBirth.Month + "/" + a[i].DateOfBirth.Year);
			}
		}
		static void Main(string[] args)
		{
			Student[] a;
			
			Console.WriteLine("Nhap n: ");
			int n = int.Parse(Console.ReadLine());
			a = new Student[n];
			nhap(a, n);
			sx(a, n);
			xuat(a, n);

			Console.ReadKey();
		}
	}
}
