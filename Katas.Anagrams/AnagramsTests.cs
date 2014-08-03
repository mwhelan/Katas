using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace Katas.Anagrams
{
    [TestFixture]
    public class AnagramsTests
    {
        [Test]
        public void should_return_empty_string_for_no_characters()
        {
            var expected = new List<string> { "" };
            Anagram.Of("").Should().BeEquivalentTo(expected);
        }

        [Test]
        public void should_return_character_for_one_character()
        {
            var expected = new List<string> {"A"};
            Anagram.Of("A").Should().BeEquivalentTo(expected);
        }

        [Test]
        [TestCase("AB", "AB", "BA")]
        [TestCase("YZ", "YZ", "ZY")]
        public void should_return_two_results_for_two_characters(string testCase, string first, string second)
        {
            var expected = new List<string> { first, second };
            Anagram.Of(testCase).Should().BeEquivalentTo(expected);
        }

        [Test]
        public void should_return_six_results_for_three_characters()
        {
            var expected = new List<string> { "ABC", "ACB", "BAC", "BCA", "CAB", "CBA" };
            Anagram.Of("ABC").Should().BeEquivalentTo(expected);
        } 
    }

    public static class Anagram
    {
        public static List<string> Of(string s)
        {
            if (s.Length <= 1)
                return new List<string> { s };
            var anagrams = new List<string>();
            for (var i = 0; i < s.Length; i++)
            {
                var droppedCharacter = s.Substring(i, 1);
                var anagramsOfRest = Anagram.Of(DropCharacter(s, i));
                foreach (var anagramOfRest in anagramsOfRest)
                    anagrams.Add(droppedCharacter + anagramOfRest);
            }
            return anagrams;
        }
        private static string DropCharacter(string s, int index)
        {
            return s.Substring(0, index) + s.Substring(index + 1, s.Length - (index + 1));
        }
    }
}
