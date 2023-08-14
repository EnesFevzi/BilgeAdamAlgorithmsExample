namespace HamburgerciOtomasyonu
{
    partial class SiparisBilgileri
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
            lbxTumSiparisler = new ListBox();
            label1 = new Label();
            gbxCiro = new GroupBox();
            label5 = new Label();
            lblCiro = new Label();
            gbxToplamSiparisSayisi = new GroupBox();
            label2 = new Label();
            lblToplamSiparisSayisi = new Label();
            gbxEkstraMalzemeGeliri = new GroupBox();
            label3 = new Label();
            lblEkstraMalzemeGeliri = new Label();
            gbxSatilanUrunAdedi = new GroupBox();
            label4 = new Label();
            lblSatilanUrunAdedi = new Label();
            gbxCiro.SuspendLayout();
            gbxToplamSiparisSayisi.SuspendLayout();
            gbxEkstraMalzemeGeliri.SuspendLayout();
            gbxSatilanUrunAdedi.SuspendLayout();
            SuspendLayout();
            // 
            // lbxTumSiparisler
            // 
            lbxTumSiparisler.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbxTumSiparisler.FormattingEnabled = true;
            lbxTumSiparisler.HorizontalScrollbar = true;
            lbxTumSiparisler.ItemHeight = 19;
            lbxTumSiparisler.Location = new Point(12, 44);
            lbxTumSiparisler.Name = "lbxTumSiparisler";
            lbxTumSiparisler.Size = new Size(330, 384);
            lbxTumSiparisler.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 1;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // gbxCiro
            // 
            gbxCiro.Controls.Add(label5);
            gbxCiro.Controls.Add(lblCiro);
            gbxCiro.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbxCiro.Location = new Point(372, 44);
            gbxCiro.Name = "gbxCiro";
            gbxCiro.Size = new Size(200, 71);
            gbxCiro.TabIndex = 2;
            gbxCiro.TabStop = false;
            gbxCiro.Text = "Ciro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(108, 31);
            label5.Name = "label5";
            label5.Size = new Size(23, 26);
            label5.TabIndex = 2;
            label5.Text = "₺";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(57, 33);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(45, 23);
            lblCiro.TabIndex = 0;
            lblCiro.Text = "0,00";
            // 
            // gbxToplamSiparisSayisi
            // 
            gbxToplamSiparisSayisi.Controls.Add(label2);
            gbxToplamSiparisSayisi.Controls.Add(lblToplamSiparisSayisi);
            gbxToplamSiparisSayisi.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbxToplamSiparisSayisi.Location = new Point(372, 156);
            gbxToplamSiparisSayisi.Name = "gbxToplamSiparisSayisi";
            gbxToplamSiparisSayisi.Size = new Size(200, 71);
            gbxToplamSiparisSayisi.TabIndex = 2;
            gbxToplamSiparisSayisi.TabStop = false;
            gbxToplamSiparisSayisi.Text = "Toplam Sipariş Sayısı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(83, 32);
            label2.Name = "label2";
            label2.Size = new Size(54, 26);
            label2.TabIndex = 2;
            label2.Text = "Adet";
            // 
            // lblToplamSiparisSayisi
            // 
            lblToplamSiparisSayisi.AutoSize = true;
            lblToplamSiparisSayisi.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamSiparisSayisi.ForeColor = Color.Red;
            lblToplamSiparisSayisi.Location = new Point(57, 32);
            lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            lblToplamSiparisSayisi.Size = new Size(20, 23);
            lblToplamSiparisSayisi.TabIndex = 0;
            lblToplamSiparisSayisi.Text = "0";
            // 
            // gbxEkstraMalzemeGeliri
            // 
            gbxEkstraMalzemeGeliri.Controls.Add(label3);
            gbxEkstraMalzemeGeliri.Controls.Add(lblEkstraMalzemeGeliri);
            gbxEkstraMalzemeGeliri.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbxEkstraMalzemeGeliri.Location = new Point(372, 254);
            gbxEkstraMalzemeGeliri.Name = "gbxEkstraMalzemeGeliri";
            gbxEkstraMalzemeGeliri.Size = new Size(200, 71);
            gbxEkstraMalzemeGeliri.TabIndex = 2;
            gbxEkstraMalzemeGeliri.TabStop = false;
            gbxEkstraMalzemeGeliri.Text = "Ekstra Malzeme Geliri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(108, 32);
            label3.Name = "label3";
            label3.Size = new Size(23, 26);
            label3.TabIndex = 2;
            label3.Text = "₺";
            // 
            // lblEkstraMalzemeGeliri
            // 
            lblEkstraMalzemeGeliri.AutoSize = true;
            lblEkstraMalzemeGeliri.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEkstraMalzemeGeliri.ForeColor = Color.Red;
            lblEkstraMalzemeGeliri.Location = new Point(57, 34);
            lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            lblEkstraMalzemeGeliri.Size = new Size(45, 23);
            lblEkstraMalzemeGeliri.TabIndex = 0;
            lblEkstraMalzemeGeliri.Text = "0,00";
            // 
            // gbxSatilanUrunAdedi
            // 
            gbxSatilanUrunAdedi.Controls.Add(label4);
            gbxSatilanUrunAdedi.Controls.Add(lblSatilanUrunAdedi);
            gbxSatilanUrunAdedi.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbxSatilanUrunAdedi.Location = new Point(372, 357);
            gbxSatilanUrunAdedi.Name = "gbxSatilanUrunAdedi";
            gbxSatilanUrunAdedi.Size = new Size(200, 71);
            gbxSatilanUrunAdedi.TabIndex = 2;
            gbxSatilanUrunAdedi.TabStop = false;
            gbxSatilanUrunAdedi.Text = "Satılan Ürün Adedi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(83, 31);
            label4.Name = "label4";
            label4.Size = new Size(54, 26);
            label4.TabIndex = 2;
            label4.Text = "Adet";
            // 
            // lblSatilanUrunAdedi
            // 
            lblSatilanUrunAdedi.AutoSize = true;
            lblSatilanUrunAdedi.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSatilanUrunAdedi.ForeColor = Color.Red;
            lblSatilanUrunAdedi.Location = new Point(57, 33);
            lblSatilanUrunAdedi.Name = "lblSatilanUrunAdedi";
            lblSatilanUrunAdedi.Size = new Size(20, 23);
            lblSatilanUrunAdedi.TabIndex = 0;
            lblSatilanUrunAdedi.Text = "0";
            // 
            // SiparisBilgileri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(gbxSatilanUrunAdedi);
            Controls.Add(gbxEkstraMalzemeGeliri);
            Controls.Add(gbxToplamSiparisSayisi);
            Controls.Add(gbxCiro);
            Controls.Add(label1);
            Controls.Add(lbxTumSiparisler);
            Name = "SiparisBilgileri";
            Text = "SiparisBilgileri";
            Load += SiparisBilgileri_Load;
            gbxCiro.ResumeLayout(false);
            gbxCiro.PerformLayout();
            gbxToplamSiparisSayisi.ResumeLayout(false);
            gbxToplamSiparisSayisi.PerformLayout();
            gbxEkstraMalzemeGeliri.ResumeLayout(false);
            gbxEkstraMalzemeGeliri.PerformLayout();
            gbxSatilanUrunAdedi.ResumeLayout(false);
            gbxSatilanUrunAdedi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxTumSiparisler;
        private Label label1;
        private GroupBox gbxCiro;
        private GroupBox gbxToplamSiparisSayisi;
        private GroupBox gbxEkstraMalzemeGeliri;
        private GroupBox gbxSatilanUrunAdedi;
        private Label lblCiro;
        private Label lblToplamSiparisSayisi;
        private Label lblEkstraMalzemeGeliri;
        private Label lblSatilanUrunAdedi;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
    }
}