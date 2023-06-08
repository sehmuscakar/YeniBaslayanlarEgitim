using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Birbiriyleaynı türden olan veri topluluklarına dizi denir.renkler,sayılar bir sınıfta bulunan öğrenciler,hayvanlar,şehirler,kuşlar hepsi birer dizidir.
       

        //dizilerde sayma işlemi 0'dan başlar

            //Dizi örnekleri;
            //sayı dizisi: 2,3,9200,65,
            //renkler dizisi:kırmızı,siyah,beyaz,gri
        
            //değişken türü [] dizi adı={elemanlar}
        
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////4 tane şehirden birini yazdırın
            //string[] sehirler = { "Adana","Adıyaman","Mersin","Edirne" };
            //label1.Text = sehirler[2];// 2.ci sehir mersindir adana 0 ıncı indextedir çünkü dizilerde bu büyle



            int[] rakamlar = { 1, 2, 3, 5, 6, 9 };
            label1.Text = rakamlar[5].ToString();   
            

            
        
        
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            //6 tane kelimeyi for düngüsüyle listeye ekleyelim
            string[] kelimeler = { "Kapı", "Kolanya", "Kalem", "Kitap", "Telefon", "Bilgisiyar" };
            for(int i=0;i<kelimeler.Length;i++)//kelimeler.Length bu keilmenin uzunluğunu ifade eder  6 tane veri var anlamında
            {
                listBox1.Items.Add(kelimeler[i]);  //burda kelimeler değişkenin i.ci indexlerini ekledik
            }

            */

            //dauble veritüründe değişken tanımyalım, ve listeye ekleylim 
            double[] ondalikli_sayiilar = { 1.23,5.36,9.52,4.78,8.55};
            for (int i = 0; i < ondalikli_sayiilar.Length; i++)
            {
                listBox1.Items.Add(ondalikli_sayiilar[i]);  
            }





        }
    }
}
