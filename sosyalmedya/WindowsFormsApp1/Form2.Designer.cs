namespace WindowsFormsApp1
{
    partial class MyPostsForm
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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.PostEkleFormbt = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Exitbt1 = new System.Windows.Forms.Button();
            this.MyPostsbt2 = new System.Windows.Forms.Button();
            this.PostFeedbt2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listPost = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(247, 385);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(114, 40);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "< Geri";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(512, 385);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(114, 40);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "İleri >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // PostEkleFormbt
            // 
            this.PostEkleFormbt.BackColor = System.Drawing.Color.Blue;
            this.PostEkleFormbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostEkleFormbt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostEkleFormbt.ForeColor = System.Drawing.SystemColors.Window;
            this.PostEkleFormbt.Location = new System.Drawing.Point(540, 16);
            this.PostEkleFormbt.Name = "PostEkleFormbt";
            this.PostEkleFormbt.Size = new System.Drawing.Size(114, 40);
            this.PostEkleFormbt.TabIndex = 3;
            this.PostEkleFormbt.Text = "Yeni Gönder";
            this.PostEkleFormbt.UseVisualStyleBackColor = false;
            this.PostEkleFormbt.Click += new System.EventHandler(this.PostEkleFormbt_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(376, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Exitbt1
            // 
            this.Exitbt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Exitbt1.FlatAppearance.BorderSize = 0;
            this.Exitbt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbt1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbt1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exitbt1.Location = new System.Drawing.Point(14, 262);
            this.Exitbt1.Name = "Exitbt1";
            this.Exitbt1.Size = new System.Drawing.Size(165, 65);
            this.Exitbt1.TabIndex = 13;
            this.Exitbt1.Text = "Çıkış Yap";
            this.Exitbt1.UseVisualStyleBackColor = false;
            this.Exitbt1.Click += new System.EventHandler(this.Exitbt1_Click);
            // 
            // MyPostsbt2
            // 
            this.MyPostsbt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MyPostsbt2.FlatAppearance.BorderSize = 0;
            this.MyPostsbt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyPostsbt2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyPostsbt2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MyPostsbt2.Location = new System.Drawing.Point(14, 172);
            this.MyPostsbt2.Name = "MyPostsbt2";
            this.MyPostsbt2.Size = new System.Drawing.Size(165, 65);
            this.MyPostsbt2.TabIndex = 12;
            this.MyPostsbt2.Text = "Gönderilerim";
            this.MyPostsbt2.UseVisualStyleBackColor = false;
            // 
            // PostFeedbt2
            // 
            this.PostFeedbt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PostFeedbt2.FlatAppearance.BorderSize = 0;
            this.PostFeedbt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostFeedbt2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostFeedbt2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PostFeedbt2.Location = new System.Drawing.Point(14, 91);
            this.PostFeedbt2.Name = "PostFeedbt2";
            this.PostFeedbt2.Size = new System.Drawing.Size(165, 65);
            this.PostFeedbt2.TabIndex = 11;
            this.PostFeedbt2.Text = "Ana Sayfa";
            this.PostFeedbt2.UseVisualStyleBackColor = false;
            this.PostFeedbt2.Click += new System.EventHandler(this.PostFeedbt2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 79);
            this.label1.TabIndex = 10;
            this.label1.Text = "Haber Akışı Simülasyonu";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.richTextBox1.Location = new System.Drawing.Point(-1, -3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(196, 456);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Gönderilerim";
            // 
            // listPost
            // 
            this.listPost.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listPost.Font = new System.Drawing.Font("PMingLiU-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPost.FormattingEnabled = true;
            this.listPost.ItemHeight = 18;
            this.listPost.Location = new System.Drawing.Point(306, 82);
            this.listPost.Name = "listPost";
            this.listPost.Size = new System.Drawing.Size(252, 256);
            this.listPost.TabIndex = 15;
            // 
            // MyPostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.listPost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exitbt1);
            this.Controls.Add(this.MyPostsbt2);
            this.Controls.Add(this.PostFeedbt2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.PostEkleFormbt);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyPostsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Post";
            this.Load += new System.EventHandler(this.MyPostsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button PostEkleFormbt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button Exitbt1;
        private System.Windows.Forms.Button MyPostsbt2;
        private System.Windows.Forms.Button PostFeedbt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listPost;
    }
}