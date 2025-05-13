namespace WindowsFormsApp1
{
    partial class PostEkleForm
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
            this.Titletxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Contenttxt = new System.Windows.Forms.TextBox();
            this.PostEklebtn = new System.Windows.Forms.Button();
            this.PostEkleClosebt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // Titletxt
            // 
            this.Titletxt.Location = new System.Drawing.Point(135, 43);
            this.Titletxt.Multiline = true;
            this.Titletxt.Name = "Titletxt";
            this.Titletxt.Size = new System.Drawing.Size(246, 43);
            this.Titletxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Content";
            // 
            // Contenttxt
            // 
            this.Contenttxt.Location = new System.Drawing.Point(135, 134);
            this.Contenttxt.Multiline = true;
            this.Contenttxt.Name = "Contenttxt";
            this.Contenttxt.Size = new System.Drawing.Size(246, 196);
            this.Contenttxt.TabIndex = 3;
            // 
            // PostEklebtn
            // 
            this.PostEklebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostEklebtn.Location = new System.Drawing.Point(43, 367);
            this.PostEklebtn.Name = "PostEklebtn";
            this.PostEklebtn.Size = new System.Drawing.Size(132, 46);
            this.PostEklebtn.TabIndex = 4;
            this.PostEklebtn.Text = "Ekle";
            this.PostEklebtn.UseVisualStyleBackColor = true;
            this.PostEklebtn.Click += new System.EventHandler(this.PostEklebtn_Click);
            // 
            // PostEkleClosebt
            // 
            this.PostEkleClosebt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostEkleClosebt.Location = new System.Drawing.Point(211, 367);
            this.PostEkleClosebt.Name = "PostEkleClosebt";
            this.PostEkleClosebt.Size = new System.Drawing.Size(132, 46);
            this.PostEkleClosebt.TabIndex = 5;
            this.PostEkleClosebt.Text = "Geri";
            this.PostEkleClosebt.UseVisualStyleBackColor = true;
            this.PostEkleClosebt.Click += new System.EventHandler(this.PostEkleClosebt_Click);
            // 
            // PostEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.PostEkleClosebt);
            this.Controls.Add(this.PostEklebtn);
            this.Controls.Add(this.Contenttxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Titletxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Post Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Titletxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Contenttxt;
        private System.Windows.Forms.Button PostEklebtn;
        private System.Windows.Forms.Button PostEkleClosebt;
    }
}