namespace Katas.FizzBuzz
{
    public class FizzBuzzer
    {
        public string GetFizzBuzzValueFor(int number)
        {
            if (NumberDivisbleBy(3,number) && NumberDivisbleBy(5, number))
            {
                return "FizzBuzz";
            }
            if (NumberDivisbleBy(3, number))
            {
                return "Fizz";
            }
            if (NumberDivisbleBy(5, number))
            {
                return "Buzz";
            }
            return number.ToString();
        }

        private bool NumberDivisbleBy(int divisor, int number )
        {
            return number % divisor == 0;
        }

        public string GetFizBuzzString()
        {
            string fizz = GetFizzBuzzValueFor(1);
            for (int i = 2; i <= 100; i++)
            {
                fizz += "," + GetFizzBuzzValueFor(i);
            }
            return fizz;
        }
    }
}