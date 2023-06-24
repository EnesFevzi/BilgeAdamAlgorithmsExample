using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Odev
{
	internal class Program
	{/*1 ile 100 arasındaki asal sayıları bulup ekrana yazdıran algoritma.
*/
		static void Main(string[] args)
		{
			

			for (int sayi = 2; sayi < 100; sayi++)
			{
				bool asalMi = true;

				for (int bolen = 2; bolen < sayi; bolen++)
				{
					if (sayi % bolen == 0)
					{
						asalMi = false;
						break;
					}
					
				}
				if (asalMi)
				{
					Console.WriteLine(sayi);
				}
			}
			Console.ReadLine();

		}
	}
}
