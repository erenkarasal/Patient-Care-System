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
    public partial class doktor_giris : Form
    {
        private OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hasta.mdb");
        public doktor_giris()
        {
            InitializeComponent();
            

        }

        private void doktor_giris_btn_Click(object sender, EventArgs e)
        {
            try {
                conn.Open();
                int tc = Convert.ToInt32(doktor_tc.Text);
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select Profession from Doctor where DoctorID = " + tc + " and Pass= '" + doktor_sifre.Text + "'";
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                        string s ="";
                   
                        s = dr[0].ToString();
                       
                    

                    Doktor doktor = new Doktor(s);
                    doktor.ShowDialog();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Id or password is incorrect ");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("There is a problem with"+ex);
                
            }
            


        }

        private void doktor_giris_Load(object sender, EventArgs e)
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

        private void doktor_tc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
