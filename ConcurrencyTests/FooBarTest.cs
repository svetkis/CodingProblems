using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Concurrency;
using Xunit;
using Xunit.Abstractions;

namespace ConcurrencyTests
{
    public class FooBarTest
    {
        private readonly ITestOutputHelper _output;

        public FooBarTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory]
        [InlineData(100)]
        public void Test(int n)
        {
            string r = string.Join("", Enumerable.Range(0, n*2).Select(i => i % 2 == 0 ? "foo" : "bar"));

            var fooBar = new FooBar(n);

            TextWriter tw = new StringWriter();

            CancellationTokenSource cts = new CancellationTokenSource(5000);
            ParallelOptions options = new ParallelOptions {CancellationToken = cts.Token};

            Parallel.ForEach(Enumerable.Range(0, 2), options, i =>
            {
                if (i % 2 == 0)
                    fooBar.Foo(() => tw.Write("foo"));
                else
                    fooBar.Bar(() => tw.Write("bar"));
            });

            string result = tw.ToString();
            Assert.True(0 == r.CompareTo(result));
        }
    }
}
