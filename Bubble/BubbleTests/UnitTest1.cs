using BubbleApp;

namespace BubbleTests
{
    public class Tests
    {
        [TestCase(new int[] { 4, 5, 7, 8, 1, 2, 9, 3, 6}, new int[] {1,2,3,4,5,6,7,8,9})]
        public void GivenAnArrayBubbleSortReturnsASortArray(int[] array, int[] sortedArray)
        {
            Assert.That(sortedArray, Is.EqualTo(Program.BubbleSort(array)));
        }

        [TestCase(new int[] { 4,1,3,2 }, new int[] {7,5,8,6,9 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        public void GivenTwoArraysMergeArraysWillMergeThem(int[] array1, int[] array2, int[] mergedArray)
        {
            Assert.That(mergedArray, Is.EqualTo(Program.MergeArray(array1, array2)));
        }  
        
    }
}