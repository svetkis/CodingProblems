using System.Collections.Generic;
using System.Linq;

namespace CodingProblemsLib.Problems
{
    public class GroupPeopleGivenGroupSizeTheyBelongTo
    {
        public IList<IList<int>> Run(int[] groupSizes)
        {
            IList<IList<int>> result = new List<IList<int>>();

            var groups = groupSizes.Select((x, i) => new {Idx = i, CountInGroup = x}).GroupBy(v => v.CountInGroup);
            foreach (var group in groups)
            {
                var count = group.Key;
                var value = group.ToList();

                for (int i = 0; i < value.Count / count; ++i)
                {
                    result.Add(new List<int>());
                    for (int j = i * count; j < (i + 1) * count; ++j)
                    {
                        result.Last().Add(value[j].Idx);
                    }
                }
            }

            return result;
        }
    }
}
