using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    internal class Person
    {
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (Age < 0)
                {
                    throw new ArgumentException();
                }
                _age = value;
            }
        }
        public string FirstName { get; init; } = "";
        public string LastName { get; init; } = "";


        public Person(string firstname)
        {
            FirstName = firstname;
        }

        public Person(string firstName, string lastName, int age = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person()
        {

        }

        public string FullName => $"{FirstName} {LastName}";
    }
}
