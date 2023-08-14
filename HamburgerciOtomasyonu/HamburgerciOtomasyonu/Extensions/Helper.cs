using HamburgerciOtomasyonu.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerciOtomasyonu.Extensions
{
    public static class Helper
    {
        public static CheckBox CreateCheckBox(EkstraMalzeme ekstraMalzeme)
        {
            CheckBox checkBox = new CheckBox
            {
                Text = ekstraMalzeme.EkstraMalzemeAdi,
                Width = 150,
                AutoSize = false,
                Font = new Font("Calibri", 11, FontStyle.Bold),
                Tag = ekstraMalzeme,
            };
            return checkBox;
        }
        public static void Temizle(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = 0;
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (control is RadioButton radioButton)
                {
                    if (radioButton.Name == "rdbKucuk")
                    {
                        radioButton.Checked = true;
                    }
                    else { radioButton.Checked = false; }
                }
                else if (control is NumericUpDown nud)
                {
                    nud.Value = default;
                }
                
                else if (control is ListBox list)
                {
                    list.Items.Clear();
                }
                else if (control is GroupBox groupBox)
                {
                    Temizle(groupBox.Controls);
                }
                else if (control is FlowLayoutPanel panel)
                {
                    Temizle(panel.Controls);
                }


            }
        }

        public static void MesajYaz(string mesaj)
        {
            MessageBox.Show($"{mesaj}", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void HataMesajYaz(string mesaj)
        {
            MessageBox.Show($"{mesaj}", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
