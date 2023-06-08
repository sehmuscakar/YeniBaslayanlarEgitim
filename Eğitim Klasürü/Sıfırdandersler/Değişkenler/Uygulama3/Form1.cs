using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt16(textBox1.Text);//burda textbox içinde girilern değer başta string türünde olduğu için 
            label1.Text=sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Klavyeden bir kenarı girilen dikdörtgende alan ve çevre hesabı yapalım.

            int kenar, alan, cevre;
            kenar = Convert.ToInt16(textBox2.Text);
            alan = kenar * kenar;
            cevre = kenar * 4;
            label4.Text=alan.ToString();
            label5.Text=cevre.ToString();
        }
    }
}
