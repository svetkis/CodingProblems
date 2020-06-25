using CodingProblemsLib.Problems;
using Xunit;

namespace CodingProblemsTests
{
    public class LongestPalindromeTest
    {
        [Theory]
        [InlineData("aaaa", new[] { "aaaa" })]
        [InlineData("bbbbb", new[] { "bbbbb" })]
        [InlineData("abcabcbb", new[]{ "bcb" })]
        [InlineData("babad", new[] { "bab", "aba"})]
        [InlineData("cbbd", new[] { "bb" })]
        [InlineData("a", new[] { "a" })]
        public void Test(string s, string[] possibleResults)
        {
            string result = LongestPalindrome.Run(s);
            Assert.Contains(possibleResults, str => str == result);
        }
    }
}
