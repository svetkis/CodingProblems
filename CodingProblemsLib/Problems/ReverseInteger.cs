using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblemsLib.Problems
{
/*  Given a 32-bit signed integer, reverse digits of an integer.

    Example 1:

    Input: 123
    Output: 321
    Example 2:

    Input: -123
    Output: -321
    Example 3:

    Input: 120
    Output: 21
    Note:
    Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range:
    [−2^31,  2^31 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.*/

    public class ReverseInteger
    {
        public static int Reverse(int x)
        {
            bool isNegative = x < 0;
            int current = x / 10;
            int rest = x % 10;
            int newVal = 0;

            while (current != 0 || rest != 0)
            {
                if (!isNegative && (int.MaxValue - rest) / 10 < newVal)
                    return 0;

                if (isNegative && (int.MinValue - rest) / 10 > newVal)
                    return 0;

                newVal = newVal * 10 + rest;

                rest = current % 10;
                current = current / 10;
            }

            return newVal;
        }
    }
}
