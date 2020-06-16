using CodingProblems.Problems;
using NUnit.Framework;

namespace CodingProblemsTests
{
    public class LengthOfLongestSubstringTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        public void Test(string s, int maxLen)
        {
            Assert.AreEqual(LengthOfLongestSubstring.Run(s), maxLen);
        }
    }
}
