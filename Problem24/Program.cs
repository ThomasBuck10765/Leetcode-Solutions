using Leetcode.Common;

namespace Leetcode.Problem24
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static ListNode SwapPairs(ListNode head)
        {
            if (head?.next == null)
            {
                return head;
            }

            var nextNode = head.next;

            head.next = SwapPairs(nextNode.next);
            nextNode.next = head;

            head = nextNode;

            return head;
        }
    }
}
