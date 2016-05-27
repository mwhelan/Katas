using FluentAssertions;
using NUnit.Framework;

namespace Katas.FibonacciSequence.Specs
{
    // Given the sequence 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
    // Supplying position 5 would print 3
    [TestFixture]
    public class FibonacciSequenceSpecs
    {
        [Test]
        public void Zero_Should_Return_Zero()
        {
            FibonacciValueFor(0).Should().Be(0);
        }

        [Test]
        public void One_Should_Return_One()
        {
            FibonacciValueFor(1).Should().Be(1);
        }

        [Test]
        public void Two_Should_Return_One()
        {
            FibonacciValueFor(2).Should().Be(1);
        }

        [Test]
        public void Three_Should_Return_Two()
        {
            FibonacciValueFor(3).Should().Be(2);
        }

        [Test]
        public void Nine_should_return_Thirty_Four()
        {
            FibonacciValueFor(9).Should().Be(34);
        }

        private int FibonacciValueFor(int position)
        {
            var generator = new MyLoopFibonacciGenerator();
            return generator.GetNumberFor(position);
        }
    }

    public class MyLoopFibonacciGenerator
    {
        public int GetNumberFor(int position)
        {
            int current = 0;
            int next = 1;

            for (int counter = 0; counter < position; counter++)
            {
                int temp = current;
                current = next;
                next = temp + next;
            }
            return current;
        }
    }

    public class MyRecursiveFibonacciGeneratorLoop
    {
        public int GetNumberFor(int position)
        {
            if (position == 0 || position == 1)
            {
                return position;
            }

            var previous = GetNumberFor(position - 1);
            var oneBeforeThat = GetNumberFor(position - 2);
            return previous + oneBeforeThat;
        }
    }
}
