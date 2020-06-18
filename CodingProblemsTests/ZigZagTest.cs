using CodingProblemsLib.Problems;
using NUnit.Framework;

namespace CodingProblemsTests
{
    public class ZigZagTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [TestCase("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [TestCase("A", 1, "A")]
        [TestCase("PAYPALISHIRING", 1, "PAYPALISHIRING")]
        public void Test(string s, int rows, string result)
        {
            Assert.AreEqual(ZigZag.Convert(s, rows), result);
        }
    }
}
