namespace WindowsFormsApp1
{
    partial class PostFeedForm
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
            this.listPost1 = new System.Windows.Forms.ListBox();
            this.Prevbt1 = new System.Windows.Forms.Button();
            this.Nextbt1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PostFeedbt1 = new System.Windows.Forms.Button();
            this.MyPostsbt1 = new System.Windows.Forms.Button();
            this.Exitbt1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPost1
            // 
            this.listPost1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listPost1.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPost1.ForeColor = System.Drawing.Color.Black;
            this.listPost1.FormattingEnabled = true;
            this.listPost1.ItemHeight = 27;
            this.listPost1.Location = new System.Drawing.Point(393, 87);
            this.listPost1.Margin = new System.Windows.Forms.Padding(4);
            this.listPost1.Name = "listPost1";
            this.listPost1.Size = new System.Drawing.Size(384, 355);
            this.listPost1.TabIndex = 0;
            // 
            // Prevbt1
            // 
            this.Prevbt1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Prevbt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prevbt1.ForeColor = System.Drawing.Color.Black;
            this.Prevbt1.Location = new System.Drawing.Point(339, 468);
            this.Prevbt1.Margin = new System.Windows.Forms.Padding(4);
            this.Prevbt1.Name = "Prevbt1";
            this.Prevbt1.Size = new System.Drawing.Size(185, 50);
            this.Prevbt1.TabIndex = 1;
            this.Prevbt1.Text = "< Geri";
            this.Prevbt1.UseVisualStyleBackColor = true;
            this.Prevbt1.Click += new System.EventHandler(this.Prevbt1_Click);
            // 
            // Nextbt1
            // 
            this.Nextbt1.BackColor = System.Drawing.SystemColors.Window;
            this.Nextbt1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nextbt1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Nextbt1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Nextbt1.Location = new System.Drawing.Point(635, 468);
            this.Nextbt1.Margin = new System.Windows.Forms.Padding(4);
            this.Nextbt1.Name = "Nextbt1";
            this.Nextbt1.Size = new System.Drawing.Size(185, 50);
            this.Nextbt1.TabIndex = 2;
            this.Nextbt1.Text = "İleri >";
            this.Nextbt1.UseVisualStyleBackColor = false;
            this.Nextbt1.Click += new System.EventHandler(this.Nextbt1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.richTextBox1.Location = new System.Drawing.Point(-3, -4);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 560);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 97);
            this.label1.TabIndex = 5;
            this.label1.Text = "Haber Akışı Simülasyonu";
            // 
            // PostFeedbt1
            // 
            this.PostFeedbt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PostFeedbt1.FlatAppearance.BorderSize = 0;
            this.PostFeedbt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostFeedbt1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostFeedbt1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PostFeedbt1.Location = new System.Drawing.Point(17, 112);
            this.PostFeedbt1.Margin = new System.Windows.Forms.Padding(4);
            this.PostFeedbt1.Name = "PostFeedbt1";
            this.PostFeedbt1.Size = new System.Drawing.Size(220, 80);
            this.PostFeedbt1.TabIndex = 6;
            this.PostFeedbt1.Text = "Ana Sayfa";
            this.PostFeedbt1.UseVisualStyleBackColor = false;
            // 
            // MyPostsbt1
            // 
            this.MyPostsbt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MyPostsbt1.FlatAppearance.BorderSize = 0;
            this.MyPostsbt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyPostsbt1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyPostsbt1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MyPostsbt1.Location = new System.Drawing.Point(17, 212);
            this.MyPostsbt1.Margin = new System.Windows.Forms.Padding(4);
            this.MyPostsbt1.Name = "MyPostsbt1";
            this.MyPostsbt1.Size = new System.Drawing.Size(220, 80);
            this.MyPostsbt1.TabIndex = 7;
            this.MyPostsbt1.Text = "Gönderilerim";
            this.MyPostsbt1.UseVisualStyleBackColor = false;
            this.MyPostsbt1.Click += new System.EventHandler(this.MyPostsbt1_Click);
            // 
            // Exitbt1
            // 
            this.Exitbt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Exitbt1.FlatAppearance.BorderSize = 0;
            this.Exitbt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbt1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbt1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exitbt1.Location = new System.Drawing.Point(17, 322);
            this.Exitbt1.Margin = new System.Windows.Forms.Padding(4);
            this.Exitbt1.Name = "Exitbt1";
            this.Exitbt1.Size = new System.Drawing.Size(220, 80);
            this.Exitbt1.TabIndex = 8;
            this.Exitbt1.Text = "Çıkış Yap";
            this.Exitbt1.UseVisualStyleBackColor = false;
            this.Exitbt1.Click += new System.EventHandler(this.Exitbt1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tüm Gönderiler";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(698, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Bildirimler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PostFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(893, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exitbt1);
            this.Controls.Add(this.MyPostsbt1);
            this.Controls.Add(this.PostFeedbt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Nextbt1);
            this.Controls.Add(this.Prevbt1);
            this.Controls.Add(this.listPost1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostFeedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Post Feed";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPost1;
        private System.Windows.Forms.Button Prevbt1;
        private System.Windows.Forms.Button Nextbt1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PostFeedbt1;
        private System.Windows.Forms.Button MyPostsbt1;
        private System.Windows.Forms.Button Exitbt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

