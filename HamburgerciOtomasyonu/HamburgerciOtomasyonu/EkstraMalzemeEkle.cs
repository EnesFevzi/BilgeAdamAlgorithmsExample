using HamburgerciOtomasyonu.Concrete;
using HamburgerciOtomasyonu.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerciOtomasyonu
{
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzemeyiKaydet_Click(object sender, EventArgs e)
        {
            EkstraMalzeme.EkstraMalzemeler.Add(new EkstraMalzeme(txtEkstraMalzemeAdi.Text, (double)nudEkstraMalzemeFiyatı.Value));

            Helper.Temizle(gbxEkstraMalzemeBilgileri.Controls);

            Helper.MesajYaz("Başarıyla Eklendi");
        }
    }
}
