using Leetcode.Common;

namespace Leetcode.Problem2
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode returnedList = new ListNode();

            returnedList.val = l1.val + l2.val;

            if (l1.next == null && l2.next == null)
            {
                return ValueCheck(returnedList);
            }

            l1.next ??= new ListNode();
            l2.next ??= new ListNode();

            returnedList.next = AddTwoNumbers(l1.next, l2.next);

            return ValueCheck(returnedList);
        }

        private static ListNode ValueCheck(ListNode node)
        {
            if (node.val >= 10)
            {
                node.next ??= new ListNode(0);

                node.next.val += 1;
                node.val -= 10;

                ValueCheck(node.next);
            }

            return node;
        }
    }
}
