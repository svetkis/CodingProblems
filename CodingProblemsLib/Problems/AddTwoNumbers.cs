namespace CodingProblemsLib.Problems
{
    public class AddTwoNumbers
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode Run(ListNode l1, ListNode l2)
        {
            SumResult firstResult = Sum(l1, l2);

            ListNode sum = new ListNode(firstResult.Digit);
            int rest = firstResult.Rest;

            ListNode it1 = l1.next;
            ListNode it2 = l2.next;

            ListNode currentListNode = sum;

            while (it1 != null || it2 != null)
            {
                var currentSumResult = Sum(it1, it2, rest);

                rest = currentSumResult.Rest;
                currentListNode.next = new ListNode(currentSumResult.Digit);

                currentListNode = currentListNode.next;
                it1 = it1?.next;
                it2 = it2?.next;
            }

            if (rest != 0)
                currentListNode.next = new ListNode(rest);

            return sum;
        }

        public struct SumResult
        {
            public int Rest;
            public int Digit;
        }

        private static SumResult Sum(ListNode l1, ListNode l2, int rest = 0)
        {
            int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + rest;
            return new SumResult { Digit = sum % 10, Rest = sum / 10 };
        }
    }
}
