namespace MoneyProblemApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] currencyValue = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] currencyCount = MoneyMaker(547);
            for (int i = 0; i < currencyCount.Length; i++)
            {
                Console.WriteLine($"{(double)currencyValue[i]/100:C} {currencyCount[i]}");
            }
        }

        public static int[] MoneyMaker(int total)
        {
            if (total < 0) { throw new ArgumentException(); }

            int[] currencyValue = new int[] {200, 100, 50, 20, 10, 5, 2, 1};
            int[] currencyCount = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < currencyValue.Length; i++)
            {
                currencyCount[i] = total / currencyValue[i];
                total %= currencyValue[i];
            }

            if (total > 0) { throw new Exception(); }
            return currencyCount;
        }
    }
}