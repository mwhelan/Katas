using Katas.FizzBuzz.Code;
using NUnit.Framework;

namespace Katas.FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzzValueForOneShouldBeOne()
        {
            Assert.AreEqual("1", GetFizzBuzzValueFor(1));
        }

        [Test]
        public void FizzBuzzValueForTwoShouldBeTwo()
        {
            Assert.AreEqual("2", GetFizzBuzzValueFor(2));
        }

        [Test]
        public void FizzBuzzValueForThreeShouldBeFizz()
        {
            Assert.AreEqual("Fizz", GetFizzBuzzValueFor(3));
        }

        [Test]
        public void FizzBuzzValueForFiveShouldBeBuzz()
        {
            Assert.AreEqual("Buzz", GetFizzBuzzValueFor(5));
        }

        [Test]
        public void FizzBuzzValueForSixShouldBeFizz()
        {
            Assert.AreEqual("Fizz", GetFizzBuzzValueFor(6));
        }

        [Test]
        public void FizzBuzzValueForTenShouldBeBuzz()
        {
            Assert.AreEqual("Buzz", GetFizzBuzzValueFor(10));
        }

        [Test]
        public void FizzBuzzValueForFifteenShouldBeFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", GetFizzBuzzValueFor(15));
        }

        [Test]
        public void FizzBuzzPrintOutShouldStartWithOne()
        {
            Assert.That(GetFizzBuzzString().StartsWith("1"));
        }

        [Test]
        public void FizzBuzzStringShouldStartWithOneCommaTwoCommaFizz()
        {
            Assert.That(GetFizzBuzzString().StartsWith("1,2,Fizz"));
        }

        [Test]
        public void FizzBuzzStringShouldEndWithNinetyEightCommaFizzCommaBuzz()
        {
            Assert.That(GetFizzBuzzString().EndsWith("98,Fizz,Buzz"));
        }

        private string GetFizzBuzzString()
        {
            return new FizzBuzzer().GetFizBuzzString();
        }

        private string GetFizzBuzzValueFor(int number)
        {
            FizzBuzzer fb = new FizzBuzzer();
            return fb.GetFizzBuzzValueFor(number);
        }
    }
}
