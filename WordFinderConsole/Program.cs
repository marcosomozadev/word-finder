using CommandLine;
using Humanizer;
using System.Diagnostics;
using WordFinderConsole.Helpers;

namespace WordFinderConsole
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Parser.Default.ParseArguments<WordFinderConsoleArgs>(args)
                .WithParsed(RunOptions)
                .WithNotParsed(HandleParseError);
        }

        private static void RunOptions(WordFinderConsoleArgs opts)
        {
            var characterMatrixFile = opts.MatrixFile;
            var wordsFile = opts.WordsFile;

            Console.WriteLine("####### WordFinder ###########");

            try
            {
                if (File.Exists(characterMatrixFile) && File.Exists(wordsFile))
                {
                    var characterLines = File.ReadAllLines(characterMatrixFile);

                    Console.WriteLine($"Character matrix file {characterMatrixFile} processed successfully");

                    var wordsToFindLines = File.ReadAllLines(wordsFile);
                    var wordsToFind = wordsToFindLines[0].Split(',');

                    Console.WriteLine($"Words file {wordsFile} processed successfully.");

                    Console.WriteLine("Finding words...");

                    var stopwatch = new Stopwatch();
                    stopwatch.Start();

                    var finder = new WordFinderLib.WordFinder(characterLines);
                    var wordResults = finder.Find(wordsToFind).ToList();

                    stopwatch.Stop();

                    Console.WriteLine($"Elapsed time {stopwatch.Elapsed.TotalMilliseconds} ms");
                    Console.WriteLine(
                        $"These are the top {wordResults.Count} most repeated words: {wordResults.Humanize()}");
                    Console.WriteLine("Printing matrix with highlighted words...");

                    Console.WriteLine("");

                    WordHighlighter.PrintMatrixWithHighlightedWords(characterLines.ToList(), wordResults);

                    Console.WriteLine("");

                    Console.WriteLine("Thanks for using the word finder tool. Press a key to exit.");

                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(
                        $"One of the following files does not exist {characterMatrixFile} or {wordsFile}. Please provide existing files.");
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.ResetColor();
            }
        }

        private static void HandleParseError(IEnumerable<Error> errs)
        {
            foreach (var err in errs)
            {
                Console.WriteLine(err.ToString());
            }
        }
    }
}