using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblemsLib.Problems
{
    public class RemoveKDigits
    {
        public static string RemoveKdigits(string num, int k)
        {
            int numbersCount = num.Length;
            Stack<int> stack = new Stack<int>();
            int[] numbers = num.ToCharArray().Select(ch => ch - '0').ToArray();

            for (int i = 0; i < numbersCount; ++i)
            {
                int s = numbers[i];
                while (k > 0 && stack.Any() && stack.Peek() > s)
                {
                    stack.Pop();
                    --k;
                }

                stack.Push(s);
            }

            while (k > 0 && stack.Any())
            {
                stack.Pop();
                --k;
            }

            StringBuilder sb = new StringBuilder();
            while (stack.Any())
                sb.Insert(0, stack.Pop());

            int j = 0;
            int len = sb.Length;
            while (j < len && numbers[j] == 0)
                ++j;

            return j == len ? "0" : sb.ToString().Substring(j);
        }
    }
}
