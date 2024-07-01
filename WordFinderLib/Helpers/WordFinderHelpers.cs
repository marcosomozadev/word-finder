namespace WordFinderLib.Helpers
{
    public static class WordFinderHelpers
    {
        const int MAX_MATRIX_SIZE = 64;

        public static void ValidateMatrix(IEnumerable<string> matrix)
        {
            if (matrix == null || !matrix.Any())
            {
                throw new ArgumentNullException(nameof(matrix), "Matrix cannot be null or empty.");
            }

            if (matrix.Count() > MAX_MATRIX_SIZE || matrix.Any(x => x.Length > MAX_MATRIX_SIZE))
            {
                throw new ArgumentException($"Matrix size cannot exceed the maximum width or height of {MAX_MATRIX_SIZE}");
            }

            var isMatrix = IsMatrix(matrix);
            if (!isMatrix)
            {
                throw new ArgumentException("Input string is not a matrix");
            }
        }

        public static void ValidateWords(IEnumerable<string> words)
        {
            if (words == null || !words.Any())
            {
                throw new ArgumentNullException(nameof(words));
            }
        }

        public static bool IsMatrix(IEnumerable<string> input)
        {
            // Split each string into an array of elements
            var rows = input.ToList();

            // If there are no rows, it's not a matrix
            if (rows.Count == 0)
            {
                return false;
            }

            // Get the number of columns in the first row
            int columnCount = rows[0].Length;

            // Check if all rows have the same number of columns
            foreach (var row in rows)
            {
                if (row.Length != columnCount)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
