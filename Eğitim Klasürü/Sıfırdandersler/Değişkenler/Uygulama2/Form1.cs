using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int veri türü:Tam sayı türündeki değerler üzerinde aritmetik işlemler yapar.
            int sayi;
            sayi = 24;
            label1.Text=sayi.ToString();//label text olarak algıladığı için sayi değişkenini stringe cevirdik tostring metodu sayesinde 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = 30;
            sayi2 = 12;
            toplam= sayi1+sayi2;
            label2.Text=toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2,sinav3,ortalama;
            sinav1 = 50;
            sinav2= 70;
            sinav3= 55;
            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            label3.Text = "Ortalama: " + ortalama.ToString();

        }
    }
}
