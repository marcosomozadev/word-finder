using System.Drawing;
using System.Text;
using Console = Colorful.Console;

namespace WordFinderConsole.Helpers;

public static class WordHighlighter
{
    public static void PrintMatrixWithHighlightedWords(IList<string> matrix, IEnumerable<string> words)
    {
        var wordsList = words.ToList();
        var rowLength = matrix.Count;
        var colLength = matrix[0].Length;

        // Create a copy of the matrix to mark the found words
        var highlightedMatrix = matrix.Select(row => new StringBuilder(row)).ToList();

        foreach (var word in wordsList)
        {
            // Highlight horizontal sequences
            for (var row = 0; row < rowLength; row++)
            {
                HighlightWordInSequence(highlightedMatrix[row], word);
            }

            // Highlight vertical sequences
            for (var col = 0; col < colLength; col++)
            {
                var columnSequence = new StringBuilder();
                for (var row = 0; row < rowLength; row++)
                {
                    columnSequence.Append(highlightedMatrix[row][col]);
                }

                HighlightWordInSequence(columnSequence, word);

                // Apply the highlighted column back to the matrix
                for (var row = 0; row < rowLength; row++)
                {
                    highlightedMatrix[row][col] = columnSequence[row];
                }
            }
        }

        // Print the highlighted matrix
        foreach (var row in highlightedMatrix)
        {
            foreach (var ch in row.ToString())
            {
                if (char.IsUpper(ch))
                {
                    Console.Write(ch, Color.CornflowerBlue); // Highlighted character
                }
                else
                {
                    Console.Write(ch); // Regular character
                }
            }

            Console.WriteLine();
        }
    }

    private static void HighlightWordInSequence(StringBuilder sequence, string word)
    {
        var position = 0;

        while ((position = sequence.ToString().IndexOf(word, position, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            for (var i = 0; i < word.Length; i++)
            {
                sequence[position + i] =
                    char.ToUpper(sequence[position + i]); // Highlight by converting to uppercase
            }

            position += word.Length; // Move position to end of the matched pattern
        }
    }
}