using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UygulamaAlanı3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //Klavyeden girilen kullanıcı adı "sehmus" şifre" 5050" olan ekrana Hoşgeldiniz buyrun  yazan aksi durumda hatalı giriş yaptınız yazdırıan koduu yaz.
            // & ve operatürü; her iki taraf ta doğru olamlı
            //== eşit mi 
            if (textBox1.Text == "sehmus" & textBox2.Text == "5050")
            {
                MessageBox.Show("Hoşgeldiniz buyrun");
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        
        }
    }
}
