namespace HamburgerciOtomasyonu
{
    partial class MenüEkle
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
            gbxMenuBilgileri = new GroupBox();
            btnMenuyuKaydet = new Button();
            nudMenuFiyatı = new NumericUpDown();
            txtMenuAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gbxMenuBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyatı).BeginInit();
            SuspendLayout();
            // 
            // gbxMenuBilgileri
            // 
            gbxMenuBilgileri.Controls.Add(btnMenuyuKaydet);
            gbxMenuBilgileri.Controls.Add(nudMenuFiyatı);
            gbxMenuBilgileri.Controls.Add(txtMenuAdi);
            gbxMenuBilgileri.Controls.Add(label2);
            gbxMenuBilgileri.Controls.Add(label1);
            gbxMenuBilgileri.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbxMenuBilgileri.Location = new Point(12, 12);
            gbxMenuBilgileri.Name = "gbxMenuBilgileri";
            gbxMenuBilgileri.Size = new Size(351, 213);
            gbxMenuBilgileri.TabIndex = 1;
            gbxMenuBilgileri.TabStop = false;
            gbxMenuBilgileri.Text = "MENÜ BİLGİLERİ";
            // 
            // btnMenuyuKaydet
            // 
            btnMenuyuKaydet.Location = new Point(149, 126);
            btnMenuyuKaydet.Name = "btnMenuyuKaydet";
            btnMenuyuKaydet.Size = new Size(187, 66);
            btnMenuyuKaydet.TabIndex = 3;
            btnMenuyuKaydet.Text = "MENÜYÜ KAYDET";
            btnMenuyuKaydet.UseVisualStyleBackColor = true;
            btnMenuyuKaydet.Click += btnMenuyuKaydet_Click;
            // 
            // nudMenuFiyatı
            // 
            nudMenuFiyatı.DecimalPlaces = 2;
            nudMenuFiyatı.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudMenuFiyatı.Increment = new decimal(new int[] { 0, 0, 0, 131072 });
            nudMenuFiyatı.Location = new Point(149, 79);
            nudMenuFiyatı.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMenuFiyatı.Name = "nudMenuFiyatı";
            nudMenuFiyatı.Size = new Size(187, 27);
            nudMenuFiyatı.TabIndex = 2;
            // 
            // txtMenuAdi
            // 
            txtMenuAdi.Location = new Point(149, 35);
            txtMenuAdi.Name = "txtMenuAdi";
            txtMenuAdi.Size = new Size(187, 27);
            txtMenuAdi.TabIndex = 1;
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
            label1.Location = new Point(59, 35);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 0;
            label1.Text = "Menü Adı";
            // 
            // MenüEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 236);
            Controls.Add(gbxMenuBilgileri);
            Name = "MenüEkle";
            Text = "MenüEkle";
            gbxMenuBilgileri.ResumeLayout(false);
            gbxMenuBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyatı).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxMenuBilgileri;
        private Button btnMenuyuKaydet;
        private NumericUpDown nudMenuFiyatı;
        private TextBox txtMenuAdi;
        private Label label2;
        private Label label1;
    }
}