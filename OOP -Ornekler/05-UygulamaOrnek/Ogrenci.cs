using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_UygulamaOrnek
{
    public class Ogrenci
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sinif { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime BırtDate { get; set; }
        public int Age { get; set; }


        public int YasHesapla()
        {
            DateTime bugun = DateTime.Today;
            int yas = bugun.Year - BırtDate.Year;
            return yas;
        }
        public Ogrenci(string ad, string soyad,DateTime age)
        {
            Ad = ad;
            Soyad = soyad;
            BırtDate = age;

            Console.WriteLine($"Ad: {Ad} \nSoyad: {Soyad} ");
            Age=YasHesapla();
        }


        
        public void BilgileriYazdir()
        {
            //Console.WriteLine("Doğum Tarihi: " + BırtDate.ToShortDateString());
            Console.WriteLine("Yaş: " + Age);
            Console.WriteLine("Sınıf: " + Sinif);
            Console.WriteLine("Cinsiyet: " + Cinsiyet);
        }
    }
}
