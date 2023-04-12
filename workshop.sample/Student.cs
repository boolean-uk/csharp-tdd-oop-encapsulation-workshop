using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.sample
{
    public class Student
    {
        private string _subject = "C#";

        public string Name { get; set; }
        public string Subject { get { return _subject;  } set { _subject = value; } }

        public string FavDrink()
        {
            return "Beer";
        }
    }
}
