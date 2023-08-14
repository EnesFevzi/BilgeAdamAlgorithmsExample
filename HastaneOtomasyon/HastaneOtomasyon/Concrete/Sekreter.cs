using HastaneOtomasyon.Abstract;
using HastaneOtomasyon.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Concrete
{
    public class Sekreter : IPersonel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public int Yas { get; set; }
        public double Maas { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public Binalar Bina { get; set; }

        public string PersonelBilgi()
        {
            return $"Ad Soyad: {Ad} {Soyad}, TC No: {TcNo}, Yas: {Yas}, Maaş: {Maas}, Cinsiyet: {Cinsiyet}";
        }
    }
}
