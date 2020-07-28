using CodingProblemsLib.Problems;
using Xunit;

namespace CodingProblemsTests
{
    public class RemoveDuplicatesFromSortedArrayTest
    {
        [Theory]
        [InlineData(new[]{ 1,1,2 }, new[] { 1, 2 })]
        [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new[] { 0, 1, 2, 3, 4 })]
        [InlineData(new int[0], new int[0])]
        public void Test(int[] input, int[] result)
        {
            int count = RemoveDuplicatesFromSortedArray.RemoveDuplicates(input);
            Assert.Equal(result.Length, count);
            for (int i = 0; i <  count; ++i)
            {
                Assert.Equal(input[i], result[i]);
            }
        }
    }
}
