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
    public partial class MainWindow : Form
    {
        public static int index;
        public static string username;
        public static string password;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.reallyWant2Exit(e);
        }

        private void LogOut()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for (int i = 0; i < LoginForm.UserList.Count; i++)
            {
                if (LoginForm.UserList[i].RememberMe1)
                {
                    LoginForm.UserList[i].RememberMe1 = false;
                    flag = true;
                }
            }
            if (flag == true)
            {
                Util.SaveCsv(LoginForm.UserList, LoginForm.UserFilePath);
            }
            LogOut();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.CreatePrompt = true;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.FileName = "value";
            saveFileDialog1.DefaultExt = "tsv";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Util.SaveTsv(LoginForm.UserList, saveFileDialog1.FileName);
            }
        }

        private void btnUser_Management_Click(object sender, EventArgs e)
        {
            bool management = false;
            for (int i = 0; i < LoginForm.UserList.Count; i++)
            {
                User user = LoginForm.UserList[i];
                if (user.IsValid(username))
                {
                    if (LoginForm.UserList[i].Admin_Control == "*")
                    {
                        management = true;
                        break;
                    }
                }
            }
            if (management)
            {
                lbluser_management.Text = "You are admin :)";
                lbluser_management.BackColor = Color.Green;
                lbluser_management.ForeColor = Color.White;
                MaintoUser_Managament();
            }
            else
            {
                lbluser_management.Text = "You are not admin :)";
                lbluser_management.BackColor = Color.Red;
                lbluser_management.ForeColor = Color.Black;
            }
        }
        private void MaintoUser_Managament()
        {
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
            this.Hide();
        }

        private void btnPhonebook_Click(object sender, EventArgs e)
        {
            Phonebook phonebook = new Phonebook();
            phonebook.Show();
            this.Hide();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            Notes Notes = new Notes();
            Notes.Show();
            this.Hide();
        }

        private void btnPersonalInformation_Click(object sender, EventArgs e)
        {
            PersonalInformation personalInformation = new PersonalInformation();
            personalInformation.Show();
            this.Hide();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            MainWindow.username = LoginForm.UserList[MainWindow.index].Username1;
            MainWindow.password = LoginForm.UserList[MainWindow.index].Password1;
        }

        private void btnSalaryCalculator_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.Show();
            this.Hide();
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            Reminder reminder = new Reminder();
            reminder.Show();
            this.Hide();
        }

        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
            if (Util.flag)
            {
                Util.RingRing();
            }              
        }
    }
}