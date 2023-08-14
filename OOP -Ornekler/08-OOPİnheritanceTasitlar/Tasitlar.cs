using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_OOPİnheritanceTasitlar
{
    public class Tasitlar
    {

        public int ID { get; set; }
        protected int TekerSayisi { get; set; } //protected olarak işaretlenen bir öğe ,kendi classı içerisinden ya da sadece kendisinden miras alınan classlardan erişebilir.
        public int Kapasite { get; set; }
        private int MaksimumHiz { get; set; } //private olarak işaretlenen bir propoerty sadece kendi classı içerisinde erişilebilir.Inherit eden classlardan erişilemez.
        public Tasitlar()
        {
            MaksimumHiz = 200;
        }
        public int HizGetir(int hiz)
        {
            return hiz;
        }
        public int TekerSayisiGetir()
        {
            TekerSayisi = 4;
            return TekerSayisi;
        }


    }
}
