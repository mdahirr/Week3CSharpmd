using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    internal class Person : IEquatable<Person?>, IComparable<Person>
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

        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return other is not null &&
                   Age == other.Age &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Age, FirstName, LastName);
        }

        public int CompareTo(Person? other)
        {
            if (other == null) return 1;
            if (LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            else if (FirstName != other.FirstName)
            {
                return FirstName.CompareTo(other.FirstName);
            }
            else { return Age.CompareTo(other.Age); };
        }

        public static bool operator ==(Person? left, Person? right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person? left, Person? right)
        {
            return !(left == right);
        }
    }
}
