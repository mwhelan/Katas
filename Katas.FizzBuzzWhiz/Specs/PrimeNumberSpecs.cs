using Katas.FizzBuzzWhiz.Code;
using NUnit.Framework;

namespace Katas.FizzBuzzWhiz.Specs
{
    [TestFixture]
    public class PrimeNumberSpecs
    {
        [Test]
        public void OneShouldNotBePrimeNumber()
        {
            Assert.IsFalse(new FizzBuzzWhizer().IsPrime(1));
        }

        [Test]
        public void TwoShouldBePrimeNumber()
        {
            Assert.IsTrue(new FizzBuzzWhizer().IsPrime(2));
        }

        [Test]
        public void EvenNumbersShouldNotBePrimeNumbers()
        {
            Assert.IsFalse(new FizzBuzzWhizer().IsPrime(4));
        }

        [Test]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5, Description="It was 5")]
        [TestCase(7, Description = "It was 7")]
        [TestCase(11, Description = "It was 11")]
        [TestCase(13, Description = "It was 13")]
        [TestCase(17, Description = "It was 17")]
        [TestCase(19, Description = "It was 19")]
        [TestCase(23, Description = "It was 23")]
        [TestCase(29, Description = "It was 29")]
        [TestCase(31, Description = "It was 31")]
        [TestCase(37, Description = "It was 37")]
        [TestCase(41, Description = "It was 41")]
        [TestCase(43, Description = "It was 43")]
        [TestCase(47, Description = "It was 47")]
        [TestCase(53, Description = "It was 53")]
        [TestCase(59, Description = "It was 59")]
        [TestCase(61, Description = "It was 61")]
        [TestCase(67, Description = "It was 67")]
        [TestCase(71, Description = "It was 71")]
        [TestCase(73, Description = "It was 73")]
        [TestCase(79, Description = "It was 79")]
        [TestCase(83, Description = "It was 83")]
        [TestCase(89, Description = "It was 89")]
        [TestCase(97, Description = "It was 97")]
        public void PrimeNumbersShouldBePrimeNumbers(int number)
        {
            Assert.IsTrue(new FizzBuzzWhizer().IsPrime(number));
        }

        [Test]
        [TestCase(9, Description = "It was 9")]
        [TestCase(21, Description = "It was 21")]
        [TestCase(27, Description = "It was 27")]
        public void ShouldNotBePrimeNumbers(int number)
        {
            Assert.IsFalse(new FizzBuzzWhizer().IsPrime(number));
        }
    }
}
