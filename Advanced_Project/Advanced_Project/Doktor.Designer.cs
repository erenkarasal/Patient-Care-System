
namespace Advanced_Project
{
    partial class Doktor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu_dkt_button = new System.Windows.Forms.Button();
            this.recete = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.medicine = new System.Windows.Forms.Label();
            this.onay_ekranı = new System.Windows.Forms.TabPage();
            this.hasta_sec = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.disase = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.recete.SuspendLayout();
            this.onay_ekranı.SuspendLayout();
            this.hasta_sec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_dkt_button
            // 
            this.menu_dkt_button.Location = new System.Drawing.Point(919, 578);
            this.menu_dkt_button.Name = "menu_dkt_button";
            this.menu_dkt_button.Size = new System.Drawing.Size(174, 32);
            this.menu_dkt_button.TabIndex = 4;
            this.menu_dkt_button.Text = "Back to Main Menu";
            this.menu_dkt_button.UseVisualStyleBackColor = true;
            this.menu_dkt_button.Click += new System.EventHandler(this.menu_dkt_button_Click);
            // 
            // recete
            // 
            this.recete.Controls.Add(this.button2);
            this.recete.Controls.Add(this.button1);
            this.recete.Controls.Add(this.medicine);
            this.recete.Location = new System.Drawing.Point(4, 25);
            this.recete.Name = "recete";
            this.recete.Padding = new System.Windows.Forms.Padding(3);
            this.recete.Size = new System.Drawing.Size(926, 511);
            this.recete.TabIndex = 3;
            this.recete.Text = "Medicine";
            this.recete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Medicine Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // medicine
            // 
            this.medicine.Location = new System.Drawing.Point(185, 117);
            this.medicine.Name = "medicine";
            this.medicine.Size = new System.Drawing.Size(205, 49);
            this.medicine.TabIndex = 0;
            // 
            // onay_ekranı
            // 
            this.onay_ekranı.Controls.Add(this.button3);
            this.onay_ekranı.Controls.Add(this.disase);
            this.onay_ekranı.Controls.Add(this.textBox8);
            this.onay_ekranı.Controls.Add(this.label9);
            this.onay_ekranı.Controls.Add(this.label8);
            this.onay_ekranı.Controls.Add(this.label7);
            this.onay_ekranı.Controls.Add(this.label6);
            this.onay_ekranı.Controls.Add(this.label5);
            this.onay_ekranı.Controls.Add(this.label4);
            this.onay_ekranı.Controls.Add(this.label3);
            this.onay_ekranı.Controls.Add(this.label2);
            this.onay_ekranı.Controls.Add(this.textBox7);
            this.onay_ekranı.Controls.Add(this.textBox6);
            this.onay_ekranı.Controls.Add(this.textBox4);
            this.onay_ekranı.Controls.Add(this.textBox3);
            this.onay_ekranı.Controls.Add(this.textBox2);
            this.onay_ekranı.Controls.Add(this.textBox1);
            this.onay_ekranı.Location = new System.Drawing.Point(4, 25);
            this.onay_ekranı.Name = "onay_ekranı";
            this.onay_ekranı.Padding = new System.Windows.Forms.Padding(3);
            this.onay_ekranı.Size = new System.Drawing.Size(926, 511);
            this.onay_ekranı.TabIndex = 2;
            this.onay_ekranı.Text = "Confirm Screen";
            this.onay_ekranı.UseVisualStyleBackColor = true;
            // 
            // hasta_sec
            // 
            this.hasta_sec.Controls.Add(this.dataGridView1);
            this.hasta_sec.Location = new System.Drawing.Point(4, 25);
            this.hasta_sec.Name = "hasta_sec";
            this.hasta_sec.Padding = new System.Windows.Forms.Padding(3);
            this.hasta_sec.Size = new System.Drawing.Size(926, 511);
            this.hasta_sec.TabIndex = 0;
            this.hasta_sec.Text = "Patient Select";
            this.hasta_sec.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(889, 460);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.hasta_sec);
            this.tabControl1.Controls.Add(this.onay_ekranı);
            this.tabControl1.Controls.Add(this.recete);
            this.tabControl1.Location = new System.Drawing.Point(32, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 540);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(314, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(314, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(314, 282);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(314, 329);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "BloodType";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Had Disase Before)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Emergency Call Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Age";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(314, 377);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 15;
            // 
            // disase
            // 
            this.disase.AutoSize = true;
            this.disase.Location = new System.Drawing.Point(316, 234);
            this.disase.Name = "disase";
            this.disase.Size = new System.Drawing.Size(18, 17);
            this.disase.TabIndex = 16;
            this.disase.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(567, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 107);
            this.button3.TabIndex = 17;
            this.button3.Text = "Confirm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 694);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu_dkt_button);
            this.Controls.Add(this.tabControl1);
            this.Name = "Doktor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doktor_Load);
            this.recete.ResumeLayout(false);
            this.onay_ekranı.ResumeLayout(false);
            this.onay_ekranı.PerformLayout();
            this.hasta_sec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button menu_dkt_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicationsYouUseRegularlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialİnsuranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage recete;
        private System.Windows.Forms.TabPage onay_ekranı;
        private System.Windows.Forms.TabPage hasta_sec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label medicine;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox disase;
        private System.Windows.Forms.Button button3;
    }
}