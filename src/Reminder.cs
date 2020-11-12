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
    public partial class Reminder : Form
    {
        public static string ReminderFilePath;
        public Reminder()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateandTime.Text = System.DateTime.Now.ToString();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ReminderFilePath = @"data/" + MainWindow.username + "Reminder.csv";
            string type;
            if (rdobtnMeeting.Checked)
                type = rdobtnMeeting.Text;
            else
                type = rdobtnTask.Text;
            MeetingTaskReminder reminder = new MeetingTaskReminder(txtboxDate.Text, mtxtboxTime.Text, txtSummary.Text, 
                txtDescription.Text,type, MainWindow.username);
            LoginForm.UserList[MainWindow.index].Reminders.Add(reminder);
            Util.SaveCsv(reminder, ReminderFilePath);
            MessageBox.Show("Reminder registered", "Save", MessageBoxButtons.OK);
            txtboxDate.Text = "";
            txtDescription.Text = "";
            txtSummary.Text = "";
            mtxtboxTime.Text = "";
            if (rdobtnMeeting.Checked)
                rdobtnMeeting.Checked = false;
            else
                rdobtnTask.Checked = false;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            txtboxDate.Text = dtpDate.Text;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ReminderFilePath = @"data/" + MainWindow.username + "Reminder.csv";
            lstReminder.Items.Clear();
            Util.LoadCsv(LoginForm.UserList[MainWindow.index].Reminders, ReminderFilePath, MainWindow.username);
            for (int i = 0; i < LoginForm.UserList[MainWindow.index].Reminders.Count; i++)
            {
                string[] row = {LoginForm.UserList[MainWindow.index].Reminders[i].Date,
                    LoginForm.UserList[MainWindow.index].Reminders[i].Time,
                    LoginForm.UserList[MainWindow.index].Reminders[i].Summary,
                    LoginForm.UserList[MainWindow.index].Reminders[i].Description,
                    LoginForm.UserList[MainWindow.index].Reminders[i].Type };
                ListViewItem itm = new ListViewItem(row);
                lstReminder.Items.Add(itm);
            }
        }

        private void btnMainWindow_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void Reminder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.reallyWant2Exit(e);
        }

        private void lstReminder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = -1;
            SelectedIndex = lstReminder.FocusedItem.Index;
            txtboxDate.Text = lstReminder.Items[SelectedIndex].SubItems[0].Text;
            mtxtboxTime.Text = lstReminder.Items[SelectedIndex].SubItems[1].Text;
            txtSummary.Text = lstReminder.Items[SelectedIndex].SubItems[2].Text;
            txtDescription.Text = lstReminder.Items[SelectedIndex].SubItems[3].Text;
            dtpDate.Text = txtboxDate.Text;
            if (rdobtnMeeting.Text == lstReminder.Items[SelectedIndex].SubItems[4].Text)
                rdobtnMeeting.Checked = true;
            else
                rdobtnTask.Checked = true;
        }

        private void btnUptade_Click(object sender, EventArgs e)
        {
            ReminderFilePath = @"data/" + MainWindow.username + "Reminder.csv";
            string type;
            if (rdobtnMeeting.Checked)
                type = rdobtnMeeting.Text;
            else
                type = rdobtnTask.Text;
            try
            {
                MeetingTaskReminder reminder = new MeetingTaskReminder(txtboxDate.Text, mtxtboxTime.Text, txtSummary.Text,
                    txtDescription.Text, type, MainWindow.username);
                var file = new List<string>(System.IO.File.ReadAllLines(ReminderFilePath));
                file.Insert(lstReminder.FocusedItem.Index, reminder.ReminderToCsv());
                file.RemoveAt(lstReminder.FocusedItem.Index + 1);
                System.IO.File.WriteAllLines(ReminderFilePath, file.ToArray());
                btnList_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Select a reminder for updating.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ReminderFilePath = @"data/" + MainWindow.username + "Reminder.csv";
                var file = new List<string>(System.IO.File.ReadAllLines(ReminderFilePath));
                file.RemoveAt(lstReminder.FocusedItem.Index);
                System.IO.File.WriteAllLines(ReminderFilePath, file.ToArray());
                btnList_Click(sender, e);
                mtxtboxTime.Text = "";
                txtSummary.Text = "";
                txtDescription.Text = "";
                rdobtnMeeting.Checked = false;
                rdobtnTask.Checked = false;
                dtpDate.ResetText();
                txtboxDate.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Select a reminder for deleting.");
            }
        }
    }
}