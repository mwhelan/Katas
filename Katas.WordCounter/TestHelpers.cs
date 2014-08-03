using System.Linq;
using FluentAssertions;

namespace Katas.WordCounter
{
    public static class TestHelpers
    {
        public static void ShouldEqual(this string input, dynamic[] expected, char delimiter = ' ')
        {
            new Counter()
                .CountWordsIn(input, delimiter)
                .Should()
                .Equal(expected.ToDictionary(item => (string)item[0], item => (int)item[1]));
        }
    }
}