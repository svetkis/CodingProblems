using System.Linq;
using CodingProblemsLib.Problems;
using NUnit.Framework;

namespace CodingProblemsTests
{
    public class LongestPalindromeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("aaaa", new[] { "aaaa" })]
        [TestCase("bbbbb", new[] { "bbbbb" })]
        [TestCase("abcabcbb", new[]{ "bcb" })]
        [TestCase("babad", new[] { "bab", "aba"})]
        [TestCase("cbbd", new[] { "bb" })]
        [TestCase("a", new[] { "a" })]
        public void Test(string s, string[] possibleResults)
        {
            string result = LongestPalindrome.Run(s);
            Assert.AreEqual(possibleResults.Any(str => str == result), true);
        }
    }
}
