
namespace Advanced_Project
{
    partial class Admin
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label professionLabel;
            System.Windows.Forms.Label roomLabel;
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.professionTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.change_doctor = new System.Windows.Forms.Button();
            this.delete_doctor = new System.Windows.Forms.Button();
            this.insert_doctor = new System.Windows.Forms.Button();
            this.menu_adm_btn = new System.Windows.Forms.Button();
            this.patient_screen = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            iDLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            professionLabel = new System.Windows.Forms.Label();
            roomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(62, 84);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 17);
            iDLabel.TabIndex = 16;
            iDLabel.Text = "ID:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(38, 114);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(73, 17);
            passwordLabel.TabIndex = 17;
            passwordLabel.Text = "Password:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(62, 152);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 18;
            nameLabel.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(42, 194);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(69, 17);
            surnameLabel.TabIndex = 19;
            surnameLabel.Text = "Surname:";
            // 
            // professionLabel
            // 
            professionLabel.AutoSize = true;
            professionLabel.Location = new System.Drawing.Point(32, 235);
            professionLabel.Name = "professionLabel";
            professionLabel.Size = new System.Drawing.Size(79, 17);
            professionLabel.TabIndex = 20;
            professionLabel.Text = "Profession:";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Location = new System.Drawing.Point(62, 273);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new System.Drawing.Size(49, 17);
            roomLabel.TabIndex = 21;
            roomLabel.Text = "Room:";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(851, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 23);
            this.date.TabIndex = 25;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(664, 24);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 23);
            this.time.TabIndex = 24;
            // 
            // roomTextBox
            // 
            this.roomTextBox.Location = new System.Drawing.Point(117, 270);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(100, 22);
            this.roomTextBox.TabIndex = 22;
            // 
            // professionTextBox
            // 
            this.professionTextBox.Location = new System.Drawing.Point(117, 232);
            this.professionTextBox.Name = "professionTextBox";
            this.professionTextBox.Size = new System.Drawing.Size(100, 22);
            this.professionTextBox.TabIndex = 21;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(117, 191);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.surnameTextBox.TabIndex = 20;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(117, 149);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 19;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(117, 111);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 22);
            this.passwordTextBox.TabIndex = 18;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Location = new System.Drawing.Point(117, 81);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDTextBox.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(362, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(701, 308);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // change_doctor
            // 
            this.change_doctor.Location = new System.Drawing.Point(218, 367);
            this.change_doctor.Name = "change_doctor";
            this.change_doctor.Size = new System.Drawing.Size(75, 23);
            this.change_doctor.TabIndex = 9;
            this.change_doctor.Text = "Change";
            this.change_doctor.UseVisualStyleBackColor = true;
            this.change_doctor.Click += new System.EventHandler(this.change_doctor_Click);
            // 
            // delete_doctor
            // 
            this.delete_doctor.Location = new System.Drawing.Point(117, 367);
            this.delete_doctor.Name = "delete_doctor";
            this.delete_doctor.Size = new System.Drawing.Size(75, 23);
            this.delete_doctor.TabIndex = 8;
            this.delete_doctor.Text = "Delete";
            this.delete_doctor.UseVisualStyleBackColor = true;
            this.delete_doctor.Click += new System.EventHandler(this.delete_doctor_Click);
            // 
            // insert_doctor
            // 
            this.insert_doctor.Location = new System.Drawing.Point(12, 367);
            this.insert_doctor.Name = "insert_doctor";
            this.insert_doctor.Size = new System.Drawing.Size(75, 23);
            this.insert_doctor.TabIndex = 7;
            this.insert_doctor.Text = "Insert";
            this.insert_doctor.UseVisualStyleBackColor = true;
            this.insert_doctor.Click += new System.EventHandler(this.insert_doctor_Click);
            // 
            // menu_adm_btn
            // 
            this.menu_adm_btn.Location = new System.Drawing.Point(1069, 348);
            this.menu_adm_btn.Name = "menu_adm_btn";
            this.menu_adm_btn.Size = new System.Drawing.Size(147, 42);
            this.menu_adm_btn.TabIndex = 2;
            this.menu_adm_btn.Text = "Get Back Menu";
            this.menu_adm_btn.UseVisualStyleBackColor = true;
            this.menu_adm_btn.Click += new System.EventHandler(this.menu_adm_btn_Click);
            // 
            // patient_screen
            // 
            this.patient_screen.Location = new System.Drawing.Point(1069, 283);
            this.patient_screen.Name = "patient_screen";
            this.patient_screen.Size = new System.Drawing.Size(147, 42);
            this.patient_screen.TabIndex = 3;
            this.patient_screen.Text = "Patient Screen";
            this.patient_screen.UseVisualStyleBackColor = true;
            this.patient_screen.Click += new System.EventHandler(this.patient_screen_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 423);
            this.Controls.Add(this.date);
            this.Controls.Add(this.patient_screen);
            this.Controls.Add(this.time);
            this.Controls.Add(this.menu_adm_btn);
            this.Controls.Add(roomLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.roomTextBox);
            this.Controls.Add(this.insert_doctor);
            this.Controls.Add(professionLabel);
            this.Controls.Add(this.delete_doctor);
            this.Controls.Add(this.professionTextBox);
            this.Controls.Add(this.change_doctor);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(passwordLabel);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button menu_adm_btn;
        private System.Windows.Forms.Button delete_doctor;
        private System.Windows.Forms.Button insert_doctor;
        private System.Windows.Forms.Button change_doctor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button patient_screen;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.TextBox professionTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
    }
}