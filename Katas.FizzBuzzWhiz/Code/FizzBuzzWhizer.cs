namespace Katas.FizzBuzzWhiz.Code
{
    public class FizzBuzzWhizer
    {
        public string GetFizzBuzzWhizValueFor(int number)
        {
            string fb = string.Empty;
            if (IsDivisbleBy(3, number))
            {
                fb += "Fizz";
            }
            if (IsDivisbleBy(5, number))
            {
                fb += "Buzz";
            }
            if (IsPrime(number))
            {
                fb += "Whiz";
            }

            if (string.IsNullOrEmpty(fb))
            {
                fb = number.ToString();
            }

            return fb;
        }

        private bool IsDivisbleBy(int divisor, int number )
        {
            return number % divisor == 0;
        }

        public bool IsPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }
            if (number == 2 || number ==3 || number == 5 || number == 7)
            {
                return true;
            }
            if (IsEvenNumber(number))
            {
                return false;
            }
            if (IsDivisbleByNumberBetweenThreeAndNine(number))
                return false;
            return true;
        }

        private bool IsDivisbleByNumberBetweenThreeAndNine(int number)
        {
            for (int i = 3; i < 10; i++)
            {
                if (number % i == 0)
                    return true;
            }
            return false;
        }

        private static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }

        public string GetFizBuzzString()
        {
            string fizz = GetFizzBuzzWhizValueFor(1);
            for (int i = 2; i <= 100; i++)
            {
                fizz += "," + GetFizzBuzzWhizValueFor(i);
            }
            return fizz;
        }

    }
}