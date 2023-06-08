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
            //GrouoBox aracı:belirli araçları bir arada tutmaya yarayan onları bir grup altına alan aracımızdır.
            // Mersin Tantuni Salonu


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tavuk_tantuni, et_tantuni, su, gazli_icecek, toplam;

            tavuk_tantuni = Convert.ToInt16(txttavuk.Text);//burda tavuk tani sayısını gireceğimiz textbox'ımızı İnt veri türüne dönüştürüyoruz.

            et_tantuni = Convert.ToInt16(txtet.Text);

            gazli_icecek = Convert.ToInt16(txtgazli.Text);

            su = Convert.ToInt16(txtsu.Text);

            toplam = tavuk_tantuni * 35 + et_tantuni * 60 + gazli_icecek * 10 + su * 4;//burda araçlarımızı değişkenlerimize atadıktan sonra aritmetsel işlemleri yaptık
            lbltoplam.Text = toplam.ToString();
        
        }
    }
}
