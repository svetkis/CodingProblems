using CodingProblems.Problems;
using NUnit.Framework;

namespace CodingProblemsTests
{
   public class FindMedianSortedArraysTest
   {
      [SetUp]
      public void Setup()
      {
      }

      [Test]
      [TestCase(new[] { 1,3,5,6 }, new[] { 1, 3, 5, 6 }, 4.0)]
      [TestCase(new[] { 1, 3}, new[] { 2 }, 2.0)]
      [TestCase(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
      [TestCase(new[] { 1, 12, 15, 26, 38 }, new[] { 2, 13, 17, 30, 45 }, 16.0)]
      public void Test(int[] arr1, int[] arr2, double result)
      {
          Assert.AreEqual(FindMedianSortedArrays.Run(arr1, arr2), result);
      }
   }
}