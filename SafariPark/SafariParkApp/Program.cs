namespace SafariParkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person phil = new Person("phil", "Windridge", 28);
            Console.WriteLine(phil.FullName);

            //Person laura = new Person("Laura");
            //Console.WriteLine(laura.GetFullName());

            phil.Age = 54;
            Console.WriteLine($"Phil is actually {phil.Age}");

            var cathy = new Person("Cathy") { Age = 21 };

            var list = new ShoppingList() { Bread = 2, Potato = 6, Milk = 2 };
            Console.WriteLine();

            var jo = new Person() { FirstName = "Joseph", LastName = "McCann", Age = 25 };
        }
    }
}