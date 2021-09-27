
namespace Advanced_Project
{
    partial class doktor_giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.doktor_tc = new System.Windows.Forms.TextBox();
            this.doktor_sifre = new System.Windows.Forms.TextBox();
            this.doktor_giris_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(190, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID no";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(190, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // doktor_tc
            // 
            this.doktor_tc.Location = new System.Drawing.Point(342, 143);
            this.doktor_tc.Name = "doktor_tc";
            this.doktor_tc.Size = new System.Drawing.Size(100, 22);
            this.doktor_tc.TabIndex = 2;
            this.doktor_tc.TextChanged += new System.EventHandler(this.doktor_tc_TextChanged);
            // 
            // doktor_sifre
            // 
            this.doktor_sifre.Location = new System.Drawing.Point(342, 203);
            this.doktor_sifre.Name = "doktor_sifre";
            this.doktor_sifre.Size = new System.Drawing.Size(100, 22);
            this.doktor_sifre.TabIndex = 3;
            // 
            // doktor_giris_btn
            // 
            this.doktor_giris_btn.Location = new System.Drawing.Point(342, 269);
            this.doktor_giris_btn.Name = "doktor_giris_btn";
            this.doktor_giris_btn.Size = new System.Drawing.Size(100, 33);
            this.doktor_giris_btn.TabIndex = 4;
            this.doktor_giris_btn.Text = "LogIn";
            this.doktor_giris_btn.UseVisualStyleBackColor = true;
            this.doktor_giris_btn.Click += new System.EventHandler(this.doktor_giris_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doktor_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doktor_giris_btn);
            this.Controls.Add(this.doktor_sifre);
            this.Controls.Add(this.doktor_tc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "doktor_giris";
            this.Text = "Doctor LogIn";
            this.Load += new System.EventHandler(this.doktor_giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox doktor_tc;
        private System.Windows.Forms.TextBox doktor_sifre;
        private System.Windows.Forms.Button doktor_giris_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}