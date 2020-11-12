using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalApplication
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.reallyWant2Exit(e);
        }

        private void CreateAccount()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            User newUser;
            string Username = txtUsername.Text;
            bool recordControl = false;
            for (int i = 0; i < LoginForm.UserList.Count; i++)
            {
                if (LoginForm.UserList[i].Username1 == txtUsername.Text)
                {
                    MessageBox.Show("User already exists.");
                    recordControl = true;
                }
            }
            if (recordControl == false && txtUsername.Text != "" && txtPassword.Text != "")
            {
                string Password = Util.ComputeSha256Hash(txtPassword.Text);
                if(LoginForm.UserList.Count == 0)
                {
                    newUser = new User(Username, Password, false, "*", "", "", "", "", "", "", 0);
                }
                else
                {
                    newUser = new User(Username, Password, false, "+", "", "", "", "", "", "", 0);
                }
                LoginForm.UserList.Add(newUser);
                Util.SaveCsv(LoginForm.UserList, LoginForm.UserFilePath);
            }
            CreateAccount();
        }
    }
}
