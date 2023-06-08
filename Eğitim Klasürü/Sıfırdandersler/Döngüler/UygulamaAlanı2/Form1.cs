using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UygulamaAlanı2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //40 ile 450 arasında 4 ile 12 tam bölünen sayıları listeleyin
            int i;
            for (i = 40; i <= 450; i++)
            {
                if (i%4 == 0 & i % 12 == 0)
                    
             {
                listBox1.Items.Add(i);
            }
        }
    }
    }
}
