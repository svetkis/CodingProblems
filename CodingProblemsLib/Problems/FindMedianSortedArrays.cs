namespace CodingProblems.Problems
{
   //There are two sorted arrays nums1 and nums2 of size m and n respectively.
   //Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).
   //You may assume nums1 and nums2 cannot be both empty.

   public class FindMedianSortedArrays
   {
      public static double Run(int[] nums1, int[] nums2)
      {
         int counter1 = 0;
         int counter2 = 0;

         int currentValue = 0;
         int previousValue = 0;

         int num1Count = nums1.Length;
         int num2Count = nums2.Length;
         int totalLength = num1Count + num2Count;

         bool isTotalLengthOdd = totalLength % 2 > 0;

         for (int totalCounter = 0; totalCounter < totalLength / 2 + 1; ++totalCounter)
         {
            previousValue = currentValue;

            if (counter1 >= num1Count)
            {
               currentValue = nums2[counter2++];
               continue;
            }

            if (counter2 >= num2Count)
            {
               currentValue = nums1[counter1++];
               continue;
            }

            currentValue = nums1[counter1] <= nums2[counter2] ? nums1[counter1++] : nums2[counter2++];
         }

         return isTotalLengthOdd ? currentValue : (currentValue + previousValue) / 2.0;
      }
   }
}
