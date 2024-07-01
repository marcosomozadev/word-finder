using CommandLine;

namespace WordFinderConsole.Helpers
{
    public class WordFinderConsoleArgs
    {
        [Option('m', "matrix-file", Default = ".//Files//matrix.txt", HelpText = "File containing a character matrix",
            Required = true)]
        public required string MatrixFile { get; set; }

        [Option('w', "words-file", Default = ".//Files//words.txt",
            HelpText = "File containing a words to find file (Seperated by a comma)", Required = true)]
        public required string WordsFile { get; set; }
    }
}