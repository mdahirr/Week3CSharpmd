using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    internal class Person
    {
        private string _firstName = "";
        private string _lastName = " ";
        private string _age;


        public Person(string firstName, string lastName, int age = 0)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
        }



        public int Age { get; set; }



        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
