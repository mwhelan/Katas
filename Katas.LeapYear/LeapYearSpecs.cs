using FluentAssertions;
using NUnit.Framework;

namespace Katas.LeapYear
{
    public class LeapYearSpecs
    {
        [Test]
        public void NormalLeapYearShouldBeLeapYear()
        {
            1996.IsLeapYear().Should().BeTrue();
        }

        [Test]
        public void NormalCommonYearShouldNotBeLeapYear()
        {
            2001.IsLeapYear().Should().BeFalse();
        }

        [Test]
        public void SpecialCommonYearShouldNotBeLeapYear()
        {
            1900.IsLeapYear().Should().BeFalse();
        }

        [Test]
        public void SpecialLeapYearShouldNotBeLeapYear()
        {
            2000.IsLeapYear().Should().BeTrue();
        }
    }
}
