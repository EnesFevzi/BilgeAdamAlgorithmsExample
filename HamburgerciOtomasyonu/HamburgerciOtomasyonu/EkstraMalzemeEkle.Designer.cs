namespace HamburgerciOtomasyonu
{
    partial class EkstraMalzemeEkle
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
            gbxEkstraMalzemeBilgileri = new GroupBox();
            btnEkstraMalzemeyiKaydet = new Button();
            nudEkstraMalzemeFiyatı = new NumericUpDown();
            txtEkstraMalzemeAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gbxEkstraMalzemeBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEkstraMalzemeFiyatı).BeginInit();
            SuspendLayout();
            // 
            // gbxEkstraMalzemeBilgileri
            // 
            gbxEkstraMalzemeBilgileri.Controls.Add(btnEkstraMalzemeyiKaydet);
            gbxEkstraMalzemeBilgileri.Controls.Add(nudEkstraMalzemeFiyatı);
            gbxEkstraMalzemeBilgileri.Controls.Add(txtEkstraMalzemeAdi);
            gbxEkstraMalzemeBilgileri.Controls.Add(label2);
            gbxEkstraMalzemeBilgileri.Controls.Add(label1);
            gbxEkstraMalzemeBilgileri.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbxEkstraMalzemeBilgileri.Location = new Point(12, 12);
            gbxEkstraMalzemeBilgileri.Name = "gbxEkstraMalzemeBilgileri";
            gbxEkstraMalzemeBilgileri.Size = new Size(351, 214);
            gbxEkstraMalzemeBilgileri.TabIndex = 0;
            gbxEkstraMalzemeBilgileri.TabStop = false;
            gbxEkstraMalzemeBilgileri.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // btnEkstraMalzemeyiKaydet
            // 
            btnEkstraMalzemeyiKaydet.Location = new Point(149, 126);
            btnEkstraMalzemeyiKaydet.Name = "btnEkstraMalzemeyiKaydet";
            btnEkstraMalzemeyiKaydet.Size = new Size(187, 66);
            btnEkstraMalzemeyiKaydet.TabIndex = 3;
            btnEkstraMalzemeyiKaydet.Text = "EKSTRA MALZEMEYİ KAYDET";
            btnEkstraMalzemeyiKaydet.UseVisualStyleBackColor = true;
            btnEkstraMalzemeyiKaydet.Click += btnEkstraMalzemeyiKaydet_Click;
            // 
            // nudEkstraMalzemeFiyatı
            // 
            nudEkstraMalzemeFiyatı.DecimalPlaces = 2;
            nudEkstraMalzemeFiyatı.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudEkstraMalzemeFiyatı.Increment = new decimal(new int[] { 0, 0, 0, 131072 });
            nudEkstraMalzemeFiyatı.Location = new Point(149, 79);
            nudEkstraMalzemeFiyatı.Name = "nudEkstraMalzemeFiyatı";
            nudEkstraMalzemeFiyatı.Size = new Size(187, 27);
            nudEkstraMalzemeFiyatı.TabIndex = 2;
            // 
            // txtEkstraMalzemeAdi
            // 
            txtEkstraMalzemeAdi.Location = new Point(149, 35);
            txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            txtEkstraMalzemeAdi.Size = new Size(187, 27);
            txtEkstraMalzemeAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(87, 81);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 0;
            label2.Text = "Fiyatı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(136, 19);
            label1.TabIndex = 0;
            label1.Text = "Eksta Malzeme Adı";
            // 
            // EkstraMalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 238);
            Controls.Add(gbxEkstraMalzemeBilgileri);
            Name = "EkstraMalzemeEkle";
            Text = "EkstraMalzemeEkle";
            gbxEkstraMalzemeBilgileri.ResumeLayout(false);
            gbxEkstraMalzemeBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEkstraMalzemeFiyatı).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxEkstraMalzemeBilgileri;
        private Button btnEkstraMalzemeyiKaydet;
        private NumericUpDown nudEkstraMalzemeFiyatı;
        private TextBox txtEkstraMalzemeAdi;
        private Label label2;
        private Label label1;
    }
}