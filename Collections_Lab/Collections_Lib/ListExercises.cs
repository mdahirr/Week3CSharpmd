using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {

            List<int> numbers = new List<int>();
            for (int i = 0; i <= max; i++)
            {
                if ( i == 0)
                {
                    numbers.Add(0);
                }    
                else if (i % 5 == 0)
                {
                    numbers.Add(i);
                }
                
                
            }
            foreach (var item in numbers)
            {
                Console.Write(item);
            }
            
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> output = new List<string>();

            foreach (var item in sourceList) 
            {
                if (item.StartsWith('A'.ToString()));
                {
                    output.Add(item);
                }
            }
            return output;
        }
    }
}
