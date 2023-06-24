using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru4
{
	internal class Program
	{//Kullanıcının girdiği iki sayıyı yer değiştererek kullanıcıya gösteren algoritmayı yazınız.
		static void Main(string[] args)
		{
			Console.Write("Lütfen  birinci tam sayıyı giriniz: ");
			int sayi1 = Convert.ToInt32(Console.ReadLine()); 
			Console.Write("Lütfen  ikinci tam sayıyı giriniz: ");
			int sayi2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Değiştilmeden Önceki birinci sayı :" + sayi1);
			Console.WriteLine("Değiştilmeden Önceki ikinci sayı :" + sayi2);
			int sayi3 = sayi1; 


			sayi1 = sayi2;
			sayi2 = sayi3;
			Console.Write("Değiştirildikten sonraki birinci sayı :" + sayi1);
			Console.Write("Değiştirildikten sonraki ikinci sayı :" + sayi2);

			Console.ReadLine();

		}
	}
}
