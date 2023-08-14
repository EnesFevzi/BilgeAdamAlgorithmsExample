using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPGirisClassTanimlamasi
{
    public class Utu
    {
        public string Marka { get; set; }
        public string Renk { get; set; }
        public int Sicaklik { get; set; }
        public bool KazanliMi { get; set; }

        //Boş Constructor oluşuyor eğer sadece boş yapı oluşturulursa instance alırken boş yapı çağrılabilir.Ancak parametreli yapı oluşturulurken hangisini çağıracağımızı bilmeli ve one göre parametre vermeli veya vermemeliyiz.Eğer hiç yapı tanımlanmazsa default olarak boş constructor varmış gibi davranır.
        public Utu()
        {
            Console.WriteLine("Ütü nesnesi yaratıldı");
        }
        public Utu(string marka, string renk, int sicaklik, bool kazanliMi)
        {
            Marka = marka;
            Renk = renk;
            Sicaklik = sicaklik;
            KazanliMi = kazanliMi;
            Console.WriteLine($"ÜTÜ NESNESİ AŞAĞIDAKİ BİLGİLERLE YARATILDI!\nMarkası:{Marka}\nRengi:{Renk}\nSıcaklık:{Sicaklik}\nKazanli mi? {(KazanliMi ? "Evet" : "Hayır")}");
        }

        public Utu(string marka)
        {
            Marka = marka;

            Console.WriteLine($"ÜTÜ NESNESİ AŞAĞIDAKİ BİLGİLERLE YARATILDI!\nMarkası:{Marka}");
        }

        //Bir class içinde davranışları metotlarla belirleyebiliriz.Bu metotlar dışarıdan erişime açık yada kapalı olabilir.Dışarıdan erişime açık ise instance alındıktan sonra ilgili nesne adına nokta konularak erişebilir.Dışarıdan erişime kapalıysa(private) nokta operatörü ile erişelemez.
        public void Isin(int derece)
        {
            Sicaklik += derece;
            Console.WriteLine($"ÜTÜ SICAKLIĞI ARTTI ŞU ANKİ SICAKLIK!:{Sicaklik}");
        }
    }
}
