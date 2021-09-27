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

namespace Advanced_Project
{
    public partial class Doktor : Form
    {
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hasta.mdb");
        string s;
        public Doktor(string s)
        {
            InitializeComponent();
            this.s = s;
        }
        public void fill()
        {

            da = new OleDbDataAdapter("Select * from Patient where DoctorType = '"+s+"'", connect);
            ds = new DataSet();
            connect.Open();
            da.Fill(ds, "Patient");
            dataGridView1.DataSource = ds.Tables["Patient"];
            connect.Close();
        }

        private void menu_dkt_button_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void Doktor_Load(object sender, EventArgs e)
        {
            timer1.Start();
            fill();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime datetime = DateTime.Now;

            this.label1.Text = DateTime.Now.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();
                long number = rand.Next(10000, 99999);



                MessageBox.Show("Medicine code :" + number);
                int id = Convert.ToInt32(textBox1.Text);
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                command.CommandText = "Delete from Patient Where ID=" + id;

                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Patient Deleted");
                fill();
                tabControl1.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Here is a problem with" + ex);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

         
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "true") disase.Checked = true;
            else disase.Checked = false;
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tabControl1.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
    }
}
