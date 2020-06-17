namespace CodingProblemsLib.Problems
{
    public class LongestPalindrome
    {
        public static string Run(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            int palindromeLen = 1;
            int palindromeStartIdx = 0;

            for (int i = 0; i < s.Length - palindromeLen/2; ++i)
            {
                //odd palindrome
                int addLen = 1;
                while (i - addLen >= 0 && i + addLen < s.Length)
                {
                    if (s[i - addLen] != s[i + addLen])
                        break;

                    if (palindromeLen < addLen * 2 + 1)
                    {
                        palindromeLen = addLen * 2 + 1;
                        palindromeStartIdx = i - addLen;
                    }

                    ++addLen;
                }

                //even palindrome
                if (i + 1 >= s.Length || s[i] != s[i+1])
                    continue;

                if (palindromeLen < 2)
                {
                    palindromeLen = 2;
                    palindromeStartIdx = i;
                }

                addLen = 1;
                while (i - addLen >= 0 && i + 1 + addLen < s.Length)
                {
                    if (s[i - addLen] != s[i + 1 + addLen])
                        break;

                    if (palindromeLen < addLen * 2 + 2)
                    {
                        palindromeLen = addLen * 2 + 2;
                        palindromeStartIdx = i - addLen;
                    }

                    ++addLen;
                }
            }

            return s.Substring(palindromeStartIdx, palindromeLen);
        }
    }
}
