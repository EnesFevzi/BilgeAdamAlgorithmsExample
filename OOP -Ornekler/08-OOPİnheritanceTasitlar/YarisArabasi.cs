using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_OOPİnheritanceTasitlar
{
    public class YarisArabasi:Araba
    {
        public YarisArabasi()
        {
            ID = 2;
            TekerSayisi = 4;
            Kapasite = 2;
            KapiSayisi = 2;
        }

        public YarisArabasi(int id,int kapi) :base(id,kapi) //Base class olarak kullanılan araba classın iki argüman alan ctor bulunmadığı için hata verecek...
        {
            ID=id;
            KapiSayisi=kapi;
            TekerSayisi=4;
            Kapasite=61;
        }

        //public YarisArabasi(int kapi =4) // =4 dediğimiz kısım default value olarak tanımlanmaktadır.Eğer bu ctor çağrılıp kapi parametresi verilmez ise  burada default value devreye girer.Ancak,bu ctor için tek değer aldığından dolayı , boş olarak gönderilmelidir ve o zaman da boş ctor devreye girecektir.

        //{
        //    KapiSayisi = kapi;    
        //}

       

    }
}
