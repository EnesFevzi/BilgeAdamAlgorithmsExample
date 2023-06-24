using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru11
{
	internal class Program
	{/*20 kişilik bir takımın yaşları girilecektir. Yaşı 18 ve 25 arasında olan kişilerin sayısını bulup ekranda gösteren programın algoritmasını yazınız.*/
		static void Main(string[] args)
		{

			int toplamKisiSayisi = 20;
			int erginKisiSayisi = 0;
			int ortalamaYas = 0;
			int toplamYas=0;
			int erginYas = 0;
			int yas = 0;

			for (int i = 0; i < toplamKisiSayisi; i++)
			{
				Console.Write(i+1 + " Numaralı Kişisinin Yaşını Giriniz: ");

				while (!int.TryParse(Console.ReadLine(),out yas))
				{
					Console.Write(i + " Numaralı Kişisinin Lütfen Yaşınızı Tekrar Giriniz: ");
				}
				ErginKisiSayisi(yas, ref erginKisiSayisi, ref  erginYas, ref  toplamYas, ref  ortalamaYas);
				ErginKisiSayisiYasOrtalaması(erginKisiSayisi, ref  erginYas, ref  ortalamaYas);
				
			}
			Console.WriteLine(" Toplamda 18-25 yaş arası olan kişi sayısı: " + erginKisiSayisi);
			Console.WriteLine(" Toplamda 18-25 yaş arası olan kişilerin yaş ortalaması: " + ortalamaYas);
			Console.ReadLine();
		}


		static void ErginKisiSayisi(int yas, ref int erginKisiSayisi, ref int erginYas, ref int toplamYas, ref int ortalamaYas)
		{
			if (yas >= 18 && yas <= 25)
			{
				erginKisiSayisi++;
				erginYas += yas;

			}

		}
		static void ErginKisiSayisiYasOrtalaması(int erginKisiSayisi, ref int erginYas, ref int ortalamaYas)
		{

			if (erginKisiSayisi > 0)
			{
				ortalamaYas = erginYas / erginKisiSayisi;
			}


		}
	}
}
