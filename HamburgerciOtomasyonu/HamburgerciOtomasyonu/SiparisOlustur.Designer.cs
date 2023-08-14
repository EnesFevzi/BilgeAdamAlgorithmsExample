namespace HamburgerciOtomasyonu
{
    partial class SiparisOlustur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cbxMenuler = new ComboBox();
            gbxBoyutSec = new GroupBox();
            rdbBuyukBoy = new RadioButton();
            rdbOrtaBoy = new RadioButton();
            rdbKucukBoy = new RadioButton();
            label2 = new Label();
            flpEkstraMalzemeler = new FlowLayoutPanel();
            label3 = new Label();
            nudSiparisAdeti = new NumericUpDown();
            label4 = new Label();
            lblToplamTutar = new Label();
            btnSiparisiTamamla = new Button();
            lbxSiparisiGoster = new ListBox();
            label5 = new Label();
            btnSiparisiEkle = new Button();
            gbxMenuSecme = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbxBoyutSec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSiparisAdeti).BeginInit();
            gbxMenuSecme.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hamburgerphoto;
            pictureBox1.Location = new Point(11, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 197);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 1;
            label1.Text = "MENÜ SEÇİNİZ";
            // 
            // cbxMenuler
            // 
            cbxMenuler.FormattingEnabled = true;
            cbxMenuler.Location = new Point(11, 232);
            cbxMenuler.Name = "cbxMenuler";
            cbxMenuler.Size = new Size(324, 23);
            cbxMenuler.TabIndex = 2;
            // 
            // gbxBoyutSec
            // 
            gbxBoyutSec.Controls.Add(rdbBuyukBoy);
            gbxBoyutSec.Controls.Add(rdbOrtaBoy);
            gbxBoyutSec.Controls.Add(rdbKucukBoy);
            gbxBoyutSec.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbxBoyutSec.Location = new Point(6, 271);
            gbxBoyutSec.Name = "gbxBoyutSec";
            gbxBoyutSec.Size = new Size(324, 62);
            gbxBoyutSec.TabIndex = 3;
            gbxBoyutSec.TabStop = false;
            gbxBoyutSec.Text = "BOYUT SEÇİNİZ";
            // 
            // rdbBuyukBoy
            // 
            rdbBuyukBoy.AutoSize = true;
            rdbBuyukBoy.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbBuyukBoy.Location = new Point(216, 26);
            rdbBuyukBoy.Name = "rdbBuyukBoy";
            rdbBuyukBoy.Size = new Size(64, 22);
            rdbBuyukBoy.TabIndex = 4;
            rdbBuyukBoy.TabStop = true;
            rdbBuyukBoy.Text = "Buyuk";
            rdbBuyukBoy.UseVisualStyleBackColor = true;
            // 
            // rdbOrtaBoy
            // 
            rdbOrtaBoy.AutoSize = true;
            rdbOrtaBoy.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbOrtaBoy.Location = new Point(111, 26);
            rdbOrtaBoy.Name = "rdbOrtaBoy";
            rdbOrtaBoy.Size = new Size(53, 22);
            rdbOrtaBoy.TabIndex = 4;
            rdbOrtaBoy.TabStop = true;
            rdbOrtaBoy.Text = "Orta";
            rdbOrtaBoy.UseVisualStyleBackColor = true;
            // 
            // rdbKucukBoy
            // 
            rdbKucukBoy.AutoSize = true;
            rdbKucukBoy.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbKucukBoy.Location = new Point(6, 26);
            rdbKucukBoy.Name = "rdbKucukBoy";
            rdbKucukBoy.Size = new Size(63, 22);
            rdbKucukBoy.TabIndex = 4;
            rdbKucukBoy.TabStop = true;
            rdbKucukBoy.Text = "Kucuk";
            rdbKucukBoy.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 346);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 1;
            label2.Text = "MALZEME SEÇİN";
            // 
            // flpEkstraMalzemeler
            // 
            flpEkstraMalzemeler.Location = new Point(11, 372);
            flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            flpEkstraMalzemeler.Size = new Size(318, 253);
            flpEkstraMalzemeler.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 631);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 1;
            label3.Text = "ADET";
            // 
            // nudSiparisAdeti
            // 
            nudSiparisAdeti.Location = new Point(99, 631);
            nudSiparisAdeti.Name = "nudSiparisAdeti";
            nudSiparisAdeti.Size = new Size(230, 23);
            nudSiparisAdeti.TabIndex = 5;
            nudSiparisAdeti.TextAlign = HorizontalAlignment.Center;
            nudSiparisAdeti.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(363, 604);
            label4.Name = "label4";
            label4.Size = new Size(122, 23);
            label4.TabIndex = 1;
            label4.Text = "TOPLAM TUTAR:";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblToplamTutar.ForeColor = Color.Red;
            lblToplamTutar.Location = new Point(491, 604);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(43, 23);
            lblToplamTutar.TabIndex = 1;
            lblToplamTutar.Text = "0,00";
            // 
            // btnSiparisiTamamla
            // 
            btnSiparisiTamamla.BackColor = SystemColors.ActiveCaption;
            btnSiparisiTamamla.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisiTamamla.Location = new Point(678, 604);
            btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            btnSiparisiTamamla.Size = new Size(283, 100);
            btnSiparisiTamamla.TabIndex = 6;
            btnSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            btnSiparisiTamamla.UseVisualStyleBackColor = false;
            btnSiparisiTamamla.Click += btnSiparisiTamamla_Click;
            // 
            // lbxSiparisiGoster
            // 
            lbxSiparisiGoster.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbxSiparisiGoster.FormattingEnabled = true;
            lbxSiparisiGoster.ItemHeight = 19;
            lbxSiparisiGoster.Location = new Point(353, 12);
            lbxSiparisiGoster.Name = "lbxSiparisiGoster";
            lbxSiparisiGoster.Size = new Size(608, 574);
            lbxSiparisiGoster.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(540, 601);
            label5.Name = "label5";
            label5.Size = new Size(25, 26);
            label5.TabIndex = 1;
            label5.Text = "₺";
            // 
            // btnSiparisiEkle
            // 
            btnSiparisiEkle.BackColor = SystemColors.ActiveCaption;
            btnSiparisiEkle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisiEkle.Location = new Point(13, 681);
            btnSiparisiEkle.Name = "btnSiparisiEkle";
            btnSiparisiEkle.Size = new Size(318, 42);
            btnSiparisiEkle.TabIndex = 6;
            btnSiparisiEkle.Text = "SİPARİŞ EKLE";
            btnSiparisiEkle.UseVisualStyleBackColor = false;
            btnSiparisiEkle.Click += btnSiparisiEkle_Click;
            // 
            // gbxMenuSecme
            // 
            gbxMenuSecme.Controls.Add(pictureBox1);
            gbxMenuSecme.Controls.Add(label1);
            gbxMenuSecme.Controls.Add(label3);
            gbxMenuSecme.Controls.Add(label2);
            gbxMenuSecme.Controls.Add(nudSiparisAdeti);
            gbxMenuSecme.Controls.Add(cbxMenuler);
            gbxMenuSecme.Controls.Add(flpEkstraMalzemeler);
            gbxMenuSecme.Controls.Add(gbxBoyutSec);
            gbxMenuSecme.Location = new Point(1, 12);
            gbxMenuSecme.Name = "gbxMenuSecme";
            gbxMenuSecme.Size = new Size(335, 663);
            gbxMenuSecme.TabIndex = 8;
            gbxMenuSecme.TabStop = false;
            gbxMenuSecme.Text = "Menü Seçme";
            // 
            // SiparisOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 730);
            Controls.Add(gbxMenuSecme);
            Controls.Add(lbxSiparisiGoster);
            Controls.Add(btnSiparisiEkle);
            Controls.Add(btnSiparisiTamamla);
            Controls.Add(label5);
            Controls.Add(lblToplamTutar);
            Controls.Add(label4);
            Name = "SiparisOlustur";
            Text = "SiparisOlustur";
            Load += SiparisOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbxBoyutSec.ResumeLayout(false);
            gbxBoyutSec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSiparisAdeti).EndInit();
            gbxMenuSecme.ResumeLayout(false);
            gbxMenuSecme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cbxMenuler;
        private GroupBox gbxBoyutSec;
        private RadioButton rdbKucukBoy;
        private RadioButton rdbBuyukBoy;
        private RadioButton rdbOrtaBoy;
        private Label label2;
        private FlowLayoutPanel flpEkstraMalzemeler;
        private Label label3;
        private NumericUpDown nudSiparisAdeti;
        private Label label4;
        private Label lblToplamTutar;
        private Button btnSiparisiTamamla;
        private ListBox lbxSiparisiGoster;
        private Label label5;
        private Button btnSiparisiEkle;
        private GroupBox gbxMenuSecme;
    }
}