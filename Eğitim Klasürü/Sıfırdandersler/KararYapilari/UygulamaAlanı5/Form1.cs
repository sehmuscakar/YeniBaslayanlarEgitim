using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UygulamaAlanı5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //trafik lambası similasyonu yapalım
            //0,20 arasında kırmızı
            //20,30 arasında sarı
            //30,50 arasında yeşil

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //panel:Nesneleri guruplamak için kullanılır. groupbox’tan farkı kaydırma çubukları eklenmesidir.
            // sayac++;
            sayac += 1; // böylede sayacı 1 artırız
            label2.Text = sayac.ToString();
            if(sayac>=0 & sayac <= 20)
            {
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Transparent;//şefaf yani ana rengine dönecektir.
                panel3.BackColor = Color.Transparent;
            }

            if (sayac >= 21 & sayac <= 30)
            {
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Yellow;//şefaf yani ana rengine dönecektir.
                panel3.BackColor = Color.Transparent;
            }
            if (sayac >= 31 & sayac <= 50)
            {
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;//şefaf yani ana rengine dönecektir.
                panel3.BackColor = Color.Green;
            }
            if (sayac == 51)
            {
                sayac = 0;
            }
        }

        private void btndur_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }
    }
}
