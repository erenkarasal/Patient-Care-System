using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Advanced_Project
{
    public partial class Admin : Form
    {
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hasta.mdb");
        public Admin()
        {
            InitializeComponent();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void menu_adm_btn_Click(object sender, EventArgs e)
        {
           
            this.Close();
           
        }

        private void doktor_list_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
       
            timer1.Start();

            fill();
            
            
           
               
            

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void fillByDoctorIDToolStripButton_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void patient_screen_Click(object sender, EventArgs e)
        {
            adminPatientScreen admptnsc = new adminPatientScreen();
            admptnsc.ShowDialog();
            
        }
        public void fill()
        {
            
            da = new OleDbDataAdapter("Select * from Doctor", connect);
            ds = new DataSet();
            connect.Open();
            da.Fill(ds, "Doctor");
            dataGridView1.DataSource = ds.Tables["Doctor"];
            connect.Close();
        }

        private void insert_doctor_Click(object sender, EventArgs e)
        {
            connect.Open();
            
            int room = Convert.ToInt32(roomTextBox.Text);
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string prof = professionTextBox.Text;
            string pass = passwordTextBox.Text;
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "insert into Doctor(Name,Surname,Profession,Room,Pass) values('"+name + "','" + surname + "','" + prof + "'," + room + ",'" + pass + "');";
        
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Doctor Added");
            fill();
        }

        private void inserted_doctor_Click(object sender, EventArgs e)
        {

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime datetime = DateTime.Now;

            this.date.Text = DateTime.Now.ToShortDateString();
            this.time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void change_doctor_Click(object sender, EventArgs e)
        {
            connect.Open();
            int id = Convert.ToInt32(iDTextBox.Text);
            int room = Convert.ToInt32(roomTextBox.Text);
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string prof = professionTextBox.Text;
            string pass = passwordTextBox.Text;
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "update Doctor set Name ='"+name+"', Surname ='"+surname+"', profession = '"+prof+"', room = "+room+", Pass='"+pass+"' where DoctorID="+id;

            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Changed");
            fill();
        }

        private void delete_doctor_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(iDTextBox.Text); ;
            connect.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "delete from Doctor where DoctorID = "+id;

            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("ID Deleted");
            fill();
        }
    }
}
