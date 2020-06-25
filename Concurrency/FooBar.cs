using System;
using System.Threading;

namespace Concurrency
{
    public class FooBar
    {
        private readonly int _n;

        public FooBar(int n)
        {
            _n = n;
        }

        private readonly EventWaitHandle _waitFoo = new AutoResetEvent(false);
        private readonly EventWaitHandle _waitBar = new AutoResetEvent(true);

        public void Foo(Action printFoo)
        {
            for (int i = 0; i < _n; ++i)
            {
                _waitBar.WaitOne();

                printFoo();

                _waitBar.Reset();
                _waitFoo.Set();
            }
        }

        public void Bar(Action printBar)
        {
            for (int i = 0; i < _n; ++i)
            {
                _waitFoo.WaitOne();

                printBar();

                _waitFoo.Reset();
                _waitBar.Set();
            }
        }
    }
}
