using System.Linq;
using CodingProblemsLib.Problems;
using Xunit;
using ListNode = CodingProblemsLib.Problems.AddTwoNumbers.ListNode;

namespace CodingProblemsTests
{
    public class AddTwoNumbersTest
    {
        [Theory]
        [InlineData(new[] {2, 4, 3}, new[] {5, 6, 4}, new[] {7, 0, 8})]
        public void Test(int[] arr1, int[] arr2, int[] result)
        {
            var res = AddTwoNumbers.Run(CreateListNode(arr1), CreateListNode(arr2)).ToArray();
            Assert.Equal(res, result);
        }

        private ListNode CreateListNode(int[] intArray)
        {
            ListNode head = new ListNode(intArray.First());
            ListNode currentNode = head;
            for (int i = 1; i < intArray.Length; ++i)
            {
                currentNode.next = new ListNode(intArray[i]);
                currentNode = currentNode.next;
            }

            return head;
        }
    }
}