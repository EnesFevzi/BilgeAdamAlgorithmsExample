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
    public partial class MenüEkle : Form
    {
        public MenüEkle()
        {
            InitializeComponent();
        }

        private void btnMenuyuKaydet_Click(object sender, EventArgs e)
        {
            Menu.Menuler.Add(new Menu(txtMenuAdi.Text, (double)nudMenuFiyatı.Value));

            Helper.Temizle(gbxMenuBilgileri.Controls);

            Helper.MesajYaz("Başarıyla Eklendi");
        }
    }
}
