/*The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

   P   A   H   N
   A P L S I I G
   Y   I   R
   And then read line by line: "PAHNAPLSIIGYIR"

   Write the code that will take a string and make this conversion given a number of rows:

   string convert(string s, int numRows);
   Example 1:

   Input: s = "PAYPALISHIRING", numRows = 3
   Output: "PAHNAPLSIIGYIR"
   Example 2:

   Input: s = "PAYPALISHIRING", numRows = 4
   Output: "PINALSIGYAHRPI"
   Explanation:

   P     I    N
   A   L S  I G
   Y A   H R
   P     I*/

using System.Linq;

namespace CodingProblemsLib.Problems
{
    public class ZigZag
    {
        public static string Convert(string s, int numRows)
        {
            int patternLen = numRows > 1 ? numRows * 2 - 2 : 1;

            int[] indices = new int[s.Length];
            int idx = 0;
            for (int row = 0; row < numRows; ++row)
            {
                if (row == 0 || row == numRows - 1)
                {
                    int currIdx = row;
                    while (currIdx < s.Length)
                    {
                        indices[idx] = currIdx;
                        ++idx;
                        currIdx += patternLen;
                    }

                    continue;
                }

                int currentIdx = row;
                int idx1 = 0;
                int firstDist = patternLen - 2 * row;
                int secondDist = patternLen - firstDist;
                while (currentIdx < s.Length)
                {
                    indices[idx] = currentIdx;
                    ++idx;

                    currentIdx += idx1 % 2 == 0 ? firstDist : secondDist;
                    ++idx1;
                }
            }

            return string.Join("", indices.Select(i => s[i]));
        }
    }
}
