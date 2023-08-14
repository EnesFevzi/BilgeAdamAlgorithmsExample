
using HastaneOtomasyon.Abstract;
using HastaneOtomasyon.Concrete;
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
    public partial class DetayEkran : Form
    {
       protected readonly IPersonel _personel;
        public DetayEkran(IPersonel personel)
        {
            InitializeComponent();
            _personel = personel;

        }

        private void DetayEkran_Load(object sender, EventArgs e)
        {
            txtAd.Text = _personel.Ad;
            txtSoyad.Text = _personel.Soyad;
            txtYas.Text=_personel.Yas.ToString();
            txtMaas.Text=_personel.Maas.ToString();
            txtTcNo.Text = _personel.TcNo.ToString();
            cmbCinsiyet.Text = _personel.Cinsiyet.ToString();
            cmbBina.Text = _personel.Bina.ToString();

            if (_personel is Doktor doktor)
            {
                lblAlan.Visible = true;
                cmbAlan.Visible = true;
                cmbAlan.Text = doktor.Alan.ToString();

            }
            else if (_personel is Hemsire hemsire)
            {
                lblAlan.Visible = true;
                cmbAlan.Visible = true;
                cmbAlan.Text = hemsire.Alan.ToString();

            }
            else if (_personel is Ebe ebe)
            {
                lblAlan.Visible = true;
                cmbAlan.Visible = true;
                cmbAlan.Text = ebe.Alan.ToString();
            }

            else
            {
                lblAlan.Visible = false;
                cmbAlan.Visible=false;
            }
        }
    }
}
