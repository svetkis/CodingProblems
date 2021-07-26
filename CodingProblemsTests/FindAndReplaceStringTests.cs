using CodingProblemsLib.Problems;
using Xunit;

namespace CodingProblemsTests
{
    public class FindAndReplaceStringTests
    {
        [Theory]
        [InlineData("abcd", new [] { 0, 2}, new [] { "a", "cd"}, new [] {"eee", "ffff"}, "eeebffff")]
        public void Test(string s, int[] indices, string[] sources, string[] targets, string result)
        {
            Assert.Equal(FindAndReplaceInString.Run(s, indices, sources, targets), result);
        }
    }
}
