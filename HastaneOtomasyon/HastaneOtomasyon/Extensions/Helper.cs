using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon.Extensions
{
    public static class Helper
    {
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
                else if (control is RadioButton radioButton)
                {
                    if (radioButton.Name == "rdbDoktor")
                    {
                        radioButton.Checked = true;
                    }
                    else { radioButton.Checked = false; }
                }
                else if (control is GroupBox groupBox)
                {
                    Temizle(groupBox.Controls);
                }


            }
        }

        static void KontrolEt()
        {

        }


    }
}
