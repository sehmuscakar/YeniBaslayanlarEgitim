using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_Alanı_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // rastgele  3 sayi oluşturup ve   toplamı bulan prg yazınız.

            Random r = new Random();
            int toplam;
            int sayi1 = r.Next(0, 20);
            int sayi2 = r.Next(0, 20);
            int sayi3 = r.Next(0, 20);
            textBox1.Text = sayi1.ToString();
            textBox2.Text = sayi2.ToString();
            textBox3.Text = sayi3.ToString();
            toplam = sayi1 + sayi2 + sayi3;
            textBox4.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //harfler dizisi içinde bulunan harfler içierisinden rastgele seçilen bir hafri label aracına yazdıran prog. kodu yazalım.
            Random rastgele=new Random();
            int deger;
            string[] harfler = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };

      deger=rastgele.Next(0,harfler.Length);//burdan bu aralıktaki index sayıları gelecek deger' e atanacak.
            textBox5.Text = harfler[deger].ToString();  //burdan da ilgili değer textboox'a atanacak.

        
        
        }
    }
}
