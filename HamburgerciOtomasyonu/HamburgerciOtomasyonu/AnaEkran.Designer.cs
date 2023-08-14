namespace HamburgerciOtomasyonu
{
    partial class AnaEkran
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            mspOtomasyon = new MenuStrip();
            siparişYönetimiToolStripMenuItem = new ToolStripMenuItem();
            mspSiparisOlustur = new ToolStripMenuItem();
            mspSiparisBilgileri = new ToolStripMenuItem();
            ürünYönetimiToolStripMenuItem = new ToolStripMenuItem();
            mspMenuEkle = new ToolStripMenuItem();
            mspEkstraMalzemeEkle = new ToolStripMenuItem();
            mspOtomasyon.SuspendLayout();
            SuspendLayout();
            // 
            // mspOtomasyon
            // 
            mspOtomasyon.Items.AddRange(new ToolStripItem[] { siparişYönetimiToolStripMenuItem, ürünYönetimiToolStripMenuItem });
            mspOtomasyon.Location = new Point(0, 0);
            mspOtomasyon.Name = "mspOtomasyon";
            mspOtomasyon.Size = new Size(650, 24);
            mspOtomasyon.TabIndex = 0;
            mspOtomasyon.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mspSiparisOlustur, mspSiparisBilgileri });
            siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            siparişYönetimiToolStripMenuItem.Size = new Size(103, 20);
            siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // mspSiparisOlustur
            // 
            mspSiparisOlustur.Name = "mspSiparisOlustur";
            mspSiparisOlustur.Size = new Size(150, 22);
            mspSiparisOlustur.Text = "Sipariş Oluştur";
            mspSiparisOlustur.Click += mspSiparisOlustur_Click;
            // 
            // mspSiparisBilgileri
            // 
            mspSiparisBilgileri.Name = "mspSiparisBilgileri";
            mspSiparisBilgileri.Size = new Size(150, 22);
            mspSiparisBilgileri.Text = "Sipariş Bilgileri";
            mspSiparisBilgileri.Click += mspSiparisBilgileri_Click;
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mspMenuEkle, mspEkstraMalzemeEkle });
            ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            ürünYönetimiToolStripMenuItem.Size = new Size(95, 20);
            ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // mspMenuEkle
            // 
            mspMenuEkle.Name = "mspMenuEkle";
            mspMenuEkle.Size = new Size(180, 22);
            mspMenuEkle.Text = "Menü Ekle";
            mspMenuEkle.Click += mspMenuEkle_Click;
            // 
            // mspEkstraMalzemeEkle
            // 
            mspEkstraMalzemeEkle.Name = "mspEkstraMalzemeEkle";
            mspEkstraMalzemeEkle.Size = new Size(180, 22);
            mspEkstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            mspEkstraMalzemeEkle.Click += mspEkstraMalzemeEkle_Click;
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 475);
            Controls.Add(mspOtomasyon);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = mspOtomasyon;
            Name = "AnaEkran";
            Text = "HAMBURGER OTOMASYONU";
            mspOtomasyon.ResumeLayout(false);
            mspOtomasyon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mspOtomasyon;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private ToolStripMenuItem mspSiparisOlustur;
        private ToolStripMenuItem mspSiparisBilgileri;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem mspMenuEkle;
        private ToolStripMenuItem mspEkstraMalzemeEkle;
    }
}