using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciOtomasyonu.Concrete
{
    public class EkstraMalzeme
    {
        public EkstraMalzeme(string ekstraMalzemeAdi, double ekstraMalzemeFiyati)
        {
            EkstraMalzemeAdi = ekstraMalzemeAdi;
            EkstraMalzemeFiyati = ekstraMalzemeFiyati;
        }
        public string EkstraMalzemeAdi { get; set; }
        public double EkstraMalzemeFiyati { get; set; }

        public static List<EkstraMalzeme> EkstraMalzemeler = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme("Ketçap",4),
            new EkstraMalzeme("Mayonez",4),
            new EkstraMalzeme("Hardal",5),
            new EkstraMalzeme("BBQ",5),
            new EkstraMalzeme("Ranch Sos",6),
            new EkstraMalzeme("Sarımsaklı Mayonez",6),
            new EkstraMalzeme("Buffalo",7),

        };
    }
}
