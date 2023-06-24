using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma12
{/*Bir kampüsteki öğrencilerin kilo ortalamalarını , cinsiyetlerine göre bulduran algoritma
*/
	internal class Program
	{
		static void Main(string[] args)
		{
			string cevap = "";
			int erkekKisiSayisi = 0;
			int kadinKisiSayisi = 0;
			int toplamKadinKilo = 0;
			int toplamErkekKilo = 0;
			int erkekOrtalamaKilo = 0;
			int kadinOrtalamaKilo = 0;

			while (cevap.ToLower() != "hayır")
			{
				Console.Write("Ankete Katılacak mısınız? (evet/hayır): ");
				cevap = Console.ReadLine();

				if (cevap.ToLower() != "evet" && cevap.ToLower() != "hayır")
				{
					Console.WriteLine("Geçerli bir değer giriniz (evet/hayır).");
					continue;
				}

				if (cevap.ToLower() == "hayır")
				{
					break;
				}

				Console.Write("Cinsiyetinizi giriniz (Erkek:E, Kadın:K): ");
				string cinsiyet = Console.ReadLine();

				if (cinsiyet.ToUpper() == "E")
				{
					erkekKisiSayisi++;
					Console.Write("Kilonuzu giriniz: ");
					int kilo = int.Parse(Console.ReadLine());
					toplamErkekKilo += kilo;
				}
				else if (cinsiyet.ToUpper() == "K")
				{
					kadinKisiSayisi++;
					Console.Write("Kilonuzu giriniz: ");
					int kilo = int.Parse(Console.ReadLine());
					toplamKadinKilo += kilo;
				}
				else
				{
					Console.WriteLine("Geçerli bir cinsiyet değeri giriniz.");
				}
			}

			double erkekOrtalama = ErkekOrtalamaKilo(erkekKisiSayisi, ref toplamErkekKilo);
			double kadinOrtalama = KadınOrtalamaKilo(kadinKisiSayisi, ref toplamKadinKilo);

			Console.WriteLine("Erkek Öğrencilerin Kilo Ortalaması: " + erkekOrtalama.ToString("F2"));
			Console.WriteLine("Kadın Öğrencilerin Kilo Ortalaması: " + kadinOrtalama.ToString("F2"));
			Console.ReadLine();
		}

		static double ErkekOrtalamaKilo(int erkekKisiSayisi, ref int toplamErkekKilo)
		{
			if (erkekKisiSayisi == 0)
			{
				return 0;
			}
			else
			{
				return (double)toplamErkekKilo / erkekKisiSayisi;
			}
		}

		static double KadınOrtalamaKilo(int kadinKisiSayisi, ref int toplamKadinKilo)
		{
			if (kadinKisiSayisi == 0)
			{
				return 0;
			}
			else
			{
				return (double)toplamKadinKilo / kadinKisiSayisi;
			}
		}

	}
}

