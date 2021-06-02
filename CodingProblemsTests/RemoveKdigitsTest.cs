using CodingProblemsLib.Problems;
using Xunit;

namespace CodingProblemsTests
{
    public class RemoveKdigitsTest
    {
        [Theory]
        [InlineData("10", 1, "0")]
        [InlineData("112", 1, "11")]
        [InlineData("10001", 4, "0")]
        [InlineData("111111", 3, "111")]
        [InlineData("12345", 2, "123")]
        [InlineData("512345", 2, "1234")]
        public void Test(string num, int digitCount, string result)
        {
            Assert.Equal(result, RemoveKDigits.RemoveKdigits(num, digitCount));
        }
    }
}
