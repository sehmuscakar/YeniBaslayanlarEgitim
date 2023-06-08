using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Döngüler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// döngü nedir ;
         //Belirli şartlar sağlanana kadar ilgili işlemler tekrar içersine alan dögülerin birden fazla türü vardır.Dögülerde amaç belirli şart sağlanana
         //kadar ilgili işlemi tekrar etmektir.
         //C# programlama dilinde  temel döngü vardır. bu döngüler;for,while,do-while,forech döngüleridir 
         // bu kısımda for ve while döngülerini anlatacam.

            //For Döngüsü. çok kullanılır döngü inilizce anlamı loop dur
            //for dögüsünde 3 temel paremetre vardır.
            //for(1;2;3;)
            //1;döngünün başlangıç değerini tutar yani döngü kaçtan başlayacaksa o değerin ataması yapılır.
            //2;döngünün bitiş değerini tutan paremetredir.
            //3;Döngü artış ya da azalış değerinin tutulduğu paremetredir.Arttırma işlemi birer olabileceği gibi farklı değerlerde de olabilir.
            //for döngüsünde paremetreler birbirinden noktalı virgül sembolü ile ayrılır.

            //ekrana 15 defa Mersin yazdıralım
            int i;
            for (i = 1; i <= 15; i++)
            {
                listBox1.Items.Add("mersin");
            }
            /*
             
    
            // 5 ile 22 arasında sayıları listboxa yazdıran kod;
            int i;
            for (i = 5; i <= 22; i++)
            {
                listBox1.Items.Add(i);
            }
            */



            // 3 den 30 kadar 3 er olarak artıralım 
            //int i;
            //for (i = 3; i <= 30; i += 3)
            //{
            //    listBox1.Items.Add(i);
            //}


            //10 ile 120 arsında 11 bölünen sayıları listeleyin
            /*
            int i;
            for (i = 10; i <= 120; i++)
            {
                if (i % 11 == 0)//i sayının 11 ile bölümünde kalan sayı 0 dır. % kalanı bize verir bu işaret
                {
                    listBox1.Items.Add(i);
                }
            }

            */


            // 40 ile 450 arasında 4 ve 12 ye tam bölünen sayıları listele
            /* 
              int i;
              for (i = 40; i <= 450; i++)
              {
                  if (i % 4 == 0 & i % 12 == 0)
                  {
                      listBox1.Items.Add(i);
                  }
              }
            */





        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
