namespace _08_OOPİnheritanceTasitlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Tasitlar tasitlar = new Tasitlar();
            tasitlar.Kapasite = 5;
            tasitlar.ID = 10;

            Console.WriteLine($"Taşıtın ID si: {tasitlar.ID} \nTaşıtın Kapasitesi:{tasitlar.Kapasite}\nTaşıtın Kapasitesi:{tasitlar.TekerSayisiGetir}");


             Araba araba = new Araba();
            Console.WriteLine($"Taşıtın ID si: {araba.ID} \nTaşıtın Kapasitesi:{araba.Kapasite}\nTaşıtın Maksimum Hızı:{araba.HizGetir(200)}");


            YarisArabasi yarisArabasi = new YarisArabasi();

            Console.WriteLine($"Taşıtın ID si: {yarisArabasi.ID} \nTaşıtın Kapasitesi:{yarisArabasi.Kapasite}\nTaşıtın Maksimum Hızı:{yarisArabasi.HizGetir(100)}");


            YarisArabasi yarisArabasi2 = new YarisArabasi(60,70);

            Console.WriteLine($"Taşıtın ID si: {yarisArabasi2.ID} \nTaşıtın Kapasitesi:{yarisArabasi2.Kapasite}\nTaşıtın Maksimum Hızı:{yarisArabasi2.HizGetir(100)}\nTaşıtın Kapı Sayısı:{yarisArabasi2.KapiSayisi}");
            Console.ReadLine();
        }
    }
}