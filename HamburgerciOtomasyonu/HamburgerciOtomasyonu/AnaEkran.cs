using HamburgerciOtomasyonu.Concrete;
using System.Windows.Forms;

namespace HamburgerciOtomasyonu
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        public static List<Siparis> AnlýkSiparisler = new List<Siparis>();
        public static List<Siparis> ToplamSiparisler = new List<Siparis>();
        private void mspSiparisOlustur_Click(object sender, EventArgs e)
        {
            MdiFormKontrolEtveAc(new SiparisOlustur());
        }

        private void mspSiparisBilgileri_Click(object sender, EventArgs e)
        {
            MdiFormKontrolEtveAc(new SiparisBilgileri());
        }

        private void mspMenuEkle_Click(object sender, EventArgs e)
        {
            MdiFormKontrolEtveAc(new MenüEkle());
        }

        private void mspEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            MdiFormKontrolEtveAc(new EkstraMalzemeEkle());
        }

        public void MdiFormKontrolEtveAc(Form form)
        {

            bool formAcikMi = false;

            foreach (Form item in this.MdiChildren)
            {
                if (item.Text == form.Text)
                {
                    item.Activate();
                    formAcikMi = true;

                }
                else
                {
                    item.Close();

                }
            }
            if (!formAcikMi)
            {
                form.MdiParent = this;
                form.Show();
            }

            BoyutAyarla(form);
        }
        public void BoyutAyarla(Form form)
        {
            this.Width = form.Width + 30;
            this.Height = form.Height + 20;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
        }


    }
}