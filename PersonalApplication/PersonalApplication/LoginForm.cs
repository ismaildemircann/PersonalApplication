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
    public partial class LoginForm : Form
    {
        public static List<User> UserList = new List<User>();
        public static string UserFilePath = @"data/User.csv";        
        public LoginForm()
        {
            InitializeComponent();
            Util.LoadCsv(UserList, UserFilePath);
            checkRememberedUser();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            bool rememberMe = chkRememberMe.Checked;
            for (int i = 0; i < UserList.Count; i++)
            {
                User user = UserList[i];
                if(user.IsValid(Username, Password))
                {
                    user.RememberMe1 = rememberMe;
                    lblLoginMessage.Text = "Success";
                    lblLoginMessage.ForeColor = Color.Green;
                    LoginedUser.getInstance().User = user;
                    LoginDelay.Start();
                    if (rememberMe == true)
                    {
                        Util.SaveCsv(UserList, UserFilePath);
                    }
                    MainWindow.username = Username;
                    MainWindow.password = Password;
                    MainWindow.index = i;
                    Util.LoadCsv(User.phones, Phonebook.PhonebookFilePath, Username);
                    return;
                }
                lblLoginMessage.Text = "Failure";
                lblLoginMessage.ForeColor = Color.Red;
            }
        }

        private void LoginDelay_Tick(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            LoginDelay.Stop();
            this.Hide();
        }

        private void SignUp()
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
            this.Hide();
        }

        private void checkRememberedUser()
        {
            int i = 0;
            foreach (User user in UserList)
            {
                if(user.RememberMe1)
                {
                    MainWindow.index = i;
                    LoginedUser.getInstance().User = user;
                    LoginDelay.Interval = 10;
                    LoginDelay.Start();
                    return;
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.reallyWant2Exit(e);
        }
    }
}
