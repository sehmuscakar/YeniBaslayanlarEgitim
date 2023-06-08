using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Random yani rastgele sınıfı prrogramlama dünyasında çok önemli bir yere sahiptir.pek çok oyunun alt yapısında bulunan random sınıfı 
            //rastgele tam sayı üreten sınıftır.şeklinde tanımlanabilir. örneğin rastele soru gelen yarişmalarda 
            // Class:sınıf, programlarımızın her bir aşaması için çeşitli durum ve özelliklerin yer aldığı, parçalayarak bir bütün elde etmeyi amaçladığımız bir görev kontrol sistemidir.
       
            
            //Random bir sınıftır ve sınıf tanımlama işleemi şu şekildedir.
            //Sınıf_Adı Nesne_Adı=new Sınıf_Adı();
           // bu nesne ilgili sınıfa ait özeliklere ulaşabilmek için oluşturulan komuttur.



        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //0 ile 50 arasında rastgele sayı getir.
           Random r =new Random();
            int sayi;
            sayi = r.Next(0, 50);
            label2.Text = sayi.ToString();

            //Random; sınıf
            //R ,Nesne
            //Nest:Nitelik/özelik
            //Sayı:değişken
            //label:aracımız


        }

        private void button2_Click(object sender, EventArgs e)
        {
           //5 labela 0 ile 100 arasında sayılar getirsinler 
            Random r =new Random();
            int sayi1,sayi2,sayi3,sayi4,sayi5;
            sayi1= r.Next(0, 100); // 0 ile 100 arasında değerler gelecek
            sayi2 = r.Next(0, 100);
            sayi3 = r.Next(0, 100);
            sayi4 = r.Next(0, 100);
            sayi5 = r.Next(0, 100);
            label3.Text = sayi1.ToString();
            label4.Text = sayi2.ToString();
            label5.Text = sayi3.ToString();
            label6.Text = sayi4.ToString();
            label7.Text = sayi5.ToString();
        }
    }
}
