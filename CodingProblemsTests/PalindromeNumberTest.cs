using System;
using System.Collections.Generic;
using System.Text;
using CodingProblemsLib.Problems;
using Xunit;

namespace CodingProblemsTests
{
    public class PalindromeNumberTest
    {
        [Theory]
        [InlineData(012, false)]
        [InlineData(121, true)]
        [InlineData(1210, false)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        public void Test(int input, bool expected)
        {
            bool result = PalindromeNumber.IsPalindrome(input);
            Assert.Equal(expected, result);
        }
    }
}
