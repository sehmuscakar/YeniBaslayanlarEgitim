using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // foreach döngüsü için diziler konusunu bilmemiz lazım 
            //Foreach döngüsü 4 temel paremetre barındıran ve dizilerle beraber kullanılan bir döngüdür.
            // yapı olarak for döngüsne benzeyen yapısı vardır.

            //Foreach Döngüsü paremetreleri 
            // foreach (değişken_türü değişken_adı in dizi_adı)
            //değişken türü:dizimizin değerlerine ulaşabilmek için tanımlanacak değişken türüdür.dizi içinde bulunan değişken türü ne ise foreach döngümüzde kullanacağımız değişken türü de o olmalıdır.

         //   değişken_adı:dizimizin elemanlarını tek tek okuyup bu elemanlara ulaşacak olan değişkenimiz içim verdiğimiz isimdir.

            //In:İngilizcedeki in komuu  türkçeye içinden olarak çevirebilirsiniz.yani ilgili dizinin içinden al/seç anlamı taşımaktadır.ingilizcedeki from kelimesinde olduğu gibi.
            // örnek:in car:araba içinde,in home :ev içinde

            //dizi_adı:elemanlara ulaşmak istediğimiz dizinin ismidir.




        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*

            // 3 elemanlı bir mutfak malzeme listesi oluşturup bu listeyi listboz aracımza yazdıralım.

            string[] malzeme = { "Tencere", "Tava", "Bardak" };
            foreach(string s in malzeme)
            {
                listBox1.Items.Add(s);
            }
       
        */

            // 10 elemanlı bir sayı dizisi oluşturup elemanlarımızı listbox aracımıza yazdıralım
            int[] malzeme = {2,6,-5,1,3,-7};
            foreach (int x in malzeme)
            {
                listBox1.Items.Add(x);
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 5 elemanlı bir dizide bulunan çift sayıları combobox aracına yazdıran kodu yazalım.
            int[] sayilar = { 6,8,24,56,55,45,39,42,743};
            foreach (int x in sayilar)
            {
                if (x % 2 == 0)
                {
                    comboBox1.Items.Add(x);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //3 elemanlı bir ondalıklı sayı dizisinin elemanlı tolamını hesaplayıp mesaj kutusunda gösteren kodu yazalım.
            double toplam = 0;
            double[] sayilar = { 21.01, 60.55, 44.45, 78.99, 71.35 };
            foreach (double x in sayilar)
            {
                toplam = toplam + x;
            }
            MessageBox.Show("Toplam:" + toplam.ToString());//tostring metot olduğu için () yaznına konulur.
        }
    }
}
