using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
	internal class Program
	{/*Kullanıcıdan alınan 3 sayı arasından en büyüğü bulduran algoritmayı yazdırınız.
*/
		static void Main(string[] args)
		{

			Console.Write("Lütfen  birinci tam sayıyı giriniz: ");
			int sayi1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Lütfen  ikinci tam sayıyı giriniz: ");
			int sayi2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Lütfen  üçüncü tam sayıyı giriniz: ");
			int sayi3 = Convert.ToInt32(Console.ReadLine());

			int enBuyuk = sayi1;


			if (sayi2 > enBuyuk)
			{
				enBuyuk = sayi2;
			}

			if (sayi3 > enBuyuk)
			{
				enBuyuk = sayi3;
			}

			Console.WriteLine("En Büyük Sayı:" + enBuyuk);


			Console.ReadLine();

		}
	}
}
