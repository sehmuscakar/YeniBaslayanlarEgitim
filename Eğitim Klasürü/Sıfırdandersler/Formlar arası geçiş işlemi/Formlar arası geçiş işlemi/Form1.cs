using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_arası_geçiş_işlemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm= new Form2();
            frm.Show(); //show:açmak anlamında


            //C#'da projemizde eklenen her form bir sınıftır.eğer bir yerde sınıf varsa o sınıfa ait nitelikleri kullanabilmek için ilgili sınıftan nesne türetmemiz gerekecektir.

        }
    }
}
