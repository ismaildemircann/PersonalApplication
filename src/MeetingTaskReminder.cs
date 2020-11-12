using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApplication
{
    public class MeetingTaskReminder
    {
        private string date;
        private string time;
        private string summary;
        private string description;
        private string type;
        private string owner;

        public MeetingTaskReminder(string date, string time, string summary, string description, string type, string owner)
        {
            this.date = date;
            this.time = time;
            this.summary = summary;
            this.description = description;
            this.type = type;
            this.owner = owner;
        }

        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public string Summary { get => summary; set => summary = value; }
        public string Description { get => description; set => description = value; }
        public string Owner { get => owner; set => owner = value; }
        public string Type { get => type; set => type = value; }

        public string ReminderToCsv()
        {
            return Date + "," + Time + "," + Summary + "," + Description + "," + Type + "," + Owner;
        }
    }
}
