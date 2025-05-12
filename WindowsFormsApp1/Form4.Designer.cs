namespace WindowsFormsApp1
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserLogtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordLogtxt = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.KayitFormbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(55, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Haber Akışı Simülasyonu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(112, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hesabınıza giriş yapın";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(56, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // UserLogtxt
            // 
            this.UserLogtxt.Location = new System.Drawing.Point(81, 224);
            this.UserLogtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserLogtxt.Multiline = true;
            this.UserLogtxt.Name = "UserLogtxt";
            this.UserLogtxt.Size = new System.Drawing.Size(317, 40);
            this.UserLogtxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(56, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şifre";
            // 
            // PasswordLogtxt
            // 
            this.PasswordLogtxt.Location = new System.Drawing.Point(81, 318);
            this.PasswordLogtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordLogtxt.Multiline = true;
            this.PasswordLogtxt.Name = "PasswordLogtxt";
            this.PasswordLogtxt.Size = new System.Drawing.Size(317, 40);
            this.PasswordLogtxt.TabIndex = 6;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.Blue;
            this.Loginbtn.FlatAppearance.BorderSize = 0;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Loginbtn.Location = new System.Drawing.Point(81, 389);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(319, 80);
            this.Loginbtn.TabIndex = 14;
            this.Loginbtn.Text = "Geriş Yap";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(89, 485);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hesabınız yok mu?";
            // 
            // KayitFormbtn
            // 
            this.KayitFormbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.KayitFormbtn.FlatAppearance.BorderSize = 0;
            this.KayitFormbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KayitFormbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayitFormbtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.KayitFormbtn.Location = new System.Drawing.Point(272, 476);
            this.KayitFormbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KayitFormbtn.Name = "KayitFormbtn";
            this.KayitFormbtn.Size = new System.Drawing.Size(99, 42);
            this.KayitFormbtn.TabIndex = 16;
            this.KayitFormbtn.Text = "Kayıt Ol";
            this.KayitFormbtn.UseVisualStyleBackColor = false;
            this.KayitFormbtn.Click += new System.EventHandler(this.KayitFormbtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(453, 554);
            this.Controls.Add(this.KayitFormbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.PasswordLogtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserLogtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserLogtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordLogtxt;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button KayitFormbtn;
    }
}