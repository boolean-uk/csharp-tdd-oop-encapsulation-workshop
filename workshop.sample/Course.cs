using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.sample
{
    public class Course
    {
        private string _name;
        private Teacher _courseTeacher;
        private List<Student> _students = new List<Student>();

        public Course(string courseName, Teacher teacher)
        {
            _name = courseName;
            _courseTeacher = teacher;
            
        }

        public string Name { get => _name;  }
        public Teacher CourseTeacher { get => _courseTeacher; set => _courseTeacher = value; }
        public List<Student> Students { get => _students; }

    }
}
