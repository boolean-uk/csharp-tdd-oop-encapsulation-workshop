using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.sample
{
    public class Teacher
    {
  
        private DateTime _dateOfBirth;
        private string firstName;


        /// <summary>
        /// Method to calculate age using private member
        /// </summary>
        /// <returns>returns int age</returns>
        public int Age()
        {
            //return 48;
            int age = DateTime.Now.Year - _dateOfBirth.Year;  
            return (_dateOfBirth > DateTime.Now.AddYears(-age)) ? age -- : age;                        
        }
        public int Age(bool letLieAboutMyAge)
        {
            if(letLieAboutMyAge)
            {
                return 31;
            }
            else
            {
                int result = Age();
                return result;

            }
        }
        
        public DateTime Dob { get { return _dateOfBirth;} set { _dateOfBirth = value; } }
        public string FirstName { get => firstName.ToUpper(); set => firstName = value; }
    }
}
