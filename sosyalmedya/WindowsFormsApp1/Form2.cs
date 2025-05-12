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
    public partial class MyPostsForm : Form
    {


        public MyPostsForm()
        {
            InitializeComponent();
        }

        private void PostFeedbt2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PostFeedForm form = new PostFeedForm(); 
            form.ShowDialog();
            this.Close();
        }

        private void PostEkleFormbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            PostEkleForm form = new PostEkleForm();  
            form.ShowDialog();
            this.Show();
            ShowCurrent();

        }
        private void ShowCurrent()
        {
            Post current = FeedManager.feedmanager.GetCurrent();
            if (listPost.Items == null)
                listPost.Items.Remove(current);
            if (current != null && current.Name == User.user.Users)
            {
                listPost.Items.Clear();
                listPost.Items.Add($"Name: {current.Name}\n");
                listPost.Items.Add($"Title: {current.Title}\n");
                listPost.Items.Add($"Content: {current.Content}\n");
                listPost.Items.Add($"Time: {current.Timestamp}");
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            listPost.Items.Clear();
            FeedManager.feedmanager.MoveNext();
            ShowCurrent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            listPost.Items.Clear();
            FeedManager.feedmanager.MovePrevious();
            ShowCurrent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listPost.Items.Clear();
            FeedManager.feedmanager.DeleteCurrent();
            ShowCurrent();
            
        }

        private void Exitbt1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void MyPostsForm_Load(object sender, EventArgs e)
        {
            ShowCurrent();

        }
    }
}
