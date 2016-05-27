using FluentAssertions;
using NUnit.Framework;

namespace Katas.PrimeNumbers
{
    // Prime numbers: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 
    //  41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97

    [TestFixture]
    public class PrimeNumberSpecs
    {
        private PrimeCalculator SUT;

        [SetUp]
        public void SetUp()
        {
            SUT = new PrimeCalculator();
        }

        [Test]
        public void One_should_return_false()
        {
            SUT.IsPrime(1).Should().BeFalse();
        }

        [Test]
        public void Two_should_return_true()
        {
            SUT.IsPrime(2).Should().BeTrue();
        }

        [Test]
        public void Three_should_return_true()
        {
            SUT.IsPrime(3).Should().BeTrue();
        }

        [Test]
        public void Four_should_return_false()
        {
            SUT.IsPrime(4).Should().BeFalse();
        }
    }
}
