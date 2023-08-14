using HamburgerciOtomasyonu.Concrete;
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
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            foreach (Siparis siparis in AnaEkran.ToplamSiparisler)
            {
                lbxTumSiparisler.Items.Add(siparis);
            }
            HesapalamalariYap();

        }


        public void HesapalamalariYap()
        {
            double toplamCiro = 0;
            int toplamSiparisAdeti = 0;
            double ekstraMalzemeGeliri = 0;
            int satilanUrunAdedi = 0;

            foreach (Siparis siparis in AnaEkran.ToplamSiparisler)
            {
                toplamCiro += siparis.ToplamTutar;

                foreach (EkstraMalzeme ekstra in siparis.MalzemeEkstralar)
                {
                    ekstraMalzemeGeliri += ekstra.EkstraMalzemeFiyati;
                }
                satilanUrunAdedi += siparis.Adet;
            }
            lblCiro.Text = toplamCiro.ToString();
            toplamSiparisAdeti = lbxTumSiparisler.Items.Count;
            lblToplamSiparisSayisi.Text = toplamSiparisAdeti.ToString();
            lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString();
            lblSatilanUrunAdedi.Text = satilanUrunAdedi.ToString();

        }
    }
}
