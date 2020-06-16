namespace CodingProblems.Problems
{
   //Given a string, find the length of the longest substring without repeating characters.
   public class LengthOfLongestSubstring
   {
      private const int NumOfChars = 256;

      public static int Run(string s)
      {
         if (string.IsNullOrEmpty(s))
            return 0;

         int strLen = s.Length;

         int currentSubstringLen = 1;
         int maxLen = 1;

         int[] visitedIndexes = new int[NumOfChars];
         for (int i = 0; i < NumOfChars; ++i)
            visitedIndexes[i] = -1;

         visitedIndexes[s[0]] = 0;

         for (int i = 1; i < strLen; ++i)
         {
            int prevIdx = visitedIndexes[s[i]];

            if (prevIdx == -1 || i - currentSubstringLen > prevIdx)
               ++currentSubstringLen;
            else
            {
               if (currentSubstringLen > maxLen)
                  maxLen = currentSubstringLen;

               currentSubstringLen = i - prevIdx;
            }

            visitedIndexes[s[i]] = i;
         }

         if (currentSubstringLen > maxLen)
            maxLen = currentSubstringLen;

         return maxLen;
      }
   }
}
