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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void goster_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < WindowsFormsApp2.stack.mystack.Count; i++)
                FeedManager.ar.Add(WindowsFormsApp2.stack.mystack.Pop());
            foreach(var item in FeedManager.ar)
            {
                listBox1.Items.Add(item);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PostFeedForm postFeedForm = new PostFeedForm();
            postFeedForm.Show();
            this.Close();
        }
    }
}
