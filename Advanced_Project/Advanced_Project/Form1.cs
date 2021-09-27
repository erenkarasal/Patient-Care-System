using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Advanced_Project
{
    public partial class Form1 : Form
    {
       OleDbConnection connect = new OleDbConnection();
        public Form1()
        {

            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hasta.mdb";

        }
     

        private void giris_Click(object sender, EventArgs e)
        {

            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;

            if (tc_no.Text.Equals("admin"))
            {
                admin_giris admin_Giris = new admin_giris();
                admin_Giris.ShowDialog();
            }
            else
            {
                int id = Convert.ToInt32(tc_no.Text);
                connect.Open();
                command.CommandText = "select Pass from Doctor where DoctorID=" + id;
                OleDbDataReader reader = command.ExecuteReader(); //bulamazsa

                while (reader.Read())
                {



                    doktor_giris doktor_Giris = new doktor_giris();
                    doktor_Giris.ShowDialog();
                    connect.Close();
                    break;

                }
                connect.Close();
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();        
        }


        private void button1_Click(object sender, EventArgs e)
        {
         

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
           
           this.label3.Text = DateTime.Now.ToShortDateString();
            this.label4.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void hastagirisi_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris.Visible = true;
            tc_no.Visible = true;
            label1.Visible = true;
            button3.Visible = true;
            button2.Visible = false;
            button1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            giris.Visible = false;
            tc_no.Visible = false;
            label1.Visible = false;
            button3.Visible = false;
            button2.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.ShowDialog();
        }
    }
}
