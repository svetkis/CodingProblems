using CodingProblemsLib.Problems;
using Xunit;

namespace CodingProblemsTests
{
    public class ReverseIntegerTest
    {
        [Theory]
        [InlineData(123,321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(1534236469, 0)]
        [InlineData(-1534236469, 0)]
        public void Test(int input, int result)
        {
            Assert.Equal(result, ReverseInteger.Reverse(input));
        }
    }
}
