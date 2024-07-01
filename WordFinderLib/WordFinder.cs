using System.Text;
using WordFinderLib.Helpers;

namespace WordFinderLib
{
    public class WordFinder
    {
        private readonly List<string> _matrix;

        public WordFinder(IEnumerable<string> matrix)
        {
            var matrixList = matrix.ToList();
            WordFinderHelpers.ValidateMatrix(matrixList);
            _matrix = matrixList;
        }

        public IEnumerable<string> Find(IEnumerable<string> wordStream)
        {
            var wordsList = wordStream.ToList();
            WordFinderHelpers.ValidateWords(wordsList);

            var distinctWords = new HashSet<string>(wordsList); // Remove duplicates

            var wordCount = new Dictionary<string, int>();

            var flattenedMatrix = FlattenMatrix();

            foreach (var word in distinctWords)
            {
                var count = flattenedMatrix.Sum(sequence => CountWordOccurrences(sequence, word));

                if (count > 0)
                {
                    wordCount[word] = count;
                }
            }

            // Convert dictionary to list and sort by frequency (descending)
            var sortedWords = wordCount.OrderByDescending(pair => pair.Value)
                .Select(pair => pair.Key)
                .ToList();

            // Return up to top 10 most repeated unique words
            return sortedWords.Take(10).ToList();
        }

        private List<string> FlattenMatrix()
        {
            var rowLength = _matrix.Count;
            var colLength = _matrix[0].Length;
            var sequences = new List<string>();

            // Add horizontal sequences
            sequences.AddRange(_matrix);

            // Add vertical sequences
            var columnSequence = new StringBuilder();
            for (var col = 0; col < colLength; col++)
            {
                columnSequence.Clear();
                for (var row = 0; row < rowLength; row++)
                {
                    columnSequence.Append(_matrix[row][col]);
                }

                sequences.Add(columnSequence.ToString());
            }

            return sequences;
        }

        private static int CountWordOccurrences(string sequence, string word)
        {
            var count = 0;
            var position = 0;

            // Use StringComparison.OrdinalIgnoreCase to perform case-insensitive search
            while ((position = sequence.IndexOf(word, position, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                position += word.Length; // Move position to end of the matched pattern
            }

            return count;
        }
    }
}