using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        

        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void Logbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            PostFeedForm form = new PostFeedForm();  
            form.ShowDialog();
            this.Close();
        }

        private void KayitFormbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingupForm form = new SingupForm();
            form.ShowDialog();
            
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {

            string username = UserLogtxt.Text;
            string password = PasswordLogtxt.Text;

            if (UserData.Users.ContainsKey(username))
            {
                if (UserData.Users[username].ToString() == password)
                {
                    User.user.Users = UserLogtxt.Text;
                    this.Close();
                    PostFeedForm postfeedform = new PostFeedForm();

                    postfeedform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("password wrong");
                }
            }
            else
            {
                MessageBox.Show("username not found");
            }



        }
    }
    
}
