using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Odev
{
	internal class Program
	{/*1000 e kadar olan tribonacci sayı dizisini yazdırınız.*/
		static void Main(string[] args)
		{
			Console.WriteLine("Tribonacci Sayı Dizisi:");

			int n = 1000; // İstenilen sayı adedi

			int[] tribonacci = new int[n];
			tribonacci[0] = 0;
			tribonacci[1] = 0;
			tribonacci[2] = 1;

			Console.Write($"{tribonacci[0]} {tribonacci[1]} {tribonacci[2]} ");

			for (int i = 3; i < n; i++)
			{
				tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];

				if (tribonacci[i] > 1000)
					break;

				Console.Write($"{tribonacci[i]} ");
			}

			Console.ReadLine();
		}
	}
}
