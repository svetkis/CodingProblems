using System.Collections.Generic;
using System.Linq;
using CodingProblemsLib.Problems;
using Xunit;

namespace CodingProblemsTests
{
    public static class ListNodeExtension
    {
        public static int[] ToArray(this AddTwoNumbers.ListNode node)
        {
            List<int> list = new List<int>();

            AddTwoNumbers.ListNode currentNode = node;
            while (currentNode != null)
            {
                list.Add(currentNode.val);
                currentNode = currentNode.next;
            }

            return list.ToArray();
        }
    }
}
