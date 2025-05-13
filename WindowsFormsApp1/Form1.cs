using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class PostFeedForm : Form
    {
        
        public PostFeedForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowCurrentPost();
        }
        private void ShowCurrentPost()
        {
            Post current = FeedManager.feedmanager.GetCurrent();
            if (current != null)
            {
                listPost1.Items.Clear();
                listPost1.Items.Add($"Name: {current.Name}\n");
                listPost1.Items.Add($"Title: {current.Title}\n");
                listPost1.Items.Add($"Content: {current.Content}\n");
                listPost1.Items.Add($"Time: {current.Timestamp}");

            }

        }


        private void MyPostsbt1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyPostsForm myPostsForm = new MyPostsForm();
            myPostsForm.ShowDialog();
            this.Close();
        }

        private void Nextbt1_Click(object sender, EventArgs e)

        {
            listPost1.Items.Clear();
            FeedManager.feedmanager.MoveNext();
            ShowCurrentPost();
        }

        private void Prevbt1_Click(object sender, EventArgs e)
        {
            listPost1.Items.Clear();
            FeedManager.feedmanager.MovePrevious();
            ShowCurrentPost();
        }

        private void Exitbt1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.Show();
            this.Close();
        }
    }
}
