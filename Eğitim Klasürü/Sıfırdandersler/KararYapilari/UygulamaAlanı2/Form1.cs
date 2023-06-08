using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UygulamaAlanı2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Klavyeden girilen 3 sayının toplamının 50 den büyük olup olmadığını kontrol eden program yazınız.
            int sayi1, sayi2, sayi3, toplam;
            sayi1=Convert.ToInt16(textBox1.Text);
            sayi2=Convert.ToInt16(textBox2.Text);
            sayi3=Convert.ToInt16(textBox3.Text);
            toplam = sayi1 + sayi2+sayi3;
            textBox4.Text = toplam.ToString();

            if (toplam >= 50)
            {
                textBox5.Text = "Toplam 50'den büyük";
            }

            else
            {
                textBox5.Text = "Toplam 50'den küçük";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Klavyeden girilen 2 sayının birbirine bölümünde kalanı bulan programı yazalım
            int sayi1, sayi2, kalan;
            sayi1 = Convert.ToInt16(textBox8.Text);
            sayi2 = Convert.ToInt16(textBox7.Text);
            kalan = sayi1 / sayi2; //bu sayı ondalıklı çıksa da kalan değişkenini int veri türünde tanımladığımız için tam sayı döndürür örneğin 4.6 eğer çıkarsa 4 ' ü döndürür
            textBox6.Text=kalan.ToString();
        }
    }
}
