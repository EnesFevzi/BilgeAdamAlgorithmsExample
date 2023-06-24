using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru8
{/*1 den 100 e kadar olan sayıları tek ve çift olarak ekrana yazdıran algoritma yazınız.*/
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 100; i++) 
			{
				if (i %2 == 0)
				{
					Console.WriteLine(i +" "+ "sayısı Çifttir");
				}
				else
				{
					Console.WriteLine(i +" "+ "sayısı Tektir");
				}
				
				
			}
			Console.ReadLine();
		}
	}
}
