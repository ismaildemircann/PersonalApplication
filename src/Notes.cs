using System;
using System.Collections;
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
    public partial class Notes : Form
    {
        public static string NotesFilePath;
        public Notes()
        {
            InitializeComponent();
        }

        private void Notes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.reallyWant2Exit(e);
        }

        private void btnMainWindow_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string value = Regex.Escape(txtnotes.Text);
            Note note = new Note(value, MainWindow.username);
            NotesFilePath = @"data/" + MainWindow.username + "Notes.csv";
            LoginForm.UserList[MainWindow.index].Notes.Add(note);
            Util.SaveCsv(note, NotesFilePath);
            txtnotes.Text = "";
            MessageBox.Show("Note registered", "Save", MessageBoxButtons.OK);
            btnList_Click(sender, e);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lstNotes.Items.Clear();
            NotesFilePath = @"data/" + MainWindow.username + "Notes.csv";
            Util.LoadCsv(LoginForm.UserList[MainWindow.index].Notes, NotesFilePath, MainWindow.username);
            for (int i = 0; i < LoginForm.UserList[MainWindow.index].Notes.Count; i++)
            {
                string str = LoginForm.UserList[MainWindow.index].Notes[i].Text;
                str = Regex.Unescape(str);
                ListViewItem itm = new ListViewItem(str);
                lstNotes.Items.Add(itm);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                NotesFilePath = @"data/" + MainWindow.username + "Notes.csv";
                var file = new List<string>(System.IO.File.ReadAllLines(NotesFilePath));
                file.RemoveAt(lstNotes.FocusedItem.Index);
                System.IO.File.WriteAllLines(NotesFilePath, file.ToArray());
                btnList_Click(sender, e);
                txtnotes.Text = "";
                btnList_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Select a note for deleting.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                NotesFilePath = @"data/" + MainWindow.username + "Notes.csv";
                Note note = new Note(txtnotes.Text, MainWindow.username);
                var file = new List<string>(System.IO.File.ReadAllLines(NotesFilePath));
                file.Insert(lstNotes.FocusedItem.Index, note.NoteToCsv());
                file.RemoveAt(lstNotes.FocusedItem.Index + 1);
                System.IO.File.WriteAllLines(NotesFilePath, file.ToArray());
                btnList_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Select an user for updating.");
            }
        }

        private void lstNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstNotes.FocusedItem.Index;
            var text = lstNotes.Items[index].Text;
            txtnotes.Text = text;
        }
    }
}
