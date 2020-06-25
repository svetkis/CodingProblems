using CodingProblems.Problems;
using Xunit;

namespace CodingProblemsTests
{
    public class LengthOfLongestSubstringTest
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void Test(string s, int maxLen)
        {
            Assert.Equal(LengthOfLongestSubstring.Run(s), maxLen);
        }
    }
}
