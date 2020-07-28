namespace CodingProblemsLib.Problems
{
    //https://leetcode.com/problems/palindrome-number/
    //Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
    //Example 1:
    //Input: 121
    //Output: true
    //Example 2:
    //
    //Input: -121
    //Output: false
    //Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
    //
    //Example 3:
    //Input: 10
    //Output: false
    //Explanation: Reads 01 from right to left.Therefore it is not a palindrome.

    public class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            if (x == 0)
                return true;

            if (x % 10 == 0)
                return false;

            int current = x;
            int reverted = 0;

            while (current > 0)
            {
                reverted = reverted*10 + current % 10;
                current /= 10;
            }

            return reverted == x;
        }
    }
}