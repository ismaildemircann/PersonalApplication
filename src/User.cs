using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApplication
{
    public class User
    {
        private string Username;
        private string Password;
        private bool RememberMe;
        private string AdminControl;
        private string name;
        private string surname;
        private string phonenumber;
        private string address;
        private string e_Mail;
        private string photo;
        private double salary;
        public static List<Phone> phones = new List<Phone>();
        public static List<Note> note = new List<Note>();
        public static List<MeetingTaskReminder> reminders = new List<MeetingTaskReminder>();

        public User(string Username, string Password, bool RememberMe, string AdminControl,
            string name, string surname, string phonenumber, string address, string e_Mail, string photo, double salary)
        {
            this.Username = Username;
            this.Password = Password;
            this.RememberMe = RememberMe;
            this.AdminControl = AdminControl;
            this.name = name;
            this.surname = surname;
            this.phonenumber = phonenumber;
            this.address = address;
            this.e_Mail = e_Mail;
            this.photo = photo;
            this.salary = salary;
        }

        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
        public bool RememberMe1 { get => RememberMe; set => RememberMe = value; }
        public string Admin_Control { get => AdminControl; set => AdminControl = value; }
        public List<Phone> Phones { get => phones; set => phones = value; }
        public List<Note> Notes { get => note; set => note = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Address { get => address; set => address = value; }
        public string E_Mail { get => e_Mail; set => e_Mail = value; }
        public string Photo { get => photo; set => photo = value; }
        public double Salary { get => salary; set => salary = value; }
        public List<MeetingTaskReminder> Reminders { get => reminders; set => reminders = value; }

        public bool IsValid(string Username, string Password)
        {
            return this.Username.Equals(Username) && this.Password.Equals(Util.ComputeSha256Hash(Password));
        }
        public bool IsValid(string Username)
        {
            return this.Username.Equals(Username);
        }

        public string ToStringCsv()
        {
            return Username + "," + Password + "," + (RememberMe ? "1" : "0") + "," + AdminControl + ","
                + name + "," + surname + "," + phonenumber + "," 
                + address + "," + e_Mail + "," + photo + "," + salary;
        }

        public string ToStringTsv()
        {
            return Username + "\t" + Password + "\t" + (RememberMe ? "1" : "0") + "\t" + AdminControl + "\t"
                + name + "\t" + surname + "\t" + phonenumber + "\t"
                + address + "\t" + e_Mail + "\t" + photo + "," + salary;
        }
        public Memento Save()
        {
            return new Memento
            {
                Username1 = this.Username1,
                Password1 = this.Password1,
                Name = this.Name,
                Surname = this.Surname,
                Phonenumber = this.Phonenumber,
                Address = this.Address,
                E_Mail = this.E_Mail,
                Photo = this.Photo
            };
        }
        public void Undo(Memento memento)
        {
            this.Username1 = memento.Username1;
            this.Password1 = memento.Password1;
            this.Name = memento.Name;
            this.Surname = memento.Surname;
            this.Phonenumber = memento.Phonenumber;
            this.Address = memento.Address;
            this.E_Mail = memento.E_Mail;
            this.Photo = memento.Photo;
        }
    }
    public class Memento
    {
        private string Username;
        private string Password;
        private string name;
        private string surname;
        private string phonenumber;
        private string address;
        private string e_Mail;
        private string photo;
        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Address { get => address; set => address = value; }
        public string E_Mail { get => e_Mail; set => e_Mail = value; }
        public string Photo { get => photo; set => photo = value; }
    }
    class Memory
    {
        public Memento ProductMemento { get; set; }
    }
}
