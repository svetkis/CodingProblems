using CodingProblemsLib.Problems;
using Xunit;

namespace CodingProblemsTests
{
    public class TwoSumTest
    {
        [Theory]
        [InlineData(new[] {2, 7, 11, 15}, 9, new[] {0, 1})]
        [InlineData(new[] { 0, 0, 11, 15 }, 0, new[] { 0, 1 })]
        [InlineData(new[] { 5, 7, 4, 0 }, 7, new[] { 1, 3 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        public void Test(int[] nums, int target, int[] result)
        {
            Assert.Equal(TwoSum.Run(nums, target ), result);
        }

        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new[] { 0, 0, 11, 15 }, 0, new[] { 0, 1 })]
        [InlineData(new[] { 5, 7, 4, 0 }, 7, new[] { 1, 3 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        public void TestTwoSumFast(int[] nums, int target, int[] result)
        {
            Assert.Equal(TwoSum.RunHashTableSolution(nums, target), result);
        }
    }
}
