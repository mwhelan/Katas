using System;

namespace Katas.FibonacciSequence.Code
{
    public class FibonacciGeneratorLoop
    {
        public int GetNumberFor(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;

                Console.WriteLine("i={0}, temp={1}, a (returned) ={2}, b={3}", i, temp, a, b);
            }
            return a;
        }
    }
}