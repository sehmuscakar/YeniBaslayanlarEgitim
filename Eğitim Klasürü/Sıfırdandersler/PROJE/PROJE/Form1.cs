using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // bazı şehirlerle ilgili bazı  özelikleri gösteren uygulama yazalım 
      

        private void pcbistanbul_Click(object sender, EventArgs e)
        {
            lblisim.Text = "İstanbul";
            lblbolge.Text = "Marmara";
            lblplaka.Text = "34";
        }

        private void pcbankara_Click(object sender, EventArgs e)
        {
            lblisim.Text = "Ankara";
            lblbolge.Text = "İç Anadolu";
            lblplaka.Text = "06";
        }

        private void pcbbatman_Click(object sender, EventArgs e)
        {
            lblisim.Text = "Batman";
            lblbolge.Text = "Güneydoğu";
            lblplaka.Text = "72";
        }

        private void pcbizmir_Click(object sender, EventArgs e)
        {
            lblisim.Text = "izmir";
            lblbolge.Text = "Ege";
            lblplaka.Text = "35";
        }

        private void pcbmardin_Click(object sender, EventArgs e)
        {
            lblisim.Text = "Mardin";
            lblbolge.Text = "Güneydoğu";
            lblplaka.Text = "47";
        }

        private void pcptrabzon_Click(object sender, EventArgs e)
        {
            lblisim.Text = "Trabzon";
            lblbolge.Text = "Karadeniz";
            lblplaka.Text = "61";
        }

      
    }
}
