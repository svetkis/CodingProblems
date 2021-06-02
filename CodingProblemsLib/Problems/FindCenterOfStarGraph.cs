using System.Threading;

namespace CodingProblemsLib.Problems
{
    public class FindCenterOfStarGraph
    {
        public int FindCenter(int[][] edges)
        {
            var e1 = edges[0];
            var e2 = edges[1];

            return e1[0] == e2[0] || e1[0] == e2[1] ? e1[0] : e1[1];
        }
    }
}
