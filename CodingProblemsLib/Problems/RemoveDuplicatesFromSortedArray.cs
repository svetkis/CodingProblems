using System.Linq;

namespace CodingProblemsLib.Problems
{
    public class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (!nums.Any())
                return 0;

            int count = 1;

            for (int i = 1; i < nums.Count(); ++i)
            {
                if (nums[i] == nums[count - 1])
                    continue;

                nums[count] = nums[i];

                ++count;
            }

            return count;
        }
    }
}
