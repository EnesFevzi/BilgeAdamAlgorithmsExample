using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_OOPİnheritanceTasitlar
{
    //Derived Class(Türemiş Class)
    public class Araba:Tasitlar
    {
        public Araba()
        {
            KapiSayisi = 4;
            TekerSayisi = 4;
            ID = 1;
            Kapasite = 5;
        }
        public Araba(int id,int kapi)
        {
            KapiSayisi = kapi;
            ID = id;

        }

        public int KapiSayisi { get; set; }
    }
}
