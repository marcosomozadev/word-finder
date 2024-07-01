# WordFinder

Word search library using **net8.0** designed to search for specified words within a matrix of strings, both horizontally and vertically, and return the top 10 most frequently found unique words.

### Details

Word search can find words from left to right or from top to bottom on a 2D character matrix.

* **Flattening:** Converts the 2D matrix into a list of strings representing rows and columns.

* **Searching:** Performs case-insensitive search for each word in both horizontal and vertical character sequences.

* **Sorting:** Returns the top 10 most repeated unique words based on the frequency they are found.
*  **Validation:** Validates the provided matrix and word list.

Used `HashSet` to remove duplicate words and `Dictionary<string, int>` to store the word occurences found. Since, the comparisons needed are from left to right and top to bottom,  decided to convert the matrix into a list of character sequences to be able to compare the vertical sequences as horizontal sequences. Used `string.IndexOf` to compare each instance of a word on a given character sequence.

### Run
`WordFinderConsole` is a console app to execute the WordFinder library methods and highlight the found words.
To run the application, use the following command lines arguments:

    .\WordFinderConsole -m <matrix-file-path> -w <words-file-path>

The following files are included and used for debug launch configs:

* `matrix.txt` contains a 5x5 character matrix used in combination with `words.txt` that  contains a 4 comma seperated word list.

* `matrix64x64.txt` contains a 64x64 character matrix used in combination with `words64x64.txt` that contains a 26 comma seperated word list.

### Performance

* **Matrix 5x5:** searching for 4 words has an execution time of 7.244 ms.

* **Matrix 64x64:** searching for 26 words has an execution time of 7.3854 ms.
  
  
### Testing
Included a unit testing project `WordFinderTests` using NUnit for code test coverage.
