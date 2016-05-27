using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace Katas.WordCounter
{
    [TestFixture]
    public class WordCounterSpecs
    {
        [Test]
        public void empty_string_should_return_empty_collection()
        {
            CountWordsIn("").Should().BeEmpty();
        }

        [Test]
        public void one_word_should_return_word()
        {
            var expected = new Dictionary<string, int> { { "boom", 1 } };
            CountWordsIn("boom").Should().Equal(expected);
        }

        [Test]
        public void different_two_words_should_return_two_words()
        {
            var expected = new Dictionary<string, int> { {"boom", 1}, {"bang", 1} };
            CountWordsIn("boom bang").Should().Equal(expected);
        }

        [Test]
        public void same_two_words_should_return_one_word_with_count_of_2()
        {
            var expected = new Dictionary<string, int> { { "boom", 2 }, { "bang", 1 } };
            CountWordsIn("boom bang boom").Should().Equal(expected);
        }

        [Test]
        public void should_be_able_to_specify_delimiter()
        {
            var expected = new Dictionary<string, int> { { "boom", 2 }, { "bang", 1 } };
            CountWordsIn("boom,bang,boom", ',').Should().Equal(expected);
        }

        private static Dictionary<string, int> CountWordsIn(string input, char delimiter = ' ')
        {
            var counter = new Counter();
            var result = counter.CountWordsIn(input, delimiter);
            return result;
        }
    }
}
