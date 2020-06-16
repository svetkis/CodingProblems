using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodingProblemsLib.Problems;
using CodingProblemsTests;
using NUnit.Framework;
using ListNode = CodingProblemsLib.Problems.AddTwoNumbers.ListNode;

namespace CodingProblemsTests
{
    public static class ListNodeExtension
    {
        public static int[] ToArray(this ListNode node)
        {
            List<int> list = new List<int>();

            ListNode currentNode = node;
            while (currentNode != null)
            {
                list.Add(currentNode.val);
                currentNode = currentNode.next;
            }

            return list.ToArray();
        }
    }

    public class AddTwoNumbersTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new[] {2, 4, 3}, new[] {5, 6, 4}, new[] {7, 0, 8})]
        public void Test(int[] arr1, int[] arr2, int[] result)
        {
            var res = AddTwoNumbers.Run(CreateListNode(arr1), CreateListNode(arr2)).ToArray();
            Assert.AreEqual(res, result);
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