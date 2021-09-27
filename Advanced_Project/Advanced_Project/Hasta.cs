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
    public partial class Hasta : Form
    {
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        
        OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hasta.mdb");
        public Hasta()
        {
            InitializeComponent();
        }

        private void has_bil_MouseDown(object sender, MouseEventArgs e)
        {
            if (has_bil.SelectedTab == doktor_sec)
            {
                has_bil.SelectedIndex = 0;

                has_bil.SelectedTab = tum_bilgiler;
                has_bil.SelectedTab = hasta_bilgisi;
                MessageBox.Show("Action Denied!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

        }

        private void kayıt_hasta_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(patient_id.Text);
            string name = name_pat.Text;
            string surname = surname_pat.Text;
            int age = Convert.ToInt32(numericUpDown1.Value.ToString());
            string blood = blood_type.Text;
            int phone = Convert.ToInt32(phone_number.Text);
            int emer = Convert.ToInt32(call_number.Text);
            
            bool disase = false;
            if (checkBox1.Checked == true)
            {
                disase = true;
            }

            connect.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "insert into Patient(Name,Surname,HadDisase,BloodType,PhoneNumber,EmergancyCall,Age,ID) values('" + name + "','" + surname + "'," + disase + ",'" + blood + "'," + phone + "," + emer + "," + age + "," + id + ");";

            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("You Registered");
            has_bil.SelectedIndex = 1;
        }

        private void ana_ekran_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;

            this.label4.Text = DateTime.Now.ToString();
        }

        private void Hasta_Load(object sender, EventArgs e)
        {
            fill();
            timer1.Start();
        }

        private void fillByProfessionToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void bolum_sec_Click(object sender, EventArgs e)
        {
            string s = "";
            if(goz_radio.Checked == true)
            {
                s = "eyes";
            }
            else if(dahiliye_radio.Checked == true)
            {
                s = "internal";
            }
            else if(dis_radio.Checked == true)
            {
                s = "dentist";
            }
            connect.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "update Patient set DoctorType = '"+s+"'";

            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Changed");
            fill();

        }
        public void fill()
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hasta.mdb");
            da = new OleDbDataAdapter("Select * from Doctor", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "Doctor");
            dataGridView1.DataSource = ds.Tables["Doctor"];
            conn.Close();
        }

        private void goz_radio_CheckedChanged(object sender, EventArgs e)
        {
            if(goz_radio.Checked == true)
            {
                dahiliye_radio.Checked = false;
                dis_radio.Checked = false;
            }
        }

        private void dahiliye_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (dahiliye_radio.Checked == true)
            {
                goz_radio.Checked = false;
                dis_radio.Checked = false;
            }
        }

        private void dis_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (dis_radio.Checked == true)
            {
                dahiliye_radio.Checked = false;
                goz_radio.Checked = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if (s.Equals("dentist"))
            {
                dis_radio.Checked = true;
            }
            if (s.Equals("internal"))
            {
                dahiliye_radio.Checked = true;
            }
            if (s.Equals("eyes"))
            {
                goz_radio.Checked = true;
            }
        }
    }
}
