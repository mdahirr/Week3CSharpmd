using System.Globalization;

namespace BubbleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 1, 8, 2, 7, 3, 6, 4, 6 };
            int[] array2 = { 9, 3, 35, 3, 2, 23, 54, 65, 3, };

            int[] sorted1 = BubbleSort(array);
            int[] sorted2 = BubbleSort(array2);

            int[] mergedArray = MergeArray(sorted1, sorted2);

            foreach (var item in mergedArray)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
            return array;
        }

        public static int[] MergeArray(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length + array2.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i];
            }
            for (int j = 0; j < array2.Length; j++)
            {
                result[j + array1.Length] = array2[j];
            }

            return BubbleSort(result);
        }

    }
}