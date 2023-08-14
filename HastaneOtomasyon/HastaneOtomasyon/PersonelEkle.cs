using HastaneOtomasyon.Abstract;
using HastaneOtomasyon.Concrete;
using HastaneOtomasyon.Enums;
using HastaneOtomasyon.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace HastaneOtomasyon
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }
        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));
            cmbAlan.DataSource = Enum.GetValues(typeof(Alan));
            cmbBina.DataSource = Enum.GetValues(typeof(Binalar));
            cmbAlan.Enabled = false;

        }
        private void btnPersonel_Click(object sender, EventArgs e)
        {

            if (rdbDoktor.Checked)
            {
                bool basariliMi = KontrolEt();
                if (basariliMi)
                {
                    Doktor doktor = new Doktor();
                    doktor.Ad = txtAd.Text;
                    doktor.Soyad = txtSoyad.Text;
                    doktor.Maas = Convert.ToDouble(txtMaas.Text);
                    doktor.TcNo = txtTcNo.Text;
                    doktor.Yas = Convert.ToInt32(txtYas.Text);
                    doktor.Cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.Text);
                    doktor.Bina = (Binalar)Enum.Parse(typeof(Binalar), cmbBina.Text);
                    //AnaEkran.Personeller.Add(doktor);
                    AnaEkran2.Personeller.Add(doktor);
                    AnaEkran2.Personeller2.Add(doktor.TcNo,doktor);
                    MesajYaz("Kayıt Başarılı");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
                else
                {

                    MesajYaz("Kayıt Başarısız");
                    return;

                }

            }
            if (rdbHemsire.Checked)
            {
                bool basariliMi = KontrolEt();
                if (basariliMi)
                {
                    Hemsire hemsire = new Hemsire()
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Maas = Convert.ToDouble(txtMaas.Text),
                        TcNo = txtTcNo.Text,
                        Yas = Convert.ToInt32(txtYas.Text),
                        Cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.Text),
                        Bina = (Binalar)Enum.Parse(typeof(Binalar), cmbBina.Text),
                        Alan = (Alan)Enum.Parse(typeof(Alan), cmbAlan.Text),
                    };
                    //AnaEkran.Personeller.Add(hemsire);
                    //AnaEkran2.Personeller.Add(hemsire);
                    AnaEkran2.Personeller2.Add(hemsire.TcNo, hemsire);
                    MesajYaz("Kayıt Başarılı");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
                else
                {

                    MesajYaz("Kayıt Başarısız");
                    return;

                }
            }
            if (rdbEbe.Checked)
            {
                bool basariliMi = KontrolEt();
                if (basariliMi)
                {
                    Ebe ebe = new Ebe()
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Maas = Convert.ToDouble(txtMaas.Text),
                        TcNo = txtTcNo.Text,
                        Yas = Convert.ToInt32(txtYas.Text),
                        Cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.Text),
                        Bina = (Binalar)Enum.Parse(typeof(Binalar), cmbBina.Text),

                    };
                    //AnaEkran.Personeller.Add(ebe);
                    //AnaEkran2.Personeller.Add(ebe);
                    AnaEkran2.Personeller2.Add(ebe.TcNo, ebe);
                    MesajYaz("Kayıt Başarılı");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
                else
                {

                    MesajYaz("Kayıt Başarısız");
                    return;

                }
            }
            if (rdbSekreter.Checked)
            {

                bool basariliMi = KontrolEt();
                if (basariliMi)
                {
                    Sekreter sekreter = new Sekreter();

                    sekreter.Ad = txtAd.Text;
                    sekreter.Soyad = txtSoyad.Text;
                    sekreter.Maas = Convert.ToDouble(txtMaas.Text);
                    sekreter.TcNo = txtTcNo.Text;
                    sekreter.Yas = Convert.ToInt32(txtYas.Text);
                    sekreter.Cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.Text);
                    sekreter.Bina = (Binalar)Enum.Parse(typeof(Binalar), cmbBina.Text);

                    //AnaEkran.Personeller.Add(sekreter);
                    AnaEkran2.Personeller.Add(sekreter);
                    AnaEkran2.Personeller2.Add(sekreter.TcNo, sekreter);
                    MesajYaz("Kayıt Başarılı");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
                else
                {

                    MesajYaz("Kayıt Başarısız");
                    return;

                }
            }
            if (rdbTemizlikci.Checked)
            {
                bool basariliMi = KontrolEt();
                if (basariliMi)
                {
                    Temizlikci temizlikci = new Temizlikci()
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Maas = Convert.ToDouble(txtMaas.Text),
                        TcNo = txtTcNo.Text,
                        Yas = Convert.ToInt32(txtYas.Text),
                        Cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.Text),
                        Bina = (Binalar)Enum.Parse(typeof(Binalar), cmbBina.Text),

                    };
                    //AnaEkran.Personeller.Add(temizlikci);
                    AnaEkran2.Personeller.Add(temizlikci);
                    AnaEkran2.Personeller2.Add(temizlikci.TcNo, temizlikci);
                    MesajYaz("Kayıt Başarılı");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
                else
                {

                    MesajYaz("Kayıt Başarısız");
                    return;

                }
            }
        }

        private void rdbDoktor_CheckedChanged(object sender, EventArgs e)
        {
            AlanLabelAc();
        }

        private void rdbHemsire_CheckedChanged(object sender, EventArgs e)
        {
            AlanLabelAc();
        }

        private void rdbEbe_CheckedChanged(object sender, EventArgs e)
        {
            AlanLabelKapat();
        }

        private void rdbTemizlikci_CheckedChanged(object sender, EventArgs e)
        {
            AlanLabelKapat();
        }

        private void rdbSekreter_CheckedChanged(object sender, EventArgs e)
        {
            AlanLabelKapat();
        }
        private void AlanLabelKapat()
        {
            lblAlan.Enabled = false;
            cmbAlan.Enabled = false;

        }
        private void AlanLabelAc()
        {
            lblAlan.Enabled = true;
            cmbAlan.Enabled = true;

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Helper.Temizle(this.Controls);
        }

        public bool KontrolEt()
        {
            if (string.IsNullOrEmpty(txtAd.Text))
            {
                HataMesajYaz("Ad Alanı Seçimsiz Bırakılmaz");
                return false;
            }
            if (AnaEkran2.Personeller2.ContainsKey(txtTcNo.Text))
            {
                HataMesajYaz("Bu TC den içeride var zaten");
                return false;
            }
            if (string.IsNullOrEmpty(txtSoyad.Text))
            {
                HataMesajYaz("Soyad Alanı Seçimsiz Bırakılmaz");
                return false;
            }
            if (string.IsNullOrEmpty(txtMaas.Text))
            {
                HataMesajYaz("Maaş Alanı Seçimsiz Bırakılmaz");
                return false;
            }
            if (string.IsNullOrEmpty(txtTcNo.Text))
            {
                HataMesajYaz("TC Alanı Seçimsiz Bırakılmaz");
                return false;
            }
            if (txtTcNo.Text.Length > 12)
            {

                HataMesajYaz("TC Alanı En Fazla 11 Karakter olabilir");
                return false;
            }

            if (cmbCinsiyet.Text == null)
            {
                HataMesajYaz("Cinsiyet Alanı Seçimsiz Bırakılmaz");
                return false;
            }
            if (cmbBina.Text == null)
            {
                HataMesajYaz("Bina Alanı Seçimsiz Bırakılmaz");
                return false;
            }


            return true;
        }

        public bool RadioButtonKontrolEt()
        {
            foreach (RadioButton radio in gbRadio.Controls)
            {
                if (radio.Checked)
                {
                    return true;
                }
            }

            HataMesajYaz("Personel Alanı Seçimsiz Bırakılmaz");
            return false;
        }

        public void MesajYaz(string mesaj)
        {
            MessageBox.Show($"{mesaj}", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void HataMesajYaz(string mesaj)
        {
            MessageBox.Show($"{mesaj}", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
