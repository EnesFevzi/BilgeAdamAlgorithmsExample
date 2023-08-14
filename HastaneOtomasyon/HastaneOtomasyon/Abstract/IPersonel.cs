using HastaneOtomasyon.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Abstract
{
    public interface IPersonel
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        string TcNo { get; set; }
        int Yas { get; set; }
        double Maas { get; set; }
        Cinsiyet Cinsiyet { get; set; }
        Binalar Bina { get; set; }

        string PersonelBilgi();

   

    }
}
