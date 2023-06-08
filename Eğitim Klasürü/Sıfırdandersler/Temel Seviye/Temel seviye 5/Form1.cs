using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temel_seviye_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Horizontal Scroll Bar:ListBox aracımızadeğerlerin soldan sağa doğru sığması durumunda yatay kaydırma katif hale getirmek için kullanılanalandır.

            //Items:Combobox aracı ile çok benzerlik gösteren lisbox aracında da öğelerin eklendiği alandır.Özeliklerin çoğu Combobox aracı ile aynodor.
            //sorted: bunu true yaparsan veriler alfabetik olarak sıralanacak 

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Pıcturebox :resim kutusu anlamına gelir.
            //-background Image:picturebox aracımızın arka planına resim eklnemesi için kullanılan alandır.
            //-background Image Layout:Arka Plana eklenen resmin resim
            //-Tile:Resmi karo şeklide konumlayan alan 
            //-Center:Resmi picturebox aracımızın merkezine konumlar.
            //-Stretch:Resmi olarak sığdıran özellik.
            //-Zoom:Resmi üst ve alt kısmından boşluk bırakıp konumuyla özelik.

            //-picturebox aracımızın sağ üste köşesinde bulunan ikona tıkladığımız zaman karşımıza 3 tane ayar gelir.Choose Image kısmı resim seç anlamına geliyor.
            //Size Mode Resmimizin boyut modunu,Dock In Parent Container ise içeriğin kapla anlamına gelir.



        }
    }
}
