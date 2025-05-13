using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class SingupForm : Form
    {
        public SingupForm()
        {
            InitializeComponent();
            
        }

        private void LoginFormbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }

        private void Kayitbtn_Click(object sender, EventArgs e)
        {


            if (AdSoyadtxt.Text != string.Empty)
            {
                if (Usertxt.Text != string.Empty)
                {
                    if (Passwordtxt.Text != string.Empty)
                    {
                        if (Passwordtxt.Text == textBox4.Text)
                        {
                            string username = Usertxt.Text;
                            string password = Passwordtxt.Text;

                            if (UserData.Users.ContainsKey(username))
                            {
                                MessageBox.Show("username already exist");
                            }
                            else
                            {
                                UserData.Users.Add(username, password);
                                MessageBox.Show("new account created successfully");
                            }
                            
                            this.Close();
                            LoginForm loginform = new LoginForm();
                            loginform.Show();
                        }
                        else
                        {
                            filling_Error fillerror = new filling_Error();
                            fillerror.ShowDialog();
                        }
                    }
                    else
                    {
                        filling_Error fillerror = new filling_Error();
                        fillerror.ShowDialog();
                    }
                }
                else
                {
                    filling_Error fillerror = new filling_Error();
                    fillerror.ShowDialog();
                }
            }
            else
            {
                filling_Error fillerror = new filling_Error();
                fillerror.ShowDialog();
            }



        }

        
    }



    
}
