namespace Katas.FibonacciSequence.Code
{
    public class FibonacciGenerator
    {
        public int GetNumberFor(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            return (GetNumberFor(number - 1)) + (GetNumberFor(number - 2));
        }
    }
}