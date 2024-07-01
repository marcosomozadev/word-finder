using WordFinderLib;
using WordFinderTests.Helpers;

namespace WordFinderTests
{
    [TestFixture]
    public class WordFinderTests
    {
        [Test]
        public void WordFinder_ValidMatrix128_ThrowArgumentException()
        {
            // Arrange
            const int matrixSize = 128;

            var matrix = WordFinderTestsHelper.GenerateMatrix(matrixSize);

            // Act && Assert
            Assert.Throws<ArgumentException>(() => _ = new WordFinder(matrix));
        }

        [Test]
        public void Find_ValidMatrix_ThreeWordsFound()
        {
            // Arrange
            var matrix = new List<string>
            {
                "abcdc",
                "fgwio",
                "chill",
                "pqnsd",
                "uvdxy"
            };

            var words = new List<string>
            {
                "chill", "cold", "wind", "snow"
            };

            var wordFinder = new WordFinder(matrix);

            // Act
            var results = wordFinder.Find(words).ToList();

            // Assert
            Assert.That(results.Count(), Is.EqualTo(3));
            Assert.That(results, Is.EquivalentTo(new List<string> { "chill", "cold", "wind" }));
        }

        [Test]
        public void WordFinder_InvalidMatrix_ArgumentException()
        {
            // Arrange
            var matrix = new List<string>
            {
                "abcdcz",
                "fgw",
                "chill3",
            };

            // Act && Assert
            Assert.Throws<ArgumentException>(() => _ = new WordFinder(matrix));
        }

        [TestCaseSource(nameof(NullAndEmptyTestCases))]
        public void Find_NullAndEmptyWords_ThrowArgumentNullException(List<string> words)
        {
            // Arrange
            var matrix = new List<string>
            {
                "abc",
                "fgw",
                "chi",
            };

            var wordFinder = new WordFinder(matrix);

            // Act && Assert
            Assert.Throws<ArgumentNullException>(() => wordFinder.Find(words));
        }

        [TestCaseSource(nameof(NullAndEmptyTestCases))]
        public void WordFinder_NullAndEmptyMatrix_ThrowArgumentNullException(List<string> matrix)
        {
            // Act && Assert
            Assert.Throws<ArgumentNullException>(() => _ = new WordFinder(matrix));
        }

        [Test]
        public void Find_ValidMatrix_FiveWordsFound()
        {
            // Arrange
            var matrix = new List<string>
            {
                "abcdc",
                "fgwio",
                "chill",
                "pqnsd",
                "uvdxy",
                "chill"
            };

            var words = new List<string>
            {
                "chill", "cold", "wind", "snow", "chil", "chi"
            };

            var wordFinder = new WordFinder(matrix);

            // Act
            var results = wordFinder.Find(words).ToList();

            // Assert
            Assert.That(results.Count, Is.EqualTo(5));
            Assert.That(results, Is.EquivalentTo(new List<string> { "chill", "chil", "chi", "cold", "wind" }));
        }

        [Test]
        public void Find_ValidMatrix_NoWordsAreFound()
        {
            // Arrange
            var matrix = new List<string>
            {
                "abcdc",
                "fgwio",
                "chill",
                "pqnsd",
                "uvdxy"
            };

            var words = new List<string>
            {
                "child"
            };

            var wordFinder = new WordFinder(matrix);

            // Act
            var results = wordFinder.Find(words).ToList();

            // Assert
            Assert.That(results.Count, Is.EqualTo(0));
        }

        [Test]
        public void Find_ValidMatrixDuplicateWords_OneWordFound()
        {
            // Arrange
            var matrix = new List<string>
            {
                "abcdc",
                "fgwio",
                "chill",
                "pqnsd",
                "chill"
            };

            var words = new List<string>
            {
                "chill"
            };

            var wordFinder = new WordFinder(matrix);

            // Act
            var results = wordFinder.Find(words).ToList();

            // Assert
            Assert.That(results.Count, Is.EqualTo(1));
            Assert.That(results, Is.EquivalentTo(new List<string> { "chill" }));
        }

        [Test]
        public void Find_Valid64X64Matrix_ExpectedWordsFound()
        {
            // Arrange
            var matrix = WordFinderTestsHelper.Matrix64X64;

            var words = new List<string>
            {
                "wind", "yard", "zeal", "yolk", "twig", "soar", "ruby", "pool", "maze", "quartz",
                "silence", "unicorn", "station", "morning", "journey", "guitar", "diamond", "butterfly"
            };

            var wordFinder = new WordFinder(matrix);

            // Act
            var results = wordFinder.Find(words).ToList();

            // Assert
            Assert.That(results.Count, Is.EqualTo(10));
            Assert.That(results,
                Is.EquivalentTo(new List<string>
                    { "wind", "yard", "zeal", "yolk", "twig", "soar", "ruby", "pool", "maze", "quartz" }));
        }

        private static IEnumerable<List<string>?> NullAndEmptyTestCases()
        {
            yield return null; // Test case with null
            yield return new List<string>(); // Test case with empty list
        }
    }
}