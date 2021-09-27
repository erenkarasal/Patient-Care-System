
namespace Advanced_Project
{
    partial class Hasta
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
            this.has_bil = new System.Windows.Forms.TabControl();
            this.hasta_bilgisi = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.patient_id = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ana_ekran = new System.Windows.Forms.Button();
            this.kayıt_hasta = new System.Windows.Forms.Button();
            this.call_number = new System.Windows.Forms.TextBox();
            this.phone_number = new System.Windows.Forms.TextBox();
            this.blood_type = new System.Windows.Forms.TextBox();
            this.surname_pat = new System.Windows.Forms.TextBox();
            this.name_pat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.doktor_sec = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolum_sec = new System.Windows.Forms.Button();
            this.dis_radio = new System.Windows.Forms.RadioButton();
            this.dahiliye_radio = new System.Windows.Forms.RadioButton();
            this.goz_radio = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tum_bilgiler = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.has_bil.SuspendLayout();
            this.hasta_bilgisi.SuspendLayout();
            this.doktor_sec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tum_bilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // has_bil
            // 
            this.has_bil.Controls.Add(this.hasta_bilgisi);
            this.has_bil.Controls.Add(this.doktor_sec);
            this.has_bil.Controls.Add(this.tum_bilgiler);
            this.has_bil.Location = new System.Drawing.Point(0, 2);
            this.has_bil.Name = "has_bil";
            this.has_bil.SelectedIndex = 0;
            this.has_bil.Size = new System.Drawing.Size(968, 505);
            this.has_bil.TabIndex = 0;
            this.has_bil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.has_bil_MouseDown);
            // 
            // hasta_bilgisi
            // 
            this.hasta_bilgisi.Controls.Add(this.numericUpDown1);
            this.hasta_bilgisi.Controls.Add(this.checkBox1);
            this.hasta_bilgisi.Controls.Add(this.label18);
            this.hasta_bilgisi.Controls.Add(this.patient_id);
            this.hasta_bilgisi.Controls.Add(this.label14);
            this.hasta_bilgisi.Controls.Add(this.ana_ekran);
            this.hasta_bilgisi.Controls.Add(this.kayıt_hasta);
            this.hasta_bilgisi.Controls.Add(this.call_number);
            this.hasta_bilgisi.Controls.Add(this.phone_number);
            this.hasta_bilgisi.Controls.Add(this.blood_type);
            this.hasta_bilgisi.Controls.Add(this.surname_pat);
            this.hasta_bilgisi.Controls.Add(this.name_pat);
            this.hasta_bilgisi.Controls.Add(this.label13);
            this.hasta_bilgisi.Controls.Add(this.label12);
            this.hasta_bilgisi.Controls.Add(this.label11);
            this.hasta_bilgisi.Controls.Add(this.label10);
            this.hasta_bilgisi.Controls.Add(this.label2);
            this.hasta_bilgisi.Controls.Add(this.label4);
            this.hasta_bilgisi.Controls.Add(this.label6);
            this.hasta_bilgisi.Location = new System.Drawing.Point(4, 25);
            this.hasta_bilgisi.Name = "hasta_bilgisi";
            this.hasta_bilgisi.Padding = new System.Windows.Forms.Padding(3);
            this.hasta_bilgisi.Size = new System.Drawing.Size(960, 476);
            this.hasta_bilgisi.TabIndex = 0;
            this.hasta_bilgisi.Text = "Patient Register";
            this.hasta_bilgisi.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(386, -1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(210, 58);
            this.label18.TabIndex = 51;
            this.label18.Text = "\"_\" \'s are REQUIERED ";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patient_id
            // 
            this.patient_id.Location = new System.Drawing.Point(227, 99);
            this.patient_id.Name = "patient_id";
            this.patient_id.Size = new System.Drawing.Size(100, 22);
            this.patient_id.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(22, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 48;
            this.label14.Text = "&PatientID";
            // 
            // ana_ekran
            // 
            this.ana_ekran.Location = new System.Drawing.Point(193, 408);
            this.ana_ekran.Name = "ana_ekran";
            this.ana_ekran.Size = new System.Drawing.Size(180, 33);
            this.ana_ekran.TabIndex = 26;
            this.ana_ekran.Text = "Back to main menu";
            this.ana_ekran.UseVisualStyleBackColor = true;
            this.ana_ekran.Click += new System.EventHandler(this.ana_ekran_Click);
            // 
            // kayıt_hasta
            // 
            this.kayıt_hasta.Location = new System.Drawing.Point(399, 408);
            this.kayıt_hasta.Name = "kayıt_hasta";
            this.kayıt_hasta.Size = new System.Drawing.Size(75, 33);
            this.kayıt_hasta.TabIndex = 25;
            this.kayıt_hasta.Text = "Register";
            this.kayıt_hasta.UseVisualStyleBackColor = true;
            this.kayıt_hasta.Click += new System.EventHandler(this.kayıt_hasta_Click);
            // 
            // call_number
            // 
            this.call_number.Location = new System.Drawing.Point(227, 334);
            this.call_number.Name = "call_number";
            this.call_number.Size = new System.Drawing.Size(100, 22);
            this.call_number.TabIndex = 20;
            // 
            // phone_number
            // 
            this.phone_number.Location = new System.Drawing.Point(227, 281);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(100, 22);
            this.phone_number.TabIndex = 19;
            // 
            // blood_type
            // 
            this.blood_type.Location = new System.Drawing.Point(227, 237);
            this.blood_type.Name = "blood_type";
            this.blood_type.Size = new System.Drawing.Size(100, 22);
            this.blood_type.TabIndex = 18;
            // 
            // surname_pat
            // 
            this.surname_pat.Location = new System.Drawing.Point(227, 60);
            this.surname_pat.Name = "surname_pat";
            this.surname_pat.Size = new System.Drawing.Size(100, 22);
            this.surname_pat.TabIndex = 15;
            // 
            // name_pat
            // 
            this.name_pat.Location = new System.Drawing.Point(227, 20);
            this.name_pat.Name = "name_pat";
            this.name_pat.Size = new System.Drawing.Size(100, 22);
            this.name_pat.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(19, 370);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 27);
            this.label13.TabIndex = 12;
            this.label13.Text = "&Age";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(19, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 40);
            this.label12.TabIndex = 11;
            this.label12.Text = "&Relative name to be reached in an emergency";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(19, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "&Phone nunber";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(19, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "&Soyisminiz";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "&Blood group";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(690, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 23);
            this.label4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "&Name";
            // 
            // doktor_sec
            // 
            this.doktor_sec.AutoScroll = true;
            this.doktor_sec.Controls.Add(this.dataGridView1);
            this.doktor_sec.Controls.Add(this.bolum_sec);
            this.doktor_sec.Controls.Add(this.dis_radio);
            this.doktor_sec.Controls.Add(this.dahiliye_radio);
            this.doktor_sec.Controls.Add(this.goz_radio);
            this.doktor_sec.Controls.Add(this.label17);
            this.doktor_sec.Controls.Add(this.label16);
            this.doktor_sec.Controls.Add(this.label3);
            this.doktor_sec.Controls.Add(this.label1);
            this.doktor_sec.Location = new System.Drawing.Point(4, 25);
            this.doktor_sec.Name = "doktor_sec";
            this.doktor_sec.Padding = new System.Windows.Forms.Padding(3);
            this.doktor_sec.Size = new System.Drawing.Size(960, 476);
            this.doktor_sec.TabIndex = 1;
            this.doktor_sec.Text = "Take Doctor";
            this.doktor_sec.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 238);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolum_sec
            // 
            this.bolum_sec.Location = new System.Drawing.Point(225, 153);
            this.bolum_sec.Name = "bolum_sec";
            this.bolum_sec.Size = new System.Drawing.Size(254, 23);
            this.bolum_sec.TabIndex = 15;
            this.bolum_sec.Text = "Take Department and Doctor";
            this.bolum_sec.UseVisualStyleBackColor = true;
            this.bolum_sec.Click += new System.EventHandler(this.bolum_sec_Click);
            // 
            // dis_radio
            // 
            this.dis_radio.AutoSize = true;
            this.dis_radio.Location = new System.Drawing.Point(121, 123);
            this.dis_radio.Name = "dis_radio";
            this.dis_radio.Size = new System.Drawing.Size(17, 16);
            this.dis_radio.TabIndex = 13;
            this.dis_radio.TabStop = true;
            this.dis_radio.UseVisualStyleBackColor = true;
            this.dis_radio.CheckedChanged += new System.EventHandler(this.dis_radio_CheckedChanged);
            // 
            // dahiliye_radio
            // 
            this.dahiliye_radio.AutoSize = true;
            this.dahiliye_radio.Location = new System.Drawing.Point(121, 87);
            this.dahiliye_radio.Name = "dahiliye_radio";
            this.dahiliye_radio.Size = new System.Drawing.Size(17, 16);
            this.dahiliye_radio.TabIndex = 12;
            this.dahiliye_radio.TabStop = true;
            this.dahiliye_radio.UseVisualStyleBackColor = true;
            this.dahiliye_radio.CheckedChanged += new System.EventHandler(this.dahiliye_radio_CheckedChanged);
            // 
            // goz_radio
            // 
            this.goz_radio.AutoSize = true;
            this.goz_radio.Location = new System.Drawing.Point(121, 52);
            this.goz_radio.Name = "goz_radio";
            this.goz_radio.Size = new System.Drawing.Size(17, 16);
            this.goz_radio.TabIndex = 11;
            this.goz_radio.TabStop = true;
            this.goz_radio.UseVisualStyleBackColor = true;
            this.goz_radio.CheckedChanged += new System.EventHandler(this.goz_radio_CheckedChanged);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(40, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 23);
            this.label17.TabIndex = 9;
            this.label17.Text = "Internal medicine";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(40, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 23);
            this.label16.TabIndex = 8;
            this.label16.Text = "Dentist";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(40, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eyes";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which department do you want";
            // 
            // tum_bilgiler
            // 
            this.tum_bilgiler.Controls.Add(this.label22);
            this.tum_bilgiler.Controls.Add(this.label21);
            this.tum_bilgiler.Controls.Add(this.label20);
            this.tum_bilgiler.Controls.Add(this.label19);
            this.tum_bilgiler.Controls.Add(this.label15);
            this.tum_bilgiler.Controls.Add(this.label8);
            this.tum_bilgiler.Controls.Add(this.label7);
            this.tum_bilgiler.Controls.Add(this.label5);
            this.tum_bilgiler.Location = new System.Drawing.Point(4, 25);
            this.tum_bilgiler.Name = "tum_bilgiler";
            this.tum_bilgiler.Padding = new System.Windows.Forms.Padding(3);
            this.tum_bilgiler.Size = new System.Drawing.Size(960, 476);
            this.tum_bilgiler.TabIndex = 2;
            this.tum_bilgiler.Text = "Information";
            this.tum_bilgiler.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(89, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "label15";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(89, 225);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 17);
            this.label19.TabIndex = 4;
            this.label19.Text = "label19";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(89, 271);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 17);
            this.label20.TabIndex = 5;
            this.label20.Text = "label20";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(89, 317);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 17);
            this.label21.TabIndex = 6;
            this.label21.Text = "label21";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(89, 367);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 17);
            this.label22.TabIndex = 7;
            this.label22.Text = "label22";
            // 
            // checkBox1
            // 
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(25, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(302, 24);
            this.checkBox1.TabIndex = 52;
            this.checkBox1.Text = "Disease you have had  before?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(227, 370);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 53;
            // 
            // Hasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 507);
            this.Controls.Add(this.has_bil);
            this.Name = "Hasta";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Hasta_Load);
            this.has_bil.ResumeLayout(false);
            this.hasta_bilgisi.ResumeLayout(false);
            this.hasta_bilgisi.PerformLayout();
            this.doktor_sec.ResumeLayout(false);
            this.doktor_sec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tum_bilgiler.ResumeLayout(false);
            this.tum_bilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl has_bil;
        private System.Windows.Forms.TabPage hasta_bilgisi;
        private System.Windows.Forms.TabPage doktor_sec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tum_bilgiler;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton dis_radio;
        private System.Windows.Forms.RadioButton dahiliye_radio;
        private System.Windows.Forms.RadioButton goz_radio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox call_number;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.TextBox blood_type;
        private System.Windows.Forms.TextBox surname_pat;
        private System.Windows.Forms.TextBox name_pat;
        private System.Windows.Forms.Button kayıt_hasta;
        private System.Windows.Forms.Button bolum_sec;
        private System.Windows.Forms.Button ana_ekran;
        private System.Windows.Forms.TextBox patient_id;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}