using System;
using FluentAssertions;
using NUnit.Framework;

namespace Katas.StringCalculator
{
//    An empty string returns zero
//A single number returns the value
//Two numbers, comma delimited, returns the sum
//Two numbers, newline delimited, returns the sum
//Three numbers, delimited either way, returns the sum
//Negative numbers throw an exception
//Numbers greater than 1000 are ignored
//A single char delimiter can be defined on the first line (e.g. //# for a ‘#’ as the delimiter)
//A multi char delimiter can be defined on the first line (e.g. //[###] for ‘###’ as the delimiter)
//Many single or multi-char delimiters can be defined (each wrapped in square brackets)

    [TestFixture]
    public class StringCalculatorSpecs
    {
        [Test]
        public void Empty_string_should_return_zero()
        {
            Calculate("").Should().Be(0);
        }

        [Test]
        public void Single_number_should_return_its_value()
        {
            Calculate("5").Should().Be(5);
        }

        [Test]
        public void Two_comma_delimited_numbers_returns_the_sum()
        {
            Calculate("7,4").Should().Be(11);
        }

        [Test]
        public void Two_newline_delimited_numbers_returns_the_sum()
        {
            Calculate("5\n7").Should().Be(12);
        }

        [Test]
        public void Three_numbers_delimited_either_way_returns_the_sum()
        {
            Calculate("5\n7,119").Should().Be(131);
        }

        [Test]
        public void Any_negative_number_throws_an_exception()
        {
            Action action = () => Calculate("5\n7,-3");
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void Numbers_greater_than_1000_are_ignored()
        {
            Calculate("5\n7,1001").Should().Be(12);
        }

        [Test]
        public void Single_custom_delimiter_can_be_applied()
        {
            Calculate("//;\n1;2").Should().Be(3);
        }

        //[Test]
        //public void Multi_custom_delimiters_can_be_applied()
        //{
        //    Calculate("//[###]\n1###2").Should().Be(3);
        //}
        
        private int Calculate(string numbers)
        {
            var calculator = new Calculator();
            return calculator.Add(numbers);
        }
    }
}
