using HamburgerciOtomasyonu.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciOtomasyonu.Concrete
{
    public class Siparis
    {
        public int Adet { get; set; }
        public double ToplamTutar { get; set; }
        public Menu Menu { get; set; }
        public MenuBoyut MenuBoyut { get; set; }
        public List<EkstraMalzeme> MalzemeEkstralar { get; set; }

        public double ToplamTutarHesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += Menu.MenuFiyati;

            if (MenuBoyut == MenuBoyut.Orta)
            {
                ToplamTutar += 10;
            }
            if (MenuBoyut == MenuBoyut.Buyuk)
            {
                ToplamTutar += 20;
            }
            foreach (EkstraMalzeme ekstra in MalzemeEkstralar)
            {

                ToplamTutar += ekstra.EkstraMalzemeFiyati;
            }

            return ToplamTutar * Adet;

        }
        public override string ToString()
        {
            if (MalzemeEkstralar.Count<1)
            {
                return $"{Menu.MenuAdi} x {Adet} Adet , {MenuBoyut} Boy, {ToplamTutar} ₺";
            }
            else
            {
                string malzemeAdlari = "";
                foreach (EkstraMalzeme ekstra in MalzemeEkstralar)
                {
                    malzemeAdlari += ekstra.EkstraMalzemeAdi + ",";
                }
                malzemeAdlari = malzemeAdlari.Trim(',');
                return $"{Menu.MenuAdi} x {Adet} Adet , {MenuBoyut} Boy, ({malzemeAdlari}), {ToplamTutar} ₺";
                
            }


            
        }

    }
}
