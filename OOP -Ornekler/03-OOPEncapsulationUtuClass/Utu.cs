using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOPEncapsulationUtuClass
{
    public class Utu
    {
        public string Marka { get; set; }
        public string Renk { get; set; }
        //Encapsulation : Class içerisindeki oluşturulmuş private bir fieldın dışarıdan erişimini kontrol altına almaktır.Property yardımıyla.

        private int _sicaklik;
        public int Sicaklik
        {
            get
            {
                return _sicaklik;
            }
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("Ütünün sıcaklığı 100 dereceden fazla olamaz!");
                    _sicaklik = 100;
                }
                else
                {
                    _sicaklik = value;
                }
               
            }
        }
        public void Isin(int derece)
        {
            Sicaklik += derece;
        }
    }
}
