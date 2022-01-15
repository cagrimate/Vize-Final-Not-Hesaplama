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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btn3Vize_Click(object sender, EventArgs e)
        {
            Form3Vize f3 = new Form3Vize();
            f3.Show();

        }
        private void btn2vize_Click(object sender, EventArgs e)
        {
            Form2Vize f2 = new Form2Vize();
            f2.Show();

        }
    }
}
