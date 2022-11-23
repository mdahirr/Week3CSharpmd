namespace FizzBuzzApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int max = 30;
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine($"{ FizzBuzz(i)}");

            }
        }

        public static string FizzBuzz(int i)
        {   
            if ( i % 3 == 0 && i % 5 ==0)
            {
                return "FizzBuzz";
            }
            else if ( i % 3 == 0 )
            {
                return "Fizz";
            }
            else if ( i % 5 == 0 )
            {
                return "Buzz";
            }
            else
            {
                return i.ToString();
            }
            
        }

       
    }
}