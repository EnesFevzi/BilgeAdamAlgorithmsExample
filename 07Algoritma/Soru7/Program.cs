using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru7
{
	internal class Program
	{/*Kullanıcıdan bir kenar uzunluğu alınan karenin çevresini ve alanını hesaplayan algoritmayı yazınız.*/
		static void Main(string[] args)
		{
			int kenar;
			Console.WriteLine("Karenin Kenar Uzunluğunu Giriniz:");
			while (!int.TryParse(Console.ReadLine(), out kenar) || kenar <= 0)
			{
				Console.WriteLine("Geçerli Kenar Uzunluğunu Giriniz:");
			}
			double cevre = 4 * kenar;
			double alan = kenar * kenar;

			Console.WriteLine("Karenin Çevresi: " + cevre);
			Console.WriteLine("Karenin Alanı: " + alan);

			Console.ReadLine();
		}
	}
}
