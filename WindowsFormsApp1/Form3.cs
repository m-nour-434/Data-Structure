using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class PostEkleForm : Form
    {

        public PostEkleForm()
        {
            InitializeComponent();
        }


        private void PostEkleClosebt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PostEklebtn_Click(object sender, EventArgs e)
        {
            string Title =Titletxt.Text;
            string Content = Contenttxt.Text;
            string name = User.user.Users;
            if (!string.IsNullOrEmpty(Title) && !string.IsNullOrEmpty(Content))
            {
                FeedManager.feedmanager.AddPost(Title, Content,name); 
                this.Close();  
            }
            else
            {
                MessageBox.Show("Lütfen başlık ve içerik giriniz.");
            }

            
        }


    }



}
