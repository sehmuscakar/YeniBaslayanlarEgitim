using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, yas, meslek;// string veri türü ad,soyad,yas,meslek bunlar değişkne örnekleri 
            ad = textBox1.Text;
            soyad = textBox2.Text;
            yas = textBox3.Text;
            meslek= textBox4.Text;
            listBox1.Items.Add(ad+" "+soyad+" "+yas+" "+meslek);
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
