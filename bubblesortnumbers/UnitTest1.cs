using System;
using Xunit;
using bubblesort;

namespace bubblesortnumbers
{
    public class UnitTest1
    {
        [Fact]
        public void BubbleSortAscendingNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int length = numbers.Count;

            Program.BubbleSortAscending(numbers, length);

            Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, numbers);
        }

        [Fact]
        public void BubbleSortAscendingNumbersFails()
        {
            List<int> numbers = new List<int> { 5, 4, 3, 2, 1 };
            int length = numbers.Count;

            Program.BubbleSortAscending(numbers, length);

            Assert.Equal(new List<int> { 1, 3, 2, 5, 4 }, numbers);
        }

        [Fact]
        public void BubbleSortDescendingNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int length = numbers.Count;

            Program.BubbleSortDescending(numbers, length);

            Assert.Equal(new List<int> { 5, 4, 3, 2, 1 }, numbers);
        }

        [Fact]
        public void BubbleSortDescendingNumbersFails()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int length = numbers.Count;

            Program.BubbleSortDescending(numbers, length);

            Assert.Equal(new List<int> { 5, 2, 4, 3, 1 }, numbers);
        }
    }
}
