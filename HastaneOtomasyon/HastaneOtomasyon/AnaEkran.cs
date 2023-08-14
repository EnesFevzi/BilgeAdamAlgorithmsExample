using HastaneOtomasyon.Abstract;
using HastaneOtomasyon.Concrete;
using HastaneOtomasyon.Enums;
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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        public static List<IPersonel> Personeller = new List<IPersonel>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle();
            DialogResult result = personelEkle.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (IPersonel personel in Personeller)
                {
                    listBox1.Items.Add(personel.PersonelBilgi());
                }

            }



        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

            Doktor doktor = new Doktor()
            {
                Ad = "Tekin",
                Soyad = "Ozturk",
                Maas = 7500.50,
                TcNo = "12345678901",
                Yas = 35,
                Cinsiyet = Enums.Cinsiyet.Erkek,
                Bina = Binalar.ABlok,
                Alan = Alan.Goz,

            };

           

            Hemsire hemsire = new Hemsire()
            {
                Ad = "Ayşe",
                Soyad = "Demir",
                Maas = 5500.75,
                TcNo = "98765432101",
                Yas = 28,
                Cinsiyet = Cinsiyet.Kadın,
                Bina = Binalar.BBlok,
                Alan = Alan.Acil,
            };

            Ebe ebe = new Ebe()
            {
                Ad = "Eren",
                Soyad = "Çolak",
                Maas = 16800,
                TcNo = "98765432101",
                Yas = 28,
                Cinsiyet = Cinsiyet.Kadın,
                Bina = Binalar.BBlok,
            };

            Temizlikci temizlikci = new Temizlikci()
            {
                Ad = "Tarık",
                Soyad = "Yüksel",
                Maas = 12500,
                TcNo = "98765432101",
                Yas = 28,
                Cinsiyet = Cinsiyet.Erkek,
                Bina = Binalar.CBlok,
            };

            Sekreter sekreter = new Sekreter()
            {
                Ad = "Neslihan",
                Soyad = "Demirler",
                Maas = 16800,
                TcNo = "987654532101",
                Yas = 15,
                Cinsiyet = Cinsiyet.Kadın,
                Bina = Binalar.BBlok,
            };
            Personeller.Add(doktor);
            Personeller.Add(hemsire);
            Personeller.Add(sekreter);
            Personeller.Add(ebe);
            Personeller.Add(temizlikci);



            foreach (IPersonel personel in Personeller)
            {
                listBox1.Items.Add(personel.PersonelBilgi());
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //IPersonel personel =(IPersonel)listBox1.SelectedItem;

            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < Personeller.Count)
            {
                IPersonel personel = Personeller[selectedIndex];
                DetayEkran detayEkran = new DetayEkran(personel);
                detayEkran.ShowDialog();

            }

        }
       
    }
}
