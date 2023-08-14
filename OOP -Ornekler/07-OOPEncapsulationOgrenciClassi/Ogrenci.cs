using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_OOPEncapsulationOgrenciClassi
{
    public class Ogrenci
    {
        public Ogrenci(string name, string surName)
        {
            Name = name;
            SurName = surName;
        }

        public string Name { get; set; }
        public string SurName { get; set; }
        public string Sinif { get; set; }

        private DateTime _dogumTarihi;
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set
            {
                _dogumTarihi = value;
                _yas = DateTime.Now.Year - DogumTarihi.Year; 
                //Sadece bu satır kullanılıp bir üstteki satır kaldırılırsa dışarıdan gelen değer value içerisinde taşındığı için içeriddeki fielda aktarılamış olur dolayıısly adoğum tarihi DogumTarihi proepertysinin get metodyla _dogumTarihin field'ı içeriisnde değer get edilirken defaukt value (01.01.0001)       getirilir.Ancak bir üsteki satırdaki işlem yapılırsa ilgili _dogumTarihi fieldına dışarıdan gelen değer atanacağı için işlem dopru şekilde gerçekleştirilir.
            }
        }
        private int _yas;

        public int Yas
        {
            get { return _yas; }

        }

        public void EkranaYazdir()
        {
            Console.WriteLine("AD:" + Name);
            Console.WriteLine("SOYAD:" + SurName);
            Console.WriteLine("YAŞ:" + Yas);
        }

    }



}
