using System;
using System.Collections.Generic;
using System.Linq;

namespace WordUnscrambler
{
    class Program
    {
        private  static readonly FileReader FileReader = new FileReader();
        private  static  readonly WordMatcher WordMatcher = new WordMatcher();
      
        static void Main(string[] args)

        {
            try
            {
                var contWordUnscramle = true;
                do
                {
                    Console.WriteLine(Constants.OptionsEnterScramble);
                    var option = Console.ReadLine() ?? string.Empty;
                    switch (option.ToUpper())
                    {
                        case Constants.File:
                            Console.WriteLine(Constants.EnterScrambleViaFile);
                            ExcuteFileScenario();
                            break;
                        case Constants.Manual:
                            Console.WriteLine(Constants.EnterScrambleManually);
                            ExceuteManualScenario();
                            break;
                        default:
                            Console.WriteLine(Constants.EnterScrambleOptionNotReco);

                            break;

                    }

                    var userDecision = string.Empty;
                    do
                    {
                        Console.WriteLine(Constants.OptionsContiunuing);
                        userDecision = Console.ReadLine() ?? string.Empty;
                    } while (!userDecision.Equals(Constants.Yes, StringComparison.OrdinalIgnoreCase) &&
                             !userDecision.Equals(Constants.No, StringComparison.OrdinalIgnoreCase));

                    contWordUnscramle = userDecision.Equals(Constants.Yes, StringComparison.OrdinalIgnoreCase);
                } while (contWordUnscramle);

            }
            catch (Exception e)
            {
                Console.WriteLine(Constants.ErrorTerminate+e.Message);
              
            }
           
        }

        private static void ExcuteFileScenario()
        {
            try
            {
                var filename = Console.ReadLine() ?? string.Empty;
                string[] scrambledwords = FileReader.Read(filename);

                DisplayMatched(scrambledwords);
            }
            catch (Exception e)
            {
                Console.WriteLine(Constants.ErrorScrambleNotloaded + e.Message);
                
            }
            
        }

        private static void ExceuteManualScenario()
        {
            var Input = Console.ReadLine() ?? string.Empty;
            string[] scrambledwords = Input.Split(',');
            DisplayMatched(scrambledwords);
        }

        private static void DisplayMatched(string[] scrambledwords)
        {
            string[] wordList = FileReader.Read(Constants.WordListFileName);
            List<MatchedWord> matchedWords = WordMatcher.Match(scrambledwords,wordList);
            if (matchedWords.Any())
            {
                foreach (var matchWord in matchedWords)
                {
                    Console.WriteLine(Constants.MatchFound,matchWord.ScrambledWord,matchWord.Word );
                    
                }
            }
            else
            {
                Console.WriteLine(Constants.MatchNotFound);   
            }
        }
    }
}
