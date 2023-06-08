using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Double veri türü;Ondalıklı veriler için kullanılır.
            // virgülden sonra 15 basamağa kadar değeri gösterebilen double değişkenlerin aralığı int değişkenlerine göre çok daha büyüktür.
            //Tam Sayılar içide kullanılabilir.

            //Double değişkenlerin dönüşümlerinde ToDouble metodu kullanılır.
            //double değişkenlerin ondalık kısmı klavyeden girerken virgül ile , kod kısmınadan girerek ile ayrılır.

            double sayi;
            sayi = 35.8;
            label1.Text= sayi.ToString();// burda da label a string olarak yazılması gerektiği için ToString metodunu kullanırız.



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //iki ondalıklı sayının çarpımını bulan program yazınız

            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2= Convert.ToDouble(textBox2.Text);

            sonuc = sayi1 * sayi2;
            textBox3.Text=sonuc.ToString();

        }
    }
}
