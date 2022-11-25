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
        private string _firstName;
        private string _lastName;
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

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

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

        public string GetFullName() => $"{_firstName} {_lastName}";

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }
    }
}
