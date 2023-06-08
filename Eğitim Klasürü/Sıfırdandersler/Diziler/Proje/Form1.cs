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
            // dizimizden seçtiğimiz arabaya göre o araba ile ilgili görsel bize verecek 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] araba = { "Toyota", "Ford", "BMW", "Volvo", "Fiat" };
            for(int i=0;i<araba.Length;i++)  // 5 tane değer var i 5 ten küçük olacak anlamına geliyor 
            {
                // listBox1.Items.Add(i); //dizilerde sayma 0 . cı index ten başlar 
                listBox1.Items.Add(araba[i]);
            }

            //ayarlar events:olaylar kısmında bulunur burda pek çok olay bulunmaktadır ,listbox ın selected Index Changed olayına çift tıkladığımızda ilgili kodu yazdığımızda 
            //arabaya tıklandığında ismi labela yadırılacak 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label1.Text= listBox1.SelectedIndex.ToString();//index numarasını labela atadık
            label1.Text = listBox1.SelectedItem.ToString(); //öğeleri labela atadık

            if(label1.Text== "Toyota")
            {
                pictureBox1.ImageLocation = @"C:\Users\Şehmus\Desktop\Eğitimler\Eğitimler resim\exterior-4.png"; //burda resmin bulunduğu yolu verdik
            }
            if (label1.Text == "Ford")
            {
                pictureBox1.ImageLocation = @"C:\Users\Şehmus\Desktop\Eğitimler\Eğitimler resim\indir (8).jpg"; // bu yolu ilgili resmin özelikler kısmındaki güvenlik alanındaki nesne adı vereceksin yani yolu
            }

            if (label1.Text == "BMW")
            {
                pictureBox1.ImageLocation = @"C:\Users\Şehmus\Desktop\Eğitimler\Eğitimler resim\indir (9).jpg"; 
            }
            if (label1.Text == "Volvo")
            {
                pictureBox1.ImageLocation = @"C:\Users\Şehmus\Desktop\Eğitimler\Eğitimler resim\indir (10).jpg";
            }
            if (label1.Text == "Fiat")
            {
                pictureBox1.ImageLocation = @"C:\Users\Şehmus\Desktop\Eğitimler\Eğitimler resim\indir (11).jpg";
            }
            //resim dosyaveya benzeri adres yapılarında adres bilgisini olduğu gibi almak için başına  @ et sembolü kullanılır.bunun yerine tek \ olan yerlere bir 
            //tane daha slash \\ sembolü eklenerek işlem yapılabilir.
        }
    }
}
