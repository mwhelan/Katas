using NUnit.Framework;

namespace Katas.Fibonacci
{
    [TestFixture]
    public class FibonacciGeneratorSpecs
    {
        [Test]
        public void FibonacciValueOfZeroShouldBeZero()
        {
            int result = GetFibonacciValueFor(0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void FibonacciValueOfOneShouldBeOne()
        {
            int result = GetFibonacciValueFor(1);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void FibonacciValueOfTwoShouldBeOne()
        {
            int result = GetFibonacciValueFor(2);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void FibonacciValueOfFiveShouldBeFive()
        {
            int result = GetFibonacciValueFor(5);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void FibonacciValueOfEightShouldBeTwentyOne()
        {
            int result = GetFibonacciValueFor(8);
            Assert.AreEqual(21, result);
        }

        private int GetFibonacciValueFor(int number)
        {
            var fg = new FibonacciGenerator();
            return fg.GetFibonacciValueFor(number);
        }
    }
}
