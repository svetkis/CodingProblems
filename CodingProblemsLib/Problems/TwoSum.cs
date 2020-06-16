namespace CodingProblemsLib.Problems
{
    public class TwoSum
    {
        //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        public static int[] Run(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; ++i)
            {
                for (int j = i + 1; j < nums.Length; ++j)
                {
                    if (nums[i] + nums[j] == target)
                        return new[] { i, j };
                }
            }

            return new[] { 0, 0 };
        }
    }
}
