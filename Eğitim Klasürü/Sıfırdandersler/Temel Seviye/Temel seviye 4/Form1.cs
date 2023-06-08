using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temel_seviye_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Combobox aracı:bazen değerleri olarak yazmak yerine kullanıcıya seçtirmek isteyebiliriz.
            //örneğin bir şehri elle girmek yerine bir liste içerisinden kullanıcı kendisi seçebilir ,nu durumda çoklu seçim kutusu olan combo box kullanırız.

            //-Data Source:aracımızı herhangi bir veritabanına bağlamak için kullanırız 
            //-Drop Down Style:Combobox aracımızın biçimini deiğiştirir.
            //-İtems:öğelerimizin girişinin yapıldığı alandır.
            //-Max Drop Down Items:Combobox aracımıza elemanlar ekleyip çalıştırdıktan sonra sağ tarafında bulunan açılış ikonuna tıklayınca karşımıza gelecek olan eleman 
            //sayısının belirlendiği alandır.
            //-Sorted:Elemanlarımızı küçükten büğüğe doğru sıralamak için kullanılır.
            //-aracın sağ tarafındaki işarete tıklayarak edit ıtems yaparak verileri girebilirsin o kısım string collection Editor olarak adlandırılır.
            //collection:kolaksiyon
            //verileri girekekn önemli bir durum var parantez içinde One per line isiminde  bir ifade var bu her satıra bir ttane değer girmemizi söyler.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Batman");
        }
    }
}
