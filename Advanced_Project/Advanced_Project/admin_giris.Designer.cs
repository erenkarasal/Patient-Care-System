
namespace Advanced_Project
{
    partial class admin_giris
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
            this.admin_giris_btn = new System.Windows.Forms.Button();
            this.admin_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_tc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admin_giris_btn
            // 
            this.admin_giris_btn.Location = new System.Drawing.Point(359, 239);
            this.admin_giris_btn.Name = "admin_giris_btn";
            this.admin_giris_btn.Size = new System.Drawing.Size(100, 33);
            this.admin_giris_btn.TabIndex = 9;
            this.admin_giris_btn.Text = "Giriş";
            this.admin_giris_btn.UseVisualStyleBackColor = true;
            this.admin_giris_btn.Click += new System.EventHandler(this.admin_giris_btn_Click);
            // 
            // admin_sifre
            // 
            this.admin_sifre.Location = new System.Drawing.Point(359, 173);
            this.admin_sifre.Name = "admin_sifre";
            this.admin_sifre.Size = new System.Drawing.Size(100, 22);
            this.admin_sifre.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(207, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(207, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin ID";
            // 
            // admin_tc
            // 
            this.admin_tc.Location = new System.Drawing.Point(359, 113);
            this.admin_tc.Name = "admin_tc";
            this.admin_tc.Size = new System.Drawing.Size(100, 22);
            this.admin_tc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // admin_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.admin_giris_btn);
            this.Controls.Add(this.admin_sifre);
            this.Controls.Add(this.admin_tc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "admin_giris";
            this.Text = "Admin LogIn";
            this.Load += new System.EventHandler(this.admin_giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin_giris_btn;
        private System.Windows.Forms.TextBox admin_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox admin_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}