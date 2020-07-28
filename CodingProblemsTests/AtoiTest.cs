using CodingProblemsLib.Problems;
using Xunit;

namespace CodingProblemsTests
{
    public class AtoiTest
    {
        [Theory]
        [InlineData("   -42", -42)]
        [InlineData("4193 with words", 4193)]
        [InlineData("-91283472332", int.MinValue)]
        [InlineData("91283472332", int.MaxValue)]
        [InlineData("+1", 1)]
        [InlineData("2147483646", 2147483646)]
        [InlineData("0-1", 0)]

        public void Test(string input, int result)
        {
            Assert.Equal(result, Atoi.Convert(input));
        }
    }
}
