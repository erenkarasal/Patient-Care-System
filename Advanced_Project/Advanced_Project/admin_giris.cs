using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Advanced_Project
{
    public partial class admin_giris : Form
    {
   

        public admin_giris()
        {
            InitializeComponent();
           

        }

        private void admin_giris_btn_Click(object sender, EventArgs e)
        {
            if (admin_tc.Text.Equals("eren") && admin_sifre.Text.Equals("şifre"))
            {
                Admin admin = new Admin();
                admin.ShowDialog();
            }
        }

        private void admin_giris_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime datetime = DateTime.Now;

            this.label3.Text = DateTime.Now.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
