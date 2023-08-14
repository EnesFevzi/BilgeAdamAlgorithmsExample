namespace _09_UygulamaOrnek
{
    internal class Program
    {//Bir insan kclasası oluşturun bu clastan bir nesne ürettiğimizde çeşitli kabiliyetleri olmalı.İsimsiz insan olmaz tahmin edeceğiniz üzere. Bu insanın ID si adı soyad doğum tarihi yaşı ve işi olsun .Ayrıca yemek ve game sınıfları oluşturun bu insan ona verdiğimiz yemeği yesin ve ona verdiğimiz oyunu oynasın (Ekrana şu oyunu oynuyor şu yemeği yiyor yazsın)
        static void Main(string[] args)
        {
           Ogrenci ogrenci = new Ogrenci(1,"Enes","Fevzi");
            ogrenci.Job = "Yazılımcı";
            ogrenci.DogumTarihi = new DateTime(2008, 8, 2);
            ogrenci.BilgileriYazdir();



            Yemek yemek = new Yemek("Pizza");
            ogrenci.YemekYe(yemek);
            Game oyun = new Game("Call of Duty");
            ogrenci.OyunOyna(oyun);
         
            Console.ReadLine();
        }
    }
}