using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.sample
{
    public class Teacher
    {
        private string _firstName;
        private DateTime _dob;
       

        /// <summary>
        /// Method to calculate age using private member
        /// </summary>
        /// <returns>returns int age</returns>
        public int Age()
        {
            int age = DateTime.Now.Year - _dob.Year;  
            return (_dob > DateTime.Now.AddYears(-age)) ? age -- : age;                        
        }
        
        public DateTime Dob { get { return _dob;} set { _dob = value; } }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
    }
}
