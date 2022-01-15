using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize_Final_Not_Hesaplama
{
    public partial class Form2Vize : Form
    {

        public Form2Vize()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double vize1 = 0, vize2 = 0, vize3 = 0, Final = 0, ort = 0;

            if (!string.IsNullOrEmpty(txtVize1.Text) && !string.IsNullOrEmpty(txtVize2.Text) && !string.IsNullOrEmpty(txtFinal.Text))
            {
                vize1 = Convert.ToDouble(txtVize1.Text);
                vize2 = Convert.ToDouble(txtVize2.Text);
                Final = Convert.ToDouble(txtFinal.Text);
                ort = vize1 * 0.2 + vize2 * 0.2 + Final * 0.6;
                txtOrt.Text = ort.ToString();
                if (ort<45)
                {
                    txtSonuc.Text = " FF ile Kaldınız! ";
                    txtSonuc.ForeColor = Color.Red;                        
                }
                else if (ort>=45 && ort < 55)
                {
                    txtSonuc.Text = " FD ile Kaldınız !";
                    txtSonuc.ForeColor = Color.Red;

                }
                else if (ort>=55 && ort<65)
                {
                    txtSonuc.Text = " Tebrikler DD Geçtiniz!";
                    txtSonuc.ForeColor = Color.Green;
                }
                else if (ort>=65 && ort<75)
                {
                    txtSonuc.Text = "Tebrikler CC ile Geçtiniz ! ";
                    txtSonuc.ForeColor = Color.Aqua;

                }
                else if (ort>=75 && ort <85)
                {
                    txtSonuc.Text = " Tebrikler BB ile Geçtiniz ! ";
                    txtSonuc.ForeColor = Color.Gold;
                }
                else if (ort >=85 && ort <=100)
                {
                    txtSonuc.Text = " Tebrikler AA ile Geçtiniz ! ";
                    txtSonuc.ForeColor = Color.OrangeRed;
                }
                else
                {
                    MessageBox.Show("Yanlış Giriş Yaptınız");
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız");
            }
        }
    }
}
