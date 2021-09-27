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
    public partial class adminPatientScreen : Form
    {
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hasta.mdb");
        public adminPatientScreen()
        {
            InitializeComponent();
        }

        private void adminPatientScreen_Load(object sender, EventArgs e)
        {
            fill();
           
            timer1.Start();
        }
        public void fill()
        {

            da = new OleDbDataAdapter("Select * from Patient", connect);
            ds = new DataSet();
            connect.Open();
            da.Fill(ds, "Patient");
            dataGridView2.DataSource = ds.Tables["Patient"];
            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Close();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime datetime = DateTime.Now;

            this.label1.Text = DateTime.Now.ToString();
            
        }

        private void add_pati_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(patient_id.Text);
            string name = textBox1.Text;
            string surname = textBox2.Text;
            int age = Convert.ToInt32(numericUpDown1.Value.ToString());
            string blood = textBox5.Text;
            int phone = Convert.ToInt32(textBox6.Text);
            int emer = Convert.ToInt32(textBox7.Text);
            string type = textBox3.Text;
            bool disase = false;
            if (checkBox1.Checked == true)
            {
                disase = true;
            }
           
            connect.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "insert into Patient(Name,Surname,HadDisase,BloodType,PhoneNumber,EmergancyCall,Age,ID,DoctorType) values('" + name + "','" + surname + "'," + disase + ",'" + blood + "'," + phone + ","+ emer +","+age+","+id+",'"+type+"');";

            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Patient Added");
            fill();
        }

        private void delete_pati_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(patient_id.Text);
            connect.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "Delete from Patient Where ID="+id;

            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Patient Deleted");
            fill();
        }

        private void change_pati_Click(object sender, EventArgs e)
        {
            connect.Open();
            int id = Convert.ToInt32(patient_id.Text);
            string name = textBox1.Text;
            string surname = textBox2.Text;
            int age = Convert.ToInt32(numericUpDown1.Value.ToString());
            string blood = textBox5.Text;
            int phone = Convert.ToInt32(textBox6.Text);
            int emer = Convert.ToInt32(textBox7.Text);
            string type = textBox3.Text;
            bool disase = false;
            if (checkBox1.Checked == true)
            {
                disase = true;
            }
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "update Patient set Name ='" + name + "', Surname ='" + surname + "', HadDisase = " + disase + ", BloodType = '" + blood + "', PhoneNumber=" + phone + ", EmergancyCall="+emer+ " DoctorType = '"+type+"' where ID=" + id;

            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Changed");
            fill();
        }
    }
}
