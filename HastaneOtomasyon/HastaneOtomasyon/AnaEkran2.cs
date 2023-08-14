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
    public partial class AnaEkran2 : Form
    {
        public AnaEkran2()
        {
            InitializeComponent();
        }
        public static List<IPersonel> Personeller = new List<IPersonel>();
        public static Dictionary<string, IPersonel> Personeller2 = new Dictionary<string, IPersonel>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle();
            DialogResult result = personelEkle.ShowDialog();
            if (result == DialogResult.OK)
            {
                lvPersonel.Items.Clear();
                #region List
                //foreach (IPersonel personel in Personeller)
                //{
                //    ListViewItem item = new ListViewItem(new string[] { personel.Ad, personel.Soyad, personel.TcNo ,personel.Cinsiyet.ToString(),personel.Bina.ToString()});
                //    item.Tag = personel; 
                //    lvPersonel.Items.Add(item);
                //}
                #endregion


                #region Dictionary
                ListViewDoldur(Personeller2);
                #endregion

            }
        }

        private void AnaEkran2_Load(object sender, EventArgs e)
        {
            Doktor doktor1 = new Doktor()
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

            Hemsire hemsire1 = new Hemsire()
            {
                Ad = "Ayşe",
                Soyad = "Demir",
                Maas = 5500.75,
                TcNo = "987654320101",
                Yas = 28,
                Cinsiyet = Enums.Cinsiyet.Kadın,
                Bina = Binalar.BBlok,
                Alan = Alan.Acil,
            };

            Ebe ebe1 = new Ebe()
            {
                Ad = "Eren",
                Soyad = "Çolak",
                Maas = 16800,
                TcNo = "987654323101",
                Yas = 28,
                Cinsiyet = Enums.Cinsiyet.Kadın,
                Bina = Binalar.BBlok,
            };

            Temizlikci temizlikci1 = new Temizlikci()
            {
                Ad = "Tarık",
                Soyad = "Yüksel",
                Maas = 12500,
                TcNo = "987654342101",
                Yas = 28,
                Cinsiyet = Enums.Cinsiyet.Erkek,
                Bina = Binalar.CBlok,
            };

            Sekreter sekreter1 = new Sekreter()
            {
                Ad = "Neslihan",
                Soyad = "Demirler",
                Maas = 16800,
                TcNo = "9876545325101",
                Yas = 15,
                Cinsiyet = Enums.Cinsiyet.Kadın,
                Bina = Binalar.BBlok,
            };

            #region List
            //Personeller.Add(doktor);
            //Personeller.Add(hemsire);
            //Personeller.Add(sekreter);
            //Personeller.Add(ebe);
            //Personeller.Add(temizlikci);
            #endregion

            #region Dictionary
            Personeller2.Add(doktor1.TcNo, doktor1);
            Personeller2.Add(hemsire1.TcNo, hemsire1);
            Personeller2.Add(sekreter1.TcNo, sekreter1);
            Personeller2.Add(ebe1.TcNo, ebe1);
            Personeller2.Add(temizlikci1.TcNo, temizlikci1);
            ListViewDoldur(Personeller2);
            #endregion


            #region List
            //lvPersonel.Items.Clear();
            //foreach (IPersonel personel in Personeller)
            //{
            //    ListViewItem item = new ListViewItem(new string[] { personel.Ad, personel.Soyad, personel.TcNo, personel.Cinsiyet.ToString(), personel.Bina.ToString() });
            //    item.Tag = personel;
            //    lvPersonel.Items.Add(item);
            //}
            #endregion

           
        }

        private void ListViewDoldur(Dictionary<string,IPersonel>personelList)
        {
            lvPersonel.Items.Clear();
            //foreach (var kvp in Personeller2)
            //{
            //    IPersonel personel = kvp.Value;
            //    ListViewItem item = new ListViewItem(new string[] { personel.Ad, personel.Soyad, personel.TcNo, personel.Cinsiyet.ToString(), personel.Bina.ToString() });
            //    item.Tag = personel;
            //    lvPersonel.Items.Add(item);

            //}


            #region ArdaHocanın
            foreach (var item2 in Personeller2)
            {
                IPersonel personel = item2.Value;
                string[] forLvi = { personel.Ad, personel.Soyad, personel.TcNo, personel.Cinsiyet.ToString(), personel.Bina.ToString() };
                ListViewItem lv1 = new ListViewItem(forLvi);
                lv1.Tag = personel;
                lvPersonel.Items.Add(lv1);
            }
            #endregion

        }

        private void lvPersonel_DoubleClick(object sender, EventArgs e)
        {
            #region List
            //if (lvPersonel.SelectedItems.Count > 0)
            //{
            //    ListViewItem selectedItem = lvPersonel.SelectedItems[0];
            //    IPersonel selectedPersonel = (IPersonel)selectedItem.Tag; 

            //    DetayEkran detayEkran = new DetayEkran(selectedPersonel);
            //    detayEkran.ShowDialog();
            //}
            #endregion

            #region Dictionary
            //if (lvPersonel.SelectedItems.Count > 0)
            //{
            //    ListViewItem selectedItem = lvPersonel.SelectedItems[0];
            //    IPersonel selectedPersonel = (IPersonel)selectedItem.Tag;

            //    DetayEkran detayEkran = new DetayEkran(selectedPersonel);
            //    detayEkran.ShowDialog();
            //}

            #region ARDA HOCA
            IPersonel selectedPersonel = (IPersonel)lvPersonel.SelectedItems[0].Tag;
            DetayEkran detayEkran = new DetayEkran(selectedPersonel);
            detayEkran.ShowDialog();
            #endregion


            #endregion


        }
    }
}
