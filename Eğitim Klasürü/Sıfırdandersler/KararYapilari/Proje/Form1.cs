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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        int soruno = 0, dogru = 0, yanlis = 0;// buraya tanımladığımızda global olur yani sayfadaki(sınıfın) bütün fonksiyonlarda kullanılabilir.

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnbaslat.Enabled = true;
            labelkontrol1.Text = btnb.Text;//labelkontrol1 ile doğru olan şıkkın atamasını yapıyoruuz,labelkontrol2 ilede kontrolü sağlıyoruz labelkontol1 ile
            if (labelkontrol2.Text == labelkontrol1.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                panel1.BackColor = Color.Blue;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                panel1.BackColor = Color.Wheat;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnbaslat.Enabled = true;
            labelkontrol1.Text = btnc.Text;//labelkontrol1 ile doğru olan şıkkın atamasını yapıyoruuz,labelkontrol2 ilede kontrolü sağlıyoruz labelkontol1 ile
            if (labelkontrol2.Text == labelkontrol1.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                panel1.BackColor = Color.Blue;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                panel1.BackColor = Color.Wheat;
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnbaslat.Enabled = true;
            labelkontrol1.Text = btnd.Text;//labelkontrol1 ile doğru olan şıkkın atamasını yapıyoruuz,labelkontrol2 ilede kontrolü sağlıyoruz labelkontol1 ile
            if (labelkontrol2.Text == labelkontrol1.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                panel1.BackColor = Color.Blue;//doğru olduğunda ren bu olsun 
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                panel1.BackColor = Color.Wheat;
            }
        }

        private void btna_Click(object sender, EventArgs e)
        {
            //herhangi bir şıkka tılandığı zaman birden fazla şıkka tıklnamasın diye şiklerı enabled özeliğini false yapptık
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnbaslat.Enabled = true;
            labelkontrol1.Text = btna.Text;//labelkontrol1 ile doğru olan şıkkın atamasını yapıyoruuz,labelkontrol ilede kontrolü sağlıyoruz bizim verdiğiiz cevabı labelkontol1 ile
            if (labelkontrol2.Text == labelkontrol1.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                panel1.BackColor = Color.Blue;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                panel1.BackColor = Color.Wheat;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. kısım
            //3 sorudan oluşan bir bilgi yarışması programı oluşturalım.oyuncu sorulara doğru verdikçe cevap verdikçe doğru sayısı 1, yanlış cevap vverdikçe yanlış 
            //sayısı 1 artsın. 3 sorunun sonunda toplam doğru ve yanlış sayısını ekranda nesaj kutusu içerisinde görelim.

            soruno++;//burda soruno değerini 1 artırmış olduk
            lblsoru.Text = soruno.ToString();
            btnbaslat.Text = "sonraki";
            btnbaslat.Enabled = false;//buda buton artık tıklandığında da etki gürmeyecek pasif olacak anlamına geliyor. enabled:etkinleştirilmiş
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;

            if (soruno == 1) //başta bu soru gelecekk 
            {
                richTextBox1.Text = "Mersin ilinim plaka kodu kaçtır?";
                btna.Text = "66";
                btnb.Text = "21";
                btnc.Text = "33";
                btnd.Text = "44";
                labelkontrol1.Text = "33"; // bu label' i visible yaptık yani program çalıştığuında bu label görünmeyecek ilgili kod çalıştığında 33 değerini döndürecek.

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Bir gün kaç saatir?";
                btna.Text = "23";
                btnb.Text = "24";
                btnc.Text = "28";
                btnd.Text = "25";
                labelkontrol1.Text = "24";

            }

            if (soruno == 3)
            {
                richTextBox1.Text = " Bir yıl kaç aydan oluşur ?";
                btna.Text = "12";
                btnb.Text = "22";
                btnc.Text = "13";
                btnd.Text = "14";
                labelkontrol1.Text = "12";
            }

        }
    }
}
