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
            string choice = string.Empty;
            while(running)
            {
                Console.WriteLine("Enter your choice...");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "q":
                    case "Q":
                        Stop();
                        break;
                    default:
                        break;
                }
            }

        }

        private void Stop()
        {
            running = false;
        }
    }
}
