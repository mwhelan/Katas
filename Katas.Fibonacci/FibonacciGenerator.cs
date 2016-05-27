namespace Katas.Fibonacci
{
    public class FibonacciGenerator
    {
        public int GetFibonacciValueFor(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            return (GetFibonacciValueFor(number - 1)) + (GetFibonacciValueFor(number - 2));
        }
    }
}