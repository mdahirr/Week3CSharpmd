namespace MoneyProblemApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] currency = { 2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };
            

            int[] currencyCount = MoneyMaker(5.47, currency);
            for (int i = 0; i < currency.Length; i++)
            {
                Console.WriteLine($"{currency[i]:C} {currencyCount[i]}");
            }
        }

        public static int[] MoneyMaker(double total, double[] currencyValue) 
        {
            int[] CurrencyCount = { 0, 0, 0, 0, 0, 0, 0, 0};

            for (int i = 0; i < CurrencyCount.Length; i++)
            {
                
                while (total >= currencyValue[i])
                {
                    CurrencyCount[i]++;
                    total -= currencyValue[i];
                }
            }

            return CurrencyCount;
        }
    }
}