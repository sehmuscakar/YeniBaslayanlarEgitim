using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Klavyeden girilen şehrin Batman olup olmadığını kontrol eden program yazalım.

            if (textBox1.Text == "Batman")// if :eğer 
            {
                MessageBox.Show("Doğru Şehir");
            }
            else //Değilse
            {
                MessageBox.Show("Hatalı Şehir");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Klavyeden girilen sayının 50 olup olmadığını kontrolünü yapalım.

            int sayi = Convert.ToInt16(textBox2.Text);
            if(sayi == 50)
            {
                MessageBox.Show("Doğru Sayı");
            }
            else
            {
                MessageBox.Show("Yanlış Sayı");
            }
        }
    }
}
