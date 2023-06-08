using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//While döngüsü şart sağlandığı müddetçe anlamı taşımaktadır.
         //for dan biraz daha farklıdır.

            /*
            //ekrana 24 defa yazılım yazdıran kodu yazalım
            int i = 1;//eğer bu değeri artırmazsan program kilitlenecek ve değer hep 1 olarak kalacak,i değerini artırmamız için ilk değeri olmalıdır
          // i değerini artırmazsan ekleme olmaz 
            while (i<=24)
            {
              
                listBox1.Items.Add("Yazılım");
                i++;
            }
            */

            // 0 dahil 30 a kadar sayıları listeleyen kodu yazın .
            int i=0;
            while (i <= 30)
            {

                listBox1.Items.Add(i);
                i++;
            }


        }
    }
}
