﻿namespace HastaneOtomasyon
{
    partial class AnaEkran2
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lvPersonel = new System.Windows.Forms.ListView();
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoyAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TcNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(217, 24);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(142, 67);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Personel Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lvPersonel
            // 
            this.lvPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ad,
            this.SoyAd,
            this.TcNo,
            this.Cinsiyet,
            this.Bina});
            this.lvPersonel.FullRowSelect = true;
            this.lvPersonel.GridLines = true;
            this.lvPersonel.HideSelection = false;
            this.lvPersonel.Location = new System.Drawing.Point(57, 138);
            this.lvPersonel.MultiSelect = false;
            this.lvPersonel.Name = "lvPersonel";
            this.lvPersonel.Size = new System.Drawing.Size(485, 421);
            this.lvPersonel.TabIndex = 2;
            this.lvPersonel.UseCompatibleStateImageBehavior = false;
            this.lvPersonel.View = System.Windows.Forms.View.Details;
            this.lvPersonel.DoubleClick += new System.EventHandler(this.lvPersonel_DoubleClick);
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            this.Ad.Width = 100;
            // 
            // SoyAd
            // 
            this.SoyAd.Text = "Soy Ad";
            this.SoyAd.Width = 100;
            // 
            // TcNo
            // 
            this.TcNo.Text = "Tc No";
            this.TcNo.Width = 120;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Text = "Cinsiyet";
            // 
            // Bina
            // 
            this.Bina.Text = "Bina Blok";
            this.Bina.Width = 100;
            // 
            // AnaEkran2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 590);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lvPersonel);
            this.Name = "AnaEkran2";
            this.Text = "AnaEkran2";
            this.Load += new System.EventHandler(this.AnaEkran2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.ListView lvPersonel;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader SoyAd;
        private System.Windows.Forms.ColumnHeader TcNo;
        private System.Windows.Forms.ColumnHeader Cinsiyet;
        private System.Windows.Forms.ColumnHeader Bina;
    }
}