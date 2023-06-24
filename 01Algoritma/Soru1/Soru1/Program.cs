using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
	internal class Program
	{ /*Kullanıcıdan alınan iki tam sayının hangisinin büyük olduğunu gösteren algoritmayı yazınız.
*/
		static void Main(string[] args)
		{

			Console.Write("Lütfen  birinci tam sayıyı giriniz: ");
			int sayi1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Lütfen  ikinci tam sayıyı giriniz: ");
			int sayi2 = Convert.ToInt32(Console.ReadLine());

			if (sayi1 > sayi2)
			{
				Console.WriteLine("Birinci Sayı Büyüktür");
			}

			else if (sayi1 < sayi2)
			{
				Console.WriteLine("İkinci Sayı Büyüktür");
			}
			else
			{
				Console.WriteLine("İki sayı birbirine eşittir");
			}

			Console.ReadLine();

		}
	}
}
