using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Aplikasi Calculator";
			
			// int a = 10; // deklarasi variabel a, dengan nilai awal 10;
			// int b = 6; // deklarasi variabel b, dengan nilai awal 6;
			
			Console.WriteLine("Pilih Menu Calculator :");
			Console.WriteLine();
			Console.WriteLine("1. Penambahan");
			Console.WriteLine("2. Pengurangan");
			Console.WriteLine("3. Perkalian");
			Console.WriteLine("4. Pembagian");
			
			Console.WriteLine();
			Console.Write("Input Nomor Menu [1 - 4] : ");
			int pilihan = int.Parse(Console.ReadLine());
			Console.WriteLine();
			
			Console.Write("Inputkan nilai a = ");
			int a = int.Parse(Console.ReadLine()); // proses casting
			
			Console.Write("Inputkan nilai b = ");
			int b = Convert.ToInt32(Console.ReadLine()); // proses casting
			
			Console.WriteLine(); // tambahkan baris kosong
			
			switch(pilihan)
			{
				case 1:
					Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
					break;
				case 2:
					Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
					break;
				case 3:
					Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
					break;
				case 4:
					Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
					break;
				default:
					Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
					break;
			}
			
			Console.WriteLine("\nTekan sembarang key untuk keluar");
			Console.ReadKey();
		}
		
		static int Penambahan(int a, int b)
		{
			return a + b;
		}
		
		static int Pengurangan(int a, int b)
		{
			return a - b;
		}
		
		static int Perkalian(int a, int b)
		{
			return a * b;
		}
		
		static int Pembagian(int a, int b)
		{
			return a / b;
		}
	}
}
