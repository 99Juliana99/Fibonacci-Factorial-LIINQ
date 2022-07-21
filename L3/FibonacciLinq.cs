using System.Collections.Generic;
using System.Linq;

namespace L3
{
    public class FibonacciLinq
    {
        public IEnumerable<uint> Calculate(int n)
        {
            uint ord1 = 0, ord2 = 0, ord3 = 0;
            IEnumerable<uint> sequence = Enumerable.Range(1, n).Select(a =>
            {
                ord1 = a == 1 ? 0 : ord2;
                ord2 = a == 1 ? 1 : ord3;
                ord3 = a == 1 ? 0 : ord1 + ord2;
                return ord3;
            });
            return sequence;
        }
    }
}
