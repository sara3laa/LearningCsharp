using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledwords, string[] wordList)
        {
            var matchedWords = new List<MatchedWord>();

            foreach (var scrambleword in scrambledwords)
            {
                foreach (var word in wordList)
                {
                    if (scrambleword.Equals(word,StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWords.Add(BuildMatchedWord(scrambleword,word));
                    }
                    else
                    {
                        var scrambledWordArray = scrambleword.ToCharArray();
                        var wordArray = word.ToCharArray();
                        Array.Sort(scrambledWordArray);
                        Array.Sort(wordArray);
                        var sortedscarmbledWord = new string(scrambledWordArray);

                        var sortedWord = new string(wordArray);
                        if (sortedscarmbledWord.Equals(sortedWord, StringComparison.OrdinalIgnoreCase))
                        {
                            matchedWords.Add(BuildMatchedWord(scrambleword, word));
                        }
                    }
                }

                
            }
            return matchedWords;

        }

        private MatchedWord BuildMatchedWord(string scrambleword, string word)
        {
            var matchedWord = new MatchedWord
            {
                ScrambledWord =  scrambleword,
                Word = word
            };
            return matchedWord;
        }
    }
}
