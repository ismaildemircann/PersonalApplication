using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApplication
{
    public class Phone
    {
        private string name;
        private string surname;
        private string phonenumber;
        private string address;
        private string description;
        private string e_Mail;
        private string owner;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Address { get => address; set => address = value; }
        public string Description { get => description; set => description = value; }
        public string E_Mail { get => e_Mail; set => e_Mail = value; }
        public string Owner { get => owner; set => owner = value; }

        public Phone(string Name, string Surname, string Phonenumber, string Address, string Description, string E_Mail, string owner)
        {
            this.name = Name;
            this.surname = Surname;
            this.phonenumber = Phonenumber;
            this.address = Address;
            this.description = Description;
            this.e_Mail = E_Mail;
            this.owner = owner;
        }

        public string PhoneToCsv()
        {
            return Name + "," + Surname + "," + Phonenumber + "," + Address + "," + Description + "," + E_Mail + "," + owner;
        }
    }
}
