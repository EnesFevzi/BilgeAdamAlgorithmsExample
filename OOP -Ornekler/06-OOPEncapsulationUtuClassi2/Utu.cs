using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOPEncapsulationUtuClassi2
{
    public class Utu
    {
        public string Marka { get; set; }
        public int Sicaklik { get; set; }

        //Encapsulation propfull

        private string _renk;

        public string Renk
        {
            get { return _renk; }
            set 
            {
                if (value== "Mavi")
                    _renk = value;
                else
                    _renk = "Belirtilmedi";
               
            }
        }

    }
}
