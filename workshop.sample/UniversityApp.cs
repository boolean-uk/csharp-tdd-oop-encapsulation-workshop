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
        public UniversityApp()
        {

            //instance a course - needs name + teacher



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
            Console.WriteLine("Welcome to University App");
            Console.WriteLine("1: Add student to course");
            Console.WriteLine("q: quit");

        }
        private void FirstChoice()
        {
            Console.WriteLine("Enter Student Name");
            Student student = new Student();
            student.Name = Console.ReadLine();


        }
        private void Stop()
        {
            running = false;
        }
    }
}
