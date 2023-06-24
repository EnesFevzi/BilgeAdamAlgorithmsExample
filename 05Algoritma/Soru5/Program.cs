using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru5
{/*Kullanıcıdan alınan tam sayının çift veya tek olduğunu ekrana yazdıran algoritmayı yazınız.*/
	internal class Program
	{
		static void Main(string[] args)
		{
			int sayi;
			Console.Write("Lütfen Tam Sayı Giriniz: ");

			while (!int.TryParse(Console.ReadLine(), out sayi))
			{
				Console.Write("Geçerli Tam Sayı giriniz: ");
			}
			if (sayi % 2 == 0)
			{
				Console.WriteLine("Sayı Çifttir");
			}
			else
			{
				Console.WriteLine("Sayı Tektir");
			}
			Console.ReadLine();

		}
	}
}
