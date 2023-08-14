using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciOtomasyonu.Concrete
{
    public class Menu
    {
        public Menu(string menuAdi, double menuFiyati)
        {
            MenuAdi = menuAdi;
            MenuFiyati = menuFiyati;
        }
        public string MenuAdi { get; set; }
        public double MenuFiyati { get; set; }

        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu("Whopper",99),
            new Menu("Steakhouse",109),
            new Menu("Big King",119),
            new Menu("Chicken Royale",129),
            new Menu("King Chicken",139),
            new Menu("Texas Smokehouse",149),
            new Menu("Long Chicken",134),
            new Menu("Crispy Chicken",159),

        };
        public override string ToString()
        {
            return $"{MenuAdi} Menü";
        }
    }
}
