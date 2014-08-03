using System.Collections.Generic;

namespace Katas.WordCounter
{
    public class Counter
    {
        public Dictionary<string, int> CountWordsIn(string input, char delimiter = ' ')
        {
            var registry = new Dictionary<string, int>();
            if (string.IsNullOrEmpty(input))
            {
                return registry;
            }

            var words = input.Split(delimiter);
            foreach (var word in words)
            {
                if(registry.ContainsKey(word))
                {
                    registry[word] = registry[word] + 1;
                }
                else
                {
                    registry.Add(word, 1);
                }
            }

            return registry;
        }
    }
}