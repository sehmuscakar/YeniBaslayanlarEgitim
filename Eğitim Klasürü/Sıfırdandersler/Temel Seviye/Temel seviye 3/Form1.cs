using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temel_seviye_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // textbox aracı:değerlerimiz sadece kod kısmında değil dışarıdan da girmemiz gereken noktalar olacak örneğin;bir web sitesine kaydolurken ad,soyad,yaş,mail bilgileri dişardan girmen gerekli olabilir
            
            //textbox aracımızın bazı özelikleri 
            
            //- Character Casing: girilen harflerin büyük mü yoksa küçük mü olduğunu belirler.eğer Upper seçilirse tüm hafler büyük olur küçükte yazan yüyük olur
              //Lower;seçilirse tüm harfleri küçük olarak karşımıza gelir.
/* 
  
            Fore Color:yazı renginin belirlendiği alandır.
Max Length:TextBox aracımıza girilebilcecek maksimum karekter sayısının belirlendiği alandır.

            Multiline:Çok lu satır seceneğinin aktif hale getirileceği alandır.TextBox varsayılan olarak sadece tek satır üzerinden veri girişi yapılan bir araçtır.ancak multiline özeliği aktif olursa alt satırada veri girşi yapılabilir.

            Password Char:TextBox'ımıza girilen değerleri şifre karekteri şeklinde gösterir.
Use System Password Char:textbox'ımıza girdiğimiz değerleri * sembolü şeklinde göstererek kutucuğumuzu şifrelemiş olur.

           
 
 */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;// + toplama anlamına değil birleştirme operatörü olarak kullanılır 
           //string lerdeki boşlukta boşluk içi kullanılır .
            // ilerde operatürler konusuna gelecez , 
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = textBox4.Text + "-" + textBox5.Text;
        }
    }
}
