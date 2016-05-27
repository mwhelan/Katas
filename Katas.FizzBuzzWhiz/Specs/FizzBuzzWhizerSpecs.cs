using Katas.FizzBuzzWhiz.Code;
using NUnit.Framework;

namespace Katas.FizzBuzzWhiz.Specs
{
    [TestFixture]
    public class FizzBuzzWhizerSpecs
    {
        [Test]
        public void FizzBuzzWhizValueForOneShouldBeOne()
        {
            Assert.AreEqual("1", GetFizzBuzzWhizValueFor(1));
        }

        [Test]
        public void FizzBuzzWhizValueForTwoShouldBeWhiz()
        {
            Assert.AreEqual("Whiz", GetFizzBuzzWhizValueFor(2));
        }

        [Test]
        public void FizzBuzzWhizValueForThreeShouldBeFizzWhiz()
        {
            Assert.AreEqual("FizzWhiz", GetFizzBuzzWhizValueFor(3));
        }

        [Test]
        public void FizzBuzzWhizValueForFourShouldBeFour()
        {
            Assert.AreEqual("4", GetFizzBuzzWhizValueFor(4));
        }

        [Test]
        [TestCase(5, "BuzzWhiz")]
        [TestCase(6, "Fizz")]
        [TestCase(7, "Whiz")]
        [TestCase(8, "8")]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        public void FizzBuzzValuesShouldBe(int number, string expected)
        {
            Assert.AreEqual(expected, GetFizzBuzzWhizValueFor(number));
        }

        private string GetFizzBuzzWhizValueFor(int number)
        {
            FizzBuzzWhizer fbw = new FizzBuzzWhizer();
            return fbw.GetFizzBuzzWhizValueFor(number);
        }
    }
}
