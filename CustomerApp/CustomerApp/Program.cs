using System;

internal class Program
{
    static void Main(string[] args)
    {
        Person person;
        Random rand = new Random();
        int myRandomInt = rand.Next(0, 2);
        if (myRandomInt == 0)
        {
            person = new Customer("Joyti", "Sureh", "London bridge");
        }
        else
        {
            person = new Employee("Minato", "Fujiwara", "Marketing");
        }
        

     
        person.Print();
    }
}
