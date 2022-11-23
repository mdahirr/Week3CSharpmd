namespace SafariParkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person phil = new Person("phil", "Windridge", 28);
            Console.WriteLine(phil.GetFullName());

            //Person laura = new Person("Laura");
            //Console.WriteLine(laura.GetFullName());

            phil.Age = 54;
            Console.WriteLine($"Phil is actually {phil.Age}");

        }
    }
}