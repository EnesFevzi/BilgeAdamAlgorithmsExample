using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru10_1
{
	internal class Program
	{ /*Bir ürün için yapılan ankette beğenen , beğenmeyen ve kararsız kalanların sayısını ve toplam müşteri sayısını ekrana yazdıran algoritma (Kaç kişinin katılacağını ilk başta sormadan)*/
		static void Main(string[] args)
		{
			int begenenSayisi = 0;
			int begenmeyenSayisi = 0;
			int kararsizSayisi = 0;
			string cevap = "";

			while (cevap.ToLower() != "hayır")
			{
				Console.Write("Ankete Katılacak mısınız? (evet/hayır): ");
				cevap = Console.ReadLine();

				if (cevap.ToLower() != "evet" && cevap.ToLower() != "hayır")
				{
					Console.WriteLine("Geçerli bir değer giriniz (evet/hayır).");
				}
				else if (cevap.ToLower() == "evet")
				{
					int degerlendirme;
					Console.WriteLine("Değerlendirmeniz nedir?");
					Console.WriteLine("1 - Beğendi, 2 - Beğenmedi, 3 - Kararsız");

					while (!int.TryParse(Console.ReadLine(), out degerlendirme) || degerlendirme < 1 || degerlendirme > 3)
					{
						Console.WriteLine("Lütfen geçerli bir değer giriniz (1, 2 veya 3)");
					}

					Degerlendirme(degerlendirme, ref begenenSayisi, ref begenmeyenSayisi, ref kararsizSayisi);
				}
			}

			Console.WriteLine("Sonuçlar:");
			Console.WriteLine("Toplam Müşteri Sayısı: " + ToplamMusteriSayisi(begenenSayisi, begenmeyenSayisi, kararsizSayisi));
			Console.WriteLine("Beğenen sayısı: " + begenenSayisi);
			Console.WriteLine("Beğenmeyen sayısı: " + begenmeyenSayisi);
			Console.WriteLine("Kararsız sayısı: " + kararsizSayisi);

			Console.ReadLine();
		}

		static void Degerlendirme(int degerlendirme, ref int begenenSayisi, ref int begenmeyenSayisi, ref int kararsizSayisi)
		{
			if (degerlendirme == 1)
			{
				begenenSayisi++;
			}
			else if (degerlendirme == 2)
			{
				begenmeyenSayisi++;
			}
			else if (degerlendirme == 3)
			{
				kararsizSayisi++;
			}
		}

		static int ToplamMusteriSayisi(int begenenSayisi, int begenmeyenSayisi, int kararsizSayisi)
		{
			return begenenSayisi + begenmeyenSayisi + kararsizSayisi;
		}
	}
}
