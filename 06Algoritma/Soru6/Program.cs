using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru6
{/*Kullanıcıdan alınan n adet saynının ortalamasını alan algoritmayı yazınız.*/
	internal class Program
	{
		static void Main(string[] args)
		{
			int toplam = 0;
			int i = 1;
			Console.WriteLine("Başla");

			Console.WriteLine("Kaç adet sayı gireceksiniz: ");
			int n = Convert.ToInt32(Console.ReadLine());

			while (i <= n)
			{
				Console.WriteLine("Sayıyı girin: ");
				int sayi = Convert.ToInt32(Console.ReadLine());
				toplam += sayi;
				i++;
			}

			double ortalama = toplam / n;

			Console.WriteLine("Ortalama: " + ortalama);
			Console.ReadLine();
		}
	}
}
