using System;
using System.Text;

namespace CodingProblemsLib.Problems
{
    public class FindAndReplaceInString
    {
        public static string Run(string s, int[] indices, string[] sources, string[] targets)
        {
            int idx = 0;
            StringBuilder sb = new StringBuilder();
            while (idx < s.Length)
            {
                int replaceIdx = Array.IndexOf(indices, idx);
                if (replaceIdx == -1)
                {
                    sb.Append(s[idx++]);
                    continue;
                }

                int len = sources[replaceIdx].Length;
                if (0 == string.CompareOrdinal(s.Substring(idx, len), sources[replaceIdx]))
                {
                    sb.Append(targets[replaceIdx]);
                    idx += len;
                }
                else
                {
                    sb.Append(s[idx++]);
                }
            }

            return sb.ToString();
        }
    }
}
