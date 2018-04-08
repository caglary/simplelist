using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciftciler
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void btn_giris_Click(object sender, EventArgs e)
        {
            string user=textBox1.Text ;
            string password=textBox2.Text ;
            if (user == "demo" && password=="demo")
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
           

        }
    }
}
