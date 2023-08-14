namespace HastaneOtomasyon
{
    partial class AnaEkran
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(176, 25);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(142, 67);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Personel Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(496, 420);
            this.listBox1.TabIndex = 2;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 560);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEkle);
            this.Name = "AnaEkran";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listBox1;
    }
}

