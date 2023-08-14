using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Uygulama_Ornek
{
    public class Cikarma :İslemler
    {
        public Cikarma(int sayi1, int sayi2)
        {
            Sayi1 = sayi1;
            Sayi2 = sayi2;
        }
        public int Cikarmaİslemi()
        {

            return Sayi1 - Sayi2;
        }
    }
}
