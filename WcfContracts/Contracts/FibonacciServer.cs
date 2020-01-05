using System;
using System.Collections.Generic;
using System.Text;

namespace WcfContracts.Contracts
{
    public class FibonacciServer : ISequenceServer
    {
        private List<Int32> _row = new List<Int32> { 1, 1 };
        private Int32 _cursor = 0;

        public int Current()
        {
            if (_cursor < 2)
            {
                return 1;
            }

            return _row[_cursor];
        }

        public int Next()
        {
            if (_cursor == 0)
            {
                return Current();
            }

            Int32 newValue = _row[_cursor - 1] + _row[_cursor];
            _row.Add(newValue);

            return _row[++_cursor];
        }

        public void Reset()
        {
            _row = new List<int> { 1, 1 };
        }
    }
}
