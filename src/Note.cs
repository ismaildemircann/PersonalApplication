using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApplication
{
    public class Note
    {
        private string text;
        private string owner;

        public string Text { get => text; set => text = value; }

        public Note(string Text,string owner)
        {
            this.text = Text;
            this.owner = owner;
        }
        public string NoteToCsv()
        {
            return owner + "," + Text;
        }
    }
}
