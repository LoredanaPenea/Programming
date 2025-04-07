using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP
{
    public class Person
    {
        private string firstName;
        private string lastName;
        protected int age;

        public string FirstName
        {
            get { return firstName; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First Name can not be empty!");
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last Name can not be empty!");
                lastName = value;
            }
        }

        public Person() { }
       
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FullName()
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }

        public void SetAge(int ageNr)
        {
          if (ageNr <= 0 )
              throw new ArgumentException("Please enter a valid number, greater than 0!");
          age = ageNr;
            
        }

        public int GetAge()
        {
            return age;
        }


    }
}
