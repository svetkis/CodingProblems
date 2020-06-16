using CodingProblemsLib.Problems;
using NUnit.Framework;

namespace CodingProblemsTests
{
    public class TwoSumTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new[] {2, 7, 11, 15}, 9, new[] {0, 1})]
        [TestCase(new[] { 0, 0, 11, 15 }, 0, new[] { 0, 1 })]
        [TestCase(new[] { 5, 7, 4, 0 }, 7, new[] { 1, 3 })]
        public void Test(int[] nums, int target, int[] result)
        {
            Assert.AreEqual(TwoSum.Run(nums, target ), result);
        }
    }
}
