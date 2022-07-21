using System.Collections.Generic;
using System.Linq;

namespace L3
{
    public class FactorialLinq
    {
        public int Calculate(int n)
        {
            IEnumerable<int> ints = Enumerable.Range(1, n);
            int factorial = ints.Aggregate((f, s) => f * s);
            return factorial;
        }
    }
}
