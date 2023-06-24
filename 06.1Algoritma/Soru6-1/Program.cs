using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru6_1
{
	internal class Program
	{/*Kullanıcıdan  almadan n adet saynının ortalamasını alan algoritmayı yazınız.*/
		static void Main(string[] args)
		{
			int toplam = 0;
			int n = 0;

			string cevap = "";

			while (cevap.ToLower() != "hayır")
			{
				Console.Write("Bir sayı girin: ");
				int sayi = Convert.ToInt32(Console.ReadLine());

				toplam += sayi;
				n++;

				Console.Write("Devam etmek istiyor musunuz? (evet/hayır): ");
				cevap = Console.ReadLine();
			}

			double ortalama = (double)toplam / n;

			Console.WriteLine("Girilen sayıların ortalaması: " + ortalama);

			Console.ReadLine();



		}
	}
}
