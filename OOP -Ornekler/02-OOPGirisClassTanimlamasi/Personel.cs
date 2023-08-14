using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOPGirisClassTanimlamasi
{
    public class Personel
    {
        //public Personel()
        //{
        //}
        public int PersonelID { get; set; }
        public string PersonelName { get; set; }
        public string PersonelSurnname { get; set; }
        public string Unvan { get; set; }
        /* public decimal Maas { get; }*/ //==> set; metodu kaldırılırsa salt okunur(sadece okunur) bir property elde ederiz.

        //Kapsülleme(Encapsulation) yapabimek için field-property yapısı birlikte kullanmalıyız.

        private decimal _personelMaasi; //Field == Dışarıdan erişime kapalı olan alanlarımız. _öneki ile tanımlanır ve camelCasing kuralı uygulanır.

        public decimal PersonelMaasi //Property == Dışarıdan erişime açık olan özelliklerimiz.Fielde erişmek veya fideldaki değeri set etmek için
        {
            get { return _personelMaasi; }
            set
            {
                if (Unvan != "Mudur" || value < 11402.32M)
                {
                    Console.WriteLine("Yetkiniz yok ya da maaş değeri asgari ücretten düşük");
                }
                else
                    _personelMaasi = value;
            }
        }

    }
}
