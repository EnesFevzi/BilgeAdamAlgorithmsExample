using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
	internal class Program
	{/*Kullanıcıdan girilen fiyatı KDV(%18) ekleyerek KDV li fiyatını ekrana yazdıran algoritma..
*/
		static void Main(string[] args)
		{
			Console.WriteLine("Fiyat Giriniz: ");
			int fiyat;
			while (!int.TryParse(Console.ReadLine(), out fiyat))
			{
				Console.WriteLine("Geçerli bir fiyat giriniz: ");
			}

			double kdvliFiyat = fiyat * 1.18;
			Console.WriteLine("KDVli fiyat: " + kdvliFiyat);


			Console.ReadLine();
		}
	}
}
