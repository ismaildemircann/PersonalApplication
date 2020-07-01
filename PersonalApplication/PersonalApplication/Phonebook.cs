using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalApplication
{
    public partial class Phonebook : Form
    {
        public static string PhonebookFilePath;
        int SelectedIndex = -1;

        public Phonebook()
        {
            InitializeComponent();
        }

        private void btnMainWindow_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void Phonebook_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.reallyWant2Exit(e);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool isEmail = Regex.IsMatch(txtboxMail.Text, @"\A(?:[a-z0-9!#$%&'+/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'+/=?^_`{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (isEmail)
            {
                PhonebookFilePath = @"data/" + MainWindow.username + "Phonebook.csv";
                Phone phn = new Phone(txtboxName.Text, txtboxSurname.Text, mtxtboxPhoneNumber.Text,
              txtboxAddress.Text, txtboxDescription.Text, txtboxMail.Text, MainWindow.username);
                LoginForm.UserList[MainWindow.index].Phones.Add(phn);
                Util.SaveCsv(phn, PhonebookFilePath);
                MessageBox.Show("Person registered", "Save", MessageBoxButtons.OK);
                txtboxName.Text = "";
                txtboxSurname.Text = "";
                txtboxMail.Text = "";
                txtboxDescription.Text = "";
                txtboxAddress.Text = "";
                mtxtboxPhoneNumber.Text = "";
                btnList_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Your email address is not verified.");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lstPhoneBook.Items.Clear();
            PhonebookFilePath = @"data/" + MainWindow.username + "Phonebook.csv";
            Util.LoadCsv(LoginForm.UserList[MainWindow.index].Phones, PhonebookFilePath, MainWindow.username);
            for (int i = 0; i < LoginForm.UserList[MainWindow.index].Phones.Count; i++)
            {
                string[] row = {LoginForm.UserList[MainWindow.index].Phones[i].Name,
                    LoginForm.UserList[MainWindow.index].Phones[i].Surname,
                    LoginForm.UserList[MainWindow.index].Phones[i].Phonenumber,
                    LoginForm.UserList[MainWindow.index].Phones[i].Address,
                    LoginForm.UserList[MainWindow.index].Phones[i].Description,
                    LoginForm.UserList[MainWindow.index].Phones[i].E_Mail };
                ListViewItem itm = new ListViewItem(row);
                lstPhoneBook.Items.Add(itm);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                PhonebookFilePath = @"data/" + MainWindow.username + "phonebook.csv";
                var file = new List<string>(System.IO.File.ReadAllLines(PhonebookFilePath));
                file.RemoveAt(lstPhoneBook.FocusedItem.Index);
                System.IO.File.WriteAllLines(PhonebookFilePath, file.ToArray());
                btnList_Click(sender, e);
                txtboxName.Text = "";
                txtboxSurname.Text = "";
                txtboxMail.Text = "";
                txtboxDescription.Text = "";
                txtboxAddress.Text = "";
                mtxtboxPhoneNumber.Text = "";
            }
            catch(Exception)
            {
                MessageBox.Show("Select an user for deleting.");
            }
        }

        private void lstPhoneBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhonebookFilePath = @"data/" + MainWindow.username + "phonebook.csv";
            SelectedIndex = lstPhoneBook.FocusedItem.Index;
            txtboxName.Text = lstPhoneBook.Items[SelectedIndex].SubItems[0].Text;
            txtboxSurname.Text = lstPhoneBook.Items[SelectedIndex].SubItems[1].Text;
            mtxtboxPhoneNumber.Text = lstPhoneBook.Items[SelectedIndex].SubItems[2].Text;
            txtboxAddress.Text = lstPhoneBook.Items[SelectedIndex].SubItems[3].Text;
            txtboxDescription.Text = lstPhoneBook.Items[SelectedIndex].SubItems[4].Text;
            txtboxMail.Text = lstPhoneBook.Items[SelectedIndex].SubItems[5].Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                PhonebookFilePath = @"data/" + MainWindow.username + "phonebook.csv";
                Phone phn = new Phone(txtboxName.Text, txtboxSurname.Text, mtxtboxPhoneNumber.Text,
               txtboxAddress.Text, txtboxDescription.Text, txtboxMail.Text, MainWindow.username);
                var file = new List<string>(System.IO.File.ReadAllLines(PhonebookFilePath));
                file.Insert(lstPhoneBook.FocusedItem.Index, phn.PhoneToCsv());
                file.RemoveAt(lstPhoneBook.FocusedItem.Index + 1);
                System.IO.File.WriteAllLines(PhonebookFilePath, file.ToArray());
                btnList_Click(sender, e);
            }
            catch(Exception)
            {
                MessageBox.Show("Select an user for updating.");
            }
        }
    }
}
