namespace _05_UygulamaOrnek
{
    public class Program
    {//Bir öğrenci nesnesi oluşturup ad,syoad,doğum tarihi,sınıf,cinsiyet bilgilerini tutunuz.Öğrenci nesnesini ad,soyad bilgileri ile yaratınız.Aynı zamanda öğrenci classında gelen doğum tarihi bilgisinne göre yıl bazında yaşını hesaplayınız.
        //Yine class içerisinde oluşturulacak bir method ile öğnrenci bilgilerini ekrana yazdırınız(Yaş bilgisi de dahil)
        //Klavyeden değil Program.cs den nesne oluşturulduğunda bilgileri girebilirsiniz.
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci("Enes","Fevzi", new DateTime(1998, 1, 1));
            ogrenci.Sinif = "Yazılım";
            ogrenci.Cinsiyet = "Erkek";
            //ogrenci.BırtDate = new DateTime(1998, 1, 1);

            ogrenci.BilgileriYazdir();
            Console.ReadLine();
        }
    }
}