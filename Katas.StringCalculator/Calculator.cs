using System;
using System.Linq;

namespace Katas.StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            char[] delimiters;
            if (numbers.StartsWith("//"))
            {
                delimiters = new char[]{numbers[2]};
                numbers = numbers.Substring(4);
            }
            else
            {
                delimiters = new char[]{',','\n'};
            }
            var strings = numbers
                .Split(delimiters)
                .Select(int.Parse);

            if (strings.Any(x => x <0))
            {
                throw new ArgumentOutOfRangeException();
            }

            return strings
                .Where(x => x <= 1000)
                .Sum(x => x);
        }
    }
}