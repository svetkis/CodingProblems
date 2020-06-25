using CodingProblemsLib.Problems;
using Xunit;

namespace CodingProblemsTests
{
    public class ZigZagTest
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("A", 1, "A")]
        [InlineData("PAYPALISHIRING", 1, "PAYPALISHIRING")]
        public void Test(string s, int rows, string result)
        {
            Assert.Equal(ZigZag.Convert(s, rows), result);
        }
    }
}
