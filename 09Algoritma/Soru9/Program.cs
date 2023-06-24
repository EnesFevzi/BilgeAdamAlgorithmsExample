using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru9
{/*Öğrenci notunu hesaplayıp geçtiniz veya kaldınız yazan algoritma.
Vize: %30 , Final:%70 , Geçme Notu: 50 )
*/
	internal class Program
	{
		static void Main(string[] args)
		{
			int vizeNot, finalNot;
			double gecmeNotu;

			Console.Write("Lütfen Vize Notunuzu Giriniz: ");
			while (!int.TryParse(Console.ReadLine(), out vizeNot))
			{
				Console.WriteLine("Lütfen Vize Notunu Tekrar Giriniz: ");
			}

			Console.Write("Lütfen Final Notunuzu Giriniz: ");
			while (!int.TryParse(Console.ReadLine(), out finalNot))
			{
				Console.WriteLine("Lütfen Final Notunu Tekrar Giriniz: ");
			}

			gecmeNotu = HesaplaGecmeNotu(vizeNot, finalNot);
			Console.WriteLine("Notunuz: " + gecmeNotu);
			Console.WriteLine("Harf Notunuz: " + HarfNotu(gecmeNotu));

			Console.ReadLine();

		}
		static double HesaplaGecmeNotu(int vizeNot, int finalNot)
		{
			double vizeEtkisi = vizeNot * 0.3;
			double finalEtkisi = finalNot * 0.7;
			return vizeEtkisi + finalEtkisi;
		}

		static string HarfNotu(double gecmeNotu)
		{
			if (gecmeNotu < 100 && gecmeNotu >= 90)
			{
				return "A";
			}
			else if (gecmeNotu < 90 && gecmeNotu >= 80)
			{
				return "B";
			}
			else if (gecmeNotu < 80 && gecmeNotu >= 70)
			{
				return "C";
			}
			else if (gecmeNotu < 70 && gecmeNotu >= 45)
			{
				return "D";
			}
			else
			{
				return "F";
			}
		}

	}
}
