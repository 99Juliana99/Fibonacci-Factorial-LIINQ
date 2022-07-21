using System;
using System.Collections.Generic;

namespace L3
{
    class Program
    {
        static void Main(string[] args)
        {
            FactorialLinq factorial = new FactorialLinq();
            string nString1 = Console.ReadLine();
            int n1 = int.Parse(nString1);
            int resultFactorial = factorial.Calculate(n1);
            Console.WriteLine(resultFactorial);

            FibonacciLinq fibonacci = new FibonacciLinq();
            string nString2 = Console.ReadLine();
            int n2 = int.Parse(nString2);
            IEnumerable<uint> resultFibonacci = fibonacci.Calculate(n2);
            Console.WriteLine(resultFibonacci);
        }
    }
}
