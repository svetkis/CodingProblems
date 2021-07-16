using System.Collections.Generic;
using System.Linq;

namespace CodingProblemsLib.Problems
{
    public class ValidParentheses
    {
        private Dictionary<char, char> parentheses = new Dictionary<char, char>
        {
            {'(', ')' },
            {'[', ']' },
            {'{', '}' },
        };

        public bool IsValid(string s)
        {
            Stack<char> states = new Stack<char>();
            for (var idx = 0; idx < s.Length; ++idx)
            {
                var symbol = s[idx];
                if (parentheses.ContainsKey(symbol))
                {
                    states.Push(symbol);
                    continue;
                }

                if (!parentheses.ContainsValue(symbol))
                    continue;

                if (!states.Any() || parentheses[states.Pop()] != symbol)
                    return false;
            }

            return !states.Any();
        }
    }
}
