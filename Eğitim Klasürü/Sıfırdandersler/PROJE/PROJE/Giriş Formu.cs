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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        private void frmgiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // programın çalıştığında ilk önce bu formu açması için program.cs kısmında 
            //  Application.Run(new frmgiris()); burdan ılk açılacağı forumun name ismini yazman lazım.
            //şifreyi textboxın özeliklerinden UseSystemPasswordchar kısmını True yapman lazım ,şifre gözükmesin 
            if (textBox1.Text=="şehmus" & textBox2.Text == "72")
            {
                Form1 fr=new Form1();
                fr.Show();
                this.Hide();// eğer diğer form açılırsa kod doğru çalışırsa bu formu gizleyecektir. 
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız");
            }
            
        }
    }
}
