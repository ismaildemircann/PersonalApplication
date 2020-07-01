using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PersonalApplication
{
    public partial class PersonalInformation : Form
    {
        Memory memory = new Memory();
        Stack<Memento> undo = new Stack<Memento>();
        Stack<Memento> redo = new Stack<Memento>();
        public PersonalInformation()
        {
            InitializeComponent();
        }

        private void PersonalInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.reallyWant2Exit(e);
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Dosyası |*.jpg";
            openFileDialog1.CheckFileExists = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                picBoxPhoto.ImageLocation = openFileDialog1.FileName;
                LoginForm.UserList[MainWindow.index].Photo = Util.GetBase64StringForImage(openFileDialog1.FileName);
                LoginForm.UserList.Insert(MainWindow.index, LoginForm.UserList[MainWindow.index]);
                LoginForm.UserList.RemoveAt(MainWindow.index + 1);
                Util.SaveCsv(LoginForm.UserList, LoginForm.UserFilePath);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            LoginForm.UserList[MainWindow.index].Name = txtboxName.Text;
            LoginForm.UserList[MainWindow.index].Surname = txtboxSurname.Text;
            LoginForm.UserList[MainWindow.index].Phonenumber = mtxtboxPhoneNumber.Text;
            LoginForm.UserList[MainWindow.index].Address = txtboxAddress.Text;
            LoginForm.UserList[MainWindow.index].E_Mail = txtboxMail.Text;
            LoginForm.UserList.Insert(MainWindow.index, LoginForm.UserList[MainWindow.index]);
            LoginForm.UserList.RemoveAt(MainWindow.index + 1);
            Util.SaveCsv(LoginForm.UserList, LoginForm.UserFilePath);
        }

        private void PersonalInformation_Load(object sender, EventArgs e)
        {
            Util.LoadCsv(LoginForm.UserList, LoginForm.UserFilePath);
            txtboxName.Text = LoginForm.UserList[MainWindow.index].Name;
            txtboxSurname.Text = LoginForm.UserList[MainWindow.index].Surname;
            mtxtboxPhoneNumber.Text = LoginForm.UserList[MainWindow.index].Phonenumber;
            txtboxAddress.Text = LoginForm.UserList[MainWindow.index].Address;
            txtboxMail.Text = LoginForm.UserList[MainWindow.index].E_Mail;
            picBoxPhoto.Image = Util.Base64ToImage(LoginForm.UserList[MainWindow.index].Photo);
            picBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            memory.ProductMemento = LoginForm.UserList[MainWindow.index].Save();
        }

        private void btnMainWindow_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            pnlChangePassword.Visible = true;
        }

        private void btnPanelChange_Click(object sender, EventArgs e)
        {
            if (Util.ComputeSha256Hash(txtOldPassword.Text) == LoginForm.UserList[MainWindow.index].Password1)
            {
                LoginForm.UserList[MainWindow.index].Password1 = Util.ComputeSha256Hash(txtNewPassword.Text);
                LoginForm.UserList.Insert(MainWindow.index, LoginForm.UserList[MainWindow.index]);
                LoginForm.UserList.RemoveAt(MainWindow.index + 1);
                Util.SaveCsv(LoginForm.UserList, LoginForm.UserFilePath);
                MessageBox.Show("Password was changed!");
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
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide(); 
                return; 
            }
            MessageBox.Show("You have to type old password correctly");
        }

        private void chckBxShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chckBxShowNewPassword.Checked == true)
            {
                txtNewPassword.UseSystemPasswordChar = false;
            }
            else
                txtNewPassword.UseSystemPasswordChar = true;
        }

        private void chckBxShowOldPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxShowOldPassword.Checked == true)
            {
                txtOldPassword.UseSystemPasswordChar = false;
            }
            else
                txtOldPassword.UseSystemPasswordChar = true;
        }

        private void PersonalInformation_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                Event(undo, redo);
            }
            else if(e.Control == false && e.KeyCode != Keys.Back)
            {
                User user = new User("", "", false, "", txtboxName.Text, txtboxSurname.Text, mtxtboxPhoneNumber.Text, txtboxAddress.Text
              , txtboxMail.Text, "", 0);
                Memory memory = new Memory();
                memory.ProductMemento = user.Save();
                undo.Push(memory.ProductMemento);
                user.Undo(memory.ProductMemento);
            }
            if (e.Control && e.KeyCode == Keys.Y)
            {
                Event(redo, undo);
            }
            else if (e.Control == false && e.KeyCode != Keys.Back)
            {
                User user = new User("", "", false, "", txtboxName.Text, txtboxSurname.Text, mtxtboxPhoneNumber.Text, txtboxAddress.Text
              , txtboxMail.Text, "", 0);
                Memory memory = new Memory();
                memory.ProductMemento = user.Save();
                undo.Push(memory.ProductMemento);
                user.Undo(memory.ProductMemento);
            }
        }

        private void Event(Stack<Memento> memory, Stack<Memento> temp_memory)
        {
            if(memory.Count !=0)
            {
                User user = new User("", "", false, "", txtboxName.Text, txtboxSurname.Text, mtxtboxPhoneNumber.Text, txtboxAddress.Text
               , txtboxMail.Text, "", 0);
                Memento new_memory = memory.Pop();
                Memento old_memory;
                old_memory = user.Save();
                temp_memory.Push(old_memory);
                user.Undo(new_memory);
                txtboxSurname.Text = new_memory.Surname;
                txtboxName.Text = new_memory.Name;
                txtboxAddress.Text = new_memory.Address;
                txtboxMail.Text = new_memory.E_Mail;
                mtxtboxPhoneNumber.Text = new_memory.Phonenumber;
            }
        }
    }
}