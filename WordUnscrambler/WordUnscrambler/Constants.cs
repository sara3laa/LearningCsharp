

namespace WordUnscrambler
{
    class Constants
    {
        public const string OptionsEnterScramble = "Enter scrambled word(s) manually or as a file: F- file/M -manual";
        public const string OptionsContiunuing = "Would you like to continue? Y/N";

        public const string EnterScrambleViaFile = "Enter full path including the file name: ";
        public const string EnterScrambleManually = "Enter word(s) manually (separate by commas if multiple):";
        public const string EnterScrambleOptionNotReco = "The option was not recognized.";

        public const string ErrorScrambleNotloaded = "Scrambled words weren't loaded beacuse of an error: ";
        public const string ErrorTerminate = "The program will be terminated: ";

        public const string MatchFound = "MATCH FOUND FOR {0}: {1}";
        public const string MatchNotFound = "NO MATCHES HAVE BEEN FOUND";

        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";

        public const string WordListFileName = "wordlist.txt";
    }
}
