using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araçlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // buton kelimesi türkçeye döğme olarak çevireceğimiz ve görev olarak tıpkı düğmenin yaptığı işleri yapan aracımızdır

            //MessageBox.Show("Merhaba Dünya");

            //button1.Text = "Merhalar,ben yazılım Geliştirici & Eğitmeni şehmus çakar ";

            label1.Text = "İlerleyebilmenin tek sırrı başlamaktır";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //etiket anlamına gelir.etiketler ürünler hakında bilgi verenlerdir,veya kartlardır
            /*
             Text:label üzerindeki yazıdır
            name:label yada diğer araçlarımızın kodlama tarafındakiisimlerini değiştirmek için kullanlır. birden fazla araçlar veya aynı arraçlar kulandığında isim vererek devam
             edilmesi daha sağlıklı olaccaktır.
            AutoSize:Laberl aracımızın otomatik boyut modeudur başlangıçta değeri False şeklindedir.



             */

        }
    }
}
