namespace WindowsFormsApp1
{
    partial class SingupForm
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
            this.LoginFormbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Kayitbtn = new System.Windows.Forms.Button();
            this.AdSoyadtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginFormbtn
            // 
            this.LoginFormbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LoginFormbtn.FlatAppearance.BorderSize = 0;
            this.LoginFormbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginFormbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormbtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginFormbtn.Location = new System.Drawing.Point(321, 471);
            this.LoginFormbtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoginFormbtn.Name = "LoginFormbtn";
            this.LoginFormbtn.Padding = new System.Windows.Forms.Padding(0, 0, 44, 0);
            this.LoginFormbtn.Size = new System.Drawing.Size(161, 50);
            this.LoginFormbtn.TabIndex = 26;
            this.LoginFormbtn.Text = "Giriş Yap";
            this.LoginFormbtn.UseVisualStyleBackColor = false;
            this.LoginFormbtn.Click += new System.EventHandler(this.LoginFormbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(147, 485);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Hesabınız var mı?";
            // 
            // Kayitbtn
            // 
            this.Kayitbtn.BackColor = System.Drawing.Color.Blue;
            this.Kayitbtn.FlatAppearance.BorderSize = 0;
            this.Kayitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kayitbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kayitbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Kayitbtn.Location = new System.Drawing.Point(139, 543);
            this.Kayitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Kayitbtn.Name = "Kayitbtn";
            this.Kayitbtn.Size = new System.Drawing.Size(319, 80);
            this.Kayitbtn.TabIndex = 24;
            this.Kayitbtn.Text = "Kayıt Ol";
            this.Kayitbtn.UseVisualStyleBackColor = false;
            this.Kayitbtn.Click += new System.EventHandler(this.Kayitbtn_Click);
            // 
            // AdSoyadtxt
            // 
            this.AdSoyadtxt.Location = new System.Drawing.Point(193, 140);
            this.AdSoyadtxt.Margin = new System.Windows.Forms.Padding(4);
            this.AdSoyadtxt.Multiline = true;
            this.AdSoyadtxt.Name = "AdSoyadtxt";
            this.AdSoyadtxt.Size = new System.Drawing.Size(317, 40);
            this.AdSoyadtxt.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(40, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(9);
            this.label3.Size = new System.Drawing.Size(128, 41);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(189, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Yeni hesap oluşturun";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(112, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Haber Akışı Simülasyonu";
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(193, 234);
            this.Usertxt.Margin = new System.Windows.Forms.Padding(4);
            this.Usertxt.Multiline = true;
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(317, 40);
            this.Usertxt.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(32, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(9);
            this.label4.Size = new System.Drawing.Size(153, 41);
            this.label4.TabIndex = 31;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(193, 326);
            this.Passwordtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Passwordtxt.Multiline = true;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(317, 40);
            this.Passwordtxt.TabIndex = 32;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(193, 415);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(317, 40);
            this.textBox4.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(68, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(9);
            this.label6.Size = new System.Drawing.Size(68, 42);
            this.label6.TabIndex = 34;
            this.label6.Text = "Şifre";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(32, 415);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(9);
            this.label7.Size = new System.Drawing.Size(153, 41);
            this.label7.TabIndex = 35;
            this.label7.Text = "Şifre Tekrar";
            // 
            // SingupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(548, 646);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.LoginFormbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Kayitbtn);
            this.Controls.Add(this.AdSoyadtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SingupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginFormbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Kayitbtn;
        private System.Windows.Forms.TextBox AdSoyadtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}