using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_UygulamaOrnek
{
    public class Ogrenci
    {
        public Ogrenci(int ogrenciID, string name, string surName)
        {
            OgrenciID = ogrenciID;
            Name = name;
            SurName = surName;
        }
        public int OgrenciID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }



        private DateTime _dogumTarihi;
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set
            {
                _dogumTarihi = value;
                _yas = DateTime.Now.Year - DogumTarihi.Year;
            }
        }


        private int _yas;
        public int Yas
        {
            get { return _yas; }

        }
        private string _job;
        public string Job
        {
            get { return _job; }
            set
            {

                if (_yas < 18)
                {
                    _job= "Bu kişi 18 yaşından küçük çalışamaz";
                }
                else
                {
                    _job = value;
                }


            }
        }
        public void BilgileriYazdir()
        {

            Console.WriteLine("ID: " + OgrenciID);
            Console.WriteLine("Adı: " + Name);
            Console.WriteLine("Soyadı: " + SurName);
            Console.WriteLine("Mesleği: " + Job);
            Console.WriteLine("Yaş: " + Yas);


        }

        public void YemekYe(Yemek yemek)
        {
            Console.WriteLine($"{Name} {SurName} şu yemeği yiyor: {yemek.FoodName}");
        }

        public void OyunOyna(Game oyun)
        {
            Console.WriteLine($"{Name} {SurName} şu oyunu oynuyor: {oyun.GameName}");
        }
    }
}
