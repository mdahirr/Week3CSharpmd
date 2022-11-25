namespace SafariParkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person phil = new Person("phil", "Windridge", 28);
            //Console.WriteLine(phil.FullName);

            ////Person laura = new Person("Laura");
            ////Console.WriteLine(laura.GetFullName());

            //phil.Age = 54;
            //Console.WriteLine($"Phil is actually {phil.Age}");

            //var cathy = new Person("Cathy") { Age = 21 };

            //var list = new ShoppingList() { Bread = 2, Potato = 6, Milk = 2 };
            //Console.WriteLine();

            //var jo = new Person() { FirstName = "Joseph", LastName = "McCann", Age = 25 };

            //Point3D p = new Point3D(3, 6, 2);
            //var p2 = new Point3D();

            //Point3D p3;
            //p3.x = 3;
            //p3.y = 6;
            //p3.z = 2;

            //Point3D p4 = new Point3D(1, 7);

            //static void DemoMethod(Point3D pt, Person p)
            //{
            //    pt.y = 1000;
            //    p.Age = 92;
            //}



            //Person john = new Person("John", "Jones") { Age = 20 };
            //Point3D pt3D = new Point3D(5, 8, 2);
            //DemoMethod(pt3D, john);

            //   ***INHERITANCE***

            //Hunter james = new Hunter("James", "Grafton", "Nikon") { Age = 21 };
            //Console.WriteLine(james.Shoot());
            //Console.WriteLine(james.Age);

            //var david = new Hunter("David", "Williams", "Cannon") { Age = 18 };
            //Console.WriteLine($"james Equals david? {james.Equals(david)}");
            //Console.WriteLine($"james HashCode? {james.GetHashCode()}");
            //Console.WriteLine($"david Type? {david.GetType()}");
            //Console.WriteLine($"david ToString? {david.ToString()}"); // ToString() returns <namespace>.<class>


            //Console.WriteLine($"david ToString? {david}");

            //    Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 }; 
            //    a.Ascend(500); 
            //    Console.WriteLine(a.Move(3)); 
            //    Console.WriteLine(a); a.Descend(200);
            //    Console.WriteLine(a.Move()); a.Move(); 
            //    Console.WriteLine(a);

            // **** Collections ****

            //var helen = new Person { FirstName = "Helen", LastName = "Troy", Age = 22 };
            //var will = new Hunter { FirstName = "William", LastName = "Shakespeare", Age = 457 };
            //Console.WriteLine("List of people");
            //List<Person> thePeople = new List<Person> { helen, will };

            //foreach (var person in thePeople)
            //{
            //    Console.WriteLine(person);
            //}
            //Console.WriteLine();

            // **** LIST ****
            //List<int> numbers = new List<int>() { 5, 4, 3, 9, 0 };
            //numbers.Add(8);
            //numbers.Sort();
            //numbers.RemoveRange(1, 2);
            //numbers.Insert(2, 1);
            //numbers.Reverse();
            //numbers.Remove(9);

            //foreach (var num in numbers)
            //{
            //    Console.Write(num + " ");
            //}

            // **** LINKED LIST ****

            //Console.WriteLine("LinkedList of people");
            //LinkedList<Person> thePeopleLinked = new LinkedList<Person>();
            //thePeopleLinked.AddFirst(helen);
            //thePeopleLinked.AddLast(will);
            //thePeopleLinked.AddLast(new Person { FirstName = "Linda", LastName = "Smith", Age = 45 });

            //foreach (var person in thePeopleLinked)
            //{
            //    Console.WriteLine(person);
            //}

            // **** QUEUE - FIRST IN FIRST OUT ****

            //var myQueue = new Queue<Person>();
            //myQueue.Enqueue(helen);
            //myQueue.Enqueue(will);
            //myQueue.Enqueue(new Person("Cathy"));
            //Console.WriteLine("\nQueue");
            //foreach (var q in myQueue)
            //{
            //    Console.WriteLine(q);
            //}
            //var first = myQueue.Peek();
            //var serve = myQueue.Dequeue();

            //foreach (var q in myQueue)
            //{
            //    Console.WriteLine(q);
            //}


            // **** STACK - FIRST IN LAST OUT ****

            //int[] original = new int[] { 1, 2, 3, 4, 5 };
            //int[] reversed = new int[original.Length];
            //var stack = new Stack<int>();
            //foreach (var n in original)
            //{
            //    stack.Push(n);
            //}
            //// write out the stackConsole.WriteLine("\nStack");
            //foreach (var s in stack)
            //{
            //    Console.WriteLine(s);
            //}

            //for (int i = 0; i < original.Length; i++)
            //{
            //    reversed[i] = stack.Pop();
            //}

            //foreach (var s in reversed)
            //{
            //    Console.WriteLine(s);
            //}

            var theBeatles = new Dictionary<int, string>() { { 2, "Paul" }, { 3, "Ringo" }, { 1, "John" }, { 4, "George" } };
            var isAdded = theBeatles.TryAdd(3, "Laura");
            var beatlesList = theBeatles.Values.ToList();
            var c = theBeatles.Remove(1);
            var d = theBeatles.Keys.Where(x => x % 2 == 0).Sum();



            Console.WriteLine(isAdded);



            foreach (var el in beatlesList)
            {
                Console.WriteLine(el);
            }
        }
    }
}