using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //bir çok konuyu kapsayan bi proje ismi Yazılm Proje olsun
        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(txtsayi1.Text);
            int sayi2 = Convert.ToInt16(txtsayi2.Text);
            int toplam = sayi1 + sayi2;
            txtsonuc.Text = toplam.ToString();
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(txtsayi1.Text);
            int sayi2 = Convert.ToInt16(txtsayi2.Text);
            int toplam = sayi1 * sayi2;
            txtsonuc.Text = toplam.ToString();
        }

     

        private void btnkareal_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(txtsayi1.Text);
            int kare = sayi1 * sayi1;
            txtsonuc.Text = kare.ToString();
        }

        private void btnciftmi_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(txtsayi1.Text);

            if(sayi%2 == 0)
            {
                txtsonuc.Text = "Çifttir.";
            }
            else
            {
                txtsonuc.Text = "Tektir.";
            }

        }

        private void btnyesil_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnturuncu_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Orange;
        }

        private void btnsari_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void btnmesaj_Click(object sender, EventArgs e)
        {
            //mesaj kutusunun 4 tane paremetresi vardır. içerik,başlık,buton,ikon
            //show:göstermek
            MessageBox.Show("Hayırlı ve sağlıklı günler dilerim");

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnhakkımızda_Click(object sender, EventArgs e)
        {
            //mesaj kutusunun 4 tane paremetresi vardır. içerik,başlık,buton,ikon
            //show:göstermek
            MessageBox.Show("Yazılım Geliştirici ve Eğitmeni", "Yazılım Proje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
