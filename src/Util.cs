using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalApplication
{
    public static class Util
    {
        public static bool flag = true;
        public static string ComputeSha256Hash(string rawData)  
        {  
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())  
            {  
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  
  
                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();  
                for (int i = 0; i < bytes.Length; i++)  
                {  
                    builder.Append(bytes[i].ToString("x2"));  
                }  
                return builder.ToString();  
            }  
        }

        public static string GetBase64StringForImage(string imgPath)
        {
            try
            {
                byte[] imageBytes = System.IO.File.ReadAllBytes(imgPath);
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static Image Base64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    Image image = Image.FromStream(ms, true);
                    return image;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static void LoadCsv(List<User> userlist, string csvPath)
        {
            try
            {
                userlist.Clear();
                using (var reader = new StreamReader(csvPath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        var values = line.Split(',');
                        string username = values[0];
                        string password = values[1];
                        bool rememberMe = values[2].Equals("1") ? true : false;
                        string admin = values[3];
                        string name = values[4];
                        string surname = values[5];
                        string phonenumber = values[6];
                        string address = values[7];
                        string e_Mail = values[8];
                        string photo = values[9];
                        double salary = double.Parse(values[10]);
                        userlist.Add(new User(username, password, rememberMe, admin, name, surname, phonenumber, address, e_Mail, photo, salary));
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be read:");
            }
        }

        public static void LoadCsv(List<Phone> phones, string csvPath, string OwnerControl)
        {
            try
            {
                phones.Clear();
                using (var reader = new StreamReader(csvPath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        var values = line.Split(',');
                        string name = values[0];
                        string surname = values[1];
                        string phonenumber = values[2];
                        string address = values[3];
                        string description = values[4];
                        string e_mail = values[5];
                        string owner = values[6];
                        if (OwnerControl == owner)
                        {
                            phones.Add(new Phone(name, surname, phonenumber, address, description, e_mail, owner));
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be read:");
            }
        }

        public static void LoadCsv(List<Note> notes, string csvPath, string OwnerControl)
        {
            try
            {
                notes.Clear();
                using (var reader = new StreamReader(csvPath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string text = "";
                        int i = 0;
                        string owner = "";
                        while (line[i] != ',')
                        {
                            owner += line[i];
                            i++;
                        }
                        i++;
                        while (i != line.Length) 
                        {
                            text += line[i];
                            i++;
                        }
                        if (OwnerControl == owner)
                        {
                            notes.Add(new Note(text, owner));
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be read:");
            }
        }
        public static void LoadCsv(List<MeetingTaskReminder> reminders, string csvPath, string OwnerControl)
        {
            try
            {
                reminders.Clear();
                using (var reader = new StreamReader(csvPath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        var values = line.Split(',');
                        string date = values[0];
                        string time = values[1];
                        string summary = values[2];
                        string description = values[3];
                        string type = values[4];
                        string owner = values[5];
                        if (OwnerControl == owner)
                        {
                            reminders.Add(new MeetingTaskReminder(date, time, summary, description, type  ,owner));
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be read:");
            }
        }
        public static void SaveCsv(List<User> userlist, string csvPath)
        {
            try
            {
                using (var writer = new StreamWriter(csvPath))
                {
                    foreach (User user in userlist)
                    {
                        writer.WriteLine(user.ToStringCsv());
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be write:");
            }
        }

        public static void SaveCsv(Phone Phone, string csvPath)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(csvPath))
                {
                    writer.WriteLine(Phone.PhoneToCsv());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be write:");
            }
        }

        public static void SaveCsv(Note note , string csvPath)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(csvPath))
                {
                    writer.WriteLine(note.NoteToCsv());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be write:");
            }
        }
        public static void SaveCsv(MeetingTaskReminder reminder, string csvPath)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(csvPath))
                {
                    writer.WriteLine(reminder.ReminderToCsv());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be write:");
            }
        }

        public static void SaveTsv(List<User> userlist, string FileName)
        {
            try
            {
                using (var writer = new StreamWriter(FileName))
                {
                    foreach (User user in userlist)
                    {
                        writer.WriteLine(user.ToStringTsv());
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be write:");
            }
        }
        public static void Shake(Form form)
        {
            Point original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 70; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
            flag = true;
        }

        public static void RingRing()
        {
            Util.LoadCsv(LoginForm.UserList[MainWindow.index].Reminders, Reminder.ReminderFilePath, MainWindow.username);
            string dateandtime = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
            foreach (var item in LoginForm.UserList[MainWindow.index].Reminders)
            {
                if (dateandtime == item.Date + " " + item.Time+":00")
                {                 
                    flag = false;
                    if (Form.ActiveForm.Text == "Login")
                        break;
                    Util.Shake(Form.ActiveForm);
                    Form.ActiveForm.Text = item.Summary;
                    break;
                }
            }
        }

        public static void reallyWant2Exit(FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Really want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
                e.Cancel = true;
        }
    }
}
