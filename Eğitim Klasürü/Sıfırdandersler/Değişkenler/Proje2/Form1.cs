using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkırmızı_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;//bu üzerinde çalıştığımız arka plan rengi kırmızı yaptık
        }

        private void btnsiyah_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void btnyesil_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnmavi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btnsari_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void btnturuncu_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3, proje, ortalama;
            sinav1 = Convert.ToDouble(txtsinav1.Text);
            sinav2 = Convert.ToDouble(txtsinav2.Text);
            sinav3 = Convert.ToDouble(txtsinav3.Text);
            proje = Convert.ToDouble(txtproje.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            txtortalama.Text = ortalama.ToString();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtad.Text = "";
            txtsoyad.Text = "";
            txtsinav1.Text = "";
            txtsinav2.Text = "";
            txtsinav3.Text = "";
            txtproje.Text = "";
            txtortalama.Text = "";
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Öğrenci:" + txtad.Text + " " + txtsoyad.Text + "Ortalama: " + txtortalama.Text);
        }
    }
}
