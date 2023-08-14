using HamburgerciOtomasyonu.Concrete;
using HamburgerciOtomasyonu.Enums;
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
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }

        public static double toplamTutar;
        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            foreach (Menu menu in Menu.Menuler)
            {
                cbxMenuler.Items.Add(menu);
            }
            foreach (EkstraMalzeme ekstra in EkstraMalzeme.EkstraMalzemeler)
            {
                flpEkstraMalzemeler.Controls.Add(Helper.CreateCheckBox(ekstra));
            }
            cbxMenuler.SelectedIndex = 0;
            btnSiparisiTamamla.Enabled = false;
        }

        private void btnSiparisiEkle_Click(object sender, EventArgs e)
        {
            if (!FormElemanlariniKontrolEt())
            {
                return;
            }
            Siparis siparis = new Siparis();
            siparis.Menu = (Menu)cbxMenuler.SelectedItem;
            foreach (Control control in gbxBoyutSec.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    if (radioButton.Checked)
                    {
                        siparis.MenuBoyut = (MenuBoyut)Enum.Parse(typeof(MenuBoyut), radioButton.Text);
                    }

                }
            }
            siparis.MalzemeEkstralar = new List<EkstraMalzeme>();
            foreach (CheckBox control in flpEkstraMalzemeler.Controls)
            {
                if (control.Checked)
                {
                    siparis.MalzemeEkstralar.Add((EkstraMalzeme)control.Tag);
                }
            }

            EklemeIslemı(siparis);
            btnSiparisiTamamla.Enabled = true;
            Helper.Temizle(gbxMenuSecme.Controls);
        }
        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show($" Toplam Tutar {toplamTutar} ₺\n Siparişlerinizi Onaylamak İstiyor Musnuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Helper.MesajYaz("Siparişiniz Başarıyla Oluşturuldu...");
                Helper.Temizle(this.Controls);
                toplamTutar = 0;
                lblToplamTutar.Text = "0,00";
            }
            else
            {
                Helper.MesajYaz("Siparişten Vazgeçildi...");
            }

        }
        private bool FormElemanlariniKontrolEt()
        {
            int radioButonSayisi = 0;
            foreach (Control control in gbxMenuSecme.Controls)
            {
                if (control is NumericUpDown numericUpDown)
                {
                    if (numericUpDown.Value == 0)
                    {
                        Helper.HataMesajYaz("Adet Sayısı 0 olamaz...");
                        return false;
                    }

                }

            }
            foreach (RadioButton item in gbxBoyutSec.Controls)
            {
                if (!item.Checked)
                {
                    radioButonSayisi++;

                }
                if (radioButonSayisi == 3)
                {
                    Helper.HataMesajYaz("Boyut Seçimi Yapılmalıdır...");
                    return false;
                }
            }

            return true;
        }

        private void EklemeIslemı(Siparis siparis)
        {
            siparis.Adet = (int)nudSiparisAdeti.Value;
            siparis.ToplamTutar = siparis.ToplamTutarHesapla();
            toplamTutar += siparis.ToplamTutar;
            lblToplamTutar.Text = toplamTutar.ToString();
            AnaEkran.AnlıkSiparisler.Add(siparis);
            AnaEkran.ToplamSiparisler.Add(siparis);
            lbxSiparisiGoster.Items.Add(siparis);
        }


    }
}
