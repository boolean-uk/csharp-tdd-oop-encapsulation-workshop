using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.sample
{
    public class UniversityApp
    {
        private bool running = true;
        private Course course;
        public UniversityApp()
        {

            //instance a course - needs name + teacher
            course = new Course("C#", new Teacher() { FirstName = "Nigel" });


            string choice = string.Empty;
            while(running)
            {
                Console.Clear();
                MainMenu();
                Console.WriteLine("Enter your choice...");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"you entered 1");
                        FirstChoice();
                        break;
                    case "q":
                        Stop();
                        break;
                    case "Q":
                        Stop();
                        break;
                    default:
                        Console.WriteLine("you didnt enter anything??");
                        break;
                }
            }

        }

        private void MainMenu()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Welcome to University App");
            Console.WriteLine($"The current course is: {course.Name}");

            ShowStudents();

            Console.WriteLine("1: Add student to course");
            Console.WriteLine("q: quit");

        }

        private void ShowStudents()
        {
            if (course.Students.Any())
            {
                Console.WriteLine($"Students on the course:");
                foreach (Student student in course.Students)
                {
                    Console.WriteLine($"--Name:{student.Name}");
                }

            }
        }

        private void FirstChoice()
        {

            Console.WriteLine("Enter Student Name");
            
            Student student = new Student();
            student.Name = Console.ReadLine();

            course.Students.Add(student);

        }
        private void Stop()
        {
            running = false;
        }
    }
}
